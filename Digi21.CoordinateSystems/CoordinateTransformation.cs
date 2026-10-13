using Digi21.Math;
using System;

namespace Digi21.CoordinateSystems
{
    public sealed class CoordinateTransformation : IDisposable
    {
        private CoordinateTransformation() { }
        ~CoordinateTransformation() { }
        public static CoordinateTransformation Create(CoordinateSystem source, CoordinateSystem target, TransformationOptions options = null) => throw null;
        public CoordinateSystem Source => throw null;
        public CoordinateSystem Target => throw null;
        public string Name => throw null;
        public string AreaOfUse => throw null;
        public int SourceDimension => throw null;
        public int TargetDimension => throw null;
        public bool IsIdentity => throw null;
        public CoordinateTransformation Inverse => throw null;
        public Point2D Transform(Point2D point) => throw null;
        public Point3D Transform(Point3D point) => throw null;
        public void Transform(Span<Point3D> points) => throw null;
        public void Transform(ReadOnlySpan<Point3D> source, Span<Point3D> destination) => throw null;
        public void Transform(Span<double> coordinates, int dimension) => throw null;
        public void Dispose() => throw null;
    }
}