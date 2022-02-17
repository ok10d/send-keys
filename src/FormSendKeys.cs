using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SendKeys
{
    public partial class FormSendKeys : Form
    {
        public FormSendKeys()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);
        enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private void button_Click(object sender, EventArgs e)
        {
            IntPtr lastWindowHandle = GetWindow(Process.GetCurrentProcess().MainWindowHandle, (uint)GetWindow_Cmd.GW_HWNDNEXT);
            while (true)
            {
                IntPtr temp = GetParent(lastWindowHandle);
                if (temp.Equals(IntPtr.Zero)) break;
                lastWindowHandle = temp;
            }
            SetForegroundWindow(lastWindowHandle);

            var send = richTextBox.Text;

            if (checkBox_trimSpaces.Checked)
            {
                send = Regex.Replace(send, @"\s+", "");
            }

            foreach (var item in send)
            {
                System.Windows.Forms.SendKeys.Send(item.ToString());
                Thread.Sleep(25);//wait btw keys
            }
        }
    }
}