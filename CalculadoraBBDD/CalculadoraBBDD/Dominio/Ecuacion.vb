Public Class Ecuacion

    Private a As Double
    Private b As Double
    Private c As Double
    Private rm1 As Double
    Private im1 As Double
    Private rm2 As Double
    Private mi2 As Double


    Public Sub New(ByVal a As Double, ByVal b As Double, ByVal c As Double)
        Me.a = a
        Me.b = b
        Me.c = c
    End Sub

    Function calcular() As Double



        'Calcular el discriminante (la parte de la raiz cuadrada)'
        Dim discriminante As Double = b ^ 2 - 4 * a * c

        'Comprueba si la ecuación tiene soluciones reales o imaginarias'
        If discriminante > 0 Then
            'Te dice si la ecuación tiene dos soluciones reales'
            rm1 = (-b + Math.Sqrt(discriminante)) / (2 * a)
            rm2 = (-b - Math.Sqrt(discriminante)) / (2 * a)

        ElseIf discriminante = 0 Then
            'te dice si la ecuación tiene una solución real'
            rm1 = (-b + Math.Sqrt(discriminante)) / (2 * a)
            rm2 = (-b - Math.Sqrt(discriminante)) / (2 * a)
        Else
            'te dice si la ecuación tiene soluciones imaginarias'
            rm1 = (-b +) / (2 * a)
            rm2 = (-b - Math.Sqrt(discriminante)) / (2 * a)
            im1
            im2
        End If

        Return Nothing
    End Function

End Class
