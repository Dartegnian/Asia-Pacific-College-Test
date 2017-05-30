<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Questions = New System.Windows.Forms.Panel()
        Me.ELTab = New System.Windows.Forms.Panel()
        Me.ELSelector = New System.Windows.Forms.Panel()
        Me.ELLabel = New System.Windows.Forms.Label()
        Me.CSTab = New System.Windows.Forms.Panel()
        Me.CSSelector = New System.Windows.Forms.Panel()
        Me.CSLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SoCITButton = New System.Windows.Forms.Button()
        Me.SoEButtom = New System.Windows.Forms.Button()
        Me.SoMButton = New System.Windows.Forms.Button()
        Me.SoMAButton = New System.Windows.Forms.Button()
        Me.OverallScore = New System.Windows.Forms.TextBox()
        Me.schoolAccents = New System.Windows.Forms.Label()
        Me.OverallScoreLBL = New System.Windows.Forms.Label()
        Me.ELTab.SuspendLayout()
        Me.CSTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Questions
        '
        Me.Questions.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Questions.Location = New System.Drawing.Point(12, 137)
        Me.Questions.Name = "Questions"
        Me.Questions.Size = New System.Drawing.Size(1180, 492)
        Me.Questions.TabIndex = 0
        '
        'ELTab
        '
        Me.ELTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ELTab.Controls.Add(Me.ELSelector)
        Me.ELTab.Controls.Add(Me.ELLabel)
        Me.ELTab.Location = New System.Drawing.Point(239, 87)
        Me.ELTab.Name = "ELTab"
        Me.ELTab.Size = New System.Drawing.Size(227, 66)
        Me.ELTab.TabIndex = 1
        '
        'ELSelector
        '
        Me.ELSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ELSelector.Location = New System.Drawing.Point(-2, 0)
        Me.ELSelector.Name = "ELSelector"
        Me.ELSelector.Size = New System.Drawing.Size(229, 4)
        Me.ELSelector.TabIndex = 10
        Me.ELSelector.Visible = False
        '
        'ELLabel
        '
        Me.ELLabel.AutoSize = True
        Me.ELLabel.BackColor = System.Drawing.Color.Transparent
        Me.ELLabel.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.ELLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ELLabel.Location = New System.Drawing.Point(40, 15)
        Me.ELLabel.Name = "ELLabel"
        Me.ELLabel.Size = New System.Drawing.Size(142, 25)
        Me.ELLabel.TabIndex = 10
        Me.ELLabel.Text = "English Literature"
        '
        'CSTab
        '
        Me.CSTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CSTab.Controls.Add(Me.CSSelector)
        Me.CSTab.Controls.Add(Me.CSLabel)
        Me.CSTab.Location = New System.Drawing.Point(12, 87)
        Me.CSTab.Name = "CSTab"
        Me.CSTab.Size = New System.Drawing.Size(227, 66)
        Me.CSTab.TabIndex = 2
        '
        'CSSelector
        '
        Me.CSSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CSSelector.Location = New System.Drawing.Point(-1, 0)
        Me.CSSelector.Name = "CSSelector"
        Me.CSSelector.Size = New System.Drawing.Size(229, 4)
        Me.CSSelector.TabIndex = 9
        '
        'CSLabel
        '
        Me.CSLabel.AutoSize = True
        Me.CSLabel.BackColor = System.Drawing.Color.Transparent
        Me.CSLabel.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.CSLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CSLabel.Location = New System.Drawing.Point(33, 15)
        Me.CSLabel.Name = "CSLabel"
        Me.CSLabel.Size = New System.Drawing.Size(150, 25)
        Me.CSLabel.TabIndex = 9
        Me.CSLabel.Text = "Computer Science"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 69)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SoCITButton
        '
        Me.SoCITButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SoCITButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoCITButton.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.SoCITButton.ForeColor = System.Drawing.Color.White
        Me.SoCITButton.Location = New System.Drawing.Point(762, 12)
        Me.SoCITButton.Name = "SoCITButton"
        Me.SoCITButton.Size = New System.Drawing.Size(103, 32)
        Me.SoCITButton.TabIndex = 4
        Me.SoCITButton.Text = "SoCIT"
        Me.SoCITButton.UseVisualStyleBackColor = False
        '
        'SoEButtom
        '
        Me.SoEButtom.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SoEButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoEButtom.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.SoEButtom.ForeColor = System.Drawing.Color.White
        Me.SoEButtom.Location = New System.Drawing.Point(871, 12)
        Me.SoEButtom.Name = "SoEButtom"
        Me.SoEButtom.Size = New System.Drawing.Size(103, 32)
        Me.SoEButtom.TabIndex = 5
        Me.SoEButtom.Text = "SoE"
        Me.SoEButtom.UseVisualStyleBackColor = False
        '
        'SoMButton
        '
        Me.SoMButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SoMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoMButton.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.SoMButton.ForeColor = System.Drawing.Color.White
        Me.SoMButton.Location = New System.Drawing.Point(980, 12)
        Me.SoMButton.Name = "SoMButton"
        Me.SoMButton.Size = New System.Drawing.Size(103, 32)
        Me.SoMButton.TabIndex = 6
        Me.SoMButton.Text = "SoM"
        Me.SoMButton.UseVisualStyleBackColor = False
        '
        'SoMAButton
        '
        Me.SoMAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SoMAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoMAButton.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.SoMAButton.ForeColor = System.Drawing.Color.White
        Me.SoMAButton.Location = New System.Drawing.Point(1089, 12)
        Me.SoMAButton.Name = "SoMAButton"
        Me.SoMAButton.Size = New System.Drawing.Size(103, 32)
        Me.SoMAButton.TabIndex = 7
        Me.SoMAButton.Text = "SoMA"
        Me.SoMAButton.UseVisualStyleBackColor = False
        '
        'OverallScore
        '
        Me.OverallScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OverallScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OverallScore.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.OverallScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.OverallScore.Location = New System.Drawing.Point(1031, 87)
        Me.OverallScore.Multiline = True
        Me.OverallScore.Name = "OverallScore"
        Me.OverallScore.ReadOnly = True
        Me.OverallScore.Size = New System.Drawing.Size(161, 53)
        Me.OverallScore.TabIndex = 8
        Me.OverallScore.Text = "0"
        '
        'schoolAccents
        '
        Me.schoolAccents.AutoSize = True
        Me.schoolAccents.BackColor = System.Drawing.Color.Transparent
        Me.schoolAccents.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.schoolAccents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.schoolAccents.Location = New System.Drawing.Point(626, 16)
        Me.schoolAccents.Name = "schoolAccents"
        Me.schoolAccents.Size = New System.Drawing.Size(130, 25)
        Me.schoolAccents.TabIndex = 10
        Me.schoolAccents.Text = "School Accents:"
        '
        'OverallScoreLBL
        '
        Me.OverallScoreLBL.AutoSize = True
        Me.OverallScoreLBL.BackColor = System.Drawing.Color.Transparent
        Me.OverallScoreLBL.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.OverallScoreLBL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.OverallScoreLBL.Location = New System.Drawing.Point(852, 87)
        Me.OverallScoreLBL.Name = "OverallScoreLBL"
        Me.OverallScoreLBL.Size = New System.Drawing.Size(173, 37)
        Me.OverallScoreLBL.TabIndex = 11
        Me.OverallScoreLBL.Text = "Overall Score:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1204, 641)
        Me.Controls.Add(Me.OverallScoreLBL)
        Me.Controls.Add(Me.schoolAccents)
        Me.Controls.Add(Me.SoMAButton)
        Me.Controls.Add(Me.SoMButton)
        Me.Controls.Add(Me.SoEButtom)
        Me.Controls.Add(Me.SoCITButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Questions)
        Me.Controls.Add(Me.CSTab)
        Me.Controls.Add(Me.ELTab)
        Me.Controls.Add(Me.OverallScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asia Pacific College Test"
        Me.ELTab.ResumeLayout(False)
        Me.ELTab.PerformLayout()
        Me.CSTab.ResumeLayout(False)
        Me.CSTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Questions As Panel
    Friend WithEvents ELTab As Panel
    Friend WithEvents CSTab As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SoCITButton As Button
    Friend WithEvents SoEButtom As Button
    Friend WithEvents SoMButton As Button
    Friend WithEvents SoMAButton As Button
    Friend WithEvents OverallScore As TextBox
    Public WithEvents CSSelector As Panel
    Public WithEvents CSLabel As Label
    Public WithEvents ELLabel As Label
    Public WithEvents ELSelector As Panel
    Public WithEvents schoolAccents As Label
    Public WithEvents OverallScoreLBL As Label
End Class
