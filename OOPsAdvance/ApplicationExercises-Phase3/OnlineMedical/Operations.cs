using System;


namespace OnlineMedical
{
    public static class Operations
    {
        public static UserDetails currentUser = null;
        public static List<UserDetails> userList = new List<UserDetails>();

        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();

        public static List<OrderDetails> orderList = new List<OrderDetails>();

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.User Registration 2.User Login 3.Order History 4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your age : ");
            int age =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city : ");
            string city = Console.ReadLine();
            System.Console.WriteLine("Enter your phone number : ");
            long phoneNumber = long.Parse(Console.ReadLine());

            UserDetails user1 = new UserDetails(name,age,city,phoneNumber);
            userList.Add(user1);

            System.Console.WriteLine("Your Registeration ID is :"+user1.UserID);
            
        }

        public static void UserLogin()
        {
            System.Console.WriteLine("Enter your Register Id : ");
            string registerId = Console.ReadLine();
            int flag =0;
            foreach(UserDetails person in userList)
            {
                if(registerId==person.UserID)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=person;
                    SubMenu();
                    flag++;

                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid User Id");
            }
        }

        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                System.Console.WriteLine($"Order ID is {order.OrderID}\tUser ID is {order.UserId}\tMedicine ID is {order.MedicineId}\tMedicine Count is {order.MedicineCount}\tTotal Price is {order.TotalPrice}\tOrder Date is {order.OrderDate.ToString("dd/MM/yyyy")}\tOrder Status is {order.OrderStatus}");
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Show Medicine List 2.Purchase Medicine 3.Cancel Purchase 4.Show Purchase History 5.Recharge 6.Exit SubMenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Medicine List");
                        ShowMedicineList();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Purchase Medicine");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Purchase");
                        CancelPurchase();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Show Purchase History");
                        ShowPurchaseHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge");
                        Recharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice = "no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void ShowMedicineList()
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"Medicine Id is {medicine.MedicineID}\tMedicine Name is {medicine.MedicineName}\tAvailable count is {medicine.AvailableCount}\tPrice is {medicine.Price}\tDate of Expiry is {medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            }

        }


        public static void PurchaseMedicine()
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"Medicine Id is {medicine.MedicineID}\tMedicine Name is {medicine.MedicineName}\tAvailable count is {medicine.AvailableCount}\tPrice is {medicine.Price}\tDate of Expiry is {medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            }

            System.Console.WriteLine("Enter the Medicine ID that you want to buy : ");
            string medicineId = Console.ReadLine();
            System.Console.WriteLine("Enter the count of medicine that you want : ");
            int count = int.Parse(Console.ReadLine());

            int flag = 0;
            foreach(MedicineDetails medicine1 in medicineList)
            {
                if(medicine1.MedicineID==medicineId && medicine1.AvailableCount>=count)
                {
                    flag++;
                    double totalPrice = count*(medicine1.Price);
                    if(currentUser.Balance>=totalPrice)
                    {
                        if(medicine1.DateOfExpiry>DateTime.Now.AddDays(2))
                        {
                            medicine1.AvailableCount-=count;
                            currentUser.Balance-=totalPrice;
                            OrderDetails order1 = new OrderDetails(currentUser.UserID,medicine1.MedicineID,count,totalPrice,DateTime.Now,OrderStatus.Purchased);
                            orderList.Add(order1);
                            System.Console.WriteLine("Medicine was purchased Successfully");
                        }
                        else
                        {
                            System.Console.WriteLine("The medicine has expired");
                        }
                    }
                }
                
            }
            if(flag==0)
            {
                System.Console.WriteLine("The medicine that you have choosed is unavailable");
            }


        }

        public static void CancelPurchase()
        {
            foreach(OrderDetails orders in orderList)
            {
                if(currentUser.UserID==orders.UserId && orders.OrderStatus==OrderStatus.Purchased)
                {
                    System.Console.WriteLine($"Order ID is {orders.OrderID}\t User ID is {orders.UserId}\t Medicine ID is {orders.MedicineId}\tMedicine Count is {orders.MedicineCount}\tTotal Price is {orders.TotalPrice}\tOrder Date is {orders.OrderDate}\tOrder Status is {orders.OrderStatus}");
                    
                }

            }

            System.Console.WriteLine("Enter the Order ID to cancel : ");
            string cancel = Console.ReadLine();
            foreach(OrderDetails orders in orderList)
            {
                if(cancel==orders.OrderID && orders.OrderStatus==OrderStatus.Purchased)
                {
                    foreach(MedicineDetails medicines in medicineList)
                    {
                        if(orders.MedicineId==medicines.MedicineID)
                        {
                            medicines.AvailableCount+=orders.MedicineCount;
                        }
                    }
                    currentUser.Balance+=orders.TotalPrice;
                    orders.OrderStatus=OrderStatus.Cancelled;

                    System.Console.WriteLine($"Order ID {orders.OrderID} is cancelled Successfully");
                }        
            }
        }    

        public static void ShowPurchaseHistory()
        {
            foreach(OrderDetails history in orderList)
            {
                if(currentUser.UserID==history.OrderID)
                {
                    System.Console.WriteLine($"Order ID is {history.OrderID}\t User ID is {history.UserId}\t Medicine ID is {history.MedicineId}\tMedicine Count is {history.MedicineCount}\tTotal Price is {history.TotalPrice}\tOrder Date is {history.OrderDate}\tOrder Status is {history.OrderStatus}");
                }
            }
        }

        public static void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            currentUser.Balance+=amount;
            System.Console.WriteLine("Recharge Successfull");
        }

        
    }
}