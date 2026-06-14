Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
			Me.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empty))
        Me.g1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'g1
        '
        Me.g1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g1.Font = New System.Drawing.Font("Lucida Console", 48.0!)
        Me.g1.ForeColor = System.Drawing.Color.Red
        Me.g1.Location = New System.Drawing.Point(0, 0)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(874, 408)
        Me.g1.TabIndex = 1
        Me.g1.Text = ":D"
        Me.g1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'empty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(874, 408)
        Me.Controls.Add(Me.g1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empty"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Private g1 As Label
End Class
