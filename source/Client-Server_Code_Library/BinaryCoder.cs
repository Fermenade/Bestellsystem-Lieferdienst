using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Client_Server_Code_Library;

public static class BinaryCoder
{

    public static string BinaryDecoder(byte[] data)
    {
        return Encoding.UTF8.GetString(data);
    }

    public static byte[] BinaryEncoder(string data)
    {
        return Encoding.UTF8.GetBytes(data);
    }
}
public static class JsonSerialize
{
    public static string Serialize(object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public static T Deserialize<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json)??throw new Exception("Deserialization failed, wrong format");
    }

    static string SerializeException(Exception ex)
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, ex);
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }

    static Exception DeserializeException(string exceptionString)
    {
        byte[] bytes = Convert.FromBase64String(exceptionString);
        using (MemoryStream memoryStream = new MemoryStream(bytes))
        {
            IFormatter formatter = new BinaryFormatter();
            return (Exception)formatter.Deserialize(memoryStream);
        }
    }
}