using RPG_Assistant.Model;
using RPG_Assistant.ViewModel;
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
    public class CharacterDatabase: ViewModelBase
    {
        static SQLiteAsyncConnection characterDB;

        public List<Character> Characters { get; internal set; }

        public static async Task Init()
        {
            if (characterDB != null)
                return;
            string databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "CharactersDatabase.db3");
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

        public static async Task<List<Character>> SelectCharacter()
        {
            await Init();
            var character = await characterDB.Table<Character>().ToListAsync();
            return character;
        }

    }
}
