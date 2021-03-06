USE [Health]
GO
/****** Object:  StoredProcedure [dbo].[spGetPurchaseStats]    Script Date: 10/7/2020 3:44:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[spGetPurchaseStats]
(
  @StartYear INT = NULL
)
AS
BEGIN
	
	SELECT COUNT(Inv_Num) AS NumberOfPurchases,DATENAME(MONTH, Inv_Date) AS Month 
	FROM tblInv_Info
	WHERE CONVERT(DATE, Inv_Date) BETWEEN CONVERT(DATE,CONVERT(CHAR(4),ISNULL(@StartYear,2012))+'-01-01') AND CONVERT(DATE, CONVERT(CHAR(4), DATEPART(YEAR, GETDATE())) + '-12-31')
	GROUP BY DATENAME(MONTH, Inv_Date)
END


