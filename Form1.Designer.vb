<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblmatricula = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblpaterno = New System.Windows.Forms.Label()
        Me.lblmaterno = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblfecha_nac = New System.Windows.Forms.Label()
        Me.txtmatricula = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.rbtnmatricula = New System.Windows.Forms.RadioButton()
        Me.rbtnApPaterno = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lblfecha_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TmdevdbDataSet = New dotnet_sql_wpf.tmdevdbDataSet()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnoTableAdapter = New dotnet_sql_wpf.tmdevdbDataSetTableAdapters.alumnoTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TmdevdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmatricula
        '
        Me.lblmatricula.AutoSize = True
        Me.lblmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblmatricula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmatricula.Location = New System.Drawing.Point(100, 37)
        Me.lblmatricula.Name = "lblmatricula"
        Me.lblmatricula.Size = New System.Drawing.Size(82, 20)
        Me.lblmatricula.TabIndex = 0
        Me.lblmatricula.Text = "Matricula"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblnombre.Location = New System.Drawing.Point(100, 77)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(71, 20)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombre"
        '
        'lblpaterno
        '
        Me.lblpaterno.AutoSize = True
        Me.lblpaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblpaterno.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblpaterno.Location = New System.Drawing.Point(108, 190)
        Me.lblpaterno.Name = "lblpaterno"
        Me.lblpaterno.Size = New System.Drawing.Size(140, 20)
        Me.lblpaterno.TabIndex = 2
        Me.lblpaterno.Text = "Apellido paterno"
        '
        'lblmaterno
        '
        Me.lblmaterno.AutoSize = True
        Me.lblmaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblmaterno.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmaterno.Location = New System.Drawing.Point(107, 157)
        Me.lblmaterno.Name = "lblmaterno"
        Me.lblmaterno.Size = New System.Drawing.Size(144, 20)
        Me.lblmaterno.TabIndex = 3
        Me.lblmaterno.Text = "Apellido materno"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbldireccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldireccion.Location = New System.Drawing.Point(100, 120)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(84, 20)
        Me.lbldireccion.TabIndex = 4
        Me.lbldireccion.Text = "Dirección"
        '
        'lblfecha_nac
        '
        Me.lblfecha_nac.AutoSize = True
        Me.lblfecha_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha_nac.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblfecha_nac.Location = New System.Drawing.Point(352, 50)
        Me.lblfecha_nac.Name = "lblfecha_nac"
        Me.lblfecha_nac.Size = New System.Drawing.Size(151, 20)
        Me.lblfecha_nac.TabIndex = 5
        Me.lblfecha_nac.Text = "Fecha nacimiento"
        '
        'txtmatricula
        '
        Me.txtmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtmatricula.Location = New System.Drawing.Point(196, 37)
        Me.txtmatricula.MaxLength = 6
        Me.txtmatricula.Name = "txtmatricula"
        Me.txtmatricula.Size = New System.Drawing.Size(161, 26)
        Me.txtmatricula.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtnombre.Location = New System.Drawing.Point(196, 77)
        Me.txtnombre.MaxLength = 10
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(162, 23)
        Me.txtnombre.TabIndex = 7
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdireccion.Location = New System.Drawing.Point(196, 120)
        Me.txtdireccion.MaxLength = 20
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(161, 23)
        Me.txtdireccion.TabIndex = 8
        '
        'txtpaterno
        '
        Me.txtpaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtpaterno.Location = New System.Drawing.Point(257, 192)
        Me.txtpaterno.MaxLength = 10
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(100, 23)
        Me.txtpaterno.TabIndex = 10
        '
        'txtmaterno
        '
        Me.txtmaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtmaterno.Location = New System.Drawing.Point(257, 154)
        Me.txtmaterno.MaxLength = 10
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(100, 23)
        Me.txtmaterno.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(286, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblbuscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblbuscar.Location = New System.Drawing.Point(4, 53)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(65, 20)
        Me.lblbuscar.TabIndex = 14
        Me.lblbuscar.Text = "Buscar"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(75, 50)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(178, 23)
        Me.txtbuscar.TabIndex = 15
        '
        'rbtnmatricula
        '
        Me.rbtnmatricula.AutoSize = True
        Me.rbtnmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rbtnmatricula.Location = New System.Drawing.Point(8, 96)
        Me.rbtnmatricula.Name = "rbtnmatricula"
        Me.rbtnmatricula.Size = New System.Drawing.Size(91, 24)
        Me.rbtnmatricula.TabIndex = 16
        Me.rbtnmatricula.TabStop = True
        Me.rbtnmatricula.Text = "Matricula"
        Me.rbtnmatricula.UseVisualStyleBackColor = True
        '
        'rbtnApPaterno
        '
        Me.rbtnApPaterno.AutoSize = True
        Me.rbtnApPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rbtnApPaterno.Location = New System.Drawing.Point(111, 96)
        Me.rbtnApPaterno.Name = "rbtnApPaterno"
        Me.rbtnApPaterno.Size = New System.Drawing.Size(142, 24)
        Me.rbtnApPaterno.TabIndex = 17
        Me.rbtnApPaterno.TabStop = True
        Me.rbtnApPaterno.Text = "Apellido paterno"
        Me.rbtnApPaterno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.rbtnApPaterno)
        Me.GroupBox1.Controls.Add(Me.rbtnmatricula)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.lblbuscar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lblfecha_nac)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 136)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnalta
        '
        Me.btnalta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalta.Location = New System.Drawing.Point(9, 19)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(75, 23)
        Me.btnalta.TabIndex = 21
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnmodificar.Location = New System.Drawing.Point(171, 19)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 22
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnbaja
        '
        Me.btnbaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbaja.Location = New System.Drawing.Point(90, 19)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(75, 23)
        Me.btnbaja.TabIndex = 23
        Me.btnbaja.Text = "Baja"
        Me.btnbaja.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbuscar.Location = New System.Drawing.Point(45, 53)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 24
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnmostrar.Location = New System.Drawing.Point(126, 53)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 25
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Controls.Add(Me.btnmostrar)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.btnbaja)
        Me.GroupBox2.Controls.Add(Me.btnmodificar)
        Me.GroupBox2.Controls.Add(Me.btnalta)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 97)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'btnnuevo
        '
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnuevo.Location = New System.Drawing.Point(488, 192)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 27
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Location = New System.Drawing.Point(569, 192)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 28
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lblfecha_hora
        '
        Me.lblfecha_hora.BackColor = System.Drawing.Color.DimGray
        Me.lblfecha_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblfecha_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfecha_hora.Location = New System.Drawing.Point(439, 43)
        Me.lblfecha_hora.Name = "lblfecha_hora"
        Me.lblfecha_hora.Size = New System.Drawing.Size(260, 20)
        Me.lblfecha_hora.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TmdevdbDataSet
        '
        Me.TmdevdbDataSet.DataSetName = "tmdevdbDataSet"
        Me.TmdevdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "alumno"
        Me.AlumnoBindingSource.DataSource = Me.TmdevdbDataSet
        '
        'AlumnoTableAdapter
        '
        Me.AlumnoTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(41, 408)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(716, 237)
        Me.DataGridView1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 670)
        Me.Controls.Add(Me.lblfecha_hora)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtmaterno)
        Me.Controls.Add(Me.txtpaterno)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtmatricula)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblmaterno)
        Me.Controls.Add(Me.lblpaterno)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblmatricula)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TmdevdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmatricula As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblpaterno As Label
    Friend WithEvents lblmaterno As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblfecha_nac As Label
    Friend WithEvents txtmatricula As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtpaterno As TextBox
    Friend WithEvents txtmaterno As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblbuscar As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents rbtnmatricula As RadioButton
    Friend WithEvents rbtnApPaterno As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnalta As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnbaja As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents lblfecha_hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TmdevdbDataSet As tmdevdbDataSet
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents AlumnoTableAdapter As tmdevdbDataSetTableAdapters.alumnoTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
End Class
