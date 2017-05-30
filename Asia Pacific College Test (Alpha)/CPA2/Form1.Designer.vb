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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CSQuestions = New System.Windows.Forms.Panel()
        Me.CurrentCSScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CSPreviousPage = New System.Windows.Forms.Button()
        Me.CSNextPage = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CSQuestionsMain = New System.Windows.Forms.Panel()
        Me.ELQuestions = New System.Windows.Forms.Panel()
        Me.CurrentELScore = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ELPreviousPage = New System.Windows.Forms.Button()
        Me.ELNextPage = New System.Windows.Forms.Button()
        Me.ELQuestionsMain = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CSQuestions.SuspendLayout()
        Me.ELQuestions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(523, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(509, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 30)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Asia Pacific College"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(519, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "School of Computing and"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(519, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Information Technology"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(514, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 30)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "QUIZ PROGRAM"
        '
        'CSQuestions
        '
        Me.CSQuestions.BackColor = System.Drawing.Color.Transparent
        Me.CSQuestions.BackgroundImage = CType(resources.GetObject("CSQuestions.BackgroundImage"), System.Drawing.Image)
        Me.CSQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CSQuestions.Controls.Add(Me.CurrentCSScore)
        Me.CSQuestions.Controls.Add(Me.Label1)
        Me.CSQuestions.Controls.Add(Me.CSPreviousPage)
        Me.CSQuestions.Controls.Add(Me.CSNextPage)
        Me.CSQuestions.Location = New System.Drawing.Point(12, 12)
        Me.CSQuestions.Name = "CSQuestions"
        Me.CSQuestions.Size = New System.Drawing.Size(464, 516)
        Me.CSQuestions.TabIndex = 28
        '
        'CurrentCSScore
        '
        Me.CurrentCSScore.BackColor = System.Drawing.Color.White
        Me.CurrentCSScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentCSScore.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.CurrentCSScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.CurrentCSScore.Location = New System.Drawing.Point(200, 464)
        Me.CurrentCSScore.Multiline = True
        Me.CurrentCSScore.Name = "CurrentCSScore"
        Me.CurrentCSScore.ReadOnly = True
        Me.CurrentCSScore.Size = New System.Drawing.Size(136, 30)
        Me.CurrentCSScore.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(125, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 30)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Score:"
        '
        'CSPreviousPage
        '
        Me.CSPreviousPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.CSPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CSPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CSPreviousPage.ForeColor = System.Drawing.Color.White
        Me.CSPreviousPage.Location = New System.Drawing.Point(14, 464)
        Me.CSPreviousPage.Name = "CSPreviousPage"
        Me.CSPreviousPage.Size = New System.Drawing.Size(94, 30)
        Me.CSPreviousPage.TabIndex = 31
        Me.CSPreviousPage.Text = "Previous"
        Me.CSPreviousPage.UseVisualStyleBackColor = False
        Me.CSPreviousPage.Visible = False
        '
        'CSNextPage
        '
        Me.CSNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.CSNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CSNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CSNextPage.ForeColor = System.Drawing.Color.White
        Me.CSNextPage.Location = New System.Drawing.Point(352, 464)
        Me.CSNextPage.Name = "CSNextPage"
        Me.CSNextPage.Size = New System.Drawing.Size(94, 30)
        Me.CSNextPage.TabIndex = 30
        Me.CSNextPage.Text = "Next"
        Me.CSNextPage.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(548, 403)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(136, 30)
        Me.TextBox1.TabIndex = 29
        '
        'CSQuestionsMain
        '
        Me.CSQuestionsMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CSQuestionsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CSQuestionsMain.Location = New System.Drawing.Point(12, 29)
        Me.CSQuestionsMain.Name = "CSQuestionsMain"
        Me.CSQuestionsMain.Size = New System.Drawing.Size(464, 441)
        Me.CSQuestionsMain.TabIndex = 30
        '
        'ELQuestions
        '
        Me.ELQuestions.BackColor = System.Drawing.Color.Transparent
        Me.ELQuestions.BackgroundImage = CType(resources.GetObject("ELQuestions.BackgroundImage"), System.Drawing.Image)
        Me.ELQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ELQuestions.Controls.Add(Me.CurrentELScore)
        Me.ELQuestions.Controls.Add(Me.Label2)
        Me.ELQuestions.Controls.Add(Me.ELPreviousPage)
        Me.ELQuestions.Controls.Add(Me.ELNextPage)
        Me.ELQuestions.Location = New System.Drawing.Point(728, 12)
        Me.ELQuestions.Name = "ELQuestions"
        Me.ELQuestions.Size = New System.Drawing.Size(464, 516)
        Me.ELQuestions.TabIndex = 31
        '
        'CurrentELScore
        '
        Me.CurrentELScore.BackColor = System.Drawing.Color.White
        Me.CurrentELScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentELScore.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.CurrentELScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.CurrentELScore.Location = New System.Drawing.Point(200, 464)
        Me.CurrentELScore.Multiline = True
        Me.CurrentELScore.Name = "CurrentELScore"
        Me.CurrentELScore.ReadOnly = True
        Me.CurrentELScore.Size = New System.Drawing.Size(136, 30)
        Me.CurrentELScore.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(125, 464)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 30)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Score:"
        '
        'ELPreviousPage
        '
        Me.ELPreviousPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ELPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ELPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ELPreviousPage.ForeColor = System.Drawing.Color.White
        Me.ELPreviousPage.Location = New System.Drawing.Point(14, 464)
        Me.ELPreviousPage.Name = "ELPreviousPage"
        Me.ELPreviousPage.Size = New System.Drawing.Size(94, 30)
        Me.ELPreviousPage.TabIndex = 31
        Me.ELPreviousPage.Text = "Previous"
        Me.ELPreviousPage.UseVisualStyleBackColor = False
        Me.ELPreviousPage.Visible = False
        '
        'ELNextPage
        '
        Me.ELNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ELNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ELNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ELNextPage.ForeColor = System.Drawing.Color.White
        Me.ELNextPage.Location = New System.Drawing.Point(352, 464)
        Me.ELNextPage.Name = "ELNextPage"
        Me.ELNextPage.Size = New System.Drawing.Size(94, 30)
        Me.ELNextPage.TabIndex = 30
        Me.ELNextPage.Text = "Next"
        Me.ELNextPage.UseVisualStyleBackColor = False
        '
        'ELQuestionsMain
        '
        Me.ELQuestionsMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ELQuestionsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ELQuestionsMain.Location = New System.Drawing.Point(728, 29)
        Me.ELQuestionsMain.Name = "ELQuestionsMain"
        Me.ELQuestionsMain.Size = New System.Drawing.Size(464, 441)
        Me.ELQuestionsMain.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1204, 641)
        Me.Controls.Add(Me.ELQuestionsMain)
        Me.Controls.Add(Me.ELQuestions)
        Me.Controls.Add(Me.CSQuestionsMain)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CSQuestions)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CSQuestions.ResumeLayout(False)
        Me.CSQuestions.PerformLayout()
        Me.ELQuestions.ResumeLayout(False)
        Me.ELQuestions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Public WithEvents CSQuestions As Panel
    Public WithEvents CSPreviousPage As Button
    Public WithEvents CSNextPage As Button
    Public WithEvents CSQuestionsMain As Panel
    Friend WithEvents Label1 As Label
    Public WithEvents CurrentCSScore As TextBox
    Public WithEvents ELQuestions As Panel
    Public WithEvents CurrentELScore As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents ELPreviousPage As Button
    Public WithEvents ELNextPage As Button
    Public WithEvents ELQuestionsMain As Panel
End Class
