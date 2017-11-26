
			select * from tblHashTag h where h.HashtagName Not in (select b.BlockKeywords from tblBlockTag b) order by Counter desc

		

		Go



Delete from tblHashTag  where HashtagName  like '+'(select b.BlockKeywords from tblBlockTag b)'+'



select * from tblhashtag
order by Counter desc


select COUNT(*) as css,BlockKeywords from tblBlockTag

group by BlockKeywords 
order by COUNT(*) desc


select * from tblBlockTag
delete from tblBlockTag where BlockKeyID = 2


INSERT INTO [dbo].[tblBlockTag] (BlockKeywords) VALUES (N'‌است؟') 






select * from tblArchiveHashTags order by  RepCount desc

select * from tblHashTag order by Priority desc

