set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

CREATE FUNCTION [dbo].[FN_Cotizar_ART](@CuitEmpresa [bigint], @CodActividad [int], @CantTrabajadores [int], @MasaSalarial [decimal](18, 0), @CodPostal [smallint])
RETURNS [nvarchar](4000) WITH EXECUTE AS CALLER
AS EXTERNAL NAME [WSSancor].[WSSancor.Tarifas].[CotizarART]


select dbo.FN_Cotizar_ART(30599791716, 611093, 2, 13200, 1425)

drop function   [dbo].[FN_Cotizar_ART]
