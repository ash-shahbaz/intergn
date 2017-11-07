select * from tblNews n
--where n.RssID = 22
order by n.NewsID desc 





   select * from tblRss rs
      where rs.RssID
	Not in( SELECT DISTINCT  n.RssID FROM tblNews n) 





	exec GetAllRssCategory