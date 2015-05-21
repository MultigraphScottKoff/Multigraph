
'Public Class scratchWork
'    Private Sub importData(ByRef xl As Microsoft.Office.Interop.Excel.Application)
'        Dim mywbk As Microsoft.Office.Interop.Excel.Workbook
'        Dim loadwbk As Microsoft.Office.Interop.Excel.Workbook
'        Dim wksht As Microsoft.Office.Interop.Excel.Worksheet
'        Dim lwksht As Microsoft.Office.Interop.Excel.Worksheet
'        Dim targetRange As Microsoft.Office.Interop.Excel.Range
'        Dim data As Object(,)
'        Dim endRow As Long
'        Dim endCol As Long
'        Dim numSets As Integer = 0
'        Dim wasOpen As Boolean
'        Dim safeName As String
'        Dim parseName As Array

'        wasOpen = False
'        xl.Visible = True
'        xl.DisplayAlerts = False


'        If bIsBookOpen("MULTI_GRAPH_V3.0.xlsm", xl) Then
'            mywbk = xl.Workbooks("MULTI_GRAPH_V3.0.xlsm")
'            wasOpen = True
'        Else
'            mywbk = xl.Workbooks.Open("C:\Users\sean\Documents\GitHub\Multigraph\MULTI_GRAPH_V3.0.xlsm")
'        End If

'        wksht = Nothing

'        Try
'            wksht = mywbk.Worksheets("Cross Plot")
'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try

'        If Not IsNothing(wksht) Then
'            wksht.Delete()
'        End If

'        OpenFileDialog1.InitialDirectory = "C:\Users\sean\Documents\GitHub\Multigraph"
'        OpenFileDialog1.ShowDialog()
'        For Each fname In OpenFileDialog1.FileNames
'            loadwbk = xl.Workbooks.Open(fname)
'            If Not IsNothing(loadwbk) Then
'                parseName = Nothing
'                Try
'                    If InStr(UCase(xl.OperatingSystem), "MAC") <> 0 Then
'                        parseName = Split(fname, ":")
'                    Else
'                        parseName = Split(fname, "\")
'                    End If
'                    safeName = parseName(UBound(parseName))
'                Catch ex As Exception
'                    MessageBox.Show("Error determining operating system.", "OS Error")
'                    MessageBox.Show(ex.Message)
'                    Exit Sub
'                End Try
'                numSets += 1
'                wksht = mywbk.Sheets("Data " & numSets)
'                wksht.Cells.Clear()
'                lwksht = loadwbk.ActiveSheet
'                endRow = lwksht.Cells(lwksht.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row
'                endCol = lwksht.Cells(1, lwksht.Columns.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlToLeft).Column
'                data = lwksht.Range(lwksht.Cells(1, 1), lwksht.Cells(endRow, endCol)).Value
'                targetRange = wksht.Range(wksht.Cells(1, 1), wksht.Cells(endRow, endCol))
'                targetRange.Value = data
'                mywbk.Sheets("Control").Cells(72, 1 + numSets) = safeName
'                Dim numBlanks As Long = 0
'                For i = 2 To endRow
'                    If String.IsNullOrWhiteSpace(wksht.Cells(i, 1).Value) Then
'                        numBlanks += 1
'                    End If
'                Next
'                mywbk.Sheets("Control").Cells(74, 1 + numSets) = endRow - 1 - numBlanks
'                loadwbk.Close()
'            End If
'        Next
'        OpenFileDialog1.Dispose()
'        For i = numSets + 1 To 50
'            mywbk.Sheets("Data " & i).Cells.Clear()
'            mywbk.Sheets("Control").Cells(72, 1 + i).Value = ""
'            mywbk.Sheets("Control").Cells(74, 1 + i).Value = ""   'Eliminate old number of data points
'        Next i
'        mywbk.Sheets("Control").Cells(75, 2) = numSets
'        setVarLabels(mywbk)
'        mywbk.Save()
'        If Not wasOpen Then
'            mywbk.Close()
'        End If
'        xl.Visible = False
'        xl.DisplayAlerts = True
'    End Sub
'    Private Sub setVarLabels(ByRef mywbk As Microsoft.Office.Interop.Excel.Workbook)
'        Dim wksht As Microsoft.Office.Interop.Excel.Worksheet
'        Dim endCol As Long
'        Dim target As Long
'        Dim data As Object

'        wksht = mywbk.Sheets("Data 1")
'        endCol = wksht.Cells(1, wksht.Columns.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlToLeft).Column

'        For target = 1 To endCol
'            mywbk.Sheets("Control").Cells(11 + 3 * Int(((target - 1) Mod 100) / 10), 2 + Int((target - 1) Mod 10) + Int((target - 1) / 100) * 12) = ""
'        Next

'        target = 1
'        For i = 1 To endCol
'            data = wksht.Cells(1, i).Value
'            data = TryCast(data, String)
'            If Not String.IsNullOrWhiteSpace(data) Then
'                mywbk.Sheets("Control").Cells(11 + 3 * Int(((target - 1) Mod 100) / 10), 2 + Int((target - 1) Mod 10) + Int((target - 1) / 100) * 12) = data
'                target = target + 1
'            End If
'        Next

'        mywbk.Sheets("Control").Cells(75, 5) = target - 1
'    End Sub
'End Class
