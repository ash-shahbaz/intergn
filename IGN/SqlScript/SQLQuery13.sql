select  h.*,c.CategoryName from tblHashTag h inner join tblCategories c on h.CategoryID = c.CategoryID 
--where h.[Counter] >= 100 and h.[Counter] <= 600
 where h.HashtagName like N'%پراید%'
order by [Counter] desc


select distinct  HashtagName,[Counter] from tblHashTag
where  LEN(HashtagName) < 2
 order by [Counter] desc



 
select HashtagName,sum([Counter]) from tblHashTag
where  LEN(HashtagName) > 3
group by HashtagName,[Counter]
order by HashtagName ,[Counter]



select * from tblHashTag h



