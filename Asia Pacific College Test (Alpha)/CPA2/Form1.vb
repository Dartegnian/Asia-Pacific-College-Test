Public Class Form1
    Dim csqSet1 As New CSQuestions1
    Dim csqSet2 As New CSQuestions2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSQuestionsMain.Controls.Add(csqSet1)
    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles NextPage.Click, CSNextPage.Click
        CSQuestionsMain.Controls.Clear()
        CSQuestionsMain.Controls.Add(csqSet2)
        NextPage.Visible = False
        CSPreviousPage.Visible = True
    End Sub

    Private Sub PreviousPage_Click(sender As Object, e As EventArgs) Handles CSPreviousPage.Click
        CSQuestionsMain.Controls.Remove(csqSet2)
        CSQuestionsMain.Controls.Add(csqSet1)
        CSPreviousPage.Visible = False
        NextPage.Visible = True
    End Sub
End Class