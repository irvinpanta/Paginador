<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaginacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lnkMsg = New System.Windows.Forms.LinkLabel()
        Me.lblFiltrando = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboPaginar = New System.Windows.Forms.ComboBox()
        Me.dgListado = New System.Windows.Forms.DataGridView()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.paginacion = New Paginador.PaginacionData()
        CType(Me.dgListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(374, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 14)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Buscar por Descripcion ..."
        '
        'lnkMsg
        '
        Me.lnkMsg.AutoSize = True
        Me.lnkMsg.Location = New System.Drawing.Point(240, 171)
        Me.lnkMsg.Name = "lnkMsg"
        Me.lnkMsg.Size = New System.Drawing.Size(178, 15)
        Me.lnkMsg.TabIndex = 52
        Me.lnkMsg.TabStop = True
        Me.lnkMsg.Text = "No se han encontrado registros"
        '
        'lblFiltrando
        '
        Me.lblFiltrando.AutoSize = True
        Me.lblFiltrando.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrando.Location = New System.Drawing.Point(31, 209)
        Me.lblFiltrando.Name = "lblFiltrando"
        Me.lblFiltrando.Size = New System.Drawing.Size(0, 14)
        Me.lblFiltrando.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(164, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Registros"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 15)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Mostrar"
        '
        'cboPaginar
        '
        Me.cboPaginar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaginar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPaginar.FormattingEnabled = True
        Me.cboPaginar.Items.AddRange(New Object() {"5", "10", "50", "100", "200"})
        Me.cboPaginar.Location = New System.Drawing.Point(88, 24)
        Me.cboPaginar.Name = "cboPaginar"
        Me.cboPaginar.Size = New System.Drawing.Size(69, 23)
        Me.cboPaginar.TabIndex = 46
        '
        'dgListado
        '
        Me.dgListado.AllowUserToAddRows = False
        Me.dgListado.AllowUserToDeleteRows = False
        Me.dgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgListado.BackgroundColor = System.Drawing.Color.White
        Me.dgListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgListado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgListado.ColumnHeadersHeight = 38
        Me.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgListado.Location = New System.Drawing.Point(28, 56)
        Me.dgListado.Name = "dgListado"
        Me.dgListado.ReadOnly = True
        Me.dgListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgListado.RowHeadersWidth = 25
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        Me.dgListado.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListado.Size = New System.Drawing.Size(612, 246)
        Me.dgListado.TabIndex = 48
        '
        'txtFiltrar
        '
        Me.txtFiltrar.ForeColor = System.Drawing.Color.Black
        Me.txtFiltrar.Location = New System.Drawing.Point(377, 24)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(263, 23)
        Me.txtFiltrar.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(314, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 15)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Buscar:"
        '
        'paginacion
        '
        Me.paginacion.BackColor = System.Drawing.Color.White
        Me.paginacion.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paginacion.gBackColor = System.Drawing.Color.White
        Me.paginacion.Location = New System.Drawing.Point(304, 308)
        Me.paginacion.Name = "paginacion"
        Me.paginacion.Size = New System.Drawing.Size(336, 34)
        Me.paginacion.TabIndex = 0
        '
        'FormPaginacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 348)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lnkMsg)
        Me.Controls.Add(Me.lblFiltrando)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboPaginar)
        Me.Controls.Add(Me.dgListado)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.paginacion)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormPaginacion"
        Me.Text = "FormPaginacion"
        CType(Me.dgListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paginacion As Paginador.PaginacionData
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lnkMsg As System.Windows.Forms.LinkLabel
    Friend WithEvents lblFiltrando As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboPaginar As System.Windows.Forms.ComboBox
    Friend WithEvents dgListado As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
