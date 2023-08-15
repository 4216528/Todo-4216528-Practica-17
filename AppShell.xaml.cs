using Todo_4216528.Views;

namespace Todo_4216528

{

    public partial class AppShell : Shell

    {

        public AppShell()

        {

            InitializeComponent();

            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));

        }

    }

}