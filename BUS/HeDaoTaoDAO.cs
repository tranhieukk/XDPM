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
    }
}
