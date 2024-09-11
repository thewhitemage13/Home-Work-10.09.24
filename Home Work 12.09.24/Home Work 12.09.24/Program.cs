namespace Home_Work_12._09._24
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    namespace StoreApp
    {
        public abstract class DataCarrier
        {
            protected string mediaName;
            protected string vendorName;
            protected string model;
            protected long count;
            protected decimal price;

            public DataCarrier(string mediaName, string vendorName, string model, long count, decimal price)
            {
                this.mediaName = mediaName;
                this.vendorName = vendorName;
                this.model = model;
                this.count = count;
                this.price = price;
            }

            public decimal GetPrice()
            {
                return price;
            }

            public void SetPrice(decimal price)
            {
                this.price = price;
            }

            public long GetCount()
            {
                return count;
            }

            public void SetCount(long count)
            {
                this.count = count;
            }

            public string GetModel()
            {
                return model;
            }

            public void SetModel(string model)
            {
                this.model = model;
            }

            public string GetVendorName()
            {
                return vendorName;
            }

            public void SetVendorName(string vendorName)
            {
                this.vendorName = vendorName;
            }

            public string GetMediaName()
            {
                return mediaName;
            }

            public void SetMediaName(string mediaName)
            {
                this.mediaName = mediaName;
            }

            public virtual void Print()
            {
                Console.WriteLine(this.ToString());
            }

            public virtual void Download(string filePath)
            {

            }

            public virtual void Save(string filePath)
            {

            }

            public virtual void Update(DataCarrier dataCarrier)
            {
                Console.WriteLine("Enter Update Information about Data Carrier: ");
                Console.Write("Enter New Media Name: ");
                string newMediaName = Console.ReadLine();
                dataCarrier.SetMediaName(newMediaName);

                Console.Write("Enter New Vendor Name: ");
                string newVendorName = Console.ReadLine();
                dataCarrier.SetVendorName(newVendorName);

                Console.Write("Enter New Model: ");
                string newModel = Console.ReadLine();
                dataCarrier.SetModel(newModel);

                Console.Write("Enter New Count: ");
                long newCount = Convert.ToInt64(Console.ReadLine());
                dataCarrier.SetCount(newCount);

                Console.Write("Enter New Price: ");
                decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                dataCarrier.SetPrice(newPrice);
            }

            public override string ToString()
            {
                return "Media Name: " + this.mediaName + "\n" + "Vendor Name: " + this.mediaName + "\n" + "Medel: " + this.model + "\n" + "Count: " + this.count + "\n" + "Price: " + this.price + "\n";
            }
        }

        public class FlashData : DataCarrier
        {
            private long memorySize;
            private int usbSpeed;

            public FlashData(long memorySize, int usbSpeed, string mediaName, string vendorName, string model, long count, decimal price) : base(mediaName, vendorName, model, count, price)
            {
                this.memorySize = memorySize;
                this.usbSpeed = usbSpeed;
            }

            public int GetUsbSpeed()
            {
                return usbSpeed;
            }

            public void SetUsbSpeed(int usbSpeed)
            {
                this.usbSpeed = usbSpeed;
            }

            public long GetMemorySize()
            {
                return memorySize;
            }

            public void SetMemorySize(long memorySize)
            {
                this.memorySize = memorySize;
            }

            public override void Download(string filePath)
            {

            }

            public override void Save(string filePath)
            {

            }

            public override void Print()
            {
                Console.WriteLine(this.ToString());
            }

            public override void Update(DataCarrier dataCarrier)
            {
                Console.WriteLine("Enter Update Information about Data Carrier: ");
                Console.Write("Enter New Media Name: ");
                string newMediaName = Console.ReadLine();
                dataCarrier.SetMediaName(newMediaName);

                Console.Write("Enter New Vendor Name: ");
                string newVendorName = Console.ReadLine();
                dataCarrier.SetVendorName(newVendorName);

                Console.Write("Enter New Model: ");
                string newModel = Console.ReadLine();
                dataCarrier.SetModel(newModel);

                Console.Write("Enter New Count: ");
                long newCount = Convert.ToInt64(Console.ReadLine());
                dataCarrier.SetCount(newCount);

                Console.Write("Enter New Price: ");
                decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                dataCarrier.SetPrice(newPrice);

                Console.Write("Enter New Memory Size: ");
                long newMemorySize = Convert.ToInt64(Console.ReadLine());
                SetMemorySize(newMemorySize);

                Console.WriteLine("Enter New Usb Speed");
                int newUsbSpeed = Convert.ToInt32(Console.ReadLine());
                SetUsbSpeed(newUsbSpeed);
            }

            public override string ToString()
            {
                return base.ToString() + "Memory Size: " + memorySize + "\n" + "Usb Speed: " + usbSpeed + "\n";
            }
        }

        public class DVD : DataCarrier
        {
            private int readSpeed;
            private int writeSpeed;

            public DVD(int readSpeed, int writeSpeed, string mediaName, string vendorName, string model, long count, decimal price) : base(mediaName, vendorName, model, count, price)
            {
                this.readSpeed = readSpeed;
                this.writeSpeed = writeSpeed;
            }

            public int GetWriteSpeed()
            {
                return writeSpeed;
            }

            public void SetWriteSpeed(int writeSpeed)
            {
                this.writeSpeed = writeSpeed;
            }

            public int GetReadSpeed()
            {
                return readSpeed;
            }

            public void SetReadSpeed(int readSpeed)
            {
                this.readSpeed = readSpeed;
            }

            public override void Download(string filePath)
            {

            }

            public override void Save(string filePath)
            {

            }

            public override void Print()
            {
                Console.WriteLine(this.ToString());
            }

            public override string ToString()
            {
                return base.ToString() + "Read Speed: " + readSpeed + "\n" + "Write Speed: " + writeSpeed + "\n";
            }

            public override void Update(DataCarrier dataCarrier)
            {
                Console.WriteLine("Enter Update Information about Data Carrier: ");
                Console.Write("Enter New Media Name: ");
                string newMediaName = Console.ReadLine();
                dataCarrier.SetMediaName(newMediaName);

                Console.Write("Enter New Vendor Name: ");
                string newVendorName = Console.ReadLine();
                dataCarrier.SetVendorName(newVendorName);

                Console.Write("Enter New Model: ");
                string newModel = Console.ReadLine();
                dataCarrier.SetModel(newModel);

                Console.Write("Enter New Count: ");
                long newCount = Convert.ToInt64(Console.ReadLine());
                dataCarrier.SetCount(newCount);

                Console.Write("Enter New Price: ");
                decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                dataCarrier.SetPrice(newPrice);

                Console.Write("Enter New Read Speed: ");
                int newReadSpeed = Convert.ToInt32(Console.ReadLine());
                SetReadSpeed(newReadSpeed);

                Console.WriteLine("Enter New Write Speed");
                int newWriteSpeed = Convert.ToInt32(Console.ReadLine());
                SetWriteSpeed(newWriteSpeed);
            }
        }

        public class RemovableHDD : DataCarrier
        {
            private long diskSize;
            private int usbSpeed;

            public RemovableHDD(long diskSize, int usbSpeed, string mediaName, string vendorName, string model, long count, decimal price) : base(mediaName, vendorName, model, count, price)
            {
                this.diskSize = diskSize;
                this.usbSpeed = usbSpeed;
            }

            public int GetUsbSpeed()
            {
                return usbSpeed;
            }

            public void SetUsbSpeed(int usbSpeed)
            {
                this.usbSpeed = usbSpeed;
            }

            public long GetDiskSize()
            {
                return diskSize;
            }

            public void SetDiskSize(long diskSize)
            {
                this.diskSize = diskSize;
            }

            public override void Download(string filePath)
            {

            }

            public override void Save(string filePath)
            {

            }

            public override void Print()
            {
                Console.WriteLine(this.ToString());
            }

            public override void Update(DataCarrier dataCarrier)
            {
                Console.WriteLine("Enter Update Information about Data Carrier: ");
                Console.Write("Enter New Media Name: ");
                string newMediaName = Console.ReadLine();
                dataCarrier.SetMediaName(newMediaName);

                Console.Write("Enter New Vendor Name: ");
                string newVendorName = Console.ReadLine();
                dataCarrier.SetVendorName(newVendorName);

                Console.Write("Enter New Model: ");
                string newModel = Console.ReadLine();
                dataCarrier.SetModel(newModel);

                Console.Write("Enter New Count: ");
                long newCount = Convert.ToInt64(Console.ReadLine());
                dataCarrier.SetCount(newCount);

                Console.Write("Enter New Price: ");
                decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                dataCarrier.SetPrice(newPrice);

                Console.Write("Enter New Disk Size: ");
                long newDiskSize = Convert.ToInt32(Console.ReadLine());
                SetDiskSize(newDiskSize);

                Console.WriteLine("Enter New Write Speed");
                int newUsbSpeed = Convert.ToInt32(Console.ReadLine());
                SetUsbSpeed(newUsbSpeed);
            }

            public override string ToString()
            {
                return base.ToString() + "Disk Size: " + diskSize + "\n" + "Usb Speed: " + usbSpeed + "\n";
            }
        }

        public interface ShopInterface
        {
            void Add(DataCarrier dataCarrier);
            void Print();
            List<DataCarrier> FindByPriceRange(decimal minPrice, decimal maxPrice);
            List<DataCarrier> FindByModel(string modelPattern);
            List<DataCarrier> FindByCount(long count);
            List<DataCarrier> FindByType(Type deviceType);
            void Update(DataCarrier dataCarrier);
        }

        public class Shop : ShopInterface
        {
            List<DataCarrier> dataCarriers = new List<DataCarrier>();

            public void Add(DataCarrier dataCarrier)
            {
                dataCarriers.Add(dataCarrier);
            }

            public void Print()
            {
                foreach (DataCarrier data in dataCarriers)
                {
                    Console.WriteLine(data);
                }
            }

            public List<DataCarrier> FindByPriceRange(decimal minPrice, decimal maxPrice)
            {
                return dataCarriers.Where(d => d.GetPrice() >= minPrice && d.GetPrice() <= maxPrice).ToList();
            }

            public List<DataCarrier> FindByModel(string modelPattern)
            {
                Regex regex = new Regex(modelPattern, RegexOptions.IgnoreCase);
                return dataCarriers.Where(d => regex.IsMatch(d.GetModel())).ToList();
            }

            public List<DataCarrier> FindByCount(long count)
            {
                return dataCarriers.Where(d => d.GetCount() == count).ToList();
            }

            public List<DataCarrier> FindByType(Type deviceType)
            {
                return dataCarriers.Where(d => d.GetType() == deviceType).ToList();
            }

            public void Update(DataCarrier dataCarrier)
            {
                dataCarrier.Update(dataCarrier);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Shop shop = new Shop();

                DataCarrier dataCarrier1 = new FlashData(128, 500, "USB Flash Drive", "SanDisk", "Ultra Flair", 50, 45.99m);
                DataCarrier dataCarrier2 = new FlashData(256, 1000, "USB Flash Drive", "Kingston", "DataTraveler Max", 30, 79.99m);
                DataCarrier dataCarrier3 = new DVD(16, 8, "DVD Disc", "Verbatim", "DVD-R", 100, 19.99m);
                DataCarrier dataCarrier4 = new RemovableHDD(2000, 500, "External HDD", "Seagate", "Backup Plus", 20, 99.99m);
                DataCarrier dataCarrier5 = new RemovableHDD(4000, 1000, "External HDD", "Western Digital", "My Passport", 15, 149.99m);

                shop.Add(dataCarrier1);
                shop.Add(dataCarrier2);
                shop.Add(dataCarrier3);
                shop.Add(dataCarrier4);
                shop.Add(dataCarrier5);
                shop.Print();
                
                Console.WriteLine("====================================");

                List<DataCarrier> findByCount = shop.FindByCount(20);

                foreach (DataCarrier dataCarrier in findByCount)
                {
                    Console.WriteLine(dataCarrier);
                }

                //shop.Update(dataCarrier1);
                //shop.Print();
            }
        }
    }

}
