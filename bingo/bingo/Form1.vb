Public Class frmBingo
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resp
        resp = MsgBox("¿Realmente desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sr. Usuario")
        If resp = vbYes Then
            End
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If btn1.BackColor = Color.Violet Then
            btn1.BackColor = Color.White
            LBIngresados.Items.Remove(btn1.Text)

        Else
            btn1.BackColor = Color.Violet
            LBIngresados.Items.Add(btn1.Text)

        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.BackColor = Color.Violet Then
            btn2.BackColor = Color.White
            LBIngresados.Items.Remove(btn2.Text)

        Else
            btn2.BackColor = Color.Violet
            LBIngresados.Items.Add(btn2.Text)

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn3.BackColor = Color.Violet Then
            btn3.BackColor = Color.White
            LBIngresados.Items.Remove(btn3.Text)

        Else
            btn3.BackColor = Color.Violet
            LBIngresados.Items.Add(btn3.Text)

        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn4.BackColor = Color.Violet Then
            btn4.BackColor = Color.White
            LBIngresados.Items.Remove(btn4.Text)

        Else
            btn4.BackColor = Color.Violet
            LBIngresados.Items.Add(btn4.Text)

        End If
    End Sub

    Private Sub btnLinea_Click(sender As Object, e As EventArgs) Handles btnLinea.Click
        MsgBox("LINEA", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Sr. Usuario")
    End Sub

    Private Sub btnBingo_Click(sender As Object, e As EventArgs) Handles btnBingo.Click
        If LBIngresados.Items.Count = 0 Then
            MsgBox("¿Cómo puede haber alguien hecho Bingo si todavía no salió si quiera un número? Intente otra vez.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Usuario:")

        Else
            MsgBox("Se ha ganado, ¡BINGO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Usuario Ganador")
            End
        End If


    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn5.BackColor = Color.Violet Then
            btn5.BackColor = Color.White
            LBIngresados.Items.Remove(btn5.Text)

        Else
            btn5.BackColor = Color.Violet
            LBIngresados.Items.Add(btn5.Text)

        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btn6.BackColor = Color.Violet Then
            btn6.BackColor = Color.White
            LBIngresados.Items.Remove(btn6.Text)

        Else
            btn6.BackColor = Color.Violet
            LBIngresados.Items.Add(btn6.Text)

        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn7.BackColor = Color.Violet Then
            btn7.BackColor = Color.White
            LBIngresados.Items.Remove(btn7.Text)

        Else
            btn7.BackColor = Color.Violet
            LBIngresados.Items.Add(btn7.Text)

        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btn8.BackColor = Color.Violet Then
            btn8.BackColor = Color.White
            LBIngresados.Items.Remove(btn8.Text)

        Else
            btn8.BackColor = Color.Violet
            LBIngresados.Items.Add(btn8.Text)

        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If btn9.BackColor = Color.Violet Then
            btn9.BackColor = Color.White
            LBIngresados.Items.Remove(btn9.Text)

        Else
            btn9.BackColor = Color.Violet
            LBIngresados.Items.Add(btn9.Text)

        End If
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If btn10.BackColor = Color.Violet Then
            btn10.BackColor = Color.White
            LBIngresados.Items.Remove(btn10.Text)

        Else
            btn10.BackColor = Color.Violet
            LBIngresados.Items.Add(btn10.Text)

        End If
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If btn11.BackColor = Color.Violet Then
            btn11.BackColor = Color.White
            LBIngresados.Items.Remove(btn11.Text)

        Else
            btn11.BackColor = Color.Violet
            LBIngresados.Items.Add(btn11.Text)

        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If btn12.BackColor = Color.Violet Then
            btn12.BackColor = Color.White
            LBIngresados.Items.Remove(btn12.Text)

        Else
            btn12.BackColor = Color.Violet
            LBIngresados.Items.Add(btn12.Text)

        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If btn13.BackColor = Color.Violet Then
            btn13.BackColor = Color.White
            LBIngresados.Items.Remove(btn13.Text)

        Else
            btn13.BackColor = Color.Violet
            LBIngresados.Items.Add(btn13.Text)

        End If
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        If btn14.BackColor = Color.Violet Then
            btn14.BackColor = Color.White
            LBIngresados.Items.Remove(btn14.Text)

        Else
            btn14.BackColor = Color.Violet
            LBIngresados.Items.Add(btn14.Text)

        End If
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        If btn15.BackColor = Color.Violet Then
            btn15.BackColor = Color.White
            LBIngresados.Items.Remove(btn15.Text)

        Else
            btn15.BackColor = Color.Violet
            LBIngresados.Items.Add(btn15.Text)

        End If
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        If btn16.BackColor = Color.Violet Then
            btn16.BackColor = Color.White
            LBIngresados.Items.Remove(btn16.Text)

        Else
            btn16.BackColor = Color.Violet
            LBIngresados.Items.Add(btn16.Text)

        End If
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        If btn17.BackColor = Color.Violet Then
            btn17.BackColor = Color.White
            LBIngresados.Items.Remove(btn17.Text)

        Else
            btn17.BackColor = Color.Violet
            LBIngresados.Items.Add(btn17.Text)

        End If
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        If btn18.BackColor = Color.Violet Then
            btn18.BackColor = Color.White
            LBIngresados.Items.Remove(btn18.Text)

        Else
            btn18.BackColor = Color.Violet
            LBIngresados.Items.Add(btn18.Text)

        End If
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        If btn19.BackColor = Color.Violet Then
            btn19.BackColor = Color.White
            LBIngresados.Items.Remove(btn19.Text)

        Else
            btn19.BackColor = Color.Violet
            LBIngresados.Items.Add(btn19.Text)

        End If
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        If btn20.BackColor = Color.Violet Then
            btn20.BackColor = Color.White
            LBIngresados.Items.Remove(btn20.Text)

        Else
            btn20.BackColor = Color.Violet
            LBIngresados.Items.Add(btn20.Text)

        End If
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If btn21.BackColor = Color.Violet Then
            btn21.BackColor = Color.White
            LBIngresados.Items.Remove(btn21.Text)

        Else
            btn21.BackColor = Color.Violet
            LBIngresados.Items.Add(btn21.Text)

        End If
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If btn22.BackColor = Color.Violet Then
            btn22.BackColor = Color.White
            LBIngresados.Items.Remove(btn22.Text)

        Else
            btn22.BackColor = Color.Violet
            LBIngresados.Items.Add(btn22.Text)

        End If

    End Sub
End Class
