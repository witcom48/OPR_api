USE [OPR]
GO
/****** Object:  Table [dbo].[SELF_MT_WORKFLOW]    Script Date: 03/04/2023 09:53:35 ******/
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
/****** Object:  Table [dbo].[SELF_TR_TIMELEAVE]    Script Date: 03/04/2023 09:53:36 ******/
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
	[TIMELEAVE_TYPE] [char](1) NOT NULL,
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
/****** Object:  Table [dbo].[SELF_TR_TIMEOT]    Script Date: 03/04/2023 09:53:36 ******/
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
/****** Object:  Table [dbo].[SELF_TR_TIMESHIFT]    Script Date: 03/04/2023 09:53:36 ******/
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
INSERT [dbo].[SELF_MT_WORKFLOW] ([COMPANY_CODE], [WORKFLOW_ID], [WORKFLOW_CODE], [WORKFLOW_NAME_TH], [WORKFLOW_NAME_EN], [WORKFLOW_TYPE], [STEP1], [STEP2], [STEP3], [STEP4], [STEP5], [TOTALAPPROVE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'LV1-2', N'ผู้อนุมัติ 1 คน รหัสแทนตำแหน่ง รหัส 2', N'1 approver, position code, code 2', N'LEAVE', 1, 0, 0, 0, 0, 1, N'Admin', CAST(N'2023-03-30T16:58:26.027' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[SELF_TR_TIMELEAVE] ([COMPANY_CODE], [WORKER_CODE], [TIMELEAVE_ID], [TIMELEAVE_DOC], [TIMELEAVE_FROMDATE], [TIMELEAVE_TODATE], [TIMELEAVE_TYPE], [TIMELEAVE_MIN], [TIMELEAVE_ACTUALDAY], [TIMELEAVE_INCHOLIDAY], [TIMELEAVE_DEDUCT], [TIMELEAVE_NOTE], [LEAVE_CODE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'ELV221003004', CAST(N'2023-03-27T00:00:00.000' AS DateTime), CAST(N'2023-03-27T00:00:00.000' AS DateTime), N'F', 480, 1, 0, 0, N'TEST123', N'LB01', N'01', 1, N'Admin', CAST(N'2023-03-27T15:31:08.213' AS DateTime), N'Admin', CAST(N'2023-03-28T11:06:08.283' AS DateTime), 0)
GO
INSERT [dbo].[SELF_TR_TIMEOT] ([COMPANY_CODE], [WORKER_CODE], [TIMEOT_ID], [TIMEOT_DOC], [TIMEOT_WORKDATE], [TIMEOT_BEFOREMIN], [TIMEOT_NORMALMIN], [TIMEOT_BREAK], [TIMEOT_AFTERMIN], [TIMEOT_NOTE], [REASON_CODE], [LOCATION_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'EOT220930006', CAST(N'2023-03-28T00:00:00.000' AS DateTime), 480, 0, 0, 0, N'TEST', N'01', N'00000', 1, N'Admin', CAST(N'2023-03-28T14:29:07.643' AS DateTime), N'Admin', CAST(N'2023-03-28T14:31:34.033' AS DateTime), 0)
GO
INSERT [dbo].[SELF_TR_TIMESHIFT] ([COMPANY_CODE], [WORKER_CODE], [TIMESHIFT_ID], [TIMESHIFT_DOC], [TIMESHIFT_WORKDATE], [TIMESHIFT_OLD], [TIMESHIFT_NEW], [TIMESHIFT_NOTE], [REASON_CODE], [STATUS], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'EMP01', 1, N'ESH221003006', CAST(N'2023-03-28T00:00:00.000' AS DateTime), N'Shift N1', N'Shift N2', N'TEST', N'01', 1, N'Admin', CAST(N'2023-03-28T17:38:09.210' AS DateTime), NULL, NULL, 0)
GO
