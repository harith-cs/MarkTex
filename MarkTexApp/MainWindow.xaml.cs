using NHotkey;
using NHotkey.Wpf;
using System.Windows;
using System.Windows.Input;

namespace MarkTexApp
{
    public partial class MainWindow : Window
    {
        private NotifyIcon? notifyIcon;
        // MarkTex parameters
        public static bool UseBold { get; set; } = true;
        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                notifyIcon = new NotifyIcon();
                notifyIcon.Visible = true;
                notifyIcon.Text = "MarkTex";                            
                notifyIcon.Icon = Properties.Resources.MT_ICON;

                notifyIcon.ContextMenuStrip = new ContextMenuStrip();                
                var boldItem = new ToolStripMenuItem("Use Bold")
                {
                    Checked = UseBold,
                    CheckOnClick = true
                };
                boldItem.CheckedChanged += (s, e) =>
                {
                    UseBold = boldItem.Checked;
                };

                notifyIcon.ContextMenuStrip.Items.Add(boldItem);
                notifyIcon.ContextMenuStrip.Items.Add("Exit", null, (s, e) =>
                {
                    notifyIcon.Visible = false;
                    System.Windows.Application.Current.Shutdown();
                });

                notifyIcon.MouseClick += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                        System.Windows.MessageBox.Show("MarkTex is running!");
                };
            });

            this.Hide(); 

            try
            {
                HotkeyManager.Current.AddOrReplace("ConvertHotkey", Key.M, ModifierKeys.Control | ModifierKeys.Alt, OnHotkeyPressed);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error registering hotkey: " + ex.Message);
            }

        }

        private void OnHotkeyPressed(object? sender, HotkeyEventArgs e)
        {
            try
            {                              
                string clipboardText = System.Windows.Clipboard.GetText();
                string converted = MarkTexRenderer.Convert(clipboardText, UseBold);
                System.Windows.Clipboard.SetText(converted, System.Windows.TextDataFormat.UnicodeText);
                Thread.Sleep(50);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }

            e.Handled = true;
        }
    }
}
