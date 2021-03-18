using Newtonsoft.Json;
using RPG_Assistant.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RPG_Assistant.Databae
{
    public class CharactersData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CharacterAsJason { get; private set; }

        JsonSerializerSettings serializerSettings;

        public CharactersData() : this(null) { }

        public CharactersData(Character character)
        {
            serializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ObjectCreationHandling = ObjectCreationHandling.Replace
            };

            if (character != null)
                CharacterToJson(character);
        }

        public void CharacterToJson(Character character)
        {
            CharacterAsJason = JsonConvert.SerializeObject(character);
        }

        public Character GetCharacter()
        {
            try
            {
                var character = JsonConvert.DeserializeObject<Character>(CharacterAsJason, serializerSettings);
                character.Id = Id;
                return character;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                Debug.WriteLine(e.Source);
                Debug.WriteLine(e.Message);
                throw (e);
            }

        }
    }
}
