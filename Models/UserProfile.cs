using UsersAPI.Entities;
using System;

namespace UsersAPI.Models
{
    public class UserProfile : User
    {
        public int DaysUntilBirthday { get; set; }
        public UserProfile(User user)
        {
            if(user == null){
                throw new ArgumentNullException("You can only pass a non-null user object into the UserProfile constructor.");
            }
            this.UserID = user.UserID;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Gender = user.Gender;
            this.DOB = user.DOB;
            this.DaysUntilBirthday = getDaysUntilBirthday(user.DOB);
        }

        private static int getDaysUntilBirthday(string dob)
        {
            if(dob == null){
                return -1;
            }
            DateTime birthday = DateTime.Parse(dob);
            DateTime today = DateTime.Today;
            var nextBirthday = birthday.AddYears(today.Year - birthday.Year);
            if(nextBirthday < today) {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - today).Days;
        }
    }
}