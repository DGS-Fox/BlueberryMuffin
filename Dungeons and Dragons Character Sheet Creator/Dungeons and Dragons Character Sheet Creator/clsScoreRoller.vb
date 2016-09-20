Public Class clsScoreRoller
#Region "Const and Variables"
    Private Const MAX_ROLL As Integer = 7 'need to be 7, because 6 wont hit
    Private Const LOW_ROLL As Integer = 1
    'Declare Variables for the stat
    Private Roll1, Roll2, Roll3, Roll4, LowestNumber, Score, seed As Integer
#End Region
#Region "Constructors"
    Sub New(ByVal NewSeed As Integer)
        Generate(NewSeed)
    End Sub
#End Region
#Region "Properties"
    ReadOnly Property getRoll1
        Get
            Return Roll1
        End Get
    End Property
    ReadOnly Property getRoll2
        Get
            Return Roll2
        End Get
    End Property
    ReadOnly Property getRoll3
        Get
            Return Roll3
        End Get
    End Property
    ReadOnly Property getRoll4
        Get
            Return Roll4
        End Get
    End Property
    ReadOnly Property getScore
        Get
            Return Score
        End Get
    End Property
    ReadOnly Property getLowestNumber
        Get
            Return LowestNumber
        End Get
    End Property
    ReadOnly Property getModifer
        Get
            Select Case Score
                Case 18
                    Return 4
                Case 17, 16
                    Return 3
                Case 15, 14
                    Return 2
                Case 13, 12
                    Return 1
                Case 11, 10
                    Return 0
                Case 9, 8
                    Return -1
                Case 7, 6
                    Return -2
                Case 5, 4
                    Return -3
                Case 3
                    Return -4
                Case Else
                    Return "FAILURE"
                    MessageBox.Show("Error in score roller.")
            End Select
        End Get
    End Property
#End Region
#Region "Methods"

    Private Sub Generate(newSeed As Integer)
        Dim RandomNumberGenerator As New Random(newSeed)
        'Create an array for the scores. I know you dont like arrays so...fuck you i dont care
        Dim scoreArr(3) As Integer
        'Set Roll Values
        Roll1 = RandomNumberGenerator.Next(LOW_ROLL, MAX_ROLL)
        Roll2 = RandomNumberGenerator.Next(LOW_ROLL, MAX_ROLL)
        Roll3 = RandomNumberGenerator.Next(LOW_ROLL, MAX_ROLL)
        Roll4 = RandomNumberGenerator.Next(LOW_ROLL, MAX_ROLL)
        'place them in the array
        scoreArr(0) = Roll1
        scoreArr(1) = Roll2
        scoreArr(2) = Roll3
        scoreArr(3) = Roll4
        'Add All Scores Together
        Score = Roll1 + Roll2 + Roll3 + Roll4
        'Now Sift through and find the lowest Value
        Array.Sort(scoreArr)
        'Get the lowest number
        LowestNumber = scoreArr(0)
        'remove the lowest number from the total
        Score -= LowestNumber
    End Sub
#End Region
End Class
