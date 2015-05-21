''' <summary>
''' Built-in Xor
''' </summary>
''' <remarks></remarks>
Public Class XorCmd
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "XOR"
        Func = XorFunc()
        'Parent = Nothing
    End Sub

    Private Function XorFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim count As Integer = 0
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not x.GetType() <> GetType(Boolean) Then
                             MessageBox.Show("Or function can only take Boolean values (True/False).", "Type Error")
                             Return Nothing
                         ElseIf x Then
                             count += 1
                         End If
                     Next
                     Return New List(Of Object) From {count Mod 2 = 1}
                 End Function
        Return myFunc
    End Function
End Class
