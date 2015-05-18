

Public Class Mnto

    Dim conecta As MySqlConnection
    Dim datos As MySqlDataAdapter


    Private Sub select_tabla(sender As Object, e As EventArgs) Handles list_tablas.Click
        Select Case sender.SelectedIndex
            Case 0
                Cargar_Alumnos()
            Case 1
                Cargar_Asignatura()
            Case 2
                Cargar_Matricula()
        End Select
    End Sub

    Private Sub Cargar_Alumnos()
        
        Dim alumnos As New DataSet

        Try
            conecta = conexion()
            datos = Do_Select("*", "Alumnos", "", conecta)

            datos.Fill(alumnos)
            dta_formulario.DataSource = alumnos.Tables(0)
            dta_formulario.Columns(0).HeaderText = "Id Alumno"
            dta_formulario.Columns(1).HeaderText = "Nombre"
            dta_formulario.Columns(2).HeaderText = "Apellidos"
            dta_formulario.Columns(3).HeaderText = "Fec Nacimiento"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Asignatura()
        Dim asignatura As New DataSet

        Try
            conecta = conexion()
            datos = Do_Select("*", "Asignaturas", "", conecta)

            datos.Fill(asignatura)
            dta_formulario.DataSource = asignatura.Tables(0)
            dta_formulario.Columns(0).HeaderText = "Id Asignatura"
            dta_formulario.Columns(1).HeaderText = "Nombre"
            dta_formulario.Columns(2).HeaderText = "Profesor"
            dta_formulario.Columns(3).HeaderText = "Horas"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Matricula()
        Dim matriculas As New DataSet

        Try
            conecta = conexion()
            datos = Do_Select("mat_id, alumn_nombre, asig_nombre", "Matricula INNER JOIN alumnos ON mat_alumn_id = alumn_id INNER JOIN asignaturas ON mat_asig_id = asig_id", "", conecta)

            datos.Fill(matriculas)
            dta_formulario.DataSource = matriculas.Tables(0)
            dta_formulario.Columns(0).HeaderText = "Id Matricula"
            dta_formulario.Columns(1).HeaderText = "Alumno"
            dta_formulario.Columns(2).HeaderText = "Asignatura"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        End Sub

    Private Sub Open_Insert(sender As Object, e As EventArgs) Handles cmd_insert.Click
        Try
            Select Case list_tablas.SelectedIndex
                Case 0

                    Creador_Et("lbl_id", "Id Alumno:", Frm_Insert.lbl_campo1.Location)
                    Frm_Insert.txt_campo1.Visible = True
                    Creador_Et("lbl_nombre", "Nombre:", Frm_Insert.lbl_campo2.Location)
                    Frm_Insert.txt_campo2.Visible = True
                    Creador_Et("lbl_apellidos", "Apellidos:", Frm_Insert.lbl_campo3.Location)
                    Frm_Insert.txt_campo3.Visible = True
                    Creador_Et("lbl_fenac", "Fec. Nacimiento:", Frm_Insert.lbl_campo4.Location)
                    Frm_Insert.txt_campo4.Visible = False
                    Creador_Datos("date_fenac", "fecha", Frm_Insert.txt_campo4.Location)

                    Frm_Insert.lbl_campo1.Visible = False
                    Frm_Insert.lbl_campo2.Visible = False
                    Frm_Insert.lbl_campo3.Visible = False
                    Frm_Insert.lbl_campo4.Visible = False

                    Frm_Insert.ShowDialog()
                Case 1

                    Creador_Et("lbl_id", "Id Asignatura:", Frm_Insert.lbl_campo1.Location)
                    Frm_Insert.txt_campo1.Visible = True
                    Creador_Et("lbl_nombre", "Nombre:", Frm_Insert.lbl_campo2.Location)
                    Frm_Insert.txt_campo2.Visible = True
                    Creador_Et("lbl_profesor", "Profesor:", Frm_Insert.lbl_campo3.Location)
                    Frm_Insert.txt_campo3.Visible = True
                    Creador_Et("lbl_horas", "Horas Lectivas:", Frm_Insert.lbl_campo4.Location)
                    Frm_Insert.txt_campo4.Visible = True

                    Frm_Insert.lbl_campo1.Visible = False
                    Frm_Insert.lbl_campo2.Visible = False
                    Frm_Insert.lbl_campo3.Visible = False
                    Frm_Insert.lbl_campo4.Visible = False

                    Frm_Insert.ShowDialog()
                Case 2

                    Creador_Et("lbl_id", "Id Matricula:", Frm_Insert.lbl_campo1.Location)
                    Frm_Insert.txt_campo1.Visible = True
                    Creador_Et("lbl_alumno", "Alumno:", Frm_Insert.lbl_campo2.Location)
                    Frm_Insert.txt_campo2.Visible = True
                    Creador_Et("lbl_asignatura", "Asignatura:", Frm_Insert.lbl_campo3.Location)
                    Frm_Insert.txt_campo3.Visible = True

                    Frm_Insert.lbl_campo1.Visible = False
                    Frm_Insert.lbl_campo2.Visible = False
                    Frm_Insert.lbl_campo3.Visible = False
                    Frm_Insert.lbl_campo4.Visible = False
                    Frm_Insert.txt_campo4.Visible = False

                    Frm_Insert.ShowDialog()
                Case Else
                    MsgBox("No ha seleccionado ninguna Tabla." & Chr(13) & "Elija una y pruebe de nuevo")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Eliminar_Registro(sender As Object, e As EventArgs) Handles cmd_delete.Click
        Dim indice As Integer
    End Sub
End Class
