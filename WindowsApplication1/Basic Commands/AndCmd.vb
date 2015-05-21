''' <summary>
''' Built-in and
''' </summary>
''' <remarks></remarks>
Public Class AndCmd
    Inherits Command


    Sub New()
        MyBase.New()
        Name = "AND"
        Func = AndFunc()
        'Parent = Nothing
    End Sub

    Private Function AndFunc() As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim value As Boolean = True
                     For Each x In list.GetRange(2, list.Count - 2)
                         If Not x.GetType() <> GetType(Boolean) Then
                             MessageBox.Show("And function can only take Boolean values (True/False).", "Type Error")
                             Return Nothing
                         End If
                         value = value And x
                     Next
                     Return New List(Of Object) From {value}
                 End Function
        Return myFunc
    End Function
End Class
