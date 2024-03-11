using BankingAssignment.Models;
using BankingAssignment.Services;

using System.Collections.ObjectModel;
using System.Transactions;
namespace BankingAssignment;

public partial class Signup : ContentPage
{
    private AppDataBase _appData;
    private Client _client;
    public Client CurrentClient 
    { 
        get { return _client; } 
        set { _client = value;OnPropertyChanged(); } }
    public Signup()
	{
		InitializeComponent();
        _appData = new AppDataBase();
        BindingContext = this;
       
	}


  
    private void Button_Click(object sender, EventArgs e)
    {

        _appData.UpdateClient(CurrentClient);

    }
    private void LoadData()
    {
        Client client = _appData.GetClientById(1);

        CurrentClient = client;

        

    }
    private void ReloadButton_Clicked(object sender, EventArgs e)
    { 
        LoadData();
    }

   

   
}