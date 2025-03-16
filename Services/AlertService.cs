using BlazorBootstrap;

namespace BlazorApp3.Services;

public class AlertService
{
    public event Action? OnCalloutChanged;
    private AlertOption? AlertOption { get; set; } = default!;

    public void Show(AlertOption option)
    {
        AlertOption = option;

        OnCalloutChanged?.Invoke();
    }

    public void Dismiss(AlertOption option)
    {
        AlertOption = default;
    }

    public AlertOption? GetCurrentAlertOrDefault() => AlertOption ?? default;
}

public class AlertOption
{
    public string Message { get; set; } = string.Empty;
    public AlertColor Color { get; set; } = AlertColor.Primary;
    public bool Dismissible { get; set; } = false;
    public IconName IconName { get; set; } = default;
}
