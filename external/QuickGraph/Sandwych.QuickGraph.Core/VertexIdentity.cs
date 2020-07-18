using System.Diagnostics.Contracts;

namespace QuickGraph
{
    [Pure]
    public delegate string VertexIdentity<TVertex>(TVertex v);
}
