USE [OPR]
GO
/****** Object:  Table [dbo].[ATT_MT_LOCATION]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_LOCATION](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[LOCATION_ID] [int] NOT NULL,
	[LOCATION_CODE] [varchar](5) NOT NULL,
	[LOCATION_NAME_TH] [varchar](100) NOT NULL,
	[LOCATION_NAME_EN] [varchar](100) NOT NULL,
	[LOCATION_DETAIL] [varchar](500) NULL,
	[LOCATION_LATITUDE] [varchar](100) NULL,
	[LOCATION_LONGITUDE] [varchar](100) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_LOCATION] PRIMARY KEY CLUSTERED 
(
	[LOCATION_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_PERIOD]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_PERIOD](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[PERIOD_ID] [int] NOT NULL,
	[PERIOD_TYPE] [char](3) NOT NULL,
	[EMPTYPE_CODE] [char](1) NOT NULL,
	[YEAR_CODE] [char](4) NOT NULL,
	[PERIOD_NO] [char](2) NOT NULL,
	[PERIOD_NAME_TH] [varchar](200) NOT NULL,
	[PERIOD_NAME_EN] [varchar](200) NOT NULL,
	[PERIOD_FROM] [datetime] NOT NULL,
	[PERIOD_TO] [datetime] NOT NULL,
	[PERIOD_PAYMENT] [datetime] NOT NULL,
	[PERIOD_DAYONPERIOD] [bit] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_PERIOD] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[PERIOD_TYPE] ASC,
	[EMPTYPE_CODE] ASC,
	[YEAR_CODE] ASC,
	[PERIOD_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_PLANHOLIDAY]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_PLANHOLIDAY](
	[PLANHOLIDAY_ID] [int] NOT NULL,
	[PLANHOLIDAY_CODE] [varchar](10) NOT NULL,
	[PLANHOLIDAY_NAME_TH] [varchar](200) NOT NULL,
	[PLANHOLIDAY_NAME_EN] [varchar](200) NOT NULL,
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[YEAR_CODE] [varchar](4) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_PLANHOLIDAY] PRIMARY KEY CLUSTERED 
(
	[PLANHOLIDAY_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_PLANSHIFT]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_PLANSHIFT](
	[PLANSHIFT_ID] [int] NOT NULL,
	[PLANSHIFT_CODE] [varchar](10) NOT NULL,
	[PLANSHIFT_NAME_TH] [varchar](200) NOT NULL,
	[PLANSHIFT_NAME_EN] [varchar](200) NOT NULL,
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_PLANSHIFT] PRIMARY KEY CLUSTERED 
(
	[PLANSHIFT_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_REASON]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_REASON](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[REASON_ID] [int] NOT NULL,
	[REASON_CODE] [varchar](5) NOT NULL,
	[REASON_NAME_TH] [varchar](100) NOT NULL,
	[REASON_NAME_EN] [varchar](100) NOT NULL,
	[REASON_GROUP] [varchar](10) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_REASON] PRIMARY KEY CLUSTERED 
(
	[REASON_CODE] ASC,
	[REASON_GROUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_SHIFT]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_SHIFT](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[SHIFT_ID] [int] NOT NULL,
	[SHIFT_CODE] [varchar](10) NOT NULL,
	[SHIFT_NAME_TH] [varchar](100) NOT NULL,
	[SHIFT_NAME_EN] [varchar](100) NOT NULL,
	[SHIFT_CH1] [char](5) NULL,
	[SHIFT_CH2] [char](5) NULL,
	[SHIFT_CH3] [char](5) NOT NULL,
	[SHIFT_CH4] [char](5) NOT NULL,
	[SHIFT_CH5] [char](5) NULL,
	[SHIFT_CH6] [char](5) NULL,
	[SHIFT_CH7] [char](5) NULL,
	[SHIFT_CH8] [char](5) NULL,
	[SHIFT_CH9] [char](5) NOT NULL,
	[SHIFT_CH10] [char](5) NOT NULL,
	[SHIFT_CH3_FROM] [char](5) NOT NULL,
	[SHIFT_CH3_TO] [char](5) NOT NULL,
	[SHIFT_CH4_FROM] [char](5) NOT NULL,
	[SHIFT_CH4_TO] [char](5) NOT NULL,
	[SHIFT_CH7_FROM] [char](5) NOT NULL,
	[SHIFT_CH7_TO] [char](5) NOT NULL,
	[SHIFT_CH8_FROM] [char](5) NOT NULL,
	[SHIFT_CH8_TO] [char](5) NOT NULL,
	[SHIFT_OTIN_MIN] [int] NOT NULL,
	[SHIFT_OTIN_MAX] [int] NOT NULL,
	[SHIFT_OTOUT_MIN] [int] NOT NULL,
	[SHIFT_OTOUT_MAX] [int] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
	[SHIFT_FLEXIBLEBREAK] [bit] NULL,
 CONSTRAINT [PK_ATT_MT_SHIFT] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[SHIFT_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_MT_YEAR]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_MT_YEAR](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[YEAR_ID] [int] NOT NULL,
	[YEAR_CODE] [char](4) NOT NULL,
	[YEAR_NAME_TH] [varchar](100) NOT NULL,
	[YEAR_NAME_EN] [varchar](100) NOT NULL,
	[YEAR_FROMDATE] [datetime] NOT NULL,
	[YEAR_TODATE] [datetime] NOT NULL,
	[YEAR_GROUP] [varchar](10) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_MT_YEAR] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[YEAR_CODE] ASC,
	[YEAR_GROUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_EMPPOLATT]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_EMPPOLATT](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[EMPPOLATT_POLICY_CODE] [varchar](20) NOT NULL,
	[EMPPOLATT_POLICY_TYPE] [char](2) NOT NULL,
	[EMPPOLATT_POLICY_NOTE] [varchar](100) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[FLAG] [bit] NULL,
 CONSTRAINT [PK_ATT_TR_EMPPOLATT] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[EMPPOLATT_POLICY_CODE] ASC,
	[EMPPOLATT_POLICY_TYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_HOLIDAY]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_HOLIDAY](
	[HOLIDAY_DATE] [datetime] NOT NULL,
	[HOLIDAY_NAME_TH] [varchar](300) NOT NULL,
	[HOLIDAY_NAME_EN] [varchar](300) NOT NULL,
	[PLANHOLIDAY_CODE] [varchar](10) NOT NULL,
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[HOLIDAY_DAYTYPE] [char](1) NULL,
	[HOLIDAY_PAYPER] [decimal](5, 2) NULL,
 CONSTRAINT [PK_ATT_TR_HOLIDAY] PRIMARY KEY CLUSTERED 
(
	[HOLIDAY_DATE] ASC,
	[COMPANY_CODE] ASC,
	[PLANHOLIDAY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_LATE]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_LATE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[LATE_CODE] [varchar](10) NOT NULL,
	[LATE_FROM] [int] NOT NULL,
	[LATE_TO] [int] NOT NULL,
	[LATE_DEDUCT_TYPE] [char](1) NOT NULL,
	[LATE_DEDUCT_AMOUNT] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_ATT_TR_LATE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[LATE_CODE] ASC,
	[LATE_FROM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_PLANSCHEDULE]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_PLANSCHEDULE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[PLANSHIFT_CODE] [varchar](10) NOT NULL,
	[PLANSCHEDULE_FROMDATE] [datetime] NOT NULL,
	[PLANSCHEDULE_TODATE] [datetime] NOT NULL,
	[SHIFT_CODE] [varchar](10) NOT NULL,
	[PLANSCHEDULE_SUN_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_MON_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_TUE_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_WED_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_THU_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_FRI_OFF] [char](1) NOT NULL,
	[PLANSCHEDULE_SAT_OFF] [char](1) NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_ATT_TR_PLANSCHEDULE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[PLANSHIFT_CODE] ASC,
	[PLANSCHEDULE_FROMDATE] ASC,
	[PLANSCHEDULE_TODATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_SHIFTALLOWANCE]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_SHIFTALLOWANCE](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[SHIFT_CODE] [varchar](10) NOT NULL,
	[SHIFTALLOWANCE_NO] [int] NOT NULL,
	[SHIFTALLOWANCE_NAME_TH] [varchar](100) NULL,
	[SHIFTALLOWANCE_NAME_EN] [varchar](100) NULL,
	[SHIFTALLOWANCE_HHMM] [char](5) NOT NULL,
	[SHIFTALLOWANCE_AMOUNT] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_ATT_TR_SHIFTALLOWANCE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[SHIFT_CODE] ASC,
	[SHIFTALLOWANCE_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ATT_TR_SHIFTBREAK]    Script Date: 20/02/2023 18:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATT_TR_SHIFTBREAK](
	[COMPANY_CODE] [varchar](5) NOT NULL,
	[SHIFT_CODE] [varchar](10) NOT NULL,
	[SHIFTBREAK_NO] [int] NOT NULL,
	[SHIFTBREAK_FROM] [char](5) NOT NULL,
	[SHIFTBREAK_TO] [char](5) NOT NULL,
	[SHIFTBREAK_BREAK] [int] NOT NULL,
 CONSTRAINT [PK_ATT_TR_SHIFTBREAK] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[SHIFT_CODE] ASC,
	[SHIFTBREAK_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ATT_MT_LOCATION] ([COMPANY_CODE], [LOCATION_ID], [LOCATION_CODE], [LOCATION_NAME_TH], [LOCATION_NAME_EN], [LOCATION_DETAIL], [LOCATION_LATITUDE], [LOCATION_LONGITUDE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'00000', N'สำนักงานใหญ่', N'CENTER', N'952 อาคารรามาแลนด์ ชั้นที่ 11 ถนนพระรามสี่ แขวงสุริยวงศ์  เขตบางรัก จังหวัดกรุงเทพฯ 10500', N'13.7606452', N'100.6331538', N'Not login', CAST(N'2023-02-14T13:13:24.080' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[ATT_MT_LOCATION] ([COMPANY_CODE], [LOCATION_ID], [LOCATION_CODE], [LOCATION_NAME_TH], [LOCATION_NAME_EN], [LOCATION_DETAIL], [LOCATION_LATITUDE], [LOCATION_LONGITUDE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 2, N'00001', N'ชลบุรี', N'Chon Buri', N'88 หมู่.5 ตำบลเหมือง อำเมืองชลบุรี จังหวัดชลบุรี 20130', N'13.7606452', N'100.6331538', N'Not login', CAST(N'2023-02-14T13:21:54.637' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[ATT_MT_PERIOD] ([COMPANY_CODE], [PERIOD_ID], [PERIOD_TYPE], [EMPTYPE_CODE], [YEAR_CODE], [PERIOD_NO], [PERIOD_NAME_TH], [PERIOD_NAME_EN], [PERIOD_FROM], [PERIOD_TO], [PERIOD_PAYMENT], [PERIOD_DAYONPERIOD], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 2, N'PAY', N'D', N'2023', N'01', N'มกราคม', N'January', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-02-15T00:00:00.000' AS DateTime), CAST(N'2023-01-31T00:00:00.000' AS DateTime), 1, N'Not login', CAST(N'2023-02-07T17:58:16.810' AS DateTime), N'Not login', CAST(N'2023-02-07T18:04:45.127' AS DateTime), 0)
INSERT [dbo].[ATT_MT_PERIOD] ([COMPANY_CODE], [PERIOD_ID], [PERIOD_TYPE], [EMPTYPE_CODE], [YEAR_CODE], [PERIOD_NO], [PERIOD_NAME_TH], [PERIOD_NAME_EN], [PERIOD_FROM], [PERIOD_TO], [PERIOD_PAYMENT], [PERIOD_DAYONPERIOD], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 5, N'PAY', N'D', N'2023', N'02', N'กุมภาพันธ์', N'February', CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-02-15T00:00:00.000' AS DateTime), CAST(N'2023-02-28T00:00:00.000' AS DateTime), 1, N'Not login', CAST(N'2023-02-08T11:30:46.643' AS DateTime), N'Not login', CAST(N'2023-02-08T11:35:54.613' AS DateTime), 0)
INSERT [dbo].[ATT_MT_PERIOD] ([COMPANY_CODE], [PERIOD_ID], [PERIOD_TYPE], [EMPTYPE_CODE], [YEAR_CODE], [PERIOD_NO], [PERIOD_NAME_TH], [PERIOD_NAME_EN], [PERIOD_FROM], [PERIOD_TO], [PERIOD_PAYMENT], [PERIOD_DAYONPERIOD], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 3, N'PAY', N'M', N'2023', N'01', N'มกราคม', N'January', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-01-31T00:00:00.000' AS DateTime), CAST(N'2023-01-28T00:00:00.000' AS DateTime), 1, N'Not login', CAST(N'2023-02-08T11:18:49.250' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[ATT_MT_PERIOD] ([COMPANY_CODE], [PERIOD_ID], [PERIOD_TYPE], [EMPTYPE_CODE], [YEAR_CODE], [PERIOD_NO], [PERIOD_NAME_TH], [PERIOD_NAME_EN], [PERIOD_FROM], [PERIOD_TO], [PERIOD_PAYMENT], [PERIOD_DAYONPERIOD], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 4, N'PAY', N'M', N'2023', N'02', N'กุมภาพันธ์', N'February', CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-02-28T00:00:00.000' AS DateTime), CAST(N'2023-02-28T00:00:00.000' AS DateTime), 1, N'Not login', CAST(N'2023-02-08T11:22:32.500' AS DateTime), N'Not login', CAST(N'2023-02-08T11:35:43.807' AS DateTime), 0)
GO
INSERT [dbo].[ATT_MT_PLANHOLIDAY] ([PLANHOLIDAY_ID], [PLANHOLIDAY_CODE], [PLANHOLIDAY_NAME_TH], [PLANHOLIDAY_NAME_EN], [COMPANY_CODE], [YEAR_CODE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (1, N'HOLD', N'วันหยุดประจำปีรายวัน', N'Holiday(Daily)', N'OPR', N'2023', N'Not login', CAST(N'2023-02-16T11:37:46.240' AS DateTime), N'Not login', CAST(N'2023-02-16T11:37:53.850' AS DateTime), 0)
GO
INSERT [dbo].[ATT_MT_PLANSHIFT] ([PLANSHIFT_ID], [PLANSHIFT_CODE], [PLANSHIFT_NAME_TH], [PLANSHIFT_NAME_EN], [COMPANY_CODE], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (1, N'Plan01', N'แผนการทำงานพนักงานประจำ', N'Plan for permanent Staff ', N'OPR', N'Not login', CAST(N'2023-02-20T17:48:59.027' AS DateTime), N'Not login', CAST(N'2023-02-20T18:34:03.020' AS DateTime), 0)
GO
INSERT [dbo].[ATT_MT_REASON] ([COMPANY_CODE], [REASON_ID], [REASON_CODE], [REASON_NAME_TH], [REASON_NAME_EN], [REASON_GROUP], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 2, N'01', N'ได้งานใหม่', N'New Work', N'EMP', N'Not login', CAST(N'2023-02-13T13:18:24.910' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[ATT_MT_REASON] ([COMPANY_CODE], [REASON_ID], [REASON_CODE], [REASON_NAME_TH], [REASON_NAME_EN], [REASON_GROUP], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'01', N'ลาพักร้อน', N'Summer', N'LEAVE', N'Not login', CAST(N'2023-02-13T12:43:18.917' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[ATT_MT_SHIFT] ([COMPANY_CODE], [SHIFT_ID], [SHIFT_CODE], [SHIFT_NAME_TH], [SHIFT_NAME_EN], [SHIFT_CH1], [SHIFT_CH2], [SHIFT_CH3], [SHIFT_CH4], [SHIFT_CH5], [SHIFT_CH6], [SHIFT_CH7], [SHIFT_CH8], [SHIFT_CH9], [SHIFT_CH10], [SHIFT_CH3_FROM], [SHIFT_CH3_TO], [SHIFT_CH4_FROM], [SHIFT_CH4_TO], [SHIFT_CH7_FROM], [SHIFT_CH7_TO], [SHIFT_CH8_FROM], [SHIFT_CH8_TO], [SHIFT_OTIN_MIN], [SHIFT_OTIN_MAX], [SHIFT_OTOUT_MIN], [SHIFT_OTOUT_MAX], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG], [SHIFT_FLEXIBLEBREAK]) VALUES (N'OPR', 1, N'Shift N1', N'กะการทำงานเวลาปกติ 7.00-16.00น.', N'Shift Normal 7.00-16.00', N'04:00', N'07:00', N'07:00', N'16:00', N'00:00', N'00:00', N'00:00', N'00:00', N'16:00', N'22:00', N'04:00', N'12:00', N'12:00', N'22:00', N'00:00', N'00:00', N'00:00', N'00:00', 3, 3, 6, 6, N'Not login', CAST(N'2023-02-16T17:10:47.000' AS DateTime), N'Not login', CAST(N'2023-02-17T10:03:40.600' AS DateTime), 0, 1)
GO
INSERT [dbo].[ATT_MT_YEAR] ([COMPANY_CODE], [YEAR_ID], [YEAR_CODE], [YEAR_NAME_TH], [YEAR_NAME_EN], [YEAR_FROMDATE], [YEAR_TODATE], [YEAR_GROUP], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 2, N'2023', N'ปีการลา', N'Leave Calendar', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-12-31T00:00:00.000' AS DateTime), N'LEAVE', N'Not login', CAST(N'2023-02-08T11:27:16.660' AS DateTime), N'Not login', CAST(N'2023-02-15T09:55:42.480' AS DateTime), 0)
INSERT [dbo].[ATT_MT_YEAR] ([COMPANY_CODE], [YEAR_ID], [YEAR_CODE], [YEAR_NAME_TH], [YEAR_NAME_EN], [YEAR_FROMDATE], [YEAR_TODATE], [YEAR_GROUP], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', 1, N'2023', N'ปีภาษี', N'Tax Calendar', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-12-31T00:00:00.000' AS DateTime), N'TAX', N'Not login', CAST(N'2023-02-08T11:27:16.620' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[ATT_TR_HOLIDAY] ([HOLIDAY_DATE], [HOLIDAY_NAME_TH], [HOLIDAY_NAME_EN], [PLANHOLIDAY_CODE], [COMPANY_CODE], [HOLIDAY_DAYTYPE], [HOLIDAY_PAYPER]) VALUES (CAST(N'2023-01-01T00:00:00.000' AS DateTime), N'ปีใหม่', N'New Year', N'HOLD', N'OPR', N'H', CAST(100.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ATT_TR_PLANSCHEDULE] ([COMPANY_CODE], [PLANSHIFT_CODE], [PLANSCHEDULE_FROMDATE], [PLANSCHEDULE_TODATE], [SHIFT_CODE], [PLANSCHEDULE_SUN_OFF], [PLANSCHEDULE_MON_OFF], [PLANSCHEDULE_TUE_OFF], [PLANSCHEDULE_WED_OFF], [PLANSCHEDULE_THU_OFF], [PLANSCHEDULE_FRI_OFF], [PLANSCHEDULE_SAT_OFF], [CREATED_BY], [CREATED_DATE], [MODIFIED_BY], [MODIFIED_DATE], [FLAG]) VALUES (N'OPR', N'Plan01', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-12-31T00:00:00.000' AS DateTime), N'Shift N1', N'Y', N'N', N'N', N'N', N'N', N'N', N'Y', N'Admin', CAST(N'2023-02-20T18:34:03.087' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[ATT_TR_SHIFTALLOWANCE] ([COMPANY_CODE], [SHIFT_CODE], [SHIFTALLOWANCE_NO], [SHIFTALLOWANCE_NAME_TH], [SHIFTALLOWANCE_NAME_EN], [SHIFTALLOWANCE_HHMM], [SHIFTALLOWANCE_AMOUNT]) VALUES (N'OPR', N'Shift N1', 1, N'กะ', N'Ka', N'04:00', CAST(40.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[ATT_TR_SHIFTBREAK] ([COMPANY_CODE], [SHIFT_CODE], [SHIFTBREAK_NO], [SHIFTBREAK_FROM], [SHIFTBREAK_TO], [SHIFTBREAK_BREAK]) VALUES (N'OPR', N'Shift N1', 1, N'12:00', N'13:00', 1)
GO
