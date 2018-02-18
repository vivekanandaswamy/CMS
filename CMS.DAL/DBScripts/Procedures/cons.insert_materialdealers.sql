CREATE PROCEDURE cons.insert_materialdealers
(
	@typeOfMaterialId int,
	@mname varchar(30),
	@address varchar(max),
	@mobnum varchar(15),
	@comments varchar(max)
)
AS
BEGIN
	INSERT INTO cons.MaterialDealers (tmid,name,address,mobile,comments) VALUES(@typeOfMaterialId,@mname,@address,@mobnum,@comments)
END