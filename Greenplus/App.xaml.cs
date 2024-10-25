using Greenplus.Database;

namespace Greenplus
{
    public partial class App : Application
    {
        public static ApplicationDbContext DataBase {  get; private set; }

        public App()
        {
            InitializeComponent();

            DataBase = new ApplicationDbContext();
            MainPage = new MainPage();
        }

    }
}
