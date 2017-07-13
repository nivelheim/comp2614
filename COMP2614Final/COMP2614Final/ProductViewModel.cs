using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using COMP2614FinalLibrary;

namespace COMP2614Final
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private decimal extended;
        private int detailId;
        private int quantity;
        private String sku;
        private String description;
        private decimal price;
        private bool? isTaxable;

        public ProductCollection Products { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductViewModel(ProductCollection list)
        {
            this.Products = list;
        }

        public int DetailId
        {
            get { return detailId; }

            set
            {
                detailId = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged();
            }
        }

        public String Sku
        {
            get { return sku; }
            set
            {
                sku = value;
                OnPropertyChanged();
            }
        }

        public String Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        public bool? IsTaxable
        {
            get { return isTaxable; }
            set
            {
                isTaxable = value;
                OnPropertyChanged();
            }
        }

        public decimal Extended
        {
            get { return extended; }
            set
            {
                extended = value;
                OnPropertyChanged();
            }
        }

        public void SetDisplayingProduct(Product p)
        {
            DetailId = p.DetailId;
            Quantity = p.Quantity;
            Sku = p.Sku;
            Description = p.Description;
            Price = p.Price;
            IsTaxable = p.IsTaxable;
            Extended = p.Extended;
        }

        public Product GetDisplayingProduct()
        {
            Product product = new Product();

            product.DetailId = this.detailId;
            product.Quantity = this.quantity;
            product.Sku = this.sku;
            product.Description = this.description;
            product.Price = this.price;
            product.IsTaxable = this.isTaxable;
            product.Extended = this.extended;

            return product;
        }

        public void SaveClient(int index)
        {
            Products[index].DetailId = DetailId;
            Products[index].Quantity = Quantity;
            Products[index].Sku = Sku;
            Products[index].Description = Description;
            Products[index].Price = Price;
            Products[index].IsTaxable = IsTaxable;
            Products[index].Extended = Extended;
        }
    }
}
