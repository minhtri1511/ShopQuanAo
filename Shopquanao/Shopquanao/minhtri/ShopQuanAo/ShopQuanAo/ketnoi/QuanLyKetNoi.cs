﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ShopQuanAo
{
    public class QuanLyKetNoi
    {
        public SqlConnection cnn;
        public QuanLyKetNoi()
        {
            //CHINH LAI DUONG DAN PHU HOP VOI CAU HINH SQLSERVER CUA BAN 
            string strcnn = "Data Source=DESKTOP-HP9CAAB\\SQLEXPRESS;Initial Catalog=ShopQuanAo;Integrated Security=True";
            cnn = new SqlConnection(strcnn);
        }
        public void Open()
        {
            cnn.Open();
        }
        public void Close()
        {
            cnn.Close();
        }
    }
}