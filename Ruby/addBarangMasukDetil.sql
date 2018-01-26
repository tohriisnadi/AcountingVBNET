USE [Ruby]
GO
/****** Object:  StoredProcedure [dbo].[addBarangMasukDetil]    Script Date: 07/22/2015 14:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[addBarangMasukDetil]
	@noTXN varchar(50),
	@noNota varchar(50),
	@barcode varchar(30),
	@qty bigint,
	@satuan varchar(50),
	@hargaBeli money,
	@margin varchar(50),
	@hargaJual money,
	@subtotal money,
	@isRetur char(1)
	
AS 
BEGIN
	INSERT INTO  barangMasukdetil(noTXN,noNota,barcode,qty,satuan,hargaBeli,margin,hargaJual,subtotal,isRetur)
	VALUES (@noTXN,@noNota,@barcode,@qty,@satuan,@hargaBeli,@margin,@hargaJual ,@subtotal ,'0') 
	
END
