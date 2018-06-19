using MaratonaAvancada.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaAvancada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagingCenterPage : ContentPage
	{
        private string messageText;

        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; OnPropertyChanged(); }
        }

        private string itemText;

        public string ItemText
        {
            get { return itemText; }
            set { itemText = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Message> Messages { get; set; }

        public ICommand AddMessageCommand => new Command(AddMessageCommandExecute);

        public MessagingCenterPage ()
		{
			InitializeComponent ();
            Messages = new ObservableCollection<Message>();
            BindingContext = this;

            MessagingCenter.Subscribe<Message>(this, "SendMessage", message =>
            {
                switch (Messages.Count)
                {
                    case 0:
                        ItemText = "Vazio";
                        break;
                    case 1:
                        ItemText = $"{Messages.Count} item";
                        break;
                    default:
                        ItemText = $"{Messages.Count} itens";
                        break;
                }
            });
		}

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Message>(this, "SendMessage");
        }

        private void AddMessageCommandExecute()
        {
            Message message = new Message
            {
                Title = "Mensagem",
                Text = MessageText
            };

            Messages.Add(message);

            MessagingCenter.Send(message, "SendMessage");

            MessageText = "";
        }
    }
}