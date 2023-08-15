
// Se agregan las referencias using //

using Todo_4216528.Data;

using Todo_4216528.Models;

namespace Todo_4216528.Views;

[QueryProperty("Item", "Item")]

public partial class TodoItemPage : ContentPage

{
	TodoItem item;

	public TodoItem Item

    {

        get => BindingContext as TodoItem;

        set => BindingContext = value;

    }

    TodoItemDatabase database;

    public TodoItemPage(TodoItemDatabase todoItemDatabase)

    {

        InitializeComponent();

        database = todoItemDatabase;

    }

    async void OnSaveClicked(object sender, EventArgs e)

    {

        if (string.IsNullOrWhiteSpace(Item.Name))

        {

            await DisplayAlert("Nombre Requerido", "Introduzca un nombre para el elemento de tareas pendientes", "Aceptar"); return;

        }

        await database.SaveItemAsync(Item);

        await Shell.Current.GoToAsync("..");

    }

    async void OnDeleteClicked(object sender, EventArgs e)

    {
        if (Item.ID == 0)

            return;

        await database.DeleteItemAsync(Item);

        await Shell.Current.GoToAsync("..");

    }

    async void OnCancelClicked(object sender, EventArgs e)

    {

        await Shell.Current.GoToAsync("..");

    }

}