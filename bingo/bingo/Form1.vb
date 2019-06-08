Public Class frmBingo
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resp
        resp = MsgBox("¿Realmente desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sr. Usuario")
        If resp = vbYes Then
            End
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.BackColor = Color.Violet
        LBIngresados.Items.Add(btn1.Text)
        btn1.Enabled = False
        'If btn1.BackColor = Color.Violet Then
        'btn1.BackColor = Color.White
        'LBIngresados.Items.Remove(btn1.Text)
        'End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btn2.BackColor = Color.Violet
        LBIngresados.Items.Add(btn2.Text)
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn3.BackColor = Color.Violet
        LBIngresados.Items.Add(btn3.Text)
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn4.BackColor = Color.Violet
        LBIngresados.Items.Add(btn4.Text)
        btn4.Enabled = False
    End Sub

    Private Sub btnLinea_Click(sender As Object, e As EventArgs) Handles btnLinea.Click
        MsgBox("LINEA", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Sr. Usuario")
    End Sub

    Private Sub btnBingo_Click(sender As Object, e As EventArgs) Handles btnBingo.Click
        MsgBox("Se ha ganado, BINGO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Usuario Ganador")
        End
    End Sub
End Class
