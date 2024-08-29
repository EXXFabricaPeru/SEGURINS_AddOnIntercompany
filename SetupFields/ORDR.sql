CREATE PROCEDURE "SBO_EXX_INDO_PTN_OBJ017_ORDR"
(
	IN docEntry integer
	, IN transaction_type nchar(1)
	, OUT error integer
	, OUT error_message nvarchar(200)
)
LANGUAGE SQLSCRIPT AS

BEGIN 

	IF :transaction_type = 'A' THEN		
		UPDATE ORDR 
		SET "U_EXX_INDO_ESTADO" = (CASE WHEN (SELECT COUNT(A2."ItemCode")
											FROM ORDR A
											INNER JOIN RDR1 A1 ON A."DocEntry" = A1."DocEntry"
											INNER JOIN OITM A2 ON A1."ItemCode" = A2."ItemCode"
											INNER JOIN "@EXX_INDO_BASE" A3 ON A2."U_EXX_INDO_BASE" = A3."Code" AND A."CardCode" <> A3."U_EXX_INDO_CLIE"
											WHERE A3."Code" <> (SELECT CURRENT_SCHEMA FROM DUMMY)
											AND A2."OnHand" < A1."Quantity"
											AND A."DocEntry" = :docEntry)> 0 THEN 'PE' ELSE 'NA' END)
		WHERE "DocEntry" = :docEntry;
	END IF;
END;