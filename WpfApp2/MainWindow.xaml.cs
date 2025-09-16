using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var result = MessageBox.Show("Винде гг бывай чувак", "Твоя главная ошибка", MessageBoxButton.YesNoCancel);


            if (result == MessageBoxResult.Yes)
            {
                while (1 == 1)
                {
                    MainWindow window1 = new MainWindow();
                    window1.Show();


                }

            }
            else if (result == MessageBoxResult.Cancel)
            {
                MessageBox.Show("Самый умный, да? Удаляем винду..", "ГГ ЧУВАК");

                while (1 == 1)
                {
                    MainWindow window1 = new MainWindow();
                    window1.Show();
                }
            }
            else MessageBox.Show("Ну ладно..");

        }

    }
}