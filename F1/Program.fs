open System
//#r "C:/Windows/Microsoft.NET/Framework/v4.0.30319/System.Windows.Forms.dll"
open System.Windows.Forms
open System.Drawing
//C:\Program Files\DevExpress 14.1\Components\Bin\Framework
 
let form = new Form()
 
form.Text <- "sdd"

form.BackColor <- Color.Beige

let b = new Windows.Forms.Button()
b.Text <- "press me"

type x = Form
     
let f = new x()   
//test
 
f.Show()


form.Controls.Add(b)  

form.ShowDialog() |> ignore
