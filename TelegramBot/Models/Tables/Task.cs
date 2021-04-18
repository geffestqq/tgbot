using System;
using System.Collections.Generic;

#nullable disable

namespace TelegramBot.Models.Tables
{
    public partial class Task
    {
        public Task()
        {
            UserTgs = new HashSet<UserTg>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string UrlVideo { get; set; }

        public virtual ICollection<UserTg> UserTgs { get; set; }
    }
}
