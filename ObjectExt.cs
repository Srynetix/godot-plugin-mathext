using Newtonsoft.Json;

public static class ObjectExt {
    public static string ToJson(this object obj) {
        return JsonConvert.SerializeObject(obj);
    }

    public static T FromJson<T>(string data) {
        return JsonConvert.DeserializeObject<T>(data);
    }
}