''' <summary>
''' Built-in Or
''' </summary>
''' <remarks></remarks>
Public Class OrCmd
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "OR"
        Func = OrFunc()
        'Parent = Nothing
    End Sub

    Private Function OrFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim value As Boolean = False
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not x.GetType() <> GetType(Boolean) Then
                             MessageBox.Show("Or function can only take Boolean values (True/False).", "Type Error")
                             Return Nothing
                         End If
                         value = value Or x
                     Next
                     Return New List(Of Object) From {value}
                 End Function
        Return myFunc
    End Function
End Class
