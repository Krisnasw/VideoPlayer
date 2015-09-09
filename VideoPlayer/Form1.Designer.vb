<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahkanFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainkanVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HentikanVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahkanFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 23)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(735, 282)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 320)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(735, 43)
        Me.ListBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "Video Files|*.AVI."
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahkanFileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahkanFileToolStripMenuItem
        '
        Me.TambahkanFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahkanFileToolStripMenuItem1, Me.MainkanVideoToolStripMenuItem, Me.HentikanVideoToolStripMenuItem, Me.PauseVideoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TambahkanFileToolStripMenuItem.Name = "TambahkanFileToolStripMenuItem"
        Me.TambahkanFileToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TambahkanFileToolStripMenuItem.Text = "Menu"
        '
        'MainkanVideoToolStripMenuItem
        '
        Me.MainkanVideoToolStripMenuItem.Name = "MainkanVideoToolStripMenuItem"
        Me.MainkanVideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainkanVideoToolStripMenuItem.Text = "Play Video"
        '
        'HentikanVideoToolStripMenuItem
        '
        Me.HentikanVideoToolStripMenuItem.Name = "HentikanVideoToolStripMenuItem"
        Me.HentikanVideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HentikanVideoToolStripMenuItem.Text = "Stop Video"
        '
        'PauseVideoToolStripMenuItem
        '
        Me.PauseVideoToolStripMenuItem.Name = "PauseVideoToolStripMenuItem"
        Me.PauseVideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PauseVideoToolStripMenuItem.Text = "Pause Video"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TambahkanFileToolStripMenuItem1
        '
        Me.TambahkanFileToolStripMenuItem1.Name = "TambahkanFileToolStripMenuItem1"
        Me.TambahkanFileToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TambahkanFileToolStripMenuItem1.Text = "Add File"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 375)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Video Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahkanFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainkanVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HentikanVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahkanFileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
