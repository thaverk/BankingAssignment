using BankingAssignment.Models;
using BankingAssignment.Services;
namespace BankingAssignment;

public partial class Profile : ContentPage
{
    private AppDataBase _appData;
    private Client _client;
    public Client CurrentClient
    {

        get { return _client; }
        set { _client = value; OnPropertyChanged(); }
    }
    public Profile(Client client)
    {

        InitializeComponent();
        _client = client;
        BindingContext = this;
        OnPropertyChanged();
    }

    private void LoadData()
    {
        Client client = _appData.GetClientById(1);

        CurrentClient = client;

    }


}