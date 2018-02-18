CREATE PROCEDURE cons.insert_typeofmaterial
(
	@materialid int,
	@typeOfMaterial varchar(max),
	@comments varchar(max)
)
AS
BEGIN
	INSERT INTO cons.Typeofmaterial (mid,tmname,comments) VALUES(@materialid,@typeOfMaterial,@comments)
END