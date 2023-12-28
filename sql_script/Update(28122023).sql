USE [OPR]
GO
/****** Object:  Table [dbo].[PAY_MT_REFERRAL]    Script Date: 28/12/2023 14:22:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_MT_REFERRAL]') AND type in (N'U'))
DROP TABLE [dbo].[PAY_MT_REFERRAL]
GO
/****** Object:  Table [dbo].[EMP_TR_UNIFORM]    Script Date: 28/12/2023 14:22:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMP_TR_UNIFORM]') AND type in (N'U'))
DROP TABLE [dbo].[EMP_TR_UNIFORM]
GO
/****** Object:  Table [dbo].[EMP_TR_SUGGEST]    Script Date: 28/12/2023 14:22:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMP_TR_SUGGEST]') AND type in (N'U'))
DROP TABLE [dbo].[EMP_TR_SUGGEST]
GO
/****** Object:  Table [dbo].[EMP_TR_SUGGEST]    Script Date: 28/12/2023 14:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMP_TR_SUGGEST](
	[COMPANY_CODE] [varchar](20) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[EMPSUGGEST_ID] [int] NOT NULL,
	[EMPSUGGEST_CODE] [varchar](15) NOT NULL,
	[EMPSUGGEST_SUGGEST] [varchar](15) NOT NULL,
	[EMPSUGGEST_DATE] [datetime] NULL,
	[EMPSUGGEST_NOTE] [varchar](200) NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_EMP_TR_SUGGEST] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[EMPSUGGEST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMP_TR_UNIFORM]    Script Date: 28/12/2023 14:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMP_TR_UNIFORM](
	[COMPANY_CODE] [varchar](20) NOT NULL,
	[WORKER_CODE] [varchar](15) NOT NULL,
	[EMPUNIFORM_ID] [int] NOT NULL,
	[EMPUNIFORM_CODE] [varchar](15) NOT NULL,
	[PROJECT_CODE] [varchar](20) NOT NULL,
	[PROJOB_CODE] [varchar](20) NOT NULL,
	[PROEQUIPMENTTYPE_CODE] [varchar](20) NOT NULL,
	[EMPUNIFORM_QUANTITY] [decimal](4, 2) NOT NULL,
	[EMPUNIFORM_AMOUNT] [decimal](8, 2) NOT NULL,
	[EMPUNIFORM_ISSUEDATE] [datetime] NOT NULL,
	[EMPUNIFORM_NOTE] [varchar](200) NULL,
	[EMPUNIFORM_BY] [varchar](200) NULL,
	[EMPUNIFORM_PAYPERIOD] [decimal](8, 2) NOT NULL,
	[EMPUNIFORM_PAYAMOUNT] [decimal](8, 2) NOT NULL,
	[EMPUNIFORM_PERIOD] [datetime] NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_EMP_TR_UNIFORM] PRIMARY KEY CLUSTERED 
(
	[COMPANY_CODE] ASC,
	[WORKER_CODE] ASC,
	[EMPUNIFORM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAY_MT_REFERRAL]    Script Date: 28/12/2023 14:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAY_MT_REFERRAL](
	[COMPANY_CODE] [varchar](20) NOT NULL,
	[REFERRAL_ID] [int] NOT NULL,
	[REFERRAL_CODE] [varchar](10) NOT NULL,
	[REFERRAL_NAME_TH] [varchar](200) NOT NULL,
	[REFERRAL_NAME_EN] [varchar](200) NOT NULL,
	[ITEM_CODE] [varchar](20) NOT NULL,
	[NOTUSED] [bit] NOT NULL,
	[CREATED_BY] [varchar](20) NOT NULL,
	[CREATED_DATE] [datetime] NOT NULL,
	[MODIFIED_BY] [varchar](20) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[FLAG] [bit] NOT NULL,
 CONSTRAINT [PK_PAY_MT_REFERRAL] PRIMARY KEY CLUSTERED 
(
	[REFERRAL_CODE] ASC,
	[COMPANY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
