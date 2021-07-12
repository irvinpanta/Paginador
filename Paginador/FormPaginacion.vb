Public Class FormPaginacion

    Private dt As New DataTable
    Private dta As New llenarGrid


    'Metodo para Cargar registros en el DataGrid
    Private Sub llenarGrid(Filtrar As Boolean)
        Try
            If Filtrar = True Then

                paginacion.paginaActual = 0 'Estable el Paginado en la Primera Pagina
                dt = dta.llenarGrid(2, txtFiltrar.Text) 'Filtra Registros segun Busqueda

            Else
                dt = dta.llenarGrid(1, "") 'Llenar el DT: DataTable con los Registros
            End If

            If dt.Rows.Count <> 0 Then 'Verifica Si el Dt tiene registros

                paginacion.cargarDatos(dt, dgListado) 'Llenar el DataGrid con los Registros
                lnkMsg.Visible = False 'Oculta el Message
                paginacion.Enabled = True 'Habilita el Paginador
                cboPaginar.Enabled = True 'Habilita el comboBox del Paginador'

            Else

                dgListado.DataSource = Nothing
                lnkMsg.Visible = True 'Muestra el Message
                paginacion.Enabled = False 'Desactiva El Paginador
                cboPaginar.Enabled = False 'Desactiva el comboBox del Paginador'

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        llenarGrid(True)
    End Sub

    Private Sub FormPaginacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboPaginar.SelectedIndex = 1 'Selecciona el Primero registro del ComboBox
        llenarGrid(False) 'Carga los Registros en el DataGridView
    End Sub

    Private Sub paginacion_Load(sender As Object, e As EventArgs) Handles paginacion.Load
        Try
            paginacion.dataGridView = dgListado
            paginacion.itemPorPaginas = 10
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboPaginar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaginar.SelectedIndexChanged
        paginacion.itemPorPaginas = cboPaginar.SelectedItem
        paginacion.paginaActual = 0
        llenarGrid(False)
    End Sub


End Class
