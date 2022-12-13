Imports System.Data.SqlClient
Public Class TViewProjects
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnViewStats.Click
        ViewStatistics.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnViewTasks.Click
        TViewTasks.Show()
    End Sub

    Private Sub TViewProjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)


        'Add Projects in the ComboBox
        Dim str As String
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select SName from RegisterStudent", con)
        Dim ds As New DataSet
        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                str = CStr((ds.Tables(0).Rows(i).Item(0)))
                CBoxSelectStudent.Items.Add(str)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Adding Options in ComboBox

        CBoxSynopsis.Items.Add("Submitted")
        CBoxSynopsis.Items.Add("Not Submitted")
        CBoxSynopsis.Items.Add("Verified")
        CBoxSynopsis.Items.Add("Redo")

        CBoxDFD.Items.Add("Submitted")
        CBoxDFD.Items.Add("Not Submitted")
        CBoxDFD.Items.Add("Verified")
        CBoxDFD.Items.Add("Redo")

        CBoxER.Items.Add("Submitted")
        CBoxER.Items.Add("Not Submitted")
        CBoxER.Items.Add("Verified")
        CBoxER.Items.Add("Redo")

        CBoxGanttChart.Items.Add("Submitted")
        CBoxGanttChart.Items.Add("Not Submitted")
        CBoxGanttChart.Items.Add("Verified")
        CBoxGanttChart.Items.Add("Redo")
    End Sub

    Private Sub CBoxSelectStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxSelectStudent.SelectedIndexChanged


        'on changing the selected student/ adding values in the data grid view
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select * from CreateProject where SName='" & CBoxSelectStudent.SelectedItem & "'", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        con.Open()
        da.Fill(ds, "CreateProject")
        con.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CreateProject"

        'Adding project names in Combobox
        Dim cmd1 As New SqlCommand("Select [Project Name] from CreateProject where SName='" & CBoxSelectStudent.SelectedItem & "'", con)
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        Dim str As String

        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()
            CBoxSelectProject.Items.Clear()
            CBoxSelectProject.Text = Nothing

            For i = 0 To ds1.Tables(0).Rows.Count - 1
                str = CStr((ds1.Tables(0).Rows(i).Item(0)))
                CBoxSelectProject.Items.Add(str)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        PnlEdit.Visible = True

        'Add Present Values in the ComboBox
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select [Project Name],Synopsis, DFD, ER, [Gantt Chart] from CreateProject where PID = '" & Class3.savedPID & "'", con)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            TextBox1.Text = CStr((ds.Tables(0).Rows(0).Item(0)))
            CBoxSynopsis.Text = CStr((ds.Tables(0).Rows(0).Item(1)))
            CBoxDFD.Text = CStr((ds.Tables(0).Rows(0).Item(2)))
            CBoxER.Text = CStr((ds.Tables(0).Rows(0).Item(3)))
            CBoxGanttChart.Text = CStr((ds.Tables(0).Rows(0).Item(4)))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        PnlEdit.Visible = False
    End Sub

    Private Sub BtnMakeChanges_Click(sender As Object, e As EventArgs) Handles BtnMakeChanges.Click

        'Editing Students status
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Update CreateProject set [Project Name]='" & TextBox1.Text & "', Synopsis='" & CBoxSynopsis.Text & "', DFD='" & CBoxDFD.Text & "',ER='" & CBoxER.Text & "', [Gantt Chart]='" & CBoxGanttChart.Text & "' where PID='" & Class3.savedPID & "'  ", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()
            MessageBox.Show("Updated Successfully")
            PnlEdit.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DataGridView1.Refresh()
    End Sub

    Private Sub CBoxSelectProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxSelectProject.SelectedIndexChanged
        BtnEdit.Enabled = True
        BtnViewTasks.Enabled = True
        BtnViewStats.Enabled = True

        'Saving PID
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select PID from CreateProject where [Project Name]='" & CBoxSelectProject.SelectedItem & "' ", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            Class3.savedPID = CInt((ds.Tables(0).Rows(0).Item(0)))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Calculating total no of tasks
        Dim cmd1 As New SqlCommand("Select count(*) from CreateTask where [Project Name]='" & CBoxSelectProject.SelectedItem & "' ", con)
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet

        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()
            Stats.totalTasks = CInt((ds1.Tables(0).Rows(0).Item(0)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Calculating no of Completed tasks
        Dim cmd2 As New SqlCommand("Select count(*) from CreateTask where [Project Name]='" & CBoxSelectProject.SelectedItem & "' AND Status='Completed' ", con)
        Dim da2 As New SqlDataAdapter
        Dim ds2 As New DataSet

        Try
            con.Open()
            da2.SelectCommand = cmd2
            da2.Fill(ds2)
            con.Close()
            Stats.compTasks = CInt((ds2.Tables(0).Rows(0).Item(0)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class