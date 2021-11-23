using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntiGuyDoPietra.Properties;
using Gma.System.MouseKeyHook;

namespace AntiGuyDoPietra
{
    public partial class FrmMain : Form
    {
        private const byte TRIGGER_METHOD_MANUAL = 0;
        private const byte TRIGGER_METHOD_AUTO = 1;
        private bool _isRunning;
        private IKeyboardMouseEvents _mGlobalHook;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public FrmMain()
        {
            InitializeComponent();
            
            if (Settings.Default.XMousePosition == 0)
            {
                Settings.Default.XMousePosition = (short)(Screen.PrimaryScreen.Bounds.Width / 2 - 280);
            }
            if (Settings.Default.YMousePosition == 0)
            {
                Settings.Default.YMousePosition = (short)(Screen.PrimaryScreen.Bounds.Height / 2 + 180);
            }
            
            Populate();
            Subscribe();
        }

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            _mGlobalHook = Hook.GlobalEvents();

            _mGlobalHook.KeyDown += GlobalHookKeyDown;
            _mGlobalHook.KeyUp += GlobalHookKeyUp;
        }

        protected override void OnClosed(EventArgs e)
        {
            Settings.Default.Save();
            Unsubscribe();
            base.OnClosed(e);
        }

        private void Populate()
        {
            lbScreenHalf.Text = $"Center screen: {Screen.PrimaryScreen.Bounds.Width / 2} x {Screen.PrimaryScreen.Bounds.Height / 2}";
            cbIsEnabled.Checked = Settings.Default.IsEnabled;
            tbInventoryKey.Text = Settings.Default.InventoryKey;
            tbTriggerKey.Text = Settings.Default.TriggerKey;
            cbTriggerMethod.SelectedIndex = Settings.Default.TriggerMethod;
            nmDelayHoldGrenadeFor.Value = Settings.Default.DelayHoldGrenadeFor;
            nmDelayBeforeOpenInventory.Value = Settings.Default.DelayBeforeOpenInventory;
            nmDelayAfterOpenInventory.Value = Settings.Default.DelayAfterOpenInventory;
            nmDropClicks.Value = Settings.Default.NumberOfClicks;
            nmDelayBetweenClicks.Value = Settings.Default.DelayBetweenClicks;
            nmXOfensivePosition.Value = Settings.Default.XMousePosition;
            nmYOfensivePosition.Value = Settings.Default.YMousePosition;
            cbMouseButton.SelectedIndex = Settings.Default.MouseButton;
            nmDelayHoldGrenadeFor.Enabled = Settings.Default.TriggerMethod != TRIGGER_METHOD_MANUAL;
            UpdateCounter();
        }

        private static string ToKeyString(string value)
        {
            if (value == Keys.Tab.ToString()) return "\t";
            if (value == Keys.Space.ToString()) return " ";
            return value;
        }


        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (tbInventoryKey.Focused)
            {
                tbInventoryKey.Text = Settings.Default.InventoryKey = e.KeyCode.ToString();
                e.Handled = true;
                return;
            }
            if (tbTriggerKey.Focused)
            {
                tbTriggerKey.Text = Settings.Default.TriggerKey = e.KeyCode.ToString();
                e.Handled = true;
                return;
            }
            if (!Settings.Default.IsEnabled 
                || Settings.Default.TriggerMethod != TRIGGER_METHOD_MANUAL
                || _isRunning 
                || e.KeyCode.ToString() != Settings.Default.TriggerKey) return;

            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            _isRunning = true;
        }

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            //if (Settings.Default.TriggerMethod != 1 && (e.KeyCode.ta == Settings.Default.TriggerKey || e.KeyChar == char.ToUpper(Settings.Default.TriggerKey))) return;
            if (!Settings.Default.IsEnabled) return;

            if (e.KeyCode.ToString() == Settings.Default.TriggerKey)
            {
                e.Handled = true;

                ProcessAutoHook();
                
                return;
            }

            Debug.WriteLine("KeyCode: ({0})", e.KeyCode);
        }

        private async void ProcessAutoHook()
        {
            if (Settings.Default.TriggerMethod == TRIGGER_METHOD_MANUAL)
            {
                if (!_isRunning) return;
            }
            else
            {
                if (_isRunning) return;
            }

            _isRunning = true;
            Settings.Default.TriggerCount++;
            
            await Task.Run(() =>
            {
                if (Settings.Default.TriggerMethod != TRIGGER_METHOD_MANUAL)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    if (Settings.Default.DelayHoldGrenadeFor > 0) Thread.Sleep(Settings.Default.DelayHoldGrenadeFor);
                }

                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                
                if (Settings.Default.DelayBeforeOpenInventory > 0) Thread.Sleep(Settings.Default.DelayBeforeOpenInventory);

                Invoke((MethodInvoker)delegate { SendKeys.Send(ToKeyString(Settings.Default.InventoryKey)); });
                
                //var position = new Point(Cursor.Position.X + Settings.Default.XMousePosition, Cursor.Position.Y + Settings.Default.YMousePosition);
                var position = new Point(Settings.Default.XMousePosition, Settings.Default.YMousePosition);
                Debug.WriteLine(position);

                if (Settings.Default.DelayAfterOpenInventory > 0) Thread.Sleep(Settings.Default.DelayAfterOpenInventory);

                for (byte i = 0; i < Settings.Default.NumberOfClicks; i++)
                {
                    Cursor.Position = position;
                    if (Settings.Default.MouseButton == 0)
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        /*mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(10);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*/
                    }
                    else
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        /*mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(10);
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);*/
                    }

                    if (Settings.Default.DelayBetweenClicks > 0) Thread.Sleep(Settings.Default.DelayBetweenClicks);
                }
            });

            SendKeys.Send(ToKeyString(Settings.Default.InventoryKey));
            
            _isRunning = false;
            UpdateCounter();
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            Debug.WriteLine("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.Button, e.Timestamp);

            // uncommenting the following line will suppress the middle mouse button click
            // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }
        }

        public void Unsubscribe()
        {
            //It is recommened to dispose it
            _mGlobalHook.Dispose();
        }

        private void EventValueChanged(object sender, System.EventArgs e)
        {
            if (sender == btnUnfocus)
            {
                ActiveControl = null;
                return;
            }
            if (sender == btnResetSettings)
            {
                if (MessageBox.Show("Are you sure you want to reset all settings to default values?", "Reset settings?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                var oldCounter = Settings.Default.TriggerCount;
                Settings.Default.Reset();
                Settings.Default.XMousePosition = (short)(Screen.PrimaryScreen.Bounds.Width / 2 - 280);
                Settings.Default.YMousePosition = (short)(Screen.PrimaryScreen.Bounds.Height / 2 + 180);
                Settings.Default.TriggerCount = oldCounter;
                Populate();
                return;
            }
            if (sender == cbIsEnabled)
            {
                Settings.Default.IsEnabled = cbIsEnabled.Checked;
                return;
            }
            if (sender == cbTriggerMethod)
            {
                Settings.Default.TriggerMethod = (byte)cbTriggerMethod.SelectedIndex;
                nmDelayHoldGrenadeFor.Enabled = Settings.Default.TriggerMethod != TRIGGER_METHOD_MANUAL;
                return;
            }
            if (sender == nmDelayHoldGrenadeFor)
            {
                Settings.Default.DelayHoldGrenadeFor = (ushort)nmDelayHoldGrenadeFor.Value;
                return;
            }
            if (sender == nmDelayBeforeOpenInventory)
            {
                Settings.Default.DelayBeforeOpenInventory = (ushort)nmDelayBeforeOpenInventory.Value;
                return;
            }
            if (sender == nmDelayAfterOpenInventory)
            {
                Settings.Default.DelayAfterOpenInventory = (ushort)nmDelayAfterOpenInventory.Value;
                return;
            }
            if (sender == nmXOfensivePosition)
            {
                Settings.Default.XMousePosition = (short)nmXOfensivePosition.Value;
                return;
            }
            if (sender == nmYOfensivePosition)
            {
                Settings.Default.YMousePosition = (short)nmYOfensivePosition.Value;
                return;
            }
            if (sender == nmDropClicks)
            {
                Settings.Default.NumberOfClicks = (byte)nmDropClicks.Value;
                return;
            }
            if (sender == nmDelayBetweenClicks)
            {
                Settings.Default.DelayBetweenClicks = (byte)nmDelayBetweenClicks.Value;
                return;
            }
            if (sender == cbMouseButton)
            {
                Settings.Default.MouseButton = (byte)cbMouseButton.SelectedIndex;
                return;
            }
        }

        private void UpdateCounter()
        {
            lbTriggerLifetimeCount.Text = $"Lifetime trigger count:    {Settings.Default.TriggerCount}";
        }
    }
}
