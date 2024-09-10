using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StoreApp
{
    enum Category
    {
        Laptop,
        Phone,
        Tablet,
        Charger,
        Case,
        HeadPhones
    }

    abstract class Device
    {
        private decimal price;
        private string vendor;
        private Category category;
        private int yearOfRelease;
        private int warranty;
        private string model;

        public Device() { }

        public Device(decimal price, string vendor, Category category, int yearOfRelease, int warranty, string model)
        {
            this.price = price;
            this.vendor = vendor;
            this.category = category;
            this.yearOfRelease = yearOfRelease;
            this.warranty = warranty;
            this.model = model;
        }

        public string GetModel() 
        { 
            return model;
        }

        public void SetModel(string model) 
        {
            this.model = model;
        }

        public int GetWarranty()
        { 
            return warranty; 
        }

        public void SetWarranty(int warranty)
        {
            this.warranty = warranty;
        }

        public int GetYearOfRelease()
        {
            return yearOfRelease;
        }

        public void SetYearOfRelease(int year)
        {
            this.yearOfRelease = year;
        }

        public Category GetCategory()
        {
            return category;
        }

        public void SetCategory(Category category)
        {
            this.category = category;
        }

        public string GetVendor()
        {
            return vendor;
        }

        public void SetVendor(string vendor)
        {
            this.vendor = vendor;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"{vendor} {model} ({category}, {yearOfRelease}) - {price:C}";
        }
    }

    class Laptop : Device
    {
        public Laptop(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.Laptop, yearOfRelease, warranty, model) { }
    }

    class Phone : Device
    {
        public Phone(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.Phone, yearOfRelease, warranty, model) { }
    }

    class Tablet : Device
    {
        public Tablet(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.Tablet, yearOfRelease, warranty, model) { }
    }

    class Charger : Device
    {
        public Charger(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.Charger, yearOfRelease, warranty, model) { }
    }

    class Case : Device
    {
        public Case(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.Case, yearOfRelease, warranty, model) { }
    }

    class HeadPhone : Device
    {
        public HeadPhone(decimal price, string vendor, int yearOfRelease, int warranty, string model)
            : base(price, vendor, Category.HeadPhones, yearOfRelease, warranty, model) { }
    }

    class Store
    {
        private List<Device> devices = new List<Device>();

        public void AddDevice(Device device)
        {
            devices.Add(device);
        }

        public List<Device> FindByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return devices.Where(d => d.GetPrice() >= minPrice && d.GetPrice() <= maxPrice).ToList();
        }

        public List<Device> FindByModel(string modelPattern)
        {
            Regex regex = new Regex(modelPattern, RegexOptions.IgnoreCase);
            return devices.Where(d => regex.IsMatch(d.GetModel())).ToList();
        }

        public List<Device> FindByYear(int year)
        {
            return devices.Where(d => d.GetYearOfRelease() == year).ToList();
        }

        public List<Device> FindByType(Type deviceType)
        {
            return devices.Where(d => d.GetType() == deviceType).ToList();
        }

        public Device this[string model]
        {
            get
            {
                return devices.FirstOrDefault(d => d.GetModel().Equals(model, StringComparison.OrdinalIgnoreCase));
            }
        }

        public Device this[decimal minPrice, decimal maxPrice]
        {
            get
            {
                return devices.FirstOrDefault(d => d.GetPrice() >= minPrice && d.GetPrice() <= maxPrice);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store.AddDevice(new Laptop(1000m, "Dell", 2023, 2, "XPS 15"));
            store.AddDevice(new Phone(799m, "Apple", 2022, 1, "iPhone 14"));
            store.AddDevice(new Tablet(599m, "Samsung", 2021, 1, "Galaxy Tab S7"));
            store.AddDevice(new Charger(49m, "Anker", 2023, 2, "Anker Charger 65W"));
            store.AddDevice(new Case(29m, "Spigen", 2022, 1, "iPhone 14 Case"));

            Console.WriteLine("Search for devices priced between 500-1000: ");
            var devicesInRange = store.FindByPriceRange(500m, 1000m);
            foreach (var device in devicesInRange)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine("\nSearch for devices with the model 'iPhone': ");
            var devicesByModel = store.FindByModel("iPhone");
            foreach (var device in devicesByModel)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine("\nSearch for devices released in 2023: ");
            var devicesByYear = store.FindByYear(2023);
            foreach (var device in devicesByYear)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine("\nSearch for all laptops: ");
            var laptops = store.FindByType(typeof(Laptop));
            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop);
            }

            Console.WriteLine("\nSearch for a device by model 'XPS 15': ");
            Device deviceByModel = store["XPS 15"];
            if (deviceByModel != null)
            {
                Console.WriteLine(deviceByModel);
            }

            Console.WriteLine("\nSearching for a device in the 700-800 price range: ");
            Device deviceByPrice = store[700m, 800m];
            if (deviceByPrice != null)
            {
                Console.WriteLine(deviceByPrice);
            }
        }
    }
}
