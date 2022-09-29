<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.C1Bop1 = New System.Windows.Forms.Timer(Me.components)
        Me.C1Bop2 = New System.Windows.Forms.Timer(Me.components)
        Me.C1Foward = New System.Windows.Forms.Timer(Me.components)
        Me.C1Back = New System.Windows.Forms.Timer(Me.components)
        Me.C1Jump = New System.Windows.Forms.Timer(Me.components)
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.C1B1 = New System.Windows.Forms.Timer(Me.components)
        Me.C1B2 = New System.Windows.Forms.Timer(Me.components)
        Me.C2B1 = New System.Windows.Forms.Timer(Me.components)
        Me.C2B2 = New System.Windows.Forms.Timer(Me.components)
        Me.C2B3 = New System.Windows.Forms.Timer(Me.components)
        Me.C2B4 = New System.Windows.Forms.Timer(Me.components)
        Me.C2Foward = New System.Windows.Forms.Timer(Me.components)
        Me.C2Back = New System.Windows.Forms.Timer(Me.components)
        Me.C2Jump = New System.Windows.Forms.Timer(Me.components)
        Me.C2Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.C1Punch1 = New System.Windows.Forms.Timer(Me.components)
        Me.C1Punch2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.C1Punch = New System.Windows.Forms.PictureBox()
        Me.C2P1 = New System.Windows.Forms.PictureBox()
        Me.C2P2 = New System.Windows.Forms.PictureBox()
        Me.C1P4 = New System.Windows.Forms.PictureBox()
        Me.C1P3 = New System.Windows.Forms.PictureBox()
        Me.C1P2 = New System.Windows.Forms.PictureBox()
        Me.C1P1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1Damage1 = New System.Windows.Forms.Timer(Me.components)
        Me.C1Damage2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Punch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1P4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1P3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Bop1
        '
        Me.C1Bop1.Interval = 400
        '
        'C1Bop2
        '
        Me.C1Bop2.Interval = 400
        '
        'C1Foward
        '
        '
        'C1Back
        '
        '
        'C1Jump
        '
        '
        'Gravity
        '
        '
        'C1B1
        '
        Me.C1B1.Interval = 400
        '
        'C1B2
        '
        Me.C1B2.Interval = 400
        '
        'C2B1
        '
        Me.C2B1.Enabled = True
        Me.C2B1.Interval = 400
        '
        'C2B2
        '
        Me.C2B2.Interval = 400
        '
        'C2B3
        '
        Me.C2B3.Interval = 400
        '
        'C2B4
        '
        Me.C2B4.Interval = 400
        '
        'C2Foward
        '
        '
        'C2Back
        '
        '
        'C1Punch1
        '
        '
        'C1Punch2
        '
        Me.C1Punch2.Interval = 300
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 120)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1258, 52)
        Me.ProgressBar1.TabIndex = 7
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(1466, 120)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(1258, 52)
        Me.ProgressBar2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Tan
        Me.PictureBox1.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.Vs3
        Me.PictureBox1.Location = New System.Drawing.Point(1276, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 160)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'C1Punch
        '
        Me.C1Punch.BackColor = System.Drawing.Color.Transparent
        Me.C1Punch.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.Punch
        Me.C1Punch.Location = New System.Drawing.Point(2112, 1249)
        Me.C1Punch.Name = "C1Punch"
        Me.C1Punch.Size = New System.Drawing.Size(474, 376)
        Me.C1Punch.TabIndex = 6
        Me.C1Punch.TabStop = False
        Me.C1Punch.Visible = False
        '
        'C2P1
        '
        Me.C2P1.BackColor = System.Drawing.Color.Transparent
        Me.C2P1.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B13
        Me.C2P1.Location = New System.Drawing.Point(115, 1099)
        Me.C2P1.Name = "C2P1"
        Me.C2P1.Size = New System.Drawing.Size(353, 526)
        Me.C2P1.TabIndex = 5
        Me.C2P1.TabStop = False
        '
        'C2P2
        '
        Me.C2P2.BackColor = System.Drawing.Color.Transparent
        Me.C2P2.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B22
        Me.C2P2.Location = New System.Drawing.Point(115, 1099)
        Me.C2P2.Name = "C2P2"
        Me.C2P2.Size = New System.Drawing.Size(353, 526)
        Me.C2P2.TabIndex = 4
        Me.C2P2.TabStop = False
        '
        'C1P4
        '
        Me.C1P4.BackColor = System.Drawing.Color.Transparent
        Me.C1P4.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B2_Back
        Me.C1P4.Location = New System.Drawing.Point(2233, 1099)
        Me.C1P4.Name = "C1P4"
        Me.C1P4.Size = New System.Drawing.Size(353, 526)
        Me.C1P4.TabIndex = 3
        Me.C1P4.TabStop = False
        Me.C1P4.Visible = False
        '
        'C1P3
        '
        Me.C1P3.BackColor = System.Drawing.Color.Transparent
        Me.C1P3.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B1_Back
        Me.C1P3.Location = New System.Drawing.Point(2233, 1099)
        Me.C1P3.Name = "C1P3"
        Me.C1P3.Size = New System.Drawing.Size(353, 526)
        Me.C1P3.TabIndex = 2
        Me.C1P3.TabStop = False
        Me.C1P3.Visible = False
        '
        'C1P2
        '
        Me.C1P2.BackColor = System.Drawing.Color.Transparent
        Me.C1P2.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B2
        Me.C1P2.Location = New System.Drawing.Point(2233, 1099)
        Me.C1P2.Name = "C1P2"
        Me.C1P2.Size = New System.Drawing.Size(353, 526)
        Me.C1P2.TabIndex = 1
        Me.C1P2.TabStop = False
        Me.C1P2.Visible = False
        '
        'C1P1
        '
        Me.C1P1.BackColor = System.Drawing.Color.Transparent
        Me.C1P1.BackgroundImage = Global.Street_Fighter_Character_Movement.My.Resources.Resources.B1
        Me.C1P1.Location = New System.Drawing.Point(2233, 1099)
        Me.C1P1.Name = "C1P1"
        Me.C1P1.Size = New System.Drawing.Size(353, 526)
        Me.C1P1.TabIndex = 0
        Me.C1P1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 115)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1928, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 115)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Player 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 883)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 58)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "- 10"
        '
        'C1Damage1
        '
        '
        'C1Damage2
        '
        Me.C1Damage2.Interval = 600
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1142, 780)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 122)
        Me.Label4.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(2740, 1707)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.C1Punch)
        Me.Controls.Add(Me.C2P1)
        Me.Controls.Add(Me.C2P2)
        Me.Controls.Add(Me.C1P4)
        Me.Controls.Add(Me.C1P3)
        Me.Controls.Add(Me.C1P2)
        Me.Controls.Add(Me.C1P1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Punch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1P4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1P3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1P1 As PictureBox
    Friend WithEvents C1Bop1 As Timer
    Friend WithEvents C1Bop2 As Timer
    Friend WithEvents C1P2 As PictureBox
    Friend WithEvents C1Foward As Timer
    Friend WithEvents C1Back As Timer
    Friend WithEvents C1Jump As Timer
    Friend WithEvents Gravity As Timer
    Friend WithEvents C1P3 As PictureBox
    Friend WithEvents C1P4 As PictureBox
    Friend WithEvents C1B1 As Timer
    Friend WithEvents C1B2 As Timer
    Friend WithEvents C2P2 As PictureBox
    Friend WithEvents C2P1 As PictureBox
    Friend WithEvents C2B1 As Timer
    Friend WithEvents C2B2 As Timer
    Friend WithEvents C2B3 As Timer
    Friend WithEvents C2B4 As Timer
    Friend WithEvents C2Foward As Timer
    Friend WithEvents C2Back As Timer
    Friend WithEvents C2Jump As Timer
    Friend WithEvents C2Gravity As Timer
    Friend WithEvents C1Punch1 As Timer
    Friend WithEvents C1Punch As PictureBox
    Friend WithEvents C1Punch2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents C1Damage1 As Timer
    Friend WithEvents C1Damage2 As Timer
    Friend WithEvents Label4 As Label
End Class
