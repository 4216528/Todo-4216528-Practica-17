using Todo_4216528.Views;
using Todo_4216528.Data;
using Microsoft.Extensions.Logging;

namespace Todo_4216528
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<TodoListPage>();

            builder.Services.AddSingleton<TodoItemPage>();

            builder.Services.AddSingleton<TodoItemDatabase>();

            return builder.Build();
        }
    }
}