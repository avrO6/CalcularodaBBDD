Public Class Ecuacion

    'Declaracion de las variables '

    Private a As Double
    Private b As Double
    Private c As Double
    Private rm1 As Double
    Private im1 As Double
    Private rm2 As Double
    Private im2 As Double

    'Properties de las variables de entrada'

    Public Property PropiedadA As Double
        Get
            Return a
        End Get
        Set(ByVal value As Double)
            a = value
        End Set
    End Property

    Public Property PropiedadB As Double
        Get
            Return b
        End Get
        Set(ByVal value As Double)
            b = value
        End Set
    End Property

    Public Property PropiedadC As Double
        Get
            Return c
        End Get
        Set(ByVal value As Double)
            c = value
        End Set
    End Property

    Public Property Rm11 As Double
        Get
            Return Math.Round(rm1, 2)
        End Get
        Set(value As Double)
            rm1 = value
        End Set
    End Property

    Public Property Im11 As Double
        Get
            Return Math.Round(im1, 2)
        End Get
        Set(value As Double)
            im1 = value
        End Set
    End Property

    Public Property Rm21 As Double
        Get
            Return Math.Round(rm2, 2)
        End Get
        Set(value As Double)
            rm2 = value
        End Set
    End Property

    Public Property Im21 As Double
        Get
            Return Math.Round(im2, 2)
        End Get
        Set(value As Double)
            im2 = value
        End Set
    End Property


    'Constructor de la clase Ecuacion'
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
            Rm11 = (-b + Math.Sqrt(discriminante)) / (2 * a)
            Rm21 = (-b - Math.Sqrt(discriminante)) / (2 * a)

        ElseIf discriminante = 0 Then
            'te dice si la ecuación tiene una solución real'
            Rm11 = (-b + Math.Sqrt(discriminante)) / (2 * a)
            Rm21 = (-b - Math.Sqrt(discriminante)) / (2 * a)
        Else
            'te dice si la ecuación tiene soluciones imaginarias'
            Rm11 = -b / (2 * a)
            Rm21 = -b / (2 * a)
            Im11 = Math.Sqrt(-discriminante)
            Im21 = Math.Sqrt(-discriminante)
        End If

        Return discriminante

    End Function

End Class

