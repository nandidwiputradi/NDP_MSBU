USE [NDP_MSBU_DB]
GO
/****** Object:  Table [dbo].[ms_storage_location]    Script Date: 5/25/2023 12:43:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ms_storage_location](
	[location_id] [varchar](10) NOT NULL,
	[location_name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ms_storage_locaation] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ms_storage_location] ([location_id], [location_name]) VALUES (N'gtml', N'guatemala')
GO
INSERT [dbo].[ms_storage_location] ([location_id], [location_name]) VALUES (N'splo', N'sao paulo')
GO
