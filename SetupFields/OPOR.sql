CREATE PROCEDURE "SBO_EXX_INDO_PTN_OBJ020_OPOR"
(
	IN docEntry integer
	, IN transaction_type nchar(1)
	, OUT error integer
	, OUT error_message nvarchar(200)
)
LANGUAGE SQLSCRIPT AS

BEGIN 

	IF :transaction_type = 'A' THEN		
		UPDATE OPOR SET "U_EXX_INDO_ESTADO" =  (CASE WHEN "CardCode" in (Select "U_EXX_INDO_PROV" FROM "@EXX_INDO_BASE") THEN 'PE' ELSE 'NA' END)
		WHERE "DocEntry" = :docEntry;
	END IF;
END;