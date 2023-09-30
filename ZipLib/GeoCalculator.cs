

public static class GeoCalculator
{
    private const double EarthRadiusKm = 6371.0;

    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        // Convert latitude and longitude from degrees to radians
        lat1 = DegreesToRadians(lat1);
        lon1 = DegreesToRadians(lon1);
        lat2 = DegreesToRadians(lat2);
        lon2 = DegreesToRadians(lon2);

        // Haversine formula
        double dlon = lon2 - lon1;
        double dlat = lat2 - lat1;
        double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Pow(Math.Sin(dlon / 2), 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        // Distance in kilometers
        return (EarthRadiusKm * c) * 0.621371192;
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180;
    }
}
