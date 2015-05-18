Public Class Resultado

    Private Sub salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Resultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim acierto As Integer = 0

        carga_datos("seleccion")

        carga_datos("combinacion")

        For i = 0 To Loteria.seleccion.Count - 2
            For j = 0 To Loteria.combinacion.Count - 2
                If Loteria.seleccion(i) = Loteria.combinacion(j) Then
                    acierto += 1
                End If
            Next
        Next
        
        Label3.Text = Label3.Text + acierto.ToString
    End Sub

    Private Sub carga_datos(ByVal seccion As String)
        Dim x As Integer = 0
        If seccion.Equals("seleccion") Then
            For i = 0 To Loteria.seleccion.Count - 1
                cargar_datos_seleccion(i, x)
            Next
        ElseIf seccion.Equals("combinacion") Then
            For i = 0 To Loteria.combinacion.Count - 1
                cargar_datos_combinacion(i, x)
            Next
        End If
    End Sub

    Private Sub cargar_datos_seleccion(ByRef i As Integer, ByRef x As Integer)
        Dim num_sel As New Label
        Dim y As Integer
        y = 0
        With num_sel
            'Nombre
            .Name = "lbl_" & i
            .Tag = Loteria.seleccion(i).ToString
            'Tamaño
            .AutoSize = False
            .Width = 50
            .Height = 50
            'Tipo y detalles fuente
            .Font = New System.Drawing.Font("Arial", 20, FontStyle.Bold)
            'Si coincide lo marco en verde
            For j = 0 To Loteria.combinacion.Count - 2
                If Loteria.seleccion(i) = Loteria.combinacion(j) Then
                    .BackColor = Color.Green
                    Exit For
                End If
            Next
            'Texto
            If i = Loteria.seleccion.Count - 1 Then
                .Text = "R: "
                .BorderStyle = BorderStyle.FixedSingle
                .BackColor = Color.Red
                .Font = New System.Drawing.Font("Arial", 15, FontStyle.Bold)
            End If
            .Text = .Text + Loteria.seleccion(i).ToString
            'Alineación
            .TextAlign = ContentAlignment.MiddleCenter
            'Posicion
            .Location = New Point(x, y)
            x = x + .Width
            .Parent = Me.pnl_seleccion
            
        End With
    End Sub

    Private Sub cargar_datos_combinacion(ByRef i As Integer, ByRef x As Integer)
        Dim num_comb As New Label
        Dim y As Integer
        y = 0
        With num_comb
            'Nombre
            .Name = "lbl_" & i
            .Tag = Loteria.combinacion(i).ToString
            'Tamaño
            .AutoSize = False
            .Width = 50
            .Height = 50
            'Tipo y detalles fuente
            .Font = New System.Drawing.Font("Arial", 20, FontStyle.Bold)
            'Si coincide lo marco en verde
            For j = 0 To Loteria.seleccion.Count - 2
                If Loteria.combinacion(i) = Loteria.seleccion(j) Then
                    .BackColor = Color.Green
                    Exit For
                End If
            Next
            'Texto
            If i = Loteria.combinacion.Count - 1 Then
                .Text = "R: "
                .BorderStyle = BorderStyle.FixedSingle
                .BackColor = Color.Red
                .Font = New System.Drawing.Font("Arial", 15, FontStyle.Bold)
            End If
            .Text = .Text + Loteria.combinacion(i).ToString
            'Alineación
            .TextAlign = ContentAlignment.MiddleCenter
            'Posicion
            .Location = New Point(x, y)
            x = x + .Width
            .Parent = Me.pnl_combinacion
        End With
    End Sub
End Class