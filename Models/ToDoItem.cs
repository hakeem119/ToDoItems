﻿namespace ToDoMyApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
