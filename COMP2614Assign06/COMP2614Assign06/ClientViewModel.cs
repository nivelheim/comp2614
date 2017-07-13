using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ClientViewModel : INotifyPropertyChanged
{
    private String clientCode;
    private String companyName;
    private String address1;
    private String address2;
    private String city;
    private String province;
    private String postalCode;
    private decimal ytdSales;
    private bool isCreditHold;
    private String notes;

    public ClientCollection Clients { get; set; }
    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ClientViewModel(ClientCollection list) 
	{
        this.Clients = list;
	}

    public String ClientCode
    {
        get { return clientCode; }

        set
        {
            clientCode = value;
            OnPropertyChanged();
        }
    }

    public String CompanyName
    {
        get { return companyName; }
        set
        {
            companyName = value;
            OnPropertyChanged();
        }
    }

    public String Address1
    {
        get { return address1; }
        set
        {
            address1 = value;
            OnPropertyChanged();
        }
    }

    public String Address2
    {
        get { return address2; }
        set
        {
            address2 = value;
            OnPropertyChanged();
        }
    }

    public String City
    {
        get { return city; }
        set
        {
            city = value;
            OnPropertyChanged();
        }
    }

    public String Province
    {
        get { return province; }
        set
        {
            province = value;
            OnPropertyChanged();
        }
    }

    public String PostalCode
    {
        get { return postalCode; }
        set
        {
            postalCode = value;
            OnPropertyChanged();
        }
    }

    public decimal YtdSales
    {
        get { return ytdSales; }
        set
        {
            ytdSales = value;
            OnPropertyChanged();
        }
    }

    public bool IsCreditHold
    {
        get { return isCreditHold; }
        set
        {
            isCreditHold = value;
            OnPropertyChanged();
        }
    }

    public String Notes
    {
        get { return notes; }
        set
        {
            notes = value;
            OnPropertyChanged();
        }
    }

    public void SetDisplayingClient(Client c)
    {
        ClientCode = c.ClientCode;
        CompanyName = c.CompanyName;
        Address1 = c.Address1;
        Address2 = c.Address2;
        City = c.City;
        Province = c.Province;
        PostalCode = c.PostalCode;
        YtdSales = c.YtdSales;
        IsCreditHold = c.IsCreditHold;
        Notes = c.Notes;
    }

    public Client GetDisplayingClient()
    {
        Client client = new Client();
        client.ClientCode = this.ClientCode;
        client.CompanyName = this.CompanyName;
        client.Address1 = this.Address1;
        client.Address2 = this.Address2;
        client.City = this.City;
        client.Province = this.Province;
        client.PostalCode = this.PostalCode;
        client.YtdSales = this.YtdSales;
        client.IsCreditHold = this.IsCreditHold;
        client.Notes = this.Notes;

        return client;
    }

    public void SaveClient(int index)
    {
        Clients[index].ClientCode = ClientCode;
        Clients[index].CompanyName = CompanyName;
        Clients[index].Address1 = Address1;
        Clients[index].Address2 = Address2;
        Clients[index].City = City;
        Clients[index].Province = Province;
        Clients[index].PostalCode = PostalCode;
        Clients[index].YtdSales = YtdSales;
        Clients[index].IsCreditHold = IsCreditHold;
        Clients[index].Notes = Notes;
    }
}
