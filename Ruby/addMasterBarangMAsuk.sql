USE [Ruby]
GO
/****** Object:  StoredProcedure [dbo].[addMasterBarangMasuk]    Script Date: 07/22/2015 14:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[addMasterBarangMasuk]
	@nonota varchar(50),
	
	@tglNota date,
	@kodeSuplier varchar(10),
	@totalBeli money,
	@kodeOperator varchar (10),
	@isLunas char(1),
	@isRetur  char(1),
	@dp money,
	@tglJatuhTempo date
AS
BEGIN

	declare @kodeBH as varchar(10);
	declare @kdBH as int;
	declare @thisyear as varchar(2);
	
	select @thisyear = RIGHT(YEAR(@tglnota),2)
	
	INSERT INTO barangMasuk (noNota,tgl,tglNota,kodeSuplier,totalBeli,kodeOperator,isLunas,isRetur)
	VALUES (@nonota,CURRENT_TIMESTAMP,@tglNota, @kodeSuplier ,@totalBeli,@kodeOperator,@isLunas,'0')

	if @isLunas='0'
		begin
			select top(1) @kodeBH = SUBSTRING(kodeHutang,5,4) from hutang  WHERE YEAR(tglnota) = YEAR(GETDATE()) order by kodeHutang desc
			if @kodeBH is null
				set @kodeBH = 'BH' + @thisyear + '0001'
			else
				begin
					select @kdBH = CONVERT(int,@kodeBH);
					select @kdBH = @kdBH+1;
					select @kodeBH = CONVERT(int,@kdBH);
					select @kodeBH = '0000' + @kodeBH;
					select @kodeBH = RIGHT(@kodeBH,4);
					select @kodeBH = 'BH' + @thisyear  +@kodeBH ;
				end
						
			INSERT INTO hutang (kodeHutang ,noNota,tglNota,tglJatuhTempo,kodeSuplier ,sisaHutang,dp,pembayaran)
			VALUES (@kodeBH,@nonota,@tglNota ,@tglJatuhTempo ,@kodeSuplier,@totalBeli-@dp,@dp,0)
					
		end
		
END
