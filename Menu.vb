Imports System.Text.RegularExpressions
Public Class Menuform
    Private DB As New DBAccess

    Public Property MenuCount As Object

    Private Sub MenuHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNameLabel.Text = strStaffName
        DB.ExecuteQuery("Select * From menu")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MenuDataGridView.DataSource = DB.DBDataTable
        MenuCount1.Text = "Menu #:" & DB.RecordCount.ToString

        MenuDataGridView.ReadOnly = True
        MenuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SearchMenu(ItemName As String)
        DB.AddParam("@item_name", ItemName & "%")

        DB.ExecuteQuery("SELECT * FROM menu WHERE Item_Name LIKE ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MenuDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub MenuNamesTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchMenuItemNameTextBox.KeyUp
        SearchMenu(SearchMenuItemNameTextBox.Text)
    End Sub

    Private Sub MenuDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MenuDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = MenuDataGridView.Rows.Count - 1 Then
            ClearMenuDetails()
            Exit Sub
        Else
            MenuIDTextBox.Text = MenuDataGridView.Rows(e.RowIndex).Cells(0).Value
            CategoryIDTextBox.Text = MenuDataGridView.Rows(e.RowIndex).Cells(1).Value
            ItemNameTextBox.Text = MenuDataGridView.Rows(e.RowIndex).Cells(2).Value
            If IsDBNull(MenuDataGridView.Rows(e.RowIndex).Cells(3).Value) Then
                PriceTextBox.Text = String.Empty
            Else
                PriceTextBox.Text = MenuDataGridView.Rows(e.RowIndex).Cells(3).Value
            End If
            DescriptionTextBox.Text = MenuDataGridView.Rows(e.RowIndex).Cells(4).Value
            MenuCheckBox.Checked = MenuDataGridView.Rows(e.RowIndex).Cells(6).Value
            ' MenuLastUpdateDateTimePicker.Value = MenuDataGridView.Rows(e.RowIndex).Cells(9).Value

        End If
    End Sub

    Private Sub EnableMenuFieldsforEdit(Switch As Boolean)
        MenuIDTextBox.Enabled = False
        CategoryIDTextBox.Enabled = Switch
        ItemNameTextBox.Enabled = Switch
        PriceTextBox.Enabled = Switch
        DescriptionTextBox.Enabled = Switch
        MenuCheckBox.Enabled = Switch
        MenuLastUpdateDateTimePicker.Enabled = False 'TimeStamp field with auto update turned on. 

        If Switch = True Then
            MenuEditSaveButton.Text = "Save"
            NewMenuButton.Enabled = False
        Else
            MenuEditSaveButton.Text = "Edit"
            NewMenuButton.Enabled = True
        End If
    End Sub

    Private Sub ClearMenuDetails()
        MenuIDTextBox.Clear()
        CategoryIDTextBox.Clear()
        ItemNameTextBox.Clear()
        PriceTextBox.Clear()
        DescriptionTextBox.Clear()
        MenuCheckBox.Checked = False
        MenuLastUpdateDateTimePicker.Value = Today.Date
    End Sub

    Private Sub CusClearButton_Click(sender As Object, e As EventArgs) Handles MenuClearButton.Click
        ClearMenuDetails()
    End Sub

    Private Sub NewCusButton_Click(sender As Object, e As EventArgs) Handles NewMenuButton.Click
        ClearMenuDetails()
        EnableMenuFieldsforEdit(True)
    End Sub

    Private Sub MenuCancelButton_Click(sender As Object, e As EventArgs) Handles MenuCancelButton.Click
        MenuIDTextBox.Undo()
        CategoryIDTextBox.Undo()
        ItemNameTextBox.Undo()
        PriceTextBox.Undo()
        DescriptionTextBox.Undo()
        EnableMenuFieldsforEdit(False)
    End Sub

    Private Sub MenuEditSaveButton_Click(sender As Object, e As EventArgs) Handles MenuEditSaveButton.Click
        If MenuEditSaveButton.Text = "Edit" Then
            'edit mode
            EnableMenuFieldsforEdit(True)
        Else

            If String.IsNullOrWhiteSpace(MenuIDTextBox.Text) Then
                'add a new record
                AddNewMenu()
            Else
                'update an existing record
                UpdateMenu()
            End If
            SearchMenu(SearchMenuItemNameTextBox.Text) 'Refreshing the data grid view

            EnableMenuFieldsforEdit(False)
        End If
    End Sub

    Private Sub MenuDeleteButton_Click(sender As Object, e As EventArgs) Handles MenuDeleteButton.Click
        Dim aDialogResult As DialogResult

        aDialogResult = MessageBox.Show("Do you want to delete menu " & ItemNameTextBox.Text & "(#" & MenuIDTextBox.Text & ") record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then

            Exit Sub
        Else

            DB.AddParam("@Customer_id", MenuIDTextBox.Text)
            DB.ExecuteQuery("DELETE FROM menu WHERE item_id = ?")
            If DB.DBException <> String.Empty Then
                MessageBox.Show(DB.DBException)
                Exit Sub
            End If

            MessageBox.Show("The selected record has been deleted successfully")
            MenuIDTextBox.Clear()
            CategoryIDTextBox.Clear()
            ItemNameTextBox.Clear()
            PriceTextBox.Clear()
            DescriptionTextBox.Clear()
            MenuCheckBox.Checked = False
            MenuLastUpdateDateTimePicker.Value = Today.Date

            SearchMenu(SearchMenuItemNameTextBox.Text)
        End If
    End Sub

    Private Sub AddNewMenu()
        If ValidateMenu() = False Then
            Exit Sub
        End If

        DB.AddParam("@Category_ID", CategoryIDTextBox.Text)
        DB.AddParam("@Item_Name", ItemNameTextBox.Text)
        DB.AddParam("@Price", PriceTextBox.Text)
        DB.AddParam("@Description", DescriptionTextBox.Text)
        DB.AddParam("@Active", MenuCheckBox.Checked)
        DB.AddParam("@Last_update", MenuLastUpdateDateTimePicker.Value)

        DB.ExecuteQuery("INSERT INTO menu(category_id, item_Name, price, description, is_active, updated_on, created_by) VALUES(?,?,?,?,?,?, 2)")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("A new menu is added successfully.")

        DB.AddParam("@Item_Name", ItemNameTextBox.Text)
        DB.ExecuteQuery("select item_id AS Last_menu_id FROM menu WHERE item_name = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)

            Exit Sub

        End If

        Dim newest_menu_id As Integer
        newest_menu_id = DB.DBDataTable(0)(0)

        MessageBox.Show(" The new menu ID is" & newest_menu_id)

    End Sub

    Private Sub UpdateMenu()
        If ValidateMenu() = False Then
            Exit Sub
        End If

        DB.AddParam("@Item_name", ItemNameTextBox.Text)
        DB.AddParam("@Category_ID", CategoryIDTextBox.Text)
        DB.AddParam("@Price", PriceTextBox.Text)
        DB.AddParam("@Active", MenuCheckBox.Checked)
        DB.AddParam("@Description", DescriptionTextBox.Text)
        DB.AddParam("@Last_update", MenuLastUpdateDateTimePicker.Value)

        DB.AddParam("@Item_ID", MenuIDTextBox.Text)

        DB.ExecuteQuery("UPDATE menu set Item_name=?, category_id=?, price=?, is_Active=?, description=?, updated_on=? WHERE item_id=? ")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("The menu#" & MenuIDTextBox.Text & " is updated successfully.")
    End Sub

    Private Function ValidateMenu() As Boolean
        If String.IsNullOrWhiteSpace(ItemNameTextBox.Text) Then
            MessageBox.Show("Item Name can't be empty.")
            ItemNameTextBox.SelectAll()
            ItemNameTextBox.Focus()
            Return False
        End If

        ' Dim ItemNameRegex As New Regex("^[A-Z]+[a-z]+$")
        ' If Not ItemNameRegex.IsMatch(ItemNameTextBox.Text) Then
        ' MessageBox.Show("Please enter valid item name, with the first letter capitalized")
        ' ItemNameTextBox.SelectAll()
        'ItemNameTextBox.Focus()
        'Return False
        'End If

        If String.IsNullOrEmpty(PriceTextBox.Text) Then
            MessageBox.Show("The Price can't be empty.")
            PriceTextBox.SelectAll()
            PriceTextBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MenuDataGridView.CellContentClick

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub MenuLastUpdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles MenuLastUpdateDateTimePicker.ValueChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MenuHomeButton_Click(sender As Object, e As EventArgs) Handles MenuHomeButton.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.Focus()
    End Sub
End Class