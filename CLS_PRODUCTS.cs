using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagementSystem1.BL
{
    class CLS_PRODUCTS
    {

        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_CATEGORIES", null);
            DAL.close();
            return DT;
        }
        public void ADD_PRODUCT(int ID_CAT, string LABEL_PRODUCT, string ID_PRODUCT, string QTE, string PRICE, byte[] IMG, string criterion)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0]=new SqlParameter("ID_CAT",SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("ID_PRODUCT", SqlDbType.NVarChar,50);
            param[1].Value = ID_PRODUCT;

            param[2] = new SqlParameter("Label", SqlDbType.NVarChar, 50);
            param[2].Value = LABEL_PRODUCT;

            param[3] = new SqlParameter("QTE", SqlDbType.NVarChar, 50);
            param[3].Value=QTE;

            param[4] = new SqlParameter("PRICE", SqlDbType.NVarChar, 50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = IMG;

            param[6] = new SqlParameter("@criterion", SqlDbType.NVarChar, 50);
            param[6].Value = criterion;
            DAL.executecommand("ADD_PRODUCT", param);
            DAL.close();
        }
        public void UPDATE_PRODUCT(int ID_CAT, string ID_PRODUCT, string LABEL_PRODUCT, string QTE, string PRICE, byte[] IMG, string criterion)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("ID_PRODUCT", SqlDbType.NVarChar, 50);
            param[1].Value = ID_PRODUCT;

            param[2] = new SqlParameter("Label", SqlDbType.NVarChar, 50);
            param[2].Value = LABEL_PRODUCT;

            param[3] = new SqlParameter("QTE", SqlDbType.NVarChar, 50);
            param[3].Value = QTE;

            param[4] = new SqlParameter("PRICE", SqlDbType.NVarChar, 50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = IMG;

            param[6] = new SqlParameter("@criterion", SqlDbType.NVarChar, 50);
            param[6].Value = criterion;


            DAL.executecommand("UPDATE_PRODUCT", param);
            DAL.close();
        }

        public DataTable VERIFYPRODUCTID(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer( );
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;
            DT = DAL.selectdata("VERIFYPRODUCTID", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_PRODUCT()
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_PRODUCT", null);
            DAL.close();
            return DT;
        }
        public DataTable VERIFYMEMBER(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DT = DAL.selectdata("VERIFYMEMBER", param);
            DAL.close();
            return DT;
        }

        public void DELETEPRODUCT(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.executecommand("DeleteProduct", param);
            DAL.close();
        }
        public DataTable SEARCHPRODUCT(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DT = DAL.selectdata("SEARCHPRODUCT", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_IMAGE_PRODUCTS(string ID)
        {
            DAL.dataAccessLayer DAL = new DAL.dataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DT = DAL.selectdata("GET_IMAGE_PRODUCTS", param);
            DAL.close();
            return DT;
        }
    }
}
