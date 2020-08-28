namespace TPG.FN.Introduction
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private MainWindow _view;
        private MainViewModel _viewModel;

        private void Application_Startup(object sender, System.Windows.StartupEventArgs e)
        {
            _viewModel = new MainViewModel();
            _view = new MainWindow();

            // TODO: make _viewModel the view model for _view

            _view.Show();
        }
    }
}
