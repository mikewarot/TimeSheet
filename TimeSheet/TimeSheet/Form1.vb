Public Class Form1

    Private Sub AboutThisProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisProgramToolStripMenuItem.Click
        MessageBox.Show("This is a test")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimeSheetDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.TimeSheetDataSet.Users)

    End Sub

End Class
