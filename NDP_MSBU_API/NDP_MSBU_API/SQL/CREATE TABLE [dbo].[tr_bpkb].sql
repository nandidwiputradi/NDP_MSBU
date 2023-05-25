USE [NDP_MSBU_DB]
GO

/****** Object:  Table [dbo].[tr_bpkb]    Script Date: 5/25/2023 12:44:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tr_bpkb](
	[agreement_number] [varchar](100) NOT NULL,
	[bpkb_no] [varchar](100) NULL,
	[branch_id] [varchar](10) NULL,
	[bpkb_date] [datetime] NULL,
	[faktur_no] [varchar](100) NULL,
	[faktur_date] [datetime] NULL,
	[location_id] [varchar](10) NOT NULL,
	[police_no] [varchar](20) NULL,
	[bpkb_date_in] [datetime] NULL,
 CONSTRAINT [PK_tr_bpkb] PRIMARY KEY CLUSTERED 
(
	[agreement_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tr_bpkb]  WITH CHECK ADD  CONSTRAINT [FK_ms_storage_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[ms_storage_location] ([location_id])
GO

ALTER TABLE [dbo].[tr_bpkb] CHECK CONSTRAINT [FK_ms_storage_location]
GO


