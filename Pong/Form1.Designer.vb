<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.CPU = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.White
        Me.Player.Location = New System.Drawing.Point(12, 128)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(25, 170)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'CPU
        '
        Me.CPU.BackColor = System.Drawing.Color.White
        Me.CPU.Location = New System.Drawing.Point(1087, 128)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(25, 170)
        Me.CPU.TabIndex = 1
        Me.CPU.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.White
        Me.Ball.Location = New System.Drawing.Point(462, 166)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(25, 25)
        Me.Ball.TabIndex = 2
        Me.Ball.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(1088, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1142, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 63)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Classic"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1347, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 63)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Caldwell"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1142, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 57)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Green"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1348, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 57)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Speed"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1348, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 57)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Hide Ball"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1142, 167)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 57)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Red"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1124, 462)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Pong"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player As System.Windows.Forms.PictureBox
    Friend WithEvents CPU As System.Windows.Forms.PictureBox
    Friend WithEvents Ball As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
