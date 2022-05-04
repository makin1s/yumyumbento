Imports System.Text.RegularExpressions
Public Class NewStaffForm
    Private DB As New DBAccess
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidNewStaff() = True Then
            If DuplicateStaff() = False Then
                AddNewStaff()
                Me.Close()

            End If
        End If
    End Sub
    Private Function ValidNewStaff() As Boolean


        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            MessageBox.Show("FirstName can't be empty.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        Dim rxFirstName1 As New Regex("[0-9]")
        If rxFirstName1.IsMatch(FirstNameTextBox.Text) = True Then
            MessageBox.Show("FirstName must be in alphabets.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        Dim rxFirstName As New Regex("[A-Z][a-z]+$")
        If rxFirstName.IsMatch(FirstNameTextBox.Text) = False Then
            MessageBox.Show("FirstName must be alphabets and starts with an upper case letter.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            MessageBox.Show("LastName can't be empty.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        Dim rxLastName1 As New Regex("[0-9]")
        If rxLastName1.IsMatch(LastNameTextBox.Text) = True Then
            MessageBox.Show("LastName must be in alphabets.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        Dim rxLastName As New Regex("[A-Z][a-z]+$")
        If rxLastName.IsMatch(LastNameTextBox.Text) = False Then
            MessageBox.Show("LastName must be alphabets and starts with an upper case letter.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            MessageBox.Show("Email can't be empty.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False
        End If
        Dim rxEmail As New Regex("[a-z0-9_.+-]+@[a-z0-9-]+\.[a-z0-9-.]")
        If rxEmail.IsMatch(EmailTextBox.Text) = False Then
            MessageBox.Show("Email must follow the right format such as abc@xyz.com")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()

            Return False
        End If

        Dim rxUserName As New Regex("(?=[a-z]{4,15}[._][0-9]$)(?!.*[_.]{2})[^_.].*[^_.]$")
        If String.IsNullOrEmpty(UserNameTextBox.Text) = False Then
            If rxUserName.IsMatch(UserNameTextBox.Text) = False Then
                MessageBox.Show("UserName should contains alphanumeric characters, underscore or dot with atleast 6 characters in the format such as (wxyz_9) ")
                UserNameTextBox.SelectAll()
                UserNameTextBox.Focus()

                Return False
            End If
        End If

        Dim rxPassword As New Regex("(?=[A-Z][a-z]{3,15}[@#%&*][0-9]$)(?!_*[@#%&*])")
        If String.IsNullOrEmpty(PasswordTextBox.Text) = False Then
            If rxPassword.IsMatch(PasswordTextBox.Text) = False Then
                MessageBox.Show("Password should contain alphanumeric and with Special Characters(@#%&*) with atleast 6 characters in the format such as (Wxyz@9) ")
                PasswordTextBox.SelectAll()
                PasswordTextBox.Focus()

                Return False
            End If
        End If

        If String.IsNullOrWhiteSpace(PhoneTextBox.Text) = True Then
            MessageBox.Show("Phone Number can't be empty.")
            PhoneTextBox.SelectAll()
            PhoneTextBox.Focus()
            Return False
        End If

        Dim rxPhone1 As New Regex("[A-Za-z]")
        If rxPhone1.IsMatch(PhoneTextBox.Text) = True Then
            MessageBox.Show("Phone Number must be Integers.")
            PhoneTextBox.SelectAll()
            PhoneTextBox.Focus()
            Return False
        End If

        Dim rxPhone As New Regex("[0-9]{10}")
        If rxPhone.IsMatch(PhoneTextBox.Text) = False Then
            MessageBox.Show("Phone Number must be in 10 digits")
            PhoneTextBox.SelectAll()
            PhoneTextBox.Focus()

            Return False
        End If

        If ActiveCheckBox.Checked = False Then
            MessageBox.Show("Active can't be empty.")
            ActiveCheckBox.Select()
            ActiveCheckBox.Focus()
            Return False
        End If



        If String.IsNullOrEmpty(Role_CheckedListBox.SelectedItem) = True Then
            MessageBox.Show("Role can't be empty.")
            Role_CheckedListBox.Select()
            Role_CheckedListBox.Focus()
            Return False
        End If

        Return True
    End Function
    Private Function DuplicateStaff() As Boolean
        DB.AddParam("@firstName", FirstNameTextBox.Text)
        DB.AddParam("@lastname", LastNameTextBox.Text)


        DB.ExecuteQuery("SELECT * FROM staff WHERE FirstName = ? AND LastName = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Function
        End If

        If DB.RecordCount >= 1 Then

            MessageBox.Show("A Duplicate Film with the same FirstName and LastName already exists.")
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub AddNewStaff()


        DB.AddParam("@firstname", FirstNameTextBox.Text)
        DB.AddParam("@lastname", LastNameTextBox.Text)
        DB.AddParam("@email", EmailTextBox.Text)

        If String.IsNullOrWhiteSpace(UserNameTextBox.Text) Then
            DB.AddParam("@username", DBNull.Value)
        Else
            DB.AddParam("@username", UserNameTextBox.Text)
        End If

        If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            DB.AddParam("@password", DBNull.Value)
        Else
            DB.AddParam("@password", PasswordTextBox.Text)
        End If

        DB.AddParam("@phone", PhoneTextBox.Text)
        DB.AddParam("@active", ActiveCheckBox.Checked)
        DB.AddParam("@role", Role_CheckedListBox.SelectedItem)

        DB.ExecuteQuery("INSERT INTO staff(FirstName, LastName, Email, UserName, Password, Phone, Active, Role)" & "VALUES(?, ?, ?, ?, ?, ?, ?, ?)")


        MessageBox.Show("A new staff is added successfully.")
        Me.Close()


    End Sub


End Class