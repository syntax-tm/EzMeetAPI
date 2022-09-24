using Newtonsoft.Json;

namespace EzMeetAPI;

public static class Extensions
{

    public static bool EqualsIgnoreCase(this string source, string target)
    {
        if (source is null)
        {
            return target is null;
        }

        return source.Equals(target, StringComparison.InvariantCultureIgnoreCase);
    }

    public static string AsJson(this object source, bool indented = true)
    {
        var formatting = indented ? Formatting.Indented : Formatting.None;
        return JsonConvert.SerializeObject(source, formatting);
    }

}