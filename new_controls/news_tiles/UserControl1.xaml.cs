using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace new_app.new_controls.news_tiles
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private string article_title_PH;
        public string Article_title_PH
        {
            get { return article_title_PH; }
            set
            {
                if (article_title_PH != value)
                {
                    article_title_PH = value;
                    OnPropertyChanged("Article_title_PH");
                }
            }
        }

        private ImageSource source_image_PH;
        public ImageSource Source_image_PH
        {
            get { return source_image_PH; }
            set
            {
                if (source_image_PH != value)
                {
                    source_image_PH = value;
                    OnPropertyChanged("Source_image_PH");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Url { get; set; } // Add a property to store the URL

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Url, // Use the stored URL
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                Console.WriteLine("Error opening URL: " + ex.Message);
            }

            e.Handled = true;
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
    }
}
