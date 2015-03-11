using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
               
        }

        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
   
            
            Image tmp_img_viewer = new Image();
            Image[] imgViewers = new Image[] { img_viewer0, img_viewer1, img_viewer2, img_viewer3 };
            for (int i = 0; i <= 3; i++)
            {
                CameraCaptureUI capture = new CameraCaptureUI();
                capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
                StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
                IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
                BitmapImage img = new BitmapImage();
                img.SetSource(filestream);
                tmp_img_viewer = imgViewers[i];
                tmp_img_viewer.Source = img;
                txt1.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                btn.Visibility = Visibility.Collapsed;              
                
               
 
            }
        }

        private void txt2_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

  
    }
}

