using System.Reflection.Metadata.Ecma335;

class StringComparer : IComparer<string>
{
    public int Compare(string? word1, string? word2)
    {
        if (word1 == null && word2 == null) 
            return 0;
        if (word1 == null) 
            return -1; 
        if (word2 == null) 
            return 1;

        return word1[0].CompareTo(word2[0]);
    }
}
