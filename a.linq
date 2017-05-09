<Query Kind="Statements">
  <Connection>
    <ID>22025cc2-b757-461a-9d09-8536010a874c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from x in Artists
             orderby x.Name
			 select new 
			 {
			  Id=x.ArtistId,
			  Name=x.Name
			 };
	results.Dump();