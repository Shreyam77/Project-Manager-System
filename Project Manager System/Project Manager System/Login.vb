Imports System.Data.SqlClient
Public Class Login
    Dim a As New Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PBTeacher.Click
        'Changing the size of picture
        BtnLogin.Enabled = True
        BtnRegister.Enabled = True
        PBTeacher.Size = New Size(200, 200)
        PBTeacher.Location = New Point(75, 75)
        PBStudent.Size = New Size(100, 100)
        PBStudent.Location = New Point(325, 125)
        a = 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PBStudent.Click
        'Changing the size of picture
        BtnLogin.Enabled = True
        BtnRegister.Enabled = True
        PBStudent.Size = New Size(200, 200)
        PBStudent.Location = New Point(225, 75)
        PBTeacher.Size = New Size(100, 100)
        PBTeacher.Location = New Point(75, 125)
        a = 2
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        GBoxLogin.Visible = True
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If a = 1 Then
            RegisterTeacher.Show()
        ElseIf a = 2 Then
            RegisterStudent.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin1.Click
        'Checking Login credentials & saving SName and TName
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand
        If a = 1 Then
            cmd = New SqlCommand("SELECT * FROM RegisterTeacher WHERE TName = '" & TextBox1.Text & "' AND TPassword = '" & TextBox2.Text & "' ", con)
            Class1.savedTName = TextBox1.Text
        ElseIf a = 2 Then
            cmd = New SqlCommand("SELECT * FROM RegisterStudent WHERE SName = '" & TextBox1.Text & "' AND SPassword = '" & TextBox2.Text & "' ", con)
            Class1.savedSName = TextBox1.Text
        End If

        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If a = 1 Then
                MessageBox.Show("You are authenticated")
                THome.Show()
                Me.Hide()
            ElseIf a = 2 Then
                MessageBox.Show("You are authenticated")
                Home.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Invalid Credentials")
        End If
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing




    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBStudent.SizeMode = PictureBoxSizeMode.StretchImage
        PBTeacher.SizeMode = PictureBoxSizeMode.StretchImage

        'Changing form working area
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GBoxLogin.Visible = False
    End Sub
End Class
Public Class Class1
    Public Shared savedSID As Integer = Nothing
    Public Shared savedSName As String = Nothing

    Public Shared savedTID As String = Nothing
    Public Shared savedTName As String = Nothing

End Class