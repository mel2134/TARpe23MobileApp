using ViewModels;

namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _productsViewModel;
        public MainPage(ProductsViewModel productsViewModel)
        {
            _productsViewModel = productsViewModel;
            BindingContext = productsViewModel;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _productsViewModel.LoadProductsAsync();
        }
    }

}
