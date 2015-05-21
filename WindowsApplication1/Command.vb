''' <summary>
''' Parent class for all commands implemented in Filter window
''' </summary>
''' <remarks></remarks>
<Serializable> Public MustInherit Class Command

    Public Property Name As String
    Public Property Func As Func(Of List(Of Object), Object)
    'Public Property Parent As CmdLib

    Public Sub New()
    End Sub

    ''' <summary>
    ''' save lib to file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        Me.Func = Nothing
        Dim format As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim stream As IO.Stream
        format = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        stream = New IO.FileStream(_name, IO.FileMode.Create, IO.FileAccess.Write)
        format.Serialize(stream, Me)
        stream.Close()
    End Sub

End Class
