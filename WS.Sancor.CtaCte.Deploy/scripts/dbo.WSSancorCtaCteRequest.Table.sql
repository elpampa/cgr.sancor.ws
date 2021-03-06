SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WSSancorCtaCteRequest](
	[ncContratoCtaCteRequest] [int] IDENTITY(1,1) NOT NULL,
	[nContrato] [int] NULL,
	[cResultado] [varchar](max) NULL,
	[cError] [varchar](10) NULL,
	[cdError] [varchar](255) NULL,
	[dGeneracionResultado] [datetime] NULL,
	[dDateIns] [datetime] NOT NULL,
	[cUserIns] [varchar](30) NULL,
	[cReferencia] [varchar](255) NULL,
	[ncEstado] [int] NOT NULL CONSTRAINT [DF__WSSancorC__ncEst__442B18F2]  DEFAULT ((0)),
 CONSTRAINT [PK_WSSancorCtaCteRequest] PRIMARY KEY CLUSTERED 
(
	[ncContratoCtaCteRequest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Error de la aplicación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'cError'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion del error de la aplicación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'cdError'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha y hora de finalizacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'dGeneracionResultado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha y hora de insersion en tabla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'dDateIns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario de insersion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'cUserIns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'(0-Pending / 1-Finished)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WSSancorCtaCteRequest', @level2type=N'COLUMN',@level2name=N'ncEstado'
GO
