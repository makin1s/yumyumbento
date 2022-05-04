'Designed by Rayan Alshuayfani
Imports System.Text.RegularExpressions

Public Class Customers
    Private DB As New DBAccess
    Public Property CustomersCount As Object

    Private Sub CustomerHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNameLabel.Text = strStaffName
        DB.ExecuteQuery("SELECT * FROM customer")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        CustomerDataGridView.DataSource = DB.DBDataTable
        CustomerCount.Text = "Customers #:" & DB.RecordCount.ToString

        CustomerDataGridView.ReadOnly = True
        CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SearchCustomer(FirstName As String, LastName As String)
        DB.AddParam("@firs_tname", FirstName & "%")
        DB.AddParam("@last_name", LastName & "%")

        DB.ExecuteQuery("SELECT * FROM customer WHERE First_Name LIKE ? AND Last_Name LIKE ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        CustomerDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub CustomerNamesTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchCusFirstNameTextBox.KeyUp, SearchCusLastNameTextBox.KeyUp
        SearchCustomer(SearchCusFirstNameTextBox.Text, SearchCusLastNameTextBox.Text)
    End Sub

    Private Sub CustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = CustomerDataGridView.Rows.Count - 1 Then
            ClearCustomerDetails()
            Exit Sub
        Else
            CustomerIDTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(0).Value
            CusFirstNameTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(1).Value
            CusLastNameTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(2).Value
            If IsDBNull(CustomerDataGridView.Rows(e.RowIndex).Cells(3).Value) Then
                CusEmailTextBox.Text = String.Empty
            Else
                CusEmailTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(3).Value
            End If
            CusPhoneTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(4).Value
            CusCheckBox.Checked = CustomerDataGridView.Rows(e.RowIndex).Cells(5).Value
            CusAddressTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(6).Value
            CusZipcodeTextBox.Text = CustomerDataGridView.Rows(e.RowIndex).Cells(7).Value
            CusLastUpdateDateTimePicker.Value = CustomerDataGridView.Rows(e.RowIndex).Cells(9).Value

        End If
    End Sub

    Private Sub EnableCustomerFieldsforEdit(Switch As Boolean)
        CustomerIDTextBox.Enabled = False
        CusFirstNameTextBox.Enabled = Switch
        CusLastNameTextBox.Enabled = Switch
        CusEmailTextBox.Enabled = Switch
        CusPhoneTextBox.Enabled = Switch
        CusAddressTextBox.Enabled = Switch
        CusZipcodeTextBox.Enabled = Switch
        CusCheckBox.Enabled = Switch
        CusLastUpdateDateTimePicker.Enabled = False 'Time Stamp field with auto update turned on. 

        If Switch = True Then
            CusEditSaveButton.Text = "Save"
            NewCusButton.Enabled = False
        Else
            CusEditSaveButton.Text = "Edit"
            NewCusButton.Enabled = True
        End If
    End Sub

    Private Sub ClearCustomerDetails()
        CustomerIDTextBox.Clear()
        CusFirstNameTextBox.Clear()
        CusLastNameTextBox.Clear()
        CusEmailTextBox.Clear()
        CusPhoneTextBox.Clear()
        CusAddressTextBox.Clear()
        CusZipcodeTextBox.Clear()
        CusCheckBox.Checked = False
        CusLastUpdateDateTimePicker.Value = Today.Date
    End Sub
    Private Sub CusClearButton_Click(sender As Object, e As EventArgs) Handles CusClearButton.Click
        ClearCustomerDetails()
    End Sub

    Private Sub NewCusButton_Click(sender As Object, e As EventArgs) Handles NewCusButton.Click
        ClearCustomerDetails()
        EnableCustomerFieldsforEdit(True)
    End Sub


    Private Sub CusCancelButton_Click(sender As Object, e As EventArgs) Handles CusCancelButton.Click
        CusFirstNameTextBox.Undo()
        CusLastNameTextBox.Undo()
        CusEmailTextBox.Undo()
        CusPhoneTextBox.Undo()
        CusAddressTextBox.Undo()
        CusZipcodeTextBox.Undo()
        EnableCustomerFieldsforEdit(False)
    End Sub
    Private Sub CusEditSaveButton_Click(sender As Object, e As EventArgs) Handles CusEditSaveButton.Click
        If CusEditSaveButton.Text = "Edit" Then
            'Edit mode
            EnableCustomerFieldsforEdit(True)
        Else

            If String.IsNullOrWhiteSpace(CustomerIDTextBox.Text) Then
                'Add a new record
                AddNewCustomer()
            Else
                'Update an existing record
                UpdateCustomer()
            End If
            SearchCustomer(SearchCusFirstNameTextBox.Text, SearchCusLastNameTextBox.Text) 'Refreshing the data grid view

            EnableCustomerFieldsforEdit(False)
        End If
    End Sub
    Private Sub CusDeleteButton_Click(sender As Object, e As EventArgs) Handles CusDeleteButton.Click
        Dim aDialogResult As DialogResult

        aDialogResult = MessageBox.Show("Do you want to delete customer " & CusFirstNameTextBox.Text & "(#" & CustomerIDTextBox.Text & ") record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then

            Exit Sub
        Else

            DB.AddParam("@Customer_id", CustomerIDTextBox.Text)
            DB.ExecuteQuery("DELETE FROM Customer WHERE Customer_id = ?")
            If DB.DBException <> String.Empty Then
                MessageBox.Show(DB.DBException)
                Exit Sub
            End If

            MessageBox.Show("The selected record has been deleted successfully")
            CustomerIDTextBox.Clear()
            CusFirstNameTextBox.Clear()
            CusLastNameTextBox.Clear()
            CusEmailTextBox.Clear()
            CusPhoneTextBox.Clear()
            CusAddressTextBox.Clear()
            CusZipcodeTextBox.Clear()
            CusCheckBox.Checked = False
            CusLastUpdateDateTimePicker.Value = Today.Date

            SearchCustomer(SearchCusFirstNameTextBox.Text, SearchCusLastNameTextBox.Text)
        End If
    End Sub
    Private Sub AddNewCustomer()
        If ValidateCustomer() = False Then
            Exit Sub
        End If

        DB.AddParam("@First_Name", CusFirstNameTextBox.Text)
        DB.AddParam("@Last_Name", CusLastNameTextBox.Text)
        DB.AddParam("@Email", If(String.IsNullOrWhiteSpace(CusEmailTextBox.Text), DBNull.Value, CusEmailTextBox.Text))
        DB.AddParam("@Phone", If(String.IsNullOrWhiteSpace(CusPhoneTextBox.Text), DBNull.Value, CusPhoneTextBox.Text))
        DB.AddParam("@Address", CusAddressTextBox.Text)
        DB.AddParam("@ZipCode", CusZipcodeTextBox.Text)
        DB.AddParam("@Active", CusCheckBox.Checked)
        DB.AddParam("@Last_update", CusLastUpdateDateTimePicker.Value)

        DB.ExecuteQuery("INSERT INTO customer(First_Name, Last_Name, Email, Phone, Address, ZipCode, is_active, updated_on) VALUES(?,?,?,?,?,?,?,?)")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("A new customer is added successfully.")

        DB.AddParam("@First_Name", CusFirstNameTextBox.Text)
        DB.AddParam("@Last_Name", CusLastNameTextBox.Text)

        DB.ExecuteQuery(" select customer_id AS Last_customer_id FROM customer WHERE first_name =? AND last_name =?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)

            Exit Sub

        End If

        Dim newest_customer_id As Integer
        newest_customer_id = DB.DBDataTable(0)(0)
        MessageBox.Show(" The new customer ID is" & newest_customer_id)
    End Sub
    Private Sub UpdateCustomer()
        If ValidateCustomer() = False Then
            Exit Sub
        End If

        DB.AddParam("@First_Name", CusFirstNameTextBox.Text)
        DB.AddParam("@Last_Name", CusLastNameTextBox.Text)
        DB.AddParam("@Email", If(String.IsNullOrWhiteSpace(CusEmailTextBox.Text), DBNull.Value, CusEmailTextBox.Text))
        DB.AddParam("@Phone", If(String.IsNullOrWhiteSpace(CusPhoneTextBox.Text), DBNull.Value, CusPhoneTextBox.Text))
        DB.AddParam("@is_active", CusCheckBox.Checked)
        DB.AddParam("@Address", CusAddressTextBox.Text)
        DB.AddParam("@ZipCode", CusZipcodeTextBox.Text)
        DB.AddParam("@Customer_id", CustomerIDTextBox.Text)

        DB.ExecuteQuery("UPDATE customer set First_Name=?, Last_Name=?, Email=?, Phone=?, is_Active=?, Address=?, ZipCode=?  WHERE Customer_id=? ")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("The customer#" & CustomerIDTextBox.Text & " is updated successfully.")
    End Sub

    Private Function ValidateCustomer() As Boolean
        If String.IsNullOrWhiteSpace(CusFirstNameTextBox.Text) Then
            MessageBox.Show("Customer First Name can't be empty.")
            CusFirstNameTextBox.SelectAll()
            CusFirstNameTextBox.Focus()
            Return False
        End If



        Dim FirstNameRegex As New Regex("^[A-Z]+[a-z]+$")

        If Not FirstNameRegex.IsMatch(CusFirstNameTextBox.Text) Then
            MessageBox.Show("Please enter valid first name, with the first letter capitalized")
            CusFirstNameTextBox.SelectAll()
            CusFirstNameTextBox.Focus()
            Return False

        End If

        If String.IsNullOrWhiteSpace(CusLastNameTextBox.Text) Then
            MessageBox.Show("Customer Last Name can't be empty.")
            CusLastNameTextBox.SelectAll()
            CusLastNameTextBox.Focus()
            Return False
        End If

        Dim LastNameRegex As New Regex("^[A-Z]+[a-z]+$")

        If Not LastNameRegex.IsMatch(CusLastNameTextBox.Text) Then
            MessageBox.Show("Please enter valid last name, with the first letter capitalized.")
            CusLastNameTextBox.SelectAll()
            CusLastNameTextBox.Focus()

            Return False
        End If

        If String.IsNullOrEmpty(CusEmailTextBox.Text) Then
            MessageBox.Show("The Email can't be empty.")
            CusEmailTextBox.SelectAll()
            CusEmailTextBox.Focus()
            Return False
        End If

        Dim EmailRegex As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9.]+")
        If Not EmailRegex.IsMatch(CusEmailTextBox.Text) Then
            MessageBox.Show("Please enter valid email address, formatted  as abc@xyz.com")
            CusEmailTextBox.SelectAll()
            CusEmailTextBox.Focus()
            Return False

        End If

        If String.IsNullOrWhiteSpace(CusPhoneTextBox.Text) Then
            MessageBox.Show("The Phone Number can't be empty.")
            CusPhoneTextBox.SelectAll()
            CusPhoneTextBox.Focus()
            Return False

        End If





        Dim rxCusPhone As New Regex("[A-Za-z]")
        If rxCusPhone.IsMatch(CusPhoneTextBox.Text) Then
            MessageBox.Show("Phone Number must be Integers.")
            CusPhoneTextBox.SelectAll()
            CusPhoneTextBox.Focus()
            Return False
        End If

        Dim rxCusPhone1 As New Regex("^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$")
        If rxCusPhone1.IsMatch(CusPhoneTextBox.Text) = False Then
            MessageBox.Show("Phone Number must be in 10 digits")
            CusPhoneTextBox.SelectAll()
            CusPhoneTextBox.Focus()

            Return False
        End If

        If String.IsNullOrWhiteSpace(CusAddressTextBox.Text) Then
            MessageBox.Show("The Address can't be empty.")
            CusAddressTextBox.SelectAll()
            CusAddressTextBox.Focus()
            Return False



            Dim CusAddressTextBoxRegex As New Regex(CusAddressTextBox.Text, "[a-zA-Z0-9_.+-]+")
            MessageBox.Show("The address must follow the right format such as 510 bellows ST.")
            CusAddressTextBox.SelectAll()
            CusAddressTextBox.Focus()
            Return False
        End If


        If String.IsNullOrWhiteSpace(CusZipcodeTextBox.Text) Then
            MessageBox.Show("The Zipcode can't be empty.")
            CusZipcodeTextBox.SelectAll()
            CusZipcodeTextBox.Focus()
            Return False
        End If

        Dim CusZipInteger As Integer
        If Integer.TryParse(CusZipcodeTextBox.Text, CusZipInteger) = False Then
            MessageBox.Show("The Zipcode must be an integer.")
            CusZipcodeTextBox.SelectAll()
            CusZipcodeTextBox.Focus()

            Return False
        End If

        Dim rxCusZipcode As New Regex("^\(?([0-9]{5})\)?$")
        If rxCusZipcode.IsMatch(CusZipcodeTextBox.Text) = False Then
            MessageBox.Show("The Zipcode must be in 5 digits")
            CusZipcodeTextBox.SelectAll()
            CusZipcodeTextBox.Focus()

            Return False
        End If

        Return True
    End Function
    '_______________________________________________________________________________________________________/
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CusLastUpdateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles CusLastUpdateDateTimePicker.ValueChanged

    End Sub

    Private Sub CusHomeButton_Click(sender As Object, e As EventArgs) Handles CusHomeButton.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.Focus()
    End Sub
End Class

