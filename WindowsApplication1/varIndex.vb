''' <summary>
''' placeholder for undefined variables in UserCommands
''' </summary>
''' <remarks></remarks>
<Serializable> Public Class varIndex
    Private _index As Integer
    Private _name As String
    ''' <summary>
    ''' create undef varIndex
    ''' </summary>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub New(index As Integer)
        _index = index
    End Sub
    ''' <summary>
    ''' creat def varIndex
    ''' </summary>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Public Sub New(name As String)
        _name = name
        _index = -1
    End Sub
    ''' <summary>
    ''' index of var, -1 if defined var
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Index() As Integer
        Get
            Return _index
        End Get
    End Property
    ''' <summary>
    ''' name of var, only relevant if defined var
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

End Class
