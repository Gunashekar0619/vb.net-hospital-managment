Imports MySql.Data.MySqlClient
Public Class dectorform
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        loginform.Show()
    End Sub
    Private Sub recipt_Click(sender As Object, e As EventArgs) Handles recipt.Click
        reciptpanel.Visible = True
        profilepanel.Visible = False
    End Sub
    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        reciptpanel.Visible = False
        profilepanel.Visible = True
    End Sub
    Private Sub dectorform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.outpatient"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("pid")
                comboinpat.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        profilepanel.Visible = False
        reciptpanel.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.outpatient set solution  ='" & TextBox4.Text & "'where pid = '" & comboinpat.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class