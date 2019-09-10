namespace QuickGraph
{
    public delegate string EdgeIdentity<TVertex, TEdge>(TEdge edge)
        where TEdge : IEdge<TVertex>;
}
