﻿namespace ToDoMyApp.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
