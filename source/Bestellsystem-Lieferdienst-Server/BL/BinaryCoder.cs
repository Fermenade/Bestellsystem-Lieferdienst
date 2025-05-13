using System.Text;
using Newtonsoft.Json;

namespace Bestellsystem_Lieferdienst_server.BL;

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
}