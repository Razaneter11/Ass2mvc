﻿namespace Ass2mvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int Password { get; set; }
    }
}
