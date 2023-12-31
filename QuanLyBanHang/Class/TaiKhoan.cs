﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Class
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan 
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value; 
        }
        
        private string matKhau;

        public string MatKhau 
        { 
            get => matKhau;
            set => matKhau = value;
        }
        

        private bool loaiTaiKhoan;

        public bool LoaiTaiKhoan 
        { 
            get => loaiTaiKhoan;
            set => loaiTaiKhoan = value; 
        }

        public TaiKhoan(string tentaikhoan, string matkhau, bool loaitaikhoan)
        {
            this.TenTaiKhoan= tentaikhoan;
            this.MatKhau= matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
        }
    }
}
