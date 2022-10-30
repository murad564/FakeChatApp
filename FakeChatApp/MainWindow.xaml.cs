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

namespace FakeChatApp
{

    public partial class MainWindow : Window
    {
        public List<Message> Messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Messages = new List<Message>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                //messageArea.Text;
                if (!string.IsNullOrWhiteSpace(messageArea.Text))
                {
                    Messages.Add(new Message { SenderName = "You", SendedTime = DateTime.Now, Text = messageArea.Text.ToString() });
                    Messages.Add(new Message { SenderName = "StepIT bot", SendedTime = DateTime.Now, Text = messageArea.Text.ToString() });
                    RefreshMessageList();
                }
            }
        }

        private void messageList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListView lView)
            {
                if (lView.SelectedItem is Message msg && msg.SenderName == "You")
                {
                    Messages.Remove(msg);
                    RefreshMessageList();
                }

            }
        }

        private void RefreshMessageList()
        {
            messageList.ItemsSource = null;
            messageList.ItemsSource = Messages;
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Canvas canvas)
            {
                MessageBox.Show("Chat with WhatsApp bot\nPhone:+994---");
            }
        }
    }
}