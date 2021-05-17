using System;

namespace capstone_toolmeonce.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }

        public string FirebaseUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime DateRegistered { get; set; }

        public DateTime DateDeactivated { get; set; }

        public DateTime DateLastActivated { get; set; }

        public int IsActive { get; set; }
    }
}
