''' <summary>
''' Identity Function
''' </summary>
''' <remarks></remarks>
Public Class Identity
    Inherits Command

    Sub New()
        MyBase.New()
        Name = "ID"
        Func = IDFunc()
        'Parent = Nothing
    End Sub

    Private Function IDFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     If list.Count <> 3 Then
                         MessageBox.Show("Identity function only takes one argument.")
                         Return Nothing
                     End If
                     Return New List(Of Object) From {list(2)}
                 End Function
        Return myFunc
    End Function
End Class
