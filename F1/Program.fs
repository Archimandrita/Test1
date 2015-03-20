open System

//#r "C:/Windows/Microsoft.NET/Framework/v4.0.30319/System.Windows.Forms.dll"
open System.Windows.Forms
open System.Drawing
open System.Data
open System.Data.SQLite

//C:\Program Files\DevExpress 14.1\Components\Bin\Framework
open DevExpress.XtraGrid

type cg = DevExpress.XtraGrid.GridControl

let cs = """
 sdsd
"""

let sqlite_conn = new SQLiteConnection("Data Source=C:\Users\user\x;Version=3;")
sqlite_conn.Open()

//let sqlcmd = sqlite_conn.CreateCommand("Select * from Companies")
//let DB = new SQLiteDataAdapter(CommandText,sql_con)

let DA  = new SQLite.SQLiteDataAdapter("Select * from Companies" , sqlite_conn)
let DS = new Data.DataSet()

DA.Fill(DS) |> ignore

let DT = DS.Tables.[0]

(*
sql_cmd = sql_con.CreateCommand(); 
string CommandText = "select id, desc from mains"; 
DB = new SQLiteDataAdapter(CommandText,sql_con); 
DS.Reset(); 
DB.Fill(DS); 
DT= DS.Tables[0]; 
Grid.DataSource = DT; 
sql_con.Close();
*)

sqlite_conn.Close()

let form = new Form()


let cg1 = new cg()
cg1.Dock <- DockStyle.Fill

cg1.DataSource <- DT

form.Controls.Add(cg1)

let data = new DataTable()

form.Text <- "sdd"

form.BackColor <- Color.Beige
let b = new Windows.Forms.Button()
b.Text <- "press me"

type x = Form
 
form.Controls.Add(b)  

form.ShowDialog() |> ignore
