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

public void add_it(BsonDocument doc)
{
MongoClient mg1 = new MongoClient("url");
IMongoDatabase db1 = mg1.GetDatabase("mydb");
var c1 = db1.GetCollection<BsonDocument>("list");
c1.InsertOne(doc);
}


add_it(new BsonDocument{{"Tag Name": "SWE vs Intern"}});
add_it(new BsonDocument{{"Dog Name":"Chotu Raj", " My House Made":"Manju", "Their Boss":"PCK"}});
add_it(new BsonDocument{{"My Cousin":"Best creative writer like normal graduates."});
add_it(new BsonDocument{{"Name":"Deo", "Domain": "Senior Data Scientist", "Role":"Friend"}});

