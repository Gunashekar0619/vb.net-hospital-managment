Imports MySql.Data.MySqlClient
Public Class reseptionistform
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim igender As String
    Dim ogender As String
    Private Sub inpatients_Click(sender As Object, e As EventArgs) Handles inpatients.Click
        inpatientspanel.Visible = True
        outpatientspanel.Visible = False
        inpatients.Enabled = False
        outpatients.Enabled = True
    End Sub
    Private Sub outpatients_Click(sender As Object, e As EventArgs) Handles outpatients.Click
        inpatientspanel.Visible = False
        outpatientspanel.Visible = True
        outpatients.Enabled = False
        inpatients.Enabled = True
    End Sub
    Private Sub registerpatients_Click(sender As Object, e As EventArgs) Handles registerpatients.Click
        registerpatientspanel.Visible = True
        doctorpanel.Visible = False
        stockspanel.Visible = False
        registerpatients.Enabled = False
        doctors.Enabled = True
        stocks.Enabled = True
        inpatients.Enabled = False
    End Sub
    Private Sub doctors_Click(sender As Object, e As EventArgs) Handles doctors.Click
        registerpatientspanel.Visible = False
        doctorpanel.Visible = True
        stockspanel.Visible = False
        registerpatients.Enabled = True
        doctors.Enabled = False
        stocks.Enabled = True
    End Sub
    Private Sub stocks_Click(sender As Object, e As EventArgs) Handles stocks.Click
        registerpatientspanel.Visible = False
        doctorpanel.Visible = False
        stockspanel.Visible = True
        registerpatients.Enabled = True
        doctors.Enabled = True
        stocks.Enabled = False
    End Sub
    Private Sub inpatientspanel_Paint(sender As Object, e As PaintEventArgs) Handles inpatientspanel.Paint
        listip()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loginform.Show()
    End Sub
    Private Sub doctable()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim sda As New MySqlDataAdapter
        Dim bddataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select doctorid , doctorname ,specialization , phoneno from hospitalmanagment.doctor"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(bddataset)
            bsource.DataSource = bddataset
            DataGridView2.DataSource = bsource
            sda.Update(bddataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub doctorpanel_Paint(sender As Object, e As PaintEventArgs) Handles doctorpanel.Paint
        doctable()
    End Sub
    Private Sub saveop_Click(sender As Object, e As EventArgs) Handles saveop.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            Dim result As String
            query = "select MAX(pid) from outpatient"
            cmd = New MySqlCommand(query, conn)
            result = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(result) Then
                result = 8001
                query = "insert into hospitalmanagment.outpatient (pid ,name,dob,disease,phoneno ,gender ) values ('" & result & "', '" & opname.Text & "', '" & opdob.Text & "','" & opdisease.Text & "','" & opphno.Text & "','" & ogender & "')"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader
            Else
                result = result + 1
                query1 = "insert into hospitalmanagment.outpatient (pid,name,dob,disease,phoneno,gender ) values ('" & result & "','" & opname.Text & "', '" & opdob.Text & "','" & opdisease.Text & "','" & opphno.Text & "','" & ogender & "')"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            End If
            MessageBox.Show("name='" & opname.Text & "'" & vbCrLf & "pid='" & result & "'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub listop()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim sda As New MySqlDataAdapter
        Dim bddataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select pid , name, gender, dob,disease,phoneno from hospitalmanagment.outpatient"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(bddataset)
            bsource.DataSource = bddataset
            DataGridView3.DataSource = bsource
            sda.Update(bddataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub outpatientspanel_Paint(sender As Object, e As PaintEventArgs) Handles outpatientspanel.Paint
        listop()
    End Sub
    Private Sub modop_Click(sender As Object, e As EventArgs) Handles modop.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.outpatient set gender = '" & ogender & "', name='" & opname.Text & "',disease ='" & opdisease.Text & "',dob ='" & opdob.Text & "',phoneno='" & opphno.Text & "' where pid = '" & comboop.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub deleteop_Click(sender As Object, e As EventArgs) Handles deleteop.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " delete from hospitalmanagment.outpatient where pid='" & comboop.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub addinpatient_Click(sender As Object, e As EventArgs) Handles addinpatient.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            Dim result As String
            query = "select MAX(pid) from inpatient"
            cmd = New MySqlCommand(query, conn)
            result = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(result) Then
                result = 8001
                query = "insert into hospitalmanagment.inpatient (pid ,name,dob,disease,phoneno ,gender) values ('" & result & "', '" & ipname.Text & "', '" & ipdob.Text & "','" & indisease.Text & "','" & inphno.Text & "','" & igender & "')"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader
            Else
                result = result + 1
                query1 = "insert into hospitalmanagment.inpatient (pid,name,dob,disease,phoneno ,gender) values ('" & result & "', '" & ipname.Text & "', '" & ipdob.Text & "','" & indisease.Text & "','" & inphno.Text & "','" & igender & "')"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            End If
            MessageBox.Show("name='" & opname.Text & "'" & vbCrLf & "pid='" & result & "'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub listip()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim sda As New MySqlDataAdapter
        Dim bddataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select pid , name, dob,disease,phoneno from hospitalmanagment.inpatient"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(bddataset)
            bsource.DataSource = bddataset
            outpatientdata.DataSource = bsource
            sda.Update(bddataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub modifyinpatient_Click(sender As Object, e As EventArgs) Handles modifyinpatient.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.inpatient set gender = '" & igender & "' ,name='" & ipname.Text & "',disease ='" & indisease.Text & "',dob ='" & ipdob.Text & "',phoneno='" & inphno.Text & "',address ='" & inaddress.Text & "' where pid = '" & comboinpt.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub delinpatient_Click(sender As Object, e As EventArgs) Handles delinpatient.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " delete from hospitalmanagment.inpatient where pid='" & comboinpt.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        comboinpt.Visible = True
        modifyinpatient.Visible = True
        delinpatient.Visible = True
        dischargeip.Visible = True
        searchshowi.Visible = True
        Button4.Visible = False
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.inpatient"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim pid = reader.GetString("pid")
                comboinpt.Items.Add(pid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        searchshow.Visible = True
        Button3.Visible = False
        modop.Visible = True
        deleteop.Visible = True
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
                Dim pid = reader.GetString("pid")
                comboinpt.Items.Add(pid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub searchshow_Click(sender As Object, e As EventArgs) Handles searchshow.Click
        modop.Enabled = True
        deleteop.Enabled = True
    End Sub
    Private Sub searchshowi_Click(sender As Object, e As EventArgs) Handles searchshowi.Click
        modifyinpatient.Enabled = True
        delinpatient.Enabled = True
        dischargeip.Enabled = True
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ogender = "Male"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ogender = "Female"
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        igender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        igender = "Female"
    End Sub
End Class