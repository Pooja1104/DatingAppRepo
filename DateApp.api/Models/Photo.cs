using System;

namespace DateApp.api.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

        public User user{get;set;}//added for relation
        public int UserId { get; set; }//added for relation
    }
}