Public Class frmMain
    Dim RandomNumberGenerator _
        As New Random(DateAndTime.Now.Millisecond)

#Region "Functions and Subs"
    Private Sub EnableControls()
        cboClass.Enabled = True
        cboRace.Enabled = True
    End Sub
#End Region

    Private Sub btnGenerate_Click() _
        Handles btnGenerate.Click

        Dim Roller1, Roller2, Roller3, Roller4, Roller5, Roller6 _
            As New clsScoreRoller(CInt(RandomNumberGenerator.Next(1, 100)))
        Dim TotalModCheck As Integer = 0

        lblRNG1.Text = Roller1.getScore.ToString
        lblRNG2.Text = Roller2.getScore.ToString
        lblRNG3.Text = Roller3.getScore.ToString
        lblRNG4.Text = Roller4.getScore.ToString
        lblRNG5.Text = Roller5.getScore.ToString
        lblRNG6.Text = Roller6.getScore.ToString

        'This chunk is to display values for testing
        stat1roll1.Text = Roller1.getRoll1.ToString
        stat1roll2.Text = Roller1.getRoll2.ToString
        stat1roll3.Text = Roller1.getRoll3.ToString
        stat1roll4.Text = Roller1.getRoll4.ToString
        stat1low.Text = Roller1.getLowestNumber.ToString
        stat1total.Text = Roller1.getScore.ToString
        stat1mod.Text = Roller1.getModifer.ToString

        stat2roll1.Text = Roller2.getRoll1.ToString
        stat2roll2.Text = Roller2.getRoll2.ToString
        stat2roll3.Text = Roller2.getRoll3.ToString
        stat2roll4.Text = Roller2.getRoll4.ToString
        stat2low.Text = Roller2.getLowestNumber.ToString
        stat2total.Text = Roller2.getScore.ToString
        stat2mod.Text = Roller2.getModifer.ToString

        stat3roll1.Text = Roller3.getRoll1.ToString
        stat3roll2.Text = Roller3.getRoll2.ToString
        stat3roll3.Text = Roller3.getRoll3.ToString
        stat3roll4.Text = Roller3.getRoll4.ToString
        stat3low.Text = Roller3.getLowestNumber.ToString
        stat3total.Text = Roller3.getScore.ToString
        stat3mod.Text = Roller3.getModifer.ToString

        stat4roll1.Text = Roller4.getRoll1.ToString
        stat4roll2.Text = Roller4.getRoll2.ToString
        stat4roll3.Text = Roller4.getRoll3.ToString
        stat4roll4.Text = Roller4.getRoll4.ToString
        stat4low.Text = Roller4.getLowestNumber.ToString
        stat4total.Text = Roller4.getScore.ToString
        stat4mod.Text = Roller4.getModifer.ToString

        stat5roll1.Text = Roller5.getRoll1.ToString
        stat5roll2.Text = Roller5.getRoll2.ToString
        stat5roll3.Text = Roller5.getRoll3.ToString
        stat5roll4.Text = Roller5.getRoll4.ToString
        stat5low.Text = Roller5.getLowestNumber.ToString
        stat5total.Text = Roller5.getScore.ToString
        stat5mod.Text = Roller5.getModifer.ToString

        stat6roll1.Text = Roller6.getRoll1.ToString
        stat6roll2.Text = Roller6.getRoll2.ToString
        stat6roll3.Text = Roller6.getRoll3.ToString
        stat6roll4.Text = Roller6.getRoll4.ToString
        stat6low.Text = Roller6.getLowestNumber.ToString
        stat6total.Text = Roller6.getScore.ToString
        stat6mod.Text = Roller6.getModifer.ToString
        'end chunk
        TotalModCheck += Roller1.getModifer
        TotalModCheck += Roller2.getModifer
        TotalModCheck += Roller3.getModifer
        TotalModCheck += Roller4.getModifer
        TotalModCheck += Roller5.getModifer
        TotalModCheck += Roller6.getModifer

        TotalMod.Text = TotalModCheck.ToString
        'MessageBox.Show("generate character function")


    End Sub

    Private Sub radFirstEdition_CheckedChanged() _
        Handles radFirstEdition.CheckedChanged,
        radSecondEdition.CheckedChanged,
        radThirdEdition.CheckedChanged,
        rad35Edition.CheckedChanged,
        radFourthEdition.CheckedChanged,
        radFifthEdition.CheckedChanged
        'Enable the dropdown lists after an edition is selected.
        EnableControls()


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        lblRNG1.Text = "Null"
        lblRNG2.Text = "Null"
        lblRNG3.Text = "Null"
        lblRNG4.Text = "Null"
        lblRNG5.Text = "Null"
        lblRNG6.Text = "Null"
    End Sub

End Class
