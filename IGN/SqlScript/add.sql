USE [DBEWDiGN]
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_tblNews]    Script Date: 11/12/2017 9:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_Add_tblNews]
	-- Add the parameters for the stored procedure here
  
    
            @Title nvarchar(500)
           ,@Description nvarchar(max)
           ,@PublishDate datetime
           ,@RegisterDate datetime
           ,@ImageUrl nvarchar(50)
           ,@ViewNumber bigint
           ,@Link nvarchar(900)
           ,@LanguageID int
           ,@RssID int
           ,@LikeCount int
           ,@Unlike int
           ,@Likes int,	@IsDeleted bit
		   ,@categoryID int
	AS
BEGIN
		    BEGIN TRANSACTION;
    SAVE TRANSACTION MySavePoint;
 
    BEGIN TRY




INSERT INTO [dbo].[tblNews]
           ([Title]
           ,[Description]
           ,[PublishDate]
           ,[RegisterDate]
           ,[ImageUrl]
           ,[ViewNumber]
           ,[Link]
           ,[LanguageID]
           ,[RssID]
           ,[LikeCount]
           ,[Unlike]
           ,[Likes],IsDeleted)
     VALUES
           (@Title
           ,@Description
           ,@PublishDate
           ,@RegisterDate
           ,@ImageUrl
           ,@ViewNumber
           ,@Link
           ,@LanguageID
           ,@RssID
           ,@LikeCount
           ,@Unlike
           ,@Likes	,@IsDeleted)




		   --'asdjklh asdnbasjd ad djshda dsajhdas dasdh'
		   
		   --@Title = 'asdjklh asdnbasjd ad djshda dsajhdas dasdh';

DECLARE @String NVARCHAR(500) = N'' + @Title +''
DECLARE @Delimiter CHAR(1) =' '

 CREATE TABLE #TempTable(
 HashtagName NVARCHAR(500))

 INSERT INTO #TempTable ( HashtagName) 
SELECT  *
FROM STRING_SPLIT(@String,@Delimiter)
   

declare @htagname nvarchar(50)
DECLARE contact_cursor CURSOR FOR  
SELECT HashtagName from #TempTable 

OPEN contact_cursor;  

-- Perform the first fetch.  
FETCH NEXT FROM contact_cursor  
INTO @htagname;  
-- Check @@FETCH_STATUS to see if there are any more rows to fetch.  
WHILE @@FETCH_STATUS = 0  
BEGIN  

	exec sp_UpdateOrAdd_tblHashTag @htagname,1
	
   -- This is executed as long as the previous fetch succeeds.  
   FETCH NEXT FROM contact_cursor
   INTO @htagname;  
END  

CLOSE contact_cursor;  
DEALLOCATE contact_cursor;  

drop table #TempTable

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION MySavePoint; -- rollback to MySavePoint
        END
    END CATCH
    COMMIT TRANSACTION 

END



