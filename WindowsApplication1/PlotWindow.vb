''' <summary>
''' window displaying all plots
''' </summary>
''' <remarks></remarks>
Public Class PlotWindow

    Private _numPlots As Integer
    Private _pSetup As PlotSetup
    Private _baseSize As Size

    Public Sub New(PSetup As PlotSetup)

        InitializeComponent()
        _baseSize = PlotLayoutPanel.Size
        _pSetup = PSetup
        InitPlotLayout()
        AddCharts()

    End Sub
    ''' <summary>
    ''' add rows and columns to the plot layout based on number of plots
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitPlotLayout()
        _numPlots = _pSetup.PlotList.Count - 1
        'square root of numPlots as an int
        Dim rootInt As Integer = Int(Math.Sqrt(_numPlots))
        'closest square less than or equal to numPlots
        Dim closeSqr As Integer = rootInt ^ 2
        Dim numRows As Integer
        Dim numCols As Integer
        'set number of rows and columns based on number of plots
        If _numPlots = closeSqr Then
            numRows = rootInt
            numCols = rootInt
        ElseIf _numPlots <= closeSqr + rootInt Then
            numRows = rootInt
            numCols = rootInt + 1
        Else
            numRows = rootInt + 1
            numCols = rootInt + 1
        End If

        'set row and column numbers
        PlotLayoutPanel.RowCount = numRows
        PlotLayoutPanel.ColumnCount = numCols

        'add rows
        For i = 1 To numRows - 1
            PlotLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent))
        Next
        'add columns
        For i = 1 To numCols - 1
            PlotLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent))
        Next
        'set row sizes
        For i = 0 To numRows - 1
            PlotLayoutPanel.RowStyles(i).Height = 100.0F / numRows
        Next
        'set column sizes
        For i = 0 To numCols - 1
            PlotLayoutPanel.ColumnStyles(i).Width = 100.0F / numCols
        Next

        'resize panel
        PlotLayoutPanel.Height = numRows * (_baseSize.Height)
        PlotLayoutPanel.Width = numCols * (_baseSize.Width)

    End Sub
    ''' <summary>
    ''' Add charts to formatted plot layout
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddCharts()

        Dim myConfig As PlotConfig
        Dim myX As String
        Dim myY As String
        Dim numAdded As Integer = 0
        Dim chart As C1.Win.C1Chart.C1Chart
        Dim series As C1.Win.C1Chart.ChartDataSeries = Nothing
        Dim myTable As DataTable
        Dim font As System.Drawing.Font
        Dim setList As List(Of XLSet)

        'for each pane, add a plot if numPlots not exceeded
        For i = 0 To PlotLayoutPanel.RowCount - 1
            For j = 0 To PlotLayoutPanel.ColumnCount - 1
                'skip base plot
                numAdded += 1
                If numAdded > _numPlots Then
                    Exit For
                End If
                'add a plot
                myConfig = _pSetup.PlotList(numAdded)
                myX = myConfig.X
                myY = myConfig.Y
                chart = New C1.Win.C1Chart.C1Chart
                'formatting
                chart.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot
                chart.Height = _baseSize.Height
                chart.Width = _baseSize.Width
                chart.Margin = New Padding(1)
                chart.BackColor = Color.LightGray
                'set axes and title
                chart.Header.Text = myConfig.Name
                font = New System.Drawing.Font(myConfig.Name, 14, FontStyle.Bold)
                chart.Header.Style.Font = font
                chart.ChartArea.AxisX.Text = myX
                chart.ChartArea.AxisY.Text = myY
                'populate series by table
                chart.ChartGroups.Group0.ChartData.SeriesList.Clear()
                If myConfig.AllSets Then
                    setList = Multigraph.SetList
                Else
                    setList = myConfig.SetList
                End If
                'set up plots based on X and Y. Y cannot be a string; if X is, create bar 
                If Not IsNumeric(setList(0).Data.Rows(0).Item(myY)) Or Not IsNumeric(setList(0).Data.Rows(0).Item(myX)) Then
                    MessageBox.Show("Variable cannot be a String. Please choose a numeric variable.", "Invalid Variable Type")
                    'ElseIf Not IsNumeric(myConfig.SetList(0).Data.Rows(0).Item(myX)) Then
                    '    chart.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar
                    '    If myConfig.OneSeries Then
                    '        series = chart.ChartGroups.Group0.ChartData.SeriesList.AddNewSeries()
                    '        series.SymbolStyle.Color = Color.Black
                    '    End If
                    '    For k = 0 To myConfig.SetList.Count - 1
                    '        If Not myConfig.OneSeries Then
                    '            series = chart.ChartGroups.Group0.ChartData.SeriesList.AddNewSeries()
                    '            series.SymbolStyle.Color = myConfig.Colors(k)
                    '        End If
                    '        myTable = myConfig.SetList(k).Data
                    '        For l = 0 To myTable.Rows.Count - 1
                    '            series.X.Add(CStr(myTable.Rows(l).Item(myX)))
                    '            series.Y.Add(CDbl(myTable.Rows(l).Item(myY)))
                    '        Next
                    '    Next
                    '    chart.ChartArea.AxisY.VerticalText = False
                    '    chart.Visible = True
                    '    PlotLayoutPanel.Controls.Add(chart, j, i)
                Else
                    If myConfig.OneSeries Then
                        series = chart.ChartGroups.Group0.ChartData.SeriesList.AddNewSeries()
                        series.Label = "Combined Data"
                        series.TooltipText = "Combined Data"
                        series.TooltipTextLegend = "Combined Data"
                        series.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
                        series.SymbolStyle.Color = Color.Black
                        series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Circle
                        series.SymbolStyle.Size = 5
                    End If
                    For k = 0 To setList.Count - 1
                        If Not myConfig.OneSeries Then
                            series = chart.ChartGroups.Group0.ChartData.SeriesList.AddNewSeries()
                            series.Label = setList(k).Name
                            series.TooltipText = setList(k).Name
                            series.TooltipTextLegend = setList(k).Name
                            series.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
                            If Not myConfig.AllSets Then
                                series.SymbolStyle.Color = myConfig.Colors(k)
                            End If
                            series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Circle
                            series.SymbolStyle.Size = (2 * (setList.Count - k) + 3)
                        End If
                        myTable = setList(k).Data
                        For l = 0 To myTable.Rows.Count - 1
                            series.X.Add(CDbl(myTable.Rows(l).Item(myX)))
                            series.Y.Add(CDbl(myTable.Rows(l).Item(myY)))
                        Next
                    Next
                    chart.Legend.Compass = C1.Win.C1Chart.CompassEnum.South
                    chart.Legend.Visible = True
                    chart.ChartArea.AxisY.VerticalText = False
                    chart.Visible = True
                    PlotLayoutPanel.Controls.Add(chart, j, i)
                End If
            Next
        Next
    End Sub
End Class