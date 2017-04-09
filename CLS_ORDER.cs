using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagementSystem1.BL
{
    class CLS_ORDER
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_LAST_ORDER_ID", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_LAST_ORDER_FOR_PRINT()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_LAST_ORDER_FOR_PRINT", null);
            DAL.close();
            return DT;
        }
        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID, string DESCRIPTION_ORDER, string SALES_MAN)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALES_MAN", SqlDbType.VarChar,75);
            param[4].Value = SALES_MAN;

            DAL.executecommand("ADD_ORDER", param);
            DAL.close();
        }
        public void ADD_ORDER_DETAILS(string ID_PRODUCT, int ID_ORDER, Double QTE, string PRICE, Double DISCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Float);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar,50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar,50);
            param[6].Value = TOTAL_AMOUNT;

            DAL.executecommand("ADD_ORDER_DETAILS", param);
            DAL.close();
        }
        public DataTable SEARCHORDERS(string criterion)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar,50);
            param[0].Value = criterion;

            DT = DAL.selectdata("SEARCHORDERS", param);
            DAL.close();
            return DT;
        }

        public DataTable VERIFYQUANTITY(string ID_PRODUCT, double QTY_ENTERED)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@QTY_ENTERED", SqlDbType.Float);
            param[1].Value = QTY_ENTERED;

            DT = DAL.selectdata("VERIFYQUANTITY", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ORDER_DETAILS(int ID_ORDER)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            DT = DAL.selectdata("GET_ORDER_DETAILS", param);
            DAL.close();
            return DT;
        }

    }
}
