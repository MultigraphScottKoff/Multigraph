Imports System.IO
Imports System.Text
''' <summary>
''' Library for Saving UserCommands
''' </summary>
''' <remarks></remarks>
<Serializable> Public Class CmdLib
    Private _name As String
    Private _shortName As String
    Private _cmds As List(Of UserCommand)
    ''' <summary>
    ''' create new lib from commands
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="cmds"></param>
    ''' <remarks></remarks>
    Public Sub New(name As String, sName As String, cmds As List(Of UserCommand))
        _name = name
        _shortName = sName
        _cmds = cmds
    End Sub
    ''' <summary>
    ''' name of library
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    ''' <summary>
    ''' short name for reference
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ShortName As String
        Get
            Return _shortName
        End Get
        Set(value As String)
            _shortName = value
        End Set
    End Property
    ''' <summary>
    ''' list of commands
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Commands As List(Of UserCommand)
        Get
            Return _cmds
        End Get
        Set(value As List(Of UserCommand))
            _cmds = value
        End Set
    End Property
    ''' <summary>
    ''' save lib to file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        For Each cmd In _cmds
            cmd.Func = Nothing
        Next
        Dim format As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim stream As IO.Stream
        format = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        stream = New IO.FileStream(_name, IO.FileMode.Create, IO.FileAccess.Write)
        format.Serialize(stream, Me)
        stream.Close()
    End Sub
End Class
