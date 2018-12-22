Imports System.Threading
Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim a As OpenFileDialog = New OpenFileDialog
        a.Title = ("Open")
        a.Filter = " Rich Text Files (*.rtf)|*.rtf"
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(a.FileName)
        End If
        Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim a As SaveFileDialog = New SaveFileDialog
        a.Title = "Save as"
        a.Filter = "Rich Text Files (*.rtf)|*.rtf"
        If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(a.FileName)
        End If
        Try : Catch ex As Exception : End Try
    End Sub
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub
    Private Sub PasteCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteCToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub
    Private Sub CopyCtrlCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyCtrlCToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub
    Private Sub CopyAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub
    Private Sub CutCtrlXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutCtrlXToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Dim a As FontDialog = New FontDialog
        a.Font = RichTextBox1.Font
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = a.Font
        End If
    End Sub
    Private Sub ColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourToolStripMenuItem.Click
        Dim a As ColorDialog = New ColorDialog
        a.Color = RichTextBox1.ForeColor
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = a.Color
            Try : Catch ex As Exception : End Try
        End If
    End Sub
    Shared Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.MaximizeBox = False
        Control.CheckForIllegalCrossThreadCalls = False
        Dim A As Threading.Thread = New Threading.Thread(AddressOf Form1.Clock)
        A.IsBackground = True
        A.Start()
    End Sub
    Public Sub Clock()
        Do : Label1.Text = "Time:" + TimeString
            Thread.Sleep(1000) : Loop
    End Sub
    Private Sub DarkBlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkBlueToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.DarkBlue
        RichTextBox1.ForeColor = Color.YellowGreen
    End Sub
    Private Sub TomatoOrangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TomatoOrangeToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Tomato
        RichTextBox1.ForeColor = Color.AntiqueWhite
    End Sub
    Private Sub CrimsonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrimsonToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.Crimson
        RichTextBox1.ForeColor = Color.LightBlue
    End Sub
    Private Sub TransperancyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransperancyToolStripMenuItem.Click
        Opacity = 100%
    End Sub
End Class