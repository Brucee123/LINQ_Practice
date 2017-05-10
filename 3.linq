<Query Kind="Statements">
  <Connection>
    <ID>e6b9389a-4ba4-474e-bab3-1d67b7f2ced9</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new 
			  {
			    Name = m.Name,
				Tracks = from a in m.Tracks
				         select new 
						 {
						   
						   TrackName=a.Name,
						  
						   Album= a.Album.Title,
						   Aritist = a.Album.Artist.Name,
						   ReleaseYear=a.Album.ReleaseYear,
						   ReleaseLabel=a.Album.ReleaseLabel,
						   Genre = a.Genre.Name
						   
						   
						 }
			  };
results.Dump();