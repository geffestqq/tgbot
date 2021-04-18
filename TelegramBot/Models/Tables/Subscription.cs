using System;
using System.Collections.Generic;

#nullable disable

namespace TelegramBot.Models.Tables
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal PriceDay { get; set; }
        public decimal AccountAmount { get; set; }

        public virtual UserTg IdNavigation { get; set; }
    }
}
