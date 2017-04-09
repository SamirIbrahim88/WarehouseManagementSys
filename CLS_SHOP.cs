using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagementSystem1.BL
{
    class CLS_SHOP
    {
        public DataTable GET_LAST_SHOP_ID()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_LAST_SHOP_ID", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_LAST_SHOP_FOR_PRINT()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_LAST_SHOP_FOR_PRINT", null);
            DAL.close();
            return DT;
        }
        public void ADD_SHOP(int ID_SHOP, DateTime DATE_ORDER, int TRADER_ID, string DESCRIPTION_ORDER, string PAYMAN)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_SHOP", SqlDbType.Int);
            param[0].Value = ID_SHOP;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@TRADER_ID", SqlDbType.Int);
            param[2].Value = TRADER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@PAYMAN", SqlDbType.VarChar, 75);
            param[4].Value = PAYMAN;

            DAL.executecommand("ADD_SHOP", param);
            DAL.close();
        }
        public void ADD_SHOP_DETAILS(string ID_PRODUCT, int ID_shop, double QTE, string PRICE, string AMOUNT, string TOTAL_AMOUNT, Double DISCOUNT)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_shop", SqlDbType.Int);
            param[1].Value = ID_shop;

            param[2] = new SqlParameter("@QTE", SqlDbType.Float);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[4].Value = AMOUNT;

            param[5] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[5].Value = TOTAL_AMOUNT;

            param[6] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[6].Value = DISCOUNT;

            DAL.executecommand("ADD_SHOP_DETAILS", param);
            DAL.close();
        }
        public DataTable SEARCHSHOP(string criterion)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar,50);
            param[0].Value = criterion;

            DT = DAL.selectdata("SEARCHSHOP", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_SHOP_DETAILS(int ID_SHOP)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_SHOP", SqlDbType.Int);
            param[0].Value = ID_SHOP;

            DT = DAL.selectdata("GET_SHOP_DETAILS", param);
            DAL.close();
            return DT;
        }

    }
}
