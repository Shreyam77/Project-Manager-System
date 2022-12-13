Imports System.Data.SqlClient
Public Class TViewTasks
    Private Sub TViewTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        'Adding tasks of related project to combobox
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select Title from CreateTask where PID= '" & Class3.savedPID & "'", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim Str As String

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Str = CStr((ds.Tables(0).Rows(i).Item(0)))
                CBoxSelectTask.Items.Add(Str)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Checking wheather all tasks are completed or not 
        Dim cmd1 As New SqlCommand("Select Status from CreateTask where PID='" & Class3.savedPID & "'  ", con)
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        Dim str1 As String
        Dim check As Integer = 1

        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()

            For i = 0 To ds1.Tables(0).Rows.Count - 1
                str1 = CStr((ds1.Tables(0).Rows(i).Item(0)))
                If String.Equals(str1, "Opened") Then
                    check = 0
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If check = 1 Then
            Button1.Enabled = True
        End If

    End Sub

    Private Sub CBoxSelectTask_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxSelectTask.SelectedIndexChanged

        'For Description
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        Dim cmd1 As New SqlCommand("Select Description,Status,Priority,Type from CreateTask where [Title]='" & CBoxSelectTask.SelectedItem & "' AND PID='" & Class3.savedPID & "'   ", con)

        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()
            LblDescription.Text = CStr(ds1.Tables(0).Rows(0).Item(0))
            LblStatus.Text = CStr(ds1.Tables(0).Rows(0).Item(1))
            LblPriority.Text = CStr(ds1.Tables(0).Rows(0).Item(2))
            LblType.Text = CStr(ds1.Tables(0).Rows(0).Item(3))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnMarkasCompleted.Enabled = True


    End Sub

    Private Sub BtnMarkasCompleted_Click(sender As Object, e As EventArgs) Handles BtnMarkasCompleted.Click
        'Mark as Completed
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Update CreateTask set Status='Completed' where PID='" & Class3.savedPID & "' AND Title='" & CBoxSelectTask.SelectedItem & "' ", con)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TViewProjects.Close()
        TViewProjects.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Update CreateProject set Status='Completed' where PID = '" & Class3.savedPID & "' ", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TViewProjects.Close()
        TViewProjects.Show()
    End Sub
End Class