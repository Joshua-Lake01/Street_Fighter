Public Class Form1
    Dim BlnJump As Boolean = True
    Dim pressedD As Boolean = False
    Dim pressedA As Boolean = False
    Sub mydelay()

        Dim icount As Integer = 1
        For icount = 1 To 1000000000
            icount = icount + 1
        Next



    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'character 1
        C1P1.Visible = True
        C1P2.Visible = False
        C1Bop1.Enabled = True
        C1Bop2.Enabled = False
        C1B1.Enabled = False
        C1B2.Enabled = False
        C1P3.Visible = False
        C1P4.Visible = False

        'character 2
        C2P1.Visible = True
        C2P2.Visible = False
        ProgressBar1.Value = 100
        ProgressBar2.Value = 100

        Label3.Visible = False
        Label4.Visible = False


    End Sub


    'character 1
    Private Sub C1Foward_Tick(sender As Object, e As EventArgs) Handles C1Foward.Tick

        If C1P1.Left > Me.Width - 200 Then
            C1Foward.Enabled = False
        Else
            C1P1.Left = C1P1.Left + 50
            C1P2.Left = C1P1.Left
            C1P3.Left = C1P1.Left
            C1P4.Left = C1P1.Left
            Label3.Left = C1P1.Left - 50
            Label3.Top = C1P1.Top - 70
            C1Punch.Left = C1P1.Left
            C1Foward.Enabled = False
        End If




    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "d" Then
            C1Foward.Enabled = True
            If pressedD = False Then
                pressedD = True
                pressedA = False
                C1B1.Enabled = True
                C1B2.Enabled = False
                C1Bop1.Enabled = False
                C1Bop2.Enabled = False
            End If

        End If
        If e.KeyChar = "a" Then
            C1Back.Enabled = True
            If pressedA = False Then
                pressedA = True
                pressedD = False
                C1B1.Enabled = False
                C1B2.Enabled = False
                C1Bop1.Enabled = True
                C1Bop2.Enabled = False

            End If
        End If

        If e.KeyChar = "w" Then
            If BlnJump = True Then
                C1Jump.Enabled = True
                BlnJump = False
            End If

        End If

        If e.KeyChar = "c" Then
            C1Punch1.Enabled = True
            If C1Punch.Enabled = True Then
                If C2P1.Left + C2P1.Width + 10 > C1P1.Left Then
                    If ProgressBar1.Value = 10 Then
                        Label4.Text = "Game Over"
                        Label4.Visible = True
                        C1Bop1.Enabled = False
                        C1Bop2.Enabled = False
                        C1B1.Enabled = False
                        C1B2.Enabled = False
                        C1Foward.Enabled = False
                        C1Back.Enabled = False
                        C1Punch.Enabled = False
                        C1Punch1.Enabled = False
                        Gravity.Enabled = False
                        C1Damage1.Enabled = False
                        C1Damage2.Enabled = False
                        C1Jump.Enabled = False

                    End If
                    ProgressBar1.Value = ProgressBar1.Value - 10
                    C1Damage1.Enabled = True
                End If
            End If
        End If

        'character 2
        If e.KeyChar = "l" Then
            C2Foward.Enabled = True
        End If
        If e.KeyChar = "j" Then
            C2Back.Enabled = True
        End If

    End Sub

    Private Sub C1Jump_Tick(sender As Object, e As EventArgs) Handles C1Jump.Tick
        Static x As Integer = 0
        If x < 3 Then
            C1P1.Top = C1P1.Top - 40
            C1P2.Top = C1P1.Top
            C1P3.Top = C1P1.Top
            C1P4.Top = C1P1.Top
            C1Punch.Top = C1P1.Top + 85
            x = x + 1

        Else
            Gravity.Enabled = True
            x = 0
            C1Jump.Enabled = False

        End If
    End Sub

    Private Sub C1Back_Tick(sender As Object, e As EventArgs) Handles C1Back.Tick
        If C2P1.Left + C2P1.Width + 10 < C1P1.Left Then
            C1Foward.Enabled = False
            If C1P1.Left < 30 Then
                C1Back.Enabled = False
            Else
                C1P1.Left = C1P1.Left - 30
                C1P2.Left = C1P1.Left
                C1P3.Left = C1P1.Left
                C1P4.Left = C1P1.Left
                Label3.Left = C1P1.Left - 50
                Label3.Top = C1P1.Top - 70
                C1Punch.Left = C1P1.Left
                C1Back.Enabled = False
            End If
        End If


    End Sub

    Private Sub Gravity_Tick(sender As Object, e As EventArgs) Handles Gravity.Tick

        Static x As Integer = 0
        If x < 3 Then
            C1P1.Top = C1P1.Top + 40
            C1P2.Top = C1P1.Top
            C1P3.Top = C1P1.Top
            C1P4.Top = C1P1.Top
            Label3.Left = C1P1.Left - 50
            Label3.Top = C1P1.Top - 70
            C1Punch.Top = C1P1.Top + 85
            x = x + 1

        Else
            Gravity.Enabled = False
            x = 0
            BlnJump = True

        End If
    End Sub

    Private Sub C1B1_Tick(sender As Object, e As EventArgs) Handles C1B1.Tick
        C1P3.Visible = False
        C1P4.Visible = True
        C1P1.Visible = False
        C1P2.Visible = False
        C1B1.Enabled = False
        C1B2.Enabled = True


    End Sub

    Private Sub C1B2_Tick(sender As Object, e As EventArgs) Handles C1B2.Tick
        C1P3.Visible = True
        C1P4.Visible = False
        C1P1.Visible = False
        C1P2.Visible = False
        C1B2.Enabled = False
        C1B1.Enabled = True
    End Sub
    Private Sub C1Bop1_Tick(sender As Object, e As EventArgs) Handles C1Bop1.Tick

        C1P1.Visible = False
        C1P2.Visible = True
        C1P3.Visible = False
        C1P4.Visible = False
        C1Bop1.Enabled = False
        C1Bop2.Enabled = True

    End Sub

    Private Sub C1Bop2_Tick(sender As Object, e As EventArgs) Handles C1Bop2.Tick
        C1P1.Visible = True
        C1P2.Visible = False
        C1P3.Visible = False
        C1P4.Visible = False
        C1Bop1.Enabled = True
        C1Bop2.Enabled = False

    End Sub
    'Character 2
    Private Sub C2B1_Tick(sender As Object, e As EventArgs) Handles C2B1.Tick
        C2P1.Visible = True
        C2P2.Visible = False
        C2B1.Enabled = False
        C2B2.Enabled = True

    End Sub

    Private Sub C2B2_Tick(sender As Object, e As EventArgs) Handles C2B2.Tick
        C2P1.Visible = False
        C2P2.Visible = True
        C2B1.Enabled = True
        C2B2.Enabled = False
    End Sub

    Private Sub C2Foward_Tick(sender As Object, e As EventArgs) Handles C2Foward.Tick
        If C1P1.Left > C2P1.Left + 293 Then
            C1Foward.Enabled = False
            If C2P1.Left > Me.Width - 200 Then
                C2Foward.Enabled = False
            Else
                C2P1.Left = C2P1.Left + 50
                C2P2.Left = C2P1.Left
                C2Foward.Enabled = False
            End If
        End If


    End Sub

    Private Sub C2Back_Tick(sender As Object, e As EventArgs) Handles C2Back.Tick
        If C2P1.Left < 30 Then
            C2Back.Enabled = False
        Else
            C2P1.Left = C2P1.Left - 50
            C2P2.Left = C2P1.Left
            C2Back.Enabled = False
        End If
    End Sub

    Private Sub C1Punch1_Tick(sender As Object, e As EventArgs) Handles C1Punch1.Tick
        C1Punch.Visible = True
        C1P2.Visible = False
        C1P1.Visible = False
        C1Punch1.Enabled = False
        C1Punch2.Enabled = True


    End Sub

    Private Sub C1Punch2_Tick(sender As Object, e As EventArgs) Handles C1Punch2.Tick
        C1Punch.Visible = False
        C1P2.Visible = True
        C1P1.Visible = False
        C1Punch1.Enabled = False
        C1Punch2.Enabled = False
    End Sub

    Private Sub C1Damage1_Tick(sender As Object, e As EventArgs) Handles C1Damage1.Tick
        Label3.Visible = True
        C1Damage2.Enabled = True
        C1Damage1.Enabled = False
    End Sub

    Private Sub C1Damage2_Tick(sender As Object, e As EventArgs) Handles C1Damage2.Tick
        Label3.Visible = False
        C1Damage2.Enabled = False
        C1Damage1.Enabled = False
    End Sub
End Class
