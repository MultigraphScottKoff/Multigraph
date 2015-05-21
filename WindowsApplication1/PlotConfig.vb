''' <summary>
''' Configuration data for a single plot
''' </summary>
''' <remarks></remarks>
Public Class PlotConfig

    Private _name As String
    Private _setList As List(Of XLSet)
    Private _colors As List(Of Color)
    Private _x_var As String
    Private _y_var As String
    Private _allSets As Boolean
    Private _oneSeries As Boolean
    Private _varlist As List(Of String)
    Private Random As New Random

    ''' <summary>
    ''' Create a PlotConfig with a given name
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <remarks></remarks>
    Public Sub New(Name As String)
        _name = Name
        _setList = New List(Of XLSet)
        _colors = New List(Of Color)
        _x_var = ""
        _y_var = ""
        _allSets = False
        _oneSeries = False
        _varlist = New List(Of String)
        Random = New Random
    End Sub
    ''' <summary>
    ''' Create a PlotConfig as a copy of another PlotConfig
    ''' </summary>
    ''' <param name="myConfig"></param>
    ''' <remarks></remarks>
    Public Sub New(MyConfig As PlotConfig)
        _name = MyConfig.Name
        _setList = MyConfig.SetList.ToList
        _colors = MyConfig.Colors.ToList
        _x_var = MyConfig.X
        _y_var = MyConfig.Y
        _allSets = MyConfig.AllSets
        _oneSeries = MyConfig.OneSeries
        _varlist = MyConfig.VarList.ToList
        Random = New Random
    End Sub
    ''' <summary>
    ''' Name of plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    ''' <summary>
    ''' List of XLSet colors for this plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Colors() As List(Of Color)
        Get
            Return _colors
        End Get
        Set(value As List(Of Color))
            _colors = value
        End Set
    End Property
    ''' <summary>
    ''' List of XLSets for this plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetList() As List(Of XLSet)
        Get
            Return _setList
        End Get
        Set(value As List(Of XLSet))
            _setList = value
        End Set
    End Property
    ''' <summary>
    ''' X variable for this plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property X() As String
        Get
            Return _x_var
        End Get
        Set(value As String)
            _x_var = value
        End Set
    End Property
    ''' <summary>
    ''' Y variable for this plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Y() As String
        Get
            Return _y_var
        End Get
        Set(value As String)
            _y_var = value
        End Set
    End Property
    ''' <summary>
    ''' switch to determine whether all available sets used for plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AllSets() As Boolean
        Get
            Return _allSets
        End Get
        Set(value As Boolean)
            _allSets = value
        End Set
    End Property
    ''' <summary>
    ''' switch to determine whether all sets used for plot displayed as one series
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OneSeries() As Boolean
        Get
            Return _oneSeries
        End Get
        Set(value As Boolean)
            _oneSeries = value
        End Set
    End Property
    ''' <summary>
    ''' list of valid variables for this plot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property VarList() As List(Of String)
        Get
            Return _varlist
        End Get
        Set(value As List(Of String))
            _varlist = value
        End Set
    End Property
    ''' <summary>
    ''' Add an XLSet to this plot and generate a color
    ''' </summary>
    ''' <param name="NewSet"></param>
    ''' <remarks></remarks>
    Public Sub AddSet(NewSet As XLSet)
        Dim numSets As Integer = _setList.Count
        Dim goodColor As Boolean = False

        _setList.Add(NewSet)
        'if set small enough, choose a default color that has not been chosen, else, get a random
        While Not goodColor
            Select Case numSets
                Case 0
                    If Not _colors.Contains(Color.Black) Then
                        goodColor = True
                        _colors.Add(Color.Black)
                    Else
                        numSets += 1
                    End If
                Case 1
                    If Not _colors.Contains(Color.Red) Then
                        goodColor = True
                        _colors.Add(Color.Red)
                    Else
                        numSets += 1
                    End If
                Case 2
                    If Not _colors.Contains(Color.Blue) Then
                        goodColor = True
                        _colors.Add(Color.Blue)
                    Else
                        numSets += 1
                    End If
                Case 3
                    If Not _colors.Contains(Color.Yellow) Then
                        goodColor = True
                        _colors.Add(Color.Yellow)
                    Else
                        numSets += 1
                    End If
                Case 4
                    If Not _colors.Contains(Color.Green) Then
                        goodColor = True
                        _colors.Add(Color.Green)
                    Else
                        numSets += 1
                    End If
                Case 5
                    If Not _colors.Contains(Color.Orange) Then
                        goodColor = True
                        _colors.Add(Color.Orange)
                    Else
                        numSets += 1
                    End If
                Case 6
                    If Not _colors.Contains(Color.Purple) Then
                        goodColor = True
                        _colors.Add(Color.Purple)
                    Else
                        numSets += 1
                    End If
                Case Else
                    Dim newColor As Color = RandomColor()
                    While _colors.Contains(newColor)
                        newColor = RandomColor()
                    End While
                    goodColor = True
                    _colors.Add(newColor)
            End Select
        End While
    End Sub
    ''' <summary>
    ''' Removes an XLSet
    ''' </summary>
    ''' <param name="Index"></param>
    ''' <remarks></remarks>
    Public Sub RemoveSet(Index As Integer)
        _setList.RemoveAt(Index)
        _colors.RemoveAt(Index)
    End Sub
    ''' <summary>
    ''' Picks random color for new set
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function RandomColor() As Color
        Dim RGBList(2) As Integer
        Dim max As Integer = 576
        Dim diff As Integer

        For i = 0 To 2
            RGBList(i) = Random.Next(256)
        Next
        diff = RGBList.Sum() - max
        If diff > 0 Then
            Dim RGBLess(2) As Integer
            Dim temp As Integer
            RGBLess(0) = Random.Next(diff + 1)
            RGBLess(1) = Random.Next(diff - RGBLess(0) + 1)
            RGBLess(2) = diff - RGBLess(0) - RGBLess(1)
            For i = 0 To 2
                If Random.Next(2) = 1 Then
                    If i = 2 Then
                        temp = RGBLess(0)
                        RGBLess(0) = RGBLess(2)
                        RGBLess(2) = temp
                    Else
                        temp = RGBLess(i + 1)
                        RGBLess(i + 1) = RGBLess(i)
                        RGBLess(i) = temp
                    End If
                End If
            Next
            For i = 0 To 2
                RGBList(i) -= RGBLess(i)
            Next
        End If
        Return Color.FromArgb(RGBList(0), RGBList(1), RGBList(2))
    End Function

End Class
