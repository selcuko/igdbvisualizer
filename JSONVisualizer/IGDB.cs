using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JSONVisualizer
{
    class IGDB
    {
        
        public List<string> GetMessagesByName(string personName)
        {
            string rawJson = File.ReadAllText(MainForm.messagesPath);
            Messages msgs = JsonConvert.DeserializeObject<Messages>(rawJson);
            var result = from participant in msgs.participants where msgs.participants.Contains(personName) select participant;
            return null;
        }
        public Messages GetConversationByName(string personName)
        {
            string jsonValue = File.ReadAllText(MainForm.messagesPath);
            Messages[] messages = JsonConvert.DeserializeObject<Messages[]>(jsonValue);
            foreach(Messages msg in messages)
            {
                if (msg.participants.Contains(personName)) { return msg; }
            }
            return null;
        }
        public Profile GetProfile()
        {
            string jsonValue = File.ReadAllText(MainForm.profilePath);
            return JsonConvert.DeserializeObject<Profile>(jsonValue);
        }
        public Contacts[] GetContacts()
        {
            string jsonValue = File.ReadAllText(MainForm.contactsPath);
            Contacts[] cont = JsonConvert.DeserializeObject<Contacts[]>(jsonValue);
            return cont;
        }
        public List<string> GetConversationNames(string personName)
        {
            List<string> names = new List<string>();
            string jsonValue = File.ReadAllText(MainForm.messagesPath);
            Messages[] messages = JsonConvert.DeserializeObject<Messages[]>(jsonValue);
            foreach(Messages msg in messages)
            {
                foreach(string participant in msg.participants) { names.Add(participant); }
            }
            names.RemoveAll(str => str == personName);
            return names;
        }
    }
    


}
