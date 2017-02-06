using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WpfApplication4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer;
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        DateTimeOffset stopTime;
        int timesTicked = 1;
        int timesToTick = 10;
        String selectalarm;



        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimerSetup();

        }
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            startTime = DateTimeOffset.Now;
            lastTime = startTime;
            dispatcherTimer.Start();
            ring();
        }
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Tbreloj.Text = DateTime.Now.ToShortTimeString();
            ring();

        }
        private void ajuda(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("aplicación creada por Marcos Cantón");
        }
        private void sortir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


      
        private void ring()
        {
            if (Rbactivar_alarma.IsChecked.Value)
            {
                if (selectalarm == Tbreloj.Text)
                {
                    MessageBoxResult result=MessageBox.Show("Riiiiiiiing es la hora","Confirmation",MessageBoxButton.OK,MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {
                       Rbactivar_alarma.IsChecked = false;
                       Rbdesactivar_alarma.IsChecked = true;
                    }
                }
            }
        }

        private void RbactAlarmCheck(object sender, RoutedEventArgs e)
        {
            Rbdesactivar_alarma.IsChecked = false;
            selectalarm = Tbalarm.Text;
        }

        private void RbdesactAlarmCheck(object sender, RoutedEventArgs e)
        {
            Rbactivar_alarma.IsChecked = false;
        }

        
    }
}
