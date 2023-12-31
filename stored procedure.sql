DECLARE CURA CURSOR FOR SELECT UNITSONORDER , UNITPRICE ,PRODUCTNAME FROM PRODUCTS 
OPEN CURA
DECLARE @UNITSONORDER SMALLINT , @UNITPRICE MONEY , @PRODUCTNAME VARCHAR(MAX);
FETCH NEXT FROM CURA INTO @UNITSONORDER , @UNITPRICE ,@PRODUCTNAME;
--SELECT @UNITSONORDER AS [UNITS ON ORDER],@UNITPRICE AS [UNIT PRICE] 

--DECLARE @UNITSONORDER SMALLINT , @UNITPRICE MONEY ;
WHILE @@FETCH_STATUS = 0 
BEGIN
FETCH NEXT FROM CURA INTO @UNITSONORDER , @UNITPRICE , @PRODUCTNAME ;
SELECT @UNITSONORDER AS [UNITS ON ORDER],@UNITPRICE AS [UNIT PRICE] 
DECLARE @TOTAL_AMOUNT INT ;
SELECT @TOTAL_AMOUNT = @UNITPRICE*@UNITPRICE ;
--SELECT @PRODUCTNAME AS [PRODUCT NAME], @TOTAL_AMOUNT AS [TOTAL AMOUNT]
if @UnitsOnOrder>50 and @UnitsOnOrder<100
	BEGIN
		SELECT @TOTALAMOUNT=(@UnitsOnOrder*@UnitPrice)*0.95;
	END
	else if  @UnitsOnOrder>100
	BEGIN
		SELECT @TOTALAMOUNT=(@UnitsOnOrder*@UnitPrice)*0.90;
	END
	else
	BEGIN
		SELECT @TOTALAMOUNT=(@UnitsOnOrder*@UnitPrice);
	END
	PRINT 'PRODUCT NAME ' + @ProductName + ' and TOTAL AMOUNT IS ' + CAST(@TOTALAMOUNT as VARCHAR);
	FETCH NEXT FROM CURA INTO @UnitsOnOrder,@UnitPrice,@ProductName;
SELECT 'DONE' AS [COLUMN BREAK MESSAGE]
END 
CLOSE CURA ;
DEALLOCATE CURA ;
