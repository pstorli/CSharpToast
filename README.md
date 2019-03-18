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
  
Steps To Create:
  1) Create a  
  
  Add windows form item the size you want your toast, say 6 inches.
  1.1) Set the FormBorderStyle to None
  1.2) Set the StartPosition to CenterScreen

  2) Add a label
  2.1) Set autosize to false.
  2.2) Set textalign to MiddleCenter
  2.3) Set Dock to fill
