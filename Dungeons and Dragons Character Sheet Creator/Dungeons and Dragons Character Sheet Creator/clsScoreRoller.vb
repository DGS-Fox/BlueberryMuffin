Public Class clsScoreRoller
#Region "Const and Variables"
    Protected RandomNumberGenerator As New Random(DateAndTime.Now.Millisecond)
    'Declare Variables for the stat
    Private Roll1, Roll2, Roll3, Roll4, LowestNumber, Score As Integer
#End Region
#Region "Constructors"
    Sub New()
        Generate()
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
#End Region
#Region "Methods"
    Private Sub Generate()
        'Create an array for the scores. I know you dont like arrays so...fuck you i dont care
        Dim scoreArr(3) As Integer
        'Set Roll Values
        scoreArr(0) = Roll1 = RandomNumberGenerator.Next(1, 6)
        scoreArr(1) = Roll2 = RandomNumberGenerator.Next(1, 6)
        scoreArr(2) = Roll3 = RandomNumberGenerator.Next(1, 6)
        scoreArr(3) = Roll4 = RandomNumberGenerator.Next(1, 6)
        'Add All Scores Together
        Score = Roll1 + Roll2 + Roll3 + Roll4
        'Now Sift through and find the lowest Value
        Array.Sort(scoreArr)
        'Get the lowest number
        LowestNumber = scoreArr(3)
        'remove the lowest number from the total
        Score -= LowestNumber
    End Sub
#End Region
End Class
