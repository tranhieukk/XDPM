using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class KhoaHocDAO
    {
        private KhoaHocDAO() { }
        private static KhoaHocDAO instance = new KhoaHocDAO();

        public static KhoaHocDAO Instance
        {
            get { if (instance == null) instance = new KhoaHocDAO(); return instance; }
            private set => instance = value;
        }
        public DataTable getAllData()
        {
            string query = "Exec USP_getAllKhoaHoc";
            return DAL.DataProvider.Instance.ExecuteQuery(query);
        }

        public int addKhoaHoc(string maKhoaHoc, string ngayBatDau, string ngayKetthuc)
        {
            string query = "Exec USP_addKhoaHoc @maKhoaHoc , @ngayBatDau , @ngayKetthuc";
            return DAL.DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhoaHoc, ngayBatDau, ngayKetthuc });
        }
    }
}
