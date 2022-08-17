Public Class Form1
    Public MIOS As New Collection
    Public MATRIZ(7, 7) As Integer
    Public BANDERA As Integer
    Public X, Y As Integer
    Public TIRO As Char
    Public CONTADOR As Integer
    Private Sub LimpiarTextBox(ByVal ofrm As Form)
        'Declaramos nuestro metodo que hara la limpieza de los textbox
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is TextBox Then
                oControl.Text = ""
                oControl.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub DISPARO(ByVal XX As Integer, YY As Integer)
        TIRO = "*"
        RESULTADO.Text = ""
        If MATRIZ(XX, YY) = 0 Then
            Me.RESULTADO.Text = "AGUA"
            TIRO = "*"
        End If
        If MATRIZ(XX, YY) = 1 Then
            Me.RESULTADO.Text = "SUBMARINO TOCADO"
            TIRO = "1"
            CONTADOR = CONTADOR + 1
        End If
        If MATRIZ(XX, YY) = 2 Then
            Me.RESULTADO.Text = "DESTRUCTOR TOCADO"
            TIRO = "2"
            CONTADOR = CONTADOR + 1
        End If
        If MATRIZ(XX, YY) = 3 Then
            Me.RESULTADO.Text = "ACORAZADO TOCADO"
            TIRO = "3"
            CONTADOR = CONTADOR + 1
        End If
        If MATRIZ(XX, YY) = 4 Then
            Me.RESULTADO.Text = "PORTAVIONES TOCADO"
            TIRO = "4"
            CONTADOR = CONTADOR + 1
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MIOS.Add(M1.Text)
        MIOS.Add(M2.Text)
        MIOS.Add(M3.Text)
        MIOS.Add(M4.Text)
        MIOS.Add(M5.Text)
        MIOS.Add(M6.Text)
        MIOS.Add(M7.Text)
        MIOS.Add(M8.Text)
        MIOS.Add(M9.Text)
        MIOS.Add(M10.Text)
        MIOS.Add(M11.Text)
        MIOS.Add(M12.Text)
        MIOS.Add(M13.Text)
        MIOS.Add(M14.Text)
        MIOS.Add(M15.Text)
        MIOS.Add(M16.Text)
        MIOS.Add(M17.Text)
        MIOS.Add(M18.Text)
        MIOS.Add(M19.Text)
        MIOS.Add(M20.Text)
        MIOS.Add(M21.Text)
        MIOS.Add(M22.Text)
        MIOS.Add(M23.Text)
        MIOS.Add(M24.Text)
        MIOS.Add(M25.Text)
        MIOS.Add(M26.Text)
        MIOS.Add(M27.Text)
        MIOS.Add(M28.Text)
        MIOS.Add(M29.Text)
        MIOS.Add(M30.Text)
        MIOS.Add(M31.Text)
        MIOS.Add(M32.Text)
        MIOS.Add(M33.Text)
        MIOS.Add(M34.Text)
        MIOS.Add(M35.Text)
        MIOS.Add(M36.Text)
        MIOS.Add(M37.Text)
        MIOS.Add(M38.Text)
        MIOS.Add(M39.Text)
        MIOS.Add(M40.Text)
        MIOS.Add(M41.Text)
        MIOS.Add(M42.Text)
        MIOS.Add(M43.Text)
        MIOS.Add(M44.Text)
        MIOS.Add(M45.Text)
        MIOS.Add(M46.Text)
        MIOS.Add(M47.Text)
        MIOS.Add(M48.Text)
        MIOS.Add(M49.Text)

        For I = 1 To 7 ' 1ª FILA
            MATRIZ(1, I) = Val(MIOS(I))
        Next
        For I = 8 To 14 ' 2ª FILA
            MATRIZ(2, I - 7) = Val(MIOS(I))
        Next
        For I = 15 To 21 ' 3ª FILA
            MATRIZ(3, I - 14) = Val(MIOS(I))
        Next
        For I = 22 To 28 ' 4ª FILA
            MATRIZ(4, I - 21) = Val(MIOS(I))
        Next
        For I = 29 To 35 ' 5ª FILA
            MATRIZ(5, I - 28) = Val(MIOS(I))
        Next
        For I = 36 To 42 ' 6ª FILA
            MATRIZ(6, I - 35) = Val(MIOS(I))
        Next
        For I = 43 To 49 ' 7ª FILA
            MATRIZ(7, I - 42) = Val(MIOS(I))
        Next
        BANDERA = 1
        'Button1.Visible = False

    End Sub



    Private Sub M2_Click(sender As Object, e As EventArgs) Handles M2.Click
        If BANDERA = 1 Then
            X = 1
            Y = 2
            M2.Text = "*"
            DISPARO(X, Y)
            M2.Text = TIRO
            If TIRO <> "*" Then
                M2.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M1_Click(sender As Object, e As EventArgs) Handles M1.Click
        If BANDERA = 1 Then
            X = 1
            Y = 1
            M1.Text = "*"
            DISPARO(X, Y)
            M1.Text = TIRO
            If TIRO <> "*" Then
                M1.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub



    Private Sub M3_Click(sender As Object, e As EventArgs) Handles M3.Click
        If BANDERA = 1 Then
            X = 1
            Y = 3
            M3.Text = "*"
            DISPARO(X, Y)
            M3.Text = TIRO
            If TIRO <> "*" Then
                M3.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M10_Click(sender As Object, e As EventArgs) Handles M10.Click
        If BANDERA = 1 Then
            X = 2
            Y = 3
            M10.Text = "*"
            DISPARO(X, Y)
            M10.Text = TIRO
            If TIRO <> "*" Then
                M10.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M11_Click(sender As Object, e As EventArgs) Handles M11.Click
        If BANDERA = 1 Then
            X = 2
            Y = 4
            M11.Text = "*"
            DISPARO(X, Y)
            M11.Text = TIRO
            If TIRO <> "*" Then
                M11.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M12_Click(sender As Object, e As EventArgs) Handles M12.Click
        If BANDERA = 1 Then
            X = 2
            Y = 5
            M12.Text = "*"
            DISPARO(X, Y)
            M12.Text = TIRO
            If TIRO <> "*" Then
                M12.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M13_Click(sender As Object, e As EventArgs) Handles M13.Click
        If BANDERA = 1 Then
            X = 2
            Y = 6
            M13.Text = "*"
            DISPARO(X, Y)
            M13.Text = TIRO
            If TIRO <> "*" Then
                M13.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M14_Click(sender As Object, e As EventArgs) Handles M14.Click
        If BANDERA = 1 Then
            X = 2
            Y = 7
            M14.Text = "*"
            DISPARO(X, Y)
            M14.Text = TIRO
            If TIRO <> "*" Then
                M14.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M15_Click(sender As Object, e As EventArgs) Handles M15.Click
        If BANDERA = 1 Then
            X = 3
            Y = 1
            M15.Text = "*"
            DISPARO(X, Y)
            M15.Text = TIRO
            If TIRO <> "*" Then
                M15.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M16_Click(sender As Object, e As EventArgs) Handles M16.Click
        If BANDERA = 1 Then
            X = 3
            Y = 2
            M16.Text = "*"
            DISPARO(X, Y)
            M16.Text = TIRO
            If TIRO <> "*" Then
                M16.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M17_Click(sender As Object, e As EventArgs) Handles M17.Click
        If BANDERA = 1 Then
            X = 3
            Y = 3
            M17.Text = "*"
            DISPARO(X, Y)
            M17.Text = TIRO
            If TIRO <> "*" Then
                M17.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M18_Click(sender As Object, e As EventArgs) Handles M18.Click
        If BANDERA = 1 Then
            X = 3
            Y = 4
            M18.Text = "*"
            DISPARO(X, Y)
            M18.Text = TIRO
            If TIRO <> "*" Then
                M18.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M19_Click(sender As Object, e As EventArgs) Handles M19.Click
        If BANDERA = 1 Then
            X = 3
            Y = 5
            M19.Text = "*"
            DISPARO(X, Y)
            M19.Text = TIRO
            If TIRO <> "*" Then
                M19.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M20_Click(sender As Object, e As EventArgs) Handles M20.Click
        If BANDERA = 1 Then
            X = 3
            Y = 6
            M20.Text = "*"
            DISPARO(X, Y)
            M20.Text = TIRO
            If TIRO <> "*" Then
                M20.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M21_Click(sender As Object, e As EventArgs) Handles M21.Click
        If BANDERA = 1 Then
            X = 3
            Y = 7
            M21.Text = "*"
            DISPARO(X, Y)
            M21.Text = TIRO
            If TIRO <> "*" Then
                M21.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M22_Click(sender As Object, e As EventArgs) Handles M22.Click
        If BANDERA = 1 Then
            X = 4
            Y = 1
            M22.Text = "*"
            DISPARO(X, Y)
            M22.Text = TIRO
            If TIRO <> "*" Then
                M22.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M23_Click(sender As Object, e As EventArgs) Handles M23.Click
        If BANDERA = 1 Then
            X = 4
            Y = 2
            M23.Text = "*"
            DISPARO(X, Y)
            M23.Text = TIRO
            If TIRO <> "*" Then
                M23.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M24_Click(sender As Object, e As EventArgs) Handles M24.Click
        If BANDERA = 1 Then
            X = 4
            Y = 3
            M24.Text = "*"
            DISPARO(X, Y)
            M24.Text = TIRO
            If TIRO <> "*" Then
                M24.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M25_Click(sender As Object, e As EventArgs) Handles M25.Click
        If BANDERA = 1 Then
            X = 4
            Y = 4
            M25.Text = "*"
            DISPARO(X, Y)
            M25.Text = TIRO
            If TIRO <> "*" Then
                M25.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M26_Click(sender As Object, e As EventArgs) Handles M26.Click
        If BANDERA = 1 Then
            X = 4
            Y = 5
            M26.Text = "*"
            DISPARO(X, Y)
            M26.Text = TIRO
            If TIRO <> "*" Then
                M26.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M27_Click(sender As Object, e As EventArgs) Handles M27.Click
        If BANDERA = 1 Then
            X = 4
            Y = 6
            M27.Text = "*"
            DISPARO(X, Y)
            M27.Text = TIRO
            If TIRO <> "*" Then
                M27.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M28_Click(sender As Object, e As EventArgs) Handles M28.Click
        If BANDERA = 1 Then
            X = 4
            Y = 7
            M28.Text = "*"
            DISPARO(X, Y)
            M28.Text = TIRO
            If TIRO <> "*" Then
                M28.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M29_Click(sender As Object, e As EventArgs) Handles M29.Click
        If BANDERA = 1 Then
            X = 5
            Y = 1
            M29.Text = "*"
            DISPARO(X, Y)
            M29.Text = TIRO
            If TIRO <> "*" Then
                M29.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M30_Click(sender As Object, e As EventArgs) Handles M30.Click
        If BANDERA = 1 Then
            X = 5
            Y = 2
            M30.Text = "*"
            DISPARO(X, Y)
            M30.Text = TIRO
            If TIRO <> "*" Then
                M30.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M31_Click(sender As Object, e As EventArgs) Handles M31.Click
        If BANDERA = 1 Then
            X = 5
            Y = 3
            M31.Text = "*"
            DISPARO(X, Y)
            M31.Text = TIRO
            If TIRO <> "*" Then
                M31.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M32_Click(sender As Object, e As EventArgs) Handles M32.Click
        If BANDERA = 1 Then
            X = 5
            Y = 4
            M32.Text = "*"
            DISPARO(X, Y)
            M32.Text = TIRO
            If TIRO <> "*" Then
                M32.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M33_Click(sender As Object, e As EventArgs) Handles M33.Click
        If BANDERA = 1 Then
            X = 5
            Y = 5
            M33.Text = "*"
            DISPARO(X, Y)
            M33.Text = TIRO
            If TIRO <> "*" Then
                M33.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M34_Click(sender As Object, e As EventArgs) Handles M34.Click
        If BANDERA = 1 Then
            X = 5
            Y = 6
            M34.Text = "*"
            DISPARO(X, Y)
            M34.Text = TIRO
            If TIRO <> "*" Then
                M34.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M35_Click(sender As Object, e As EventArgs) Handles M35.Click
        If BANDERA = 1 Then
            X = 5
            Y = 7
            M35.Text = "*"
            DISPARO(X, Y)
            M35.Text = TIRO
            If TIRO <> "*" Then
                M35.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M36_Click(sender As Object, e As EventArgs) Handles M36.Click
        If BANDERA = 1 Then
            X = 6
            Y = 1
            M36.Text = "*"
            DISPARO(X, Y)
            M36.Text = TIRO
            If TIRO <> "*" Then
                M36.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M37_Click(sender As Object, e As EventArgs) Handles M37.Click
        If BANDERA = 1 Then
            X = 6
            Y = 2
            M37.Text = "*"
            DISPARO(X, Y)
            M37.Text = TIRO
            If TIRO <> "*" Then
                M37.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M38_Click(sender As Object, e As EventArgs) Handles M38.Click
        If BANDERA = 1 Then
            X = 6
            Y = 3
            M38.Text = "*"
            DISPARO(X, Y)
            M38.Text = TIRO
            If TIRO <> "*" Then
                M38.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M39_Click(sender As Object, e As EventArgs) Handles M39.Click
        If BANDERA = 1 Then
            X = 6
            Y = 4
            M39.Text = "*"
            DISPARO(X, Y)
            M39.Text = TIRO
            If TIRO <> "*" Then
                M39.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M4_Click(sender As Object, e As EventArgs) Handles M4.Click
        If BANDERA = 1 Then
            X = 1
            Y = 4
            M4.Text = "*"
            DISPARO(X, Y)
            M4.Text = TIRO
            If TIRO <> "*" Then
                M4.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M40_Click(sender As Object, e As EventArgs) Handles M40.Click
        If BANDERA = 1 Then
            X = 6
            Y = 5
            M40.Text = "*"
            DISPARO(X, Y)
            M40.Text = TIRO
            If TIRO <> "*" Then
                M40.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M41_Click(sender As Object, e As EventArgs) Handles M41.Click
        If BANDERA = 1 Then
            X = 6
            Y = 6
            M41.Text = "*"
            DISPARO(X, Y)
            M41.Text = TIRO
            If TIRO <> "*" Then
                M41.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M42_Click(sender As Object, e As EventArgs) Handles M42.Click
        If BANDERA = 1 Then
            X = 6
            Y = 7
            M42.Text = "*"
            DISPARO(X, Y)
            M42.Text = TIRO
            If TIRO <> "*" Then
                M42.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M43_Click(sender As Object, e As EventArgs) Handles M43.Click
        If BANDERA = 1 Then
            X = 7
            Y = 1
            M43.Text = "*"
            DISPARO(X, Y)
            M43.Text = TIRO
            If TIRO <> "*" Then
                M43.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M44_Click(sender As Object, e As EventArgs) Handles M44.Click
        If BANDERA = 1 Then
            X = 7
            Y = 2
            M44.Text = "*"
            DISPARO(X, Y)
            M44.Text = TIRO
            If TIRO <> "*" Then
                M44.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M45_Click(sender As Object, e As EventArgs) Handles M45.Click
        If BANDERA = 1 Then
            X = 7
            Y = 3
            M45.Text = "*"
            DISPARO(X, Y)
            M45.Text = TIRO
            If TIRO <> "*" Then
                M45.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M46_Click(sender As Object, e As EventArgs) Handles M46.Click
        If BANDERA = 1 Then
            X = 7
            Y = 4
            M46.Text = "*"
            DISPARO(X, Y)
            M46.Text = TIRO
            If TIRO <> "*" Then
                M46.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M47_Click(sender As Object, e As EventArgs) Handles M47.Click
        If BANDERA = 1 Then
            X = 7
            Y = 5
            M47.Text = "*"
            DISPARO(X, Y)
            M47.Text = TIRO
            If TIRO <> "*" Then
                M47.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M48_Click(sender As Object, e As EventArgs) Handles M48.Click
        If BANDERA = 1 Then
            X = 7
            Y = 6
            M48.Text = "*"
            DISPARO(X, Y)
            M48.Text = TIRO
            If TIRO <> "*" Then
                M48.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M49_Click(sender As Object, e As EventArgs) Handles M49.Click
        If BANDERA = 1 Then
            X = 7
            Y = 7
            M49.Text = "*"
            DISPARO(X, Y)
            M49.Text = TIRO
            If TIRO <> "*" Then
                M49.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub



    Private Sub M5_Click(sender As Object, e As EventArgs) Handles M5.Click
        If BANDERA = 1 Then
            X = 1
            Y = 5
            M5.Text = "*"
            DISPARO(X, Y)
            M5.Text = TIRO
            If TIRO <> "*" Then
                M5.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M6_Click(sender As Object, e As EventArgs) Handles M6.Click
        If BANDERA = 1 Then
            X = 1
            Y = 6
            M6.Text = "*"
            DISPARO(X, Y)
            M6.Text = TIRO
            If TIRO <> "*" Then
                M6.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M7_Click(sender As Object, e As EventArgs) Handles M7.Click
        If BANDERA = 1 Then
            X = 1
            Y = 7
            M7.Text = "*"
            DISPARO(X, Y)
            M7.Text = TIRO
            If TIRO <> "*" Then
                M7.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub M8_Click(sender As Object, e As EventArgs) Handles M8.Click
        If BANDERA = 1 Then
            X = 2
            Y = 1
            M8.Text = "*"
            DISPARO(X, Y)
            M8.Text = TIRO
            If TIRO <> "*" Then
                M8.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        CONTADOR = 0
        BANDERA = 0
        TIRO = "*"
        For X = 1 To 7
            For Y = 1 To 7
                MATRIZ(X, Y) = 0
            Next
        Next
        Call LimpiarTextBox(Me)
        M1.Text = ""

    End Sub



    Private Sub M9_Click(sender As Object, e As EventArgs) Handles M9.Click
        If BANDERA = 1 Then
            X = 2
            Y = 2
            M9.Text = "*"
            DISPARO(X, Y)
            M9.Text = TIRO
            If TIRO <> "*" Then
                M9.BackColor = Color.Blue
            End If
            If CONTADOR = 10 Then RESULTADO.Text = "GAME OVER"
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = "*"
    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TextBox1.Text = "T"
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = "*"
    End Sub

    Private Sub TextBox2_DoubleClick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
        TextBox2.Text = "T"
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Text = "*"
    End Sub

    Private Sub TextBox3_DoubleClick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        TextBox3.Text = "T"
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Text = "*"
    End Sub

    Private Sub TextBox4_DoubleClick(sender As Object, e As EventArgs) Handles TextBox4.DoubleClick
        TextBox4.Text = "T"
    End Sub
    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.Text = "*"
    End Sub

    Private Sub TextBox5_DoubleClick(sender As Object, e As EventArgs) Handles TextBox5.DoubleClick
        TextBox5.Text = "T"
    End Sub
    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.Text = "*"
    End Sub

    Private Sub TextBox6_DoubleClick(sender As Object, e As EventArgs) Handles TextBox6.DoubleClick
        TextBox6.Text = "T"
    End Sub
    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        TextBox7.Text = "*"
    End Sub

    Private Sub TextBox7_DoubleClick(sender As Object, e As EventArgs) Handles TextBox7.DoubleClick
        TextBox7.Text = "T"
    End Sub
    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        TextBox8.Text = "*"
    End Sub

    Private Sub TextBox8_DoubleClick(sender As Object, e As EventArgs) Handles TextBox8.DoubleClick
        TextBox8.Text = "T"
    End Sub
    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        TextBox9.Text = "*"
    End Sub

    Private Sub TextBox9_DoubleClick(sender As Object, e As EventArgs) Handles TextBox9.DoubleClick
        TextBox9.Text = "T"
    End Sub
    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.Text = "*"
    End Sub

    Private Sub TextBox10_DoubleClick(sender As Object, e As EventArgs) Handles TextBox10.DoubleClick
        TextBox10.Text = "T"
    End Sub
    Private Sub TextBox11_Click(sender As Object, e As EventArgs) Handles TextBox11.Click
        TextBox11.Text = "*"
    End Sub
    Private Sub TextBox11_DoubleClick(sender As Object, e As EventArgs) Handles TextBox11.DoubleClick
        TextBox11.Text = "T"
    End Sub
    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        TextBox12.Text = "*"
    End Sub

    Private Sub TextBox12_DoubleClick(sender As Object, e As EventArgs) Handles TextBox12.DoubleClick
        TextBox12.Text = "T"
    End Sub
    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        TextBox13.Text = "*"
    End Sub

    Private Sub TextBox13_DoubleClick(sender As Object, e As EventArgs) Handles TextBox13.DoubleClick
        TextBox13.Text = "T"
    End Sub
    Private Sub TextBox14_Click(sender As Object, e As EventArgs) Handles TextBox14.Click
        TextBox14.Text = "*"
    End Sub

    Private Sub TextBox14_DoubleClick(sender As Object, e As EventArgs) Handles TextBox14.DoubleClick
        TextBox14.Text = "T"
    End Sub
    Private Sub TextBox15_Click(sender As Object, e As EventArgs) Handles TextBox15.Click
        TextBox15.Text = "*"
    End Sub

    Private Sub TextBox15_DoubleClick(sender As Object, e As EventArgs) Handles TextBox15.DoubleClick
        TextBox15.Text = "T"
    End Sub
    Private Sub TextBox16_Click(sender As Object, e As EventArgs) Handles TextBox16.Click
        TextBox16.Text = "*"
    End Sub

    Private Sub TextBox16_DoubleClick(sender As Object, e As EventArgs) Handles TextBox16.DoubleClick
        TextBox16.Text = "T"
    End Sub
    Private Sub TextBox17_Click(sender As Object, e As EventArgs) Handles TextBox17.Click
        TextBox17.Text = "*"
    End Sub

    Private Sub TextBox17_DoubleClick(sender As Object, e As EventArgs) Handles TextBox17.DoubleClick
        TextBox17.Text = "T"
    End Sub
    Private Sub TextBox18_Click(sender As Object, e As EventArgs) Handles TextBox18.Click
        TextBox18.Text = "*"
    End Sub

    Private Sub TextBox18_DoubleClick(sender As Object, e As EventArgs) Handles TextBox18.DoubleClick
        TextBox18.Text = "T"
    End Sub
    Private Sub TextBox19_Click(sender As Object, e As EventArgs) Handles TextBox19.Click
        TextBox19.Text = "*"
    End Sub

    Private Sub TextBox19_DoubleClick(sender As Object, e As EventArgs) Handles TextBox19.DoubleClick
        TextBox19.Text = "T"
    End Sub
    Private Sub TextBox20_Click(sender As Object, e As EventArgs) Handles TextBox20.Click
        TextBox20.Text = "*"
    End Sub

    Private Sub TextBox20_DoubleClick(sender As Object, e As EventArgs) Handles TextBox20.DoubleClick
        TextBox20.Text = "T"
    End Sub
    Private Sub TextBox21_Click(sender As Object, e As EventArgs) Handles TextBox21.Click
        TextBox21.Text = "*"
    End Sub

    Private Sub TextBox21_DoubleClick(sender As Object, e As EventArgs) Handles TextBox21.DoubleClick
        TextBox21.Text = "T"
    End Sub

    Private Sub TextBox22_Click(sender As Object, e As EventArgs) Handles TextBox22.Click
        TextBox22.Text = "*"
    End Sub

    Private Sub TextBox22_DoubleClick(sender As Object, e As EventArgs) Handles TextBox22.DoubleClick
        TextBox22.Text = "T"
    End Sub
    Private Sub TextBox23_Click(sender As Object, e As EventArgs) Handles TextBox23.Click
        TextBox23.Text = "*"
    End Sub

    Private Sub TextBox23_DoubleClick(sender As Object, e As EventArgs) Handles TextBox23.DoubleClick
        TextBox23.Text = "T"
    End Sub
    Private Sub TextBox24_Click(sender As Object, e As EventArgs) Handles TextBox24.Click
        TextBox24.Text = "*"
    End Sub

    Private Sub TextBox24_DoubleClick(sender As Object, e As EventArgs) Handles TextBox24.DoubleClick
        TextBox24.Text = "T"
    End Sub
    Private Sub TextBox25_Click(sender As Object, e As EventArgs) Handles TextBox25.Click
        TextBox25.Text = "*"
    End Sub

    Private Sub TextBox25_DoubleClick(sender As Object, e As EventArgs) Handles TextBox25.DoubleClick
        TextBox25.Text = "T"
    End Sub
    Private Sub TextBox26_Click(sender As Object, e As EventArgs) Handles TextBox26.Click
        TextBox26.Text = "*"
    End Sub

    Private Sub TextBox26_DoubleClick(sender As Object, e As EventArgs) Handles TextBox26.DoubleClick
        TextBox26.Text = "T"
    End Sub
    Private Sub TextBox27_Click(sender As Object, e As EventArgs) Handles TextBox27.Click
        TextBox27.Text = "*"
    End Sub

    Private Sub TextBox27_DoubleClick(sender As Object, e As EventArgs) Handles TextBox27.DoubleClick
        TextBox27.Text = "T"
    End Sub
    Private Sub TextBox28_Click(sender As Object, e As EventArgs) Handles TextBox28.Click
        TextBox28.Text = "*"
    End Sub

    Private Sub TextBox28_DoubleClick(sender As Object, e As EventArgs) Handles TextBox28.DoubleClick
        TextBox28.Text = "T"
    End Sub
    Private Sub TextBox29_Click(sender As Object, e As EventArgs) Handles TextBox29.Click
        TextBox29.Text = "*"
    End Sub

    Private Sub TextBox29_DoubleClick(sender As Object, e As EventArgs) Handles TextBox29.DoubleClick
        TextBox29.Text = "T"
    End Sub
    Private Sub TextBox30_Click(sender As Object, e As EventArgs) Handles TextBox30.Click
        TextBox30.Text = "*"
    End Sub

    Private Sub TextBox30_DoubleClick(sender As Object, e As EventArgs) Handles TextBox30.DoubleClick
        TextBox30.Text = "T"
    End Sub
    Private Sub TextBox31_Click(sender As Object, e As EventArgs) Handles TextBox31.Click
        TextBox31.Text = "*"
    End Sub

    Private Sub TextBox31_DoubleClick(sender As Object, e As EventArgs) Handles TextBox31.DoubleClick
        TextBox31.Text = "T"
    End Sub

    Private Sub TextBox32_Click(sender As Object, e As EventArgs) Handles TextBox32.Click
        TextBox32.Text = "*"
    End Sub

    Private Sub TextBox32_DoubleClick(sender As Object, e As EventArgs) Handles TextBox32.DoubleClick
        TextBox32.Text = "T"
    End Sub
    Private Sub TextBox33_Click(sender As Object, e As EventArgs) Handles TextBox33.Click
        TextBox33.Text = "*"
    End Sub

    Private Sub TextBox33_DoubleClick(sender As Object, e As EventArgs) Handles TextBox33.DoubleClick
        TextBox33.Text = "T"
    End Sub
    Private Sub TextBox34_Click(sender As Object, e As EventArgs) Handles TextBox34.Click
        TextBox34.Text = "*"
    End Sub

    Private Sub TextBox34_DoubleClick(sender As Object, e As EventArgs) Handles TextBox34.DoubleClick
        TextBox34.Text = "T"
    End Sub
    Private Sub TextBox35_Click(sender As Object, e As EventArgs) Handles TextBox35.Click
        TextBox35.Text = "*"
    End Sub

    Private Sub TextBox35_DoubleClick(sender As Object, e As EventArgs) Handles TextBox35.DoubleClick
        TextBox35.Text = "T"
    End Sub
    Private Sub TextBox36_Click(sender As Object, e As EventArgs) Handles TextBox36.Click
        TextBox36.Text = "*"
    End Sub

    Private Sub TextBox36_DoubleClick(sender As Object, e As EventArgs) Handles TextBox36.DoubleClick
        TextBox36.Text = "T"
    End Sub
    Private Sub TextBox37_Click(sender As Object, e As EventArgs) Handles TextBox37.Click
        TextBox37.Text = "*"
    End Sub

    Private Sub TextBox37_DoubleClick(sender As Object, e As EventArgs) Handles TextBox37.DoubleClick
        TextBox37.Text = "T"
    End Sub
    Private Sub TextBox38_Click(sender As Object, e As EventArgs) Handles TextBox38.Click
        TextBox38.Text = "*"
    End Sub

    Private Sub TextBox38_DoubleClick(sender As Object, e As EventArgs) Handles TextBox38.DoubleClick
        TextBox38.Text = "T"
    End Sub
    Private Sub TextBox39_Click(sender As Object, e As EventArgs) Handles TextBox39.Click
        TextBox39.Text = "*"
    End Sub

    Private Sub TextBox39_DoubleClick(sender As Object, e As EventArgs) Handles TextBox39.DoubleClick
        TextBox39.Text = "T"
    End Sub
    Private Sub TextBox40_Click(sender As Object, e As EventArgs) Handles TextBox40.Click
        TextBox40.Text = "*"
    End Sub

    Private Sub TextBox40_DoubleClick(sender As Object, e As EventArgs) Handles TextBox40.DoubleClick
        TextBox40.Text = "T"
    End Sub

    Private Sub TextBox41_Click(sender As Object, e As EventArgs) Handles TextBox41.Click
        TextBox41.Text = "*"
    End Sub

    Private Sub TextBox41_DoubleClick(sender As Object, e As EventArgs) Handles TextBox41.DoubleClick
        TextBox41.Text = "T"
    End Sub
    Private Sub TextBox42_Click(sender As Object, e As EventArgs) Handles TextBox42.Click
        TextBox42.Text = "*"
    End Sub

    Private Sub TextBox42_DoubleClick(sender As Object, e As EventArgs) Handles TextBox42.DoubleClick
        TextBox42.Text = "T"
    End Sub
    Private Sub TextBox43_Click(sender As Object, e As EventArgs) Handles TextBox43.Click
        TextBox43.Text = "*"
    End Sub

    Private Sub TextBox43_DoubleClick(sender As Object, e As EventArgs) Handles TextBox43.DoubleClick
        TextBox43.Text = "T"
    End Sub
    Private Sub TextBox44_Click(sender As Object, e As EventArgs) Handles TextBox44.Click
        TextBox44.Text = "*"
    End Sub

    Private Sub TextBox44_DoubleClick(sender As Object, e As EventArgs) Handles TextBox44.DoubleClick
        TextBox44.Text = "T"
    End Sub
    Private Sub TextBox45_Click(sender As Object, e As EventArgs) Handles TextBox45.Click
        TextBox45.Text = "*"
    End Sub

    Private Sub TextBox45_DoubleClick(sender As Object, e As EventArgs) Handles TextBox45.DoubleClick
        TextBox45.Text = "T"
    End Sub
    Private Sub TextBox46_Click(sender As Object, e As EventArgs) Handles TextBox46.Click
        TextBox46.Text = "*"
    End Sub

    Private Sub TextBox46_DoubleClick(sender As Object, e As EventArgs) Handles TextBox46.DoubleClick
        TextBox46.Text = "T"
    End Sub
    Private Sub TextBox47_Click(sender As Object, e As EventArgs) Handles TextBox47.Click
        TextBox47.Text = "*"
    End Sub

    Private Sub TextBox47_DoubleClick(sender As Object, e As EventArgs) Handles TextBox47.DoubleClick
        TextBox47.Text = "T"
    End Sub
    Private Sub TextBox48_Click(sender As Object, e As EventArgs) Handles TextBox48.Click
        TextBox48.Text = "*"
    End Sub

    Private Sub TextBox48_DoubleClick(sender As Object, e As EventArgs) Handles TextBox48.DoubleClick
        TextBox48.Text = "T"
    End Sub
    Private Sub TextBox49_Click(sender As Object, e As EventArgs) Handles TextBox49.Click
        TextBox49.Text = "*"
    End Sub

    Private Sub TextBox49_DoubleClick(sender As Object, e As EventArgs) Handles TextBox49.DoubleClick
        TextBox49.Text = "T"
    End Sub
End Class
