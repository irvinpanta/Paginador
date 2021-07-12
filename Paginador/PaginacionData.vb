Public Class PaginacionData
    Public Property gBackColor As Color
        Get
            Return panelPrimario.BackColor
        End Get
        Set(value As Color)
            panelPrimario.BackColor = value
        End Set
    End Property


    Private dtTotalDatos = New DataTable
    Private total As Integer = 0
    Public paginaActual As Integer = 0
    Private maximoPaginas As Integer = 0
    Public itemPorPaginas As Integer

    Public dataGridView As DataGridView
    Public Sub cargarDatos(dt As DataTable, dgv As DataGridView)

        dtTotalDatos = dt
        total = dt.Rows.Count
        maximoPaginas = Math.Ceiling(total / itemPorPaginas)

        lblTotalPaginas.Text = maximoPaginas
        dgv.DataSource = Split(dtTotalDatos)
        habilitarBotones()

    End Sub

    Private Function Split(dt As DataTable) As DataTable
        Try
            lblPaginaActual.Text = (paginaActual + 1)
            habilitarBotones()
            Return dt.Select.Skip(itemPorPaginas * paginaActual).Take(itemPorPaginas).CopyToDataTable()

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub botonSiguiente(dgv As DataGridView)
        paginaActual = paginaActual + 1
        dgv.DataSource = Split(dtTotalDatos)
    End Sub

    Public Sub botonAnterior(dgv As DataGridView)
        paginaActual = paginaActual - 1
        dgv.DataSource = Split(dtTotalDatos)
    End Sub


    Public Sub habilitarBotones()
        If paginaActual = 0 Then
            btnAnterior.Enabled = False
        Else
            btnAnterior.Enabled = True
        End If

        If paginaActual = (maximoPaginas - 1) Then
            btnSiguiente.Enabled = False
        Else
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        botonSiguiente(dataGridView)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        botonAnterior(dataGridView)
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        paginaActual = 0
        dataGridView.DataSource = Split(dtTotalDatos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        paginaActual = maximoPaginas - 1
        dataGridView.DataSource = Split(dtTotalDatos)
    End Sub
End Class
