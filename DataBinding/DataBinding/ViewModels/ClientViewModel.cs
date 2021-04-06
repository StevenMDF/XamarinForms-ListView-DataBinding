using DataBinding.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DataBinding.ViewModels
{
    public class ClientViewModel : BaseViewModel
    {
        private ObservableCollection<Client> clients;
        public ObservableCollection<Client> Clients 
        {
            get { return clients; } 
            set
            {
                clients = value;
                OnPropertyChanged();
            }
        }

        public Command SaveClientCommand { get; }

        public ClientViewModel()
        {
            this.Clients = new ObservableCollection<Client>();

            SaveClientCommand = new Command(()=> {

                Client client = new Client()
                {
                    Name = Name,
                    Phone = Phone
                };

                Clients.Add(client);
                OnPropertyChanged(nameof(Clients));
            });



        }

        private int id;
        public int Id 
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set 
            {
                phone = value;
                OnPropertyChanged();
            }
        }

    }
}
