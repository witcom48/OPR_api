﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using ClassLibrary_BPC.hrfocus.controller;
using ClassLibrary_BPC.hrfocus.service;
using ClassLibrary_BPC.hrfocus.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Drawing;
using AntsCode.Util;
using System.Web.Security;
using HRFocusWCF;
using System.Security.Permissions;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using System.Configuration;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;

namespace BPC_OPR
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ModuleSelfServices : IModuleSelfServices
    {
        BpcOpr objBpcOpr = new BpcOpr();

        #region TRTimeleave
        public string getTRTimeleaveList(InputTRTimeleave input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                DateTime datefrom = Convert.ToDateTime(input.timeleave_fromdate);
                DateTime dateto = Convert.ToDateTime(input.timeleave_todate);

                cls_ctTRTimeleave objTRTimeleave = new cls_ctTRTimeleave();
                List<cls_TRTimeleave> listTRTimeleave = objTRTimeleave.getDataByFillter(input.timeleave_id,input.status, input.company_code, input.worker_code, datefrom, dateto);

                JArray array = new JArray();

                if (listTRTimeleave.Count > 0)
                {
                    int index = 1;

                    foreach (cls_TRTimeleave model in listTRTimeleave)
                    {
                        JObject json = new JObject();

                        json.Add("company", model.company_code);
                        json.Add("worker_code", model.worker_code);
                        json.Add("leave_code", model.leave_code);

                        json.Add("worker_detail_th", model.worker_detail_th);
                        json.Add("leave_detail_th", model.leave_detail_th);
                        json.Add("worker_detail_en", model.worker_detail_en);
                        json.Add("leave_detail_en", model.leave_detail_en);

                        json.Add("timeleave_id", model.timeleave_id);
                        json.Add("timeleave_doc", model.timeleave_doc);

                        json.Add("timeleave_fromdate", model.timeleave_fromdate);
                        json.Add("timeleave_todate", model.timeleave_todate);

                        json.Add("timeleave_type", model.timeleave_type);
                        json.Add("timeleave_min", model.timeleave_min);

                        json.Add("timeleave_actualday", model.timeleave_actualday);
                        json.Add("timeleave_incholiday", model.timeleave_incholiday);
                        json.Add("timeleave_deduct", model.timeleave_deduct);

                        json.Add("timeleave_note", model.timeleave_note);
                        json.Add("reason_code", model.reason_code);
                        json.Add("reason_th", model.reason_th);
                        json.Add("reason_en", model.reason_en);
                        json.Add("status", model.status);

                        json.Add("modified_by", model.modified_by);
                        json.Add("modified_date", model.modified_date);
                        json.Add("flag", model.flag);

                        json.Add("index", index);

                        index++;

                        array.Add(json);
                    }

                    output["result"] = "1";
                    output["result_text"] = "1";
                    output["data"] = array;
                }
                else
                {
                    output["result"] = "0";
                    output["result_text"] = "Data not Found";
                    output["data"] = array;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return output.ToString(Formatting.None);
        }
        public string doManageTRTimeleave(InputTRTimeleave input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            string strID = "";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                cls_ctTRTimeleave objTRTimeleave = new cls_ctTRTimeleave();
                var jsonArray = JsonConvert.DeserializeObject<List<cls_TRTimeleave>>(input.leave_data);
                foreach (cls_TRTimeleave leavedata in jsonArray)
                {
                    cls_TRTimeleave model = new cls_TRTimeleave();

                    model.company_code = leavedata.company_code;
                    model.worker_code = leavedata.worker_code;
                    model.timeleave_id = leavedata.timeleave_id.Equals("") ? 0 : Convert.ToInt32(leavedata.timeleave_id);
                    model.timeleave_doc = leavedata.timeleave_doc;

                    model.timeleave_fromdate = Convert.ToDateTime(leavedata.timeleave_fromdate);
                    model.timeleave_todate = Convert.ToDateTime(leavedata.timeleave_todate);

                    model.timeleave_type = leavedata.timeleave_type;
                    model.timeleave_min = leavedata.timeleave_min;

                    model.timeleave_actualday = leavedata.timeleave_actualday;
                    model.timeleave_incholiday = leavedata.timeleave_incholiday;
                    model.timeleave_deduct = leavedata.timeleave_deduct;

                    model.timeleave_note = leavedata.timeleave_note;
                    model.leave_code = leavedata.leave_code;
                    model.reason_code = leavedata.reason_code;
                    model.status = leavedata.status;

                    model.modified_by = input.username;
                    model.flag = leavedata.flag;

                    strID = objTRTimeleave.insert(model);
                    if (!strID.Equals(""))
                    {
                        cls_srvProcessTime srv_time = new cls_srvProcessTime();
                        srv_time.doCalleaveacc(model.timeleave_fromdate.Year.ToString(), model.company_code, model.worker_code, model.modified_by);
                    }
                    else
                    {
                        break;
                    }
                }
                if (!strID.Equals(""))
                {
                    output["success"] = true;
                    output["message"] = "Retrieved data successfully";
                    output["record_id"] = strID;

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Retrieved data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = objTRTimeleave.getMessage();
                }

                objTRTimeleave.dispose();
            }
            catch (Exception ex)
            {
                output["result"] = "0";
                output["result_text"] = ex.ToString();

            }

            return output.ToString(Formatting.None);

        }
        public string doDeleteTRTimeleave(InputTRTimeleave input)
        {
            JObject output = new JObject();

            var json_data = new JavaScriptSerializer().Serialize(input);
            var tmp = JToken.Parse(json_data);

            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.3";
            log.apilog_by = input.username;
            log.apilog_data = tmp.ToString();

            try
            {
                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;
                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }

                cls_ctTRTimeleave controller = new cls_ctTRTimeleave();
                cls_TRTimeleave model = controller.getDataByID(input.timeleave_id);
                bool blnResult = controller.delete(input.timeleave_id);

                if (blnResult)
                {
                    cls_srvProcessTime srv_time = new cls_srvProcessTime();
                    srv_time.doCalleaveacc(model.timeleave_fromdate.Year.ToString(), model.company_code, model.worker_code, model.modified_by);
                    output["success"] = true;
                    output["message"] = "Remove data successfully";

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Remove data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = controller.getMessage();
                }
                controller.dispose();
            }
            catch (Exception ex)
            {
                output["success"] = false;
                output["message"] = "(C)Remove data not successfully";

                log.apilog_status = "500";
                log.apilog_message = ex.ToString();
            }
            finally
            {
                objBpcOpr.doRecordLog(log);
            }

            output["data"] = tmp;

            return output.ToString(Formatting.None);

        }
        #endregion

        #region TRTimeot
        public string getTRTimeotList(InputTRTimeot input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                DateTime datefrom = Convert.ToDateTime(input.timeot_fromdate);
                DateTime dateto = Convert.ToDateTime(input.timeot_todate);

                cls_ctTRTimeot objTRTime = new cls_ctTRTimeot();
                List<cls_TRTimeot> listTRTime = objTRTime.getDataByFillter(input.timeot_id, input.status, input.company_code, input.worker_code, datefrom, dateto);

                JArray array = new JArray();

                if (listTRTime.Count > 0)
                {
                    int index = 1;

                    foreach (cls_TRTimeot model in listTRTime)
                    {
                        JObject json = new JObject();
                        json.Add("company_code", model.company_code);
                        json.Add("worker_code", model.worker_code);

                        json.Add("worker_detail_th", model.worker_detail_th);
                        json.Add("worker_detail_en", model.worker_detail_en);

                        json.Add("timeot_id", model.timeot_id);
                        json.Add("timeot_doc", model.timeot_doc);

                        json.Add("timeot_workdate", model.timeot_workdate);

                        json.Add("timeot_beforemin", model.timeot_beforemin);
                        json.Add("timeot_normalmin", model.timeot_normalmin);
                        json.Add("timeot_break", model.timeot_breakmin);
                        json.Add("timeot_aftermin", model.timeot_aftermin);

                        int hrs = (model.timeot_beforemin) / 60;
                        int min = (model.timeot_beforemin) - (hrs * 60);
                        json.Add("timeot_beforemin_hrs", hrs.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0'));

                        hrs = (model.timeot_normalmin) / 60;
                        min = (model.timeot_normalmin) - (hrs * 60);
                        json.Add("timeot_normalmin_hrs", hrs.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0'));

                        hrs = (model.timeot_breakmin) / 60;
                        min = (model.timeot_breakmin) - (hrs * 60);
                        json.Add("timeot_break_hrs", hrs.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0'));

                        hrs = (model.timeot_aftermin) / 60;
                        min = (model.timeot_aftermin) - (hrs * 60);
                        json.Add("timeot_aftermin_hrs", hrs.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0'));


                        json.Add("timeot_note", model.timeot_note);
                        json.Add("location_code", model.location_code);
                        json.Add("location_name_th", model.location_name_th);
                        json.Add("location_name_en", model.location_name_en);
                        json.Add("reason_code", model.reason_code);
                        json.Add("reason_name_th", model.reason_name_th);
                        json.Add("reason_name_en", model.reason_name_en);
                        json.Add("status", model.status);

                        json.Add("modified_by", model.modified_by);
                        json.Add("modified_date", model.modified_date);
                        json.Add("flag", model.flag);

                        json.Add("index", index);

                        index++;

                        array.Add(json);
                    }

                    output["result"] = "1";
                    output["result_text"] = "1";
                    output["data"] = array;
                }
                else
                {
                    output["result"] = "0";
                    output["result_text"] = "Data not Found";
                    output["data"] = array;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return output.ToString(Formatting.None);
        }
        public string doManageTRTimeot(InputTRTimeot input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            string strID = "";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                cls_ctTRTimeot objTRTime = new cls_ctTRTimeot();
                var jsonArray = JsonConvert.DeserializeObject<List<cls_TRTimeot>>(input.ot_data);
                foreach (cls_TRTimeot otdata in jsonArray)
                {
                    cls_TRTimeot model = new cls_TRTimeot();

                    model.company_code = otdata.company_code;
                    model.worker_code = otdata.worker_code;
                    model.timeot_id = otdata.timeot_id.Equals("") ? 0 : Convert.ToInt32(otdata.timeot_id);
                    model.timeot_doc = otdata.timeot_doc;

                    model.timeot_workdate = Convert.ToDateTime(otdata.timeot_workdate);

                    model.timeot_beforemin = otdata.timeot_beforemin;
                    model.timeot_normalmin = otdata.timeot_normalmin;
                    model.timeot_breakmin = otdata.timeot_breakmin;
                    model.timeot_aftermin = otdata.timeot_aftermin;

                    model.timeot_note = otdata.timeot_note;
                    model.location_code = otdata.location_code;
                    model.reason_code = otdata.reason_code;
                    model.status = otdata.status;

                    model.modified_by = input.username;
                    model.flag = otdata.flag;

                    strID = objTRTime.insert(model);
                    if (!strID.Equals(""))
                    {
                        
                    }
                    else
                    {
                        break;
                    }
                }
                if (!strID.Equals(""))
                {
                    output["success"] = true;
                    output["message"] = "Retrieved data successfully";
                    output["record_id"] = strID;

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Retrieved data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = objTRTime.getMessage();
                }

                objTRTime.dispose();
            }
            catch (Exception ex)
            {
                output["result"] = "0";
                output["result_text"] = ex.ToString();

            }

            return output.ToString(Formatting.None);

        }
        public string doDeleteTRTimeot(InputTRTimeot input)
        {
            JObject output = new JObject();

            var json_data = new JavaScriptSerializer().Serialize(input);
            var tmp = JToken.Parse(json_data);

            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.3";
            log.apilog_by = input.username;
            log.apilog_data = tmp.ToString();

            try
            {
                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;
                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }

                cls_ctTRTimeot controller = new cls_ctTRTimeot();
                bool blnResult = controller.delete(input.timeot_id);

                if (blnResult)
                {
                    output["success"] = true;
                    output["message"] = "Remove data successfully";

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Remove data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = controller.getMessage();
                }
                controller.dispose();
            }
            catch (Exception ex)
            {
                output["success"] = false;
                output["message"] = "(C)Remove data not successfully";

                log.apilog_status = "500";
                log.apilog_message = ex.ToString();
            }
            finally
            {
                objBpcOpr.doRecordLog(log);
            }

            output["data"] = tmp;

            return output.ToString(Formatting.None);

        }
        #endregion

        #region TRTimeshift
        public string getTRTimeshiftList(InputTRTimeshift input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                DateTime datefrom = Convert.ToDateTime(input.timeshift_fromdate);
                DateTime dateto = Convert.ToDateTime(input.timeshift_todate);

                cls_ctTRTimeshift objTRTime = new cls_ctTRTimeshift();
                List<cls_TRTimeshift> listTRTime = objTRTime.getDataByFillter(input.timeshift_id, input.status, input.company_code, input.worker_code, datefrom, dateto);

                JArray array = new JArray();

                if (listTRTime.Count > 0)
                {
                    int index = 1;

                    foreach (cls_TRTimeshift model in listTRTime)
                    {
                        JObject json = new JObject();
                        json.Add("company_code", model.company_code);
                        json.Add("worker_code", model.worker_code);

                        json.Add("worker_detail_th", model.worker_detail_th);
                        json.Add("worker_detail_en", model.worker_detail_en);

                        json.Add("timeshift_id", model.timeshift_id);
                        json.Add("timeshift_doc", model.timeshift_doc);
                        json.Add("timeshift_workdate", model.timeshift_workdate);
                        json.Add("timeshift_old", model.timeshift_old);
                        json.Add("shift_old_th", model.shift_old_th);
                        json.Add("shift_old_en", model.shift_old_en);
                        json.Add("timeshift_new", model.timeshift_new);
                        json.Add("shift_new_th", model.shift_new_th);
                        json.Add("shift_new_en", model.shift_new_en);
                        json.Add("timeshift_note", model.timeshift_note);
      
                        json.Add("reason_code", model.reason_code);
                        json.Add("reason_detail_th", model.reason_detail_th);
                        json.Add("reason_detail_en", model.reason_detail_en);
                        json.Add("status", model.status);
                        json.Add("modified_by", model.modified_by);
                        json.Add("modified_date", model.modified_date);
                        json.Add("flag", model.flag);

                        json.Add("index", index);

                        index++;

                        array.Add(json);
                    }

                    output["result"] = "1";
                    output["result_text"] = "1";
                    output["data"] = array;
                }
                else
                {
                    output["result"] = "0";
                    output["result_text"] = "Data not Found";
                    output["data"] = array;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return output.ToString(Formatting.None);
        }
        public string doManageTRTimeshift(InputTRTimeshift input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            string strID = "";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                cls_ctTRTimeshift objTRTime = new cls_ctTRTimeshift();
                var jsonArray = JsonConvert.DeserializeObject<List<cls_TRTimeshift>>(input.timeshift_data);
                foreach (cls_TRTimeshift shiftdata in jsonArray)
                {
                    cls_TRTimeshift model = new cls_TRTimeshift();

                    model.company_code = shiftdata.company_code;
                    model.worker_code = shiftdata.worker_code;

                    model.timeshift_id = shiftdata.timeshift_id;
                    model.timeshift_doc = shiftdata.timeshift_doc;

                    model.timeshift_workdate = Convert.ToDateTime(shiftdata.timeshift_workdate);

                    model.timeshift_old = shiftdata.timeshift_old;
                    model.timeshift_new = shiftdata.timeshift_new;

                    model.timeshift_note = shiftdata.timeshift_note;

                    model.reason_code = shiftdata.reason_code;
                    model.status = shiftdata.status;

                    model.modified_by = input.username;
                    model.flag = shiftdata.flag;

                    strID = objTRTime.insert(model);
                    if (!strID.Equals(""))
                    {

                    }
                    else
                    {
                        break;
                    }
                }
                if (!strID.Equals(""))
                {
                    output["success"] = true;
                    output["message"] = "Retrieved data successfully";
                    output["record_id"] = strID;

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Retrieved data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = objTRTime.getMessage();
                }

                objTRTime.dispose();
            }
            catch (Exception ex)
            {
                output["result"] = "0";
                output["result_text"] = ex.ToString();

            }

            return output.ToString(Formatting.None);

        }
        public string doDeleteTRTimeshift(InputTRTimeshift input)
        {
            JObject output = new JObject();

            var json_data = new JavaScriptSerializer().Serialize(input);
            var tmp = JToken.Parse(json_data);

            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.3";
            log.apilog_by = input.username;
            log.apilog_data = tmp.ToString();

            try
            {
                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;
                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }

                cls_ctTRTimeshift controller = new cls_ctTRTimeshift();

                cls_TRTimeshift model = controller.getDataByID(input.timeshift_id);

                bool blnResult = controller.delete(input.timeshift_id);

                if (blnResult)
                {
                    cls_ctTRTimecard objTRTimecard = new cls_ctTRTimecard();
                    List<cls_TRTimecard> list_timecard = objTRTimecard.getDataByFillter(model.company_code,"", model.worker_code, model.timeshift_workdate.Date, model.timeshift_workdate.Date);

                    if (list_timecard.Count > 0)
                    {
                        cls_TRTimecard timecard = list_timecard[0];
                        timecard.shift_code = model.timeshift_old;

                        objTRTimecard.update(timecard);
                    }
                    output["success"] = true;
                    output["message"] = "Remove data successfully";

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Remove data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = controller.getMessage();
                }
                controller.dispose();
            }
            catch (Exception ex)
            {
                output["success"] = false;
                output["message"] = "(C)Remove data not successfully";

                log.apilog_status = "500";
                log.apilog_message = ex.ToString();
            }
            finally
            {
                objBpcOpr.doRecordLog(log);
            }

            output["data"] = tmp;

            return output.ToString(Formatting.None);

        }
        #endregion

        #region MTWorkflow
        public string getMTWorkflowList(InputMTWorkflow input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                cls_ctMTWorkflow objMT = new cls_ctMTWorkflow();
                List<cls_MTWorkflow> list = objMT.getDataByFillter(input.company_code, input.workflow_id, input.workflow_code,input.workflow_type);

                JArray array = new JArray();

                if (list.Count > 0)
                {
                    int index = 1;

                    foreach (cls_MTWorkflow model in list)
                    {
                        JObject json = new JObject();
                        json.Add("company_code", model.company_code);
                        json.Add("workflow_id", model.workflow_id);
                        json.Add("workflow_code", model.workflow_code);
                        json.Add("workflow_name_th", model.workflow_name_th);
                        json.Add("workflow_name_en", model.workflow_name_en);
                        json.Add("workflow_type", model.workflow_type);

                        json.Add("step1", model.step1);
                        json.Add("step2", model.step2);
                        json.Add("step3", model.step3);
                        json.Add("step4", model.step4);
                        json.Add("step5", model.step5);

                        json.Add("totalapprove", model.totalapprove);

                        json.Add("modified_by", model.modified_by);
                        json.Add("modified_date", model.modified_date);
                        json.Add("flag", model.flag);
                        json.Add("index", index);

                        index++;

                        array.Add(json);
                    }

                    output["result"] = "1";
                    output["result_text"] = "1";
                    output["data"] = array;
                }
                else
                {
                    output["result"] = "0";
                    output["result_text"] = "Data not Found";
                    output["data"] = array;
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return output.ToString(Formatting.None);
        }
        public string doManageMTWorkflow(InputMTWorkflow input)
        {
            JObject output = new JObject();
            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.1";
            log.apilog_by = input.username;
            log.apilog_data = "all";
            try
            {

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;

                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }
                cls_ctMTWorkflow objMT = new cls_ctMTWorkflow();
                cls_MTWorkflow model = new cls_MTWorkflow();
                model.company_code = input.company_code;
                model.workflow_id = input.workflow_id.Equals("") ? 0 : Convert.ToInt32(input.workflow_id);
                model.workflow_code = input.workflow_code;
                model.workflow_name_th = input.workflow_name_th;
                model.workflow_name_en = input.workflow_name_en;
                model.workflow_type = input.workflow_type;

                model.step1 = input.step1;
                model.step2 = input.step2;
                model.step3 = input.step3;
                model.step4 = input.step4;
                model.step5 = input.step5;

                model.totalapprove = input.totalapprove;

                model.modified_by = input.username;
                model.flag = input.flag;

                string strID = objMT.insert(model);
                if (!strID.Equals(""))
                {
                    output["success"] = true;
                    output["message"] = "Retrieved data successfully";
                    output["record_id"] = strID;

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Retrieved data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = objMT.getMessage();
                }

                objMT.dispose();
            }
            catch (Exception ex)
            {
                output["result"] = "0";
                output["result_text"] = ex.ToString();

            }

            return output.ToString(Formatting.None);

        }
        public string doDeleteMTWorkflow(InputMTWorkflow input)
        {
            JObject output = new JObject();

            var json_data = new JavaScriptSerializer().Serialize(input);
            var tmp = JToken.Parse(json_data);

            cls_SYSApilog log = new cls_SYSApilog();
            log.apilog_code = "ATT001.3";
            log.apilog_by = input.username;
            log.apilog_data = tmp.ToString();

            try
            {
                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
                if (authHeader == null || !objBpcOpr.doVerify(authHeader))
                {
                    output["success"] = false;
                    output["message"] = BpcOpr.MessageNotAuthen;
                    log.apilog_status = "500";
                    log.apilog_message = BpcOpr.MessageNotAuthen;
                    objBpcOpr.doRecordLog(log);

                    return output.ToString(Formatting.None);
                }

                cls_ctMTWorkflow controller = new cls_ctMTWorkflow();

                bool blnResult = controller.delete(input.workflow_id,input.company_code);

                if (blnResult)
                {
                    output["success"] = true;
                    output["message"] = "Remove data successfully";

                    log.apilog_status = "200";
                    log.apilog_message = "";
                }
                else
                {
                    output["success"] = false;
                    output["message"] = "Remove data not successfully";

                    log.apilog_status = "500";
                    log.apilog_message = controller.getMessage();
                }
                controller.dispose();
            }
            catch (Exception ex)
            {
                output["success"] = false;
                output["message"] = "(C)Remove data not successfully";

                log.apilog_status = "500";
                log.apilog_message = ex.ToString();
            }
            finally
            {
                objBpcOpr.doRecordLog(log);
            }

            output["data"] = tmp;

            return output.ToString(Formatting.None);

        }
        #endregion
    }
}