''' <summary>
''' Built-in not
''' </summary>
''' <remarks></remarks>
Public Class NotCmd
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "NOT"
        Func = NotFunc()
        'Parent = Nothing
    End Sub

    Private Function NotFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     If list.Count <> 3 Or list(2).GetType() <> GetType(Boolean) Then
                         MessageBox.Show("Not negates only one Boolean (True/False) input.", "Argument Number Error")
                         Return Nothing
                     End If
                     Return New List(Of Object) From {Not list(2)}
                 End Function
        Return myFunc
    End Function
End Class
