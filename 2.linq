<Query Kind="Statements">
  <Connection>
    <ID>e6b9389a-4ba4-474e-bab3-1d67b7f2ced9</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new 
			  {
			   
			   TracksCount = g.Tracks.Count(),
			   Tracks=from t in g.Tracks
			          select new {
					   TrackName = t.Name,
					   AlbumName = t.Album.Title,
					   Milliseconds = t. Milliseconds,
					   Size = (t.Bytes/1000)+"kb",
					   Price = t.UnitPrice
					  }
			  };
			  results.Dump("Query Math 2");