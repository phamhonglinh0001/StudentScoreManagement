using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataReader rd;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            delTT();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiBangTT();
        }





        private void hienThiBangTT()
        {
            try
            {
                
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                comm = new SqlCommand("select * from ThongTin", con);
                con.Open();
                rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    string[] row = new string[] {rd.GetString(0),rd.GetString(1),rd.GetString(2),rd.GetString(3),
                        rd.GetString(4),rd.GetString(5),rd.GetString(6) };
                    dGTT.Rows.Add(row);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private string layTenChon()
        {
            try
            {
                DataGridViewRow row = dGTT.Rows[dGTT.CurrentCell.RowIndex];
                return row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private string layMSSVChon()
        {
            try
            {
                DataGridViewRow row = dGTT.Rows[dGTT.CurrentCell.RowIndex];
                return row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private void hienThiBangDiem(string mssv)
        {
            try
            {

                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                comm = new SqlCommand("select * from Diem where mssv='"+mssv+"'", con);
                con.Open();
                rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    string[] row = new string[] {rd.GetInt32(0).ToString(),rd.GetString(1),rd.GetString(2),rd.GetString(3),
                        rd.GetString(4),rd.GetString(5),rd.GetString(6),rd.GetString(7) };
                    dGDiem.Rows.Add(row);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void xoaTT()
        {
            txtMSSV.Text = "";
            txtTen.Text = "";
            txtNS.Text = "";
            rdNam.Checked = true;
            txtDC.Text = "";
            txtE.Text = "";
            txtSDT.Text = "";

        }
        private void xoaDiem()
        {
            txtNH1.Text = "";
            txtNH2.Text = "";
            cbHK.SelectedIndex = -1;
            txtHP.Text = "";
            txtTC.Text = "";
            txtDieS.Text = "";
            try
            {

                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                comm = new SqlCommand("select max(ID) from Diem", con);
                con.Open();
                txtID.Text = (Convert.ToInt32(comm.ExecuteScalar()) + 1).ToString();
                
                txtMSSV2.Text = layMSSVChon();
                con.Close();
            }
            catch (Exception ex)
            {
                txtID.Text = "1";
                Console.WriteLine(ex);
            }

        }

        private void dGTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            xoaBangDiem();
            try
            {

                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                comm = new SqlCommand("select max(ID) from Diem", con);
                con.Open();
                txtID.Text = (Convert.ToInt32(comm.ExecuteScalar().ToString())+1).ToString();
                txtMSSV2.Text = layMSSVChon();
                con.Close();
            }
            catch (Exception ex)
            {
                txtID.Text = "1";
                Console.WriteLine(ex);
            }
            hienThiBangDiem(layMSSVChon());
            txtMSSV2.Text = layMSSVChon();
            txtMSSVX.Text = layMSSVChon();
            txtTenX.Text = layTenChon();
        }
        private void suaTT()
        {
            try
            {

                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                con.Open();
                string gioitinh = "";
                if (rdNam.Checked) gioitinh = "Nam"; else gioitinh = "Nu";
                string sql = "update ThongTin set hoTen='" + txtTen.Text +"', ngaySinh='"+txtNS.Text+"',gioiTinh='"+gioitinh+"',diaChi='"+txtDC.Text+"',email='"+txtE.Text+"',sdt='"+txtSDT.Text+"' "+"where mssv='"+txtMSSV.Text+"'";
                comm = new SqlCommand(sql, con);
 
                comm.ExecuteNonQuery();
                con.Close();
                xoaBangTT();
                hienThiBangTT();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void suaDiem()
        {
            try
            {

                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                con.Open();
                string hocky = "";
                if (cbHK.SelectedIndex==0) hocky = "1";
                if (cbHK.SelectedIndex == 1) hocky = "2";
                if (cbHK.SelectedIndex == 2) hocky = "3";
                string sql = "update Diem set namHoc='" + txtNH1.Text+txtNH2.Text + "', hocKy='" + hocky + "',mssv='" + txtMSSV2.Text + "',tenHP='" + txtHP.Text + "',soTC='" + txtTC.Text + "',diemChu='" + txtDieC.Text + "',diemSo='" + txtDieS.Text + "' " + "where id='" + txtID.Text + "'";
                comm = new SqlCommand(sql, con);

                comm.ExecuteNonQuery();
                con.Close();
                xoaBangDiem();
                
                hienThiBangDiem(layMSSVChon());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dGTT.Rows[dGTT.CurrentCell.RowIndex];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtNS.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString().Equals("Nam")) rdNam.Checked = true; else rdNu.Checked = true;
                txtDC.Text = row.Cells[4].Value.ToString();
                txtE.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

            }
            btnLuu1.Visible = true;
            btnThoat1.Visible = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMSSV.Enabled = false;
            btnTim.Enabled = false;
            btnSua.Visible = false;
            //suaTT();
            //xoaTT();
        }
        private void xoaBangTT()
        {
            for (int i = 0; i < dGTT.Rows.Count - 1; i++)
            {
                dGTT.Rows.RemoveAt(i);
                i--;
                while (dGTT.Rows.Count == 0)
                    continue;
            }
        }
        private void xoaBangDiem()
        {
            for (int i = 0; i < dGDiem.Rows.Count - 1; i++)
            {
                dGDiem.Rows.RemoveAt(i);
                i--;
                while (dGDiem.Rows.Count == 0)
                    continue;
            }
        }
        private void delTT()
        {
            try
            {
                DataGridViewRow row = dGTT.Rows[dGTT.CurrentCell.RowIndex];
                string mssv = row.Cells[0].Value.ToString();
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                string sql = "delete from ThongTin where mssv='" + mssv + "'";
                comm = new SqlCommand(sql, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                xoaBangTT();
                hienThiBangTT();
                xoaTT();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private void delDiem()
        {
            try
            {
                DataGridViewRow row = dGDiem.Rows[dGDiem.CurrentCell.RowIndex];
                string id = row.Cells[0].Value.ToString();
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                string sql = "delete from Diem where ID='" + id + "'";
                comm = new SqlCommand(sql, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                xoaBangDiem();
                hienThiBangDiem(layMSSVChon());
                xoaDiem();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void themTT()
        {
            try
            {
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");

                string gioitinh = "";
                if (rdNam.Checked) gioitinh = "Nam"; else gioitinh = "Nu";
                string sql = "insert into ThongTin values ('"+ txtMSSV.Text +"','" + txtTen.Text + "','" + txtNS.Text + "','" + gioitinh + "','" + txtDC.Text + "','" + txtE.Text + "','" + txtSDT.Text + "')" ;
                
                comm = new SqlCommand(sql, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                xoaBangTT();
                hienThiBangTT();
                xoaTT();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themTT();
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            suaTT();
            xoaTT();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnTim.Enabled = true;
            btnSua.Visible = true;
            btnLuu1.Visible = false;
            txtMSSV.Enabled = true;
            btnThoat1.Visible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            labelNhapTen.Visible = true;
            txtNhapTen.Visible = true;
            btnKetQua.Visible = true;
            btnTim.Enabled = false;
            btnThoatTK.Visible = true;
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                xoaBangTT();
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                string ten = txtNhapTen.Text;
                comm = new SqlCommand("select * from ThongTin where hoTen like '%"+ten+"%'", con);
                con.Open();
                rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    string[] row = new string[] {rd.GetString(0),rd.GetString(1),rd.GetString(2),rd.GetString(3),
                        rd.GetString(4),rd.GetString(5),rd.GetString(6) };
                    dGTT.Rows.Add(row);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTim.Enabled = true;
            btnKetQua.Visible = false;
            btnThoatTK.Visible = false;
            labelNhapTen.Visible = false;
            txtNhapTen.Visible = false;
            xoaBangTT();
            hienThiBangTT();
        }

        private void dGTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string quyDoiDiem(string diemSo)
        {
            try
            {

                if (Convert.ToDouble(diemSo) >= 0 && Convert.ToDouble(diemSo) < 4.0) return "F";
                else if (Convert.ToDouble(diemSo) >= 4.0 && Convert.ToDouble(diemSo) < 5.0) return "D";
                else if (Convert.ToDouble(diemSo) >= 5.0 && Convert.ToDouble(diemSo) < 5.4) return "D+";
                else if (Convert.ToDouble(diemSo) >= 5.5 && Convert.ToDouble(diemSo) < 6.5) return "C";
                else if (Convert.ToDouble(diemSo) >= 6.5 && Convert.ToDouble(diemSo) < 7.0) return "C+";
                else if (Convert.ToDouble(diemSo) >= 7.0 && Convert.ToDouble(diemSo) < 8.0) return "B";
                else if (Convert.ToDouble(diemSo) >= 8.0 && Convert.ToDouble(diemSo) < 9.0) return "B+";
                else if (Convert.ToDouble(diemSo) >= 9.0 && Convert.ToDouble(diemSo) <= 10.0) return "A";
                else return "";
            }catch(Exception ex)
            {
                return "";
            }
        }
        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");

                string hocky = "";
                if (cbHK.SelectedIndex == 0) hocky = "1";
                if (cbHK.SelectedIndex == 1) hocky = "2";
                if (cbHK.SelectedIndex == 2) hocky = "3";
                string sql = "insert into Diem values ('" + Convert.ToInt32(txtID.Text) + "','" + txtNH1.Text+txtNH2.Text + "','" + hocky + "','" + txtMSSV2.Text + "','" + txtHP.Text + "','" + txtTC.Text + "','" + txtDieC.Text + "','"+txtDieS.Text+"')";

                comm = new SqlCommand(sql, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                
                xoaBangDiem();
                xoaDiem();
                hienThiBangDiem(layMSSVChon());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtDieS_TextChanged(object sender, EventArgs e)
        {
            txtDieC.Text = quyDoiDiem(txtDieS.Text);
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dGDiem.Rows[dGDiem.CurrentCell.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtNH1.Text = row.Cells[1].Value.ToString().Substring(0,4);
                txtNH2.Text = row.Cells[1].Value.ToString().Substring(4,4);
                
                if (row.Cells[2].Value.ToString().Equals("1")) cbHK.SelectedIndex = 0;
                if (row.Cells[2].Value.ToString().Equals("2")) cbHK.SelectedIndex = 1;
                if (row.Cells[2].Value.ToString().Equals("3")) cbHK.SelectedIndex = 2;
                txtHP.Text = row.Cells[4].Value.ToString();
                txtTC.Text = row.Cells[5].Value.ToString();
                txtDieC.Text = row.Cells[6].Value.ToString();
                txtDieS.Text = row.Cells[7].Value.ToString();
                txtMSSV2.Text = layMSSVChon();
            }
            catch (Exception ex)
            {

            }
            btnLuu2.Visible = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            txtMSSV2.Enabled = false;
            
            
            btnSua2.Visible = false;
            btnThoat2.Visible = true; 
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            
            suaDiem();
            xoaDiem();
            btnThem2.Enabled = true;
            btnXoa2.Enabled = true;
           
            
            btnSua2.Visible = true;
            btnLuu2.Visible = false;
            cbHK.SelectedIndex = -1;
            btnThoat2.Visible = false;
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            delDiem();
        }
        private Double giaTriDiemChu(string diem)
        {
            if (diem.Equals("A")) return 4.0;
            if (diem.Equals("B+")) return 3.5;
            if (diem.Equals("B")) return 3.0;
            if (diem.Equals("C+")) return 2.5;
            if (diem.Equals("C")) return 2.0;
            if (diem.Equals("D+")) return 1.5;
            if (diem.Equals("D")) return 1.0;
            return 0;
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            txtCNH1.Enabled = false;
            txtCNH2.Enabled = false;
            cbCHK.Enabled = false;
        }

        private void rdTNH_CheckedChanged(object sender, EventArgs e)
        {
            txtCNH1.Enabled = true;
            txtCNH2.Enabled = true;
            cbCHK.Enabled = false;
        }

        private void rdTHK_CheckedChanged(object sender, EventArgs e)
        {
            txtCNH1.Enabled = true;
            txtCNH2.Enabled = true;
            cbCHK.Enabled = true;
        }

        private void btnDTB_Click(object sender, EventArgs e)
        {
            if(rdAll.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                    txtDTB.Text = Math.Round((tong / tc),2).ToString();
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            if (rdTNH.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "' and namHoc='"+txtCNH1.Text+txtCNH2.Text+"'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                    txtDTB.Text = Math.Round((tong / tc), 2).ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            if (rdTHK.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "' and namHoc='" + txtCNH1.Text + txtCNH2.Text + "' and hocKy='"+cbCHK.SelectedItem.ToString()+"'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                    txtDTB.Text = Math.Round((tong / tc), 2).ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }
            txtXep.Text = xepLoai(Convert.ToDouble(txtDTB.Text));
        }
        private string xepLoai(double dtb)
        {
            if (dtb >= 0 && dtb < 1.0) return "Kem";
            if (dtb >= 1.0 && dtb < 2.0) return "Yeu";
            if (dtb >= 2.0 && dtb < 2.5) return "TB";
            if (dtb >= 2.5 && dtb < 3.2) return "Kha";
            if (dtb >= 3.2 && dtb < 3.6) return "Gioi";
            if (dtb >= 3.6 && dtb <= 4.0) return "Xuat sac";

            return "";
        }
        private void txtDTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            xoaTT();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnTim.Enabled = true;
            btnSua.Visible = true;
            btnLuu1.Visible = false;
            txtMSSV.Enabled = true;
            btnThoat1.Visible = false;
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            xoaDiem();
            btnThem2.Enabled = true;
            btnXoa2.Enabled = true;


            btnSua2.Visible = true;
            btnLuu2.Visible = false;
            cbHK.SelectedIndex = -1;
            btnThoat2.Visible = false;
        }

        private void rdAll3_CheckedChanged(object sender, EventArgs e)
        {
            txtNH13.Enabled = false;
            txtNH23.Enabled = false;
            cbHK3.Enabled = false;
        }

        private void rdTNH3_CheckedChanged(object sender, EventArgs e)
        {
            txtNH13.Enabled = true;
            txtNH23.Enabled = true;
            cbHK3.Enabled = false;
        }

        private void rdTHK3_CheckedChanged(object sender, EventArgs e)
        {
            txtNH13.Enabled = true;
            txtNH23.Enabled = true;
            cbHK3.Enabled = true;
        }
        
        string xeploai, dtb, toankhoa, nh, hk;
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (rdAll3.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                     dtb = Math.Round((tong / tc),2).ToString();
                    toankhoa = "1";
                    nh = "";
                    hk = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            if (rdTNH3.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "' and namHoc='" + txtNH13.Text + txtNH23.Text + "'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                    dtb = Math.Round((tong / tc), 2).ToString();
                    toankhoa = "0";
                    nh = txtNH13.Text + txtNH23.Text;
                    hk = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            if (rdTHK3.Checked)
            {
                try
                {
                    string mssv = layMSSVChon();
                    con = new SqlConnection("Server=DESKTOP-2S9L0GP\\SQLEXPRESS;Database=QLSV;user id=sa;Password=sa2017");
                    comm = new SqlCommand("select soTC, diemChu from Diem where mssv='" + mssv + "' and namHoc='" + txtNH13.Text + txtNH23.Text + "' and hocKy='" + cbHK3.SelectedItem.ToString() + "'", con);
                    con.Open();
                    rd = comm.ExecuteReader();
                    double tong = 0, tc = 0;
                    while (rd.Read())
                    {
                        tong = tong + (Convert.ToDouble(rd.GetString(0)) * giaTriDiemChu(rd.GetString(1)));
                        tc = tc + Convert.ToDouble(rd.GetString(0));
                    }
                    dtb = Math.Round((tong / tc), 2).ToString();
                    toankhoa = "0";
                    nh = txtNH13.Text + txtNH23.Text;
                    hk = cbHK3.SelectedItem.ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            xeploai = xepLoai(Convert.ToDouble(dtb));
            Form2 f2 = new Form2(layMSSVChon(), toankhoa, nh, hk, dtb, xeploai);
            f2.Visible = true;
            
        }
    }
    }
    

