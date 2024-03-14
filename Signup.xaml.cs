using BankingAssignment.Models;
using BankingAssignment.Services;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;
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
        OnPropertyChanged();
        LoadData();
       


    }

    
   

   


    private void LoadData()
    {
        Client client = _appData.GetClientById(1);

        CurrentClient = client;

    }
   
    
    private async void SavePage(object sender, EventArgs e) 
    {
        CurrentClient = new Client()
        {
            ClientId= 1,
            ClientName = txtname.Text,
            ClientSurname = txtsurname.Text,
           // ClientContactnumber=txtnumber.Text,
            ClientEmail=txtemail.Text,

        }
         ;


        _appData.UpdateClient(CurrentClient);

        await DisplayAlert("Success", "Client saved successfully.", "OK");
        DisableButton();

    }

    private void DisableButton() 
    { 
        SaveButton.IsEnabled= false;
        SaveButton.IsVisible= false;
        
    
    }

    private async void NextPage(object sender, EventArgs e) 
    {
        Routing.RegisterRoute("Profile", typeof(Profile));
        await Shell.Current.GoToAsync("//Profile");
        //await Navigation.PushAsync(new Profile(CurrentClient));
    }

   

    private void ReloadButton_Clicked(object sender, EventArgs e)
    {
        LoadData();
    }




}

