''' <summary>
''' Built-in contains
''' </summary>
''' <remarks></remarks>
Public Class Contains
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "CONTAINS"
        Func = ContFunc()
        'Parent = Nothing
    End Sub

    Private Function ContFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     If list.Count <> 4 Then
                         MessageBox.Show("Contains function only takes two inputs.", "Argument Number Error")
                         Return Nothing
                     End If
                     Dim value As Boolean = True
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not x.GetType() <> GetType(String) Then
                             MessageBox.Show("Contains function operands must be text (String).", "Type Error")
                             Return Nothing
                         End If
                     Next
                     Return New List(Of Object) From {CStr(list(2)).Contains(CStr(list(3)))}
                 End Function
        Return myFunc
    End Function
End Class
