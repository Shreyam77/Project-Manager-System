Imports System.Data.SqlClient
Public Class Home

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        'Inserting project details in DataGridView control
        Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql1 As String = "select * from CreateProject where SName='" & Class1.savedSName & "'"
        Dim da1 As New SqlDataAdapter(sql1, con1)
        Dim d1 As New DataSet
        con1.Open()
        da1.Fill(d1, "CreateProject")
        con1.Close()
        DataGridView1.DataSource = d1
        DataGridView1.DataMember = "CreateProject"

        LblUsername.Text += Class1.savedSName

        'Saving SID
        Dim constring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30"
        Dim con As SqlConnection = New SqlConnection(constring)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd1 As SqlCommand = New SqlCommand("Select SID from RegisterStudent where SName='" & Class1.savedSName & "'", con)


        Try
            con.Open()
            da.SelectCommand = cmd1
            da.Fill(ds)
            con.Close()

            Class1.savedSID = CInt(ds.Tables(0).Rows(0).Item(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Saving PID 
        Dim con2 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd2 As New SqlCommand("Select PID from CreateProject ", con2)
        Dim ds2 As New DataSet
        Dim da2 As New SqlDataAdapter

        Try

            con2.Open()
            da2.SelectCommand = cmd2
            da2.Fill(ds2)
            con2.Close()
            class2.savedPID = "1001"

            For i = 0 To ds2.Tables(0).Rows.Count - 1
                class2.savedPID = CInt((ds2.Tables(0).Rows(i).Item(0))) + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnNewProject.Click
        CreateNewProject.Show()
    End Sub

    Private Sub BtnNewTask_Click(sender As Object, e As EventArgs) Handles BtnNewTask.Click
        CreateNewTask.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Refresh()

    End Sub

    Private Sub BtnViewTask_Click(sender As Object, e As EventArgs) Handles BtnViewTask.Click
        ViewTasks.Show()
    End Sub

    Private Sub BtnViewStats_Click(sender As Object, e As EventArgs)
        ViewStatistics.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub


End Class

Public Class class2
    Public Shared savedPID As Integer = Nothing
    Public Shared savedPName As String = Nothing
End Class
