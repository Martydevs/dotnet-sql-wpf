Imports System.Data.SqlClient

Public Class Form1

    'Variable que instancia una nueva conexion y que contiene la string connection'
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=tmdevdb;Persist Security Info=True;User ID=sa;Password=TMPassword2003!")

    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click
        conexion.Open()

        'Variable dim que contiene el objeto sqlcommand que llenamos los dos parametros'
        'con el nombre del procediiento y el nombre de la instancia'
        Dim CMD As New SqlCommand("sp_AltaAlumno", conexion)
        CMD.CommandType = CommandType.StoredProcedure
        With CMD
            .Parameters.AddWithValue("@matricula", Me.txtmatricula.Text)
            .Parameters.AddWithValue("@Nombre", Me.txtnombre.Text)
            .Parameters.AddWithValue("@Ap_Paterno", Me.txtpaterno.Text)
            .Parameters.AddWithValue("@Ap_Materno", Me.txtmaterno.Text)
            .Parameters.AddWithValue("@Direccion", Me.txtdireccion.Text)
            .Parameters.AddWithValue("@Fecha_nac", DateTime.Parse(DateTimePicker1.Text))
            'ExecuteNonQuery es un método de la clase sqlcommand que ejecuta una'
            'instruccion sql y devuelva el resultado de la consultas'
            .ExecuteNonQuery()
        End With
        'sp_AltaAlumno'
        MsgBox("Registrado correctamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Alumno")
        conexion.Close()
    End Sub

    Sub MostrarAlumnos()
        Dim DA As New SqlDataAdapter("sp_MostrarAlumnos", conexion)
        Dim DS As New DataSet
        DA.Fill(DS, "alumno")
        DataGridView1.DataSource = DS.Tables("alumno")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call MostrarAlumnos()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Call MostrarAlumnos()
    End Sub

    Private Sub btnbaja_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        conexion.Open()

        If MsgBox("Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Alumno") = MsgBoxResult.Yes Then

            Dim DT As New DataTable
            Dim CMD As New SqlCommand("sp_BajaAlumno", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            With CMD
                .Parameters.AddWithValue("@Matricula", txtmatricula.Text)
            End With

            Dim DA As New SqlDataAdapter(CMD)
            DA.Fill(DT)
            Me.DataGridView1.DataSource = DT

            MsgBox("Registro borrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Alumno")
            Call MostrarAlumnos()
        End If
        conexion.Close()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim Fila As DataGridViewRow = DataGridView1.CurrentRow
        txtmatricula.Text = CStr(Fila.Cells(0).Value)
        txtnombre.Text = (Fila.Cells(1).Value)
        txtpaterno.Text = (Fila.Cells(2).Value)
        txtmaterno.Text = (Fila.Cells(3).Value)
        txtdireccion.Text = (Fila.Cells(4).Value)

        DateTimePicker1.Value = CStr(Fila.Cells(5).Value)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        conexion.Open()

        If MsgBox("¿Desea Modificar el registro=", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Alumno") = MsgBoxResult.Yes Then
            Dim DT As New DataTable
            Dim CMD As New SqlCommand("sp_ModificarAlumno", conexion)
            CMD.CommandType = CommandType.StoredProcedure
            With CMD
                .Parameters.AddWithValue("@Nombre", txtnombre.Text)
                .Parameters.AddWithValue("@Ap_Paterno", txtpaterno.Text)
                .Parameters.AddWithValue("@Ap_Materno", txtmaterno.Text)
                .Parameters.AddWithValue("@Direccion", txtdireccion.Text)
                .Parameters.AddWithValue("@Fecha_nac", DateTime.Parse(DateTimePicker1.Text))
                .Parameters.AddWithValue("@Matricula", txtmatricula.Text)
            End With
            Dim DA As New SqlDataAdapter(CMD)
            DA.Fill(DT)
            Me.DataGridView1.DataSource = DT

            MsgBox("Se modifico el registro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Alumno")
            Call MostrarAlumnos()
        End If
        conexion.Close()
    End Sub

    'Subrutina para buscar alumnos en base a dos radios, por matricula o apellido paterno'
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If rbtnmatricula.Checked Then
            Dim DA As New SqlDataAdapter("sp_BuscarMatricula", conexion)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.SelectCommand.Parameters.AddWithValue("@matricula", txtbuscar.Text)

            Dim DT As New DataTable
            DA.Fill(DT)
            DataGridView1.DataSource = DT

        ElseIf rbtnApPaterno.Checked Then
            Dim DA As New SqlDataAdapter("sp_BuscarApPaterno", conexion)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.SelectCommand.Parameters.AddWithValue("@Ap_Paterno", txtbuscar)

            Dim DT As New DataTable
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        Else
            MsgBox("Seleccione un tipo de busqueda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Alumno")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtmatricula.Text = ""
        txtnombre.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
        txtdireccion.Text = ""
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea salir del formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Alumno") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblfecha_hora.Text = DateTime.Now
    End Sub
End Class
