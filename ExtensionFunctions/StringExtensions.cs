using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace ExtensionFunctions;

public static class StringExtensions
{
    public static bool IsNumber(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        foreach (char c in str)
        {
            if (!char.IsNumber(c)) return false;
        }
        return true;
    }
    public static bool IsDate(this string str)
    {
        string[] formats = { "yyyy-MM-dd", "MM/dd/yyyy", "dd/MM/yyyy", "yyyy/MM/dd" };

        DateTime result;
        return DateTime.TryParseExact(str, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result);
    }

    public static string[] ToWords(this string str)
    {
        string[] words = str.Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return words;
    }

    public static string CalculateHash(this string str)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            builder.Append(hashBytes[i].ToString("x2"));
        }
        return builder.ToString();
    }

    public static void SaveToFile(this string str, string filePath)
    {
        using (FileStream fs = File.Create(filePath))
        {
            string content = str;
            byte[] contentBytes = Encoding.UTF8.GetBytes(content);

            fs.Write(contentBytes, 0, contentBytes.Length);
        }

    }
}