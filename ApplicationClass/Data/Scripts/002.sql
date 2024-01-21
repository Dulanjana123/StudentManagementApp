USE [StudentManagement]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User_Get_ByUserName]') AND type in (N'P', N'PC'))
BEGIN
    -- Create the stored procedure
    DECLARE @CreateProcedureScript NVARCHAR(MAX)
    SET @CreateProcedureScript = '
   

    CREATE PROCEDURE [dbo].[User_Get_ByUserName]
        @UserName VARCHAR(10)
    AS
    BEGIN
        SET NOCOUNT ON;

        SELECT *
        FROM [User]  
        WHERE UserName = @UserName;
    END;'
    EXEC sp_executesql @CreateProcedureScript;
END
ELSE
BEGIN
    -- Alter the existing stored procedure
    DECLARE @AlterProcedureScript NVARCHAR(MAX)
    SET @AlterProcedureScript = '
    

    ALTER PROCEDURE [dbo].[User_Get_ByUserName]
        @UserName VARCHAR(10)
    AS
    BEGIN
        SET NOCOUNT ON;

        SELECT *
        FROM [User]  
        WHERE UserName = @UserName;
    END;'
    EXEC sp_executesql @AlterProcedureScript;
END
