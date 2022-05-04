Public Class LoginForm
    Private DB As New DBAccess

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click

        If String.IsNullOrWhiteSpace(UsernameTextBox.Text) Then
            MessageBox.Show("Username can not be empty.")
            UsernameTextBox.SelectAll()
            UsernameTextBox.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            MessageBox.Show("Password can not be empty.")
            UsernameTextBox.SelectAll()
            UsernameTextBox.Focus()
            Exit Sub
        End If

        DB.AddParam("@username", UsernameTextBox.Text)
        DB.AddParam("@password", PasswordTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM staff WHERE username = ? AND password = ? ")

        If DB.DBException <> String.Empty Then
            MessageBox.Show("DB Error: " & DB.DBException)
            Exit Sub
        End If

        If DB.RecordCount > 0 Then
            'user has a match, can be logged in
            'clear username and password entered to secure the system.
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()

            'hide the login form from user afer login. 
            'in the next form load event, it will close the login form completely. 
            Me.Hide()
            Dim role As String = String.Empty
            role = DB.DBDataTable(0)!Role.ToString()
            intStaffID = CInt(DB.DBDataTable(0)!Staff_ID.ToString())
            strStaffName = DB.DBDataTable(0)!FirstName.ToString() & " " & DB.DBDataTable(0)!LastName.ToString()
            'store_id is just a representative field for user type or role. we use store_id here to process staff who belongs to different store. 
            If role = "Manager" Or role = "Chef" Then
                'Dim frmHome As New Home
                'frmHome.ShowDialog()
                Home.Show()
            ElseIf role = "Server" Then
                'Dim frmOrder1 As New frmOrdering_Type
                'frmOrder1.ShowDialog()
                frmOrdering_Type.Show()
            End If

        Else
            MessageBox.Show("Invalid Credentials, Please check the username and Password again")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Exit Sub
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class