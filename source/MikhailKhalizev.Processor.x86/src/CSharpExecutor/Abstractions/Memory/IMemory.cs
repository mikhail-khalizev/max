namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public interface IMemory : IRandomAccess
    {
        int Size { get; }
    }
}