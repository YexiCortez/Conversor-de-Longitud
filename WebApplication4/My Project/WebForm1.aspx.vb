Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Entrada.Text = "Milimetros" And Salida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mm"
        ElseIf Entrada.Text = "Milimetros" And Salida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
            lblum.Text = "cm"
        ElseIf Entrada.Text = "Milimetros" And Salida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "m"
        ElseIf Entrada.Text = "Milimetros" And Salida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000
            lblum.Text = "km"
        ElseIf Entrada.Text = "Centimetros" And Salida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
            lblum.Text = "mm"
        ElseIf Entrada.Text = "Centimetros" And Salida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "cm"
        ElseIf Entrada.Text = "Centimetros" And Salida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 100
            lblum.Text = "m"
        ElseIf Entrada.Text = "Centimetros" And Salida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 100000
            lblum.Text = "km"
        ElseIf Entrada.Text = "Metros" And Salida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "mm"
        ElseIf Entrada.Text = "Metros" And Salida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100
            lblum.Text = "cm"
        ElseIf Entrada.Text = "Metros" And Salida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m"
        ElseIf Entrada.Text = "Metros" And Salida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "km"
        ElseIf Entrada.Text = "Kilometros" And Salida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000000
            lblum.Text = "mm"
        ElseIf Entrada.Text = "Kilometros" And Salida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100000
            lblum.Text = "cm"
        ElseIf Entrada.Text = "Kilometros" And Salida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "m"
        ElseIf Entrada.Text = "Kilometros" And Salida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "km"
        End If
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        lblr.Text = ""
        lblum.Text = ""
        txtvalor.Text = ""
    End Sub




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class