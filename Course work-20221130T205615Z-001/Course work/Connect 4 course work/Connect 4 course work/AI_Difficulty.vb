Public Class frmselection
    Dim Dif As String
    Dim Num As String




    Private Sub AI_Difficulty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDifficulty.Items.Add("Easy")
        txtDifficulty.Items.Add("Medium")
        txtDifficulty.Items.Add("Hard")
        txtNumbers.Items.Add("One")
        txtNumbers.Items.Add("Two")
        btnNext.Enabled = False



    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim file As String = ("C:\Users\Christian\Desktop\Course work AI works\Course work\Connect 4 course work\Connect 4 course work\text.txt")
        Dim objWriter As New System.IO.StreamWriter(file)


        objWriter.WriteLine(Dif)
        objWriter.WriteLine(Num)
        objWriter.Close()

        frmconnect4.Show()
        Me.Hide()
    End Sub

    Private Sub Difficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDifficulty.SelectedIndexChanged
        Dif = txtDifficulty.Text
        If Num = ("One") Then
            If Num <> ("") And Dif <> ("") Then
                btnNext.Enabled = True
            Else

            End If
        Else
            If Num <> ("") Then
                btnNext.Enabled = True
            Else

            End If
        End If
    End Sub

    Private Sub Numbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtNumbers.SelectedIndexChanged
        Num = txtNumbers.Text
        If Num = ("One") Then
            txtDifficulty.Enabled = True
        Else
            txtDifficulty.Enabled = False
            txtDifficulty.Text = ("")
        End If
        If Num = ("One") Then
            If Num <> ("") And Dif <> ("") Then
                btnNext.Enabled = True
            Else

            End If
        Else
            If Num <> ("") Then
                btnNext.Enabled = True

            Else

            End If
        End If
    End Sub
End Class