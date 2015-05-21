''' <summary>
''' Built-in equals
''' </summary>
''' <remarks></remarks>
Public Class Equals
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "EQUALS"
        Func = EqFunc()
        'Parent = Nothing
    End Sub

    Private Function EqFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Try
                         If list.Count < 4 Then
                             MessageBox.Show("Comparison functions take only two inputs.", "Argument Number Error")
                             Return Nothing
                         End If
                         Dim value As Boolean = True
                         For i = 2 To list.Count - 2
                             value = value And (list(2) = list(3))
                         Next
                         Return New List(Of Object) From {value}
                     Catch ex As Exception
                         MessageBox.Show("Data type does not support Equals function.", "Type Error")
                         Return Nothing
                     End Try
                 End Function
        Return myFunc
    End Function
End Class
