using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;

namespace BUS
{
    public class HeDaoTaoDAO
    {
        private HeDaoTaoDAO() { }
        private static HeDaoTaoDAO instance;

        public static HeDaoTaoDAO Instance {
            get { if(instance==null) instance= new HeDaoTaoDAO(); return instance; }
            private set => instance = value; }

        public List<HeDaoTao> GetListHeDaoTao()
        {
            List<HeDaoTao> list = new List<HeDaoTao>();
            DataTable data = new DataTable();
            string query = "Exec USP_getAllHeDaoTao ";
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                HeDaoTao heDaoTao = new HeDaoTao(item);
                
                list.Add(heDaoTao);
            }
            return list;
        }
        public int Insert(HeDaoTao hdt)
        {
            string query = "Exec addHeDaoTao @maHeDT , @tenHDT ";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] {hdt.MaHe,hdt.TenHe })
        }
        public int Remove(HeDaoTao hdt)
        {
            string query = "Exec deleteHeDaoTao @maHeDT  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hdt.MaHe });
        }
        public int Update(HeDaoTao hdt,string mahdtOld)
        {
            string query = "Exec updateHeDaoTao @maHDTOld , @maHeDT , @tenHDT ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {mahdtOld, hdt.MaHe, hdt.TenHe })
        }
    }
}
