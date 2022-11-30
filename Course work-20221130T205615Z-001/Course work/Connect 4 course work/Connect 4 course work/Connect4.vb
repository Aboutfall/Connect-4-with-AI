Public Class Counter
    Public Colour As String

End Class

Public Class frmconnect4

    Dim collumn1, collumn2, collumn3, collumn4, collumn5, collumn6, collumn7 As Integer
    Dim player As Integer = 0
    Private multiarray(8, 9) As Integer 'Added 2 
    Dim Colour As String
    Dim AI As Boolean = False
    Dim difficulty As String
    Dim B1, B2 As String
    Dim rng As New Random
    Dim wincon As String
    Dim file As String = ("C:\Users\Christian\Desktop\Course work AI works\Course work\Connect 4 course work\Connect 4 course work\text.txt")
    Dim objreader As New System.IO.StreamReader(file)
    Dim turn As Integer
    Dim Counter As New Counter




    Private Sub frmconnect4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        B1 = objreader.ReadLine
        B2 = objreader.ReadLine
        If B2 = ("One") Then
            AI = True
            If B1 = ("Easy") Then
                lblPlayer2.Text = ("Easy AI")
            ElseIf B1 = ("Medium") Then
                lblPlayer2.Text = ("Medium AI")
            ElseIf B1 = ("Hard") Then
                lblPlayer2.Text = ("Hard AI")
            Else
            End If
        Else
            AI = False
            lblPlayer1.Text = InputBox("Name of player 1?")
            lblPlayer2.Text = InputBox("Name of player 2?")
        End If

        lblPlayer2.Enabled = False
    End Sub


    Private Sub BtnRow1_Click(sender As Object, e As EventArgs) Handles btnRow1.Click




        'Counter
        If player = 0 Then


            If collumn1 = 0 Then
                PictureBox1_0.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn1 = 1 Then
                PictureBox1_1.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn1 = 2 Then
                PictureBox1_2.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn1 = 3 Then
                PictureBox1_3.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn1 = 4 Then
                PictureBox1_4.Image = My.Resources.ResourceManager.GetObject("Red")
            Else
                PictureBox1_5.Image = My.Resources.ResourceManager.GetObject("Red")
                btnRow1.Enabled = False
            End If
            player = player + 1
            multiarray(0, collumn1) = 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else


            If collumn1 = 0 Then
                PictureBox1_0.Image = My.Resources.ResourceManager.GetObject("Yellow")


            ElseIf collumn1 = 1 Then
                PictureBox1_1.Image = My.Resources.ResourceManager.GetObject("Yellow")


            ElseIf collumn1 = 2 Then
                PictureBox1_2.Image = My.Resources.ResourceManager.GetObject("Yellow")


            ElseIf collumn1 = 3 Then
                PictureBox1_3.Image = My.Resources.ResourceManager.GetObject("Yellow")


            ElseIf collumn1 = 4 Then
                PictureBox1_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox1_5.Image = My.Resources.ResourceManager.GetObject("Yellow")

                btnRow1.Enabled = False

            End If
            multiarray(0, collumn1) = 5
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
            player = player - 1
        End If
        collumn1 = collumn1 + 1


        'Vertical check
        For j = 0 To 3
            If multiarray(0, j) + multiarray(0, j + 1) + multiarray(0, j + 2) + multiarray(0, j + 3) = 4 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(1, j) + multiarray(0, j + 1) + multiarray(0, j + 2) + multiarray(0, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next



        'Artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                'random AI
                While player = 1
                    If player = 1 Then
                    If rng.Next(0, 6) = 0 Then
                        If btnRow1.Enabled <> False Then
                            btnRow1.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If
                    ElseIf rng.Next(0, 6) = 1 Then
                        If btnrow2.Enabled <> False Then
                            btnrow2.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If
                    ElseIf rng.Next(0, 6) = 2 Then
                        If btnrow3.Enabled <> False Then
                            btnrow3.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If
                    ElseIf rng.Next(0, 6) = 3 Then
                        If btnrow4.Enabled <> False Then
                            btnrow4.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If
                    ElseIf rng.Next(0, 6) = 4 Then
                        If btnrow4.Enabled <> False Then
                            btnrow5.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If
                    ElseIf rng.Next(0, 6) = 5 Then
                        If btnrow6.Enabled <> False Then
                            btnrow6.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If

                    ElseIf rng.Next(0, 6) = 6 Then
                        If btnrow7.Enabled <> False Then
                            btnrow7.PerformClick()

                        Else
                            rng.Next(0, 6)
                        End If

                    End If
                Else
                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While



            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                    Me.Close()

            End If

        End If




    End Sub

    Private Sub btnrow2_Click(sender As Object, e As EventArgs) Handles btnrow2.Click
        'Counter
        If player = 0 Then
            If collumn2 = 0 Then
                PictureBox2_0.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn2 = 1 Then
                PictureBox2_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn2 = 2 Then
                PictureBox2_2.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn2 = 3 Then
                PictureBox2_3.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn2 = 4 Then
                PictureBox2_4.Image = My.Resources.ResourceManager.GetObject("Red")

            Else
                PictureBox2_5.Image = My.Resources.ResourceManager.GetObject("Red")


                btnrow2.Enabled = False

            End If
            multiarray(1, collumn2) = 1
            player = player + 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else
            If collumn2 = 0 Then
                PictureBox2_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn2 = 1 Then
                PictureBox2_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn2 = 2 Then
                PictureBox2_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn2 = 3 Then
                PictureBox2_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn2 = 4 Then
                PictureBox2_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox2_5.Image = My.Resources.ResourceManager.GetObject("Yellow")

                btnrow2.Enabled = False

            End If
            player = player - 1
            multiarray(1, collumn2) = 5
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
        End If
        collumn2 = collumn2 + 1

        'Vertical check
        For j = 0 To 3
            If multiarray(1, j) + multiarray(1, j + 1) = 2 And multiarray(1, j + 2) + multiarray(1, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(1, j) + multiarray(1, j + 1) + multiarray(1, j + 2) + multiarray(1, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While



            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If
        turn = turn + 1
    End Sub

    Private Sub btnrow3_Click(sender As Object, e As EventArgs) Handles btnrow3.Click
        'Counter
        If player = 0 Then
            If collumn3 = 0 Then
                PictureBox3_0.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn3 = 1 Then
                PictureBox3_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn3 = 2 Then
                PictureBox3_2.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn3 = 3 Then
                PictureBox3_3.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn3 = 4 Then
                PictureBox3_4.Image = My.Resources.ResourceManager.GetObject("Red")

            Else
                PictureBox3_5.Image = My.Resources.ResourceManager.GetObject("Red")


                btnrow3.Enabled = False

            End If
            player = player + 1
            multiarray(2, collumn3) = 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else
            If collumn3 = 0 Then
                PictureBox3_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn3 = 1 Then
                PictureBox3_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn3 = 2 Then
                PictureBox3_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn3 = 3 Then
                PictureBox3_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn3 = 4 Then
                PictureBox3_4.Image = My.Resources.ResourceManager.GetObject("Yellow")


            Else
                PictureBox3_5.Image = My.Resources.ResourceManager.GetObject("Yellow")

                btnrow3.Enabled = False

            End If
            player = player - 1
            multiarray(2, collumn3) = 5
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
        End If
        collumn3 = collumn3 + 1


        'Vertical check
        For j = 0 To 3
            If multiarray(2, j) + multiarray(2, j + 1) = 2 And multiarray(2, j + 2) + multiarray(2, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(2, j) + multiarray(2, j + 1) + multiarray(2, j + 2) + multiarray(2, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While


            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If


    End Sub

    Private Sub btnrow4_Click(sender As Object, e As EventArgs) Handles btnrow4.Click
        'Counter
        If player = 0 Then
            If collumn4 = 0 Then
                PictureBox4_0.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn4 = 1 Then
                PictureBox4_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn4 = 2 Then
                PictureBox4_2.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn4 = 3 Then
                PictureBox4_3.Image = My.Resources.ResourceManager.GetObject("Red")
            ElseIf collumn4 = 4 Then
                PictureBox4_4.Image = My.Resources.ResourceManager.GetObject("Red")
            Else
                PictureBox4_5.Image = My.Resources.ResourceManager.GetObject("Red")
                btnrow4.Enabled = False
            End If
            player = player + 1
            multiarray(3, collumn4) = 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else
            If collumn4 = 0 Then
                PictureBox4_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn4 = 1 Then
                PictureBox4_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn4 = 2 Then
                PictureBox4_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn4 = 3 Then
                PictureBox4_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn4 = 4 Then
                PictureBox4_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox4_5.Image = My.Resources.ResourceManager.GetObject("Yellow")


                btnrow4.Enabled = False

            End If
            multiarray(3, collumn4) = 5
            player = player - 1
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
        End If
        collumn4 = collumn4 + 1


        'Vertical check
        For j = 0 To 3
            If multiarray(3, j) + multiarray(3, j + 1) = 2 And multiarray(3, j + 2) + multiarray(3, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(3, j) + multiarray(3, j + 1) + multiarray(3, j + 2) + multiarray(3, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While



            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If

    End Sub

    Private Sub btnrow5_Click(sender As Object, e As EventArgs) Handles btnrow5.Click
        'Counter
        If player = 0 Then
            If collumn5 = 0 Then
                PictureBox5_0.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn5 = 1 Then
                PictureBox5_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn5 = 2 Then
                PictureBox5_2.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn5 = 3 Then
                PictureBox5_3.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn5 = 4 Then
                PictureBox5_4.Image = My.Resources.ResourceManager.GetObject("Red")

            Else
                PictureBox5_5.Image = My.Resources.ResourceManager.GetObject("Red")


                btnrow5.Enabled = False

            End If
            multiarray(4, collumn5) = 1
            player = player + 1
        Else
            If collumn5 = 0 Then
                PictureBox5_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn5 = 1 Then
                PictureBox5_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn5 = 2 Then
                PictureBox5_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn5 = 3 Then
                PictureBox5_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn5 = 4 Then
                PictureBox5_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox5_5.Image = My.Resources.ResourceManager.GetObject("Yellow")

                btnrow5.Enabled = False

            End If
            player = player - 1
            multiarray(4, collumn5) = 5
        End If
        collumn5 = collumn5 + 1



        ' Vertical check
        For j = 0 To 3
            If multiarray(4, j) + multiarray(4, j + 1) = 2 And multiarray(4, j + 2) + multiarray(4, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(4, j) + multiarray(4, j + 1) + multiarray(4, j + 2) + multiarray(4, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next


        'artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While


            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If



    End Sub

    Private Sub btnrow6_Click(sender As Object, e As EventArgs) Handles btnrow6.Click
        'Counter
        If player = 0 Then
            If collumn6 = 0 Then
                PictureBox6_0.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn6 = 1 Then
                PictureBox6_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn6 = 2 Then
                PictureBox6_2.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn6 = 3 Then
                PictureBox6_3.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn6 = 4 Then
                PictureBox6_4.Image = My.Resources.ResourceManager.GetObject("Red")

            Else
                PictureBox6_5.Image = My.Resources.ResourceManager.GetObject("Red")

                btnrow6.Enabled = False
            End If
            player = player + 1
            multiarray(5, collumn6) = 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else
            If collumn6 = 0 Then
                PictureBox6_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn6 = 1 Then
                PictureBox6_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn6 = 2 Then
                PictureBox6_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn6 = 3 Then
                PictureBox6_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn6 = 4 Then
                PictureBox6_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox6_5.Image = My.Resources.ResourceManager.GetObject("Yellow")


                btnrow6.Enabled = False

            End If
            player = player - 1
            multiarray(5, collumn6) = 5
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
        End If
        collumn6 = collumn6 + 1


        'Vertical check
        For j = 0 To 3
            If multiarray(5, j) + multiarray(5, j + 1) = 2 And multiarray(5, j + 2) + multiarray(5, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(5, j) + multiarray(5, j + 1) + multiarray(5, j + 2) + multiarray(5, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next


        'artificial intelligence  


        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While


            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If




        turn = turn + 1
    End Sub

    Private Sub btnrow7_Click(sender As Object, e As EventArgs) Handles btnrow7.Click
        'Counter
        If player = 0 Then
            If collumn7 = 0 Then
                PictureBox7_0.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn7 = 1 Then
                PictureBox7_1.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn7 = 2 Then
                PictureBox7_2.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn7 = 3 Then
                PictureBox7_3.Image = My.Resources.ResourceManager.GetObject("Red")

            ElseIf collumn7 = 4 Then
                PictureBox7_4.Image = My.Resources.ResourceManager.GetObject("Red")

            Else
                PictureBox7_5.Image = My.Resources.ResourceManager.GetObject("Red")


                btnrow7.Enabled = False

            End If
            player = player + 1
            multiarray(6, collumn7) = 1
            lblPlayer1.Enabled = False
            lblPlayer2.Enabled = True
        Else
            If collumn7 = 0 Then
                PictureBox7_0.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn7 = 1 Then
                PictureBox7_1.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn7 = 2 Then
                PictureBox7_2.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn7 = 3 Then
                PictureBox7_3.Image = My.Resources.ResourceManager.GetObject("Yellow")

            ElseIf collumn7 = 4 Then
                PictureBox7_4.Image = My.Resources.ResourceManager.GetObject("Yellow")

            Else
                PictureBox7_5.Image = My.Resources.ResourceManager.GetObject("Yellow")

                btnrow7.Enabled = False

            End If
            player = player - 1
            multiarray(6, collumn7) = 5
            lblPlayer1.Enabled = True
            lblPlayer2.Enabled = False
        End If
        collumn7 = collumn7 + 1


        'vertical check
        For j = 0 To 3
            If multiarray(6, j) + multiarray(6, j + 1) = 2 And multiarray(6, j + 2) + multiarray(6, j + 3) = 2 Then
                MsgBox(" Red player won.")
                Me.Close()
            ElseIf multiarray(6, j) + multiarray(6, j + 1) + multiarray(6, j + 2) + multiarray(6, j + 3) = 20 Then
                MsgBox("Yellow player won.")
                Me.Close()
            Else

            End If
        Next
        'Horizontal check
        For i = 0 To 3
            For j = 0 To 6
                If multiarray(i, j) + multiarray(i + 1, j) = 2 And multiarray(i + 2, j) + multiarray(i + 3, j) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'Diaganol right check
        For i = 0 To 3
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i + 1, j + 1) = 2 And multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next
        'diagonal left check
        For i = 3 To 6
            For j = 0 To 4
                If multiarray(i, j) + multiarray(i - 1, j + 1) = 2 And multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 2 Then
                    MsgBox(" Red player won.")
                    Me.Close()
                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 20 Then
                    MsgBox("Yellow player won.")
                    Me.Close()
                Else
                End If
            Next
        Next


        'Artificial intelligence
        If AI = True And player = 1 Then



            If B1 = ("Easy") Then
                While player = 1
                    If rng.Next(0, 6) = 0 Then
                    If btnRow1.Enabled <> False Then
                        btnRow1.PerformClick()
                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 1 Then
                    If btnrow2.Enabled <> False Then
                        btnrow2.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 2 Then
                    If btnrow3.Enabled <> False Then
                        btnrow3.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 3 Then
                    If btnrow4.Enabled <> False Then
                        btnrow4.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 4 Then
                    If btnrow4.Enabled <> False Then
                        btnrow5.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If
                ElseIf rng.Next(0, 6) = 5 Then
                    If btnrow6.Enabled <> False Then
                        btnrow6.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                ElseIf rng.Next(0, 6) = 6 Then
                    If btnrow7.Enabled <> False Then
                        btnrow7.PerformClick()

                    Else
                        rng.Next(0, 6)
                    End If

                End If
                End While
            ElseIf B1 = ("Medium") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(1, 100) < 99 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()
                                            MsgBox(multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2))
                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 1) = 1 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(1, 10) < 9 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 100) < 99 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next
                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 3) < 2 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While


            ElseIf B1 = ("Hard") Then
                While player = 1
                    'diagonal left win check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 15 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 15 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 15 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical win check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then ' simulate human error
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 1 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal win check
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 50) < 49 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 3, j) <> 1 Then
                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 1 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 1 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 15 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 1 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 15 Then
                                    If multiarray(i + 2, j) <> 1 Then
                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diagonal right win check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 15 Then
                                    If multiarray(i + 3, j + 3) <> 1 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 1 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 15 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 1 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 15 Then
                                    If multiarray(i + 2, j + 2) <> 1 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Horizontal  prevention check 
                    For i = 0 To 3
                        For j = 0 To 6
                            If player = 1 And rng.Next(0, 100) <= 99 Then
                                If multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 2, j) = 3 Then ' removed 3 or 15 line
                                    If (multiarray(i + 3, j) <> 5) Then

                                        If i = 0 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 Then
                                            If collumn1 = j And multiarray(i - 1, j) <> 5 Then
                                                btnRow1.PerformClick()
                                            ElseIf collumn5 = j Then
                                                btnrow5.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 Then
                                            If collumn2 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow2.PerformClick()
                                            ElseIf collumn6 = j Then
                                                btnrow6.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 Then
                                            If collumn3 = j And multiarray(i - 1, j) <> 5 Then
                                                btnrow3.PerformClick()
                                            ElseIf collumn7 = j Then
                                                btnrow7.PerformClick()
                                            Else
                                            End If
                                        Else
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j) + multiarray(i + 3, j) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i + 1, j) <> 5 Then
                                        If i = 0 And collumn2 = j Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j) + multiarray(i + 3, j) = 3 Then
                                    If multiarray(i + 2, j) <> 5 Then

                                        If i = 0 And collumn3 = j Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j Then
                                            btnrow6.PerformClick()
                                        Else
                                        End If
                                    Else
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'Vertical prevention check
                    For i = 0 To 6
                        For j = 0 To 3
                            If player = 1 And rng.Next(0, 1000) <= 999 Then
                                If multiarray(i, j) + multiarray(i, j + 1) + multiarray(i, j + 2) = 3 Then ' removed 3 or 15 line
                                    If multiarray(i, j + 3) <> 5 Then

                                        If i = 0 Then
                                            btnRow1.PerformClick()

                                        ElseIf i = 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 4 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 5 Then
                                            btnrow6.PerformClick()
                                        Else
                                            btnrow7.PerformClick()
                                        End If
                                    Else
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'Diaganol right prevention check
                    For i = 0 To 3
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 2, j + 2) = 3 Then
                                    If multiarray(i + 3, j + 3) <> 5 Then
                                        If i = 0 And collumn4 = j + 3 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 1 And collumn5 = j + 3 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 1 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnRow1.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 2 And collumn6 = j + 3 Then
                                            btnrow6.PerformClick()
                                        ElseIf i = 2 And j > 0 Then
                                            If collumn2 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow2.PerformClick()
                                            Else
                                            End If
                                        ElseIf i = 3 And collumn7 = j + 3 Then
                                            btnrow7.PerformClick()
                                        ElseIf i = 3 And j > 0 Then
                                            If collumn1 = j - 1 And multiarray(i - 1, j - 1) <> 5 Then
                                                btnrow3.PerformClick()
                                            Else
                                            End If

                                        Else
                                        End If
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 2, j + 2) + multiarray(i + 3, j + 3) = 3 Then 'removed   Or 15 And multiarray(i + 1, j + 1) <> 1 Or 5
                                    If multiarray(i + 1, j + 1) <> 5 Then
                                        If i = 0 And collumn2 = j + 1 Then
                                            btnrow2.PerformClick()
                                        ElseIf i = 1 And collumn3 = j + 1 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 2 And collumn4 = j + 1 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 3 And collumn5 = j + 1 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i + 1, j + 1) + multiarray(i + 3, j + 3) = 3 Then
                                    If multiarray(i + 2, j + 2) <> 5 Then
                                        If i = 0 And collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        ElseIf i = 1 And collumn4 = j + 2 Then
                                            btnrow4.PerformClick()
                                        ElseIf i = 2 And collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        ElseIf i = 3 And collumn6 = j + 2 Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                Else

                                End If
                            Else
                            End If
                        Next
                    Next

                    'diagonal left check
                    For i = 3 To 6
                        For j = 0 To 4
                            If player = 1 And rng.Next(0, 30) < 29 Then
                                If multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 2, j + 2) = 3 Then '
                                    If i = 3 Then
                                        If collumn1 = j + 3 Then
                                            btnRow1.PerformClick()
                                        ElseIf j > 0 And collumn5 = j - 1 Then
                                            btnrow5.PerformClick()
                                        Else
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn2 = j + 3 Then
                                            btnrow2.PerformClick()
                                        ElseIf j > 0 And collumn6 = j - 1 Then
                                            btnrow6.PerformClick()

                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 3 Then
                                            btnrow3.PerformClick()
                                        ElseIf j > 0 And collumn7 = j - 1 Then
                                            btnrow7.PerformClick()
                                        End If
                                    ElseIf i = 6 Then
                                        If collumn4 = j + 3 Then
                                            btnrow4.PerformClick()

                                        End If
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 2, j + 2) + multiarray(i - 3, j + 3) = 3 Then 'Diaganol with left middle missing
                                    If i = 3 And collumn3 = j + 1 Then
                                        btnrow3.PerformClick()

                                    ElseIf i = 4 And collumn4 = j + 1 Then
                                        btnrow4.PerformClick()
                                    ElseIf i = 5 And collumn5 = j + 1 Then
                                        btnrow5.PerformClick()
                                    ElseIf i = 6 And collumn6 = j + 1 Then
                                        btnrow6.PerformClick()
                                    Else
                                    End If
                                ElseIf multiarray(i, j) + multiarray(i - 1, j + 1) + multiarray(i - 3, j + 3) = 3 Then 'left diagonal with right missing middle
                                    If i = 3 Then
                                        If collumn2 = j + 2 Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf i = 4 Then
                                        If collumn3 = j + 2 Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf i = 5 Then
                                        If collumn3 = j + 2 Then
                                            btnrow4.PerformClick()

                                        End If
                                    ElseIf i = 6 Then
                                        If collumn5 = j + 2 Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next

                    'better starting moves
                    If player = 1 Then
                        'Between starter moves 
                        If collumn4 = 0 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 0 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 0 Then
                            btnrow3.PerformClick()
                        ElseIf collumn4 = 1 Then
                            btnrow4.PerformClick()
                        ElseIf collumn5 = 1 Then
                            btnrow5.PerformClick()
                        ElseIf collumn3 = 1 Then
                            btnrow3.PerformClick()
                        End If
                    End If

                    'win using a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) < 8 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 10 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 10 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Preventing a 3 in middle horizontal with the two side free
                    For i = 0 To 6
                        For j = 2 To 4
                            If player = 1 And rng.Next(0, 10) <= 4 Then
                                If multiarray(j + 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j - 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn2 = i AndAlso collumn1 = i Then
                                            btnrow2.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn2 = i AndAlso collumn6 = i Then
                                            btnrow3.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn3 = i AndAlso collumn7 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j + 1, i) + multiarray(j - 1, i) = 2 And (multiarray(j + 2, i) + multiarray(j, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn3 = i AndAlso collumn1 = i Then
                                            btnrow3.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn4 = i AndAlso collumn6 = i Then
                                            btnrow4.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn5 = i AndAlso collumn7 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    End If
                                ElseIf multiarray(j - 1, i) + multiarray(j, i) = 2 And (multiarray(j + 2, i) + multiarray(j + 1, i) = 0) Then
                                    If j = 2 Then
                                        If collumn5 = i And collumn4 = i AndAlso collumn1 = i Then
                                            btnrow4.PerformClick()
                                        End If

                                    ElseIf j = 3 Then
                                        If collumn3 = i And collumn5 = i AndAlso collumn6 = i Then
                                            btnrow5.PerformClick()
                                        End If
                                    ElseIf j = 4 Then
                                        If collumn4 = i And collumn6 = i AndAlso collumn7 = i Then
                                            btnrow6.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                            End If
                        Next
                    Next
                    'Filler moves
                    If player = 1 Then
                        If rng.Next(0, 6) = 0 Then
                            If btnRow1.Enabled <> False Then
                                btnRow1.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 1 Then
                            If btnrow2.Enabled <> False Then
                                btnrow2.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 2 Then
                            If btnrow3.Enabled <> False Then
                                btnrow3.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 3 Then
                            If btnrow4.Enabled <> False Then
                                btnrow4.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 4 Then
                            If btnrow4.Enabled <> False Then
                                btnrow5.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If
                        ElseIf rng.Next(0, 6) = 5 Then
                            If btnrow6.Enabled <> False Then
                                btnrow6.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        ElseIf rng.Next(0, 6) = 6 Then
                            If btnrow7.Enabled <> False Then
                                btnrow7.PerformClick()

                            Else
                                rng.Next(0, 6)
                            End If

                        End If
                    Else
                    End If
                End While
            Else
                MsgBox("Error!")
                Me.Close()

            End If




        End If

    End Sub

End Class
