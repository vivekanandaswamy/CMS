CREATE PROCEDURE cons.insert_material
(
	@name varchar(30),
	@comments varchar(max)
)
AS
BEGIN
	INSERT INTO [ConstructionDB].[cons].[Material] (mname,comments) VALUES(@name,@comments)
END
