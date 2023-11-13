USE [CFI]
GO

/****** Object:  Table [dbo].[Agencia]    Script Date: 10/11/2023 17:45:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[MinimumValue] [decimal](15, 2) NOT NULL,
	[MaximumValue] [decimal](15, 2) NOT NULL,
	[Code] [varchar](25) NOT NULL,
	[Description] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO



