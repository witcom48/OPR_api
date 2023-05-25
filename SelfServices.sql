USE [OPR]
GO
/****** Object:  Table [dbo].[SELF_MT_ACCOUNT]    Script Date: 25/05/2023 14:30:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_ACCOUNT](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[ACCOUNT_USER] [varchar](30) NOT NULL,
	[ACCOUNT_PWD] [varchar](100) NOT NULL,
	[ACCOUNT_TYPE] [varchar](10) NOT NULL,
	[ACCOUNT_LEVEL] [int] NULL,
	[ACCOUNT_EMAIL] [varchar](100) NULL,
	[ACCOUNT_EMAIL_ALERT] [bit] NULL,
	[ACCOUNT_LINE] [varchar](100) NULL,
	[ACCOUNT_LINE_ALERT] [bit] NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_MT_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[ACCOUNT_USER] ASC,
	[ACCOUNT_TYPE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_AREA]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_AREA](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[AREA_ID] [bigint] NOT NULL,
	[AREA_LAT] [float] NOT NULL,
	[AREA_LONG] [float] NOT NULL,
	[AREA_DISTANCE] [float] NOT NULL,
	[LOCATION_CODE] [varchar](10) NOT NULL,
	[PROJECT_CODE] [varchar](100) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_MT_AREA] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[LOCATION_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_JOBTABLE]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_JOBTABLE](
	[COMPANY_CODE] [varchar](30) NOT NULL,
	[JOBTABLE_ID] [bigint] NOT NULL,
	[JOB_ID] [varchar](30) NOT NULL,
	[JOB_TYPE] [varchar](100) NOT NULL,
	[STATUS_JOB] [char](1) NOT NULL,
	[JOB_NEXTSTEP] [int] NULL,
	[JOB_DATE] [datetime] NOT NULL,
	[JOB_FINISHDATE] [datetime] NULL,
	[WORKFLOW_CODE] [varchar](30) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
 CONSTRAINT [PK_SELF_MT_JOBTABLE] PRIMARY KEY CLUSTERED 
(
	[JOB_ID] ASC,
	[JOB_TYPE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_REQDOC]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_REQDOC](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](30) NOT NULL,
	[REQDOC_ID] [bigint] NOT NULL,
	[REQDOC_DOC] [varchar](30) NULL,
	[REQDOC_DATE] [datetime] NOT NULL,
	[REQDOC_NOTE] [varchar](100) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_MT_REQDOC] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[REQDOC_DATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_REQDOCUMENT]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_REQDOCUMENT](
	[COMPANY_CODE] [varchar](30) NOT NULL,
	[DOCUMENT_ID] [bigint] NOT NULL,
	[JOB_ID] [varchar](30) NOT NULL,
	[JOB_TYPE] [varchar](100) NOT NULL,
	[DOCUMENT_NAME] [varchar](100) NOT NULL,
	[DOCUMENT_TYPE] [varchar](100) NOT NULL,
	[DOCUMENT_PATH] [varchar](100) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
 CONSTRAINT [PK_SELF_MT_REQDOCUMENT] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[DOCUMENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_TOPIC]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_TOPIC](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[TOPIC_ID] [bigint] NOT NULL,
	[TOPIC_CODE] [varchar](30) NOT NULL,
	[TOPIC_NAME_TH] [varchar](100) NULL,
	[TOPIC_NAME_EN] [varchar](100) NULL,
	[TOPIC_TYPE] [varchar](30) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_MT_TOPIC] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[TOPIC_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_MT_WORKFLOW]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_MT_WORKFLOW](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[WORKFLOW_ID] [int] NOT NULL,
	[WORKFLOW_CODE] [varchar](10) NOT NULL,
	[WORKFLOW_NAME_TH] [varchar](50) NOT NULL,
	[WORKFLOW_NAME_EN] [varchar](50) NOT NULL,
	[WORKFLOW_TYPE] [varchar](10) NOT NULL,
	[STEP1] [int] NULL,
	[STEP2] [int] NULL,
	[STEP3] [int] NULL,
	[STEP4] [int] NULL,
	[STEP5] [int] NULL,
	[TOTALAPPROVE] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_WORKFLOW] PRIMARY KEY CLUSTERED 
(
	[WORKFLOW_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_ACCOUNT]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_ACCOUNT](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[ACCOUNT_USER] [varchar](30) NOT NULL,
	[ACCOUNT_TYPE] [varchar](10) NOT NULL,
	[WORKER_CODE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SELF_TR_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[ACCOUNT_USER] ASC,
	[ACCOUNT_TYPE] ASC,
	[WORKER_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_ACCOUNTDEP]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_ACCOUNTDEP](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[ACCOUNT_USER] [varchar](30) NOT NULL,
	[ACCOUNT_TYPE] [varchar](10) NOT NULL,
	[LEVEL_CODE] [varchar](30) NOT NULL,
	[DEP_CODE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SELF_TR_ACCOUNTDEP] PRIMARY KEY CLUSTERED 
(
	[ACCOUNT_USER] ASC,
	[ACCOUNT_TYPE] ASC,
	[LEVEL_CODE] ASC,
	[DEP_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_ACCOUNTPOS]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_ACCOUNTPOS](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[ACCOUNT_USER] [varchar](30) NOT NULL,
	[ACCOUNT_TYPE] [varchar](10) NOT NULL,
	[POSITION_CODE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SELF_TR_ACCOUNTPOS] PRIMARY KEY CLUSTERED 
(
	[ACCOUNT_USER] ASC,
	[ACCOUNT_TYPE] ASC,
	[POSITION_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_AREA]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_AREA](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[LOCATION_CODE] [varchar](30) NOT NULL,
	[WORKER_CODE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SELF_TR_AREA] PRIMARY KEY CLUSTERED 
(
	[LOCATION_CODE] ASC,
	[WORKER_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_LINEAPPROVE]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_LINEAPPROVE](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[WORKFLOW_TYPE] [varchar](10) NOT NULL,
	[WORKFLOW_CODE] [varchar](10) NOT NULL,
	[POSITION_LEVEL] [varchar](10) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_TR_LINEAPPROVE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKFLOW_TYPE] ASC,
	[POSITION_LEVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_REQDOC_ATT]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_REQDOC_ATT](
	[REQDOC_ID] [bigint] NOT NULL,
	[REQDOC_ATT_NO] [bigint] NOT NULL,
	[REQDOC_ATT_FILENAME] [varchar](100) NULL,
	[REQDOC_ATT_FILETYPE] [varchar](10) NULL,
	[REQDOC_ATT_PATH] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_REQEMPINFO]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_REQEMPINFO](
	[REQDOC_ID] [bigint] NOT NULL,
	[REQEMPINFO_NO] [bigint] NOT NULL,
	[TOPIC_CODE] [varchar](10) NULL,
	[REQEMPINFO_DETAIL] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMECHECKIN]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMECHECKIN](
	[COMPANY_CODE] [varchar](10) NOT NULL,
	[TIMECHECKIN_ID] [int] NOT NULL,
	[TIMECHECKIN_WORKDATE] [datetime] NOT NULL,
	[TIMECHECKIN_TIME] [varchar](10) NOT NULL,
	[TIMECHECKIN_TYPE] [varchar](10) NULL,
	[TIMECHECKIN_LAT] [float] NOT NULL,
	[TIMECHECKIN_LONG] [float] NOT NULL,
	[TIMECHECKIN_NOTE] [varchar](200) NULL,
	[LOCATION_CODE] [varchar](20) NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_TR_TIMECHECKIN] PRIMARY KEY CLUSTERED 
(
	[TIMECHECKIN_WORKDATE] ASC,
	[TIMECHECKIN_TIME] ASC,
	[WORKER_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMEDAYTYPE]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMEDAYTYPE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[TIMEDAYTYPE_ID] [bigint] NOT NULL,
	[TIMEDAYTYPE_DOC] [varchar](30) NULL,
	[TIMEDAYTYPE_WORKDATE] [datetime] NOT NULL,
	[TIMEDAYTYPE_OLD] [varchar](20) NOT NULL,
	[TIMEDAYTYPE_NEW] [varchar](20) NOT NULL,
	[TIMEDAYTYPE_NOTE] [varchar](100) NULL,
	[REASON_CODE] [varchar](10) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_TR_TIMEDAYTYPE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[TIMEDAYTYPE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMELEAVE]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMELEAVE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[TIMELEAVE_ID] [bigint] NOT NULL,
	[TIMELEAVE_DOC] [varchar](30) NULL,
	[TIMELEAVE_FROMDATE] [datetime] NOT NULL,
	[TIMELEAVE_TODATE] [datetime] NOT NULL,
	[TIMELEAVE_TYPE] [varchar](2) NOT NULL,
	[TIMELEAVE_MIN] [int] NULL,
	[TIMELEAVE_ACTUALDAY] [int] NULL,
	[TIMELEAVE_INCHOLIDAY] [bit] NULL,
	[TIMELEAVE_DEDUCT] [bit] NULL,
	[TIMELEAVE_NOTE] [varchar](100) NULL,
	[LEAVE_CODE] [varchar](10) NOT NULL,
	[REASON_CODE] [varchar](10) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_TR_TIMELEAVE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[TIMELEAVE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMEONSITE]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMEONSITE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[TIMEONSITE_ID] [bigint] NOT NULL,
	[TIMEONSITE_DOC] [varchar](30) NULL,
	[TIMEONSITE_WORKDATE] [datetime] NOT NULL,
	[TIMEONSITE_IN] [char](5) NOT NULL,
	[TIMEONSITE_OUT] [char](5) NOT NULL,
	[TIMEONSITE_NOTE] [varchar](100) NULL,
	[REASON_CODE] [varchar](10) NULL,
	[LOCATION_CODE] [varchar](10) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_SELF_TR_TIMEONSITE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[TIMEONSITE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMEOT]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMEOT](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[TIMEOT_ID] [bigint] NOT NULL,
	[TIMEOT_DOC] [varchar](30) NULL,
	[TIMEOT_WORKDATE] [datetime] NOT NULL,
	[TIMEOT_BEFOREMIN] [int] NULL,
	[TIMEOT_NORMALMIN] [int] NULL,
	[TIMEOT_BREAK] [int] NULL,
	[TIMEOT_AFTERMIN] [int] NULL,
	[TIMEOT_NOTE] [varchar](100) NULL,
	[REASON_CODE] [varchar](10) NULL,
	[LOCATION_CODE] [varchar](10) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_TR_TIMEOT] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[TIMEOT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SELF_TR_TIMESHIFT]    Script Date: 25/05/2023 14:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SELF_TR_TIMESHIFT](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[TIMESHIFT_ID] [bigint] NOT NULL,
	[TIMESHIFT_DOC] [varchar](30) NULL,
	[TIMESHIFT_WORKDATE] [datetime] NOT NULL,
	[TIMESHIFT_OLD] [varchar](20) NOT NULL,
	[TIMESHIFT_NEW] [varchar](20) NOT NULL,
	[TIMESHIFT_NOTE] [varchar](100) NULL,
	[REASON_CODE] [varchar](10) NULL,
	[STATUS] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_TR_TIMESHIFT] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[TIMESHIFT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SELF_MT_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_PWD], [ACCOUNT_TYPE], [ACCOUNT_LEVEL], [ACCOUNT_EMAIL], [ACCOUNT_EMAIL_ALERT], [ACCOUNT_LINE], [ACCOUNT_LINE_ALERT], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'Admin', N'1KqlegNZtYvbcla+lVnx8g==', N'ADM', 1, N'admin@gmail.com', 1, N'admin', 1, N'Not login', CAST(N'2023-05-05T11:36:04.023' AS DateTime), N'Not login', CAST(N'2023-05-05T11:37:46.703' AS DateTime), 0)
INSERT [dbo].[SELF_MT_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_PWD], [ACCOUNT_TYPE], [ACCOUNT_LEVEL], [ACCOUNT_EMAIL], [ACCOUNT_EMAIL_ALERT], [ACCOUNT_LINE], [ACCOUNT_LINE_ALERT], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'Approve01', N'1KqlegNZtYvbcla+lVnx8g==', N'APR', 1, N'approve01@gmai.com', 1, N'approve01', 1, N'Not login', CAST(N'2023-05-05T11:31:01.500' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_MT_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_PWD], [ACCOUNT_TYPE], [ACCOUNT_LEVEL], [ACCOUNT_EMAIL], [ACCOUNT_EMAIL_ALERT], [ACCOUNT_LINE], [ACCOUNT_LINE_ALERT], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'Emp01', N'1KqlegNZtYvbcla+lVnx8g==', N'Emp', 3, N'Emp01@gmail.com', 1, N'Emp01', 1, N'Not login', CAST(N'2023-05-05T13:09:18.523' AS DateTime), N'Not login', CAST(N'2023-05-05T13:55:50.627' AS DateTime), 0)
INSERT [dbo].[SELF_MT_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_PWD], [ACCOUNT_TYPE], [ACCOUNT_LEVEL], [ACCOUNT_EMAIL], [ACCOUNT_EMAIL_ALERT], [ACCOUNT_LINE], [ACCOUNT_LINE_ALERT], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'Group01', N'1KqlegNZtYvbcla+lVnx8g==', N'GRP', 3, N'Group01@gmai.com', 1, N'Group01', 1, N'Not login', CAST(N'2023-05-05T11:28:33.633' AS DateTime), N'Not login', CAST(N'2023-05-05T11:29:27.130' AS DateTime), 0)
GO
INSERT [dbo].[SELF_MT_AREA] ([COMPANY_CODE], [AREA_ID], [AREA_LAT], [AREA_LONG], [AREA_DISTANCE], [LOCATION_CODE], [PROJECT_CODE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, 13.760724232134409, 100.63315898180009, 1000, N'00000', N'PRO001', N'Not login', CAST(N'2023-05-19T15:41:13.907' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 8, N'0', N'LEA', N'W', 2, CAST(N'2023-05-26T00:00:00.000' AS DateTime), NULL, N'LV1-2', N'EMP01', CAST(N'2023-05-25T13:44:25.250' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 5, N'1', N'DAT', N'W', 2, CAST(N'2023-05-22T14:13:32.623' AS DateTime), NULL, N'DAT1-2', N'Admin', CAST(N'2023-05-22T14:13:32.623' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 6, N'1', N'LEA', N'W', 2, CAST(N'2023-05-25T00:00:00.000' AS DateTime), NULL, N'LV1-2', N'EMP01', CAST(N'2023-05-25T13:44:08.030' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 4, N'1', N'ONS', N'W', 1, CAST(N'2023-05-22T14:12:45.473' AS DateTime), NULL, N'ONS1-2', N'Admin', CAST(N'2023-05-22T14:12:45.473' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 2, N'1', N'OT', N'W', 1, CAST(N'2023-05-22T13:51:03.383' AS DateTime), NULL, N'OT1-2', N'Admin', CAST(N'2023-05-22T13:51:03.383' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 1, N'1', N'SHT', N'W', 1, CAST(N'2023-05-22T13:50:02.460' AS DateTime), NULL, N'SHT1-2', N'Admin', CAST(N'2023-05-22T13:50:02.460' AS DateTime))
INSERT [dbo].[SELF_MT_JOBTABLE] ([COMPANY_CODE], [JOBTABLE_ID], [JOB_ID], [JOB_TYPE], [STATUS_JOB], [JOB_NEXTSTEP], [JOB_DATE], [JOB_FINISHDATE], [WORKFLOW_CODE], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 9, N'2', N'LEA', N'W', 2, CAST(N'2023-05-26T00:00:00.000' AS DateTime), NULL, N'LV1-2', N'EMP01', CAST(N'2023-05-25T14:11:15.420' AS DateTime))
GO
INSERT [dbo].[SELF_MT_REQDOC] ([COMPANY_CODE], [WORKER_CODE], [REQDOC_ID], [REQDOC_DOC], [REQDOC_DATE], [REQDOC_NOTE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'DOC_20230516133520', CAST(N'2023-05-16T00:00:00.000' AS DateTime), N'TEST', 2, N'Admin', CAST(N'2023-05-16T13:53:43.147' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_MT_REQDOCUMENT] ([COMPANY_CODE], [DOCUMENT_ID], [JOB_ID], [JOB_TYPE], [DOCUMENT_NAME], [DOCUMENT_TYPE], [DOCUMENT_PATH], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 1, N'1', N'LEA', N'LEAVE_DOC20230525135259.png', N'image/png', N'D:\\OPR\Imports\LEAVE_DOC20230525135259.png', N'EMP01', CAST(N'2023-05-25T13:53:02.330' AS DateTime))
INSERT [dbo].[SELF_MT_REQDOCUMENT] ([COMPANY_CODE], [DOCUMENT_ID], [JOB_ID], [JOB_TYPE], [DOCUMENT_NAME], [DOCUMENT_TYPE], [DOCUMENT_PATH], [CREATED_BY], [CREATED_DATE]) VALUES (N'OPR', 2, N'2', N'LEA', N'LEAVE_DOC20230525141110.png', N'image/png', N'D:\\OPR\Imports\LEAVE_DOC20230525141110.png', N'EMP01', CAST(N'2023-05-25T14:11:15.060' AS DateTime))
GO
INSERT [dbo].[SELF_MT_TOPIC] ([COMPANY_CODE], [TOPIC_ID], [TOPIC_CODE], [TOPIC_NAME_TH], [TOPIC_NAME_EN], [TOPIC_TYPE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'0001', N'แก้ไขข้อมูล', N'Edit info', N'EMP', N'Admin', CAST(N'2023-05-16T13:36:44.253' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 4, N'DAT1-2', N'เปลี่ยนประเภทวัน', N'DAT', N'DAT', 1, 2, 0, 0, 0, 2, N'Not login', CAST(N'2023-05-22T13:58:47.363' AS DateTime), N'Not login', CAST(N'2023-05-22T14:16:32.220' AS DateTime), 0)
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'LV1-2', N'ผู้อนุมัติ 1 คน รหัสแทนตำแหน่ง รหัส 2', N'1 approver, position code, code 2', N'LEA', 1, 2, 0, 0, 0, 2, N'Admin', CAST(N'2023-05-02T12:52:45.830' AS DateTime), N'Not login', CAST(N'2023-05-22T11:51:49.487' AS DateTime), 0)
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 5, N'ONS1-2', N'นอกสถานที่', N'ONS', N'ONS', 1, 0, 0, 0, 0, 1, N'Not login', CAST(N'2023-05-22T14:11:43.783' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 2, N'OT1-2', N'โอที', N'OT', N'OT', 1, 0, 0, 0, 0, 1, N'Not login', CAST(N'2023-05-19T16:27:27.687' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 3, N'SHT1-2', N'กะ', N'SHT', N'SHT', 1, 0, 0, 0, 0, 1, N'Not login', CAST(N'2023-05-22T13:06:20.557' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [WORKER_CODE]) VALUES (N'OPR', N'Emp01', N'Emp', N'EMP01')
INSERT [dbo].[SELF_TR_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [WORKER_CODE]) VALUES (N'OPR', N'Group01', N'GRP', N'EMP01')
INSERT [dbo].[SELF_TR_ACCOUNT] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [WORKER_CODE]) VALUES (N'OPR', N'Group01', N'GRP', N'EMP02')
GO
INSERT [dbo].[SELF_TR_ACCOUNTDEP] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [LEVEL_CODE], [DEP_CODE]) VALUES (N'OPR', N'Approve01', N'APR', N'01', N'AB')
INSERT [dbo].[SELF_TR_ACCOUNTDEP] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [LEVEL_CODE], [DEP_CODE]) VALUES (N'OPR', N'Approve01', N'APR', N'01', N'AB00')
GO
INSERT [dbo].[SELF_TR_ACCOUNTPOS] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [POSITION_CODE]) VALUES (N'OPR', N'Approve01', N'APR', N'002')
INSERT [dbo].[SELF_TR_ACCOUNTPOS] ([COMPANY_CODE], [ACCOUNT_USER], [ACCOUNT_TYPE], [POSITION_CODE]) VALUES (N'OPR', N'Approve01', N'APR', N'AC-AM')
GO
INSERT [dbo].[SELF_TR_AREA] ([COMPANY_CODE], [LOCATION_CODE], [WORKER_CODE]) VALUES (N'OPR', N'00000', N'EMP01')
INSERT [dbo].[SELF_TR_AREA] ([COMPANY_CODE], [LOCATION_CODE], [WORKER_CODE]) VALUES (N'OPR', N'00000', N'EMP02')
GO
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'DAT', N'DAT1-2', N'6', N'Not login', CAST(N'2023-05-22T14:16:32.220' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'LEA', N'LV1-2', N'1', N'Not login', CAST(N'2023-05-22T11:51:49.487' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'LEA', N'LV1-2', N'6', N'Not login', CAST(N'2023-05-22T11:51:49.487' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'ONS', N'ONS1-2', N'6', N'Not login', CAST(N'2023-05-22T14:11:43.783' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'OT', N'OT1-2', N'6', N'Not login', CAST(N'2023-05-19T16:27:27.927' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[SELF_TR_LINEAPPROVE] ([COMPANY_CODE], [WORKFLOW_TYPE], [WORKFLOW_CODE], [POSITION_LEVEL], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'SHT', N'SHT1-2', N'6', N'Not login', CAST(N'2023-05-22T13:06:20.573' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_REQDOC_ATT] ([REQDOC_ID], [REQDOC_ATT_NO], [REQDOC_ATT_FILENAME], [REQDOC_ATT_FILETYPE], [REQDOC_ATT_PATH]) VALUES (1, 1, N'TESTDOCATT_01', N'PDF', N'C:/temp/TESTDOCATT_01.pdf')
GO
INSERT [dbo].[SELF_TR_TIMECHECKIN] ([COMPANY_CODE], [TIMECHECKIN_ID], [TIMECHECKIN_WORKDATE], [TIMECHECKIN_TIME], [TIMECHECKIN_TYPE], [TIMECHECKIN_LAT], [TIMECHECKIN_LONG], [TIMECHECKIN_NOTE], [LOCATION_CODE], [WORKER_CODE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, CAST(N'2023-05-08T00:00:00.000' AS DateTime), N'17:00', N'O', 13.321, 14.123, N'TEST', N'00000', N'EMP01', N'Admin', CAST(N'2023-05-09T10:56:52.260' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_TIMEDAYTYPE] ([COMPANY_CODE], [WORKER_CODE], [TIMEDAYTYPE_ID], [TIMEDAYTYPE_DOC], [TIMEDAYTYPE_WORKDATE], [TIMEDAYTYPE_OLD], [TIMEDAYTYPE_NEW], [TIMEDAYTYPE_NOTE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'12345', CAST(N'2023-05-12T00:00:00.000' AS DateTime), N'O', N'N', N'TEST', N'01', 2, N'Admin', CAST(N'2023-05-22T14:13:32.353' AS DateTime), N'Admin', CAST(N'2023-05-22T14:16:39.923' AS DateTime), 0)
GO
INSERT [dbo].[SELF_TR_TIMELEAVE] ([COMPANY_CODE], [WORKER_CODE], [TIMELEAVE_ID], [TIMELEAVE_DOC], [TIMELEAVE_FROMDATE], [TIMELEAVE_TODATE], [TIMELEAVE_TYPE], [TIMELEAVE_MIN], [TIMELEAVE_ACTUALDAY], [TIMELEAVE_INCHOLIDAY], [TIMELEAVE_DEDUCT], [TIMELEAVE_NOTE], [LEAVE_CODE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'LEAVE_20230525135301', CAST(N'2023-05-25T00:00:00.000' AS DateTime), CAST(N'2023-05-25T00:00:00.000' AS DateTime), N'F', 480, 1, 0, 0, N'TESTTTT', N'LB01', N'02', 0, N'EMP01', CAST(N'2023-05-25T13:44:07.763' AS DateTime), N'EMP01', CAST(N'2023-05-25T13:53:02.087' AS DateTime), 0)
INSERT [dbo].[SELF_TR_TIMELEAVE] ([COMPANY_CODE], [WORKER_CODE], [TIMELEAVE_ID], [TIMELEAVE_DOC], [TIMELEAVE_FROMDATE], [TIMELEAVE_TODATE], [TIMELEAVE_TYPE], [TIMELEAVE_MIN], [TIMELEAVE_ACTUALDAY], [TIMELEAVE_INCHOLIDAY], [TIMELEAVE_DEDUCT], [TIMELEAVE_NOTE], [LEAVE_CODE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 2, N'LEAVE_20230525141114', CAST(N'2023-05-26T00:00:00.000' AS DateTime), CAST(N'2023-05-26T00:00:00.000' AS DateTime), N'H1', 240, 1, 0, 0, N'Sick', N'LB02', N'02', 0, N'EMP01', CAST(N'2023-05-25T14:11:14.843' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_TIMEONSITE] ([COMPANY_CODE], [WORKER_CODE], [TIMEONSITE_ID], [TIMEONSITE_DOC], [TIMEONSITE_WORKDATE], [TIMEONSITE_IN], [TIMEONSITE_OUT], [TIMEONSITE_NOTE], [REASON_CODE], [LOCATION_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'1234', CAST(N'2023-05-09T00:00:00.000' AS DateTime), N'07:00', N'16:00', N'TEST', N'01', N'00000', 2, N'Admin', CAST(N'2023-05-22T14:12:45.160' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_TIMEOT] ([COMPANY_CODE], [WORKER_CODE], [TIMEOT_ID], [TIMEOT_DOC], [TIMEOT_WORKDATE], [TIMEOT_BEFOREMIN], [TIMEOT_NORMALMIN], [TIMEOT_BREAK], [TIMEOT_AFTERMIN], [TIMEOT_NOTE], [REASON_CODE], [LOCATION_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'EOT220930006', CAST(N'2023-03-28T00:00:00.000' AS DateTime), 480, 0, 0, 0, N'TEST', N'01', N'00000', 1, N'Admin', CAST(N'2023-05-22T13:51:03.130' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_TIMESHIFT] ([COMPANY_CODE], [WORKER_CODE], [TIMESHIFT_ID], [TIMESHIFT_DOC], [TIMESHIFT_WORKDATE], [TIMESHIFT_OLD], [TIMESHIFT_NEW], [TIMESHIFT_NOTE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'ESH221003006', CAST(N'2023-03-28T00:00:00.000' AS DateTime), N'Shift N1', N'Shift N2', N'TEST', N'01', 1, N'Admin', CAST(N'2023-05-22T13:50:02.150' AS DateTime), NULL, NULL, 0)
GO
