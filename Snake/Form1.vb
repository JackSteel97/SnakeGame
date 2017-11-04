'start time: 23:22

'**************************
'*SNAKE CODE BY JACK STEEL*
'**************************

Public Class ParentForm
    Dim SnakeBody(1000) As Label
	Dim TitleSnake(10000) As Label
    Dim directionreq As Char
	Dim Length_of_Snake As Integer
	Dim Score As Integer
	Dim showing As Boolean
	Dim currentstate As Byte
	Dim difficulty As Byte
    Dim powerfood As Boolean
	Dim FRed As Byte
	Dim FGreen As Byte
    Dim FBlue As Byte
    Dim direction As Char
    Dim colour As System.Drawing.Color
	Dim paused As Boolean
	Dim Titledirectionreq As Char
	Dim TitleDirection As Char
	Dim titlecount As Integer
	Dim titlesnakelength As Integer


    Private Sub InitialiseSnake()
        Dim name As String

        SnakeBody(0) = Snake_0
        SnakeBody(1) = Snake_1
        SnakeBody(2) = Snake_2
        SnakeBody(3) = Snake_3
        TitleSnake(0) = TitleSnake_0
        'title snake
		For i = 1 To 20
			name = "TitleSnake_" & i
			Dim newpartTitle As New Label

			newpartTitle.Name = name
			newpartTitle.Left = TitleSnake(i - 1).Left - 10
			newpartTitle.Top = TitleSnake(i - 1).Top
			newpartTitle.Visible = True
			newpartTitle.BackColor = Color.White
			newpartTitle.AutoSize = False
			newpartTitle.Size = Snake_0.Size

			Me.Controls.Add(newpartTitle)
			newpartTitle.Parent = MenuPanel
			TitleSnake(i) = newpartTitle
		Next
		scorelbl.SendToBack()
		titlesnakelength = 20
    End Sub

	Private Sub TitleSnakeMover(ByVal directionnum As Integer)
		
		TitleSnake_0.SendToBack()
		
		Select Case directionnum
			Case 1
				If TitleDirection <> "U" Then
					Titledirectionreq = "D"
				End If

			Case 2
				If TitleDirection <> "L" Then
					Titledirectionreq = "R"
				End If
			Case 3
				If TitleDirection <> "D" Then
					Titledirectionreq = "U"
				End If
			Case 4
				If TitleDirection <> "R" Then
					Titledirectionreq = "L"
				End If
		End Select

		TitleDirection = Titledirectionreq
		'Update snake
		For i = titlesnakelength To 1 Step -1
			TitleSnake(i).Top = TitleSnake(i - 1).Top
			TitleSnake(i).Left = TitleSnake(i - 1).Left
			TitleSnake(i).SendToBack()
		Next
		'end

		If TitleDirection = "R" Then
			TitleSnake(0).Left += 10
		ElseIf TitleDirection = "L" Then
			TitleSnake(0).Left -= 10
		ElseIf TitleDirection = "D" Then
			TitleSnake(0).Top += 10
		ElseIf TitleDirection = "U" Then
			TitleSnake(0).Top -= 10
		End If



		If TitleSnake(0).Left >= Me.Width - 100 Then
			TitleSnake(0).Left -= 10
			TitleDirection = "L"
		End If
		If TitleSnake(0).Left <= 100 Then
			TitleSnake(0).Left += 10
			TitleDirection = "R"

		End If
		If TitleSnake(0).Top <= 100 Then
			TitleSnake(0).Top += 10
			TitleDirection = "D"

		End If
		If TitleSnake(0).Top >= Me.Height - 50 Then
			TitleSnake(0).Top -= 10
			TitleDirection = "U"

		End If



		



		


	End Sub

	Private Sub growtitlesnake()
		Dim name As String
		name = "TitleSnake_" & titlesnakelength + 1
		Dim newpart As New Label

		newpart.Name = name
		newpart.Left = TitleSnake(titlesnakelength).Left - 10
		newpart.Top = TitleSnake(titlesnakelength).Top
		newpart.Visible = True
		newpart.BackColor = Color.White
		newpart.AutoSize = False
		newpart.Size = TitleSnake_0.Size

		Me.Controls.Add(newpart)
		newpart.Parent = MenuPanel
		TitleSnake(titlesnakelength + 1) = newpart
		titlesnakelength += 1
	End Sub
	Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Length_of_Snake = 3
		direction = "R"
		InitialiseSnake()
		MenuPanel.Size = Me.Size
		MenuPanel.Top = 0
        MenuPanel.Left = 0
		colour = Color.White
		TitleDirection = "R"
		My.Computer.Audio.Play(My.Resources.SnakeTheme, AudioPlayMode.BackgroundLoop)
	End Sub

	Private Sub Mover_Tick(sender As Object, e As EventArgs) Handles Mover.Tick
        UpdateSnake()
        If directionreq = "R" Then
            direction = "R"
        ElseIf directionreq = "L" Then
            direction = "L"
        ElseIf directionreq = "D" Then
            direction = "D"
        ElseIf directionreq = "U" Then
            direction = "U"
        End If
        If direction = "R" Then
            SnakeBody(0).Left += 10
        ElseIf direction = "L" Then
            SnakeBody(0).Left -= 10
        ElseIf direction = "D" Then
            SnakeBody(0).Top += 10
        ElseIf direction = "U" Then
            SnakeBody(0).Top -= 10
        End If

		'Collisions
		For i = 1 To Length_of_Snake
			If SnakeBody(0).Bounds.IntersectsWith(SnakeBody(i).Bounds) Then
				Mover.Enabled = False
				DeathOccured()
				Exit For
			ElseIf SnakeBody(0).Left < 0 Or SnakeBody(0).Left > Me.Width - 10 Or SnakeBody(0).Top < 0 Or SnakeBody(0).Top > Me.Height - 10 Then
				Mover.Enabled = False
				DeathOccured()
				Exit For
			End If


		Next

	End Sub
	Private Sub deathoccured()
		Dim name As String

		name = InputBox("Your Final score is: " & Score & Chr(13) & "Enter your name")
		If Not Score < 0 And Not name = "" Then
			FileOpen(1, "Highscores.txt", OpenMode.Append)
			PrintLine(1, name & ": " & Score & Chr(13))
			FileClose(1)
		End If
		MenuPanel.Show()

		'Reset
		InitialiseSnake()
		For i = 4 To Length_of_Snake
			Me.Controls.Remove(SnakeBody(i))
		Next
		Length_of_Snake = 3
        directionreq = "R"
		SnakeBody(0).Left = 250
		SnakeBody(0).Top = 210
        SnakeBody(1).Left = 240
        SnakeBody(1).Top = 210
        SnakeBody(2).Left = 230
        SnakeBody(2).Top = 210
        SnakeBody(3).Left = 220
        SnakeBody(3).Top = 210
		GenerateFood()
		TitleMover.Start()
	End Sub
	Private Sub UpdateSnake()
		For i = Length_of_Snake To 1 Step -1
			SnakeBody(i).Top = SnakeBody(i - 1).Top
			SnakeBody(i).Left = SnakeBody(i - 1).Left
		Next
		If SnakeBody(0).Bounds.IntersectsWith(Food.Bounds) Then
			GrowSnake()
            GenerateFood()
		End If
	End Sub

	Private Sub GrowSnake()
		Dim name As String
		name = "Snake_" & Length_of_Snake + 1
		Dim newpart As New Label

		newpart.Name = name
		newpart.Left = SnakeBody(Length_of_Snake).Left - 10
		newpart.Top = SnakeBody(Length_of_Snake).Top
		newpart.Visible = True
		newpart.BackColor = Food.BackColor
		newpart.AutoSize = False
		newpart.Size = Snake_0.Size

		Me.Controls.Add(newpart)
		SnakeBody(Length_of_Snake + 1) = newpart

		If powerfood = True Then
			Score += 100 * difficulty + (Length_of_Snake \ 3)
			scoredisp.Text = 100 * difficulty + (Length_of_Snake \ 3)
            scoredisp.ForeColor = colour
			scoredisp.Location = Food.Location
			scoredisp.SendToBack()
			scoredisp.Show()
			FRed = 255
			FBlue = 255
			FGreen = 255
			Fader.Start()
		Else
			Score = Score + ((Length_of_Snake \ 3) * difficulty)
			scoredisp.Text = ((Length_of_Snake \ 3) * difficulty)
            scoredisp.ForeColor = colour
			scoredisp.Location = Food.Location
			scoredisp.SendToBack()
			scoredisp.Show()
			FRed = 255
			FBlue = 255
			FGreen = 255
			Fader.Start()
		End If

		scorelbl.Text = "Score: " & Score
		Length_of_Snake += 1






	End Sub
	Private Sub DirectionChangeKey(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyData = Keys.S Or e.KeyData = Keys.Down Then
			If direction <> "U" Then
                directionreq = "D"
			End If

		End If
		If e.KeyData = Keys.D Or e.KeyData = Keys.Right Then
			If direction <> "L" Then
                directionreq = "R"
			End If
		End If
		If e.KeyData = Keys.A Or e.KeyData = Keys.Left Then
			If direction <> "R" Then
                directionreq = "L"
			End If

		End If
		If e.KeyData = Keys.W Or e.KeyData = Keys.Up Then
			If direction <> "D" Then
                directionreq = "U"
			End If
        End If
        If e.KeyData = Keys.P Then
            If paused = True Then
                paused = False
                Mover.Start()
            Else
                paused = True
                Mover.Stop()
            End If
        End If

	End Sub

	Private Sub GenerateFood()
		Dim toppos As Integer
		Dim leftpos As Integer
		Dim powerchance As Integer


		Randomize()
		toppos = ((Int(((Me.Height - 100) - 1 + 1) * Rnd() + 1)) \ 10) * 10
		Randomize()
		leftpos = ((Int(((Me.Width - 100) - 1 + 1) * Rnd() + 1)) \ 10) * 10

		Randomize()
		powerchance = Int((100 - 0 + 1) * Rnd() + 0)
		If powerchance > 90 Then
			ColourChanger.Start()
			powerfood = True
		Else
			ColourChanger.Stop()
			Food.BackColor = Color.White
			powerfood = False
		End If


		Dim CRed As Integer
		Dim CBlue As Integer
		Dim CGreen As Integer

		Randomize()
		CRed = Int((255 - 10 + 1) * Rnd() + 10)
		Randomize()
		CBlue = Int((255 - 10 + 1) * Rnd() + 10)
		Randomize()
		CGreen = Int((255 - 10 + 1) * Rnd() + 10)


		Food.BackColor = (Color.FromArgb(CRed, CGreen, CBlue))


		Food.Top = toppos
		Food.Left = leftpos
		Food.Show()

	End Sub

	Private Sub resizemenu(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
		MenuPanel.Size = Me.Size
	End Sub

	Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
		If Difficultyselector.Text = "Select Difficulty" Then
			MsgBox("Please Select a Difficulty", MsgBoxStyle.Exclamation, "Difficulty Error")

		ElseIf Difficultyselector.Text = "Easy" Then
			Mover.Interval = 100
			MenuPanel.Hide()
			Mover.Enabled = True
			difficulty = 1
			TitleMover.Stop()
		ElseIf Difficultyselector.Text = "Intermediate" Then
			Mover.Interval = 75
			MenuPanel.Hide()
			Mover.Enabled = True
			difficulty = 2
			TitleMover.Stop()
		ElseIf Difficultyselector.Text = "Hard" Then
			Mover.Interval = 50
			MenuPanel.Hide()
			Mover.Enabled = True
			difficulty = 3
			TitleMover.Stop()
		ElseIf Difficultyselector.Text = "Insane" Then
			Mover.Interval = 20
			MenuPanel.Hide()
			Mover.Enabled = True
			difficulty = 4
			TitleMover.Stop()
		ElseIf Difficultyselector.Text = "Impossible" Then
			Mover.Interval = 1
			MenuPanel.Hide()
			Mover.Enabled = True
			difficulty = 5
			TitleMover.Stop()
		End If

		Score = 0
		scorelbl.Text = "Score: " & Score


	End Sub

	Private Sub Highscoresbtn_Click(sender As Object, e As EventArgs) Handles Highscoresbtn.Click

		Dim currentline As String
		Dim splitrecord() As String
		Dim arrayelements As Integer
		Dim holdingname As String
		Dim holdingscore As Integer
		Dim namearr(100) As String
		Dim scorearr(100) As Integer
		Dim count As Integer = 0

		FileOpen(1, "Highscores.txt", OpenMode.Input)
		Do Until EOF(1) = True
			currentline = LineInput(1)
			splitrecord = currentline.Split(":")
			namearr(count) = splitrecord(0)
			Try
				scorearr(count) = splitrecord(1)
			Catch ex As Exception
				count = count - 1
			End Try

			count = count + 1

		Loop
		FileClose(1)
		arrayelements = count - 2
		For i = 0 To arrayelements

			For j = 0 To arrayelements
				If scorearr(j + 1) > scorearr(j) Then
					holdingscore = scorearr(j)
					holdingname = namearr(j)
					scorearr(j) = scorearr(j + 1)
					namearr(j) = namearr(j + 1)
					scorearr(j + 1) = holdingscore
					namearr(j + 1) = holdingname


				End If
			Next
		Next

		If showing = False Then
			If Me.WindowState = FormWindowState.Maximized Then
				currentstate = 0
			Else
				currentstate = 1
			End If

			Me.WindowState = FormWindowState.Maximized
			Highscorestxt.Show()
			Highscorestxt.Text = "HIGHSCORES: " & Chr(13) & Chr(13)
			For i = 0 To count - 1
				Highscorestxt.Text = Highscorestxt.Text & (namearr(i)) & ": " & scorearr(i) & Chr(13)
			Next
			showing = True
		ElseIf showing = True Then
			If currentstate = 0 Then
				Me.WindowState = FormWindowState.Maximized
			ElseIf currentstate = 1 Then
				Me.WindowState = FormWindowState.Normal
			End If

			Highscorestxt.Hide()
			showing = False
		End If
	End Sub

	Private Sub ColourChanger_Tick(sender As Object, e As EventArgs) Handles ColourChanger.Tick
		Dim CRed As Integer
		Dim CBlue As Integer
		Dim CGreen As Integer

		Randomize()
		CRed = Int((255 - 1 + 1) * Rnd() + 1)
		Randomize()
		CBlue = Int((255 - 1 + 1) * Rnd() + 1)
		Randomize()
		CGreen = Int((255 - 1 + 1) * Rnd() + 1)


		Food.BackColor = (Color.FromArgb(CRed, CGreen, CBlue))

	End Sub

	Private Sub Fader_Tick(sender As Object, e As EventArgs) Handles Fader.Tick
		If FRed >= 5 Then
			FRed -= 5
			FBlue -= 5
			FGreen -= 5
			scoredisp.Top -= 1
		Else
			FRed = 255
			FBlue = 255
			FGreen = 255
			scoredisp.Hide()
			Fader.Stop()
		End If


		scoredisp.ForeColor = Color.FromArgb(FRed, FBlue, FGreen)
	End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        settingspanel.Show()

    End Sub

    Private Sub changecolourbtn_Click(sender As Object, e As EventArgs) Handles changecolourbtn.Click

        If Snakecolour.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            colour = Snakecolour.Color
            Snake_0.BackColor = colour
            Snake_1.BackColor = colour
            Snake_2.BackColor = colour
            Snake_3.BackColor = colour
        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        settingspanel.Hide()

    End Sub

	Private Sub TitleMover_Tick(sender As Object, e As EventArgs) Handles TitleMover.Tick
		Dim directionnumd As Integer

		If titlecount >= 3 Then
			Randomize()
			directionnumd = Int((4 - 1 + 1) * Rnd() + 1)
			titlecount = 0
			growtitlesnake()
		End If
		
		TitleSnakeMover(directionnumd)
		titlecount += 1

	End Sub
End Class

'End time: 00:09
