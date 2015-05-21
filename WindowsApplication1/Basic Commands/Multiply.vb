''' <summary>
''' Built-in multiply
''' </summary>
''' <remarks></remarks>
Public Class Multiply
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "MULT"
        Func = AddFunc()
        'Parent = Nothing
    End Sub

    Private Function AddFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim prod As Double = 1
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not IsNumeric(x) Then
                             MessageBox.Show("Improper operands for multiplication.", "Type Error")
                             Return Nothing
                         End If
                         prod *= x
                     Next
                     Return New List(Of Object) From {prod}
                 End Function
        Return myFunc
    End Function
End Class
