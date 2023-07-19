﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_BPC.hrfocus.model;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary_BPC.hrfocus.controller
{
    public class cls_ctTRProjobemp
    {
        string Message = string.Empty;

        cls_ctConnection Obj_conn = new cls_ctConnection();

        public cls_ctTRProjobemp() { }

        public string getMessage() { return this.Message.Replace("PRO_TR_PROJOBEMP", "").Replace("cls_ctTRProjobemp", "").Replace("line", ""); }

        public void dispose()
        {
            Obj_conn.doClose();
        }

        private List<cls_TRProjobemp> getData(string condition)
        {
            List<cls_TRProjobemp> list_model = new List<cls_TRProjobemp>();
            cls_TRProjobemp model;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT ");
                obj_str.Append("PROJOBEMP_ID");
                obj_str.Append(", PROJOBEMP_EMP");         
                obj_str.Append(", ISNULL(PROJOBEMP_FROMDATE, '01/01/1900') AS PROJOBEMP_FROMDATE");
                obj_str.Append(", ISNULL(PROJOBEMP_TODATE, '01/01/1900') AS PROJOBEMP_TODATE");
                obj_str.Append(", PROJOBEMP_TYPE");
                obj_str.Append(", PROJOBEMP_STATUS");

                obj_str.Append(", PROJOB_CODE");     
                obj_str.Append(", PROJECT_CODE");                

                obj_str.Append(", ISNULL(MODIFIED_BY, CREATED_BY) AS MODIFIED_BY");
                obj_str.Append(", ISNULL(MODIFIED_DATE, CREATED_DATE) AS MODIFIED_DATE");

                obj_str.Append(" FROM PRO_TR_PROJOBEMP");
                obj_str.Append(" WHERE 1=1");

                if (!condition.Equals(""))
                    obj_str.Append(" " + condition);

                obj_str.Append(" ORDER BY PROJECT_CODE, PROJOB_CODE, PROJOBEMP_EMP");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    model = new cls_TRProjobemp();

                    model.projobemp_id = Convert.ToInt32(dr["PROJOBEMP_ID"]);
                    model.projobemp_emp = Convert.ToString(dr["PROJOBEMP_EMP"]);

                    model.projobemp_fromdate = Convert.ToDateTime(dr["PROJOBEMP_FROMDATE"]);
                    model.projobemp_todate = Convert.ToDateTime(dr["PROJOBEMP_TODATE"]);

                    model.projobemp_type = Convert.ToString(dr["PROJOBEMP_TYPE"]); 
                    model.projobemp_status = Convert.ToString(dr["PROJOBEMP_STATUS"]); 
                    
                    model.projob_code = Convert.ToString(dr["PROJOB_CODE"]);                                        
                    model.project_code = Convert.ToString(dr["PROJECT_CODE"]);
                   
                    model.modified_by = dr["MODIFIED_BY"].ToString();
                    model.modified_date = Convert.ToDateTime(dr["MODIFIED_DATE"]);

                    list_model.Add(model);
                }

            }
            catch (Exception ex)
            {
                Message = "BNK001:" + ex.ToString();
            }

            return list_model;
        }

        public List<cls_TRProjobemp> getDataByFillter(string project, string job)
        {
            string strCondition = "";

            if (!project.Equals(""))
                strCondition += " AND PROJECT_CODE='" + project + "'";

            if (!job.Equals(""))
                strCondition += " AND PROJOB_CODE='" + job + "'";

            return this.getData(strCondition);
        }
                
        public int getNextID()
        {
            int intResult = 1;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT ISNULL(PROJOBEMP_ID, 1) ");
                obj_str.Append(" FROM PRO_TR_PROJOBEMP");
                obj_str.Append(" ORDER BY PROJOBEMP_ID DESC ");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    intResult = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }
            }
            catch (Exception ex)
            {
                Message = "BNK002:" + ex.ToString();
            }

            return intResult;
        }

        public bool checkDataOld(string project, string job, string emp, DateTime fromdate)
        {
            bool blnResult = false;
            try
            {
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("SELECT PROJOBEMP_EMP");
                obj_str.Append(" FROM PRO_TR_PROJOBEMP");
                obj_str.Append(" WHERE PROJECT_CODE='" + project + "'");
                obj_str.Append(" AND PROJOB_CODE='" + job + "'");
                obj_str.Append(" AND PROJOBEMP_EMP='" + emp + "'");
                obj_str.Append(" AND PROJOBEMP_FROMDATE='" + fromdate.ToString("MM/dd/yyyy") + "'");

                DataTable dt = Obj_conn.doGetTable(obj_str.ToString());

                if (dt.Rows.Count > 0)
                {
                    blnResult = true;
                }
            }
            catch (Exception ex)
            {
                Message = "BNK003:" + ex.ToString();
            }

            return blnResult;
        }

        public bool delete(string project, string job, string emp, DateTime fromdate)
        {
            bool blnResult = true;
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();

                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("DELETE FROM PRO_TR_PROJOBEMP");
                obj_str.Append(" WHERE PROJECT_CODE='" + project + "'");
                obj_str.Append(" AND PROJOB_CODE='" + job + "'");
                obj_str.Append(" AND PROJOBEMP_EMP='" + emp + "'");
                obj_str.Append(" AND PROJOBEMP_FROMDATE='" + fromdate.ToString("MM/dd/yyyy") + "'");
                
                blnResult = obj_conn.doExecuteSQL(obj_str.ToString());

            }
            catch (Exception ex)
            {
                blnResult = false;
                Message = "BNK004:" + ex.ToString();
            }

            return blnResult;
        }

        public bool delete(string project, string job)
        {
            bool blnResult = true;
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();

                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("DELETE FROM PRO_TR_PROJOBEMP");
                obj_str.Append(" WHERE PROJECT_CODE='" + project + "'");
                obj_str.Append(" AND PROJOB_CODE='" + job + "'");

                blnResult = obj_conn.doExecuteSQL(obj_str.ToString());

            }
            catch (Exception ex)
            {
                blnResult = false;
                Message = "BNK004:" + ex.ToString();
            }

            return blnResult;
        }

        public bool insert(cls_TRProjobemp model)
        {
            bool blnResult = false;
            try
            {

                //-- Check data old
                if (this.checkDataOld(model.project_code, model.projob_code, model.projobemp_emp, model.projobemp_fromdate))
                {
                    return this.update(model);
                }

                cls_ctConnection obj_conn = new cls_ctConnection();
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();

                obj_str.Append("INSERT INTO PRO_TR_PROJOBEMP");
                obj_str.Append(" (");
                obj_str.Append("PROJOBEMP_ID ");
                obj_str.Append(", PROJOBEMP_EMP ");                
                obj_str.Append(", PROJOBEMP_FROMDATE ");
                obj_str.Append(", PROJOBEMP_TODATE ");
                obj_str.Append(", PROJOBEMP_TYPE ");
                obj_str.Append(", PROJOBEMP_STATUS ");
                
                obj_str.Append(", PROJOB_CODE ");     
                obj_str.Append(", PROJECT_CODE ");      
         
                obj_str.Append(", CREATED_BY ");
                obj_str.Append(", CREATED_DATE ");
                obj_str.Append(", FLAG ");
                obj_str.Append(" )");

                obj_str.Append(" VALUES(");
                obj_str.Append("@PROJOBEMP_ID ");
                obj_str.Append(", @PROJOBEMP_EMP ");                
                obj_str.Append(", @PROJOBEMP_FROMDATE ");
                obj_str.Append(", @PROJOBEMP_TODATE ");
                obj_str.Append(", @PROJOBEMP_TYPE ");
                obj_str.Append(", @PROJOBEMP_STATUS ");

                obj_str.Append(", @PROJOB_CODE ");
                obj_str.Append(", @PROJECT_CODE ");

                obj_str.Append(", @CREATED_BY ");
                obj_str.Append(", @CREATED_DATE ");
                obj_str.Append(", @FLAG ");
                obj_str.Append(" )");

                obj_conn.doConnect();

                SqlCommand obj_cmd = new SqlCommand(obj_str.ToString(), obj_conn.getConnection());

                obj_cmd.Parameters.Add("@PROJOBEMP_ID", SqlDbType.Int); obj_cmd.Parameters["@PROJOBEMP_ID"].Value = this.getNextID();
                obj_cmd.Parameters.Add("@PROJOBEMP_EMP", SqlDbType.VarChar); obj_cmd.Parameters["@PROJOBEMP_EMP"].Value = model.projobemp_emp;

                obj_cmd.Parameters.Add("@PROJOBEMP_FROMDATE", SqlDbType.DateTime); obj_cmd.Parameters["@PROJOBEMP_FROMDATE"].Value = model.projobemp_fromdate;
                obj_cmd.Parameters.Add("@PROJOBEMP_TODATE", SqlDbType.DateTime); obj_cmd.Parameters["@PROJOBEMP_TODATE"].Value = model.projobemp_todate;

                obj_cmd.Parameters.Add("@PROJOBEMP_TYPE", SqlDbType.Char); obj_cmd.Parameters["@PROJOBEMP_TYPE"].Value = model.projobemp_type;
                
                obj_cmd.Parameters.Add("@PROJOBEMP_STATUS", SqlDbType.Char); obj_cmd.Parameters["@PROJOBEMP_STATUS"].Value = model.projobemp_status;
                
                obj_cmd.Parameters.Add("@PROJOB_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@PROJOB_CODE"].Value = model.projob_code;               
                obj_cmd.Parameters.Add("@PROJECT_CODE", SqlDbType.VarChar); obj_cmd.Parameters["@PROJECT_CODE"].Value = model.project_code;
                
                obj_cmd.Parameters.Add("@CREATED_BY", SqlDbType.VarChar); obj_cmd.Parameters["@CREATED_BY"].Value = model.modified_by;
                obj_cmd.Parameters.Add("@CREATED_DATE", SqlDbType.DateTime); obj_cmd.Parameters["@CREATED_DATE"].Value = DateTime.Now;
                obj_cmd.Parameters.Add("@FLAG", SqlDbType.Bit); obj_cmd.Parameters["@FLAG"].Value = false;

                obj_cmd.ExecuteNonQuery();

                obj_conn.doClose();
               
                blnResult = true;
            }
            catch (Exception ex)
            {
                Message = "BNK005:" + ex.ToString();               
            }

            return blnResult;
        }

        public bool update(cls_TRProjobemp model)
        {
            bool blnResult = false;
            try
            {
                cls_ctConnection obj_conn = new cls_ctConnection();
                System.Text.StringBuilder obj_str = new System.Text.StringBuilder();
                obj_str.Append("UPDATE PRO_TR_PROJOBEMP SET ");

                obj_str.Append(" PROJOBEMP_FROMDATE=@PROJOBEMP_FROMDATE ");
                obj_str.Append(", PROJOBEMP_TODATE=@PROJOBEMP_TODATE ");

                obj_str.Append(", PROJOBEMP_TYPE=@PROJOBEMP_TYPE "); 
                obj_str.Append(", PROJOBEMP_STATUS=@PROJOBEMP_STATUS ");                                  

                obj_str.Append(", MODIFIED_BY=@MODIFIED_BY ");
                obj_str.Append(", MODIFIED_DATE=@MODIFIED_DATE ");

                obj_str.Append(" WHERE PROJOBEMP_ID=@PROJOBEMP_ID ");
               
                obj_conn.doConnect();

                SqlCommand obj_cmd = new SqlCommand(obj_str.ToString(), obj_conn.getConnection());

             
                obj_cmd.Parameters.Add("@PROJOBEMP_FROMDATE", SqlDbType.DateTime); obj_cmd.Parameters["@PROJOBEMP_FROMDATE"].Value = model.projobemp_fromdate;
                obj_cmd.Parameters.Add("@PROJOBEMP_TODATE", SqlDbType.DateTime); obj_cmd.Parameters["@PROJOBEMP_TODATE"].Value = model.projobemp_todate;

                obj_cmd.Parameters.Add("@PROJOBEMP_TYPE", SqlDbType.Char); obj_cmd.Parameters["@PROJOBEMP_TYPE"].Value = model.projobemp_type;
                obj_cmd.Parameters.Add("@PROJOBEMP_STATUS", SqlDbType.Char); obj_cmd.Parameters["@PROJOBEMP_STATUS"].Value = model.projobemp_status;  

                obj_cmd.Parameters.Add("@MODIFIED_BY", SqlDbType.VarChar); obj_cmd.Parameters["@MODIFIED_BY"].Value = model.modified_by;
                obj_cmd.Parameters.Add("@MODIFIED_DATE", SqlDbType.DateTime); obj_cmd.Parameters["@MODIFIED_DATE"].Value = DateTime.Now;

                obj_cmd.Parameters.Add("@PROJOBEMP_ID", SqlDbType.Int); obj_cmd.Parameters["@PROJOBEMP_ID"].Value = model.projobemp_id;

                obj_cmd.ExecuteNonQuery();

                obj_conn.doClose();

                blnResult = true;
            }
            catch (Exception ex)
            {
                Message = "BNK006:" + ex.ToString();
            }

            return blnResult;
        }

    }
}
