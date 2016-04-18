Public Class frmMain
#Region "Functions and Subs"
    Private Sub EnableControls()
        cboClass.Enabled = True
        cboRace.Enabled = True
    End Sub
#End Region


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        MessageBox.Show("generate character function")
    End Sub

    Private Sub radFirstEdition_CheckedChanged(sender As Object, e As EventArgs) Handles radFirstEdition.CheckedChanged,
                                                                                         radSecondEdition.CheckedChanged,
                                                                                         radThirdEdition.CheckedChanged,
                                                                                         rad35Edition.CheckedChanged,
                                                                                         radFourthEdition.CheckedChanged,
                                                                                         radFifthEdition.CheckedChanged
        'Enable the dropdown lists after an edition is selected.
        EnableControls()


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRNG1.Text = "Null"
        lblRNG2.Text = "Null"
        lblRNG3.Text = "Null"
        lblRNG4.Text = "Null"
        lblRNG5.Text = "Null"
        lblRNG6.Text = "Null"
    End Sub
End Class
