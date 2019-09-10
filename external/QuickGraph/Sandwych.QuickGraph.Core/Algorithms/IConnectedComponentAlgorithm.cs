using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    public interface IConnectedComponentAlgorithm<TVertex,TEdge,TGraph> : IAlgorithm<TGraph>
        where TGraph : IGraph<TVertex,TEdge>
        where TEdge : IEdge<TVertex>
    {
        int ComponentCount { get;}
        IDictionary<TVertex, int> Components { get;}
    }
}
