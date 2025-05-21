using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_3_Layer_Model
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppContext());

            //LoginForm loginForm = new LoginForm();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new DashBoardForm());
            //}
            //else
            //{
            //    Application.Exit();
            //}

            //Application.Run(new DashBoardForm());
            //Application.Run(new LoginForm());
        }
        public class AppContext : ApplicationContext
        {
            private LoginForm loginForm;
            private Form dashboardForm;

            public AppContext()
            {
                ShowLoginForm();
            }

            private void ShowLoginForm()
            {
                loginForm = new LoginForm();
                loginForm.LoginSuccessful += OnLoginSuccessful;
                loginForm.FormClosed += (s, e) => ExitThread(); // Nếu tắt form login
                loginForm.Show();
            }

            //private void OnLoginSuccessful(object sender, EventArgs e)
            //{
            //    loginForm.LoginSuccessful -= OnLoginSuccessful;
            //    loginForm.Hide();

            //    dashboardForm = new DashBoardForm();
            //    dashboardForm.Logout += OnLogout;
            //    dashboardForm.FormClosed += (s, args) => ExitThread(); // Nếu tắt dashboard
            //    dashboardForm.Show();
            //}

            private void OnLoginSuccessful(string username, string role)
            {
                //loginForm.LoginSuccessful -= OnLoginSuccessful;
                //loginForm.Hide();

                //dashboardForm = new DashBoardForm(username, role); // truyền trực tiếp
                //dashboardForm.FormClosed += (s, args) => ExitThread();
                //dashboardForm.Show();

                loginForm.Hide();

                if (role == "1")
                    dashboardForm = new DashBoardForm();
                else if (role == "2")
                    dashboardForm = new DashBoardForm(role);
                else if (role == "Kỹ thuật viên")
                    dashboardForm = new DashBoardForm(role);
                else if (role == "Trông xe")
                    dashboardForm = new DashBoardForm(role);
                else if (role == "Tiếp tân")
                    dashboardForm = new DashBoardForm(role);

                dashboardForm.FormClosed += (s, args) => ExitThread();
                dashboardForm.Show();
            }

            private void OnLogout(object sender, EventArgs e)
            {
                //dashboardForm.Logout -= OnLogout;
                if (dashboardForm is DashBoardForm dashForm)
                {
                    dashForm.Logout -= OnLogout;
                }
                dashboardForm.Close(); // đóng dashboard
                ShowLoginForm();       // quay lại login
            }
        }
    }
}
