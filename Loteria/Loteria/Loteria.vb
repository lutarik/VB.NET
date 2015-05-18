Public Class Loteria

    '**********VARIABLES GLOBALES**********'
    Dim arreu As New Random
    'Guardo los checkbox
    Dim tmp_array() As CheckBox = {}
    Dim lote_nums As List(Of CheckBox) = tmp_array.ToList()
    'Guardo los numeros seleccionados
    Dim tmp_array2() As Integer = {}
    Public seleccion As List(Of Integer) = tmp_array2.ToList
    'Guardo los numeros ganadores
    Dim tmp_array3() As Integer = {}
    Public combinacion As List(Of Integer) = tmp_array3.ToList
    'Variable control para que no elijan más números de los permitidos
    Dim checked As Integer = 0
    '**********FIN VARIABLES GLOBALES**********'

    ''' <summary>
    ''' Genero los checkbox.
    ''' Llamada desde:
    ''' Loteria_Load
    ''' </summary>
    ''' <param name="i">Número del checkbox</param>
    ''' <param name="x">Posición en el eje X. Se pasa por referencia para así ir aumentando</param>
    ''' <param name="y">Posición en el eje Y. Se pasa por referencia para así ir aumentando</param>
    ''' <remarks></remarks>
    Private Sub generador_chk(ByVal i As Integer, ByRef x As Integer, ByRef y As Integer)
        Dim check As New CheckBox

        With check
            'Nombre
            .Name = "chk" & i
            .Text = i & ": "
            .Tag = i
            'Quitamos autosize
            .AutoSize = False
            'Lo cargamos deshabilitado
            .Enabled = False
            'Situamos la casilla a la derecha
            .CheckAlign = ContentAlignment.MiddleRight
            'Fuente
            .Font = New System.Drawing.Font("Arial", 11, FontStyle.Bold)
            'Ancho y Alto
            .Width = 50
            .Height = 30
            'Situamos el chk
            If x = 350 Then
                x = 0
                y = y + .Height
            End If
            .Location = New Point(x, y)
            'Indico donde mostrarse
            .Parent = divisor.Panel1
            'Indico a la función CheckedChanged que cuando suceda llame a checkear
            AddHandler .CheckedChanged, AddressOf checkear
            x = x + .Width
        End With
        lote_nums.Add(check)
    End Sub

    ''' <summary>
    ''' Mostramos los resultados de la lotería
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub mostrar_resultados_sorteo() Handles btn_check.Click
        Dim i, x As Integer
        Dim res As String = ""
        combinacion.Clear()
        For i = 1 To 6
            x = arreu.Next(1, 50)
            Do While repetido(x, combinacion)
                x = arreu.Next(1, 50)
                For j = 0 To 1000
                Next
            Loop
            combinacion.Add(x)
        Next
        'Ordenamos y almacenamos el reintegro al final
        ordenar(combinacion)
        combinacion.Add(arreu.Next(10))

        Resultado.Show()
    End Sub

    ''' <summary>
    ''' Comprobamos si el numero seleccionado ya ha salido
    ''' </summary>
    ''' <param name="num">Número a comprobar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function repetido(ByVal num As Integer, ByRef arrai As List(Of Integer)) As Boolean
        Dim repe As Boolean
        If arrai.Count = 0 Then
            repe = False
        Else
            For i = 0 To arrai.Count - 1
                If arrai(i) = num Then
                    repe = True
                End If
            Next
        End If
        If repe Then
            Return repe
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Ordenamos los resultados
    ''' </summary>
    ''' <param name="arrai">Nombre del array a ordenar</param>
    ''' <remarks></remarks>
    Private Sub ordenar(ByRef arrai As List(Of Integer))
        arrai.Sort()
    End Sub

    Private Sub Loteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x, y As Integer
        x = 0
        y = 0
        'Genero los checkbox
        For i = 1 To 49
            generador_chk(i, x, y)
        Next
        botones(False, "load")
    End Sub

    ''' <summary>
    ''' Bloque los botones dependiendo de donde me llamen
    ''' </summary>
    ''' <param name="est"></param>
    ''' <param name="funcion"></param>
    ''' <remarks></remarks>
    Private Sub botones(ByRef est As Boolean, ByRef funcion As String)
        If funcion.Equals("btn_manual") Then
            btn_manual.Enabled = est
            btn_borrar.Enabled = Not est
        ElseIf funcion.Equals("load") Then
            btn_check.Enabled = est
            btn_borrar.Enabled = est
        ElseIf funcion.Equals("automatico") Then
            btn_check.Enabled = est
            btn_borrar.Enabled = est
        ElseIf funcion.Equals("borrar") Then
            btn_borrar.Enabled = est
            btn_manual.Enabled = Not est
            btn_check.Enabled = est
        End If

    End Sub

    ''' <summary>
    ''' Habilito los checkbox y el reintegro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub nums_manual(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manual.Click
        For Each check In lote_nums
            check.Enabled = True
        Next
        '(Des)Habilitamos
        txt_reintegro.Enabled = True
        botones(False, "btn_manual")
    End Sub

    ''' <summary>
    ''' Genero numeros aleatorios así como un reintegro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub nums_auto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_auto.Click
        Dim x As Integer
        'Vacio el tablero
        vaciado()
        'For para rellenar los checkbox
        For i = 1 To 6
            'Calculo el numero
            x = arreu.Next(1, 50)
            Do While repetido(x, seleccion)
                x = arreu.Next(1, 50)
                For j = 0 To 1000
                Next
            Loop
            'Lo marco
            x = x - 1
            lote_nums.ElementAt(x).Checked = True
        Next
        bloqueo_chk()
        'Ordeno los numeros seleccionados
        ordenar(seleccion)
        'Calculo el reintegro y lo añado. Hago el ordenar antes para que no me coja el reintegro, que lo guardaré en última posicion
        txt_reintegro.Text = arreu.Next(10)
        seleccion.Add(CInt(txt_reintegro.Text))
        '(Des)Habilito botones
        botones(True, "automatico")
    End Sub

    ''' <summary>
    ''' Compruebo que el reintegro esté entre los numeros indicados. Si está y se han marcado los 6 checkbox se activa el botón de comprobar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub reintegro_chk(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_reintegro.Leave
        If CInt(txt_reintegro.Text) < 0 Or CInt(txt_reintegro.Text) > 9 Then
            MsgBox("No ha introducido el número correctamente." & Chr(13) & "Recuerde que es entre 0 y 9")
            txt_reintegro.Focus()
        Else
            seleccion.Add(CInt(txt_reintegro.Text))
            If checked = 6 Then
                btn_check.Enabled = True
            End If

        End If
    End Sub

    ''' <summary>
    ''' Al pulsar en cada check compruebo los que hay seleccionado.
    ''' Llamamos a bloqueo_chk.
    ''' Si hay 6 marcados y hay reintegro habilitamos el boton para comprobar la combinación
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub checkear(ByVal sender As Object, ByVal e As System.EventArgs)

        If sender.checked = True Then
            checked += 1
            seleccion.Add(sender.tag)
        ElseIf sender.checked = False Then
            checked -= 1
            seleccion.Remove(sender.tag)
        End If

        bloqueo_chk()

        If checked = 6 And txt_reintegro.Text.Length > 0 Then
            btn_check.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Comprueba si hay si marcados, si los hay bloqueamos el resto para que no se seleccionen.
    ''' Llamada desde:
    ''' checkear, vaciado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub bloqueo_chk()
        If checked = 6 Then
            For Each check In lote_nums
                If check.Checked = False Then
                    check.Enabled = False
                End If
            Next
        Else
            For Each check In lote_nums
                check.Enabled = True
            Next
        End If
    End Sub

    ''' <summary>
    ''' Desmarcamos las casillas, borramos el reintegro y ponermos a 0 checked
    ''' Lo llamamos desde:
    ''' boton vaciado, num_auto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub vaciado() Handles btn_borrar.Click
        For Each check In lote_nums
            If check.Checked = True Then
                check.Checked = False
            End If
        Next
        checked = 0
        seleccion.Clear()
        combinacion.Clear()
        bloqueo_chk()
        botones(False, "borrar")
        txt_reintegro.Text = ""
    End Sub


End Class
