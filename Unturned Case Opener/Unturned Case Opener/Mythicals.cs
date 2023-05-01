class Mythicals
{
    public string ChooseMythical(List<String> mythicalList)
    {
        Random rand = new Random();
        int mythNum = rand.Next(48);
        string mythChosen = mythicalList[mythNum];
        return mythChosen;
    }

    public double CalculateMythicalPrice(double price)
    {
        price = price + 20.00;
        return price;
    }
}

