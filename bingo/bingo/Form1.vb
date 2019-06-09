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

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If btn23.BackColor = Color.Violet Then
            btn23.BackColor = Color.White
            LBIngresados.Items.Remove(btn23.Text)

        Else
            btn23.BackColor = Color.Violet
            LBIngresados.Items.Add(btn23.Text)

        End If

    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        If btn24.BackColor = Color.Violet Then
            btn24.BackColor = Color.White
            LBIngresados.Items.Remove(btn24.Text)

        Else
            btn24.BackColor = Color.Violet
            LBIngresados.Items.Add(btn24.Text)

        End If

    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        If btn25.BackColor = Color.Violet Then
            btn25.BackColor = Color.White
            LBIngresados.Items.Remove(btn25.Text)

        Else
            btn25.BackColor = Color.Violet
            LBIngresados.Items.Add(btn25.Text)

        End If

    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        If btn26.BackColor = Color.Violet Then
            btn26.BackColor = Color.White
            LBIngresados.Items.Remove(btn26.Text)

        Else
            btn26.BackColor = Color.Violet
            LBIngresados.Items.Add(btn26.Text)

        End If

    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        If btn27.BackColor = Color.Violet Then
            btn27.BackColor = Color.White
            LBIngresados.Items.Remove(btn27.Text)

        Else
            btn27.BackColor = Color.Violet
            LBIngresados.Items.Add(btn27.Text)

        End If

    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        If btn28.BackColor = Color.Violet Then
            btn28.BackColor = Color.White
            LBIngresados.Items.Remove(btn28.Text)

        Else
            btn28.BackColor = Color.Violet
            LBIngresados.Items.Add(btn28.Text)

        End If

    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        If btn29.BackColor = Color.Violet Then
            btn29.BackColor = Color.White
            LBIngresados.Items.Remove(btn29.Text)

        Else
            btn29.BackColor = Color.Violet
            LBIngresados.Items.Add(btn29.Text)

        End If

    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        If btn30.BackColor = Color.Violet Then
            btn30.BackColor = Color.White
            LBIngresados.Items.Remove(btn30.Text)

        Else
            btn30.BackColor = Color.Violet
            LBIngresados.Items.Add(btn30.Text)

        End If

    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If btn31.BackColor = Color.Violet Then
            btn31.BackColor = Color.White
            LBIngresados.Items.Remove(btn31.Text)

        Else
            btn31.BackColor = Color.Violet
            LBIngresados.Items.Add(btn31.Text)

        End If

    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If btn32.BackColor = Color.Violet Then
            btn32.BackColor = Color.White
            LBIngresados.Items.Remove(btn32.Text)

        Else
            btn32.BackColor = Color.Violet
            LBIngresados.Items.Add(btn32.Text)

        End If

    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If btn33.BackColor = Color.Violet Then
            btn33.BackColor = Color.White
            LBIngresados.Items.Remove(btn33.Text)

        Else
            btn33.BackColor = Color.Violet
            LBIngresados.Items.Add(btn33.Text)

        End If

    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        If btn34.BackColor = Color.Violet Then
            btn34.BackColor = Color.White
            LBIngresados.Items.Remove(btn34.Text)

        Else
            btn34.BackColor = Color.Violet
            LBIngresados.Items.Add(btn34.Text)

        End If

    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        If btn35.BackColor = Color.Violet Then
            btn35.BackColor = Color.White
            LBIngresados.Items.Remove(btn35.Text)

        Else
            btn35.BackColor = Color.Violet
            LBIngresados.Items.Add(btn35.Text)

        End If

    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        If btn36.BackColor = Color.Violet Then
            btn36.BackColor = Color.White
            LBIngresados.Items.Remove(btn36.Text)

        Else
            btn36.BackColor = Color.Violet
            LBIngresados.Items.Add(btn36.Text)

        End If

    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        If btn37.BackColor = Color.Violet Then
            btn37.BackColor = Color.White
            LBIngresados.Items.Remove(btn37.Text)

        Else
            btn37.BackColor = Color.Violet
            LBIngresados.Items.Add(btn37.Text)

        End If

    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        If btn38.BackColor = Color.Violet Then
            btn38.BackColor = Color.White
            LBIngresados.Items.Remove(btn38.Text)

        Else
            btn38.BackColor = Color.Violet
            LBIngresados.Items.Add(btn38.Text)

        End If

    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        If btn39.BackColor = Color.Violet Then
            btn39.BackColor = Color.White
            LBIngresados.Items.Remove(btn39.Text)

        Else
            btn39.BackColor = Color.Violet
            LBIngresados.Items.Add(btn39.Text)

        End If

    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        If btn40.BackColor = Color.Violet Then
            btn40.BackColor = Color.White
            LBIngresados.Items.Remove(btn40.Text)

        Else
            btn40.BackColor = Color.Violet
            LBIngresados.Items.Add(btn40.Text)

        End If

    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        If btn41.BackColor = Color.Violet Then
            btn41.BackColor = Color.White
            LBIngresados.Items.Remove(btn41.Text)

        Else
            btn41.BackColor = Color.Violet
            LBIngresados.Items.Add(btn41.Text)

        End If

    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        If btn42.BackColor = Color.Violet Then
            btn42.BackColor = Color.White
            LBIngresados.Items.Remove(btn42.Text)

        Else
            btn42.BackColor = Color.Violet
            LBIngresados.Items.Add(btn42.Text)

        End If

    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        If btn43.BackColor = Color.Violet Then
            btn43.BackColor = Color.White
            LBIngresados.Items.Remove(btn43.Text)

        Else
            btn43.BackColor = Color.Violet
            LBIngresados.Items.Add(btn43.Text)

        End If

    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        If btn44.BackColor = Color.Violet Then
            btn44.BackColor = Color.White
            LBIngresados.Items.Remove(btn44.Text)

        Else
            btn44.BackColor = Color.Violet
            LBIngresados.Items.Add(btn44.Text)

        End If

    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        If btn45.BackColor = Color.Violet Then
            btn45.BackColor = Color.White
            LBIngresados.Items.Remove(btn45.Text)

        Else
            btn45.BackColor = Color.Violet
            LBIngresados.Items.Add(btn45.Text)

        End If

    End Sub

    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click
        If btn46.BackColor = Color.Violet Then
            btn46.BackColor = Color.White
            LBIngresados.Items.Remove(btn46.Text)

        Else
            btn46.BackColor = Color.Violet
            LBIngresados.Items.Add(btn46.Text)

        End If

    End Sub

    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click
        If btn47.BackColor = Color.Violet Then
            btn47.BackColor = Color.White
            LBIngresados.Items.Remove(btn47.Text)

        Else
            btn47.BackColor = Color.Violet
            LBIngresados.Items.Add(btn47.Text)

        End If

    End Sub

    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click
        If btn48.BackColor = Color.Violet Then
            btn48.BackColor = Color.White
            LBIngresados.Items.Remove(btn48.Text)

        Else
            btn48.BackColor = Color.Violet
            LBIngresados.Items.Add(btn48.Text)

        End If

    End Sub

    Private Sub btn49_Click(sender As Object, e As EventArgs) Handles btn49.Click
        If btn49.BackColor = Color.Violet Then
            btn49.BackColor = Color.White
            LBIngresados.Items.Remove(btn49.Text)

        Else
            btn49.BackColor = Color.Violet
            LBIngresados.Items.Add(btn49.Text)

        End If

    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        If btn50.BackColor = Color.Violet Then
            btn50.BackColor = Color.White
            LBIngresados.Items.Remove(btn50.Text)

        Else
            btn50.BackColor = Color.Violet
            LBIngresados.Items.Add(btn50.Text)

        End If

    End Sub

    Private Sub btn51_Click(sender As Object, e As EventArgs) Handles btn51.Click
        If btn51.BackColor = Color.Violet Then
            btn51.BackColor = Color.White
            LBIngresados.Items.Remove(btn51.Text)

        Else
            btn51.BackColor = Color.Violet
            LBIngresados.Items.Add(btn51.Text)

        End If

    End Sub

    Private Sub btn52_Click(sender As Object, e As EventArgs) Handles btn52.Click
        If btn52.BackColor = Color.Violet Then
            btn52.BackColor = Color.White
            LBIngresados.Items.Remove(btn52.Text)

        Else
            btn52.BackColor = Color.Violet
            LBIngresados.Items.Add(btn52.Text)

        End If

    End Sub

    Private Sub btn53_Click(sender As Object, e As EventArgs) Handles btn53.Click
        If btn53.BackColor = Color.Violet Then
            btn53.BackColor = Color.White
            LBIngresados.Items.Remove(btn53.Text)

        Else
            btn53.BackColor = Color.Violet
            LBIngresados.Items.Add(btn53.Text)

        End If

    End Sub

    Private Sub btn54_Click(sender As Object, e As EventArgs) Handles btn54.Click
        If btn54.BackColor = Color.Violet Then
            btn54.BackColor = Color.White
            LBIngresados.Items.Remove(btn54.Text)

        Else
            btn54.BackColor = Color.Violet
            LBIngresados.Items.Add(btn54.Text)

        End If

    End Sub

    Private Sub btn55_Click(sender As Object, e As EventArgs) Handles btn55.Click
        If btn55.BackColor = Color.Violet Then
            btn55.BackColor = Color.White
            LBIngresados.Items.Remove(btn55.Text)

        Else
            btn55.BackColor = Color.Violet
            LBIngresados.Items.Add(btn55.Text)

        End If

    End Sub

    Private Sub btn56_Click(sender As Object, e As EventArgs) Handles btn56.Click
        If btn56.BackColor = Color.Violet Then
            btn56.BackColor = Color.White
            LBIngresados.Items.Remove(btn56.Text)

        Else
            btn56.BackColor = Color.Violet
            LBIngresados.Items.Add(btn56.Text)

        End If

    End Sub

    Private Sub btn57_Click(sender As Object, e As EventArgs) Handles btn57.Click
        If btn57.BackColor = Color.Violet Then
            btn57.BackColor = Color.White
            LBIngresados.Items.Remove(btn57.Text)

        Else
            btn57.BackColor = Color.Violet
            LBIngresados.Items.Add(btn57.Text)

        End If

    End Sub

    Private Sub btn58_Click(sender As Object, e As EventArgs) Handles btn58.Click
        If btn58.BackColor = Color.Violet Then
            btn58.BackColor = Color.White
            LBIngresados.Items.Remove(btn58.Text)

        Else
            btn58.BackColor = Color.Violet
            LBIngresados.Items.Add(btn58.Text)

        End If

    End Sub

    Private Sub btn59_Click(sender As Object, e As EventArgs) Handles btn59.Click
        If btn59.BackColor = Color.Violet Then
            btn59.BackColor = Color.White
            LBIngresados.Items.Remove(btn59.Text)

        Else
            btn59.BackColor = Color.Violet
            LBIngresados.Items.Add(btn59.Text)

        End If

    End Sub

    Private Sub btn60_Click(sender As Object, e As EventArgs) Handles btn60.Click
        If btn60.BackColor = Color.Violet Then
            btn60.BackColor = Color.White
            LBIngresados.Items.Remove(btn60.Text)

        Else
            btn60.BackColor = Color.Violet
            LBIngresados.Items.Add(btn60.Text)

        End If

    End Sub

    Private Sub btn61_Click(sender As Object, e As EventArgs) Handles btn61.Click
        If btn61.BackColor = Color.Violet Then
            btn61.BackColor = Color.White
            LBIngresados.Items.Remove(btn61.Text)

        Else
            btn61.BackColor = Color.Violet
            LBIngresados.Items.Add(btn61.Text)

        End If

    End Sub

    Private Sub btn62_Click(sender As Object, e As EventArgs) Handles btn62.Click
        If btn62.BackColor = Color.Violet Then
            btn62.BackColor = Color.White
            LBIngresados.Items.Remove(btn62.Text)

        Else
            btn62.BackColor = Color.Violet
            LBIngresados.Items.Add(btn62.Text)

        End If

    End Sub

    Private Sub btn63_Click(sender As Object, e As EventArgs) Handles btn63.Click
        If btn63.BackColor = Color.Violet Then
            btn63.BackColor = Color.White
            LBIngresados.Items.Remove(btn63.Text)

        Else
            btn63.BackColor = Color.Violet
            LBIngresados.Items.Add(btn63.Text)

        End If

    End Sub

    Private Sub btn64_Click(sender As Object, e As EventArgs) Handles btn64.Click
        If btn64.BackColor = Color.Violet Then
            btn64.BackColor = Color.White
            LBIngresados.Items.Remove(btn64.Text)

        Else
            btn64.BackColor = Color.Violet
            LBIngresados.Items.Add(btn64.Text)

        End If

    End Sub

    Private Sub btn65_Click(sender As Object, e As EventArgs) Handles btn65.Click
        If btn65.BackColor = Color.Violet Then
            btn65.BackColor = Color.White
            LBIngresados.Items.Remove(btn65.Text)

        Else
            btn65.BackColor = Color.Violet
            LBIngresados.Items.Add(btn65.Text)

        End If

    End Sub
    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        LBIngresados.Items.Clear()
        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White
        btn10.BackColor = Color.White
        btn11.BackColor = Color.White
        btn12.BackColor = Color.White
        btn13.BackColor = Color.White
        btn14.BackColor = Color.White
        btn15.BackColor = Color.White
        btn16.BackColor = Color.White
        btn17.BackColor = Color.White
        btn18.BackColor = Color.White
        btn19.BackColor = Color.White
        btn20.BackColor = Color.White
        btn21.BackColor = Color.White
        btn22.BackColor = Color.White
        btn23.BackColor = Color.White
        btn24.BackColor = Color.White
        btn25.BackColor = Color.White
        btn26.BackColor = Color.White
        btn27.BackColor = Color.White
        btn28.BackColor = Color.White
        btn29.BackColor = Color.White
        btn30.BackColor = Color.White
        btn31.BackColor = Color.White
        btn32.BackColor = Color.White
        btn33.BackColor = Color.White
        btn34.BackColor = Color.White
        btn35.BackColor = Color.White
        btn36.BackColor = Color.White
        btn37.BackColor = Color.White
        btn38.BackColor = Color.White
        btn39.BackColor = Color.White
        btn40.BackColor = Color.White
        btn41.BackColor = Color.White
        btn42.BackColor = Color.White
        btn43.BackColor = Color.White
        btn44.BackColor = Color.White
        btn45.BackColor = Color.White
        btn46.BackColor = Color.White
        btn47.BackColor = Color.White
        btn48.BackColor = Color.White
        btn49.BackColor = Color.White
        btn50.BackColor = Color.White
        btn51.BackColor = Color.White
        btn52.BackColor = Color.White
        btn53.BackColor = Color.White
        btn53.BackColor = Color.White
        btn54.BackColor = Color.White
        btn55.BackColor = Color.White
        btn56.BackColor = Color.White
        btn57.BackColor = Color.White
        btn58.BackColor = Color.White
        btn59.BackColor = Color.White
        btn60.BackColor = Color.White
        btn61.BackColor = Color.White
        btn62.BackColor = Color.White
        btn63.BackColor = Color.White
        btn64.BackColor = Color.White
        btn65.BackColor = Color.White
        btn66.BackColor = Color.White
        btn67.BackColor = Color.White
        btn68.BackColor = Color.White
        btn69.BackColor = Color.White
        btn70.BackColor = Color.White
        btn71.BackColor = Color.White
        btn72.BackColor = Color.White
        btn73.BackColor = Color.White
        btn74.BackColor = Color.White
        btn75.BackColor = Color.White
        btn76.BackColor = Color.White
        btn77.BackColor = Color.White
        btn78.BackColor = Color.White
        btn79.BackColor = Color.White
        btn80.BackColor = Color.White
        btn81.BackColor = Color.White
        btn82.BackColor = Color.White
        btn83.BackColor = Color.White
        btn84.BackColor = Color.White
        btn85.BackColor = Color.White
        btn86.BackColor = Color.White
        btn87.BackColor = Color.White
        btn88.BackColor = Color.White
        btn89.BackColor = Color.White
        btn90.BackColor = Color.White
    End Sub

    Private Sub btn71_Click(sender As Object, e As EventArgs) Handles btn71.Click
        If btn71.BackColor = Color.Violet Then
            btn71.BackColor = Color.White
            LBIngresados.Items.Remove(btn71.Text)

        Else
            btn71.BackColor = Color.Violet
            LBIngresados.Items.Add(btn71.Text)

        End If
    End Sub

    Private Sub btn72_Click(sender As Object, e As EventArgs) Handles btn72.Click
        If btn72.BackColor = Color.Violet Then
            btn72.BackColor = Color.White
            LBIngresados.Items.Remove(btn72.Text)

        Else
            btn72.BackColor = Color.Violet
            LBIngresados.Items.Add(btn72.Text)

        End If
    End Sub

    Private Sub btn73_Click(sender As Object, e As EventArgs) Handles btn73.Click
        If btn73.BackColor = Color.Violet Then
            btn73.BackColor = Color.White
            LBIngresados.Items.Remove(btn73.Text)

        Else
            btn73.BackColor = Color.Violet
            LBIngresados.Items.Add(btn73.Text)

        End If
    End Sub

    Private Sub btn74_Click(sender As Object, e As EventArgs) Handles btn74.Click
        If btn74.BackColor = Color.Violet Then
            btn74.BackColor = Color.White
            LBIngresados.Items.Remove(btn74.Text)

        Else
            btn74.BackColor = Color.Violet
            LBIngresados.Items.Add(btn74.Text)

        End If
    End Sub

    Private Sub btn75_Click(sender As Object, e As EventArgs) Handles btn75.Click
        If btn75.BackColor = Color.Violet Then
            btn75.BackColor = Color.White
            LBIngresados.Items.Remove(btn75.Text)

        Else
            btn75.BackColor = Color.Violet
            LBIngresados.Items.Add(btn75.Text)

        End If
    End Sub

    Private Sub btn76_Click(sender As Object, e As EventArgs) Handles btn76.Click
        If btn76.BackColor = Color.Violet Then
            btn76.BackColor = Color.White
            LBIngresados.Items.Remove(btn76.Text)

        Else
            btn76.BackColor = Color.Violet
            LBIngresados.Items.Add(btn76.Text)

        End If
    End Sub

    Private Sub btn77_Click(sender As Object, e As EventArgs) Handles btn77.Click
        If btn77.BackColor = Color.Violet Then
            btn77.BackColor = Color.White
            LBIngresados.Items.Remove(btn77.Text)

        Else
            btn77.BackColor = Color.Violet
            LBIngresados.Items.Add(btn77.Text)

        End If
    End Sub

    Private Sub btn78_Click(sender As Object, e As EventArgs) Handles btn78.Click
        If btn78.BackColor = Color.Violet Then
            btn78.BackColor = Color.White
            LBIngresados.Items.Remove(btn78.Text)

        Else
            btn78.BackColor = Color.Violet
            LBIngresados.Items.Add(btn78.Text)

        End If
    End Sub

    Private Sub btn79_Click(sender As Object, e As EventArgs) Handles btn79.Click
        If btn79.BackColor = Color.Violet Then
            btn79.BackColor = Color.White
            LBIngresados.Items.Remove(btn79.Text)

        Else
            btn79.BackColor = Color.Violet
            LBIngresados.Items.Add(btn79.Text)

        End If
    End Sub

    Private Sub btn80_Click(sender As Object, e As EventArgs) Handles btn80.Click
        If btn80.BackColor = Color.Violet Then
            btn80.BackColor = Color.White
            LBIngresados.Items.Remove(btn80.Text)

        Else
            btn80.BackColor = Color.Violet
            LBIngresados.Items.Add(btn80.Text)

        End If
    End Sub

    Private Sub Btn66_Click(sender As Object, e As EventArgs) Handles btn66.Click
        If btn66.BackColor = Color.Violet Then
            btn66.BackColor = Color.White
            LBIngresados.Items.Remove(btn66.Text)

        Else
            btn66.BackColor = Color.Violet
            LBIngresados.Items.Add(btn66.Text)

        End If
    End Sub

    Private Sub Btn67_Click(sender As Object, e As EventArgs) Handles btn67.Click
        If btn67.BackColor = Color.Violet Then
            btn67.BackColor = Color.White
            LBIngresados.Items.Remove(btn67.Text)

        Else
            btn67.BackColor = Color.Violet
            LBIngresados.Items.Add(btn67.Text)

        End If
    End Sub

    Private Sub Btn68_Click(sender As Object, e As EventArgs) Handles btn68.Click
        If btn68.BackColor = Color.Violet Then
            btn68.BackColor = Color.White
            LBIngresados.Items.Remove(btn68.Text)

        Else
            btn68.BackColor = Color.Violet
            LBIngresados.Items.Add(btn68.Text)

        End If
    End Sub

    Private Sub Btn69_Click(sender As Object, e As EventArgs) Handles btn69.Click
        If btn69.BackColor = Color.Violet Then
            btn69.BackColor = Color.White
            LBIngresados.Items.Remove(btn69.Text)

        Else
            btn69.BackColor = Color.Violet
            LBIngresados.Items.Add(btn69.Text)

        End If
    End Sub

    Private Sub Btn70_Click(sender As Object, e As EventArgs) Handles btn70.Click
        If btn70.BackColor = Color.Violet Then
            btn70.BackColor = Color.White
            LBIngresados.Items.Remove(btn70.Text)

        Else
            btn70.BackColor = Color.Violet
            LBIngresados.Items.Add(btn70.Text)

        End If
    End Sub
End Class