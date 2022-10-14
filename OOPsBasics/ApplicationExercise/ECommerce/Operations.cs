using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
     public static class Operations
    {
        static CustomerDetails currentCustomer =null;
        public static List<CustomerDetails> customerList = new List<CustomerDetails>();

        public static List<ProductDetails> productList = new List<ProductDetails>();

        public static List<OrderDetails> orderList = new List<OrderDetails>();

        public static void DefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi","Chennai",9885858588,50000,"ravi@mail.com");
            customerList.Add(customer1);
            CustomerDetails customer2 = new CustomerDetails("Baskaran","Chennai",9888475757,60000,"baskaran@mail.com");
            customerList.Add(customer2);
            ProductDetails product1 = new ProductDetails("Mobile",10000,10,3);
            productList.Add(product1);
            ProductDetails product2 = new ProductDetails("Tablet",15000,5,2);
            productList.Add(product2);
            ProductDetails product3 = new ProductDetails("Camera",20000,3,4);
            productList.Add(product3);
            ProductDetails product4 = new ProductDetails("iPhone",50000,5,6);
            productList.Add(product4);
            ProductDetails product5 = new ProductDetails("Laptop",40000,3,3);
            productList.Add(product5);
            OrderDetails order1 = new OrderDetails(customer1.CustomerID,product1.ProductID,20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails(customer2.CustomerID,product3.ProductID,40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);
        } 

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Customer Registration 2.Login and Purchase 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login and Purchase");
                        LoginAndPurchase();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }

            }while(choice=="yes");
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string customerName=Console.ReadLine();
            System.Console.WriteLine("Enter your city : ");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your phone number : ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your wallet balance : ");
            double walletBalance=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail ID : ");
            string mail=Console.ReadLine();
            

            CustomerDetails customer3 = new CustomerDetails(customerName,city,mobileNumber,walletBalance,mail);
            customerList.Add(customer3);
            System.Console.WriteLine("Your Customer ID is "+customer3.CustomerID);
        }

        public static void LoginAndPurchase()
        {
            System.Console.WriteLine("Enter your Customer ID : ");
            string customerId = Console.ReadLine();
            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerID==customerId)
                {
                    System.Console.WriteLine("Login Successful");
                    currentCustomer=customer;
                    SubMenu();
                    break;
                }
                
            }
        }


        public static void SubMenu()
        {
            string choice = "yes";

            do
            {
                System.Console.WriteLine("Select Option a.Purchase b.Order History c.Cancel Order d.Wallet Balance e.Exit");
                char option = char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Purchase");
                        Purchase();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Wallet Balance");
                        WalletBalance();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void Purchase()
        {
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"Product ID is {product.ProductID}\tProduct Name is {product.ProductName}\tProduct Stock is {product.Stock}\tProduct Price per quantity is {product.Price}\tProduct Shipping Duration is {product.StockDuration} ");
            }

            System.Console.WriteLine("Enter the Product ID that you want : ");
            string productId = Console.ReadLine();
            System.Console.WriteLine("Enter the quantity of product you want : ");
            int count = int.Parse(Console.ReadLine());
            foreach(ProductDetails product1 in productList)
            {
                if(productId==product1.ProductID)
                {
                    if(product1.Stock>=count)
                    {
                        double delivery = 50;
                        double totalPrice = (count*product1.Price)+delivery;
                        if(currentCustomer.WalletBalance>=totalPrice)
                        {
                            currentCustomer.WalletBalance -=totalPrice;
                            product1.Stock-=count;
                            
                            System.Console.WriteLine($"Order placed Successfully.Your Order will be delivered on {DateTime.Now.AddDays(product1.StockDuration)}.");
                            OrderDetails order3 = new OrderDetails(currentCustomer.CustomerID,product1.ProductID,totalPrice,DateTime.Now,count,OrderStatus.Ordered);
                            orderList.Add(order3);

                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient Wallet Balance.Please recharge your wallet.");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Required count is not available");
                        System.Console.WriteLine("Current Availability is "+product1.Stock);
                    }
                    
                }
            } 
        }

        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(order.CustomerID==currentCustomer.CustomerID)
                {
                    System.Console.WriteLine($"Your Order ID is {order.OrderID}\nYour Customer ID is {order.CustomerID}\nYour Product ID is {order.ProductID}\nYour Order Total Price is {order.TotalPrice}\nYour Purchase date is {order.PurchaseDate}\nYour Product Quantity is {order.Quantity}\nYour Order status is {order.OrderStatus}");
                }
            }
        }

        public static void WalletBalance()
        {
            foreach(CustomerDetails customer in customerList)
            {
                if(currentCustomer.CustomerID==customer.CustomerID)
                {
                    System.Console.WriteLine("Your Wallet Balance is "+customer.WalletBalance);
                    System.Console.WriteLine("Do you recharge the wallet ? Enter 'yes' or 'no");
                    string option = Console.ReadLine().ToLower();
                    if(option=="yes")
                    {
                        System.Console.WriteLine("Enter the amount to be recharge : ");
                        double amount = double.Parse(Console.ReadLine());
                        currentCustomer.WalletBalance+=amount;
                        System.Console.WriteLine("Your wallet balance is "+currentCustomer.WalletBalance);
                    }
                    



                }
            }
        }

        public static void CancelOrder()
        {
            foreach(OrderDetails cancel in orderList)
            {
                if(currentCustomer.CustomerID==cancel.CustomerID)
                {
                    System.Console.WriteLine($"Your Order ID is {cancel.OrderID}\nYour Customer ID is {cancel.CustomerID}\nYour Product ID is {cancel.ProductID}\nYour Order Total Price is {cancel.TotalPrice}\nYour Purchase date is {cancel.PurchaseDate}\nYour Product Quantity is {cancel.Quantity}\nYour Order status is {cancel.OrderStatus}");
                }
            }

            System.Console.WriteLine("Enter the order ID to be cancel: ");
            string orderId = Console.ReadLine();
            foreach(OrderDetails cancelOrder in orderList)
            {
                if(orderId==cancelOrder.OrderID)
                {
                    
                        foreach(ProductDetails products in productList)
                        {
                            if(cancelOrder.ProductID==products.ProductID)
                            {
                                products.Stock+=cancelOrder.Quantity;

                                double deliveryCharge = 50;
                                double returnAmount = (cancelOrder.Quantity*products.Price)-deliveryCharge;
                                currentCustomer.WalletBalance+=returnAmount;
                                System.Console.WriteLine("Order cancelled Successfully");
                                cancelOrder.OrderStatus=OrderStatus.Cancelled;
                            }
                        }
                    
                }
            }
        }

         
    }
}