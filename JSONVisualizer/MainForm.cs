using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JSONVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Profile curProfile;
        IGDB igdb = new IGDB();
        public static string sourceFolderPath;
        public static string checkoutPath, contactsPath, commentsPath, messagesPath, searchesPath, profilePath;


        private void cmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> data = new List<string>();
                Messages messages = igdb.GetConversationByName(cmbPerson.SelectedItem.ToString());
                foreach (Conversation str in messages.conversation)
                {
                    data.Add("[" + str.created_at + "] " + str.sender + ": " + str.text);
                }
                string[] something = data.ToArray();
                Array.Reverse(something);
                listMessages.DataSource = something;
            }
            catch { MessageBox.Show("Something happened. See the source code to solve it, dear dev.", "Err"); }
        }

        


        private void BtnLocate_Click(object sender, EventArgs e) {
            try
            {
                DialogResult dr = sourceFolderBrowser.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    sourceFolderPath = sourceFolderBrowser.SelectedPath;
                    messagesPath = sourceFolderPath + "\\messages.json";
                    searchesPath = sourceFolderPath + "\\searches.json";
                    contactsPath = sourceFolderPath + "\\contacts.json";
                    commentsPath = sourceFolderPath + "\\comments.json";
                    profilePath = sourceFolderPath + "\\profile.json";
                    checkoutPath = sourceFolderPath + "\\checkout.json";

                    curProfile = igdb.GetProfile();
                    string[] profileData = { curProfile.name, curProfile.username, curProfile.phone_number, curProfile.biography };
                    listUser.DataSource = profileData;

                    cmbPerson.DataSource = igdb.GetConversationNames(curProfile.username);

                    Contacts[] cont = igdb.GetContacts();
                    foreach (Contacts contact in cont) { listContacts.Items.Add(contact.first_name + " " + contact.last_name + ": " + contact.contact); }
                }
            }
            catch
            {
                MessageBox.Show("Something happened. See the source code to solve it, dear dev.", "Err");
            }
        }

    }


    
}
