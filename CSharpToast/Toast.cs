using System;
using System.Timers;
using System.Windows.Forms;
namespace CSharpToast
{    
    public partial class Toast : Form {

        public static int DEFAULT_MS_DELAY = 2500;
        private delegate void SafeOnTimedEvent(Object source, ElapsedEventArgs e);

        public Toast(String message)
        {
            InitializeComponent();

            Message.Text = message;
        }

        public static Toast show (String message)
        {
            return show(message, DEFAULT_MS_DELAY);
        }

        public static Toast show (String message, int ms)
        {
            Toast toast = new Toast(message);
            System.Timers.Timer aTimer = new System.Timers.Timer(ms);
            aTimer.Elapsed += toast.OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
            toast.ShowDialog();

            return toast;
        }

        private void OnTimedEvent (Object source, ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                var d = new SafeOnTimedEvent(OnTimedEvent);
                Invoke(d, new object[] { source, e });
            }
            else
            {
                Close();
            }
        }        
    }
}
