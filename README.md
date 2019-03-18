# CSharpToast
Create a toast in c#

This is a Microsoft Visual Studio project that demonstrates showing a toast message to the user.

A toast message is one that appears, then after a delay, disappears without user intervention.

This is needed when either the default language implementation is lacking, see java Android, or when there is no default language implementation.

I did google on this and found unfathomibly difficult or near impossible solutions.

This solution is a form, in straight c#, no crazy libs or anyting else needed.

The steps below illustrate the steps I took to create the toast, 
but you can, if desired, just download the app here with all of these steps already completed.

Usage:
  Call: Toast.show ("This is a test toast.");
 
DownloadURL:
  git clone https://github.com/pstorli/CSharpToast
  
Steps To Create:
  1) Create a new application in MS Visual Studio. 
  1.1) File -> New -> Application -> Windows Forms App (.NET Framework)
  1.2) Name app as desired, here I used CSharpToast
  
  2) Adjust initial form/screen
  2.1) Set Form1.cs name to MainWindow.cs
  2.4) Set the StartPosition to CenterScreen
  2.5) Add a button1 to the form. Set text to "Make Toast"
  2.6) Double click button. A new method should appear:
       private void button1_Click(object sender, EventArgs e)
  2.7) Add this code to it: 
       Toast.show ("Toast is done!");
  
  3) Create the toast form.
  3.1) In the solution explorer, Add -> New Item -> Windows Form
  3.1.1) Set the name to Toast.cs
  3.1.2) Set the toast form width and height to toast size, say 6 inches wide by 1/2" tall.
  3.1.3) Set the FormBorderStyle to None
  
  3.2) Add a label to your form
  3.2.1) Set the name to Message
  3.2.2) Set autosize to false.
  3.2.3) Set textalign to MiddleCenter
  3.2.4) Set Dock to fill
  
  3.3) Add some toasty processing logic to file Toast.cs
  3.3.1) Change Toast.cs from this:
  
    using System.Windows.Forms;
    namespace CSharpToast
    {    
        public partial class Toast : Form { 
            public Toast()
            {
                InitializeComponent();
            }
        }
    }
    
    3.3.2) Change Toast.cs to this:
