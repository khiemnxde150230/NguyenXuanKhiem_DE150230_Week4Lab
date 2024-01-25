using System.Diagnostics;
using System.Numerics;
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

namespace AsynchronousWPF
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

        private void CalculatePrimesSequentially_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            CalculatePrimeNumbersSync();
            stopwatch.Stop();
            DisplayResult($"Synchronous Prime Calculation took {stopwatch.ElapsedMilliseconds} ms.");
        }

        private async void CalculatePrimesParallel_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            await CalculatePrimeNumbersAsync();
            stopwatch.Stop();
            DisplayResult($"Asynchronous Prime Calculation took {stopwatch.ElapsedMilliseconds} ms.");
        }

        private void ManageStudentsSequentially_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ManageStudentsSync();
            stopwatch.Stop();
            DisplayResult($"Synchronous Student Management took {stopwatch.ElapsedMilliseconds} ms.");
        }

        private async void ManageStudentsParallel_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            await ManageStudentsAsync();
            stopwatch.Stop();
            DisplayResult($"Asynchronous Student Management took {stopwatch.ElapsedMilliseconds} ms.");
        }

        private void CalculatePrimeNumbersSync()
        {
            DisplayResult("Synchronous Prime Calculation");
        }

        private async Task CalculatePrimeNumbersAsync()
        {
            await Task.Delay(2000);
            DisplayResult("Asynchronous Prime Calculation");
        }

        private void ManageStudentsSync()
        {
            DisplayResult("Synchronous Student Management");
        }

        private async Task ManageStudentsAsync()
        {
            await Task.Delay(2000);
            DisplayResult("Asynchronous Student Management");
        }

        private void DisplayResult(string message)
        {
            ResultTextBox.AppendText($"{message}\n");
        }
    }
}