using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea_Management
{
    class Receipt
    {
        public double totalPrice = 0;
        public string Bill = "";
        public string Descripton = "";
        BaseMilkTea myMilkTea = new Default();
        
        public void priceMilkTea()
        {
            int selected;
            BaseMilkTea myTraditionalMilkTea = new Traditional_MilkTea();
            BaseMilkTea myChocolateMilkTea = new Chocolate_MilkTea();
            BaseMilkTea myMatchaMilkTea = new Matcha_MilkTea();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" WELCOME TO SELINA MILK TEA SHOP!");
            Console.WriteLine(" --------------------------------");
            Console.ResetColor();
            Console.WriteLine(" Please select your milk tea type:");
            Console.WriteLine($" [1] \t{myTraditionalMilkTea.getDescription()}: \t\t${myTraditionalMilkTea.Price()}");
            Console.WriteLine($" [2] \t{myChocolateMilkTea.getDescription()}: \t\t${myChocolateMilkTea.Price()}");
            Console.WriteLine($" [3] \t{myMatchaMilkTea.getDescription()}: \t\t${myMatchaMilkTea.Price()}");
            Console.Write(" [");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine("]");
            System.Threading.Thread.Sleep(1200);
            Console.Write(" Your choice is: ");
            selected = Convert.ToInt32(Console.ReadLine());
            if (selected > 3 || selected < 1)
            {
                Console.WriteLine(" Please select a valid milk tea type.");
                priceMilkTea();
            }
            else
            {
                switch (selected)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", myTraditionalMilkTea.getDescription(), myTraditionalMilkTea.Price());
                        Console.ResetColor();
                        totalPrice += myTraditionalMilkTea.Price();
                        myMilkTea = myTraditionalMilkTea;
                        priceTopping();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", myChocolateMilkTea.getDescription(), myChocolateMilkTea.Price());
                        Console.ResetColor();
                        totalPrice += myChocolateMilkTea.Price();
                        myMilkTea = myChocolateMilkTea;
                        priceTopping();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", myMatchaMilkTea.getDescription(), myMatchaMilkTea.Price());
                        Console.ResetColor();
                        totalPrice += myMatchaMilkTea.Price();
                        myMilkTea = myMatchaMilkTea;
                        priceTopping();
                        break;
                }
            }
        }

        public void priceTopping()
        {
            int selected;
            BaseMilkTea pudding = new Pudding(myMilkTea);
            BaseMilkTea blackPearl = new BlackPearl(myMilkTea);
            BaseMilkTea flan = new Flan(myMilkTea);
            Console.WriteLine(" Please select your milk tea topping:");
            Console.WriteLine($" [1] Pudding: \t\t\t${pudding.Price()}");
            Console.WriteLine($" [2] Black Pearl: \t\t${blackPearl.Price()}");
            Console.WriteLine($" [3] Flan: \t\t\t${flan.Price()}");
            Console.Write(" [");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine("]");
            System.Threading.Thread.Sleep(1200);
            Console.Write(" Your choice is: ");
            selected = Convert.ToInt32(Console.ReadLine());
            if (selected > 3 || selected < 1)
            {
                Console.WriteLine(" Please select a valid milk tea topping.");
                priceTopping();
            }
            else
            {
                switch (selected)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", pudding.getDescription(), pudding.Price());
                        Console.ResetColor();
                        totalPrice += pudding.Price();
                        Bill += $"\n Order: {pudding.getDescription()}";
                        writeMessage();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", blackPearl.getDescription(), blackPearl.Price());
                        Console.ResetColor();
                        totalPrice += blackPearl.Price();
                        Bill += $"\n Order: {blackPearl.getDescription()}";
                        writeMessage();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected - Price: ${1}", flan.getDescription(), flan.Price());
                        Console.ResetColor();
                        totalPrice += flan.Price();
                        Bill += $"\n Order: {flan.getDescription()}";
                        writeMessage();
                        break;
                }
            }
        }

        public void writeMessage()
        {
            int selected;
            Console.WriteLine(" Please select your milk tea message:");
            Console.WriteLine(" [1] Add Sugar");
            Console.WriteLine(" [2] Add Ice");
            Console.WriteLine(" [3] Add Milk");
            Console.WriteLine(" [4] None");
            Console.Write(" [");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine("]");
            System.Threading.Thread.Sleep(1200);
            Console.Write(" Your choice is: ");
            selected = Convert.ToInt32(Console.ReadLine());
            if (selected > 3 || selected < 1)
            {
                if (selected == 4)
                {
                    Descripton += $"No message added.";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\nTotal Bill: \n{Bill}");
                    Console.WriteLine($"\n Descripton: {Descripton}");
                    Console.WriteLine($"\n Total Price: ${totalPrice}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(" Please select a valid milk tea message.");
                    writeMessage();
                }
            }
            else
            {
                switch (selected)
                {
                    case 1:
                        var note1 = new AddSugar();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected", note1.GetMessage());
                        Console.ResetColor();
                        Descripton += $"{note1.GetMessage()}";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n TOTAL BILL: \n{Bill}");
                        Console.WriteLine($"\n Descripton: {Descripton}");
                        Console.WriteLine($"\n Total Price: ${totalPrice}");
                        break;

                    case 2:
                        var note2 = new AddIce();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected", note2.GetMessage());
                        Console.ResetColor();
                        Descripton += $"{note2.GetMessage()}";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n TOTAL BILL: \n{Bill}");
                        Console.WriteLine($"\n Descripton: {Descripton}");
                        Console.WriteLine($"\n Total Price: ${totalPrice}");
                        break;

                    case 3:
                        var note3 = new AddMilk();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} selected", note3.GetMessage());
                        Console.ResetColor();
                        Descripton += $"{note3.GetMessage()}";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n TOTAL BILL: \n{Bill}");
                        Console.WriteLine($"\n Descripton: {Descripton}");
                        Console.WriteLine($"\n Total Price: ${totalPrice}");
                        break;
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n [THANK YOU FOR SHOPPING. SEE YOU LATER!]");
            }
        }
    }
}
