using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    public interface IDistanceRelaxer 
        : IComparer<double>
    {
        double InitialDistance { get;}
        double Combine(double distance, double weight);
    }
}
