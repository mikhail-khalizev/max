using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_be8a-db9fcdc1")]
        public void Method_100f_be8a()
        {
            ii(0x100f_be8a, 5);  call(0x100c_aa00, -0x3_148f);         /* call 0x100caa00 */
            ii(0x100f_be8f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_be94, 1);  push(eax);                            /* push eax */
            ii(0x100f_be95, 5);  call(0x100c_aa20, -0x3_147a);         /* call 0x100caa20 */
            ii(0x100f_be9a, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100f_be9c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_be9e, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100f_bea3, 5);  mov(eax, StringDefinitions.WarningExclusionZonesOverlapSelectAgain);/* mov eax, 0x101a28cd */
            ii(0x100f_bea8, 5);  call(0x1011_5d23, 0x1_9e76);          /* call 0x10115d23 */
            ii(0x100f_bead, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_beb1, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_beb5, 5);  jmp_func(0x100f_bf4f, 0x95);          /* jmp 0x100fbf4f */
        }
    }
}
