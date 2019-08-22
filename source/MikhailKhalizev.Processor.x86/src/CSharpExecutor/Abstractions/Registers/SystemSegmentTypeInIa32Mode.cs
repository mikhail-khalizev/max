namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public enum SystemSegmentTypeInIa32Mode
    {
        Tss64BitAvailable = 0b1001,
        Tss64BitBusy = 0b1011,
        
        Ldt = 0b0010,
        CallGate64Bit = 0b1100,
        InterruptGate64Bit = 0b1110,
        TrapGate64Bit = 0b1111,
    }
}