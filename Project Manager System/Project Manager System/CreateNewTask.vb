Imports System.Data.SqlClient
Public Class CreateNewTask
    Private Sub CreateNewTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        CBoxType.Items.Add("Bug")
        CBoxType.Items.Add("Feature")
        CBoxType.Items.Add("Task")

        CBoxPriority.Items.Add("Low")
        CBoxPriority.Items.Add("Medium")
        CBoxPriority.Items.Add("High")

        'Adding Projects to the ComboBox
        Dim i As Integer
        Dim Str As String
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As SqlCommand = New SqlCommand("Select [Project Name] from CreateProject where SID='" & Class1.savedSID & "'", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Str = CStr((ds.Tables(0).Rows(i).Item(0)))
                CBoxChooseProject.Items.Add(Str)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCreateNewTask.Click

        'Adding tasks in the table
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As SqlCommand = New SqlCommand("INSERT into CreateTask VALUES('" & LbltID.Text & "','" & class2.savedPID - 1 & "','" & CBoxChooseProject.SelectedItem & "','" & CBoxType.SelectedItem & "','" & TBTitle.Text & "','" & RTBDescription.Text & "','" & CBoxPriority.SelectedItem & "','Opened','" & DateTime.Now.ToString & "')", con)
        con.Open()

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Succesfully Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        CBoxChooseProject.SelectedItem = Nothing
        CBoxType.SelectedItem = Nothing
        TBTitle.Text = Nothing
        RTBDescription.Text = Nothing
        CBoxPriority.SelectedItem = Nothing

        Me.Close()
    End Sub

    Private Sub CBoxChooseProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxChooseProject.SelectedIndexChanged
        'Generating tID
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd1 As New SqlCommand("Select tID from [CreateTask] where [Project Name]='" & CBoxChooseProject.SelectedItem & "' ", con)
        Dim ds1 As New DataSet
        Dim da1 As New SqlDataAdapter

        Try

            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()

            For i = 0 To ds1.Tables(0).Rows.Count - 1
                LbltID.Text = CInt((ds1.Tables(0).Rows(i).Item(0))) + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LbltID.Visible = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class