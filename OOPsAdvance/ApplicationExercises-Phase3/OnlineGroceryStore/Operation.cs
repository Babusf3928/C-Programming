using System;

namespace OnlineGroceryStore;

public delegate void EventManager();
public static class Operation
{
    public static event EventManager eventLink = null;

    public static void Subscribe()
    {
        eventLink += new EventManager(Files.Create);
        eventLink += new EventManager(Files.ReadFiles);
        eventLink += new EventManager(Operation.MainMenu);
        eventLink += new EventManager(Files.WriteToFiles);
    }

    public static void HandleEvent()
    {
        Subscribe();
        eventLink();
    }
    static CustomerDetails currentcustomer;
    public static List<CustomerDetails> customerList = new List<CustomerDetails>();

    public static List<ProductDetails> productList = new List<ProductDetails>();

    public static List<BookingDetails> bookingList = new List<BookingDetails>();

    public static List<OrderDetails> orderList = new List<OrderDetails>();
    public static void MainMenu()
    {
        string choice = "yes";
        do
        {
            System.Console.WriteLine("Select Option \n1.Customer Registration \n2.Customer Login \n3.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("You have selected Customer Registration");
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("You have selected Customer Login");
                    CustomerLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exiting MainMenu");
                    choice = "no";
                    break;
                }
            }
            
        }while(choice=="yes");
        
    }

    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Enter your name : ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter your father name : ");
        string fatherName =Console.ReadLine();
        System.Console.WriteLine("Enter your gender :");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter your Mobile Number : ");
        long mobileNumber = long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your date of birth : ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter your mail Id : ");
        string mail = Console.ReadLine();

        CustomerDetails customer = new CustomerDetails(name,fatherName,gender,mobileNumber,dob,mail,0);
        customerList.Add(customer);

        System.Console.WriteLine("Your Customer Id is "+customer.CustomerID);
        

    }

    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter your customer Id : ");
        string customerId = Console.ReadLine().ToUpper();
        int flag = 0;
        foreach(CustomerDetails customer in customerList)
        {
            if(customerId==customer.CustomerID)
            {
                flag++;
                currentcustomer=customer;
                System.Console.WriteLine("Login Successful");
                SubMenu();
                
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid Customer ID");
        }
    }

    public static void SubMenu()
    {
        string choice = "yes";
        do
        {
            System.Console.WriteLine("Select Option \n1.Show Customer Details \n2.Show Product Details \n3.Wallet Recharge \n4.Take Order \n5.Cancel Order \n6.Exit SubMenu");
            int option = int.Parse(Console.ReadLine());
        
            switch(option)
            {
                case 1:
                {
                     System.Console.WriteLine("Show Customer Details");
                     currentcustomer.ShowCustomer();
                     break;
                }
                case 2:
                {
                    System.Console.WriteLine("Show Product Details");
                    ShowProductDetails();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Wallet Recharge");
                    currentcustomer.WalletRecharge();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Take Order");
                    TakeOrder();
                    break;
                }
                
                case 5:
                {
                    System.Console.WriteLine("Cancel Order");
                    CancelOrder();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exiting SubMenu");
                    choice = "no";
                    break;
                }
            }
            
        }while(choice=="yes");

        
    }


    public static void ShowProductDetails()
    {
        foreach(ProductDetails product in productList)
        {
            System.Console.WriteLine($"ProductId is {product.ProductID}\nProductName is {product.ProductName}\nAvailable Quantity is {product.AvailableQuantity} \nPrice per Quantity is {product.PricePerQuantity}");
        }
    }

    public static void TakeOrder()
    {
        //Create booking object locally
        BookingDetails booking = new BookingDetails(currentcustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);

        //Create a local order list
        List<OrderDetails> tempOrderList = new List<OrderDetails>();
        //dowhile loop
        string choice = "";
        do
        {
            //Show Product details
            ShowProductDetails();
            //Ask the product and check its availability
            System.Console.WriteLine("Enter the Product ID to order : ");
            string order = Console.ReadLine();
            int flag = 0;
            foreach(ProductDetails product in productList)
            {
                if(product.ProductID==order)
                {
                    flag++;
                    //If avilable ask for quantity of product
                    System.Console.WriteLine("Enter the Quantity of the product that you want : ");
                    int count = int.Parse(Console.ReadLine());

                    //Check quantity with the available quantity
                    if(product.AvailableQuantity>=count)
                    {
                        //If quantity is available ,Calculate the order price and check with the balance
                        double orderPrice = 0;
                        //double totalPrice = 0;
                        orderPrice = product.PricePerQuantity*count;
                        //totalPrice +=orderPrice;
                        
                        product.AvailableQuantity-=count;
                        // Take the order and add it to temporary list 
                        OrderDetails takeOrder = new OrderDetails(booking.BookingID,product.ProductID,count,orderPrice);
                        tempOrderList.Add(takeOrder);
                        System.Console.WriteLine($"The product {product.ProductID} with the quantity of {count} is added to the cart Successfully ");
                        
                    }
                    else
                    {
                        System.Console.WriteLine("Your required quantity is not available");
                    }
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Product is not available for this product Id");
            }
            System.Console.WriteLine("Do you want to order more ? Enter 'yes' or 'no' : ");
            choice = Console.ReadLine();
            
        }while(choice == "yes");

        double totalPrice = 0;
        foreach(OrderDetails orders in tempOrderList)
        {
            totalPrice += orders.PriceOfOrder;
        }
        
        System.Console.WriteLine("Do you want to book the orders : Enter 'yes' or 'no'");
        string opinion = Console.ReadLine().ToLower();
        if(opinion == "yes")
        {
            string proceed = "yes";
            while(proceed=="yes")
            {
                if(currentcustomer.WalletBalance >=totalPrice)
                {
                    currentcustomer.WalletBalance-=totalPrice;
                    booking.TotalPrice=totalPrice;
                    booking.BookingStatus=BookingStatus.Booked;
                    bookingList.Add(booking);
                    System.Console.WriteLine("Booking booked successfully and your Booking ID is "+booking.BookingID);
                    orderList.AddRange(tempOrderList);
                    proceed="no";
                }
                else
                {
                    currentcustomer.WalletRecharge();
                }
            }
        }
        else
        {
            foreach(OrderDetails orders in tempOrderList)
            {
                foreach(ProductDetails products in productList)
                {
                    if(orders.ProductId==products.ProductID)
                    {
                        products.AvailableQuantity+=orders.PurchaseCount;
                        System.Console.WriteLine("Your cart has been removed Successfully");
                    }
                }
            }
        }                    
                    
    }


    public static void CancelOrder()
    {
        int flag =0;
        foreach(BookingDetails bookings in bookingList)
        {
            if(currentcustomer.CustomerID==bookings.CustomerId && bookings.BookingStatus==BookingStatus.Booked)
            {
                flag++;
                System.Console.WriteLine($"Booking ID is {bookings.BookingID}\nCustomer ID is {bookings.CustomerId}\nTotal Price is {bookings.TotalPrice}\nDate Of Booking is {bookings.DateOfBooking.ToString("dd/MM/yyyy")}\nBooking Status is {bookings.BookingStatus}");
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("There are no bookings are booked for you ");
        }
        else
        {
            System.Console.WriteLine("Enter the booking Id to cancel : ");
            string bookingId = Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                if(bookingId==booking.BookingID)
                {
                    booking.BookingStatus=BookingStatus.Cancelled;
                    currentcustomer.WalletBalance+=booking.TotalPrice;
                    foreach(OrderDetails orders in orderList)
                    {
                        foreach(ProductDetails product in productList)
                        {
                            if(booking.BookingID==orders.BookingId)
                            {
                                if(product.ProductID==orders.ProductId)
                                {
                                    product.AvailableQuantity+=orders.PurchaseCount;
                                }
                            }
                        }
                    }
                }
            }

            System.Console.WriteLine("Booking Cancelled Successfully");
        }

        
        
    }
}