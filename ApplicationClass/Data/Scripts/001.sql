IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User_Insert]') AND type in (N'P', N'PC'))
BEGIN
    -- Create the stored procedure
    EXEC('
    CREATE PROCEDURE [dbo].[User_Insert]
        @UserName NVARCHAR(255),
        @FirstName NVARCHAR(255),
        @LastName NVARCHAR(255),
        @Password NVARCHAR(255),
        @IsActive BIT,
        @LastUpdatedUser INT
    AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [User]  
        (
            UserName,
            FirstName,
            LastName,
            Password,
            IsActive,
            LastUpdatedUser
        )
        VALUES
        (
            @UserName,
            @FirstName,
            @LastName,
            @Password,
            @IsActive,
            @LastUpdatedUser
        );

        SELECT SCOPE_IDENTITY(); 
    END;'
    );
END
ELSE
BEGIN
    -- Alter the existing stored procedure
    EXEC('
    ALTER PROCEDURE [dbo].[User_Insert]
        @UserName NVARCHAR(255),
        @FirstName NVARCHAR(255),
        @LastName NVARCHAR(255),
        @Password NVARCHAR(255),
        @IsActive BIT,
        @LastUpdatedUser INT
    AS
    BEGIN
        SET NOCOUNT ON;

        INSERT INTO [User]  
        (
            UserName,
            FirstName,
            LastName,
            Password,
            IsActive,
            LastUpdatedUser
        )
        VALUES
        (
            @UserName,
            @FirstName,
            @LastName,
            @Password,
            @IsActive,
            @LastUpdatedUser
        );

        SELECT SCOPE_IDENTITY(); 
    END;'
    );
END
