using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         
        }
    }
    public class ThongTin
    {
        private string mssv;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sdt;

        public ThongTin()
        {
            this.mssv = "";
            this.hoTen = "";
            this.ngaySinh = "";
            this.gioiTinh = "";
            this.diaChi = "";
            this.email = "";
            this.sdt = "";

        }

        public void setmssv(string mssv) { this.mssv = mssv; }
        public void sethoTen(string hoTen) { this.hoTen = hoTen; }
        public void setngaySinh(string ngaySinh) { this.ngaySinh = ngaySinh; }
        public void setgioiTinh(string gioiTinh) { this.gioiTinh = gioiTinh; }
        public void setdiaChi(string diaChi) { this.diaChi = diaChi; }
        public void setemail(string email) { this.email = email; }
        public void setsdt(string sdt) { this.sdt = sdt; }

        public string getmssv() { return this.mssv; }
        public string gethoTen() { return this.hoTen; }
        public string getngaySinh() { return this.ngaySinh; }
        public string getgioiTinh() { return this.gioiTinh; }
        public string getdiaChi() { return this.diaChi; }
        public string getemail() { return this.email; }
        public string getsdt() { return this.sdt; }

    }
    public class Diem
    {
        private string id;
        private string namHoc;
        private string hocKy;
        private string mssv;
        private string tenHP;
        private string soTC;
        private string diemChu;
        private string diemSo;

        public string getid() { return this.id; }
        public string getnamHoc() { return this.namHoc; }
        public string gethocKy() { return this.hocKy; }
        public string getmssv() { return this.mssv; }
        public string gettenHP() { return this.tenHP; }
        public string getsoTC() { return this.soTC; }
        public string getdiemChu() { return this.diemChu; }
        public string getdiemSo() { return this.diemSo; }


        public void setid(string id) { this.id = id; }
        public void setnamHoc(string namHoc) { this.namHoc = namHoc; }
        public void sethocKy(string hocKy) { this.hocKy = hocKy; }
        public void setmssv(string mssv) { this.mssv = mssv; }
        public void settenHP(string tenHP) { this.tenHP = tenHP; }
        public void setsoTC(string soTC) { this.soTC = soTC; }
        public void setdiemChu(string diemChu) { this.diemChu = diemChu; }
        public void setdiemSo(string diemSo) { this.diemSo = diemSo; }

    }
    public static class ThaoTac
    {

    }
}
