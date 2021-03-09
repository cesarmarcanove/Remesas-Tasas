Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim env As Double
        Dim p As Double
        Dim rem1 As Double
        Dim rem2 As Double
        Dim tasa1 As Double
        Dim tasa2 As Double
        Dim unit As Double

        ' Cantidad de personas
        ' backup: p <- 8;

        ' Tasa pais emisor
        'tasa1 = 20

        ' Tasa Pais recibidor
        'tasa2 = 10

        'Ingreso de Datos
        env = Val(TextCOST.Text) 
        p = Val(TextSELL.Text)
        tasa1 = Val(TextMAR.Text)
        tasa2 = Val(TextPOR.Text)

        'Calculo del Margen de Ganancia

        ' Calculos

        ' Dividiendo la cantidad de remesa por cada 8 personas
        unit = env / p

        ' Resta de remesa en el pais emisor
        rem1 = (unit - tasa1)

        ' Resta de remesa en el pais recibidor
        rem2 = (rem1 - tasa2)

        'Salida de Datos
        TextMAR.Text = Math.Round(Convert.ToDouble(tasa1), 2) & " $"
        TextPOR.Text = Math.Round(Convert.ToDouble(tasa2), 2) & " $"
        TextCAN.Text = Math.Round(Convert.ToDouble(unit), 2) & " $"
        TextRem1.Text = Math.Round(Convert.ToDouble(rem1), 2) & " $"
        TextRem2.Text = Math.Round(Convert.ToDouble(rem2), 2) & " $"
        TextDIF.Text = Math.Round(Convert.ToDouble(rem2), 2) & " $"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Limpiar en los ingresos de datos
        TextCOST.Text = " 600 "
        'TextSELL.Text = " 0.0 "
        TextCAN.Text = " 0.0 "


        'Limpiar Pantalla en los resultados
        TextMAR.Text = " 0.0 "
        TextPOR.Text = " 0.0 "
        TextDIF.Text = " 0.0 "
        TextRem1.Text = " 0.0 "
        TextRem2.Text = " 0.0 "
        TextCOST.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
