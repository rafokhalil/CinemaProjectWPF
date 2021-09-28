using CinemaStep.Model;
using CinemaStep.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaStep.Repository
{
    public static class FakeRepo
    {
        public static ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public static User User { get; set; }
        public static Admin Admin { get; set; }
        public static User OldUser { get; set; }
        public static Admin OldAdmin { get; set; }
        public static AddNewFilmWindow AddNewFilmWindow { get; set; } = new AddNewFilmWindow();

        public static ObservableCollection<Film> Films = new ObservableCollection<Film>();

        public static ObservableCollection<Film> GetAll()
        {
            return Films;
        }
        public static ObservableCollection<Admin> GetAdmins()
        {
            return new ObservableCollection<Admin>
            {
                new Admin
                {
                    Id=1,
                    Name="Rafael",
                    Surename="Xelilzade",
                    Password="aa123",
                    Email="rafaelxelilzade@gmail.com"
                },
                new Admin
                {
                    Id=2,
                    Name="Ruslan",
                    Surename="Mustafayev",
                    Password="1",
                    Email="ruslanmustafayev2000@gmail.com"
                }
            };
        }
    }
}
