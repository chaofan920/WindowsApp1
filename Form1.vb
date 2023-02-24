Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_select.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "文本文件|*.txt|All Files|*.*"
        'openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Text_Path.Text = openFileDialog1.FileName
            Catch Ex As Exception
                MessageBox.Show("无法读取文件： " & Ex.Message)
            End Try
        End If


    End Sub


    Private Sub run_Click(sender As Object, e As EventArgs) Handles run.Click
        MySub(Text_Path.Text)
        MsgBox("OK")
    End Sub


    Private Sub MySub(ByRef filepath)
        Dim reader As System.IO.StreamReader

        ' 打开文件
        reader = My.Computer.FileSystem.OpenTextFileReader(filepath)

        ' 读取文件
        Dim content As String = reader.ReadToEnd()

        ' 替换文件中的大写字母
        Dim lowerContent As String = content.ToLower()

        ' 关闭文件
        reader.Close()

        ' 写入文件
        My.Computer.FileSystem.WriteAllText(filepath, lowerContent, False)

    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Application.Exit()
    End Sub
End Class
