Public Class frmMain
    Dim RandomNumberGenerator _
        As New Random(DateAndTime.Now.Millisecond)

#Region "Functions and Subs"
    Private Sub radFirstEdition_CheckedChanged() _
        Handles radFirstEdition.CheckedChanged,
        radSecondEdition.CheckedChanged,
        radThirdEdition.CheckedChanged,
        rad35Edition.CheckedChanged,
        radFourthEdition.CheckedChanged,
        radFifthEdition.CheckedChanged
        'local var
        Dim edition As Decimal
        'Read the Radiobuttons and then assign the edition
        If radFirstEdition.Checked = True Then
            edition = 1
        ElseIf radSecondEdition.Checked = True Then
            edition = 2
        ElseIf radThirdEdition.Checked = True Then
            edition = 3
        ElseIf rad35Edition.Checked = True Then
            edition = 3.5
        ElseIf radFourthEdition.Checked = True Then
            edition = 4
        ElseIf radFifthEdition.Checked = True Then
            edition = 5
        Else
            MsgBox("Edtion Selector Error")
        End If
        'Enable the dropdown lists after an edition is selected.
        EnableOrRefreshControls(edition)
    End Sub

    Private Sub EnableOrRefreshControls(ed As Decimal)

        LoadClassList(ed)
        cboClass.Enabled = True
        LoadRaceList(ed)
        cboRace.Enabled = True
    End Sub


    Private Sub LoadClassList(edition As Decimal)
        'remove all items in the dropdown box
        cboClass.Items.Clear()
        Select Case edition
            Case 1
                cboClass.Items.Add("Cleric")
                cboClass.Items.Add("Druid")
                cboClass.Items.Add("Fighter")
                cboClass.Items.Add("Paladin")
                cboClass.Items.Add("Ranger")
                cboClass.Items.Add("Magic-User")
                cboClass.Items.Add("Illusionist")
                cboClass.Items.Add("Thief")
                cboClass.Items.Add("Assassin")
                cboClass.Items.Add("Monk")
        End Select
    End Sub
    Private Sub LoadRaceList(edition As Decimal)
        'remove all items in the dropdown box
        cboRace.Items.Clear()
        Select Case edition
            Case 1
                cboRace.Items.Add("Dwarves")
                cboRace.Items.Add("Elves")
                cboRace.Items.Add("Gnomes")
                cboRace.Items.Add("Half-Elves")
                cboRace.Items.Add("Halflings")
                cboRace.Items.Add("Half-Orcs")
                cboRace.Items.Add("Humans")
        End Select
    End Sub


#End Region

    Private Sub btnGenerate_Click() Handles btnGenerate.Click
        'Create each variables for each score roll.
        Dim Roller1, Roller2, Roller3, Roller4, Roller5, Roller6 _
            As New clsScoreRoller(RandomNumberGenerator.Next(1, 100))
        Dim TotalModCheck As Integer = 0

        Try
            'read the dropdowns to read the Items and Throw Errors if neeeded.
            If cboRace.Items.Count = 0 And cboClass.Items.Count = 0 Then
                Throw New EditionNotYetReadyForGenerationException
            End If
            If IsNothing(cboRace.SelectedItem) Or IsNothing(cboClass.SelectedItem) Then
                Throw New NotAllDataHasBeenSelectedException
            End If


            lblRNG1.Text = Roller1.getScore.ToString
            lblRNG2.Text = Roller2.getScore.ToString
            lblRNG3.Text = Roller3.getScore.ToString
            lblRNG4.Text = Roller4.getScore.ToString
            lblRNG5.Text = Roller5.getScore.ToString
            lblRNG6.Text = Roller6.getScore.ToString

            'end chunk
            TotalModCheck += Roller1.getModifer
            TotalModCheck += Roller2.getModifer
            TotalModCheck += Roller3.getModifer
            TotalModCheck += Roller4.getModifer
            TotalModCheck += Roller5.getModifer
            TotalModCheck += Roller6.getModifer

            TotalMod.Text = TotalModCheck.ToString

            If TotalModCheck < 0 Then
                lblStatus.Text = "Total modifier values are less than 0, You may want to re-roll you character."
            Else
                lblStatus.Text = ""
                btnGenerate.Enabled = False
            End If
            'MessageBox.Show("generate character function")

        Catch NoData As NotAllDataHasBeenSelectedException
            MsgBox("Please select all items in the dropdown boxes.")
        Catch BadEdition As EditionNotYetReadyForGenerationException
            MsgBox("That Edition has not been comlpeted yet.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        lblRNG1.Text = "Null"
        lblRNG2.Text = "Null"
        lblRNG3.Text = "Null"
        lblRNG4.Text = "Null"
        lblRNG5.Text = "Null"
        lblRNG6.Text = "Null"
        lblStatus.Text = ""
    End Sub

End Class
