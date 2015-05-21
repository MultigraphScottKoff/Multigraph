''' <summary>
''' The XLSet class is the basic building block of the Multigraph software. The XLSet stores data from Excel files and holds property values
''' for the data set.
''' </summary>
''' <remarks></remarks>
<Serializable> Public Class XLSet
    Private _name As String
    Private _ID As Integer
    Private _numVars As Long
    Private _numEntries As Long
    Private _varList As List(Of String)
    Private _myData As DataTable
    ''' <summary>
    ''' create new XLSet
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _name = ""
        _ID = -1
        _numVars = 0
        _numEntries = 0
        _varList = New List(Of String)
        _myData = Nothing
    End Sub
    ''' <summary>
    ''' create a deep clone of another XLSet
    ''' </summary>
    ''' <param name="MySet"></param>
    ''' <remarks></remarks>
    Public Sub New(MySet As XLSet)
        _name = MySet.Name
        _ID = -1
        _numVars = MySet.Vars
        _numEntries = MySet.Entries
        _varList = MySet.VarList
        _myData = New DataTable
        For i = 0 To MySet.Data.Columns.Count - 1
            _myData.Columns.Add(MySet.Data.Columns(i).ColumnName)
            For j = 0 To MySet.Data.Rows.Count - 1
                If i = 0 Then
                    _myData.Rows.Add()
                End If
                _myData.Rows(j).Item(i) = MySet.Data.Rows(j).Item(i)
            Next
        Next
    End Sub
    ''' <summary>
    ''' Name of XLSet
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
    ''' Index of XLSet in DataList, identifier only
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    ''' <summary>
    ''' Number of variables in XLSet
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Vars() As Long
        Get
            Return _numVars
        End Get
        Set(value As Long)
            _numVars = value
        End Set
    End Property
    ''' <summary>
    ''' Number of entries/rows in XLSet
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Entries() As Long
        Get
            Return _numEntries
        End Get
        Set(value As Long)
            _numEntries = value
        End Set
    End Property
    ''' <summary>
    ''' list of variables in the xlset
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property VarList() As List(Of String)
        Get
            Return _varList
        End Get
        Set(value As List(Of String))
            _varList = value
        End Set
    End Property
    ''' <summary>
    ''' Data from CSV file
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Data() As DataTable
        Get
            Return _myData
        End Get
        Set(value As DataTable)
            _myData = value
        End Set
    End Property

End Class
