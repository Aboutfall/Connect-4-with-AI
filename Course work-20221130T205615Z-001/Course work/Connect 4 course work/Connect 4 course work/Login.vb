Imports System.Data.SqlClient


Public Class frmLogin





    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnlogin.Click






    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs)
        Dim connection As New SqlConnection
        Dim Comm As New SqlCommand

        connection.ConnectionString = "server=localhost;user id=root;password=password;database=database"
        connection.Open()
        Comm.Connection = connection



        Comm.Parameters.Add("@User", SqlDbType.Char).Value = TxtUsername.Text
        Dim Adap As New SqlDataAdapter(Comm)
        Dim table As New DataTable(0, 30)
        Adap.Fill(table)

        If TxtPassword.Text = table(0)(3).ToString Then
            Me.Hide()
            frmselection.Show()
        End If



    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub InformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

End Class