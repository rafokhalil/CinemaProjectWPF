using CinemaStep.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CinemaStep
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
            DataContext = new SignUpControlViewModel(this);
        }

        private void Username_MouseEnter(object sender, MouseEventArgs e)
        {
            if (nameTxtbx.Text == "Username")
            {
                nameTxtbx.Text = null;
                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);
                nameTxtbx.Foreground = new SolidColorBrush(color1);
            }
        }



        private void Username_MouseLeave(object sender, MouseEventArgs e)
        {
            if (nameTxtbx.Text == "")
            {
                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);
                nameTxtbx.Text = "Username";
                nameTxtbx.Foreground = new SolidColorBrush(color2);
            }
        }

        private void Surename_MouseEnter(object sender, MouseEventArgs e)
        {
            if (surenameTxtbx.Text == "Surname")
            {
                surenameTxtbx.Text = null;
                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);
                surenameTxtbx.Foreground = new SolidColorBrush(color1);
            }
        }



        private void Surename_MouseLeave(object sender, MouseEventArgs e)
        {
            if (surenameTxtbx.Text == "Surname")
            {
                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);
                surenameTxtbx.Text = "Surname";
                surenameTxtbx.Foreground = new SolidColorBrush(color2);
            }
        }

        private void Password_MouseEnter(object sender, MouseEventArgs e)
        {
            if (passwordTxtbx.Text == "Password")
            {
                passwordTxtbx.Text = null;
                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);
                passwordTxtbx.Foreground = new SolidColorBrush(color1);
            }
        }



        private void Password_MouseLeave(object sender, MouseEventArgs e)
        {
            if (passwordTxtbx.Text == "Password")
            {
                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);
                passwordTxtbx.Text = "Password";
                passwordTxtbx.Foreground = new SolidColorBrush(color2);
            }
        }


        private void Email_MouseEnter(object sender, MouseEventArgs e)
        {
            if (emailTxtbx.Text == "Email")
            {
                emailTxtbx.Text = null;
                Color color1 = new Color();
                color1 = Color.FromArgb(255, 37, 191, 191);
                nameTxtbx.Foreground = new SolidColorBrush(color1);
            }
        }



        private void Email_MouseLeave(object sender, MouseEventArgs e)
        {
            if (emailTxtbx.Text == "Email")
            {
                Color color2 = new Color();
                color2 = Color.FromArgb(255, 110, 127, 128);
                emailTxtbx.Text = "Email";
                emailTxtbx.Foreground = new SolidColorBrush(color2);
            }
        }














    }
}
