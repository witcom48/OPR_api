﻿
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using ClassLibrary_BPC.hrfocus.model;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
namespace BPC_OPR
{
    [ServiceContract]
    public interface IModuleAttendance
    {

        #region MTPeriod
        //[OperationContract(Name = "period_list")]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //string getMTPeriodList(InputMTPeriod input);

        //[OperationContract(Name = "period")]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //string doManageMTPeriod(InputMTPeriod input);

        //[OperationContract(Name = "period_del")]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //string doDeleteMTPeriod(InputMTPeriod input);

        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/doUploadMTPeriod?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        //Task<string> doUploadMTPeriod(string token, string by, string fileName, Stream stream,string com);
        #endregion

        #region MTPlanholiday
        [OperationContract(Name = "planholiday_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTPlanholidayList(InputMTPlanholiday input);

        [OperationContract(Name = "planholiday")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTPlanholiday(InputMTPlanholiday input);

        [OperationContract(Name = "planholiday_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTPlanholiday(InputMTPlanholiday input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTPlanholiday?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTPlanholiday(string token, string by, string fileName, Stream stream,string com);
        #endregion

        #region MTShift
        [OperationContract(Name = "shift_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTShiftList(InputMTShift input);

        [OperationContract(Name = "shift")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTShift(InputMTShift input);

        [OperationContract(Name = "shift_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTShift(InputMTShift input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTShift?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTShift(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTPlanshift
        [OperationContract(Name = "planshift_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTPlanshiftList(InputMTPlanshift input);

        [OperationContract(Name = "planshift")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTPlanshift(InputMTPlanshift input);

        [OperationContract(Name = "planshift_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTPlanshift(InputMTPlanshift input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTPlanshift?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTPlanshift(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTLeave
        [OperationContract(Name = "leave_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTLeaveList(InputMTLeave input);

        [OperationContract(Name = "leave")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTLeave(InputMTLeave input);

        [OperationContract(Name = "leave_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTLeave(InputMTLeave input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTLeave?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTLeave(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region TRLeave
        [OperationContract(Name = "leaveacc_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTReaveList(InputTRLeave input);

        [OperationContract(Name = "leaveacc")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTReave(InputTRLeave input);

        [OperationContract(Name = "leaveacc_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTReave(InputTRLeave input);

        [OperationContract(Name = "TReave_actualday")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doGetLeaveActualDay(InputTRTimeleave input);
        #endregion

        #region MTPlanleave
        [OperationContract(Name = "planleave_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTPlanleaveList(InputMTPlanleave input);

        [OperationContract(Name = "planleave")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTPlanleave(InputMTPlanleave input);

        [OperationContract(Name = "planleave_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTPlanleave(InputMTPlanleave input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTPlanleave?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTPlanleave(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTRateot
        [OperationContract(Name = "ot_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTRateotList(InputMTRateot input);

        [OperationContract(Name = "ot")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTRateot(InputMTRateot input);

        [OperationContract(Name = "ot_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTRateot(InputMTRateot input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTRateot?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTRateot(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTDiligence
        [OperationContract(Name = "diligence_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTDiligenceList(InputMTDiligence input);

        [OperationContract(Name = "diligence")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTDiligence(InputMTDiligence input);

        [OperationContract(Name = "diligence_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTDiligence(InputMTDiligence input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTDiligence?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTDiligence(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTLate
        [OperationContract(Name = "late_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTLateList(InputMTLate input);

        [OperationContract(Name = "late")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTLate(InputMTLate input);

        [OperationContract(Name = "late_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTLate(InputMTLate input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTLate?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTLate(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region MTPlantimeallw
        [OperationContract(Name = "plantimeallw_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTPlantimeallwList(InputMTPlantimeallw input);

        [OperationContract(Name = "plantimeallw")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTPlantimeallw(InputMTPlantimeallw input);

        [OperationContract(Name = "plantimeallw_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTPlantimeallw(InputMTPlantimeallw input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTPlantimeallw?fileName={fileName}&token={token}&by={by}&com={com}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTPlantimeallw(string token, string by, string fileName, Stream stream,string com);

        #endregion

        #region SetPolicyAtt
        [OperationContract(Name = "SetPolicyAtt_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getPolicyAttendance(InputSetPolicyAtt input);

        [OperationContract(Name = "SetPolicyAtt")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doSetPolicyAttendance(InputSetPolicyAtt input);

        [OperationContract(Name = "SetPolicyAtt_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeletePolicyAttendance(InputSetPolicyAtt input);

        #endregion

        #region SetBatchPlanshift
        [OperationContract(Name = "SetBatchPlanshift")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doSetBatchPlanshift(InputBatchPlanshift input);
        #endregion

        #region Timecard
        [OperationContract(Name = "timecard_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimecardList(FillterAttendance req);

        [OperationContract(Name = "timecard")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimecard(InputTRTimecard input);

        [OperationContract(Name = "timesheet")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimesheet(InputTRTimecard input);

        [OperationContract(Name = "daytype_list")]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getDaytype();


        [OperationContract(Name = "timecard_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimecard(InputTRTimecard input);

        #endregion

        #region Timeimport
        [OperationContract(Name = "timeformat_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTTimeimpformatList(FillterAttendance req);

        [OperationContract(Name = "timeformat")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTTimeimpformat(InputMTTimeimpformat input);

        [OperationContract(Name = "timeformat_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTTimeimpformat(InputMTTimeimpformat input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doReadSimpleTimeInput?fileName={fileName}", ResponseFormat = WebMessageFormat.Json)]
        string doReadSimpleTimeInput(string fileName, Stream stream);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadTimeInput?fileName={fileName}", ResponseFormat = WebMessageFormat.Json)]
        string doUploadTimeInput(string fileName, Stream stream);
        #endregion

        #region Set Batch Attendance Item
        [OperationContract(Name = "polattpay_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getPolicyAttendanceItem(InputSetPolicyAttItem input);

        [OperationContract(Name = "polattpays")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doSetPolicyAttendanceItem(InputSetPolicyAttItem input);

        [OperationContract(Name = "polattpay_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTREmppolattItem(InputSetPolicyAttItem input);
        #endregion

        #region Wageday
        [OperationContract(Name = "wageday_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRWagedayList(FillterAttendance req);
        #endregion


        //-- F add 06/01/2024

        #region Doc approve

        [OperationContract(Name = "leaveappr_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeleaveApproveList(InputTRTimeleave input);

        [OperationContract(Name = "otappr_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeotApproveList(InputTRTimeot input);

        [OperationContract(Name = "shiftappr_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeshiftApproveList(InputTRTimeshift input);

        [OperationContract(Name = "onsiteappr_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeonsiteApproveList(InputTRTimeonsite input);

        [OperationContract(Name = "daytypeappr_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimedaytypeApproveList(InputTRTimedaytype input);

        #endregion

        [OperationContract(Name = "timeinput_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeinputList(FillterAttendance req);

        //--

        #region  Lost Wages
        [OperationContract(Name = "Lostwages_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRLostwagesList(FillterAttendance req);

        [OperationContract(Name = "Lostwages")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRLostwages(InputTRLostwages input);

        [OperationContract(Name = "timesheet1")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimesheetLostwages(InputTRLostwages input);

        [OperationContract(Name = "daytype1_list")]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getDaytype1();


        [OperationContract(Name = "Lostwages_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRLostwages(InputTRLostwages input);

        #endregion

        //
        [OperationContract(Name = "Att_Approve_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRLostwagesApprove(FillterLostwagesApprove req);

        //[OperationContract(Name = "Att_Approve_list2")]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //string getTRLostwagesApprove2(FillterLostwagesApprove req);

        #region ATTTRTimeot
        [OperationContract(Name = "atttimeot_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRATTTimeotList(InputTRATTTimeot input);

        [OperationContract(Name = "atttimeot")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRATTTimeot(InputTRATTTimeot input);

        [OperationContract(Name = "atttimeot_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRATTTimeot(InputTRATTTimeot input);
        #endregion


        #region  ATTTRTimeleave 
        [OperationContract(Name = "atttimeleave_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRATTTimeleaveList(InputTRATTTimeleave input);

        [OperationContract(Name = "atttimeleave")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRATTTimeleave(InputTRATTTimeleave input);

        [OperationContract(Name = "atttimeleave_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRATTTimeleave(InputTRATTTimeleave input);
        #endregion
    


     #region Timeonsite
        [OperationContract(Name = "ATTTimeonsite_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRATTTimeonsiteList(InputTRATTTimeonsite input);

        [OperationContract(Name = "ATTTimeonsite")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRATTTimeonsite(InputTRATTTimeonsite input);

        [OperationContract(Name = "ATTTimeonsite_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRATTTimeonsite(InputTRATTTimeonsite input);

        
        #endregion
        #region MTATTReqdoc
        [OperationContract(Name = "ATTreqdoc_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTATTReqdocList(InputMTATTReqdoc input);

        [OperationContract(Name = "ATTreqdoc")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTATTReqdoc(InputMTATTReqdoc input);

        [OperationContract(Name = "ATTreqdoc_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTATTReqdoc(InputMTATTReqdoc input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTATTReqdoc?fileName={fileName}&token={token}&by={by}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTATTReqdoc(string token, string by, string fileName, Stream stream);
 

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doGetMTATTReqdoc?file_Path={file_path}", ResponseFormat = WebMessageFormat.Json)]
        byte[] DownloadFile(string file_Path);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doDeleteMTATTReqdoc?file_Path={file_path}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteFile(string file_Path);
        #endregion


        #region MTReqdocument
        [OperationContract(Name = "attdocument_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTATTReqdocumentList(InputMTATTReqdocument input);

        [OperationContract(Name = "attdocument")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTATTReqdocument(InputMTATTReqdocument input);

        [OperationContract(Name = "attdocument_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTATTReqdocument(InputMTATTReqdocument input);
        #endregion


        #region TRATTTimecheckin
        [OperationContract(Name = "attcheckin_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRATTTimecheckinList(InputTRATTTimecheckin input);

        [OperationContract(Name = "attcheckin")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRATTTimecheckin(InputTRATTTimecheckin input);

        [OperationContract(Name = "attcheckin_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRATTTimecheckin(InputTRATTTimecheckin input);
        #endregion
    }
}
