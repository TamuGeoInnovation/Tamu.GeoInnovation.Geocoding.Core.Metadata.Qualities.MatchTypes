namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{
    public enum MatchedLocationTypes
    {
        Unmatchable = 0,
        Unknown = 2,
        StreetAddress = 4,
        PostOfficeBox = 8,
        RuralRoute = 16,
        StarRoute = 32,
        HighwayContractRoute = 64,
        Intersection = 128,
        NamedPlace = 256,
        RelativeDirection = 512,
        USPSZIP = 1024,
        City = 2048,
        State = 4096

    }


}
