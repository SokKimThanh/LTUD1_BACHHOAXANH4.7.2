public class RandomStringGenerator
{
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private HashSet<string> generatedStrings = new HashSet<string>();
    private Random random = new Random();

    public string GenerateRandomAlphanumericString(int length)
    {
        string result;
        do
        {
            result = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        } while (generatedStrings.Contains(result));

        generatedStrings.Add(result);
        return result;
    }
}

