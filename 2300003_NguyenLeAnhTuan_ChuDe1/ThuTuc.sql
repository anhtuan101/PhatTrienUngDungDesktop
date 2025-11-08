----------------------------------------------
--Thủ tục GetAll dùng chung
create proc GetAll
(
    @TableName nvarchar(200)
)
as
begin
    set nocount on
    declare @sql nvarchar(1000)
    set @sql = 'select * from ' + @TableName
    exec (@sql)
end
drop proc GetAll
exec GetAll 'Ban'
go

----------------------------------------------
--Thủ tục GetByID dùng chung
create proc GetByID
(
    @TableName nvarchar(200),  
    @id int                     
)
as
begin
    set nocount on
    declare @sql nvarchar(1000);

    set @sql = 'select * from ' + @TableName + ' where ID = ' + cast(@id as nvarchar);

    exec (@sql);
end;
exec GetByID 'Ban', @id = 1
drop proc GetByID
go

----------------------------------------------
--Thủ tục DeleteByID dùng chung
create proc DeleteByID
(
    @TableName nvarchar(200),  
    @id int                     
)
as
begin
    set nocount on
    declare @sql nvarchar(1000);

    if @TableName = N'Ban'
    begin
        if exists (select * from Bills where TableID = @id)
        begin
            print N'Tồn tại ID bàn trong bảng Bills'
            return;
        end
    end
    else if @TableName = N'Bills'
    begin
        if exists (select * from BillDetails where InvoiceID = @id)
        begin
            print N'Tồn tại ID bill trong bảng BillDetails'
            return;
        end
    end
    else if @TableName = N'Category'
    begin
        if exists (select * from Food where FoodCategoryID = @id)
        begin
            print N'Tồn tại ID category trong bảng Food'
            return;
        end
    end
    else if @TableName = N'Food'
    begin
        if exists (select * from BillDetails where FoodID = @id)
        begin
            print N'Tồn tại ID Food trong bảng BillDetails'
            return;
        end
    end
    else if @TableName = N'Rolee'
    begin
        if exists (select * from RoleAccount where RoleID = @id)
        begin
            print N'Tồn tại ID Role trong bảng RoleAccount'
            return;
        end
    end
    if @TableName = N'Account' or @TableName = N'RoleAccount'
    begin
        print N'Không có ID tăng tự động.'
        return;
    end

    set @sql = 'delete from ' + @TableName + ' where ID = ' + cast(@id as nvarchar);

    exec (@sql);
end;
exec DeleteByID 'Ban', @id = 3
select * from Bills
select * from Ban
drop proc DeleteByID
go

-----------------------------------------------------------------------------------------------------------------------------------
--TABLE INSERT
--Ban
create PROCEDURE Ban_Insert
(
    @id int output, @Name NVARCHAR(50), @Status INT, @Capacity INT                   
)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Ban WHERE Name = @Name)
    begin
        INSERT INTO Ban(Name, Status, Capacity)
        VALUES (@Name, @Status, @Capacity)

        SET @ID = @@IDENTITY
    end
    else
    begin
        RAISERROR(N'Da ton tai ten ban.', 16, 1)
        RETURN;
    end
END

DECLARE @ID INT = 0;
EXEC Ban_Insert @ID = @ID OUTPUT, @Name = N'Table 6', @Status = 1, @Capacity = 10;

DROP PROC Ban_Insert
SELECT * FROM Ban
GO
------------------------------------------------------------------------------------------------
--Bills
create PROCEDURE Bills_Insert
(
    @id int output, @Name nvarchar(1000), @tableid int, @amount int, 
    @discount float = NULL, @tax float = NULL, @status bit, @codate smalldatetime, @account nvarchar(1000)                 
)
AS
BEGIN
    IF EXISTS (SELECT * FROM Ban WHERE ID = @tableid)
    begin
        INSERT INTO Bills(Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account)
        VALUES (@Name, @tableid, @amount, @discount, @tax, @status, @codate, @account)

        SET @ID = @@IDENTITY
    end
    else
    begin
        RAISERROR(N'Khong ton tai ID ban.', 16, 1)
        RETURN;
    end
END
--Goi thu tuc
DECLARE @ID INT = 0;
EXEC Bills_Insert @ID = @ID OUTPUT, @name = N'Minh', @tableid = 1, @amount = 5, @status = 1, @codate = '2025-08-25', @account = 'ha'
--Xoa va goi bang
DROP PROC Bills_Insert
SELECT * FROM Bills
GO
------------------------------------------------------------------------------------------------
--Category
create PROCEDURE Category_Insert
(
    @ID INT OUTPUT,            
    @Name NVARCHAR(1000),      
    @Type INT                   
)
AS
BEGIN
    IF NOT EXISTS (SELECT Name FROM Category WHERE Name = @Name)
        INSERT INTO Category (Name, Type)
        VALUES (@Name, @Type)

        SET @ID = @@IDENTITY
END
--GOI THU TUC
DECLARE @ID INT = 0;
EXEC dbo.Category_Insert @ID = @ID OUTPUT, @Name = N'Trái cây', @Type = 6
--XOA THU TUC VA GOI BANG
SELECT * FROM Category
drop proc Category_Insert
go
------------------------------------------------------------------------------------------------
--Food
create PROCEDURE Food_Insert
(
    @id int output,            
    @name nvarchar(1000), @unit nvarchar(100), @fcid int,      
    @price INT, @notes nvarchar(3000) = NULL                   
)
AS
BEGIN
    IF EXISTS (SELECT * FROM Category WHERE ID = @fcid)
    begin
        INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)
        VALUES (@name, @unit, @fcid, @price, @notes)

        SET @ID = @@IDENTITY
    end
    else
    begin
        raiserror(N'Khong ton tai category id', 16, 1)
        return;
    end
END
--GOI THU TUC
DECLARE @ID INT = 0;
EXEC Food_Insert @ID = @ID OUTPUT, @Name = N'pepsi', @unit = N'lon', @fcid = 4, @price = 15000, @notes = N'Ngon hon khi uong voi da.'
EXEC Food_Insert @ID = @ID OUTPUT, @Name = N'pepsi', @unit = N'lon', @fcid = 10, @price = 15000, @notes = N'Ngon hon khi uong voi da.'
--XOA THU TUC VA GOI BANG
SELECT * FROM Food
drop proc Food_Insert
go
------------------------------------------------------------------------------------------------
--BillDetails
create PROCEDURE BillDetails_Insert
(
    @id int output,            
    @invoiceid int, @foodid int, @quantity int                
)
as
begin
    if exists (select * from Bills where ID = @invoiceid)
    begin
        if exists (select * from Food where ID = @foodid)
        begin
            insert into BillDetails(InvoiceID, FoodID, Quantity)
            values (@invoiceid, @foodid, @quantity)

            SET @ID = @@IDENTITY
        end
        else
        begin
            raiserror(N'Khong ton tai food id', 16, 1)
            return;
        end 
    end
    else
    begin
        raiserror(N'Khong ton tai bill id', 16, 1)
        return;
    end
end
--GOI THU TUC
DECLARE @ID INT = 0;
EXEC BillDetails_Insert @ID = @ID OUTPUT, @invoiceid = 3, @foodid = 5, @quantity = 4
--XOA THU TUC VA GOI BANG
SELECT * FROM BillDetails
select * from Bills
select * from Food
drop proc BillDetails_Insert
go
------------------------------------------------------------------------------------------------
--Account
create PROCEDURE Account_Insert
(
    @name nvarchar(100), @password nvarchar(200), @fullname nvarchar(1000),
    @email nvarchar(1000) = NULL, @tell nvarchar(200) = NULL, @datecreated smalldatetime = NULL
)
as
begin
    if not exists (select * from Account where AccountName = @name)
    begin
        insert into Account(AccountName, Password, FullName, Email, Tell, DateCreated)
        values (@name, @password, @fullname, @email, @tell, @datecreated)
    end
    else
    begin
        raiserror(N'Da ton tai account name.', 16, 1)
        return;
    end
end
--GOI THU TUC
EXEC Account_Insert @name = N'Tuấn', @password = N'Tuan123', @fullname = N'Nguyễn Lê Anh Tuấn', @email = N'Tuan@gmail.com'
--XOA THU TUC VA GOI BANG
select * from Account
drop proc Account_Insert
go
------------------------------------------------------------------------------------------------
--BillDetails
create PROCEDURE Rolee_Insert
(
    @id int output,            
    @rname nvarchar(1000), @path nvarchar(3000) = NULL, 
    @notes nvarchar(3000) = NULL               
)
as
begin
    if not exists (select * from Rolee where RoleName = @rname)
    begin
        insert into Rolee(RoleName, Path, Notes)
        values (@rname, @path, @notes)

        SET @id = @@IDENTITY
    end
    else
    begin
        raiserror(N'Da ton tai ten role.', 16, 1)
        return;
    end
end
--GOI THU TUC
DECLARE @id int = 0
EXEC Rolee_Insert @id = @ID OUTPUT, @rname = N'Order', @path = N'v', @notes = N'Gọi món'
--XOA THU TUC VA GOI BANG
select * from Rolee
drop proc Rolee_Insert
go
------------------------------------------------------------------------------------------------
--RoleAccount
create PROCEDURE RoleAccount_Insert
(
    @roleid int, @aname nvarchar(100), @actived bit, @notes nvarchar(3000) = NULL               
)
as
begin
    if exists (select * from Rolee where ID = @roleid)
    begin
        if exists (select * from Account where AccountName = @aname)
        begin
            insert into RoleAccount(RoleID, AccountName, Actived, Notes)
            values (@roleid, @aname, @actived, @notes)
        end
        else
        begin
            raiserror(N'Khong ton tai ten account', 16, 1)
            return;
        end 
    end
    else
    begin
        raiserror(N'Khong ton tai role id', 16, 1)
        return;
    end
end
--GOI THU TUC
EXEC RoleAccount_Insert @roleid = 4, @aname = N'Tuấn', @actived = 1
--XOA THU TUC VA GOI BANG
select * from RoleAccount
select * from Rolee
select * from Account
drop proc RoleAccount_Insert
go


-----------------------------------------------------------------------------------------------------------------------------------
--TABLE UPDATE
--BAN
CREATE PROCEDURE Ban_Update
    @ID INT,
    @Name NVARCHAR(1000) = NULL,
    @Status INT,
    @Capacity INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Ban
    SET Name = @Name, Status = @Status, Capacity = @Capacity
    WHERE ID = @ID;
END
exec Ban_Update @ID = 5, @Name = N'Table 5', @Status = 0, @Capacity = 15
select * from Ban
drop proc Ban_Update
GO
------------------------------------------------------------------------------------------------
--BILLS
CREATE PROCEDURE Bills_Update
    @ID INT, @Name NVARCHAR(1000), @TableID INT, @Amount INT, @Discount FLOAT = NULL,
    @Tax FLOAT = NULL, @Status BIT, @CheckoutDate SMALLDATETIME = NULL, @Account NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT * FROM Bills WHERE ID = @ID)
    BEGIN
        RAISERROR(N'ID kHONG TON TAI', 16, 1);
        RETURN;
    END;
    UPDATE Bills
    SET 
        Name = @Name, TableID = @TableID, Amount = @Amount, Discount = @Discount, Tax = @Tax,
        Status = @Status, CheckoutDate = @CheckoutDate, Account = @Account
    WHERE ID = @ID;
END
EXEC Bills_Update @ID = 4, @name = N'Minh', @tableid = 1, @amount = 5, @Tax = 20, @status = 1, @CheckoutDate = '2025-08-25', @account = 'H'
select * from Bills
drop proc Bills_Update
GO
------------------------------------------------------------------------------------------------
--CATEGORY
CREATE PROCEDURE Category_Update
    @ID INT, @Name NVARCHAR(1000), @Type INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Category
    SET 
        Name = @Name, Type = @Type
    WHERE ID = @ID;
END
exec Category_Update @ID = 4, @Name = N'Đồ uống', @Type = 4
select * from Category
drop proc Category_Update
GO
------------------------------------------------------------------------------------------------
--FOOD
CREATE PROCEDURE Food_Update
    @ID INT, @Name NVARCHAR(1000), @Unit NVARCHAR(100),
    @FoodCategoryID INT, @Price INT, @Notes NVARCHAR(3000) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Category WHERE ID = @FoodCategoryID)
    BEGIN
        RAISERROR(N'Category ID không tồn tại', 16, 1);
        RETURN;
    END
    UPDATE Food
    SET 
        Name = @Name, Unit = @Unit, FoodCategoryID = @FoodCategoryID,
        Price = @Price, Notes = @Notes
    WHERE ID = @ID;
END
select * from Food
EXEC Food_Update @ID = 7, @Name = N'coca', @Unit = N'lon', @FoodCategoryID = 4, @Price = 15500, @Notes = N'Ngon hon khi uong voi da.'
drop proc Food_Update
GO
------------------------------------------------------------------------------------------------
--BILLDETAILS
CREATE PROCEDURE BillDetails_Update
    @ID INT, @InvoiceID INT, @FoodID INT, @Quantity INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Bills WHERE ID = @InvoiceID)
    BEGIN
        RAISERROR(N'InvoiceID không tồn tại', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT * FROM Food WHERE ID = @FoodID)
    BEGIN
        RAISERROR(N'FoodID không tồn tại', 16, 1);
        RETURN;
    END
    UPDATE BillDetails
    SET InvoiceID = @InvoiceID, FoodID = @FoodID, Quantity = @Quantity
    WHERE ID = @ID;
END
exec BillDetails_Update @ID = 1, @InvoiceID = 1, @FoodID = 1, @Quantity = 20
select * from BillDetails
drop proc BillDetails_Update
GO
------------------------------------------------------------------------------------------------
--ACCOUNT
CREATE PROCEDURE Account_Update
    @AccountName NVARCHAR(100), @Password NVARCHAR(200), @FullName NVARCHAR(1000),
    @Email NVARCHAR(1000) = NULL, @Tell NVARCHAR(200) = NULL, @DateCreated SMALLDATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Account WHERE AccountName = @AccountName)
    BEGIN
        RAISERROR(N'Tài khoản không tồn tại', 16, 1);
        RETURN;
    END
    UPDATE Account
    SET Password = @Password, FullName = @FullName, Email = @Email,
        Tell = @Tell, DateCreated = @DateCreated
    WHERE AccountName = @AccountName;
END
exec Account_Update @AccountName = N'Tuấn', @Password = N'Tuan123', @FullName = N'Nguyễn Lê Anh Tuấn', @Email = N'Tuan@gmail.com', @Tell = N'0845152447', @DateCreated = N'11/1/2021'
select * from Account
drop proc Account_Update
GO
------------------------------------------------------------------------------------------------
--ROLEE
CREATE PROCEDURE Rolee_Update
    @ID INT, @RoleName NVARCHAR(1000),
    @Path NVARCHAR(3000) = NULL,
    @Notes NVARCHAR(3000) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Rolee WHERE ID = @ID)
    BEGIN
        RAISERROR(N'Role ID không tồn tại', 16, 1);
        RETURN;
    END
    UPDATE Rolee
    SET RoleName = @RoleName, Path = @Path, Notes = @Notes
    WHERE ID = @ID;
END
exec Rolee_Update @ID = 1, @RoleName = N'Phục vụ', @Path = N'v', @Notes = N'Dọn bàn và bưng món'
select * from Rolee
drop proc Rolee_Update
GO
------------------------------------------------------------------------------------------------
--ROLEACCOUNT
CREATE PROCEDURE RoleAccount_Update
    @RoleID INT, @AccountName NVARCHAR(100),
    @IsActive BIT, @Notes NVARCHAR(3000) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Rolee WHERE ID = @RoleID)
    BEGIN
        RAISERROR(N'RoleID không tồn tại', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT * FROM Account WHERE AccountName = @AccountName)
    BEGIN
        RAISERROR(N'AccountName không tồn tại', 16, 1);
        RETURN;
    END
    UPDATE RoleAccount
    SET Actived = @IsActive, Notes = @Notes
    WHERE RoleID = @RoleID AND AccountName = @AccountName;
END
exec RoleAccount_Update @RoleID = 3, @AccountName = N'Minh', @IsActive = 0, @Notes = N'PartTime'
select * from RoleAccount
drop proc RoleAccount_Update
GO


-----------------------------------------------------------------------------------------------------------------------------------
--TABLE DELETE
--BAN
CREATE PROCEDURE Ban_Delete
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Ban WHERE ID = @ID)
    BEGIN
        RAISERROR(N'ID không tồn tại!', 16, 1)
        RETURN;
    END;
    if exists (select * from Bills where TableID = @ID)
    begin
        print N'Không thể xóa vì tồn tại ID table trong bảng Bills'
        return;
    end
    DELETE FROM Ban
    WHERE ID = @ID
END
DROP PROC Ban_Delete
EXEC Ban_Delete @ID = 6
SELECT * FROM Ban
GO
------------------------------------------------------------------------------------------------
--BILLS
CREATE PROCEDURE Bills_Delete
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT * FROM Bills WHERE ID = @ID)
    BEGIN
        PRINT N'Không tìm thấy hóa đơn ID'
        return;
    END
    IF EXISTS (SELECT * FROM BillDetails WHERE InvoiceID = @ID)
    BEGIN
        PRINT N'Không thể xóa vì tồn tại ID invoice trong bảng BillDetails'
        return;
    END
    DELETE FROM Bills
        WHERE ID = @ID;
END;
exec Bills_Delete @ID = 2
DROP PROC Bills_Delete
select * from BillDetails
SELECT * FROM Bills
GO
------------------------------------------------------------------------------------------------
--CATEGORY
CREATE PROCEDURE Category_Delete
(
    @ID INT
)
AS
BEGIN
    set nocount on
    if exists (select * from Food where ID = @ID)
    begin
        print N'Không thể xóa vì tồn tại ID Category trong bảng Food'
        return;
    end
    DELETE FROM Category
    WHERE ID = @ID
END
exec Category_Delete @ID = 4
DROP PROC Category_Delete
select * from Food
SELECT * FROM Category
GO
------------------------------------------------------------------------------------------------
--FOOD
CREATE PROCEDURE Food_Delete
(
    @ID INT
)
AS
BEGIN
    set nocount on
    if exists (select * from BillDetails where FoodID = @ID)
    begin
        print N'Không thể xóa vì tồn tại ID Food trong bảng BillDetails'
        return;
    end
    DELETE FROM Food
    WHERE ID = @ID
END
DROP PROC Food_Delete
SELECT * FROM Food
GO
------------------------------------------------------------------------------------------------
--BILLDETAILS
CREATE PROCEDURE BillDetails_Delete
(
    @IDivc INT, @IDfd INT
)
AS
BEGIN
    set nocount on
    if exists (select * from BillDetails where InvoiceID = @IDivc and FoodID = @IDfd)
    begin
        DELETE FROM BillDetails
        WHERE InvoiceID = @IDivc and FoodID = @IDfd
    end
    else
    begin
        print N'Không tìm thấy InvoiceID và FoodID trong bảng BillDetails'
        return;
    end
END
exec BillDetails_Delete @IDivc = 3, @IDfd = 5
DROP PROC BillDetails_Delete
SELECT * FROM BillDetails
GO
------------------------------------------------------------------------------------------------
--ACCOUNT
CREATE PROCEDURE Account_Delete
(
    @Name nvarchar(100)
)
AS
BEGIN
    set nocount on
    if exists (select * from RoleAccount where AccountName = @Name)
    begin
        print N'Không thể xóa vì tồn tại Name Account trong bảng RoleAccount'
        return;
    end
    DELETE FROM Account
    WHERE AccountName = @Name
END
exec Account_Delete @Name = N'Tuấn'
DROP PROC Account_Delete
SELECT * FROM RoleAccount
SELECT * FROM Account
GO
------------------------------------------------------------------------------------------------
--ROLEE
CREATE PROCEDURE Rolee_Delete
(
    @ID INT
)
AS
BEGIN
    set nocount on
    if exists (select * from RoleAccount where RoleID = @ID)
    begin
        print N'Không thể xóa vì tồn tại ID Role trong bảng RoleAccount'
        return;
    end
    DELETE FROM Rolee
    WHERE ID = @ID
END
exec Rolee_Delete @ID = 4
DROP PROC Rolee_Delete
SELECT * FROM Rolee
GO
------------------------------------------------------------------------------------------------
--ROLEACCOUNT
CREATE PROCEDURE RoleAccount_Delete
(
    @IDrl INT, @name nvarchar(100)
)
AS
BEGIN
    set nocount on
    if exists (select * from RoleAccount where RoleID = @IDrl and AccountName = @name)
    begin
        DELETE FROM RoleAccount
        WHERE RoleID = @IDrl and AccountName = @name
    end
    else
    begin
        print N'Không tìm thấy Role ID và Account Name'
        return;
    end
END
exec RoleAccount_Delete @IDrl = 4, @name = N'Tuấn'
DROP PROC Ban_Delete
SELECT * FROM RoleAccount
GO

--thủ tục để khi thêm quyền vào bảng Role thì tự động gán hết quyền cho các User (Insert vào bảng User Role, nhưng để Active = false)
CREATE PROCEDURE AddRoleWithAssign
    @RoleName NVARCHAR(100),
    @Path NVARCHAR(50) = NULL,
    @Notes NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NewRoleID INT;

    INSERT INTO Rolee(RoleName, Path, Notes)
    VALUES (@RoleName, @Path, @Notes);

    SET @NewRoleID = SCOPE_IDENTITY();

    INSERT INTO RoleAccount(RoleID, AccountName, Actived, Notes)
    SELECT @NewRoleID, u.AccountName, 0, NULL
    FROM (SELECT DISTINCT AccountName FROM RoleAccount) u;
END;
EXEC AddRoleWithAssign 
    @RoleName = N'Thu ngân',
    @Path = 'v',
    @Notes = N'Thu tiền và in hóa đơn';
drop proc AddRoleWithAssign
select * from Rolee
select * from RoleAccount
go



--------------------------------
select * from Account
select * from Ban
select * from BillDetails
select * from Bills
select * from Category
select * from Food
select * from Rolee
select * from RoleAccount
go