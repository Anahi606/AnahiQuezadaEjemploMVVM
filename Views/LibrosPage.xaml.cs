using AnahiQuezadaEjemploMVVM.Services;
using AnahiQuezadaEjemploMVVM.ViewModels;

namespace AnahiQuezadaEjemploMVVM.Views;

public partial class LibrosPage : ContentPage
{
	private readonly LibroViewModel _viewModel;
	public LibrosPage()
	{
		InitializeComponent();
		_viewModel = new LibroViewModel();

		var libroService = DependencyService.Get<ILibroService>();

		var libros = libroService.ObtenerLibro();

		_viewModel.Libros = libros;

		BindingContext = _viewModel;
	}
}