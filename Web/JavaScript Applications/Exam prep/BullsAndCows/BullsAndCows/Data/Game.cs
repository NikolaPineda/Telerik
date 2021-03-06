//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BullsAndCows.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public Game()
        {
            this.Guesses = new HashSet<Guess>();
            this.Messages = new HashSet<Message>();
        }
    
        public long Id { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public long RedUserNumber { get; set; }
        public Nullable<long> BlueUserNumber { get; set; }
        public Nullable<long> UserInTurn { get; set; }
        public long RedUserId { get; set; }
        public Nullable<long> BlueUserId { get; set; }
        public long GameStatusId { get; set; }
    
        public virtual GameStatus GameStatus { get; set; }
        public virtual User BlueUser { get; set; }
        public virtual User RedUser { get; set; }
        public virtual ICollection<Guess> Guesses { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
