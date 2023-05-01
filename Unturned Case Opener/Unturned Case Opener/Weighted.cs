﻿class Weighted
{
    private struct Entry
    {
        public double accumulatedWeight;
        public string item;
    }

    private List<Entry> entries = new List<Entry>();
    private double accumulatedWeight;
    private Random rand = new Random();

    public void AddEntry(string item, double weight)
    {
        accumulatedWeight += weight;
        entries.Add(new Entry { item = item, accumulatedWeight = accumulatedWeight });
    }

    public string GetRandom()
    {
        double r = rand.NextDouble() * accumulatedWeight;

        foreach (Entry entry in entries)
        {
            if (entry.accumulatedWeight >= r)
            {
                return entry.item;
            }
        }
        return default(string); //should only happen when there are no entries
    }
}