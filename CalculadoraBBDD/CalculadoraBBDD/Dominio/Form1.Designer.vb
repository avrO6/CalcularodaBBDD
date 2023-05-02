<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Calcula = New Button()
        Label1 = New Label()
        datoA = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        raiz2 = New TextBox()
        raiz1 = New TextBox()
        datoC = New TextBox()
        datoB = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Button2 = New Button()
        Salir = New Button()
        Label12 = New Label()
        tipo = New TextBox()
        SuspendLayout()
        ' 
        ' Calcula
        ' 
        Calcula.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Calcula.Location = New Point(171, 208)
        Calcula.Name = "Calcula"
        Calcula.Size = New Size(248, 97)
        Calcula.TabIndex = 4
        Calcula.Text = "Calcular"
        Calcula.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(53, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 20)
        Label1.TabIndex = 33
        Label1.Text = "¡BIENVENIDO A LA CALCULADORA DE ECUACIONES DE SEGUNDO GRADO!"
        ' 
        ' datoA
        ' 
        datoA.Location = New Point(71, 197)
        datoA.Name = "datoA"
        datoA.Size = New Size(67, 28)
        datoA.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(438, 20)
        Label2.TabIndex = 32
        Label2.Text = "Dada la formula general de las ecuaciones de segundo grado: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(522, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 20)
        Label3.TabIndex = 30
        Label3.Text = "Ax2 + Bx +C = 0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(446, 20)
        Label4.TabIndex = 31
        Label4.Text = "Introduces los valores de los parametros para obtener las raices:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(522, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 20)
        Label5.TabIndex = 6
        Label5.Text = "La solucion es de tipo:"
        ' 
        ' raiz2
        ' 
        raiz2.Location = New Point(583, 265)
        raiz2.Name = "raiz2"
        raiz2.Size = New Size(283, 28)
        raiz2.TabIndex = 7
        ' 
        ' raiz1
        ' 
        raiz1.Location = New Point(583, 217)
        raiz1.Name = "raiz1"
        raiz1.Size = New Size(283, 28)
        raiz1.TabIndex = 8
        ' 
        ' datoC
        ' 
        datoC.Location = New Point(71, 301)
        datoC.Name = "datoC"
        datoC.Size = New Size(67, 28)
        datoC.TabIndex = 3
        ' 
        ' datoB
        ' 
        datoB.Location = New Point(70, 249)
        datoB.Name = "datoB"
        datoB.Size = New Size(67, 28)
        datoB.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(19, 20)
        Label6.TabIndex = 11
        Label6.Text = "A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(43, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(18, 20)
        Label7.TabIndex = 12
        Label7.Text = "B"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(43, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(19, 20)
        Label8.TabIndex = 13
        Label8.Text = "C"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(518, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 20)
        Label9.TabIndex = 14
        Label9.Text = "Raiz1:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(518, 265)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 20)
        Label10.TabIndex = 15
        Label10.Text = "Raiz2:"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(751, 301)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 74)
        Button2.TabIndex = 5
        Button2.Text = "Limpiar los datos"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Salir
        ' 
        Salir.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Salir.Location = New Point(751, 381)
        Salir.Name = "Salir"
        Salir.Size = New Size(115, 30)
        Salir.TabIndex = 6
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(43, 391)
        Label12.Name = "Label12"
        Label12.Size = New Size(485, 20)
        Label12.TabIndex = 19
        Label12.Text = "Calculadora realizada por Álvaro Gª, Adrian Panes y Sergio mendoza"
        ' 
        ' tipo
        ' 
        tipo.BackColor = SystemColors.Menu
        tipo.Location = New Point(685, 172)
        tipo.Name = "tipo"
        tipo.Size = New Size(181, 28)
        tipo.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 450)
        Controls.Add(tipo)
        Controls.Add(Label12)
        Controls.Add(Salir)
        Controls.Add(Button2)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(datoB)
        Controls.Add(datoC)
        Controls.Add(raiz1)
        Controls.Add(raiz2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(datoA)
        Controls.Add(Label1)
        Controls.Add(Calcula)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Calcula As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents datoA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents raiz2 As TextBox
    Friend WithEvents raiz1 As TextBox
    Friend WithEvents datoC As TextBox
    Friend WithEvents datoB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents tipo As TextBox
End Class
