class Lists
{
    public List<String> Mythicals(List<String> mythicalList, StreamReader readerMyths)
    {
        for (int i = 0; i < 48; i++)
        {
            string data = readerMyths.ReadLine();
            mythicalList.Add(data);
        }
        return mythicalList;
    }

    public long CountLinesReader(string filePath)
    {
        var lineCounter = 0;
        using (StreamReader reader = new(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCounter++;
            }
            return lineCounter;
        }
    }
    public List<String> PopulateLists(long caseLength,  List<String> itemList, List<String> rarityList, StreamReader reader)
    {
        for (int i = 0; i < caseLength; i++)
        {
            String data = reader.ReadLine();
            String rarity = data.Substring(0, 4);
            String itemName = data.Substring(5);
            itemList.Add(itemName);
            rarityList.Add(rarity);
            

        }
        return itemList;
        return rarityList;
        
    }

    public List<Double> PopulatePriceList(long caseLengthPrice, List<double> priceList, StreamReader readerPrice)
    {
        for (int i = 0; i < caseLengthPrice; i++)
        {
            double price = double.Parse(readerPrice.ReadLine());
            priceList.Add(price);
        }

        return priceList;
    }
}
