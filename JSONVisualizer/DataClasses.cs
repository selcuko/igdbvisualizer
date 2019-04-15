using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#region Messages Class
public class Like
{

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("date")]
    public DateTime date { get; set; }
}

public class Conversation
{

    [JsonProperty("sender")]
    public string sender { get; set; }

    [JsonProperty("created_at")]
    public DateTime created_at { get; set; }

    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("media_url")]
    public string media_url { get; set; }

    [JsonProperty("story_share")]
    public string story_share { get; set; }

    [JsonProperty("mentioned_username")]
    public string mentioned_username { get; set; }

    [JsonProperty("media_owner")]
    public string media_owner { get; set; }

    [JsonProperty("media_share_caption")]
    public string media_share_caption { get; set; }

    [JsonProperty("media_share_url")]
    public string media_share_url { get; set; }

    [JsonProperty("media")]
    public string media { get; set; }

    [JsonProperty("heart")]
    public string heart { get; set; }

    [JsonProperty("likes")]
    public IList<Like> likes { get; set; }

    [JsonProperty("link")]
    public string link { get; set; }
}

public class Messages
{

    [JsonProperty("participants")]
    public IList<string> participants { get; set; }

    [JsonProperty("conversation")]
    public IList<Conversation> conversation { get; set; }
}


#endregion
#region Profile Class
public class Profile
{
    public string biography { get; set; }
    public DateTime date_joined { get; set; }
    public string website { get; set; }
    public string gender { get; set; }
    public bool private_account { get; set; }
    public string name { get; set; }
    public string phone_number { get; set; }
    public string profile_pic_url { get; set; }
    public string username { get; set; }
}

#endregion
#region Contacts Class
public class Contacts
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string contact { get; set; }
}

#endregion