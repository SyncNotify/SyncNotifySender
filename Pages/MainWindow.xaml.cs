using iNKORE.UI.WPF.Helpers;
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

namespace SyncNotifySender
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Message message = new Message();
        private MessagePriority priority = new MessagePriority();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            
            message.Property.FileContent = Message_Input_TextBox.Text;
            message.Property.FileCreatingTime = DateTime.Now;
            message.Display.FileDisplayTime = DateTime.Now;
            MessageManager messageManager = new MessageManager();
            messageManager.SaveMessageToFile(message);
        }

        private void Popup_Button_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.IsChecked == true)
            {
                switch (radioButton.Name) 
                {
                    case "AfterClass_Popup_RadioButton":
                        message.Display.FileDisplayMode = MessagePriority.Priority.AFTERCLASS;
                        break;
                    case "Default_RadioButton":
                        message.Display.FileDisplayMode = MessagePriority.Priority.DEFAULT;
                        break;
                    case "Force_Popup_RadioButton":
                        message.Display.FileDisplayMode = MessagePriority.Priority.FORCED_NOW;
                        break;
                    case "Figured_Time_RadioButton":
                        message.Display.FileDisplayMode = MessagePriority.Priority.FIGURED;
                        break;
                    case "Invisible_RadioButton":
                        message.Display.FileDisplayMode = MessagePriority.Priority.INVISIBLE;
                        break;
                }

            }
        }
    }
}
