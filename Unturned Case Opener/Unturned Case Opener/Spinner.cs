using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Permissions;
using System.Web;

class Spinner
{
    public static void Main(String[] args)
    {

        Lists lists = new Lists();
        Weighted weighted = new Weighted();
        Mythicals mythicals = new Mythicals();

        List<String> rarityList = new List<String>();
        List<String> itemList = new List<String>();
        List<Double> priceList = new List<Double>();
        List<String> mythicalList = new List<String>();
        List<String> mythicalRarity = new List<String>();

        List<String> itemsSpunFinal = new List<String>();
        List<Double> pricesSpunFinal= new List<Double>();

        double casePrice = 0;
        double itemPrice = 0;
        double earnings = 0;
        int amountChosen = 0;

        Random rand = new Random();

        String caseChosen = "";

        try
        {
            Console.WriteLine("What Case Do You Want To Simulate? \n");

            int caseAmount = Directory.GetFiles($"../../txt").Length;
            caseAmount = (caseAmount - 1) / 3;

            DirectoryInfo directory = new DirectoryInfo($"../../txt/");
            FileInfo[] Files = directory.GetFiles("*_Content.txt"); //Getting Text files
            string str = "";

            int underscore = 0;
            List<String> fileList = new List<String>();

            foreach (FileInfo file in Files)
            {
                str = file.Name;
                underscore = str.IndexOf("_");
                String newString = str.Substring(0, underscore);
                fileList.Add(newString);
            }

            Console.WriteLine("Available Cases Are: \n");
            for (int i = 0; i < caseAmount; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                switch (fileList[i])
                {
                    case "A6 Polaris":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Anniversary Gift Bag":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "April 2017 Workshop Crate":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "Arid":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Arms Shipment":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Carbon Fiber":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Chrome Plated":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Dango":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Easter Island":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Elver II":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Elver":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Festive Gift Present":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "Greece":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Grocery Bag":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "Halloween Gift Present":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "Hawaii":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Hot":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "January 2017 Workshop Crate":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "July 2017 Workshop Crate":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;

                    case "Purple":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Red":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "Russia":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(fileList[i]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" Mystery Box");
                        break;

                    case "September 2017 Workshop Crate":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(fileList[i]);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\n");
            caseChosen = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Input, Input A Valid Case Name");
        }

        StreamReader readerCasePrice = new StreamReader($"../../txt/{caseChosen}_Case.txt");

        for (int i = 0; i < 1; i++)
        {
            double data = Double.Parse(readerCasePrice.ReadLine());
            casePrice = data;
        }

        try
        {
            Console.WriteLine("How Many Times? \n");
            amountChosen = Int32.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Input, Needs To Be Integer");
        }


        StreamReader readerMyths = new StreamReader($"../../txt/Mythical.txt");
        StreamReader reader = new StreamReader($"../../txt/{caseChosen}_Content.txt");
        StreamReader readerPrice = new StreamReader($"../../txt/{caseChosen}_Price.txt");
        long caseLength = lists.CountLinesReader($"../../txt/{caseChosen}_Content.txt");
        long caseLengthPrice = lists.CountLinesReader($"../../txt/{caseChosen}_Price.txt");
        int mythLength;

        lists.PopulateLists(caseLength, itemList, rarityList, reader);
        lists.PopulatePriceList(caseLengthPrice, priceList, readerPrice);
        lists.Mythicals(mythicalList, readerMyths);

        for (int i = 0; i < caseLength; i++)
        {
            String dataRarity = rarityList[i];
            String currentItem = itemList[i];
            switch (dataRarity)
            {
                case "Blue":
                    weighted.AddEntry(currentItem, 75.0);
                    break;

                case "Purp":
                    weighted.AddEntry(currentItem, 20.0);
                    break;

                case "Pink":
                    weighted.AddEntry(currentItem, 5.0);
                    break;

                case "Myth":
                    weighted.AddEntry(currentItem, 3.0);
                    break;
            }
        }

        for (int i = 0; i < amountChosen; i++)
        {
            string itemSpun = weighted.GetRandom();

            // Mythical Generation
            if (itemSpun.Equals("M"))
            {
                itemSpun = weighted.GetRandom();
                string mythicalChose = mythicals.ChooseMythical(mythicalList);
                for (int j = 0; j < caseLength; j++)
                {
                    int counter = 0;
                    string data = itemList[j];
                    if (itemSpun.Equals(data))
                    {
                        itemPrice = priceList[j];
                    }
                }

                double mythPrice = mythicals.CalculateMythicalPrice(itemPrice);
                itemSpun = "Mythical " + mythicalChose + " " + itemSpun;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You spun a Mythical Item!", Console.ForegroundColor);
                itemPrice =  mythPrice;
                Console.WriteLine($"It is worth ${itemPrice}", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            // Specifically Only Give Holiday Spirit For Christmas Cases
            if (itemSpun.Equals("C"))
            {
                itemSpun = weighted.GetRandom();
                string mythicalChose = mythicalList[9];
                for (int j = 0; j < caseLength; j++)
                {
                    int counter = 0;
                    string data = itemList[j];
                    if (itemSpun.Equals(data))
                    {
                        itemPrice = priceList[j];
                    }
                }

                double mythPrice = mythicals.CalculateMythicalPrice(itemPrice);
                itemSpun = "Mythical " + mythicalChose + " " + itemSpun;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You spun a Mythical Item!", Console.ForegroundColor);
                itemPrice = mythPrice;
                Console.WriteLine($"It is worth ${itemPrice}", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            //Specifically Only Give Confetti For Anniversary Bags
            if (itemSpun.Equals("A"))
            {
                itemSpun = weighted.GetRandom();
                string mythicalChose = mythicalList[17];
                for (int j = 0; j < caseLength; j++)
                {
                    int counter = 0;
                    string data = itemList[j];
                    if (itemSpun.Equals(data))
                    {
                        itemPrice = priceList[j];
                    }
                }

                double mythPrice = mythicals.CalculateMythicalPrice(itemPrice);
                itemSpun = "Mythical " + mythicalChose + " " + itemSpun;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You spun a Mythical Item!", Console.ForegroundColor);
                itemPrice = mythPrice;
                Console.WriteLine($"It is worth ${itemPrice}", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            // Specifically Only Give Blood Sucker For Halloween Cases
            if (itemSpun.Equals("H"))
            {
                itemSpun = weighted.GetRandom();
                string mythicalChose = mythicalList[16];
                for (int j = 0; j < caseLength; j++)
                {
                    int counter = 0;
                    string data = itemList[j];
                    if (itemSpun.Equals(data))
                    {
                        itemPrice = priceList[j];
                    }
                }

                double mythPrice = mythicals.CalculateMythicalPrice(itemPrice);
                itemSpun = "Mythical " + mythicalChose + " " + itemSpun;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You spun a Mythical Item!", Console.ForegroundColor);
                itemPrice = mythPrice;
                Console.WriteLine($"It is worth ${itemPrice}", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                for (int j = 0; j < caseLength; j++)
                {
                    int counter = 0;
                    string data = itemList[j];
                    if (itemSpun.Equals(data))
                    {
                        itemPrice = priceList[j];
                    }
                }
            }

            earnings = earnings + itemPrice;
            itemsSpunFinal.Add(itemSpun);
            pricesSpunFinal.Add(itemPrice);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Spun {itemSpun} Worth ${itemPrice}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.WriteLine("\n");
        Console.WriteLine("In Total, you spun: \n");

        var q = from x in itemsSpunFinal
                group x by x into g
                let count = g.Count()
                orderby count descending
                select new { Value = g.Key, Count = count };
        foreach (var x in q)
        {
            if (x.Value.Contains("Mythical"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(x.Count + " " + x.Value, Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        double casePriceTotal = amountChosen * casePrice;
        double profit = earnings - casePriceTotal;
        double netProfit = Math.Round(profit, 2);
        double profitPercentage = (netProfit / casePriceTotal) * 100;
        profitPercentage = Math.Round(profitPercentage, 2);
        earnings = Math.Round(earnings, 2);
        casePriceTotal = Math.Round(casePriceTotal, 2);

        Console.WriteLine("\n");
        Console.WriteLine($"You spent ${casePriceTotal} on cases");
        Console.WriteLine($"And in return, you got ${earnings} from all the items");
        Console.WriteLine("\n");
        Console.WriteLine($"In the end, you had a profit of {profitPercentage}% \n");

        Console.WriteLine($"Restart to simulate again");
        var done = Console.ReadLine();
    }
}