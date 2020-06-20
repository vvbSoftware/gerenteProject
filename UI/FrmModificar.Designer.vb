<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificar
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelModSintoma = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelModEnfermedad = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtSegApellido = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtSegNombre = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHoraSalidaDomingo = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaSabado = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaJueves = New System.Windows.Forms.TextBox()
        Me.txtHoraSalidaLunes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaDomingo = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaSabado = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaJueves = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaLunes = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPriApellido = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelModifMedico = New System.Windows.Forms.Panel()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelModSintoma.SuspendLayout()
        Me.PanelModEnfermedad.SuspendLayout()
        Me.PanelModifMedico.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(227, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 36)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Modificar"
        '
        'DgvDatos
        '
        Me.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvDatos.ColumnHeadersHeight = 30
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDatos.DefaultCellStyle = DataGridViewCellStyle14
        Me.DgvDatos.EnableHeadersVisualStyles = False
        Me.DgvDatos.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvDatos.Location = New System.Drawing.Point(16, 92)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DgvDatos.Size = New System.Drawing.Size(640, 204)
        Me.DgvDatos.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 79
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 79
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 79
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltro.ForeColor = System.Drawing.Color.Silver
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbFiltro.Location = New System.Drawing.Point(16, 302)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(180, 24)
        Me.cbFiltro.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Haga doble click en una celda para seleccionar el elemento"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.ForeColor = System.Drawing.Color.Silver
        Me.btnFiltrar.Location = New System.Drawing.Point(202, 300)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(180, 30)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "FILTRAR"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(0, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Silver
        Me.TextBox3.Location = New System.Drawing.Point(7, 79)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(392, 93)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Silver
        Me.TextBox4.Location = New System.Drawing.Point(8, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(180, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(14, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Datos Seleccionados"
        '
        'PanelModSintoma
        '
        Me.PanelModSintoma.Controls.Add(Me.TextBox1)
        Me.PanelModSintoma.Controls.Add(Me.Label5)
        Me.PanelModSintoma.Location = New System.Drawing.Point(16, 349)
        Me.PanelModSintoma.Name = "PanelModSintoma"
        Me.PanelModSintoma.Size = New System.Drawing.Size(191, 66)
        Me.PanelModSintoma.TabIndex = 10
        Me.PanelModSintoma.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(216, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Riesgo"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(219, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(5, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion"
        '
        'PanelModEnfermedad
        '
        Me.PanelModEnfermedad.Controls.Add(Me.TextBox4)
        Me.PanelModEnfermedad.Controls.Add(Me.TextBox3)
        Me.PanelModEnfermedad.Controls.Add(Me.ComboBox1)
        Me.PanelModEnfermedad.Controls.Add(Me.Label3)
        Me.PanelModEnfermedad.Controls.Add(Me.Label4)
        Me.PanelModEnfermedad.Controls.Add(Me.Label1)
        Me.PanelModEnfermedad.Location = New System.Drawing.Point(16, 349)
        Me.PanelModEnfermedad.Name = "PanelModEnfermedad"
        Me.PanelModEnfermedad.Size = New System.Drawing.Size(413, 180)
        Me.PanelModEnfermedad.TabIndex = 11
        Me.PanelModEnfermedad.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Silver
        Me.TextBox6.Location = New System.Drawing.Point(415, 79)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(180, 22)
        Me.TextBox6.TabIndex = 46
        '
        'txtSegApellido
        '
        Me.txtSegApellido.AutoSize = True
        Me.txtSegApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtSegApellido.Location = New System.Drawing.Point(437, 57)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(148, 21)
        Me.txtSegApellido.TabIndex = 25
        Me.txtSegApellido.Text = "Segundo Apellido"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Silver
        Me.TextBox2.Location = New System.Drawing.Point(203, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 22)
        Me.TextBox2.TabIndex = 44
        '
        'txtSegNombre
        '
        Me.txtSegNombre.AutoSize = True
        Me.txtSegNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtSegNombre.Location = New System.Drawing.Point(217, 55)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(147, 21)
        Me.txtSegNombre.TabIndex = 23
        Me.txtSegNombre.Text = "Segundo Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(538, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 21)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Domingo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(467, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Sabado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(404, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 21)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Viernes"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Silver
        Me.TextBox5.Location = New System.Drawing.Point(415, 34)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(180, 22)
        Me.TextBox5.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(344, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 21)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Jueves"
        '
        'txtHoraSalidaDomingo
        '
        Me.txtHoraSalidaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaDomingo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaDomingo.Location = New System.Drawing.Point(560, 175)
        Me.txtHoraSalidaDomingo.Name = "txtHoraSalidaDomingo"
        Me.txtHoraSalidaDomingo.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaDomingo.TabIndex = 42
        '
        'txtHoraSalidaSabado
        '
        Me.txtHoraSalidaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaSabado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaSabado.Location = New System.Drawing.Point(484, 174)
        Me.txtHoraSalidaSabado.Name = "txtHoraSalidaSabado"
        Me.txtHoraSalidaSabado.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaSabado.TabIndex = 41
        '
        'txtHoraSalidaMiercoles
        '
        Me.txtHoraSalidaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaMiercoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaMiercoles.Location = New System.Drawing.Point(281, 175)
        Me.txtHoraSalidaMiercoles.Name = "txtHoraSalidaMiercoles"
        Me.txtHoraSalidaMiercoles.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaMiercoles.TabIndex = 40
        '
        'txtHoraSalidaViernes
        '
        Me.txtHoraSalidaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaViernes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaViernes.Location = New System.Drawing.Point(418, 174)
        Me.txtHoraSalidaViernes.Name = "txtHoraSalidaViernes"
        Me.txtHoraSalidaViernes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaViernes.TabIndex = 39
        '
        'txtHoraSalidaMartes
        '
        Me.txtHoraSalidaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaMartes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaMartes.Location = New System.Drawing.Point(211, 177)
        Me.txtHoraSalidaMartes.Name = "txtHoraSalidaMartes"
        Me.txtHoraSalidaMartes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaMartes.TabIndex = 38
        '
        'txtHoraSalidaJueves
        '
        Me.txtHoraSalidaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaJueves.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaJueves.Location = New System.Drawing.Point(353, 175)
        Me.txtHoraSalidaJueves.Name = "txtHoraSalidaJueves"
        Me.txtHoraSalidaJueves.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaJueves.TabIndex = 37
        '
        'txtHoraSalidaLunes
        '
        Me.txtHoraSalidaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraSalidaLunes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraSalidaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraSalidaLunes.Location = New System.Drawing.Point(147, 175)
        Me.txtHoraSalidaLunes.Name = "txtHoraSalidaLunes"
        Me.txtHoraSalidaLunes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraSalidaLunes.TabIndex = 36
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaDomingo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(560, 133)
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaDomingo.TabIndex = 35
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaSabado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(484, 132)
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaSabado.TabIndex = 32
        '
        'txtHoraEntradaViernes
        '
        Me.txtHoraEntradaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaViernes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(418, 132)
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaViernes.TabIndex = 34
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(281, 133)
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaMiercoles.TabIndex = 33
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(353, 133)
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaJueves.TabIndex = 45
        '
        'txtHoraEntradaMartes
        '
        Me.txtHoraEntradaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMartes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(211, 135)
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaMartes.TabIndex = 31
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(147, 133)
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(49, 22)
        Me.txtHoraEntradaLunes.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(264, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 21)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Miercoles"
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.Silver
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(8, 77)
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(180, 22)
        Me.txtLugarTrabajo.TabIndex = 30
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtEspecialidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialidad.ForeColor = System.Drawing.Color.Silver
        Me.txtEspecialidad.Location = New System.Drawing.Point(8, 34)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(180, 22)
        Me.txtEspecialidad.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(201, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Martes"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Silver
        Me.TextBox7.Location = New System.Drawing.Point(203, 34)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(180, 22)
        Me.TextBox7.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(136, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Lunes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(29, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lugar de Trabajo"
        '
        'txtPriApellido
        '
        Me.txtPriApellido.AutoSize = True
        Me.txtPriApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtPriApellido.Location = New System.Drawing.Point(448, 11)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(125, 21)
        Me.txtPriApellido.TabIndex = 19
        Me.txtPriApellido.Text = "Primer Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(43, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Especialidad"
        '
        'txtPriNombre
        '
        Me.txtPriNombre.AutoSize = True
        Me.txtPriNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtPriNombre.Location = New System.Drawing.Point(236, 11)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(124, 21)
        Me.txtPriNombre.TabIndex = 24
        Me.txtPriNombre.Text = "Primer Nombre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(5, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Hora de Salida"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(5, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 21)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Hora de Entrada"
        '
        'PanelModifMedico
        '
        Me.PanelModifMedico.Controls.Add(Me.TextBox6)
        Me.PanelModifMedico.Controls.Add(Me.txtSegApellido)
        Me.PanelModifMedico.Controls.Add(Me.Label17)
        Me.PanelModifMedico.Controls.Add(Me.TextBox2)
        Me.PanelModifMedico.Controls.Add(Me.txtSegNombre)
        Me.PanelModifMedico.Controls.Add(Me.Label16)
        Me.PanelModifMedico.Controls.Add(Me.Label15)
        Me.PanelModifMedico.Controls.Add(Me.TextBox5)
        Me.PanelModifMedico.Controls.Add(Me.Label14)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaDomingo)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaSabado)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaMiercoles)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaViernes)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaMartes)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaJueves)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraSalidaLunes)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaSabado)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaViernes)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaMiercoles)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaJueves)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaMartes)
        Me.PanelModifMedico.Controls.Add(Me.txtHoraEntradaLunes)
        Me.PanelModifMedico.Controls.Add(Me.Label13)
        Me.PanelModifMedico.Controls.Add(Me.txtLugarTrabajo)
        Me.PanelModifMedico.Controls.Add(Me.txtEspecialidad)
        Me.PanelModifMedico.Controls.Add(Me.Label12)
        Me.PanelModifMedico.Controls.Add(Me.TextBox7)
        Me.PanelModifMedico.Controls.Add(Me.Label11)
        Me.PanelModifMedico.Controls.Add(Me.Label7)
        Me.PanelModifMedico.Controls.Add(Me.txtPriApellido)
        Me.PanelModifMedico.Controls.Add(Me.Label6)
        Me.PanelModifMedico.Controls.Add(Me.txtPriNombre)
        Me.PanelModifMedico.Controls.Add(Me.Label10)
        Me.PanelModifMedico.Controls.Add(Me.Label18)
        Me.PanelModifMedico.Location = New System.Drawing.Point(12, 349)
        Me.PanelModifMedico.Name = "PanelModifMedico"
        Me.PanelModifMedico.Size = New System.Drawing.Size(622, 219)
        Me.PanelModifMedico.TabIndex = 47
        Me.PanelModifMedico.Visible = False
        '
        'FrmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 570)
        Me.Controls.Add(Me.PanelModifMedico)
        Me.Controls.Add(Me.PanelModEnfermedad)
        Me.Controls.Add(Me.PanelModSintoma)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificar"
        Me.Text = "FrmModificar"
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelModSintoma.ResumeLayout(False)
        Me.PanelModSintoma.PerformLayout()
        Me.PanelModEnfermedad.ResumeLayout(False)
        Me.PanelModEnfermedad.PerformLayout()
        Me.PanelModifMedico.ResumeLayout(False)
        Me.PanelModifMedico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DgvDatos As DataGridView
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelModSintoma As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelModEnfermedad As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtSegApellido As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtSegNombre As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHoraSalidaDomingo As TextBox
    Friend WithEvents txtHoraSalidaSabado As TextBox
    Friend WithEvents txtHoraSalidaMiercoles As TextBox
    Friend WithEvents txtHoraSalidaViernes As TextBox
    Friend WithEvents txtHoraSalidaMartes As TextBox
    Friend WithEvents txtHoraSalidaJueves As TextBox
    Friend WithEvents txtHoraSalidaLunes As TextBox
    Friend WithEvents txtHoraEntradaDomingo As TextBox
    Friend WithEvents txtHoraEntradaSabado As TextBox
    Friend WithEvents txtHoraEntradaViernes As TextBox
    Friend WithEvents txtHoraEntradaMiercoles As TextBox
    Friend WithEvents txtHoraEntradaJueves As TextBox
    Friend WithEvents txtHoraEntradaMartes As TextBox
    Friend WithEvents txtHoraEntradaLunes As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLugarTrabajo As TextBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPriApellido As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPriNombre As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PanelModifMedico As Panel
End Class
