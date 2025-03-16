using System.ComponentModel.DataAnnotations;

namespace BlazorApp3;

public class YourViewModel
{
    [UniqueKeyValuePairs]
    public List<KeyValuePairs<string, string>> KeyValuePairs { get; set; }
}

public class KeyValuePairs<TKey, TValue>
{
    [Required]
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}