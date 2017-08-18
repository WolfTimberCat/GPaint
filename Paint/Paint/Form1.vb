Public Class Form1
    Dim click As String
    Dim myBrush As New SolidBrush(Color.Black)
    Dim thickness As Integer = 10
    Dim rightclick As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'IDK.Enabled = False
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        'draw.FillEllipse(Brushes.Gray, 450, 50, 300, 300)
        'draw.FillRectangle(Brushes.Gray, 520, 30, 150, 150)
        'draw.FillRectangle(Brushes.Gray, 520, 230, 150, 150)
        'draw.FillRectangle(Brushes.Black, 0, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 300, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 600, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 900, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 150, 150, 150, 150)   
        'draw.FillRectangle(Brushes.Black, 450, 150, 150, 150)
        'draw.FillRectangle(Brushes.Black, 750, 150, 150, 150)
        'draw.FillRectangle(Brushes.Black, 1053, 150, 150, 150)
        'draw.FillRectangle(Brushes.Black, 0, 300, 150, 150)
        'draw.FillRectangle(Brushes.Black, 0, 600, 150, 150)
        'draw.FillRectangle(Brushes.Black, 300, 300, 150, 150)
        'draw.FillRectangle(Brushes.Black, 600, 300, 150, 150)
        'draw.FillRectangle(Brushes.Black, 900, 300, 150, 150)
        'draw.FillRectangle(Brushes.Black, 1200, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 1500, 0, 150, 150)
        'draw.FillRectangle(Brushes.Black, 1353, 150, 150, 150)






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        Dim XPos As Integer = Me.MousePosition.X - Me.Location.X - 15
        Dim yPos As Integer = Me.MousePosition.Y - Me.Location.Y - 40


        Label1.Text = XPos
        Label2.Text = yPos


        If click >= 1 Then
            draw.FillEllipse(myBrush, XPos, yPos, thickness, thickness)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        click = 1
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        click = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Black

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)








    End Sub

    Private Sub Gray_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Gray

    End Sub

    Private Sub White_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.White
    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Red
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Orange
    End Sub

    Private Sub Yellow_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Green_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Green
    End Sub

    Private Sub Blue_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Blue
    End Sub

    Private Sub Purple1_Click(sender As Object, e As EventArgs)
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            thickness = thickness + 1
        Else
            thickness = thickness - 1
        End If
    End Sub

    Private Sub Square_Click(sender As Object, e As EventArgs)
        'Dim draw As System.Drawing.Graphics
        'draw = Me.CreateGraphics
        'Dim XPos As Integer = Me.MousePosition.X - Me.Location.X - 15
        'Dim yPos As Integer = Me.MousePosition.Y - Me.Location.Y - 40
        'If rightclick Then
        '    draw.DrawRectangle(New Pen(myBrush.Color, thickness), XPos, yPos, 100, 100)
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        myBrush.Color = Color.Blue
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        myBrush.Color = Color.Orange
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBrush.Color = Color.LightGreen
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        myBrush.Color = Color.LightBlue
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        myBrush.Color = Color.White
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
