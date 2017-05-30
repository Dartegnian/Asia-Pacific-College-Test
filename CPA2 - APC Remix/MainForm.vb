Public Class MainForm
    Dim csPage As New CSQuestions
    Dim elPage As New ELQuestions
    Dim mainRed As Integer = 25
    Dim mainBlue As Integer = 25
    Dim mainGreen As Integer = 25

    Public Function AccentChanger(ByVal selectedAccent As String)
        Select Case (True)
            Case selectedAccent = "SoCIT"
                mainRed = 9 : mainBlue = 67 : mainGreen = 149 : changeColor(9, 67, 149)
            Case selectedAccent = "SoE"
                mainRed = 211 : mainBlue = 100 : mainGreen = 46 : changeColor(211, 100, 46)
            Case selectedAccent = "SoM"
                changeColor(223, 171, 25)
                mainRed = 223
                mainBlue = 171
                mainGreen = 25
            Case selectedAccent = "SoMA"
                changeColor(223, 24, 31)
                mainRed = 223
                mainBlue = 24
                mainGreen = 31
        End Select
    End Function
    Private Function ChangeColor(ByVal Red As Integer, Blue As Integer, Green As Integer)
        CSSelector.BackColor = Color.FromArgb(Red, Blue, Green)
        ELSelector.BackColor = Color.FromArgb(Red, Blue, Green)
        OverallScore.BackColor = Color.FromArgb(Red, Blue, Green)
        schoolAccents.ForeColor = Color.FromArgb(Red, Blue, Green)
        OverallScoreLBL.ForeColor = Color.FromArgb(Red, Blue, Green)
        OverallScore.ForeColor = Color.FromArgb(250, 250, 250)

        Select Case (True)
            Case CSLabel.ForeColor <> Color.FromArgb(232, 232, 232)
                CSLabel.ForeColor = Color.FromArgb(Red, Blue, Green)
            Case ELLabel.ForeColor <> Color.FromArgb(232, 232, 232)
                ELLabel.ForeColor = Color.FromArgb(Red, Blue, Green)
            Case CSSelector.BackColor <> Color.FromArgb(80, 80, 80)
                CSSelector.BackColor = Color.FromArgb(Red, Blue, Green)
            Case ELLabel.ForeColor <> Color.FromArgb(80, 80, 80)
                ELSelector.BackColor = Color.FromArgb(Red, Blue, Green)
        End Select

        csPage.CSQues1.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues2.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues3.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues4.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues5.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues6.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues7.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues8.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues9.ForeColor = Color.FromArgb(Red, Blue, Green)
        csPage.CSQues10.ForeColor = Color.FromArgb(Red, Blue, Green)

        elPage.ELQues1.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues2.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues3.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues4.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues5.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues6.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues7.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues8.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues9.ForeColor = Color.FromArgb(Red, Blue, Green)
        elPage.ELQues10.ForeColor = Color.FromArgb(Red, Blue, Green)
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Questions.Controls.Add(csPage)
    End Sub

    Private Sub CSLabel_Click(sender As Object, e As EventArgs) Handles CSLabel.Click
        If (Questions.Controls.Contains(csPage) = True) Then
        Else
            CSTab.BackColor = Color.FromArgb(232, 232, 232)
            CSLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.Visible = True

            ELSelector.Visible = False
            ELTab.BackColor = Color.FromArgb(189, 189, 189)
            ELLabel.ForeColor = Color.FromArgb(232, 232, 232)
            ELSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(csPage)
        End If
    End Sub

    Private Sub CSTab_Click(sender As Object, e As EventArgs) Handles CSTab.Click
        If (Questions.Controls.Contains(csPage) = True) Then
        Else
            CSTab.BackColor = Color.FromArgb(232, 232, 232)
            CSLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.Visible = True

            ELSelector.Visible = False
            ELTab.BackColor = Color.FromArgb(189, 189, 189)
            ELLabel.ForeColor = Color.FromArgb(232, 232, 232)
            ELSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(csPage)
        End If
    End Sub

    Private Sub CSSelector_Click(sender As Object, e As EventArgs) Handles CSSelector.Click
        If (Questions.Controls.Contains(csPage) = True) Then
        Else
            CSTab.BackColor = Color.FromArgb(232, 232, 232)
            CSLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            CSSelector.Visible = True

            ELSelector.Visible = False
            ELTab.BackColor = Color.FromArgb(189, 189, 189)
            ELLabel.ForeColor = Color.FromArgb(232, 232, 232)
            ELSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(csPage)
        End If
    End Sub
    Private Sub ELLabel_Click(sender As Object, e As EventArgs) Handles ELLabel.Click
        If (Questions.Controls.Contains(elPage) = True) Then
        Else
            ELTab.BackColor = Color.FromArgb(232, 232, 232)
            ELLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.Visible = True

            CSSelector.Visible = False
            CSTab.BackColor = Color.FromArgb(189, 189, 189)
            CSLabel.ForeColor = Color.FromArgb(232, 232, 232)
            CSSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(elPage)
        End If
    End Sub

    Private Sub ELTab_Click(sender As Object, e As EventArgs) Handles ELTab.Click
        If (Questions.Controls.Contains(elPage) = True) Then
        Else
            ELTab.BackColor = Color.FromArgb(232, 232, 232)
            ELLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.Visible = True

            CSSelector.Visible = False
            CSTab.BackColor = Color.FromArgb(189, 189, 189)
            CSLabel.ForeColor = Color.FromArgb(232, 232, 232)
            CSSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(elPage)
        End If
    End Sub

    Private Sub ELSelector_Click(sender As Object, e As EventArgs) Handles ELSelector.Click
        If (Questions.Controls.Contains(elPage) = True) Then
        Else
            ELTab.BackColor = Color.FromArgb(232, 232, 232)
            ELLabel.ForeColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.BackColor = Color.FromArgb(mainRed, mainBlue, mainGreen)
            ELSelector.Visible = True

            CSSelector.Visible = False
            CSTab.BackColor = Color.FromArgb(189, 189, 189)
            CSLabel.ForeColor = Color.FromArgb(232, 232, 232)
            CSSelector.BackColor = Color.FromArgb(80, 80, 80)
            Questions.Controls.Clear()
            Questions.Controls.Add(elPage)
        End If
    End Sub

    Private Sub SoCITButton_Click(sender As Object, e As EventArgs) Handles SoCITButton.Click
        AccentChanger("SoCIT")
    End Sub

    Private Sub SoEButtom_Click(sender As Object, e As EventArgs) Handles SoEButtom.Click
        AccentChanger("SoE")
    End Sub

    Private Sub SoMButton_Click(sender As Object, e As EventArgs) Handles SoMButton.Click
        AccentChanger("SoM")
    End Sub

    Private Sub SoMAButton_Click(sender As Object, e As EventArgs) Handles SoMAButton.Click
        AccentChanger("SoMA")
    End Sub

End Class
