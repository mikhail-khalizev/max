using System;

namespace QuickGraph.Algorithms
{
    public delegate void AlgorithmEventHandler<TGraph>(
        IAlgorithm<TGraph> sender,
        EventArgs e);
}
