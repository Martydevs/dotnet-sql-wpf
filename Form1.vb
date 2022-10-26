﻿Imports System.Data.SqlClient

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
End Class