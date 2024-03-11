using BankingAssignment.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment.Services
{
    public class AppDataBase
    {
        private SQLiteConnection _dbconnection;
    
        public string GetDatabasePath() 
        
        {
            string filename = "AppDatabase.db";

            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return pathToDb + filename;

        }

       
       
        public AppDataBase() 
        { 
        _dbconnection=new SQLiteConnection(GetDatabasePath());
         _dbconnection.CreateTable<Client>();
           
        }
      
        public  void SaveClient(Client client)
        {


           _dbconnection.Insert(client);
        }
        public void UpdateClient(Client client)
        {
            _dbconnection.Update(client);
        }

        public Client GetClientById(int id)
        {
            Client client = _dbconnection.Table<Client>().Where(x => x.ClientId == id).FirstOrDefault();

            if (client != null)
                _dbconnection.GetChildren(client, true);

            return client;
        }

        public void DeleteClientById(int id) { _dbconnection.Delete<Client>(id); }
    }
}
