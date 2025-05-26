using SmartRide.Models;

public class SearchingDriverViewModel
{
    public RideRequest Request { get; set; }
    public bool IsDriverFound { get; set; }
    public int RefreshInterval { get; set; } = 5; // Refresh every 5 seconds
}