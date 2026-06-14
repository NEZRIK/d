Imports System.ComponentModel
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _o_program
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_o_program))
        Me.srv = New System.Windows.Forms.Timer(Me.components)
        Me.cursorstylec = New System.Windows.Forms.Timer(Me.components)
        Me.OnError = New System.Windows.Forms.Timer(Me.components)
        Me.clck = New System.Windows.Forms.Timer(Me.components)
        Me.bypasserr = New System.Windows.Forms.Timer(Me.components)
        Me.g1 = New System.Windows.Forms.Label()
        Me.a1 = New System.Windows.Forms.Panel()
        Me.s2 = New System.Windows.Forms.Label()
        Me.tg = New System.Windows.Forms.Label()
        Me.s1 = New System.Windows.Forms.Label()
        Me.border_6 = New System.Windows.Forms.PictureBox()
        Me.border_5 = New System.Windows.Forms.PictureBox()
        Me.border_2 = New System.Windows.Forms.PictureBox()
        Me.border_1 = New System.Windows.Forms.PictureBox()
        Me.main = New System.Windows.Forms.Panel()
        Me.ByPassMessage = New System.Windows.Forms.Panel()
        Me.c3 = New System.Windows.Forms.PictureBox()
        Me.c2 = New System.Windows.Forms.PictureBox()
        Me.c4 = New System.Windows.Forms.PictureBox()
        Me.c1 = New System.Windows.Forms.PictureBox()
        Me.ByPassWarnMsg = New System.Windows.Forms.Label()
        Me.Safe1 = New System.Windows.Forms.PictureBox()
        Me.Safe2 = New System.Windows.Forms.PictureBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.UserInfo = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.menu1 = New System.Windows.Forms.Label()
        Me.a2 = New System.Windows.Forms.Panel()
        Me.errx = New System.Windows.Forms.Label()
        Me.border_8 = New System.Windows.Forms.PictureBox()
        Me.border_7 = New System.Windows.Forms.PictureBox()
        Me.border_4 = New System.Windows.Forms.PictureBox()
        Me.border_3 = New System.Windows.Forms.PictureBox()
        Me.inputPS = New System.Windows.Forms.Label()
        Me.keytext = New System.Windows.Forms.Label()
        Me.hdn = New System.Windows.Forms.TextBox()
        Me.art = New System.Windows.Forms.Label()
        Me.a1.SuspendLayout()
        CType(Me.border_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main.SuspendLayout()
        Me.ByPassMessage.SuspendLayout()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Safe1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Safe2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.a2.SuspendLayout()
        CType(Me.border_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.border_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'srv
        '
        Me.srv.Enabled = True
        Me.srv.Interval = 5
        '
        'cursorstylec
        '
        Me.cursorstylec.Enabled = True
        Me.cursorstylec.Interval = 9
        '
        'OnError
        '
        Me.OnError.Interval = 40
        '
        'clck
        '
        Me.clck.Enabled = True
        Me.clck.Interval = 500
        '
        'bypasserr
        '
        Me.bypasserr.Interval = 10
        '
        'g1
        '
        Me.g1.BackColor = System.Drawing.Color.Transparent
        Me.g1.Font = New System.Drawing.Font("Lucida Console", 13.25!)
        Me.g1.ForeColor = System.Drawing.Color.White
        Me.g1.Location = New System.Drawing.Point(6, 1)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(807, 153)
        Me.g1.TabIndex = 0
        Me.g1.Text = resources.GetString("g1.Text")
        Me.g1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'a1
        '
        Me.a1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.a1.Controls.Add(Me.s2)
        Me.a1.Controls.Add(Me.tg)
        Me.a1.Controls.Add(Me.s1)
        Me.a1.Controls.Add(Me.border_6)
        Me.a1.Controls.Add(Me.border_5)
        Me.a1.Controls.Add(Me.border_2)
        Me.a1.Controls.Add(Me.border_1)
        Me.a1.Controls.Add(Me.g1)
        Me.a1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.a1.Location = New System.Drawing.Point(97, 147)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(813, 178)
        Me.a1.TabIndex = 2
        Me.a1.Visible = False
        '
        's2
        '
        Me.s2.BackColor = System.Drawing.Color.Transparent
        Me.s2.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.s2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.s2.Location = New System.Drawing.Point(647, 154)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(140, 23)
        Me.s2.TabIndex = 12
        Me.s2.Text = "(Telegram)"
        '
        'tg
        '
        Me.tg.BackColor = System.Drawing.Color.Transparent
        Me.tg.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tg.Location = New System.Drawing.Point(411, 154)
        Me.tg.Name = "tg"
        Me.tg.Size = New System.Drawing.Size(234, 23)
        Me.tg.TabIndex = 11
        Me.tg.Text = "@ftmoapp"
        Me.tg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.Transparent
        Me.s1.Font = New System.Drawing.Font("Lucida Console", 15.75!)
        Me.s1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.s1.Location = New System.Drawing.Point(30, 151)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(395, 23)
        Me.s1.TabIndex = 10
        Me.s1.Text = "Чтобы получить код, напишите"
        Me.s1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'border_6
        '
        Me.border_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_6.Dock = System.Windows.Forms.DockStyle.Right
        Me.border_6.Location = New System.Drawing.Point(811, 1)
        Me.border_6.Name = "border_6"
        Me.border_6.Size = New System.Drawing.Size(2, 176)
        Me.border_6.TabIndex = 9
        Me.border_6.TabStop = False
        '
        'border_5
        '
        Me.border_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_5.Dock = System.Windows.Forms.DockStyle.Left
        Me.border_5.Location = New System.Drawing.Point(0, 1)
        Me.border_5.Name = "border_5"
        Me.border_5.Size = New System.Drawing.Size(2, 176)
        Me.border_5.TabIndex = 8
        Me.border_5.TabStop = False
        '
        'border_2
        '
        Me.border_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.border_2.Location = New System.Drawing.Point(0, 177)
        Me.border_2.Name = "border_2"
        Me.border_2.Size = New System.Drawing.Size(813, 1)
        Me.border_2.TabIndex = 7
        Me.border_2.TabStop = False
        '
        'border_1
        '
        Me.border_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.border_1.Location = New System.Drawing.Point(0, 0)
        Me.border_1.Name = "border_1"
        Me.border_1.Size = New System.Drawing.Size(813, 1)
        Me.border_1.TabIndex = 6
        Me.border_1.TabStop = False
        '
        'main
        '
        Me.main.BackColor = System.Drawing.Color.DarkBlue
        Me.main.Controls.Add(Me.ByPassMessage)
        Me.main.Controls.Add(Me.Safe1)
        Me.main.Controls.Add(Me.Safe2)
        Me.main.Controls.Add(Me.ID)
        Me.main.Controls.Add(Me.UserInfo)
        Me.main.Controls.Add(Me.Title)
        Me.main.Controls.Add(Me.menu1)
        Me.main.Controls.Add(Me.a2)
        Me.main.Controls.Add(Me.hdn)
        Me.main.Controls.Add(Me.a1)
        Me.main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(1006, 540)
        Me.main.TabIndex = 1
        Me.main.Visible = False
        '
        'ByPassMessage
        '
        Me.ByPassMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ByPassMessage.Controls.Add(Me.c3)
        Me.ByPassMessage.Controls.Add(Me.c2)
        Me.ByPassMessage.Controls.Add(Me.c4)
        Me.ByPassMessage.Controls.Add(Me.c1)
        Me.ByPassMessage.Controls.Add(Me.ByPassWarnMsg)
        Me.ByPassMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ByPassMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ByPassMessage.Location = New System.Drawing.Point(324, 208)
        Me.ByPassMessage.Name = "ByPassMessage"
        Me.ByPassMessage.Size = New System.Drawing.Size(373, 178)
        Me.ByPassMessage.TabIndex = 18
        Me.ByPassMessage.Visible = False
        '
        'c3
        '
        Me.c3.BackColor = System.Drawing.Color.Red
        Me.c3.Dock = System.Windows.Forms.DockStyle.Right
        Me.c3.Location = New System.Drawing.Point(371, 1)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(2, 176)
        Me.c3.TabIndex = 9
        Me.c3.TabStop = False
        '
        'c2
        '
        Me.c2.BackColor = System.Drawing.Color.Red
        Me.c2.Dock = System.Windows.Forms.DockStyle.Left
        Me.c2.Location = New System.Drawing.Point(0, 1)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(2, 176)
        Me.c2.TabIndex = 8
        Me.c2.TabStop = False
        '
        'c4
        '
        Me.c4.BackColor = System.Drawing.Color.Red
        Me.c4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c4.Location = New System.Drawing.Point(0, 177)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(373, 1)
        Me.c4.TabIndex = 7
        Me.c4.TabStop = False
        '
        'c1
        '
        Me.c1.BackColor = System.Drawing.Color.Red
        Me.c1.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1.Location = New System.Drawing.Point(0, 0)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(373, 1)
        Me.c1.TabIndex = 6
        Me.c1.TabStop = False
        '
        'ByPassWarnMsg
        '
        Me.ByPassWarnMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ByPassWarnMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ByPassWarnMsg.Font = New System.Drawing.Font("Lucida Console", 14.25!)
        Me.ByPassWarnMsg.ForeColor = System.Drawing.Color.White
        Me.ByPassWarnMsg.Location = New System.Drawing.Point(0, 0)
        Me.ByPassWarnMsg.Name = "ByPassWarnMsg"
        Me.ByPassWarnMsg.Size = New System.Drawing.Size(373, 178)
        Me.ByPassWarnMsg.TabIndex = 0
        Me.ByPassWarnMsg.Text = "Замечена и остановлена попытка обмануть систему!"
        Me.ByPassWarnMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Safe1
        '
        Me.Safe1.BackColor = System.Drawing.Color.Black
        Me.Safe1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Safe1.Location = New System.Drawing.Point(0, 0)
        Me.Safe1.Name = "Safe1"
        Me.Safe1.Size = New System.Drawing.Size(70, 540)
        Me.Safe1.TabIndex = 14
        Me.Safe1.TabStop = False
        '
        'Safe2
        '
        Me.Safe2.BackColor = System.Drawing.Color.Black
        Me.Safe2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Safe2.Location = New System.Drawing.Point(936, 0)
        Me.Safe2.Name = "Safe2"
        Me.Safe2.Size = New System.Drawing.Size(70, 540)
        Me.Safe2.TabIndex = 15
        Me.Safe2.TabStop = False
        '
        'ID
        '
        Me.ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ID.BackColor = System.Drawing.Color.Transparent
        Me.ID.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ID.ForeColor = System.Drawing.Color.White
        Me.ID.Location = New System.Drawing.Point(74, 517)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(856, 23)
        Me.ID.TabIndex = 17
        Me.ID.Text = "ID: Ошибка идентификации"
        Me.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ID.Visible = False
        '
        'UserInfo
        '
        Me.UserInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserInfo.BackColor = System.Drawing.Color.Transparent
        Me.UserInfo.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.UserInfo.ForeColor = System.Drawing.Color.Silver
        Me.UserInfo.Location = New System.Drawing.Point(97, 427)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(645, 23)
        Me.UserInfo.TabIndex = 16
        Me.UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserInfo.Visible = False
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(332, 119)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(342, 23)
        Me.Title.TabIndex = 13
        Me.Title.Text = "Ваши файлы зашифрованы!"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menu1
        '
        Me.menu1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.menu1.BackColor = System.Drawing.Color.DarkBlue
        Me.menu1.Font = New System.Drawing.Font("Lucida Console", 15.75!)
        Me.menu1.ForeColor = System.Drawing.Color.White
        Me.menu1.Location = New System.Drawing.Point(744, 427)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(166, 23)
        Me.menu1.TabIndex = 12
        Me.menu1.Text = "Enter [Ввод]"
        Me.menu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.menu1.Visible = False
        '
        'a2
        '
        Me.a2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.a2.Controls.Add(Me.errx)
        Me.a2.Controls.Add(Me.border_8)
        Me.a2.Controls.Add(Me.border_7)
        Me.a2.Controls.Add(Me.border_4)
        Me.a2.Controls.Add(Me.border_3)
        Me.a2.Controls.Add(Me.inputPS)
        Me.a2.Controls.Add(Me.keytext)
        Me.a2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.a2.Location = New System.Drawing.Point(97, 330)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(813, 94)
        Me.a2.TabIndex = 5
        Me.a2.Visible = False
        '
        'errx
        '
        Me.errx.BackColor = System.Drawing.Color.Transparent
        Me.errx.Font = New System.Drawing.Font("Lucida Console", 15.75!)
        Me.errx.ForeColor = System.Drawing.Color.MistyRose
        Me.errx.Location = New System.Drawing.Point(3, 62)
        Me.errx.Name = "errx"
        Me.errx.Size = New System.Drawing.Size(807, 24)
        Me.errx.TabIndex = 11
        Me.errx.Text = "Ошибка! Введённый код не совпадает с ключом разблокировки."
        Me.errx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.errx.Visible = False
        '
        'border_8
        '
        Me.border_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_8.Dock = System.Windows.Forms.DockStyle.Right
        Me.border_8.Location = New System.Drawing.Point(811, 1)
        Me.border_8.Name = "border_8"
        Me.border_8.Size = New System.Drawing.Size(2, 92)
        Me.border_8.TabIndex = 10
        Me.border_8.TabStop = False
        '
        'border_7
        '
        Me.border_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_7.Dock = System.Windows.Forms.DockStyle.Left
        Me.border_7.Location = New System.Drawing.Point(0, 1)
        Me.border_7.Name = "border_7"
        Me.border_7.Size = New System.Drawing.Size(2, 92)
        Me.border_7.TabIndex = 9
        Me.border_7.TabStop = False
        '
        'border_4
        '
        Me.border_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.border_4.Location = New System.Drawing.Point(0, 93)
        Me.border_4.Name = "border_4"
        Me.border_4.Size = New System.Drawing.Size(813, 1)
        Me.border_4.TabIndex = 8
        Me.border_4.TabStop = False
        '
        'border_3
        '
        Me.border_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.border_3.Dock = System.Windows.Forms.DockStyle.Top
        Me.border_3.Location = New System.Drawing.Point(0, 0)
        Me.border_3.Name = "border_3"
        Me.border_3.Size = New System.Drawing.Size(813, 1)
        Me.border_3.TabIndex = 7
        Me.border_3.TabStop = False
        '
        'inputPS
        '
        Me.inputPS.BackColor = System.Drawing.Color.White
        Me.inputPS.Font = New System.Drawing.Font("Lucida Console", 15.75!)
        Me.inputPS.ForeColor = System.Drawing.Color.Black
        Me.inputPS.Location = New System.Drawing.Point(8, 29)
        Me.inputPS.Name = "inputPS"
        Me.inputPS.Size = New System.Drawing.Size(797, 25)
        Me.inputPS.TabIndex = 5
        Me.inputPS.Text = " "
        Me.inputPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'keytext
        '
        Me.keytext.BackColor = System.Drawing.Color.Transparent
        Me.keytext.Font = New System.Drawing.Font("Lucida Console", 15.75!)
        Me.keytext.Location = New System.Drawing.Point(3, 8)
        Me.keytext.Name = "keytext"
        Me.keytext.Size = New System.Drawing.Size(807, 24)
        Me.keytext.TabIndex = 4
        Me.keytext.Text = "Введи код разблокировки:"
        Me.keytext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'hdn
        '
        Me.hdn.Location = New System.Drawing.Point(-17, 4)
        Me.hdn.MaxLength = 45
        Me.hdn.Name = "hdn"
        Me.hdn.Size = New System.Drawing.Size(10, 22)
        Me.hdn.TabIndex = 3
        '
        'art
        '
        Me.art.Dock = System.Windows.Forms.DockStyle.Fill
        Me.art.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.art.Image = My.Resources.art
        Me.art.Location = New System.Drawing.Point(0, 0)
        Me.art.Name = "art"
        Me.art.Size = New System.Drawing.Size(1006, 540)
        Me.art.TabIndex = 14
        '
        '_o_program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1006, 540)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.art)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_o_program"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.a1.ResumeLayout(False)
        CType(Me.border_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main.ResumeLayout(False)
        Me.main.PerformLayout()
        Me.ByPassMessage.ResumeLayout(False)
        CType(Me.c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Safe1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Safe2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.a2.ResumeLayout(False)
        CType(Me.border_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.border_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents g1 As Label
	Friend WithEvents a1 As Panel
	Friend WithEvents main As Panel
	Friend WithEvents a2 As Panel
	Friend WithEvents keytext As Label
	Friend WithEvents hdn As TextBox
	Friend WithEvents inputPS As Label
	Friend WithEvents srv As Global.System.Windows.Forms.Timer
	Friend WithEvents border_6 As PictureBox
	Friend WithEvents border_5 As PictureBox
	Friend WithEvents border_2 As PictureBox
	Friend WithEvents border_1 As PictureBox
	Friend WithEvents border_8 As PictureBox
	Friend WithEvents border_7 As PictureBox
	Friend WithEvents border_4 As PictureBox
	Friend WithEvents border_3 As PictureBox
	Friend WithEvents s2 As Label
	Friend WithEvents s1 As Label
	Friend WithEvents cursorstylec As Global.System.Windows.Forms.Timer
	Friend WithEvents menu1 As Label
	Friend WithEvents Title As Label
	Friend WithEvents art As Label
	Friend WithEvents errx As Label
	Friend WithEvents OnError As Global.System.Windows.Forms.Timer
	Friend WithEvents UserInfo As Label
	Friend WithEvents ID As Label
	Friend WithEvents clck As Global.System.Windows.Forms.Timer
	Friend WithEvents Safe1 As PictureBox
	Friend WithEvents Safe2 As PictureBox
	Friend WithEvents ByPassMessage As Panel
	Friend WithEvents c3 As PictureBox
	Friend WithEvents c2 As PictureBox
	Friend WithEvents c4 As PictureBox
	Friend WithEvents c1 As PictureBox
	Friend WithEvents ByPassWarnMsg As Label
	Friend WithEvents bypasserr As Global.System.Windows.Forms.Timer
	Friend WithEvents tg As Label
End Class
