Imports System.IO

Public Class Configuracion

    Private Sub cargar_img(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_img2.Click, btn_img1.Click
        ofd_imagen.Filter = "JPG|*.jpg|PNG|*.png|Mostrar todos|*.*"
        ofd_imagen.Title = "Seleccione imagen"
        ofd_imagen.FileName = ""

        If ofd_imagen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If sender.name.Equals("btn_img1") Then
                pic_jug1.Image = Image.FromFile(ofd_imagen.FileName)
            ElseIf sender.name.Equals("btn_img2") Then
                pic_jug2.Image = Image.FromFile(ofd_imagen.FileName)
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

    Private Sub guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_arx_save.Click, cmd_save.Click
        Dim ctrl As Integer = 0
        'Controlo que los jugadores hayan seleccionado una imagen
        If pic_jug1.Image Is Nothing Or pic_jug2.Image Is Nothing Then
            MsgBox("No ha seleccionado las imagenes de un jugador o de ambos")
        Else
            ctrl += 1
        End If
        'Controlo que se haya seleccionado una modalidad de juego
        If opt_3x3.Checked = 0 And opt_4x4.Checked = 0 And opt_5x5.Checked = 0 Then
            MsgBox("No ha seleccionado una modalidad de juego")
        Else
            ctrl += 1
        End If
        If ctrl = 2 Then
            Me.Close()
        End If
    End Sub

    Private Sub conf_tablero(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_5x5.CheckedChanged, opt_4x4.CheckedChanged, opt_3x3.CheckedChanged
        If sender.name.Equals("opt_3x3") Then
            Principal.dimen = 3
        ElseIf sender.name.Equals("opt_4x4") Then
            Principal.dimen = 4
        ElseIf sender.name.Equals("opt_5x5") Then
            Principal.dimen = 5
        End If
    End Sub

    Private Sub juega_pc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pc.CheckedChanged
        If chk_pc.Checked = True Then
            'MsgBox("No implementado actualmente")
            chk_defecto2.Checked = True
            txt_nombre2.Text = "Ordenador"
            Principal.pc = True
        Else
            chk_defecto2.Checked = False
            txt_nombre2.Text = "Jugador 2"
            Principal.pc = False
        End If
        
    End Sub
End Class