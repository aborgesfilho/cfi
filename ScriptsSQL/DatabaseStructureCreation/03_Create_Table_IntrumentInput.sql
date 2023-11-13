USE [CFI]
GO

/****** Object:  Table [dbo].[Agencia]    Script Date: 10/11/2023 17:45:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InstrumentInput](
	[InstrumentInputId] [int] IDENTITY(1,1) NOT NULL,
	[NickName] [varchar](25) NOT NULL,
	[MarketValue] [decimal] (12, 2) NOT NULL,
	[Type] [varchar](25) NOT NULL,
	[ProcessDate] [datetime] NOT NULL,
 PRIMARY KEY CLUSTERED 
(
	[InstrumentInputId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO



