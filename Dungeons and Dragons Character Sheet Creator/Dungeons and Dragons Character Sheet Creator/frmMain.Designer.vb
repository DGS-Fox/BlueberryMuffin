<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cboRace = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radFirstEdition = New System.Windows.Forms.RadioButton()
        Me.rad35Edition = New System.Windows.Forms.RadioButton()
        Me.radSecondEdition = New System.Windows.Forms.RadioButton()
        Me.radFifthEdition = New System.Windows.Forms.RadioButton()
        Me.radThirdEdition = New System.Windows.Forms.RadioButton()
        Me.radFourthEdition = New System.Windows.Forms.RadioButton()
        Me.lblRNG1 = New System.Windows.Forms.Label()
        Me.lblRNG2 = New System.Windows.Forms.Label()
        Me.lblRNG3 = New System.Windows.Forms.Label()
        Me.lblRNG4 = New System.Windows.Forms.Label()
        Me.lblRNG5 = New System.Windows.Forms.Label()
        Me.lblRNG6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboRace
        '
        Me.cboRace.Enabled = False
        Me.cboRace.FormattingEnabled = True
        Me.cboRace.Location = New System.Drawing.Point(11, 248)
        Me.cboRace.Name = "cboRace"
        Me.cboRace.Size = New System.Drawing.Size(143, 24)
        Me.cboRace.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose a Race:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choose a Class:"
        '
        'cboClass
        '
        Me.cboClass.Enabled = False
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(11, 298)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(143, 24)
        Me.cboClass.TabIndex = 2
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(11, 328)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(143, 26)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate Character"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnGenerate)
        Me.GroupBox1.Controls.Add(Me.cboRace)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboClass)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 373)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFirstEdition)
        Me.GroupBox2.Controls.Add(Me.rad35Edition)
        Me.GroupBox2.Controls.Add(Me.radSecondEdition)
        Me.GroupBox2.Controls.Add(Me.radFifthEdition)
        Me.GroupBox2.Controls.Add(Me.radThirdEdition)
        Me.GroupBox2.Controls.Add(Me.radFourthEdition)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 188)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Edition"
        '
        'radFirstEdition
        '
        Me.radFirstEdition.AutoSize = True
        Me.radFirstEdition.Location = New System.Drawing.Point(6, 21)
        Me.radFirstEdition.Name = "radFirstEdition"
        Me.radFirstEdition.Size = New System.Drawing.Size(95, 21)
        Me.radFirstEdition.TabIndex = 5
        Me.radFirstEdition.Text = "1st Edition"
        Me.radFirstEdition.UseVisualStyleBackColor = True
        '
        'rad35Edition
        '
        Me.rad35Edition.AutoSize = True
        Me.rad35Edition.Location = New System.Drawing.Point(6, 102)
        Me.rad35Edition.Name = "rad35Edition"
        Me.rad35Edition.Size = New System.Drawing.Size(96, 21)
        Me.rad35Edition.TabIndex = 10
        Me.rad35Edition.Text = "3.5 Edition"
        Me.rad35Edition.UseVisualStyleBackColor = True
        '
        'radSecondEdition
        '
        Me.radSecondEdition.AutoSize = True
        Me.radSecondEdition.Location = New System.Drawing.Point(6, 48)
        Me.radSecondEdition.Name = "radSecondEdition"
        Me.radSecondEdition.Size = New System.Drawing.Size(100, 21)
        Me.radSecondEdition.TabIndex = 6
        Me.radSecondEdition.Text = "2nd Edition"
        Me.radSecondEdition.UseVisualStyleBackColor = True
        '
        'radFifthEdition
        '
        Me.radFifthEdition.AutoSize = True
        Me.radFifthEdition.Location = New System.Drawing.Point(6, 156)
        Me.radFifthEdition.Name = "radFifthEdition"
        Me.radFifthEdition.Size = New System.Drawing.Size(96, 21)
        Me.radFifthEdition.TabIndex = 9
        Me.radFifthEdition.Text = "5th Edition"
        Me.radFifthEdition.UseVisualStyleBackColor = True
        '
        'radThirdEdition
        '
        Me.radThirdEdition.AutoSize = True
        Me.radThirdEdition.Location = New System.Drawing.Point(6, 75)
        Me.radThirdEdition.Name = "radThirdEdition"
        Me.radThirdEdition.Size = New System.Drawing.Size(97, 21)
        Me.radThirdEdition.TabIndex = 7
        Me.radThirdEdition.Text = "3rd Edition"
        Me.radThirdEdition.UseVisualStyleBackColor = True
        '
        'radFourthEdition
        '
        Me.radFourthEdition.AutoSize = True
        Me.radFourthEdition.Location = New System.Drawing.Point(6, 129)
        Me.radFourthEdition.Name = "radFourthEdition"
        Me.radFourthEdition.Size = New System.Drawing.Size(96, 21)
        Me.radFourthEdition.TabIndex = 8
        Me.radFourthEdition.Text = "4th Edition"
        Me.radFourthEdition.UseVisualStyleBackColor = True
        '
        'lblRNG1
        '
        Me.lblRNG1.AutoSize = True
        Me.lblRNG1.Location = New System.Drawing.Point(20, 400)
        Me.lblRNG1.Name = "lblRNG1"
        Me.lblRNG1.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG1.TabIndex = 6
        Me.lblRNG1.Text = "Label3"
        '
        'lblRNG2
        '
        Me.lblRNG2.AutoSize = True
        Me.lblRNG2.Location = New System.Drawing.Point(20, 425)
        Me.lblRNG2.Name = "lblRNG2"
        Me.lblRNG2.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG2.TabIndex = 7
        Me.lblRNG2.Text = "Label4"
        '
        'lblRNG3
        '
        Me.lblRNG3.AutoSize = True
        Me.lblRNG3.Location = New System.Drawing.Point(20, 450)
        Me.lblRNG3.Name = "lblRNG3"
        Me.lblRNG3.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG3.TabIndex = 8
        Me.lblRNG3.Text = "Label5"
        '
        'lblRNG4
        '
        Me.lblRNG4.AutoSize = True
        Me.lblRNG4.Location = New System.Drawing.Point(77, 400)
        Me.lblRNG4.Name = "lblRNG4"
        Me.lblRNG4.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG4.TabIndex = 9
        Me.lblRNG4.Text = "Label6"
        '
        'lblRNG5
        '
        Me.lblRNG5.AutoSize = True
        Me.lblRNG5.Location = New System.Drawing.Point(77, 425)
        Me.lblRNG5.Name = "lblRNG5"
        Me.lblRNG5.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG5.TabIndex = 10
        Me.lblRNG5.Text = "Label7"
        '
        'lblRNG6
        '
        Me.lblRNG6.AutoSize = True
        Me.lblRNG6.Location = New System.Drawing.Point(77, 450)
        Me.lblRNG6.Name = "lblRNG6"
        Me.lblRNG6.Size = New System.Drawing.Size(51, 17)
        Me.lblRNG6.TabIndex = 11
        Me.lblRNG6.Text = "Label8"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 523)
        Me.Controls.Add(Me.lblRNG6)
        Me.Controls.Add(Me.lblRNG5)
        Me.Controls.Add(Me.lblRNG4)
        Me.Controls.Add(Me.lblRNG3)
        Me.Controls.Add(Me.lblRNG2)
        Me.Controls.Add(Me.lblRNG1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "D&D Character Sheet Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboRace As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad35Edition As RadioButton
    Friend WithEvents radFifthEdition As RadioButton
    Friend WithEvents radFourthEdition As RadioButton
    Friend WithEvents radThirdEdition As RadioButton
    Friend WithEvents radSecondEdition As RadioButton
    Friend WithEvents radFirstEdition As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblRNG1 As Label
    Friend WithEvents lblRNG2 As Label
    Friend WithEvents lblRNG3 As Label
    Friend WithEvents lblRNG4 As Label
    Friend WithEvents lblRNG5 As Label
    Friend WithEvents lblRNG6 As Label
End Class
