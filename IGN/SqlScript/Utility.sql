	select * from tblNews n
	--where n.RssID = 22
	order by n.NewsID desc 


select * from tblNews n
--where n.RssID = 22
order by n.PublishDate  



   select * from tblRss rs
      where rs.RssID
	Not in( SELECT DISTINCT  n.RssID FROM tblNews n) 

	select * from tblRss where RssTypeID = 4
	


	exec GetAllNews 1


	update tblRss
	set RssTypeID = 4
	where RssID = 172

select top 15 *,(select CategoryName from tblCategories c where c.CategoryID = 1 )as CID from tblNews n  where n.RssID in ( select RssID from tblRss where CategoryID = 1 ) 
	order by n.PublishDate desc

select top 10 * from tblNews n where n.RssID in ( select RssID from tblRss where CategoryID = 2) 
	order by n.NewsID desc


select top 10 * from tblNews n where n.RssID in ( select RssID from tblRss where CategoryID = 3 ) 
	order by n.PublishDate,n.RegisterDate desc



	
DECLARE @LoopCounter INT = 1, @MaxEmployeeId INT = 18 , 
        @EmployeeName NVARCHAR(100)
 
WHILE(@LoopCounter <= @MaxEmployeeId)
BEGIN
 	select top 15 *,(select CategoryID from tblCategories c where c.CategoryID = @LoopCounter )as CID,(select CategoryName from tblCategories c where c.CategoryID = @LoopCounter )as CName from tblNews n  where n.RssID in ( select RssID from tblRss where CategoryID = @LoopCounter ) 
	order by n.PublishDate desc

   SET @LoopCounter  = @LoopCounter  + 1        
END







GO
Begin
		DECLARE @LoopCounter INT = 1, @MaxEmployeeId INT = 1000 , 
		        @EmployeeName NVARCHAR(100)
		 
		WHILE(@LoopCounter <= @MaxEmployeeId)
		BEGIN
		
		Declare @NewsKey 
		select @Newskey  = select n.Title from tblNews n where n.NewsID = @LoopCounter
		



		exec SplitString 











		   SET @LoopCounter  = @LoopCounter  + 1        
		END
END