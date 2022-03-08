using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form2 : Form

    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataReader rd;
        private string mssv,  toankhoa,  nh,  hk,  dtb,  xeploai;

        private void btnXuat_Click(object sender, EventArgs e)
        {
            xuatFile();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try {
                txtdtb.Text = dtb;
                txtxep.Text = xeploai;
                if (nh.Equals("")) { txtNH1.Text = "Toan Khoa Hoc"; txtNH2.Text = "Toan Khoa Hoc"; }
                else { txtNH1.Text = nh.Substring(0, 4); txtNH2.Text = nh.Substring(4, 4); }
                if (hk.Equals("")) { cbHK.SelectedIndex = -1; }
                else cbHK.SelectedItem = hk;
                try
                {

                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select * from ThongTin where mssv='" + mssv + "'", con);
                    con.Open();
                    rd = comm.ExecuteReader();

                    while (rd.Read())
                    {

                        txtMa.Text = rd.GetString(0);
                        txtTen.Text = rd.GetString(1);
                        txtNS.Text = rd.GetString(2);
                        txtGT.Text = rd.GetString(3);
                        txtE.Text = rd.GetString(5);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (toankhoa.Equals("1"))
                {
                    try
                    {

                        con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                        comm = new SqlCommand("select * from Diem where mssv='" + mssv + "'", con);
                        con.Open();
                        rd = comm.ExecuteReader();

                        while (rd.Read())
                        {
                            string[] row = new string[] {rd.GetString(1),rd.GetString(2),rd.GetString(4),rd.GetString(5),
                        rd.GetString(6),rd.GetString(7) };
                            dG1.Rows.Add(row);

                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else if (hk.Equals(""))
                {
                    try
                    {

                        con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                        comm = new SqlCommand("select * from Diem where mssv='" + mssv + "' and namHoc='" + nh + "'", con);
                        con.Open();
                        rd = comm.ExecuteReader();

                        while (rd.Read())
                        {
                            string[] row = new string[] {rd.GetString(1),rd.GetString(2),rd.GetString(4),rd.GetString(5),
                        rd.GetString(6),rd.GetString(7) };
                            dG1.Rows.Add(row);

                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    try
                    {

                        con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                        comm = new SqlCommand("select * from Diem where mssv='" + mssv + "' and namHoc='" + nh + "' and hocKy='" + hk + "'", con);
                        con.Open();
                        rd = comm.ExecuteReader();

                        while (rd.Read())
                        {
                            string[] row = new string[] {rd.GetString(1),rd.GetString(2),rd.GetString(4),rd.GetString(5),
                        rd.GetString(6),rd.GetString(7) };
                            dG1.Rows.Add(row);

                        }

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public Form2(string mssv, string toankhoa, string nh, string hk, string dtb, string xeploai)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.toankhoa = toankhoa;
            this.nh = nh;
            this.hk = hk;
            this.dtb = dtb;
            this.xeploai = xeploai;
        }
        private void xuatFile()
        {
            string fileName = @"C:\XuatFileDNET\";
            fileName += mssv;
            if (nh.Equals("")==false)
            {
                fileName +="-" +txtNH1.Text + txtNH2.Text;
            }
            if (cbHK.SelectedIndex != -1) fileName += "-Hk"+cbHK.SelectedItem.ToString();
            fileName += ".txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("{0}", txtMa.Text);
                    sw.WriteLine("{0}", txtTen.Text);
                    sw.WriteLine("{0}", txtNS.Text);
                    sw.WriteLine("{0}", txtGT.Text);
                    sw.WriteLine("{0}", txtE.Text);
                    sw.WriteLine("{0}", "---------------------------------------------------------------");
                    if(txtNH1.Text.Equals("")==false)
                    sw.WriteLine("Nam hoc: {0} - {1}", txtNH1.Text, txtNH2.Text);
                    if(cbHK.SelectedIndex!=-1)
                    sw.WriteLine("Hoc ky: {0}", cbHK.SelectedItem.ToString());
                    sw.WriteLine("{0}", "----------------------------");
                    sw.WriteLine("Diem Trung Binh: {0}", txtdtb.Text);
                    sw.WriteLine("Diem Trung Binh: {0}", txtxep.Text);
                    sw.WriteLine("{0}", "----------------------------");
                    sw.WriteLine("{0}", "---------------------------------------------------------------");
                    for (int rows = 0; rows < dG1.Rows.Count-1; rows++)
                    {
                        for (int col = 0; col < dG1.Rows[rows].Cells.Count-1; col++)
                        {
                            
                            string value = dG1.Rows[rows].Cells[col].Value.ToString();
                            if(col==0) sw.WriteLine("Nam hoc: {0}", value);
                            if (col == 1) sw.WriteLine("Hoc ky: {0}", value);
                            if (col == 2) sw.WriteLine("Ten HP: {0}", value);
                            if (col == 3) sw.WriteLine("So TC: {0}", value);
                            if (col == 4) sw.WriteLine("Diem chu: {0}", value);
                            if (col == 5) sw.WriteLine("Diem so: {0}", value);

                        }
                        sw.WriteLine("{0}", "----------------------------");
                    }
                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
