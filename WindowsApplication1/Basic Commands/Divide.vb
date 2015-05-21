''' <summary>
''' Built-in division
''' </summary>
''' <remarks></remarks>
Public Class Divide
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "DIV"
        Func = AddFunc()
        'Parent = Nothing
    End Sub

    Private Function AddFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim quot As Double = list(2)
                     For Each x In list.GetRange(3, list.Count - 3)
                         If Not IsNumeric(x) Then
                             MessageBox.Show("Improper operands for division.", "Type Error")
                             Return Nothing
                         End If
                         quot /= x
                     Next
                     Return New List(Of Object) From {quot}
                 End Function
        Return myFunc
    End Function
End Class
