using AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        Title = "ITES - Demo MVVM";
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
    }

    [RelayCommand]
    public async Task GoToUsuarioLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioListaPage());
    }

    [RelayCommand]
    public async Task Exit()
    {
        bool shouldExit = await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar", "Cancelar");

        if (shouldExit)
        {
            
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());


            Application.Current.MainPage.Navigation.RemovePage(Application.Current.MainPage.Navigation.NavigationStack.First());
        }
    }

}
