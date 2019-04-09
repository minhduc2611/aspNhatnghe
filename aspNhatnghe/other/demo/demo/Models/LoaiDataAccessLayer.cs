using ASPCore.ADONETLab.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class LoaiDataAccessLayer
    {
        public List<Loai> ToList()
        {
            DataTable dtLoai = DataProvider.SelectData("SELECT * FROM Loai", CommandType.Text, null);
            List<Loai> dsLoai = new List<Loai>();

            foreach (DataRow dr in dtLoai.Rows)
            {
                Loai tmp = new Loai();
                tmp.MaLoai = int.Parse(dr["MaLoai"].ToString());
                tmp.TenLoai = dr["TenLoai"].ToString();
                tmp.MoTa = dr["MoTa"].ToString();
                tmp.Hinh = dr["Hinh"].ToString();

                dsLoai.Add(tmp);
            }
            return dsLoai;
        }

        //Get the details of a particular employee
        public Loai GetLoai(int? id)
        {
            if (!id.HasValue) return null;
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            DataTable dtLoai = DataProvider.SelectData("spLayLoai",
           CommandType.StoredProcedure, pa);
            if (dtLoai.Rows.Count > 0)
            {
                var row = dtLoai.Rows[0];
                return new Loai()
                {
                    MaLoai = Convert.ToInt32(row["MaLoai"]),
                    TenLoai = row["TenLoai"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    Hinh = row["Hinh"].ToString()
                };
            }
            return null;
        }

        /// <summary>
        /// Them loai
        /// </summary>
        /// <param name="lo"> thong tin loai</param>
        /// <returns>Ma Loai vua them</returns>

        //To Add new employee record
        public int AddLoai(Loai lo)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaLoai", SqlDbType.Int);
            pa[0].Direction = ParameterDirection.Output;
            pa[1] = new SqlParameter("TenLoai", lo.TenLoai);
            pa[2] = new SqlParameter("MoTa", lo.MoTa);
            pa[3] = new SqlParameter("Hinh", lo.Hinh);
            DataProvider.ExcuteNonQuery("spThemLoai", CommandType.StoredProcedure, pa);


            return int.Parse(pa[0].Value.ToString());
        }
        //To Update the records of a particluar employee
        public void UpdateLoai(Loai lo)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaLoai", lo.MaLoai);
            pa[1] = new SqlParameter("TenLoai", lo.TenLoai);
            pa[2] = new SqlParameter("MoTa", lo.MoTa);
            pa[3] = new SqlParameter("Hinh", lo.Hinh);
            DataProvider.ExcuteNonQuery("spSuaLoai", CommandType.StoredProcedure, pa);
        }
        //To Delete the record on a particular employee
        public void DeleteLoai(int? id)
        {
            if (!id.HasValue) return;
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            DataTable dtLoai = DataProvider.SelectData("spXoaLoai",
           CommandType.StoredProcedure, pa);
        }


    }
}
