using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5dab-e5dbf301")]
        public void /* sys */ Method_1019_5dab()
        {
            ii(0x1019_5dab, 5);  mov(eax, 0x1020_a1f8);                /* mov eax, 0x1020a1f8 */
            ii(0x1019_5db0, 10);  mov(memd[ds, 0x1020_a204], StringDefinitions.StackDataHasBeenCorrupted);/* mov dword [0x1020a204], 0x101b3488 */
            ii(0x1019_5dba, 2);  jmp_func(0x1019_5d94, -0x28);         /* jmp 0x10195d94 */
        }
    }
}
