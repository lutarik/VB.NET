Public Class Calculadora


    Private Sub add_num(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click, btn_9.Click, btn_8.Click, btn_7.Click, btn_6.Click, btn_5.Click, btn_4.Click, btn_3.Click, btn_2.Click, btn_0.Click
        If txt_display.Text.Length < 11 Then
            txt_display.Text = txt_display.Text + sender.text
        End If
    End Sub

    Private Sub Calculadora_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub Calculadora_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Es igual que el de arriba pero de otra manera
        If Strings.Len(txt_display.Text) < 11 Then
            txt_display.Text = txt_display.Text + e.KeyChar
        End If
    End Sub

    Private Sub Calculadora_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        MessageBox.Show(e.KeyValue)

    End Sub
End Class
