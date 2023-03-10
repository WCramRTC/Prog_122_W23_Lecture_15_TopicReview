using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Prog_122_W23_Lecture_15_TopicReview
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

        private void CheckedEvent(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.Content = cb.IsChecked.Value;
        }

           
        private void btDisplay(object sender, RoutedEventArgs e)
        {
            Button Display1 = (Button)sender;
            runDisplay.Text = Display1.Content.ToString();            
        }

        private void AppendNumber(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            runDisplay.Text += btn.Content;
        }


        /*
        WPF Forms
        Text Box
        Button
        Label
        RichTextBox
            - Added name to Run Tag
            - Use .Text to get and set text
        List
        Classes ( Fields, Properties, Constructor, Methods )
        Selection Boxes
        Checkboxes and Radio Buttons
            - button.IsChecked.Value
            - 
        Rich Text Box Advanced
        List View
        Images
        Enumerable
        Jonathan Reed
        Meili Zheng
        Will was here
        BRESHNA NAIM
         */
    }
}
