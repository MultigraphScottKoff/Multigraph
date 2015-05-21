''' <summary>
''' Built-in subtraction
''' </summary>
''' <remarks></remarks>
Public Class Subtract
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "SUB"
        Func = SubFunc()
        'Parent = Nothing
    End Sub

    Private Function SubFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim sum As Double = list(2)
                     For Each x In list.GetRange(3, list.Count - 3)
                         If Not IsNumeric(x) Then
                             MessageBox.Show("Improper operands for subtraction.", "Type Error")
                             Return Nothing
                         End If
                         sum -= x
                     Next
                     Return New List(Of Object) From {sum}
                 End Function
        Return myFunc
    End Function
End Class
