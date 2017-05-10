<Query Kind="Statements">
  <Connection>
    <ID>e6b9389a-4ba4-474e-bab3-1d67b7f2ced9</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new 
			  {
			   Genre=g.Name,
			   TracksCount = g.Tracks.Count()
			  };
			  results.Dump("Query Math 1");