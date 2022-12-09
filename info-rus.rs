#simple adding songs into database like SQL back.

use runsql::{Connection};
struct song_dbs
{
fn add_song_(song_name : string, time_str : string);
}

impl song_dbs
{
  fn add_song_(song_name : string, time_str :string)
  {
     let cn = Connection::open("songs_history.db");
     let query = "insert into played (Song, Listening) values("+song_name+","+time_str+")";
     cn.execute(query);
  }
}

let sng_db = song_dbs{};
sng_dbs.add_song_("Bezos I Bo Burnham", "00:07"); 

#e.g
fn add_dat(query : string)
{
    let db = Connection::open("only_.db");
    if query !=""
    {
        db.execute(query);
  }
}

add_dat("insert into org (name, type) values('Pranav', 'Good and deserving person')");
    
      
