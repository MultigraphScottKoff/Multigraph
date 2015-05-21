<Serializable> Public Class MGSave

    Private _setList As List(Of XLSet)
    Private _varDict As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))
    Private _numSets As Integer
    Private _nameList As List(Of String)
    ''' <summary>
    ''' saves multigraph state
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _setList = Multigraph.SetList
        _varDict = Multigraph.VarDict
        _numSets = Multigraph.NumSets
        _nameList = Multigraph.NameList
        Save()
    End Sub
    ''' <summary>
    ''' The list of all XLSets
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
    ''' A dictionary mapping all variables to XLSets and their column positions
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property VarDict() As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))
        Get
            Return _varDict
        End Get
        Set(value As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long))))
            _varDict = value
        End Set
    End Property
    ''' <summary>
    ''' The number of total sets in SetList; saves time referencing list.count
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NumSets() As Integer
        Get
            Return _numSets
        End Get
        Set(value As Integer)
            _numSets = value
        End Set
    End Property
    ''' <summary>
    ''' A list of XLSet names
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NameList() As List(Of String)
        Get
            Return _nameList
        End Get
        Set(value As List(Of String))
            _nameList = value
        End Set
    End Property
    ''' <summary>
    ''' save MG state
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Save()
        Try
            Dim format As Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim stream As IO.Stream
            format = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            stream = New IO.FileStream("C:\Users\sean.EPISINC\Documents\Github\MultigraphVB\MG.mg", IO.FileMode.Create, IO.FileAccess.Write)
            format.Serialize(stream, Me)
            stream.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
