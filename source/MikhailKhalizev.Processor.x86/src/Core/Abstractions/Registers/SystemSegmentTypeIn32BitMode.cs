namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public enum SystemSegmentTypeIn32BitMode
    {
        Tss16BitAvailable = 0b0001,
        Tss16BitBusy = 0b0011,
        Tss32BitAvailable = 0b1001,
        Tss32BitBusy = 0b1011,

        CallGate16Bit = 0b0100,
        CallGate32Bit = 0b1100,

        TrapGate16Bit = 0b0111,
        TrapGate32Bit = 0b1111,

        InterruptGate16Bit = 0b0110,
        InterruptGate32Bit = 0b1110,

        Ldt = 0b0010,
        TaskGate = 0b0101,
    }
}