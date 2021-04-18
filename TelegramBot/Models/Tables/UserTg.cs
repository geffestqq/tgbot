using System;
using System.Collections.Generic;

#nullable disable

namespace TelegramBot.Models.Tables
{
    public partial class UserTg
    {
        public UserTg()
        {
            Histories = new HashSet<History>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public int Chatid { get; set; }
        public DateTime Createdate { get; set; }
        public string Event { get; set; }
        public int Numbermessage { get; set; }
        public int TaskId { get; set; }

        public virtual Task Task { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual ICollection<History> Histories { get; set; }
    }
}
