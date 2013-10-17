Public Class frm_person

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim str_name As String

        str_name = txt_name.Text

        MsgBox(str_name)


    End Sub
End Class
