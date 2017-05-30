Public Class CSQuestions2
    Shared CSScore As Integer
    Dim csqSet1

    Public Shared Function getScore() As Integer
        Return CSScore
    End Function

    Private Sub CSQuestions2_Load(sender As Object, e As EventArgs) Handles Me.Load
        CSScore = CSQuestions1.getScore()
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns1_CheckedChanged(sender As Object, e As EventArgs) Handles csAns1.CheckedChanged
        If (csAns1.Checked = True) Then
            csAns2.Enabled = False
            csAns3.Enabled = False
            csAns4.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns2_CheckedChanged(sender As Object, e As EventArgs) Handles csAns2.CheckedChanged
        If (csAns2.Checked = True) Then
            csAns1.Enabled = False
            csAns3.Enabled = False
            csAns4.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns3_CheckedChanged(sender As Object, e As EventArgs) Handles csAns3.CheckedChanged
        If (csAns3.Checked = True) Then
            csAns2.Enabled = False
            csAns1.Enabled = False
            csAns4.Enabled = False
            CSScore += 5
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns4_CheckedChanged(sender As Object, e As EventArgs) Handles csAns4.CheckedChanged
        If (csAns4.Checked = True) Then
            csAns2.Enabled = False
            csAns3.Enabled = False
            csAns1.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns5_CheckedChanged(sender As Object, e As EventArgs) Handles csAns5.CheckedChanged
        If (csAns5.Checked = True) Then
            csAns6.Enabled = False
            csAns7.Enabled = False
            csAns8.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns6_CheckedChanged(sender As Object, e As EventArgs) Handles csAns6.CheckedChanged
        If (csAns6.Checked = True) Then
            csAns5.Enabled = False
            csAns7.Enabled = False
            csAns8.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns7_CheckedChanged(sender As Object, e As EventArgs) Handles csAns7.CheckedChanged
        If (csAns7.Checked = True) Then
            csAns6.Enabled = False
            csAns5.Enabled = False
            csAns8.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns8_CheckedChanged(sender As Object, e As EventArgs) Handles csAns8.CheckedChanged
        If (csAns8.Checked = True) Then
            csAns6.Enabled = False
            csAns7.Enabled = False
            csAns5.Enabled = False
            CSScore += 5
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns9_CheckedChanged(sender As Object, e As EventArgs) Handles csAns9.CheckedChanged
        If (csAns9.Checked = True) Then
            csAns10.Enabled = False
            csAns11.Enabled = False
            csAns12.Enabled = False
            CSScore += 5
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns10_CheckedChanged(sender As Object, e As EventArgs) Handles csAns10.CheckedChanged
        If (csAns10.Checked = True) Then
            csAns9.Enabled = False
            csAns11.Enabled = False
            csAns12.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns11_CheckedChanged(sender As Object, e As EventArgs) Handles csAns11.CheckedChanged
        If (csAns11.Checked = True) Then
            csAns10.Enabled = False
            csAns9.Enabled = False
            csAns12.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns12_CheckedChanged(sender As Object, e As EventArgs) Handles csAns12.CheckedChanged
        If (csAns12.Checked = True) Then
            csAns10.Enabled = False
            csAns11.Enabled = False
            csAns9.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns13_CheckedChanged(sender As Object, e As EventArgs) Handles csAns13.CheckedChanged
        If (csAns13.Checked = True) Then
            csAns14.Enabled = False
            csAns15.Enabled = False
            csAns16.Enabled = False
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns14_CheckedChanged(sender As Object, e As EventArgs) Handles csAns14.CheckedChanged
        If (csAns14.Checked = True) Then
            csAns13.Enabled = False
            csAns15.Enabled = False
            csAns16.Enabled = False


        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns15_CheckedChanged(sender As Object, e As EventArgs) Handles csAns15.CheckedChanged
        If (csAns15.Checked = True) Then
            csAns14.Enabled = False
            csAns13.Enabled = False
            csAns16.Enabled = False


            CSScore += 5
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns16_CheckedChanged(sender As Object, e As EventArgs) Handles csAns16.CheckedChanged
        If (csAns16.Checked = True) Then
            csAns14.Enabled = False
            csAns15.Enabled = False
            csAns13.Enabled = False


        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns17_CheckedChanged(sender As Object, e As EventArgs) Handles csAns17.CheckedChanged
        If (csAns17.Checked = True) Then
            csAns18.Enabled = False
            csAns19.Enabled = False
            csAns20.Enabled = False


        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns18_CheckedChanged(sender As Object, e As EventArgs) Handles csAns18.CheckedChanged
        If (csAns18.Checked = True) Then
            csAns17.Enabled = False
            csAns19.Enabled = False
            csAns20.Enabled = False


        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns19_CheckedChanged(sender As Object, e As EventArgs) Handles csAns19.CheckedChanged
        If (csAns19.Checked = True) Then
            csAns18.Enabled = False
            csAns17.Enabled = False
            csAns20.Enabled = False


        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub

    Private Sub csAns20_CheckedChanged(sender As Object, e As EventArgs) Handles csAns20.CheckedChanged
        If (csAns20.Checked = True) Then
            csAns18.Enabled = False
            csAns19.Enabled = False
            csAns17.Enabled = False


            CSScore += 5
        End If
        Form1.CurrentCSScore.Text = CSScore
    End Sub
End Class
