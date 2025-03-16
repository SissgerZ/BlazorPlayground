namespace BlazorApp3;

using System.ComponentModel.DataAnnotations;

public class UniqueKeyValuePairsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IEnumerable<KeyValuePairs<string, string>> keyValuePairs)
        {
            var dictionary = new Dictionary<string, string>();

            foreach (var kvp in keyValuePairs)
            {
                if (dictionary.TryGetValue(kvp.Key, out var existingValue))
                {
                    if (existingValue == kvp.Value)
                    {
                        return new ValidationResult("Duplicate key-value pair found.");
                    }
                }
                else
                {
                    dictionary[kvp.Key] = kvp.Value;
                }
            }
        }

        return ValidationResult.Success;
    }
}
