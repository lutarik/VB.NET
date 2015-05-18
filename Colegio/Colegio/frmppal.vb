Public Class frmppal



    Private Sub cambio_tabla(sender As Object, e As EventArgs) Handles combo_tabla.SelectedIndexChanged
        Select Case sender.selectedindex

            Case 0
                dta_datoscole.DataMember = "alumnos"
                dta_datoscole.Refresh()
                MsgBox("0")
            Case 1
                MsgBox("1")
            Case 2
                MsgBox("2")
        End Select


    End Sub
End Class
