Public Class Form1

    Dim speed As Single = 10

    Dim rndInst As New Random()

    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed

    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed

    Dim CPUScore As Integer = 0

    Dim PlayerScore As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Ball.Location.Y > 5 And Ball.Location.Y < Me.Height - 40 - Player.Height Then

            CPU.Location = New Point(CPU.Location.X, Ball.Location.Y - 10)

        End If

        Ball.Location = New Point(Ball.Location.X + xVel, Ball.Location.Y + yVel)

        If Ball.Location.Y < 0 Then

            Ball.Location = New Point(Ball.Location.X, 0)
            yVel = -yVel

        End If


        If Ball.Location.Y > Me.Height - Ball.Size.Height - 45 Then

            Ball.Location = New Point(Ball.Location.X, Me.Height - Ball.Size.Height - 45)
            yVel = -yVel

        End If


        If Ball.Bounds.IntersectsWith(Player.Bounds) Then

            Ball.Location = New Point(Player.Location.X + Ball.Size.Width, Ball.Location.Y)
            xVel = -xVel

        End If


        If Ball.Bounds.IntersectsWith(CPU.Bounds) Then

            Ball.Location = New Point(CPU.Location.X - CPU.Size.Width - 1, Ball.Location.Y)
            xVel = -xVel

        End If

        If Ball.Location.X < 0 Then

            CPUScore = CPUScore + 1
            Ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            Label2.Text = CPUScore

        End If

        If Ball.Location.X > Me.Width - Ball.Size.Width - Player.Width Then

            PlayerScore = PlayerScore + 1
            Ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            Label1.Text = PlayerScore

        End If

        'resize the screen + have cpu paddle stay near right boundary
        'CPU.Location = New Point(, CPU.Location.Y - 10)

    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Y > 5 And e.Y < Me.Height - 40 - Player.Height Then

            Player.Location = New Point(Player.Location.X, e.Y)

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Player.BackColor = Color.White
        CPU.BackColor = Color.White
        Ball.BackColor = Color.White
        Me.BackColor = Color.Black
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Player.BackColor = Color.Blue
        CPU.BackColor = Color.Blue
        Ball.BackColor = Color.Blue
        Me.BackColor = Color.White
        Label1.ForeColor = Color.Blue
        Label2.ForeColor = Color.Blue

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Player.BackColor = Color.LimeGreen
        CPU.BackColor = Color.LimeGreen
        Ball.BackColor = Color.LimeGreen
        Me.BackColor = Color.Black
        Label1.ForeColor = Color.LimeGreen
        Label2.ForeColor = Color.LimeGreen

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        xVel = xVel + 25
        yVel = yVel + 25

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Ball.BackColor = Color.Empty

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Player.BackColor = Color.Red
        CPU.BackColor = Color.Red
        Ball.BackColor = Color.Red
        Me.BackColor = Color.Black
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red

    End Sub
End Class
