# Page-Engine-Proof-Of-Concept
Proof of concept of something that could help the conception of some C# WindowsForm app

Page Engine:
Allow making in WindowsForm app (c#) programs that work like UWP apps. You have a window where you can load documents. It has an history. The history work exactly like a web browser's history : you can navigate backward and forward. You can use the Visual Studio's UI Desingner to create pages because pages are only an interface (ex: public partial class MyPage : Form, iPage). The page engine is only two files : "PForm.cs" and "iPage.cs"
How it work:
The main form (PForm) is just a MDI container who contains every loaded "page" (form) inside. But PForm manage fully automaticaly every pages you add on it

DON'T FORGET to look at the main void in program.cs. This is important to use page engine, you will understand why.
I uploaded all the vs solution because I don't finnished to learn how Github work.
I hope you'll find it useful.
