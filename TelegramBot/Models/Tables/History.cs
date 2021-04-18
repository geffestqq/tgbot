using System;
using System.Collections.Generic;

#nullable disable

namespace TelegramBot.Models.Tables
{
    public partial class History
    {
        public int Id { get; set; }
        public string UserAction { get; set; }
        public DateTime DateAction { get; set; }
        public int UserId { get; set; }

        public virtual UserTg User { get; set; }
    }
}
