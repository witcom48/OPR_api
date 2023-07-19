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
    public interface IModuleSelfServices
    {

        #region TRTimeleave
        [OperationContract(Name = "timeleave_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeleaveList(InputTRTimeleave input);

        [OperationContract(Name = "timeleave")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimeleave(InputTRTimeleave input);

        [OperationContract(Name = "timeleave_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimeleave(InputTRTimeleave input);

        [OperationContract(Name = "timeleave_actualday")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doGetLeaveActualDay(InputTRTimeleave input);
        #endregion

        #region TRTimeot
        [OperationContract(Name = "timeot_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeotList(InputTRTimeot input);

        [OperationContract(Name = "timeot")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimeot(InputTRTimeot input);

        [OperationContract(Name = "timeot_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimeot(InputTRTimeot input);
        #endregion

        #region TRTimeshift
        [OperationContract(Name = "timeshift_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeshiftList(InputTRTimeshift input);

        [OperationContract(Name = "timeshift")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimeshift(InputTRTimeshift input);

        [OperationContract(Name = "timeshift_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimeshift(InputTRTimeshift input);
        #endregion

        #region TRTimecheckin
        [OperationContract(Name = "timecheckin_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimecheckinList(InputTRTimecheckin input);

        [OperationContract(Name = "timecheckin")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimecheckin(InputTRTimecheckin input);

        [OperationContract(Name = "timecheckin_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimecheckin(InputTRTimecheckin input);
        #endregion

        #region TRTimeonsite
        [OperationContract(Name = "timeonsite_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimeonsiteList(InputTRTimeonsite input);

        [OperationContract(Name = "timeonsite")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimeonsite(InputTRTimeonsite input);

        [OperationContract(Name = "timeonsite_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimeonsite(InputTRTimeonsite input);
        #endregion

        #region TRTimedaytype
        [OperationContract(Name = "timedaytype_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRTimedaytypeList(InputTRTimedaytype input);

        [OperationContract(Name = "timedaytype")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRTimedaytype(InputTRTimedaytype input);

        [OperationContract(Name = "timedaytype_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRTimedaytype(InputTRTimedaytype input);
        #endregion

        #region MTArea
        [OperationContract(Name = "area_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTAreaList(InputMTArea input);

        [OperationContract(Name = "area")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTArea(InputMTArea input);

        [OperationContract(Name = "area_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTArea(InputMTArea input);
        #endregion

        #region MTTopic
        [OperationContract(Name = "topic_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTTopicList(InputMTTopic input);

        [OperationContract(Name = "topic")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTTopic(InputMTTopic input);

        [OperationContract(Name = "topic_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTTopic(InputMTTopic input);
        #endregion

        #region MTReqdoc
        [OperationContract(Name = "reqdoc_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTReqdocList(InputMTReqdoc input);

        [OperationContract(Name = "reqdoc")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTReqdoc(InputMTReqdoc input);

        [OperationContract(Name = "reqdoc_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTReqdoc(InputMTReqdoc input);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doUploadMTReqdoc?fileName={fileName}&token={token}&by={by}", ResponseFormat = WebMessageFormat.Json)]
        Task<string> doUploadMTReqdoc(string token, string by, string fileName, Stream stream);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doGetMTReqdoc?file_Path={file_path}", ResponseFormat = WebMessageFormat.Json)]
        byte[] DownloadFile(string file_Path);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/doDeleteMTReqdoc?file_Path={file_path}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteFile(string file_Path);
        #endregion

        #region TRReqdocatt
        [OperationContract(Name = "docatt_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeTRReqdocatt(InputTRReqdocatt input);
        #endregion

        #region MTJobtable
        [OperationContract(Name = "jobtable_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTJobtableList(InputMTJobtable input);

        [OperationContract(Name = "jobtable")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTJobtable(InputMTJobtable input);

        [OperationContract(Name = "jobtable_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTJobtable(InputMTJobtable input);
        #endregion

        #region MTReqdocument
        [OperationContract(Name = "reqdocument_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTReqdocumentList(InputMTReqdocument input);

        [OperationContract(Name = "reqdocument")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTReqdocument(InputMTReqdocument input);

        [OperationContract(Name = "reqdocument_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTReqdocument(InputMTReqdocument input);
        #endregion

        #region MTWorkflow
        [OperationContract(Name = "workflow_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTWorkflowList(InputMTWorkflow input);

        [OperationContract(Name = "workflow")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTWorkflow(InputMTWorkflow input);

        [OperationContract(Name = "workflow_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTWorkflow(InputMTWorkflow input);

        [OperationContract(Name = "positionlevel")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getPositionLevelList(InputMTWorkflow input);
        #endregion

        #region TRLineapprove
        [OperationContract(Name = "lineapprove_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRLineapproveList(InputTRLineapprove input);

        [OperationContract(Name = "lineapprove")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRLineapprove(InputTRLineapprove input);

        [OperationContract(Name = "lineapprove_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRLineapprove(InputTRLineapprove input);
        #endregion

        #region MTAccount
        [OperationContract(Name = "account_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTAccountList(InputMTAccount input);

        [OperationContract(Name = "account")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTAccount(InputMTAccount input);

        [OperationContract(Name = "account_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeMTAccount(InputMTAccount input);


        [OperationContract(Name = "account_workflow")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTAccountworkflowList(InputMTAccount input);
        #endregion

        #region TRAccountpos
        [OperationContract(Name = "accountpos_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRAccountposList(InputTRAccountpos input);

        [OperationContract(Name = "accountpos")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRAccountpos(InputTRAccountpos input);

        [OperationContract(Name = "accountpos_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeTRAccountpos(InputTRAccountpos input);
        #endregion

        #region TRAccountdep
        [OperationContract(Name = "accountdep_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRAccountdepList(InputTRAccountdep input);

        [OperationContract(Name = "accountdep")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRAccountdep(InputTRAccountdep input);

        [OperationContract(Name = "accountdep_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeTRAccountdep(InputTRAccountdep input);
        #endregion

        #region TRAccountmodule
        [OperationContract(Name = "accountmodule_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRAccountmoduleList(InputTRAccountmodule input);

        [OperationContract(Name = "accountmodule")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRAccountmodule(InputTRAccountmodule input);

        [OperationContract(Name = "accountmodule_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteeTRAccountmodule(InputTRAccountmodule input);
        #endregion

        #region Approvedoc
        [OperationContract(Name = "approve_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Approvegetdoc(InputApprovedoc input);
        [OperationContract(Name = "approve")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Approve(InputApprovedoc input);
        #endregion

        #region MTMailconfig
        [OperationContract(Name = "mailconfig_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTMailconfigList(InputMTMailconfig input);

        [OperationContract(Name = "mailconfig")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTMailconfig(InputMTMailconfig input);

        [OperationContract(Name = "mailconfig_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTMailconfig(InputMTMailconfig input);
        #endregion

        #region MTPdpafile
        [OperationContract(Name = "pdpafile_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getMTPdpafileList(InputMTPdpafile input);

        [OperationContract(Name = "pdpafile")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageMTPdpafile(InputMTPdpafile input);

        [OperationContract(Name = "pdpafile_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteMTPdpafile(InputMTPdpafile input);
        #endregion

        #region TRPdpa
        [OperationContract(Name = "pdpa_list")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string getTRPdpaList(InputTRPdpa input);

        [OperationContract(Name = "pdpa")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doManageTRPdpa(InputTRPdpa input);

        [OperationContract(Name = "pdpa_del")]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string doDeleteTRPdpa(InputTRPdpa input);
        #endregion
    }

}
