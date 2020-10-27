USE [master]
GO

DROP DATABASE IF EXISTS [SecurePasswordDemoDB]
GO

CREATE DATABASE [SecurePasswordDemoDB]
GO

USE [SecurePasswordDemoDB]
GO

DROP TABLE IF EXISTS [User]
GO

CREATE TABLE [User] (
[UserId] INT NOT NULL IDENTITY(1,1),
[FirstName] VARCHAR(255) NOT NULL,
[LastName] VARCHAR(255) NOT NULL,
[UserName] VARCHAR(64) NOT NULL,
[Secret] VARCHAR(1000) NOT NULL,
[Peppers] VARCHAR(1000) NOT NULL,
[LogInAttempts] INT NOT NULL DEFAULT 0,
[AccountLocked] BIT NOT NULL DEFAULT 0
)
GO

ALTER TABLE [User]
ADD	PRIMARY KEY ([UserId])
GO

DROP PROCEDURE IF EXISTS [proc_createuser]
GO

CREATE PROCEDURE [proc_createuser] (
	@firstName VARCHAR(255),
	@lastName VARCHAR(255),
	@userName VARCHAR(64),
	@secret VARCHAR(1000),
	@peppers VARCHAR(1000))
AS

BEGIN TRAN CreateUser;
	INSERT INTO [User] (FirstName, LastName, UserName, [Secret], Peppers)
	VALUES (@firstName, @lastName, @userName, @secret, @peppers)
COMMIT TRAN CreateUser;

GO

DROP PROCEDURE IF EXISTS [proc_verifyuserlogin]
GO

CREATE PROCEDURE [proc_verifyuserlogin] (
	@userName VARCHAR(64),
	@secret VARCHAR(1000),
	@isVerified BIT OUTPUT)
AS

BEGIN TRAN VerifyUser;
	SET @isVerified = 0;

	IF EXISTS (SELECT * FROM [User] WHERE [User].[Secret] = @secret)
		BEGIN
			SET @isVerified = 1;
			UPDATE [User]
				SET [LogInAttempts] = 0
			WHERE [User].[UserName] = @userName
		END
	ELSE
		BEGIN
			SET @isVerified = 0;
			UPDATE [User]
				SET [LogInAttempts] = (SELECT [LogInAttempts]) +1
				WHERE [User].[UserName] = @userName
			
		END

COMMIT TRAN VerifyUser;
GO

CREATE PROCEDURE [proc_getusersalt] (
	@userName VARCHAR(64)
)
AS
	SELECT [User].[Peppers] FROM [User] WHERE [User].[UserName] = @userName
GO

CREATE PROCEDURE [proc_getloginattempts] (
	@userName VARCHAR(64)
)
AS
	SELECT [User].[LogInAttempts] FROM [User] WHERE [User].[UserName] = @userName
GO

CREATE PROCEDURE [proc_lockaccount] (
	@userName VARCHAR(64)
)
AS
BEGIN TRAN LockAccount;
	UPDATE [User]
		SET [AccountLocked] = 1
	WHERE
		[User].[UserName] = @userName
COMMIT TRAN LockAccount;