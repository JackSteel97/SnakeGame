<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
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
		Me.components = New System.ComponentModel.Container()
		Me.Snake_0 = New System.Windows.Forms.Label()
		Me.Snake_1 = New System.Windows.Forms.Label()
		Me.Snake_2 = New System.Windows.Forms.Label()
		Me.Mover = New System.Windows.Forms.Timer(Me.components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
		Me.Food = New Microsoft.VisualBasic.PowerPacks.OvalShape()
		Me.Snake_3 = New System.Windows.Forms.Label()
		Me.scorelbl = New System.Windows.Forms.Label()
		Me.MenuPanel = New System.Windows.Forms.Panel()
		Me.TitleSnake_0 = New System.Windows.Forms.Label()
		Me.settingspanel = New System.Windows.Forms.Panel()
		Me.savebtn = New System.Windows.Forms.Button()
		Me.changecolourbtn = New System.Windows.Forms.Button()
		Me.SettingsBtn = New System.Windows.Forms.Button()
		Me.Highscorestxt = New System.Windows.Forms.Label()
		Me.Highscoresbtn = New System.Windows.Forms.Button()
		Me.Difficultyselector = New System.Windows.Forms.ComboBox()
		Me.Startbtn = New System.Windows.Forms.Button()
		Me.Title = New System.Windows.Forms.Label()
		Me.ColourChanger = New System.Windows.Forms.Timer(Me.components)
		Me.Fader = New System.Windows.Forms.Timer(Me.components)
		Me.scoredisp = New System.Windows.Forms.Label()
		Me.Snakecolour = New System.Windows.Forms.ColorDialog()
		Me.TitleMover = New System.Windows.Forms.Timer(Me.components)
		Me.MenuPanel.SuspendLayout()
		Me.settingspanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'Snake_0
		'
		Me.Snake_0.BackColor = System.Drawing.Color.White
		Me.Snake_0.Location = New System.Drawing.Point(250, 210)
		Me.Snake_0.Name = "Snake_0"
		Me.Snake_0.Size = New System.Drawing.Size(10, 10)
		Me.Snake_0.TabIndex = 0
		'
		'Snake_1
		'
		Me.Snake_1.BackColor = System.Drawing.Color.White
		Me.Snake_1.Location = New System.Drawing.Point(240, 210)
		Me.Snake_1.Name = "Snake_1"
		Me.Snake_1.Size = New System.Drawing.Size(10, 10)
		Me.Snake_1.TabIndex = 1
		'
		'Snake_2
		'
		Me.Snake_2.BackColor = System.Drawing.Color.White
		Me.Snake_2.Location = New System.Drawing.Point(230, 210)
		Me.Snake_2.Name = "Snake_2"
		Me.Snake_2.Size = New System.Drawing.Size(10, 10)
		Me.Snake_2.TabIndex = 2
		'
		'Mover
		'
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Food})
		Me.ShapeContainer1.Size = New System.Drawing.Size(732, 513)
		Me.ShapeContainer1.TabIndex = 3
		Me.ShapeContainer1.TabStop = False
		'
		'Food
		'
		Me.Food.BackColor = System.Drawing.Color.White
		Me.Food.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.Food.FillColor = System.Drawing.Color.White
		Me.Food.Location = New System.Drawing.Point(470, 210)
		Me.Food.Name = "Food"
		Me.Food.Size = New System.Drawing.Size(10, 10)
		'
		'Snake_3
		'
		Me.Snake_3.BackColor = System.Drawing.Color.White
		Me.Snake_3.Location = New System.Drawing.Point(220, 210)
		Me.Snake_3.Name = "Snake_3"
		Me.Snake_3.Size = New System.Drawing.Size(10, 10)
		Me.Snake_3.TabIndex = 4
		'
		'scorelbl
		'
		Me.scorelbl.AutoSize = True
		Me.scorelbl.ForeColor = System.Drawing.Color.White
		Me.scorelbl.Location = New System.Drawing.Point(12, 9)
		Me.scorelbl.Name = "scorelbl"
		Me.scorelbl.Size = New System.Drawing.Size(47, 13)
		Me.scorelbl.TabIndex = 5
		Me.scorelbl.Text = "Score: 0"
		'
		'MenuPanel
		'
		Me.MenuPanel.BackColor = System.Drawing.Color.Black
		Me.MenuPanel.Controls.Add(Me.TitleSnake_0)
		Me.MenuPanel.Controls.Add(Me.settingspanel)
		Me.MenuPanel.Controls.Add(Me.SettingsBtn)
		Me.MenuPanel.Controls.Add(Me.Highscorestxt)
		Me.MenuPanel.Controls.Add(Me.Highscoresbtn)
		Me.MenuPanel.Controls.Add(Me.Difficultyselector)
		Me.MenuPanel.Controls.Add(Me.Startbtn)
		Me.MenuPanel.Controls.Add(Me.Title)
		Me.MenuPanel.Location = New System.Drawing.Point(12, 9)
		Me.MenuPanel.Name = "MenuPanel"
		Me.MenuPanel.Size = New System.Drawing.Size(705, 476)
		Me.MenuPanel.TabIndex = 6
		'
		'TitleSnake_0
		'
		Me.TitleSnake_0.BackColor = System.Drawing.Color.White
		Me.TitleSnake_0.Location = New System.Drawing.Point(445, 102)
		Me.TitleSnake_0.Name = "TitleSnake_0"
		Me.TitleSnake_0.Size = New System.Drawing.Size(10, 10)
		Me.TitleSnake_0.TabIndex = 7
		'
		'settingspanel
		'
		Me.settingspanel.Controls.Add(Me.savebtn)
		Me.settingspanel.Controls.Add(Me.changecolourbtn)
		Me.settingspanel.Location = New System.Drawing.Point(18, 3)
		Me.settingspanel.Name = "settingspanel"
		Me.settingspanel.Size = New System.Drawing.Size(673, 401)
		Me.settingspanel.TabIndex = 6
		Me.settingspanel.Visible = False
		'
		'savebtn
		'
		Me.savebtn.Location = New System.Drawing.Point(103, 177)
		Me.savebtn.Name = "savebtn"
		Me.savebtn.Size = New System.Drawing.Size(75, 23)
		Me.savebtn.TabIndex = 1
		Me.savebtn.Text = "save"
		Me.savebtn.UseVisualStyleBackColor = True
		'
		'changecolourbtn
		'
		Me.changecolourbtn.Location = New System.Drawing.Point(93, 25)
		Me.changecolourbtn.Name = "changecolourbtn"
		Me.changecolourbtn.Size = New System.Drawing.Size(172, 23)
		Me.changecolourbtn.TabIndex = 0
		Me.changecolourbtn.Text = "Change Snake Colour"
		Me.changecolourbtn.UseVisualStyleBackColor = True
		'
		'SettingsBtn
		'
		Me.SettingsBtn.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SettingsBtn.Location = New System.Drawing.Point(289, 266)
		Me.SettingsBtn.Name = "SettingsBtn"
		Me.SettingsBtn.Size = New System.Drawing.Size(97, 46)
		Me.SettingsBtn.TabIndex = 5
		Me.SettingsBtn.Text = "Settings"
		Me.SettingsBtn.UseVisualStyleBackColor = True
		'
		'Highscorestxt
		'
		Me.Highscorestxt.AutoSize = True
		Me.Highscorestxt.BackColor = System.Drawing.Color.Transparent
		Me.Highscorestxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Highscorestxt.ForeColor = System.Drawing.Color.White
		Me.Highscorestxt.Location = New System.Drawing.Point(550, 75)
		Me.Highscorestxt.Name = "Highscorestxt"
		Me.Highscorestxt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Highscorestxt.Size = New System.Drawing.Size(170, 33)
		Me.Highscorestxt.TabIndex = 4
		Me.Highscorestxt.Text = "Highscores:"
		Me.Highscorestxt.Visible = False
		'
		'Highscoresbtn
		'
		Me.Highscoresbtn.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Highscoresbtn.Location = New System.Drawing.Point(289, 202)
		Me.Highscoresbtn.Name = "Highscoresbtn"
		Me.Highscoresbtn.Size = New System.Drawing.Size(97, 46)
		Me.Highscoresbtn.TabIndex = 3
		Me.Highscoresbtn.Text = "Highscores"
		Me.Highscoresbtn.UseVisualStyleBackColor = True
		'
		'Difficultyselector
		'
		Me.Difficultyselector.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Difficultyselector.FormattingEnabled = True
		Me.Difficultyselector.Items.AddRange(New Object() {"Easy", "Intermediate", "Hard", "Insane", "Impossible"})
		Me.Difficultyselector.Location = New System.Drawing.Point(392, 162)
		Me.Difficultyselector.Name = "Difficultyselector"
		Me.Difficultyselector.Size = New System.Drawing.Size(105, 21)
		Me.Difficultyselector.TabIndex = 2
		Me.Difficultyselector.Text = "Select Difficulty"
		'
		'Startbtn
		'
		Me.Startbtn.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Startbtn.Location = New System.Drawing.Point(289, 138)
		Me.Startbtn.Name = "Startbtn"
		Me.Startbtn.Size = New System.Drawing.Size(97, 45)
		Me.Startbtn.TabIndex = 1
		Me.Startbtn.Text = "Start Game"
		Me.Startbtn.UseVisualStyleBackColor = True
		'
		'Title
		'
		Me.Title.AutoSize = True
		Me.Title.BackColor = System.Drawing.Color.Transparent
		Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Title.ForeColor = System.Drawing.Color.White
		Me.Title.Location = New System.Drawing.Point(223, 16)
		Me.Title.Name = "Title"
		Me.Title.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Title.Size = New System.Drawing.Size(255, 73)
		Me.Title.TabIndex = 0
		Me.Title.Text = "SNAKE"
		'
		'ColourChanger
		'
		Me.ColourChanger.Interval = 50
		'
		'Fader
		'
		Me.Fader.Interval = 1
		'
		'scoredisp
		'
		Me.scoredisp.AutoSize = True
		Me.scoredisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.scoredisp.ForeColor = System.Drawing.Color.White
		Me.scoredisp.Location = New System.Drawing.Point(120, 0)
		Me.scoredisp.Name = "scoredisp"
		Me.scoredisp.Size = New System.Drawing.Size(0, 16)
		Me.scoredisp.TabIndex = 7
		'
		'TitleMover
		'
		Me.TitleMover.Enabled = True
		'
		'ParentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(732, 513)
		Me.Controls.Add(Me.scoredisp)
		Me.Controls.Add(Me.MenuPanel)
		Me.Controls.Add(Me.scorelbl)
		Me.Controls.Add(Me.Snake_3)
		Me.Controls.Add(Me.Snake_2)
		Me.Controls.Add(Me.Snake_1)
		Me.Controls.Add(Me.Snake_0)
		Me.Controls.Add(Me.ShapeContainer1)
		Me.KeyPreview = True
		Me.Name = "ParentForm"
		Me.Text = "Snake"
		Me.MenuPanel.ResumeLayout(False)
		Me.MenuPanel.PerformLayout()
		Me.settingspanel.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Snake_0 As System.Windows.Forms.Label
    Friend WithEvents Snake_1 As System.Windows.Forms.Label
    Friend WithEvents Snake_2 As System.Windows.Forms.Label
    Friend WithEvents Mover As System.Windows.Forms.Timer
    Friend WithEvents Snake_3 As System.Windows.Forms.Label
    Friend WithEvents scorelbl As System.Windows.Forms.Label
    Friend WithEvents MenuPanel As System.Windows.Forms.Panel
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Difficultyselector As System.Windows.Forms.ComboBox
    Friend WithEvents Startbtn As System.Windows.Forms.Button
    Friend WithEvents Highscoresbtn As System.Windows.Forms.Button
    Friend WithEvents Highscorestxt As System.Windows.Forms.Label
    Friend WithEvents ColourChanger As System.Windows.Forms.Timer
    Friend WithEvents Fader As System.Windows.Forms.Timer
    Friend WithEvents scoredisp As System.Windows.Forms.Label
    Friend WithEvents SettingsBtn As System.Windows.Forms.Button
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents Food As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents settingspanel As System.Windows.Forms.Panel
    Friend WithEvents changecolourbtn As System.Windows.Forms.Button
    Friend WithEvents Snakecolour As System.Windows.Forms.ColorDialog
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents TitleSnake_0 As System.Windows.Forms.Label
    Friend WithEvents TitleMover As System.Windows.Forms.Timer

End Class
