<Query Kind="Statements">
  <Connection>
    <ID>22025cc2-b757-461a-9d09-8536010a874c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from x in Artists
             where  x.ArtistId==1
			 orderby x.Name
			 select new {
			 Artist =x.Name,
			 Albums= from b in x.Albums
			         orderby b.Title
					 select new 
					 {
					  Title = b.Title,
					  Tracks = from tr in b.Tracks
					          select new 
					         	{
								 TrackName =tr.Name,
								 GenreId=tr.GenreId,
								 Composer=tr.Composer,
								 Milliseconds=tr.Milliseconds
								 
						        }
					 }
			 };
			 results.Dump();