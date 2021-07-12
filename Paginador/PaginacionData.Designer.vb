<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginacionData
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginacionData))
        Me.panelPrimario = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPaginas = New System.Windows.Forms.Label()
        Me.lblPaginaActual = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.panelPrimario.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelPrimario
        '
        Me.panelPrimario.Controls.Add(Me.Button1)
        Me.panelPrimario.Controls.Add(Me.btnPrimero)
        Me.panelPrimario.Controls.Add(Me.Label3)
        Me.panelPrimario.Controls.Add(Me.lblTotalPaginas)
        Me.panelPrimario.Controls.Add(Me.lblPaginaActual)
        Me.panelPrimario.Controls.Add(Me.btnAnterior)
        Me.panelPrimario.Controls.Add(Me.btnSiguiente)
        Me.panelPrimario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPrimario.Location = New System.Drawing.Point(0, 0)
        Me.panelPrimario.Name = "panelPrimario"
        Me.panelPrimario.Size = New System.Drawing.Size(336, 34)
        Me.panelPrimario.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(180, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 26)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Ultima"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrimero.FlatAppearance.BorderSize = 0
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.Location = New System.Drawing.Point(88, 3)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(28, 26)
        Me.btnPrimero.TabIndex = 47
        Me.btnPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "/"
        '
        'lblTotalPaginas
        '
        Me.lblTotalPaginas.AutoSize = True
        Me.lblTotalPaginas.Location = New System.Drawing.Point(160, 10)
        Me.lblTotalPaginas.Name = "lblTotalPaginas"
        Me.lblTotalPaginas.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalPaginas.TabIndex = 45
        Me.lblTotalPaginas.Text = "0"
        '
        'lblPaginaActual
        '
        Me.lblPaginaActual.AutoSize = True
        Me.lblPaginaActual.Location = New System.Drawing.Point(123, 10)
        Me.lblPaginaActual.Name = "lblPaginaActual"
        Me.lblPaginaActual.Size = New System.Drawing.Size(14, 15)
        Me.lblPaginaActual.TabIndex = 44
        Me.lblPaginaActual.Text = "0"
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnterior.Location = New System.Drawing.Point(3, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(80, 26)
        Me.btnAnterior.TabIndex = 43
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSiguiente.Location = New System.Drawing.Point(247, 4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(78, 26)
        Me.btnSiguiente.TabIndex = 42
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'PaginacionData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.panelPrimario)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PaginacionData"
        Me.Size = New System.Drawing.Size(336, 34)
        Me.panelPrimario.ResumeLayout(False)
        Me.panelPrimario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelPrimario As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPaginas As System.Windows.Forms.Label
    Friend WithEvents lblPaginaActual As System.Windows.Forms.Label
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button

End Class
