namespace Digi21.CoordinateSystems
{
    public sealed class CoordinateSystem
    {
        private CoordinateSystem() { }
        ~CoordinateSystem() { }
        public static CoordinateSystem FromEpsg(int code) => throw null;
        public static CoordinateSystem FromEpsg(int horizontal, int vertical) => throw null;
        public static CoordinateSystem FromWkt(string wkt) => throw null;
        public static CoordinateSystem Parse(string text) => throw null;
        public CoordinateSystem WithEastNorthAxes() => throw null;
        public string Wkt => throw null;
        public string Name => throw null;
        public string Authority => throw null;
        public int? AuthorityCode => throw null;
        public int Dimension => throw null;
        public bool IsLocal => throw null;
        public (int Horizontal, int Vertical) EpsgCodes => throw null;
    }
}