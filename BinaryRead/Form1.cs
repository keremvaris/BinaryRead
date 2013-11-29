using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BinaryRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isoft9000DataSet.doc_dokuman_doczip' table. You can move, or remove it, as needed.
            this.doc_dokuman_doczipTableAdapter.Fill(this.isoft9000DataSet.doc_dokuman_doczip);

        }
        public static string Temizle(string Metin)
        {
            string deger = Metin;
            
            deger = deger.Replace(" ", "_");
            deger = deger.Replace("/", "_");
            deger = deger.Replace(">", "");
            deger = deger.Replace("&", "");
            deger = deger.Replace("[", "");
            deger = deger.Replace("]", "");
            deger = deger.Replace("--", "");
            deger = deger.Replace(";", "");

            return deger;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NEPTUN\DVLP2008;Initial Catalog=DocumentLibrary;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT big.doc_dokuman.id, 
big.doc_dokuman.dokuman_adi,
big.doc_dokuman_doczip.dokuman_no, 
big.doc_dokuman_doczip.zip 
FROM big.doc_dokuman_doczip
inner join 
big.doc_dokuman on 
big.doc_dokuman.dokuman_no=big.doc_dokuman_doczip.dokuman_no", conn);
            var t = new DataTable();
            da.Fill(t);
            foreach (DataRow row in t.Rows)
            {
                //var row = t.Rows[0];
                byte[] bytes = (byte[])row["zip"];
                string fname = (string)row["dokuman_no"] + "_" + (string)row["dokuman_adi"];
                fname = fname.Trim();
                File.WriteAllBytes(string.Format(@"c:\dosyalar\{0}.zip", Temizle(fname)), bytes);
            }
        }

				private void button2_Click(object sender, EventArgs e)
				{
					SqlConnection conn = new SqlConnection(@"Data Source=NEPTUN\DVLP2008;Initial Catalog=isoft9000;Integrated Security=True");
					SqlDataAdapter da = new SqlDataAdapter(@"SELECT 
big.doc_formlar.ad,
big.doc_formlar_webzip.form_no, 
big.doc_formlar_webzip.form

FROM big.doc_formlar_webzip
inner join 
big.doc_formlar on 
big.doc_formlar.form_no=big.doc_formlar_webzip.form_no", conn);
					var t = new DataTable();
					da.Fill(t);
					foreach (DataRow row in t.Rows)
					{
						//var row = t.Rows[0];
						byte[] bytes = (byte[])row["form"];
						string fname = (string)row["form_no"] + "_" + (string)row["ad"];
						fname = fname.Trim();
						File.WriteAllBytes(string.Format(@"c:\formlar\{0}.zip", Temizle(fname)), bytes);
					}
				}
    }
}
