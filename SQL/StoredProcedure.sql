CREATE PROC USP_ModifyPassword
@IDAccount INT, @Password NVARCHAR(1000)
AS
BEGIN
	UPDATE Account
	SET Password = @Password
	WHERE IDAccount = @IDAccount
END
GO

CREATE PROC USP_GetStatus
@Username NVARCHAR(50), @Username NVARCHAR(50)
AS
BEGIN
	SELECT Status FROM Staff S
	INNER JOIN Account A ON S.IDStaff = A.IDStaff
	WHERE A.Username = @Username AND A.Password = @Username
END

GO

CREATE PROC USP_InsertAccount
@ID INT, @Username NVARCHAR(50), @Password NVARCHAR(50)
AS
BEGIN
	INSERT INTO Account(IDStaff, Username, Password)
	VALUES (@ID, @Username, @Password)
END