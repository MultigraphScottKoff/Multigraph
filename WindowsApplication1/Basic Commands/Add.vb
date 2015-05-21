''' <summary>
''' Built-in addition
''' </summary>
''' <remarks></remarks>
Public Class Add
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "ADD"
        Func = AddFunc()
        'Parent = Nothing
    End Sub

    Private Function AddFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim sum As Double = 0
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not IsNumeric(x) Then
                             MessageBox.Show("Improper operands for addition.", "Type Error")
                             Return Nothing
                         End If
                         sum += x
                     Next
                     Return New List(Of Object) From {sum}
                 End Function
        Return myFunc
    End Function
End Class
