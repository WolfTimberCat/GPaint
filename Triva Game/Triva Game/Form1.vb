Public Class Form1
    Dim correct As Integer
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click


        Submit.Enabled = False


        If RadioButton1.Checked And correct = 1 Then
            MsgBox("Correct")
        ElseIf RadioButton2.Checked And correct = 2 Then
            MsgBox("Correct")
        ElseIf RadioButton3.Checked And correct = 3 Then
            MsgBox("Correct")
        ElseIf RadioButton4.Checked And correct = 4 Then
            MsgBox("Correct")
        Else
            MsgBox("Incorrect")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Question1.Click
        correct = 1
        AnswerBox.Enabled = True
        Submit.Enabled = True

        RadioButton1.Text = ("July 31, 2015")
        RadioButton2.Text = ("July 4, 2013")
        RadioButton3.Text = ("July 31, 2014")
        RadioButton4.Text = ("March 30, 2015")
        Label1.Text = "When did the last blue moon occured?"


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        correct = 3
        AnswerBox.Enabled = True
        Submit.Enabled = True

        RadioButton1.Text = ("432,000 mi")
        RadioButton2.Text = ("432,288 mi")
        RadioButton3.Text = ("10000 yds")
        RadioButton4.Text = ("53648 ft")


        Label1.Text = "What is an average size for a sun?"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        correct = 4
        AnswerBox.Enabled = True
        Submit.Enabled = True

        RadioButton1.Text = ("1")
        RadioButton2.Text = ("5")
        RadioButton3.Text = ("None")
        RadioButton4.Text = ("3")



        Label1.Text = "(According to theory) How many types of black holes are there?"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        correct = 1
        AnswerBox.Enabled = True
        Submit.Enabled = True

        RadioButton1.Text = ("248 Years")
        RadioButton2.Text = ("37 Weeks")
        RadioButton3.Text = ("1483 Days")
        RadioButton4.Text = ("989 Hours")

        Label1.Text = "how long does it take for Pluto to ordit the sun?"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        correct = 2
        AnswerBox.Enabled = True
        Submit.Enabled = True

        RadioButton1.Text = ("a")
        RadioButton2.Text = ("b")
        RadioButton3.Text = ("c")
        RadioButton4.Text = ("d")

        Label1.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles AnswerBox.Paint

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
