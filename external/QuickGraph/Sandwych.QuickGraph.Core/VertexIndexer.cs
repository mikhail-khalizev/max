using System.Diagnostics.Contracts;

namespace QuickGraph
{
    [Pure]
    public delegate int VertexIndexer<TVertex>(TVertex v);
}
