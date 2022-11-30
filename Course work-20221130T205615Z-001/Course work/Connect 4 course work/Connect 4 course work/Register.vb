Imports MySql.Data.MySqlClient
Public Class frmRegister
    Dim passwordver As Boolean

    Dim username As String

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btnregister.Enabled = False

    End Sub

    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Dim connection As New MySqlConnection
        Dim com As New MySqlCommand
        Dim dr As MySqlDataReader
        connection.ConnectionString = ("server=localhost;user id=root;persistsecurityinfo=True;database=database;allowuservariables=True;password=")
        Try
            connection.Open()
            MsgBox("connected")
            connection.Close()
        Catch ex As mysqlException

        End Try
        Try

            connection.ConnectionString = ("server=localhost;user id=root;persistsecurityinfo=True;database=database;allowuservariables=True;password=")

            If TxtFirstname.Text = ("") Or txtsurname.Text = ("") OrElse TxtPassword.Text = ("") OrElse txtRePassword.Text = ("") OrElse TxtPassword.Text <> txtRePassword.Text Then

                MsgBox("Re enter details there seems to be an issue")

            Else
                connection.Open()
                com.Connection = connection
                'Making the username so nomatter what they enter it will display a username 
                If TxtFirstname.Text.Length < 6 And txtsurname.Text.Length < 5 Then
                    username = TxtFirstname.Text.Substring(0, TxtFirstname.Text.Length) + txtsurname.Text.Substring(0, txtsurname.Text.Length)
                ElseIf TxtFirstname.Text.Length < 6 Then
                    username = TxtFirstname.Text.Substring(0, TxtFirstname.Text.Length) + txtsurname.Text.Substring(0, 4)
                ElseIf txtsurname.Text.Length < 5 Then
                    username = TxtFirstname.Text.Substring(0, 5) + txtsurname.Text.Substring(0, txtsurname.Text.Length)
                Else
                    username = TxtFirstname.Text.Substring(0, 5) + txtsurname.Text.Substring(0, 4)
                End If




                MsgBox(username)
                com.CommandType = CommandType.Text



                com.Connection = connection
                com = New MySqlCommand("INSERT INTO information values  " & TxtFirstname.Text & "," & txtsurname.Text & "," & TxtPassword.Text & "," & username & ")", connection)
                com.BeginExecuteNonQuery()
                MsgBox("Successfully Registered, your username is " & username & "")


            End If
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Error")
        End Try
    End Sub

    Private Sub TxtFirstname_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstname.TextChanged
        If TxtFirstname.Text <> ("") And txtsurname.Text <> ("") AndAlso TxtPassword.Text <> ("") AndAlso passwordver = True Then
            Btnregister.Enabled = True
        Else
        End If
    End Sub

    Private Sub txtRePassword_TextChanged(sender As Object, e As EventArgs) Handles txtRePassword.TextChanged
        If TxtPassword.Text = txtRePassword.Text Then
            passwordver = True
        Else

        End If
        If TxtFirstname.Text <> ("") And txtsurname.Text <> ("") AndAlso TxtPassword.Text <> ("") AndAlso passwordver = True Then
            Btnregister.Enabled = True
        Else
        End If

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        If TxtFirstname.Text <> ("") And txtsurname.Text <> ("") AndAlso TxtPassword.Text <> ("") AndAlso passwordver = True Then
            Btnregister.Enabled = True
        Else
        End If
    End Sub

    Private Sub txtsurname_TextChanged(sender As Object, e As EventArgs) Handles txtsurname.TextChanged
        If TxtFirstname.Text <> ("") And txtsurname.Text <> ("") AndAlso TxtPassword.Text <> ("") AndAlso passwordver = True Then
            Btnregister.Enabled = True
        Else
        End If
    End Sub
End Class