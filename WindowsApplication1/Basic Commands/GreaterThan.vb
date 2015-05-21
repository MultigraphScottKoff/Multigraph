''' <summary>
''' Built-in addition
''' </summary>
''' <remarks></remarks>
Public Class GreaterThan
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "GREATER"
        Func = GreatFunc()
        'Parent = Nothing
    End Sub

    Private Function GreatFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     If list.Count <> 4 Then
                         MessageBox.Show("Comparison functions take only two inputs.", "Argument Number Error")
                         Return Nothing
                     End If
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not IsNumeric(x) Then
                             MessageBox.Show("Improper operands for comparison.", "Type Error")
                             Return Nothing
                         End If
                     Next
                     Return New List(Of Object) From {list(2) > list(3)}
                 End Function
        Return myFunc
    End Function
End Class
