using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagementSystem1.BL
{
    class CLS_TRADER
    {
        public DataTable GET_ALL_TRADERS()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_TRADERS", null);
            DAL.close();
            return DT;
        }
        public void ADD_TRADER(string FIRST_NAME, string LAST_NAME, string TEL, string EMAIL, byte[] IMG, string criterion)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME ", SqlDbType.VarChar, 25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 15);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@IMG", SqlDbType.Image);
            param[4].Value = IMG;

            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;

            DAL.executecommand("ADD_TRADER", param);
            DAL.close();
        }
        public void UPDATE_TRADER(string FIRST_NAME, string LAST_NAME, string TEL, string EMAIL, byte[] IMG, string criterion, int ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME ", SqlDbType.VarChar, 25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 15);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            param[3].Value = EMAIL;


            param[4] = new SqlParameter("@IMG", SqlDbType.Image);
            param[4].Value = IMG;

            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = ID;


            DAL.executecommand("UPDATE_TRADER", param);
            DAL.close();
        }
        public void DELETE_TRADERS(int id)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("DELETE_TRADERS", param);
            DAL.close();
        }
        public DataTable SEARCH_TRADERS(string CRITERION)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CRITERION", SqlDbType.VarChar, 50);
            param[0].Value = CRITERION;
            DT = DAL.selectdata("SEARCH_TRADERS", param);
            DAL.close();
            return DT;
        }
    }
}
