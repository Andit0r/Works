using System.Security.Cryptography;
string[] files = Directory.GetFiles("Y:\\МДК.01.01");
foreach (var file in files)
    Console.WriteLine($"{await GetHashAsync(file)}");

static async Task<string> GetHashAsync(string fileName)
{
    return await Task.Run(() => $"{fileName} : {CalculateHash(File.ReadAllBytes(fileName))}"); ;
}

static string CalculateHash(byte[] data)
{
    using var sha256 = SHA256.Create();
    return Convert.ToHexString(sha256.ComputeHash(data));
}