using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteProject
{
    public class SqLiteSampleProject
    {
        //Bağlantımızı Oluşturuyoruz. 
        //Creating Our Connections
       
       
         public static void createTable()
        {
          SQLiteConnection con = new SQLiteConnection("Data Source=SQLiteProject.sqlite; New=true; Version=3; PRAGMA cache_size=20000; PRAGMA page_size=32768; PRAGMA synchronous=off");

            //Create New Table in our Sqlite db
          string createTable = @" CREATE TABLE IF NOT EXISTS `personel` (`id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,`adi` TEXT NULL,`soyadi` TEXT NULL,`bolum_id` TEXT NULL,`sehir` TEXT NULL)";
            SQLiteCommand com = new SQLiteCommand(createTable, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

         public static void dropTable()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=SQLiteProject.sqlite; New=true; Version=3; PRAGMA cache_size=20000; PRAGMA page_size=32768; PRAGMA synchronous=off");
    
            //DropTable in our Sqlite db
            string dropTable = @" Drop TABLE IF EXISTS `personel`";
            SQLiteCommand com = new SQLiteCommand(dropTable, con);
             con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

         public static DataSet dgFill()
         {
             SQLiteConnection con = new SQLiteConnection("Data Source=SQLiteProject.sqlite; New=true; Version=3; PRAGMA cache_size=20000; PRAGMA page_size=32768; PRAGMA synchronous=off");

             //Fill Our Datagridview with our database table

             SQLiteCommand com = new SQLiteCommand(@"SELECT * FROM personel ORDER BY id", con);
             SQLiteDataAdapter da = new SQLiteDataAdapter(com);
             DataSet ds = new DataSet();
             da.Fill(ds);
             return ds;
         }
         

      
    }
}

        

