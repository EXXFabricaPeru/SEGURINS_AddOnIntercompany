ALTER PROCEDURE SBO_SP_PostTransactionNotice
(
	in object_type nvarchar(20), 				-- SBO Object Type
	in transaction_type nchar(1),			-- [A"dd, [U"pdate, [D"elete, [C"ancel, C[L"ose
	in num_of_cols_in_key int,
	in list_of_key_cols_tab_del nvarchar(255),
	in list_of_cols_val_tab_del nvarchar(255)
)
LANGUAGE SQLSCRIPT
AS


--Agregar este fragmento de código en el PostTransactionNotification
IF :object_type = '17' and :transaction_type = 'A' and (:error =0) THEN
	CALL "SBO_EXX_INDO_PTN_OBJ017_ORDR" (:list_of_cols_val_tab_del, :transaction_type, :error, :error_message);
END IF;

IF :object_type = '22' and :transaction_type = 'A'  and (:error =0) THEN
	CALL "SBO_EXX_INDO_PTN_OBJ020_OPOR" (:list_of_cols_val_tab_del, :transaction_type, :error, :error_message);
END IF;

END;