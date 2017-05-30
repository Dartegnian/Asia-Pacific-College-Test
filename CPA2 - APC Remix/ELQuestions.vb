Public Class ELQuestions
    Dim OVScore As Integer

    Private Sub ELAns1_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns1.CheckedChanged
        If (ELAns1.Checked = True) Then
            ELAns2.Enabled = False
            ELAns3.Enabled = False
            ELAns4.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns2_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns2.CheckedChanged
        If (ELAns2.Checked = True) Then
            ELAns1.Enabled = False
            ELAns3.Enabled = False
            ELAns4.Enabled = False
        End If

    End Sub

    Private Sub ELAns3_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns3.CheckedChanged
        If (ELAns3.Checked = True) Then
            ELAns2.Enabled = False
            ELAns1.Enabled = False
            ELAns4.Enabled = False
        End If

    End Sub

    Private Sub ELAns4_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns4.CheckedChanged
        If (ELAns4.Checked = True) Then
            ELAns2.Enabled = False
            ELAns3.Enabled = False
            ELAns1.Enabled = False
        End If

    End Sub

    Private Sub ELAns5_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns5.CheckedChanged
        If (ELAns5.Checked = True) Then
            ELAns6.Enabled = False
            ELAns7.Enabled = False
            ELAns8.Enabled = False
        End If

    End Sub

    Private Sub ELAns6_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns6.CheckedChanged
        If (ELAns6.Checked = True) Then
            ELAns5.Enabled = False
            ELAns7.Enabled = False
            ELAns8.Enabled = False
        End If

    End Sub

    Private Sub ELAns7_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns7.CheckedChanged
        If (ELAns7.Checked = True) Then
            ELAns6.Enabled = False
            ELAns5.Enabled = False
            ELAns8.Enabled = False
        End If

    End Sub

    Private Sub ELAns8_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns8.CheckedChanged
        If (ELAns8.Checked = True) Then
            ELAns6.Enabled = False
            ELAns7.Enabled = False
            ELAns5.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns9_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns9.CheckedChanged
        If (ELAns9.Checked = True) Then
            ELAns10.Enabled = False
            ELAns11.Enabled = False
            ELAns12.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns10_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns10.CheckedChanged
        If (ELAns10.Checked = True) Then
            ELAns9.Enabled = False
            ELAns11.Enabled = False
            ELAns12.Enabled = False
        End If

    End Sub

    Private Sub ELAns11_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns11.CheckedChanged
        If (ELAns11.Checked = True) Then
            ELAns10.Enabled = False
            ELAns9.Enabled = False
            ELAns12.Enabled = False
        End If

    End Sub

    Private Sub ELAns12_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns12.CheckedChanged
        If (ELAns12.Checked = True) Then
            ELAns10.Enabled = False
            ELAns11.Enabled = False
            ELAns9.Enabled = False
        End If

    End Sub

    Private Sub ELAns13_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns13.CheckedChanged
        If (ELAns13.Checked = True) Then
            ELAns14.Enabled = False
            ELAns15.Enabled = False
            ELAns16.Enabled = False


        End If

    End Sub

    Private Sub ELAns14_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns14.CheckedChanged
        If (ELAns14.Checked = True) Then
            ELAns13.Enabled = False
            ELAns15.Enabled = False
            ELAns16.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns15_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns15.CheckedChanged
        If (ELAns15.Checked = True) Then
            ELAns14.Enabled = False
            ELAns13.Enabled = False
            ELAns16.Enabled = False
        End If

    End Sub

    Private Sub ELAns16_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns16.CheckedChanged
        If (ELAns16.Checked = True) Then
            ELAns14.Enabled = False
            ELAns15.Enabled = False
            ELAns13.Enabled = False
        End If

    End Sub

    Private Sub ELAns17_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns17.CheckedChanged
        If (ELAns17.Checked = True) Then
            ELAns18.Enabled = False
            ELAns19.Enabled = False
            ELAns20.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns18_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns18.CheckedChanged
        If (ELAns18.Checked = True) Then
            ELAns17.Enabled = False
            ELAns19.Enabled = False
            ELAns20.Enabled = False
        End If

    End Sub

    Private Sub ELAns19_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns19.CheckedChanged
        If (ELAns19.Checked = True) Then
            ELAns18.Enabled = False
            ELAns17.Enabled = False
            ELAns20.Enabled = False
        End If

    End Sub

    Private Sub ELAns20_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns20.CheckedChanged
        If (ELAns20.Checked = True) Then
            ELAns18.Enabled = False
            ELAns19.Enabled = False
            ELAns17.Enabled = False
        End If

    End Sub

    Private Sub ELAns21_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns21.CheckedChanged
        If (ELAns21.Checked = True) Then
            ELAns22.Enabled = False
            ELAns23.Enabled = False
            ELAns24.Enabled = False
        End If

    End Sub

    Private Sub ELAns22_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns22.CheckedChanged
        If (ELAns22.Checked = True) Then
            ELAns21.Enabled = False
            ELAns23.Enabled = False
            ELAns24.Enabled = False
        End If

    End Sub

    Private Sub ELAns23_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns23.CheckedChanged
        If (ELAns23.Checked = True) Then
            ELAns22.Enabled = False
            ELAns21.Enabled = False
            ELAns24.Enabled = False
        End If

    End Sub

    Private Sub ELAns24_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns24.CheckedChanged
        If (ELAns24.Checked = True) Then
            ELAns22.Enabled = False
            ELAns23.Enabled = False
            ELAns21.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns25_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns25.CheckedChanged
        If (ELAns25.Checked = True) Then
            ELAns26.Enabled = False
            ELAns27.Enabled = False
            ELAns28.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns26_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns26.CheckedChanged
        If (ELAns26.Checked = True) Then
            ELAns25.Enabled = False
            ELAns27.Enabled = False
            ELAns28.Enabled = False
        End If

    End Sub

    Private Sub ELAns27_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns27.CheckedChanged
        If (ELAns27.Checked = True) Then
            ELAns26.Enabled = False
            ELAns25.Enabled = False
            ELAns28.Enabled = False
        End If

    End Sub

    Private Sub ELAns28_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns28.CheckedChanged
        If (ELAns28.Checked = True) Then
            ELAns26.Enabled = False
            ELAns27.Enabled = False
            ELAns25.Enabled = False
        End If

    End Sub

    Private Sub ELAns29_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns29.CheckedChanged
        If (ELAns29.Checked = True) Then
            ELAns30.Enabled = False
            ELAns31.Enabled = False
            ELAns32.Enabled = False
        End If

    End Sub

    Private Sub ELAns30_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns30.CheckedChanged
        If (ELAns30.Checked = True) Then
            ELAns29.Enabled = False
            ELAns31.Enabled = False
            ELAns32.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns31_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns31.CheckedChanged
        If (ELAns31.Checked = True) Then
            ELAns30.Enabled = False
            ELAns29.Enabled = False
            ELAns32.Enabled = False
        End If

    End Sub

    Private Sub ELAns32_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns32.CheckedChanged
        If (ELAns32.Checked = True) Then
            ELAns30.Enabled = False
            ELAns31.Enabled = False
            ELAns29.Enabled = False
        End If

    End Sub

    Private Sub ELAns33_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns33.CheckedChanged
        If (ELAns33.Checked = True) Then
            ELAns34.Enabled = False
            ELAns35.Enabled = False
            ELAns36.Enabled = False
        End If

    End Sub

    Private Sub ELAns34_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns34.CheckedChanged
        If (ELAns34.Checked = True) Then
            ELAns33.Enabled = False
            ELAns35.Enabled = False
            ELAns36.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub ELAns35_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns35.CheckedChanged
        If (ELAns35.Checked = True) Then
            ELAns34.Enabled = False
            ELAns33.Enabled = False
            ELAns36.Enabled = False
        End If

    End Sub

    Private Sub ELAns36_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns36.CheckedChanged
        If (ELAns36.Checked = True) Then
            ELAns34.Enabled = False
            ELAns35.Enabled = False
            ELAns33.Enabled = False
        End If

    End Sub

    Private Sub ELAns37_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns37.CheckedChanged
        If (ELAns37.Checked = True) Then
            ELAns38.Enabled = False
            ELAns39.Enabled = False
            ELAns40.Enabled = False
        End If

    End Sub

    Private Sub ELAns38_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns38.CheckedChanged
        If (ELAns38.Checked = True) Then
            ELAns37.Enabled = False
            ELAns39.Enabled = False
            ELAns40.Enabled = False
        End If

    End Sub

    Private Sub ELAns39_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns39.CheckedChanged
        If (ELAns39.Checked = True) Then
            ELAns38.Enabled = False
            ELAns37.Enabled = False
            ELAns40.Enabled = False
        End If

    End Sub

    Private Sub ELAns40_CheckedChanged(sender As Object, e As EventArgs) Handles ELAns40.CheckedChanged
        If (ELAns40.Checked = True) Then
            ELAns38.Enabled = False
            ELAns39.Enabled = False
            ELAns37.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub
End Class