using RPG_Assistant.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace RPG_Assistant.Database
{
    //public class CharacterDatabase
    public static class CharacterDatabase
    {
        static SQLiteAsyncConnection characterDB;

        /*       public CharacterDatabase(string dbPath)
               {
                   characterDB = new SQLiteAsyncConnection(dbPath);
                   characterDB.CreateTableAsync<CharactersData>().Wait();
               }*/

        //public static async Task Init()
        public static async Task Init()
        {
            if (characterDB != null)
                return;
            //static readonly string _databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "SqliteDatabase.db3");
            string databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "CharactersDatabase.db3");
            //var databasePath = Path.Combine(FileSystem.AppDataDirectory, "CharactersDatabase.db");
            characterDB = new SQLiteAsyncConnection(databasePath);

            await characterDB.CreateTableAsync<Character>();
        }

        public static async Task CreateCharacter(Character character)
        {
            await Init();
            var id = await characterDB.InsertAsync(character);
        }

        public static async Task DeleteCharacter(int id)
        {
            await Init();

            await characterDB.DeleteAsync<Character>(id);
        }

        public static async Task<IEnumerable<Character>> SelectCharacter()
        {
            await Init();
            var character = await characterDB.Table<Character>().ToListAsync();
            return character;
        }

    }
}
