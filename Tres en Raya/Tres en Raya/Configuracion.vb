Imports System.IO

Public Class Configuracion

    Private Sub cargar_img(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_img2.Click, btn_img1.Click
        ofd_imagen.Filter = "JPG|*.jpg|PNG|*.png|Mostrar todos|*.*"
        ofd_imagen.Title = "Seleccione imagen"
        ofd_imagen.FileName = ""

        If ofd_imagen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If sender.name.Equals("btn_img1") Then
                pic_jug1.Image = Image.FromFile(ofd_imagen.FileName)
                Principal.fj1 = Image.FromFile(ofd_imagen.FileName)
            ElseIf sender.name.Equals("btn_img2") Then
                pic_jug2.Image = Image.FromFile(ofd_imagen.FileName)
                Principal.fj2 = Image.FromFile(ofd_imagen.FileName)
            End If
        End If
    End Sub

    Private Sub img_defecto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_defecto2.CheckedChanged, chk_defecto1.CheckedChanged

        If sender.checked = -1 Then
            If sender.name.Equals("chk_defecto1") Then
                pic_jug1.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "imagenes\cruz.png"))
            ElseIf sender.name.Equals("chk_defecto2") Then
                pic_jug2.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "imagenes\circulo.jpg"))
            End If
        ElseIf sender.checked = 0 Then
            If sender.name.Equals("chk_defecto1") Then
                pic_jug1.Image = Nothing
            ElseIf sender.name.Equals("chk_defecto2") Then
                pic_jug2.Image = Nothing
            End If
        End If
    End Sub

    Private Sub guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_arx_save.Click
        Me.Close()
    End Sub
End Class