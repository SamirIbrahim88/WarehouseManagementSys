using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagementSystem1.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            SqlParameter[] param= new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("sp_login", param);
            return DT;
        }
        public void ADD_USER(string ID, string FULLNAME, string PWD, string USERTYPE)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            param[1].Value = FULLNAME;

            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[3].Value = USERTYPE;

            DAL.executecommand("ADD_USER", param);
            DAL.close();
        }
        public void EDITUSER(string ID, string FULLNAME, string PWD, string USERTYPE)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            param[1].Value = FULLNAME;

            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[3].Value = USERTYPE;

            DAL.executecommand("EDITUSER", param);
            DAL.close();
        }
        public void DELETEUSER(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;


            DAL.executecommand("DELETEUSER", param);
            DAL.close();
        }


        public DataTable SEARCHUSER(string CRITERION)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CRITERION ", SqlDbType.VarChar, 50);
            param[0].Value = CRITERION;

            DT = DAL.selectdata("SEARCHUSER", param);
            DAL.close();
            return DT;
        }

    }
}
