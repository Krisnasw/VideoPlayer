Public Class Form1

    Private Sub MainkanVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainkanVideoToolStripMenuItem.Click
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem

    End Sub

    Private Sub TambahkanFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TambahkanFileToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each track As String In OpenFileDialog1.FileNames

            ListBox1.Items.Add(track)
        Next
    End Sub

    Private Sub HentikanVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HentikanVideoToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()

    End Sub

    Private Sub PauseVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseVideoToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class
