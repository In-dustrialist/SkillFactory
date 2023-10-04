using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        //Благодарю, очень интересное задание, я новичок поэтому задание далось с большим трудом, 
        //Делал на английсом, потому что с символами на русском при выводе на консоль у меня иногда возникают проблемы.
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for visiting our online store!\n");

            // Вызываем метод для выбора типа доставки
            DeliveryType selectedDeliveryType = SelectDeliveryType();

            // Вызываем метод для создания и отображения заказа
            CreateAndDisplayOrder(selectedDeliveryType);
        }

        //Список для выбора типа доставки
        enum DeliveryType
        {
            HomeDelivery = 1,
            PickPointDelivery = 2,
            ShopDelivery = 3
        }

        abstract class Delivery
        {

            public string BuyerName { get; set; }
            public string PhoneNumber { get; set; }
            public string ProductName { get; set; }
            public string DeliveryTypeName { get; set; }

            public abstract void DisplayAdditionalInfo();

        }

        class HomeDelivery : Delivery
        {
            public string HomeAddress { get; set; }

            public HomeDelivery()
            {
            }
            public HomeDelivery(string address)
            {
                HomeAddress = address;
            }

            public override void DisplayAdditionalInfo()
            {
                Console.WriteLine($"\nHome Delivery Address: {HomeAddress}\n");
                Console.WriteLine($"Thank you for the order!\nYour order will be delivered by courier within 24 hours!\n");
            }
        }

        class PickPointDelivery : Delivery
        {
            public string PickPointLocation { get; set; }
            public PickPointDelivery()
            {
            }
            public PickPointDelivery(string address)
            {
                PickPointLocation = address;
            }
            public override void DisplayAdditionalInfo()
            {
                
                Console.WriteLine($"Company name: PickPoint Service!\n");
                Console.WriteLine($"Pick Point Location: {PickPointLocation}\n");
                Console.WriteLine($"Thank you for the order!\nYour order will be delivered to the pick-up point within 2 working days!\n");
               
            }
        }

        class ShopDelivery : Delivery
        {
            public string ShopAddress { get; set; }
            public ShopDelivery()
            {
            }
            public ShopDelivery(string address)
            {
                ShopAddress = address;
            }
            public override void DisplayAdditionalInfo()
            {
               
                Console.WriteLine($"Shop Name: Eldorado.\n");
                Console.WriteLine($"Delivery store address: {ShopAddress}\n");
                Console.WriteLine($"Thank you for the order!\nYour order will be delivered to the store within 24 hours!\n");
             
            }
        }

        class Product
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }

            public Product(string productName, decimal price)
            {
                ProductName = productName;
                Price = price;
            }
        }

        class Order<TDelivery> where TDelivery : Delivery, new()
        {
            public TDelivery Delivery { get; set; } = new TDelivery();
            public DeliveryType DeliveryType { get; set; }
            public List<Product> Products { get; set; } = new List<Product>();

            //Метод для создания заказа
            public void CreateOrder()
            {
                Console.Write("Enter recipient's name: ");
                Delivery.BuyerName = Console.ReadLine();

                Console.Write("Enter the recipient's phone number: ");
                Delivery.PhoneNumber = Console.ReadLine();

                Console.Write("Comments for ordering: ");
                Delivery.ProductName = Console.ReadLine();

                Console.WriteLine("\nAvailable Products:");

                List<Product> availableProducts = GetAvailableProducts();
                for (int i = 0; i < availableProducts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableProducts[i].ProductName} (${availableProducts[i].Price})");
                }

                int productIndex;
                bool isValidInput = false;

                do
                {
                    Console.Write("Select the product you would like (Enter the item number from 1 to 3): ");
                    if (int.TryParse(Console.ReadLine(), out productIndex) && productIndex >= 1 && productIndex <= availableProducts.Count)
                    {
                        Products.Add(availableProducts[productIndex - 1]);
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid product number.");
                    }
                } while (!isValidInput);
            }
        

            //Метод для отображения информации о заказе
            public void DisplayOrderInfo()
            {
                Console.WriteLine($"Delivery Type: {DeliveryType}");
                Console.WriteLine($"Recipient's Name: {Delivery.BuyerName}");
                Console.WriteLine($"Recipient's Phone Number: {Delivery.PhoneNumber}");
                Console.WriteLine($"Comments for ordering: {Delivery.ProductName}");

                if (Products.Count > 0)
        {
            Console.WriteLine("Selected Products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.ProductName} (${product.Price})");
            }
        }
            }
        }
        private static List<Product> GetAvailableProducts()
        {
            List<Product> availableProducts = new List<Product>
        {
            new Product("Phone", 650),
            new Product("Microwave", 200),
            new Product("Laptop", 1000),
        };
            return availableProducts;
        }

        //Метод для выбора типа доставки
        static DeliveryType SelectDeliveryType()
        {
            Console.WriteLine("Available Delivery Types:");
            Console.WriteLine($"{(int)DeliveryType.HomeDelivery}. Home Delivery");
            Console.WriteLine($"{(int)DeliveryType.PickPointDelivery}. Pick Point Delivery");
            Console.WriteLine($"{(int)DeliveryType.ShopDelivery}. Shop Delivery");

            int selectedTypeIndex;
            do
            {
                Console.Write("Select delivery type (enter only numbers 1, 2 or 3): ");
            } while (!int.TryParse(Console.ReadLine(), out selectedTypeIndex) ||
                     !Enum.IsDefined(typeof(DeliveryType), selectedTypeIndex));
            return (DeliveryType)selectedTypeIndex;
        }

        //Метод для создания заказа исходя из типа доставки
        static void CreateAndDisplayOrder(DeliveryType selectedDeliveryType)
        {
            switch (selectedDeliveryType)
            {
                case DeliveryType.HomeDelivery:
                    
                    Console.WriteLine("\nCreating Home Delivery Order:");
                    Console.Write("\nEnter Home Delivery address: ");
                    string homeDeliveryAddress = Console.ReadLine();

                    HomeDelivery homeDelivery = new HomeDelivery(homeDeliveryAddress);
                    Order<HomeDelivery> homeDeliveryOrder = new Order<HomeDelivery>
                    {
                        DeliveryType = selectedDeliveryType,
                        Delivery = homeDelivery
                    };

                    homeDeliveryOrder.CreateOrder();
                    Console.WriteLine("\nOrder Details:");
                    homeDeliveryOrder.DisplayOrderInfo();
                    homeDeliveryOrder.Delivery.DisplayAdditionalInfo();
                    break;

                case DeliveryType.PickPointDelivery:

                    Console.WriteLine("\nCreating Pick Point Delivery Order:");
                    Console.Write("\nEnter PickPoint Delivery address: ");
                    string pickPointAddress = Console.ReadLine();

                    PickPointDelivery pickPointDelivery = new PickPointDelivery(pickPointAddress);
                    Order<PickPointDelivery> pickPointDeliveryOrder = new Order<PickPointDelivery>
                    {
                        DeliveryType = selectedDeliveryType,
                        Delivery = pickPointDelivery
                    };
                    pickPointDeliveryOrder.CreateOrder();
                    Console.WriteLine("\nOrder Details:");
                    pickPointDeliveryOrder.DisplayOrderInfo();
                    pickPointDeliveryOrder.Delivery.DisplayAdditionalInfo();
                    break;

                case DeliveryType.ShopDelivery:
                    Console.WriteLine("\nCreating Shop Delivery Order:");
                    Console.Write("\nEnter shop address: ");
                    string shopAddress = Console.ReadLine();

                    ShopDelivery shopDelivery = new ShopDelivery(shopAddress);
                    Order<ShopDelivery> shopDeliveryOrder = new Order<ShopDelivery>
                    {
                        DeliveryType = selectedDeliveryType,
                        Delivery = shopDelivery
                    };
                    shopDeliveryOrder.CreateOrder();
                    Console.WriteLine("\nOrder Details:");
                    shopDeliveryOrder.DisplayOrderInfo();
                    shopDeliveryOrder.Delivery.DisplayAdditionalInfo();
                    break;

                default:
                    Console.WriteLine("We do not support this type of delivery");
                    break;
            }
        }
    }
}