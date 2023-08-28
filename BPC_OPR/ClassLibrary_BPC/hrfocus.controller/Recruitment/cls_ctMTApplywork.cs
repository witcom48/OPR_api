﻿using ClassLibrary_BPC.hrfocus.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_BPC.hrfocus.controller
{
    public class cls_ctMTApplywork
    {
        string Message = string.Empty;

        cls_ctConnection Obj_conn = new cls_ctConnection();

        public cls_ctMTApplywork() { }

        public string getMessage() { return this.Message.Replace("REQ_MT_APPLYWORK", "").Replace("cls_ctMTApplywork", "").Replace("line", ""); }

        public void dispose()
        {
            Obj_conn.doClose();
        }

        private List<cls_MTWorker> getData(string condition)
        {
            List<cls_MTWorker> list_model = new List<cls_MTWorker>();
            cls_MTWorker model;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT ");

                obj_str.Append("COMPANY_CODE");
                obj_str.Append(", WORKER_ID");
                obj_str.Append(", WORKER_CODE");
                obj_str.Append(", WORKER_CARD");
                obj_str.Append(", WORKER_INITIAL");
                obj_str.Append(", ISNULL(WORKER_FNAME_TH, '') AS WORKER_FNAME_TH");
                obj_str.Append(", ISNULL(WORKER_LNAME_TH, '') AS WORKER_LNAME_TH");
                obj_str.Append(", ISNULL(WORKER_FNAME_EN, '') AS WORKER_FNAME_EN");
                obj_str.Append(", ISNULL(WORKER_LNAME_EN, '') AS WORKER_LNAME_EN");
                obj_str.Append(", WORKER_TYPE");
                obj_str.Append(", WORKER_STATUS");
                obj_str.Append(", WORKER_GENDER");
                obj_str.Append(", WORKER_BIRTHDATE");
                obj_str.Append(", WORKER_HIREDATE");
                obj_str.Append(", RELIGION_CODE");
                obj_str.Append(", BLOOD_CODE");
                obj_str.Append(", WORKER_HEIGHT");
                obj_str.Append(", WORKER_WEIGHT");
                //obj_str.Append(", ISNULL(WORKER_AGE, 0) AS WORKER_AGE");
                obj_str.Append(", ISNULL(WORKER_TEL, '') AS WORKER_TEL");
                obj_str.Append(", ISNULL(WORKER_EMAIL, '') AS WORKER_EMAIL");
                obj_str.Append(", ISNULL(WORKER_LINE, '') AS WORKER_LINE");
                obj_str.Append(", ISNULL(WORKER_FACEBOOK, '') AS WORKER_FACEBOOK");

                obj_str.Append(", ISNULL(WORKER_MILITARY, '') AS WORKER_MILITARY");
                obj_str.Append(", ISNULL(NATIONALITY_CODE, '') AS NATIONALITY_CODE");

                obj_str.Append(", ISNULL(WORKER_CARDNO, '') AS WORKER_CARDNO");
                obj_str.Append(", ISNULL(WORKER_CARDNOISSUEDATE, '01/01/2999') AS WORKER_CARDNOISSUEDATE");
                obj_str.Append(", ISNULL(WORKER_CARDNOEXPIREDATE, '01/01/2999') AS WORKER_CARDNOEXPIREDATE");

                obj_str.Append(", STATUS");

                obj_str.Append(", ISNULL(REQ_MT_WORKER.MODIFIED_BY, REQ_MT_WORKER.CREATED_BY) AS MODIFIED_BY");
                obj_str.Append(", ISNULL(REQ_MT_WORKER.MODIFIED_DATE, REQ_MT_WORKER.CREATED_DATE) AS MODIFIED_DATE");

                obj_str.Append(", ISNULL(INITIAL_NAME_TH, '') AS INITIAL_NAME_TH");
                obj_str.Append(", ISNULL(INITIAL_NAME_EN, '') AS INITIAL_NAME_EN");

                obj_str.Append(" FROM REQ_MT_WORKER");
                obj_str.Append(" INNER JOIN EMP_MT_INITIAL ON REQ_MT_WORKER.WORKER_INITIAL=EMP_MT_INITIAL.INITIAL_CODE");

                obj_str.Append(" WHERE 1=1");

                if (!condition.Equals(""))
                    obj_str.Append(" " + condition);

                obj_str.Append(" ORDER BY COMPANY_CODE, WORKER_CODE");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    model = new cls_MTWorker();

                    model.company_code = dr["COMPANY_CODE"].ToString();

                    model.worker_id = Convert.ToInt32(dr["WORKER_ID"]);
                    model.worker_code = dr["WORKER_CODE"].ToString();
                    model.worker_card = dr["WORKER_CARD"].ToString();
                    model.worker_initial = dr["WORKER_INITIAL"].ToString();
                    model.worker_fname_th = dr["WORKER_FNAME_TH"].ToString();
                    model.worker_lname_th = dr["WORKER_LNAME_TH"].ToString();
                    model.worker_fname_en = dr["WORKER_FNAME_EN"].ToString();
                    model.worker_lname_en = dr["WORKER_LNAME_EN"].ToString();
                    model.worker_type = dr["WORKER_TYPE"].ToString();
                    model.worker_status = dr["WORKER_STATUS"].ToString();

                    model.worker_gender = dr["WORKER_GENDER"].ToString();
                    model.worker_birthdate = Convert.ToDateTime(dr["WORKER_BIRTHDATE"]);
                    model.worker_hiredate = Convert.ToDateTime(dr["WORKER_HIREDATE"]);
                    model.religion_code = dr["RELIGION_CODE"].ToString();
                    model.blood_code = dr["BLOOD_CODE"].ToString();
                    model.worker_height = Convert.ToDouble(dr["WORKER_HEIGHT"]);
                    model.worker_weight = Convert.ToDouble(dr["WORKER_WEIGHT"]);
                    //model.worker_age = Convert.ToDouble(dr["WORKER_AGE"]);

                    model.worker_tel = dr["WORKER_TEL"].ToString();
                    model.worker_email = dr["WORKER_EMAIL"].ToString();
                    model.worker_line = dr["WORKER_LINE"].ToString();
                    model.worker_facebook = dr["WORKER_FACEBOOK"].ToString();

                    model.worker_military = dr["WORKER_MILITARY"].ToString();
                    model.nationality_code = dr["NATIONALITY_CODE"].ToString();

                    model.worker_cardno = dr["WORKER_CARDNO"].ToString();
                    model.worker_cardnoissuedate = Convert.ToDateTime(dr["WORKER_CARDNOISSUEDATE"]);
                    model.worker_cardnoexpiredate = Convert.ToDateTime(dr["WORKER_CARDNOEXPIREDATE"]);


                    model.status = dr["STATUS"].ToString();

                    model.modified_by = dr["MODIFIED_BY"].ToString();
                    model.modified_date = Convert.ToDateTime(dr["MODIFIED_DATE"]);

                    model.initial_name_th = dr["INITIAL_NAME_TH"].ToString();
                    model.initial_name_en = dr["INITIAL_NAME_EN"].ToString();

                    model.checkblacklist = this.checkblacklist(model.worker_cardno,model.company_code);
                    model.counthistory = this.counthistory(model.worker_cardno, model.company_code);
                    model.checkcertificate = this.checkCertificate(model.worker_code, model.company_code);

                    list_model.Add(model);
                }

            }
            catch (Exception ex)
            {
                Message = "APW001:" + ex.ToString();
            }

            return list_model;
        }
        public List<cls_MTWorker> getDataByFillter(string com, string code,string status)
        {
            string strCondition = "";

            strCondition += " AND COMPANY_CODE= '" + com  + "'";

            if (!code.Equals(""))
                strCondition += " AND WORKER_CODE  ='" + code + "'";
            if(!status.Equals(""))
                strCondition += " AND STATUS  ='" + status + "'";

            return this.getData(strCondition);
        }
        public List<cls_MTWorker> getDataMultiplereq(string com, string applywork)
        {
            string strCondition = " AND COMPANY_CODE='" + com + "'";
            strCondition += " AND WORKER_CODE IN (" + applywork + ") ";

            return this.getData(strCondition);
        }
        public int getNextID()
        {
            int intResult = 1;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT ISNULL(WORKER_ID, 1) ");
                obj_str.Append(" FROM REQ_MT_WORKER");
                obj_str.Append(" ORDER BY WORKER_ID DESC ");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    intResult = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }
            }
            catch (Exception ex)
            {
                Message = "APW002:" + ex.ToString();
            }

            return intResult;
        }
        public bool checkDataOld(string code)
        {
            bool blnResult = false;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT WORKER_CODE");
                obj_str.Append(" FROM REQ_MT_WORKER");
                obj_str.Append(" WHERE WORKER_CODE='" + code + "'");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    blnResult = true;
                }
            }
            catch (Exception ex)
            {
                Message = "APW003:" + ex.ToString();
            }

            return blnResult;
        }
        public int getID()
        {
            int intResult = 1;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT ISNULL(WORKER_ID, 1) ");
                obj_str.Append(" FROM REQ_MT_WORKER");
                obj_str.Append(" ORDER BY WORKER_ID DESC ");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    intResult = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                Message = "APW007:" + ex.ToString();
            }

            return intResult;
        }
        public bool delete(string id)
        {
            bool blnResult = true;
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();

                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();
                obj_str.Append("DELETE FROM REQ_MT_WORKER");

                obj_str.Append(" WHERE 1=1 ");
                obj_str.Append(" AND WORKER_ID='" + id + "'");

                blnResult = obj_conn.doExecuteSQL(obj_str.ToString());

            }
            catch (Exception ex)
            {
                blnResult = false;
                Message = "APW004:" + ex.ToString();
            }

            return blnResult;
        }
        public string insert(cls_MTWorker model)
        {
            string strResult = "";
            try
            {
                //-- Check data old
                if (this.checkDataOld(model.worker_code))
                {
                    if (this.update(model))
                        return model.worker_id.ToString();
                    else
                        return "";
                }

                cls_ctConnection obj_conn = new cls_ctConnection();
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("INSERT INTO REQ_MT_WORKER");
                obj_str.Append(" (");
                obj_str.Append("COMPANY_CODE ");
                obj_str.Append(", WORKER_ID ");
                obj_str.Append(", WORKER_CODE ");
                obj_str.Append(", WORKER_CARD ");

                obj_str.Append(", WORKER_INITIAL ");
                obj_str.Append(", WORKER_FNAME_TH ");
                obj_str.Append(", WORKER_LNAME_TH ");
                obj_str.Append(", WORKER_FNAME_EN ");
                obj_str.Append(", WORKER_LNAME_EN ");
                obj_str.Append(", WORKER_TYPE ");
                obj_str.Append(", WORKER_STATUS ");

                obj_str.Append(", WORKER_GENDER ");
                obj_str.Append(", WORKER_BIRTHDATE ");
                obj_str.Append(", WORKER_HIREDATE ");
                obj_str.Append(", RELIGION_CODE ");
                obj_str.Append(", BLOOD_CODE ");
                obj_str.Append(", WORKER_HEIGHT ");
                obj_str.Append(", WORKER_WEIGHT ");
                //obj_str.Append(", WORKER_AGE ");

                obj_str.Append(", WORKER_TEL ");
                obj_str.Append(", WORKER_EMAIL ");
                obj_str.Append(", WORKER_LINE ");
                obj_str.Append(", WORKER_FACEBOOK ");

                obj_str.Append(", WORKER_MILITARY ");
                obj_str.Append(", NATIONALITY_CODE ");
                obj_str.Append(", WORKER_CARDNO ");
                obj_str.Append(", WORKER_CARDNOISSUEDATE ");
                obj_str.Append(", WORKER_CARDNOEXPIREDATE ");

                obj_str.Append(", STATUS ");

                obj_str.Append(", CREATED_BY ");
                obj_str.Append(", CREATED_DATE ");
                obj_str.Append(", FLAG ");
                obj_str.Append(" )");

                obj_str.Append(" VALUES(");
                obj_str.Append("@COMPANY_CODE ");
                obj_str.Append(", @WORKER_ID ");
                obj_str.Append(", @WORKER_CODE ");
                obj_str.Append(", @WORKER_CARD ");

                obj_str.Append(", @WORKER_INITIAL ");

                obj_str.Append(", @WORKER_FNAME_TH ");
                obj_str.Append(", @WORKER_LNAME_TH ");

                obj_str.Append(", @WORKER_FNAME_EN ");
                obj_str.Append(", @WORKER_LNAME_EN ");
                obj_str.Append(", @WORKER_TYPE ");
                obj_str.Append(", @WORKER_STATUS ");
                obj_str.Append(", @WORKER_GENDER ");
                obj_str.Append(", @WORKER_BIRTHDATE ");
                obj_str.Append(", @WORKER_HIREDATE ");
                obj_str.Append(", @RELIGION_CODE ");
                obj_str.Append(", @BLOOD_CODE ");
                obj_str.Append(", @WORKER_HEIGHT ");
                obj_str.Append(", @WORKER_WEIGHT ");
                //obj_str.Append(", @WORKER_AGE ");

                obj_str.Append(", @WORKER_TEL ");
                obj_str.Append(", @WORKER_EMAIL ");
                obj_str.Append(", @WORKER_LINE ");
                obj_str.Append(", @WORKER_FACEBOOK ");

                obj_str.Append(", @WORKER_MILITARY ");
                obj_str.Append(", @NATIONALITY_CODE ");

                obj_str.Append(", @WORKER_CARDNO ");
                obj_str.Append(", @WORKER_CARDNOISSUEDATE ");
                obj_str.Append(", @WORKER_CARDNOEXPIREDATE ");

                obj_str.Append(", @STATUS ");

                obj_str.Append(", @CREATED_BY ");
                obj_str.Append(", @CREATED_DATE ");
                obj_str.Append(", @FLAG ");
                obj_str.Append(" )");

                obj_conn.doConnect();

                SqlCommand obj_cmd = new SqlCommand(obj_str.ToString(), obj_conn.getConnection()); 

                strResult = this.getNextID().ToString();

                obj_cmd.Parameters.Add("@COMPANY_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@COMPANY_CODE"].Value = model.company_code;

                obj_cmd.Parameters.Add("@WORKER_ID", SqlDbType.Int); obj_cmd.Parameters["@WORKER_ID"].Value = strResult;
                obj_cmd.Parameters.Add("@WORKER_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CODE"].Value = model.worker_code;
                obj_cmd.Parameters.Add("@WORKER_CARD", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CARD"].Value = model.worker_card;

                obj_cmd.Parameters.Add("@WORKER_INITIAL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_INITIAL"].Value = model.worker_initial;

                obj_cmd.Parameters.Add("@WORKER_FNAME_TH", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FNAME_TH"].Value = model.worker_fname_th;
                obj_cmd.Parameters.Add("@WORKER_LNAME_TH", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LNAME_TH"].Value = model.worker_lname_th;
                obj_cmd.Parameters.Add("@WORKER_FNAME_EN", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FNAME_EN"].Value = model.worker_fname_en;
                obj_cmd.Parameters.Add("@WORKER_LNAME_EN", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LNAME_EN"].Value = model.worker_lname_en;
                obj_cmd.Parameters.Add("@WORKER_TYPE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_TYPE"].Value = model.worker_type;
                obj_cmd.Parameters.Add("@WORKER_STATUS", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_STATUS"].Value = model.worker_status; 
                
                obj_cmd.Parameters.Add("@WORKER_GENDER", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_GENDER"].Value = model.worker_gender;

                obj_cmd.Parameters.Add("@WORKER_BIRTHDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_BIRTHDATE"].Value = model.worker_birthdate;
                obj_cmd.Parameters.Add("@WORKER_HIREDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_HIREDATE"].Value = model.worker_hiredate;
                obj_cmd.Parameters.Add("@RELIGION_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@RELIGION_CODE"].Value = model.religion_code;
                obj_cmd.Parameters.Add("@BLOOD_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@BLOOD_CODE"].Value = model.blood_code;
                obj_cmd.Parameters.Add("@WORKER_HEIGHT", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_HEIGHT"].Value = model.worker_height;
                obj_cmd.Parameters.Add("@WORKER_WEIGHT", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_WEIGHT"].Value = model.worker_weight;
                //obj_cmd.Parameters.Add("@WORKER_AGE", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_AGE"].Value = model.worker_age;

                obj_cmd.Parameters.Add("@WORKER_TEL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_TEL"].Value = model.worker_tel;
                obj_cmd.Parameters.Add("@WORKER_EMAIL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_EMAIL"].Value = model.worker_email;
                obj_cmd.Parameters.Add("@WORKER_LINE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LINE"].Value = model.worker_line;
                obj_cmd.Parameters.Add("@WORKER_FACEBOOK", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FACEBOOK"].Value = model.worker_facebook;

                obj_cmd.Parameters.Add("@WORKER_MILITARY", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_MILITARY"].Value = model.worker_military;
                obj_cmd.Parameters.Add("@NATIONALITY_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@NATIONALITY_CODE"].Value = model.nationality_code;

                obj_cmd.Parameters.Add("@WORKER_CARDNO", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CARDNO"].Value = model.worker_cardno;
                obj_cmd.Parameters.Add("@WORKER_CARDNOISSUEDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_CARDNOISSUEDATE"].Value = model.worker_cardnoissuedate;
                obj_cmd.Parameters.Add("@WORKER_CARDNOEXPIREDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_CARDNOEXPIREDATE"].Value = model.worker_cardnoexpiredate;

                obj_cmd.Parameters.Add("@STATUS", SqlDbType.VarChar); obj_cmd.Parameters["@STATUS"].Value = 'W';

                obj_cmd.Parameters.Add("@CREATED_BY", SqlDbType.VarChar); obj_cmd.Parameters["@CREATED_BY"].Value = model.modified_by;
                obj_cmd.Parameters.Add("@CREATED_DATE", SqlDbType.DateTime); obj_cmd.Parameters["@CREATED_DATE"].Value = DateTime.Now;
                obj_cmd.Parameters.Add("@FLAG", SqlDbType.Bit); obj_cmd.Parameters["@FLAG"].Value = false;

                obj_cmd.ExecuteNonQuery();

                obj_conn.doClose();

            }
            catch (Exception ex)
            {
                strResult = "";
                Message = "APW005:" + ex.ToString();
            }

            return strResult;
        }
        public bool update(cls_MTWorker model)
        {
            string strResult = model.worker_id.ToString();
            bool blnResult = false;
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();

                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("UPDATE REQ_MT_WORKER SET ");

                obj_str.Append(" WORKER_CODE=@WORKER_CODE ");
                obj_str.Append(", WORKER_CARD=@WORKER_CARD ");
                obj_str.Append(", WORKER_INITIAL=@WORKER_INITIAL ");
                obj_str.Append(", WORKER_FNAME_TH=@WORKER_FNAME_TH ");
                obj_str.Append(", WORKER_LNAME_TH=@WORKER_LNAME_TH ");

                obj_str.Append(", WORKER_FNAME_EN=@WORKER_FNAME_EN ");
                obj_str.Append(", WORKER_LNAME_EN=@WORKER_LNAME_EN ");
                obj_str.Append(", WORKER_TYPE=@WORKER_TYPE ");
                obj_str.Append(", WORKER_STATUS=@WORKER_STATUS ");

                obj_str.Append(", WORKER_GENDER=@WORKER_GENDER ");

                obj_str.Append(", WORKER_BIRTHDATE=@WORKER_BIRTHDATE ");
                obj_str.Append(", WORKER_HIREDATE=@WORKER_HIREDATE ");
                obj_str.Append(", RELIGION_CODE=@RELIGION_CODE ");
                obj_str.Append(", BLOOD_CODE=@BLOOD_CODE ");
                obj_str.Append(", WORKER_HEIGHT=@WORKER_HEIGHT ");
                obj_str.Append(", WORKER_WEIGHT=@WORKER_WEIGHT ");
                //obj_str.Append(", WORKER_AGE=@WORKER_AGE ");

                obj_str.Append(", WORKER_TEL=@WORKER_TEL ");
                obj_str.Append(", WORKER_EMAIL=@WORKER_EMAIL ");
                obj_str.Append(", WORKER_LINE=@WORKER_LINE ");
                obj_str.Append(", WORKER_FACEBOOK=@WORKER_FACEBOOK ");

                obj_str.Append(", WORKER_MILITARY=@WORKER_MILITARY ");
                obj_str.Append(", NATIONALITY_CODE=@NATIONALITY_CODE ");

                obj_str.Append(", WORKER_CARDNO=@WORKER_CARDNO ");
                obj_str.Append(", WORKER_CARDNOISSUEDATE=@WORKER_CARDNOISSUEDATE ");
                obj_str.Append(", WORKER_CARDNOEXPIREDATE=@WORKER_CARDNOEXPIREDATE ");

                obj_str.Append(", STATUS=@STATUS ");

                obj_str.Append(", MODIFIED_BY=@MODIFIED_BY ");
                obj_str.Append(", MODIFIED_DATE=@MODIFIED_DATE ");
                obj_str.Append(", FLAG=@FLAG ");

                obj_str.Append(" WHERE WORKER_ID=@WORKER_ID ");
                obj_str.Append(" AND COMPANY_CODE=@COMPANY_CODE ");



                obj_conn.doConnect();

                SqlCommand obj_cmd = new SqlCommand(obj_str.ToString(), obj_conn.getConnection());

                if (model.worker_id.ToString().Equals("0"))
                {
                    strResult = this.getID().ToString();
                }

                obj_cmd.Parameters.Add("@WORKER_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CODE"].Value = model.worker_code;
                obj_cmd.Parameters.Add("@WORKER_CARD", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CARD"].Value = model.worker_card;

                obj_cmd.Parameters.Add("@WORKER_INITIAL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_INITIAL"].Value = model.worker_initial;

                obj_cmd.Parameters.Add("@WORKER_FNAME_TH", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FNAME_TH"].Value = model.worker_fname_th;
                obj_cmd.Parameters.Add("@WORKER_LNAME_TH", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LNAME_TH"].Value = model.worker_lname_th;
                obj_cmd.Parameters.Add("@WORKER_FNAME_EN", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FNAME_EN"].Value = model.worker_fname_en;
                obj_cmd.Parameters.Add("@WORKER_LNAME_EN", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LNAME_EN"].Value = model.worker_lname_en;
                obj_cmd.Parameters.Add("@WORKER_TYPE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_TYPE"].Value = model.worker_type;
                obj_cmd.Parameters.Add("@WORKER_STATUS", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_STATUS"].Value = model.worker_status;                 
                obj_cmd.Parameters.Add("@WORKER_GENDER", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_GENDER"].Value = model.worker_gender;

                obj_cmd.Parameters.Add("@WORKER_BIRTHDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_BIRTHDATE"].Value = model.worker_birthdate;
                obj_cmd.Parameters.Add("@WORKER_HIREDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_HIREDATE"].Value = model.worker_hiredate;
                obj_cmd.Parameters.Add("@RELIGION_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@RELIGION_CODE"].Value = model.religion_code;
                obj_cmd.Parameters.Add("@BLOOD_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@BLOOD_CODE"].Value = model.blood_code;
                obj_cmd.Parameters.Add("@WORKER_HEIGHT", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_HEIGHT"].Value = model.worker_height;
                obj_cmd.Parameters.Add("@WORKER_WEIGHT", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_WEIGHT"].Value = model.worker_weight;
                //obj_cmd.Parameters.Add("@WORKER_AGE", SqlDbType.Decimal); obj_cmd.Parameters["@WORKER_AGE"].Value = model.worker_age;

                obj_cmd.Parameters.Add("@WORKER_TEL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_TEL"].Value = model.worker_tel;
                obj_cmd.Parameters.Add("@WORKER_EMAIL", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_EMAIL"].Value = model.worker_email;
                obj_cmd.Parameters.Add("@WORKER_LINE", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_LINE"].Value = model.worker_line;
                obj_cmd.Parameters.Add("@WORKER_FACEBOOK", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_FACEBOOK"].Value = model.worker_facebook;

                obj_cmd.Parameters.Add("@WORKER_MILITARY", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_MILITARY"].Value = model.worker_military;
                obj_cmd.Parameters.Add("@NATIONALITY_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@NATIONALITY_CODE"].Value = model.nationality_code;

                obj_cmd.Parameters.Add("@WORKER_CARDNO", SqlDbType.VarChar); obj_cmd.Parameters["@WORKER_CARDNO"].Value = model.worker_cardno;
                obj_cmd.Parameters.Add("@WORKER_CARDNOISSUEDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_CARDNOISSUEDATE"].Value = model.worker_cardnoissuedate;
                obj_cmd.Parameters.Add("@WORKER_CARDNOEXPIREDATE", SqlDbType.DateTime); obj_cmd.Parameters["@WORKER_CARDNOEXPIREDATE"].Value = model.worker_cardnoexpiredate;

                obj_cmd.Parameters.Add("@STATUS", SqlDbType.VarChar); obj_cmd.Parameters["@STATUS"].Value = model.status;

                obj_cmd.Parameters.Add("@MODIFIED_BY", SqlDbType.VarChar); obj_cmd.Parameters["@MODIFIED_BY"].Value = model.modified_by;
                obj_cmd.Parameters.Add("@MODIFIED_DATE", SqlDbType.DateTime); obj_cmd.Parameters["@MODIFIED_DATE"].Value = DateTime.Now;
                obj_cmd.Parameters.Add("@FLAG", SqlDbType.Bit); obj_cmd.Parameters["@FLAG"].Value = false;

                obj_cmd.Parameters.Add("@WORKER_ID", SqlDbType.Int); obj_cmd.Parameters["@WORKER_ID"].Value = strResult;
                obj_cmd.Parameters.Add("@COMPANY_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@COMPANY_CODE"].Value = model.company_code;

                obj_cmd.ExecuteNonQuery();

                obj_conn.doClose();

                blnResult = true;
            }
            catch (Exception ex)
            {
                Message = "APW006:" + ex.ToString();
            }

            return blnResult;
        }

        public bool checkblacklist(string code,string com)
        {
            bool blnResult = false;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT CARD_NO");
                obj_str.Append(" FROM REQ_MT_BLACKLIST");
                obj_str.Append(" WHERE COMPANY_CODE = '" + com + "' ");
                obj_str.Append(" AND CARD_NO ='" + code + "'");



                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    blnResult = true;
                }
            }
            catch (Exception ex)
            {
                Message = "APW007:" + ex.ToString();
            }
            return blnResult;
        }

        public int counthistory(string code,string com)
        {
            int intResult = 0;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT WORKER_CODE");
                obj_str.Append(" FROM EMP_MT_WORKER");
                obj_str.Append(" WHERE COMPANY_CODE = '" + com + "' ");

                obj_str.Append(" AND WORKER_CARDNO = '" + code + "' ");


                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    intResult = Convert.ToInt32(dt.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                Message = "APW008:" + ex.ToString();
            }
            return intResult;
        }

        public bool checkCertificate(string code,string com)
        {
            bool blnResult = false;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT WORKER_CODE");
                obj_str.Append(" FROM REQ_TR_DOCATT");
                obj_str.Append(" WHERE COMPANY_CODE = '"+com+"' ");
                obj_str.Append(" AND WORKER_CODE ='" + code + "'");
                obj_str.Append(" AND JOB_TYPE = 'MCER' ");



                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    blnResult = true;
                }
            }
            catch (Exception ex)
            {
                Message = "APW009:" + ex.ToString();
            }
            return blnResult;
        }

        public string updatestatus(cls_MTWorker model)
        {
            
            string strResult = "";
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();

                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("UPDATE REQ_MT_WORKER SET ");

                obj_str.Append(" STATUS=@STATUS ");

                obj_str.Append(", MODIFIED_BY=@MODIFIED_BY ");
                obj_str.Append(", MODIFIED_DATE=@MODIFIED_DATE ");
                obj_str.Append(", FLAG=@FLAG ");

                obj_str.Append(" WHERE WORKER_ID=@WORKER_ID ");
                obj_str.Append(" AND COMPANY_CODE=@COMPANY_CODE ");


                obj_conn.doConnect();

                SqlCommand obj_cmd = new SqlCommand(obj_str.ToString(), obj_conn.getConnection());

                
                strResult = model.worker_id.ToString();

                obj_cmd.Parameters.Add("@STATUS", SqlDbType.Int); obj_cmd.Parameters["@STATUS"].Value = model.status;

                obj_cmd.Parameters.Add("@MODIFIED_BY", SqlDbType.VarChar); obj_cmd.Parameters["@MODIFIED_BY"].Value = model.modified_by;
                obj_cmd.Parameters.Add("@MODIFIED_DATE", SqlDbType.DateTime); obj_cmd.Parameters["@MODIFIED_DATE"].Value = DateTime.Now;
                obj_cmd.Parameters.Add("@FLAG", SqlDbType.Bit); obj_cmd.Parameters["@FLAG"].Value = false;

                obj_cmd.Parameters.Add("@WORKER_ID", SqlDbType.Int); obj_cmd.Parameters["@WORKER_ID"].Value = strResult;
                obj_cmd.Parameters.Add("@COMPANY_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@COMPANY_CODE"].Value = model.company_code;

                obj_cmd.ExecuteNonQuery();

                obj_conn.doClose();

            }
            catch (Exception ex)
            {
                strResult = "";
                Message = "APW010:" + ex.ToString();
            }

            return strResult;
        }
    }
}
