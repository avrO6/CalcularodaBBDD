Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcula.Click



        Dim a, b, c, discriminante As Double

        'Leer los valores que introduces en los cuadros de texto'
        If IsNumeric(datoA.Text) And IsNumeric(datoB.Text) And IsNumeric(datoC.Text) Then
            a = CDbl(datoA.Text)
            b = CDbl(datoB.Text)
            c = CDbl(datoC.Text)
        Else
            'Te muestra un mensaje de error si algún valor no es numérico'
            MsgBox("Ingrese valores numéricos para a, b y c")
        End If

        'Calcular el discriminante (la parte de la raiz cuadrada)'
        Dim ecuacion = New Ecuacion(a, b, c)
        discriminante = ecuacion.calcular
        'Comprueba si la ecuación tiene soluciones reales o imaginarias'
        If discriminante > 0 Then
            'Te dice si la ecuación tiene dos soluciones reales'

            raiz1.Text = ecuacion.real1
            raiz2.Text = ecuacion.real2
            tipo.Text = "Soluciones reales"
        ElseIf discriminante = 0 Then
            'te dice si la ecuación tiene una solución real'
            Dim x As Double
            x = -b / (2 * a)
            raiz1.Text = x.ToString
            raiz2.Text = ""
            tipo.Text = "Solución real"
        Else
            'te dice si la ecuación tiene soluciones imaginarias'
            Dim parteReal, parteImaginaria As Double
            parteReal = -b / (2 * a)
            parteImaginaria = Math.Sqrt(-discriminante) / (2 * a)
            raiz1.Text = parteReal.ToString & " + " & parteImaginaria.ToString & "i"
            raiz2.Text = parteReal.ToString & " - " & parteImaginaria.ToString & "i"
            tipo.Text = "Soluciones imaginarias"
        End If

    End Sub



    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles datoC.TextChanged

    End Sub

    'Codigo del boton de limpiar los datos'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datoA.Clear()
        datoB.Clear()
        datoC.Clear()
        raiz1.Clear()
        raiz2.Clear()
        tipo.Clear()
    End Sub
End Class
