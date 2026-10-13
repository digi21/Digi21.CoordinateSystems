using System.Collections.Generic;

namespace Digi21.CoordinateSystems
{
    public delegate int SelectCoordinateOperation(string sourceName, string targetName, IReadOnlyList<CoordinateOperation> operations);

    public delegate VerticalTransformation CreateVerticalTransformation(string sourceName, string targetName);
}