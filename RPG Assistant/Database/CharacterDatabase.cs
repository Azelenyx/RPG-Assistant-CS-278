using RPG_Assistant.Model;
using RPG_Assistant.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RPG_Assistant.Database
{
    //public class CharacterDatabase
    public class CharacterDatabase: ViewModelBase, ISearchable
    {
        static SQLiteAsyncConnection characterDB;
        public ICommand SearchCommand { get { return new Command<String>(Search); } }
        public ICommand DefaultSortCommand { get { return new Command(DefaultSort); } }

        //public List<Character> Characters { get; internal set; }
        List<Character> characters;
        public static async Task Init()
        {
            if (characterDB != null)
                return;
            string databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "CharactersDatabase.db3");
            characterDB = new SQLiteAsyncConnection(databasePath);

            await characterDB.CreateTableAsync<Character>();
        }

        public List<Character> Characters
        {
            get { return characters; }
            set
            {
                characters = value;
                OnPropertyChanged();
            }
        }

        public CharacterDatabase()
        {
            var task = Task.Run(async () =>
            {
                Characters = await SelectCharacter();
            });
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

        public void DefaultSort()
        {
            List<Character> result = Characters.OrderBy(x => x.level).ToList();
            Characters = result;
        }

        public void Search(string searchText)
        {
            searchText = searchText.ToLower();
            List<Character> result;
            if (searchText == null)
            {
                DefaultSort();
                return;
            }
            else
            {
                result = Characters.OrderByDescending(x => x.name.ToLower().Contains(searchText)).ToList();
            }
            Characters = result;
        }
    }
}
