using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class demoController : Controller
    {
        public IActionResult GetData()
        {
            //buoc 1 tao bien ket noi  
            SqlConnection con = new SqlConnection(MyTool.GetConnectionString("EStore"));
            // buoc  2 : khai bao cau lenh
            string sql = "SELECT hh.* FROM HangHoa hh WHERE DonGia > 10 ";
            SqlDataAdapter da = new SqlDataAdapter(sql,con); // do? ve
                                                             //data set de hung ve, sql server day ve data table ===> sql tra ve 1 data table

            // jkhai bao sql command  / khai baio truc tiep
            DataTable data = new DataTable(); // tu cai bang nay, chung ta co the xu ly tuy y

            da.Fill(data);
            return Content($" Co {data.Rows.Count} hang hoa ");
        }

        public IActionResult Execute()
        {
            String sqlInsert = "INSERT INTO Loai(TenLoai,Mota) VALUES(N'Banh khot',N'Cac Loai Banh')";
            try
            {
                SqlConnection con = new SqlConnection(MyTool.GetConnectionString("EStore"));
                con.Open();
                SqlCommand command = new SqlCommand(sqlInsert, con);
                int result = command.ExecuteNonQuery();
                con.Close();
                return Content($"vua them {result} hang hoa");
            }
            catch(Exception ex)
            {
                return Content($"loi :{ex.Message}");

            }


        }
        

    }
}