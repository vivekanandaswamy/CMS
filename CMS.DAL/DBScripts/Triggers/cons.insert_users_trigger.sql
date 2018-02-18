select * from Customer order by cid asc
OFFSET 15 Rows
FETCH NEXT 5 ROWS ONLY


CREATE PROCEDURE sp_fetchRecords
(
	@pgno int,
	@rows int
)
AS
BEGIN
	select * from Customer order by cid asc
	OFFSET (@rows * (@pgno-1)) Rows
	FETCH NEXT @rows ROWS ONLY
END


exec sp_fetchRecords 6,5