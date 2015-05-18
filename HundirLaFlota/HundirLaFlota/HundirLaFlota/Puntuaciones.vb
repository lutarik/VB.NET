Public Class frm_puntuaciones

    Private Sub frm_puntuaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HundirLaFlotaDS.Puntuaciones' Puede moverla o quitarla según sea necesario.
        Me.PuntuacionesTableAdapter.Fill(Me.HundirLaFlotaDS.Puntuaciones)

    End Sub
End Class