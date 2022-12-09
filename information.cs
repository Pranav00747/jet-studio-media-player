After playing  a you can add it into databases like NoSQL or SQL

private void add_song_inf(string song_name, string time_str)
{
     MongoClient mg = new MongoClient("conn_url");
     IMongoDatabase db = mg.GetDatabase("song_history");
     var cols = db.GetCollection<BsonDocument>("songs");
     BsonDocument doc = new BsonDocument{{"Song":song_name, "Listening Time":time_str}};
     cols.Insert_One(doc);
}
e.g
add_song_info(fdlg.GetText(), time_st.GetText());

#samples
public class sample_db
{
       public void add_it(BsonDocument doc)
       {
             MongoClient m_ = new MongoClient("..ip/url");
             IMongoDatabase db_ = m_.getDatabase("mydata");
             var info_c = db_.GetCollection<BsonDocument>("coll_");
             info_c.Inseet_One(doc);
       }
}

sample_db dbs = new sample_dbs();
dbs.add_it({"Name":"Pranav", "Level":"Expert > 9"});

