namespace PracticeTracker.Tools.Utils;

public static class ByteArrayTools
{
    public static String ByteArrayToString(Byte[] bytes)
    {
        String hex = BitConverter.ToString(bytes);
        return hex.Replace("-", "");
    }
}