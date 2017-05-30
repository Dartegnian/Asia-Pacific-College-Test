Public Class CSQuestions
    Dim OVScore As Integer

    Private Sub CSAns1_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns1.CheckedChanged
        If (CSAns1.Checked = True) Then
            CSAns2.Enabled = False
            CSAns3.Enabled = False
            CSAns4.Enabled = False
        End If
    End Sub

    Private Sub CSAns2_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns2.CheckedChanged
        If (CSAns2.Checked = True) Then
            CSAns1.Enabled = False
            CSAns3.Enabled = False
            CSAns4.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns3_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns3.CheckedChanged
        If (CSAns3.Checked = True) Then
            CSAns2.Enabled = False
            CSAns1.Enabled = False
            CSAns4.Enabled = False
        End If
    End Sub

    Private Sub CSAns4_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns4.CheckedChanged
        If (CSAns4.Checked = True) Then
            CSAns2.Enabled = False
            CSAns3.Enabled = False
            CSAns1.Enabled = False
        End If
    End Sub

    Private Sub CSAns5_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns5.CheckedChanged
        If (CSAns5.Checked = True) Then
            CSAns6.Enabled = False
            CSAns7.Enabled = False
            CSAns8.Enabled = False
        End If
    End Sub

    Private Sub CSAns6_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns6.CheckedChanged
        If (CSAns6.Checked = True) Then
            CSAns5.Enabled = False
            CSAns7.Enabled = False
            CSAns8.Enabled = False
        End If

    End Sub

    Private Sub CSAns7_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns7.CheckedChanged
        If (CSAns7.Checked = True) Then
            CSAns6.Enabled = False
            CSAns5.Enabled = False
            CSAns8.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns8_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns8.CheckedChanged
        If (CSAns8.Checked = True) Then
            CSAns6.Enabled = False
            CSAns7.Enabled = False
            CSAns5.Enabled = False
        End If

    End Sub

    Private Sub CSAns9_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns9.CheckedChanged
        If (CSAns9.Checked = True) Then
            CSAns10.Enabled = False
            CSAns11.Enabled = False
            CSAns12.Enabled = False


        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns10_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns10.CheckedChanged
        If (CSAns10.Checked = True) Then
            CSAns9.Enabled = False
            CSAns11.Enabled = False
            CSAns12.Enabled = False
        End If

    End Sub

    Private Sub CSAns11_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns11.CheckedChanged
        If (CSAns11.Checked = True) Then
            CSAns10.Enabled = False
            CSAns9.Enabled = False
            CSAns12.Enabled = False
        End If

    End Sub

    Private Sub CSAns12_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns12.CheckedChanged
        If (CSAns12.Checked = True) Then
            CSAns10.Enabled = False
            CSAns11.Enabled = False
            CSAns9.Enabled = False
        End If

    End Sub

    Private Sub CSAns13_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns13.CheckedChanged
        If (CSAns13.Checked = True) Then
            CSAns14.Enabled = False
            CSAns15.Enabled = False
            CSAns16.Enabled = False


        End If

    End Sub

    Private Sub CSAns14_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns14.CheckedChanged
        If (CSAns14.Checked = True) Then
            CSAns13.Enabled = False
            CSAns15.Enabled = False
            CSAns16.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns15_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns15.CheckedChanged
        If (CSAns15.Checked = True) Then
            CSAns14.Enabled = False
            CSAns13.Enabled = False
            CSAns16.Enabled = False
        End If

    End Sub

    Private Sub CSAns16_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns16.CheckedChanged
        If (CSAns16.Checked = True) Then
            CSAns14.Enabled = False
            CSAns15.Enabled = False
            CSAns13.Enabled = False
        End If

    End Sub

    Private Sub CSAns17_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns17.CheckedChanged
        If (CSAns17.Checked = True) Then
            CSAns18.Enabled = False
            CSAns19.Enabled = False
            CSAns20.Enabled = False
        End If

    End Sub

    Private Sub CSAns18_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns18.CheckedChanged
        If (CSAns18.Checked = True) Then
            CSAns17.Enabled = False
            CSAns19.Enabled = False
            CSAns20.Enabled = False
        End If

    End Sub

    Private Sub CSAns19_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns19.CheckedChanged
        If (CSAns19.Checked = True) Then
            CSAns18.Enabled = False
            CSAns17.Enabled = False
            CSAns20.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns20_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns20.CheckedChanged
        If (CSAns20.Checked = True) Then
            CSAns18.Enabled = False
            CSAns19.Enabled = False
            CSAns17.Enabled = False
        End If

    End Sub

    Private Sub CSAns21_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns21.CheckedChanged
        If (CSAns21.Checked = True) Then
            CSAns22.Enabled = False
            CSAns23.Enabled = False
            CSAns24.Enabled = False
        End If

    End Sub

    Private Sub CSAns22_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns22.CheckedChanged
        If (CSAns22.Checked = True) Then
            CSAns21.Enabled = False
            CSAns23.Enabled = False
            CSAns24.Enabled = False
        End If

    End Sub

    Private Sub CSAns23_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns23.CheckedChanged
        If (CSAns23.Checked = True) Then
            CSAns22.Enabled = False
            CSAns21.Enabled = False
            CSAns24.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns24_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns24.CheckedChanged
        If (CSAns24.Checked = True) Then
            CSAns22.Enabled = False
            CSAns23.Enabled = False
            CSAns21.Enabled = False
        End If

    End Sub

    Private Sub CSAns25_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns25.CheckedChanged
        If (CSAns25.Checked = True) Then
            CSAns26.Enabled = False
            CSAns27.Enabled = False
            CSAns28.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns26_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns26.CheckedChanged
        If (CSAns26.Checked = True) Then
            CSAns25.Enabled = False
            CSAns27.Enabled = False
            CSAns28.Enabled = False
        End If

    End Sub

    Private Sub CSAns27_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns27.CheckedChanged
        If (CSAns27.Checked = True) Then
            CSAns26.Enabled = False
            CSAns25.Enabled = False
            CSAns28.Enabled = False
        End If

    End Sub

    Private Sub CSAns28_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns28.CheckedChanged
        If (CSAns28.Checked = True) Then
            CSAns26.Enabled = False
            CSAns27.Enabled = False
            CSAns25.Enabled = False
        End If

    End Sub

    Private Sub CSAns29_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns29.CheckedChanged
        If (CSAns29.Checked = True) Then
            CSAns30.Enabled = False
            CSAns31.Enabled = False
            CSAns32.Enabled = False
        End If

    End Sub

    Private Sub CSAns30_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns30.CheckedChanged
        If (CSAns30.Checked = True) Then
            CSAns29.Enabled = False
            CSAns31.Enabled = False
            CSAns32.Enabled = False
        End If

    End Sub

    Private Sub CSAns31_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns31.CheckedChanged
        If (CSAns31.Checked = True) Then
            CSAns30.Enabled = False
            CSAns29.Enabled = False
            CSAns32.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns32_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns32.CheckedChanged
        If (CSAns32.Checked = True) Then
            CSAns30.Enabled = False
            CSAns31.Enabled = False
            CSAns29.Enabled = False
        End If

    End Sub

    Private Sub CSAns33_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns33.CheckedChanged
        If (CSAns33.Checked = True) Then
            CSAns34.Enabled = False
            CSAns35.Enabled = False
            CSAns36.Enabled = False
        End If

    End Sub

    Private Sub CSAns34_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns34.CheckedChanged
        If (CSAns34.Checked = True) Then
            CSAns33.Enabled = False
            CSAns35.Enabled = False
            CSAns36.Enabled = False
        End If

    End Sub

    Private Sub CSAns35_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns35.CheckedChanged
        If (CSAns35.Checked = True) Then
            CSAns34.Enabled = False
            CSAns33.Enabled = False
            CSAns36.Enabled = False
        End If

    End Sub

    Private Sub CSAns36_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns36.CheckedChanged
        If (CSAns36.Checked = True) Then
            CSAns34.Enabled = False
            CSAns35.Enabled = False
            CSAns33.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns37_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns37.CheckedChanged
        If (CSAns37.Checked = True) Then
            CSAns38.Enabled = False
            CSAns39.Enabled = False
            CSAns40.Enabled = False
        End If

    End Sub

    Private Sub CSAns38_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns38.CheckedChanged
        If (CSAns38.Checked = True) Then
            CSAns37.Enabled = False
            CSAns39.Enabled = False
            CSAns40.Enabled = False
        End If

    End Sub

    Private Sub CSAns39_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns39.CheckedChanged
        If (CSAns39.Checked = True) Then
            CSAns38.Enabled = False
            CSAns37.Enabled = False
            CSAns40.Enabled = False
        End If
        MainForm.OverallScore.Text += 5
    End Sub

    Private Sub CSAns40_CheckedChanged(sender As Object, e As EventArgs) Handles CSAns40.CheckedChanged
        If (CSAns40.Checked = True) Then
            CSAns38.Enabled = False
            CSAns39.Enabled = False
            CSAns37.Enabled = False
        End If

    End Sub


End Class