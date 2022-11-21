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
fn add_dat(qry : string)
{
     let cnc = Connection::open("list.db");
     cnc.excute(qry);
}
let mut query1 = "insert into mydb (TagName) values('SWE vs Intern')";
add_dat(query1); 

let mut query2 = "insert into mydb (DogName, MyHouseMade, TheirBoss) values('Chotu Raj', 'Manju', 'PCK')";
add_dat(query2); 

let mut query3 = "insert into mydb (MyCousin) values('Best creative writer like normal grduates')";
add_dat(query3); 

let mut query4 = "insert into mydb (Name, Domain, Role) values('Deo', 'Secnior Data Scientist', 'Friends')";
add_dat(query4); 
      
