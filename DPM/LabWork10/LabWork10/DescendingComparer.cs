class DescendingComparer : IComparer<int>
{
    public int Compare(int value1, int value2)
    {
        return -value1.CompareTo(value2);
    }
}

