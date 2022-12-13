Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Public Class ViewStatistics
    Private Sub ViewStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        Chart1.Series.Clear()
        Chart1.Series.Add("Series 1")
        Chart1.Series("Series 1").ChartType = SeriesChartType.Pie
        Chart1.Series("Series 1").Points.AddXY("Completed Tasks", Stats.compTasks)
        Chart1.Series("Series 1").Points.AddXY("Incomplete Tasks", (Stats.totalTasks - Stats.compTasks))
        Chart1.Series("Series 1")("PieLabelStyle") = "Outside"
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub
End Class

Class Stats
    Public Shared totalTasks As Integer = Nothing
    Public Shared compTasks As Integer = Nothing
End Class