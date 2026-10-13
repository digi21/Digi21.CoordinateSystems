using System;

namespace Digi21.CoordinateSystems
{
    public class CoordinateSystemException : Exception
    {
        public CoordinateSystemException() => throw null;
        public CoordinateSystemException(string message) => throw null;
        public CoordinateSystemException(string message, Exception innerException) => throw null;
    }

    public sealed class TransformationNotFoundException : CoordinateSystemException
    {
        public TransformationNotFoundException() => throw null;
        public TransformationNotFoundException(string message) => throw null;
        public TransformationNotFoundException(string message, Exception innerException) => throw null;
    }
}