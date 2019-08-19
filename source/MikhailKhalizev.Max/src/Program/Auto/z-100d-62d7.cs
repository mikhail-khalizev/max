using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_62d7-d9d98394")]
        public void Method_100d_62d7()
        {
            ii(0x100d_62d7, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x100d_62db, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100d_62de, 6); if(jged_func(0x100d_66a4, 0x3c0)) return; /* jge 0x100d66a4 */
            ii(0x100d_62e4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_62e7, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100d_62ea, 4); mov(memb_a32[ss, ebp - 0x40], 0);       /* mov byte [ebp-0x40], 0x0 */
            ii(0x100d_62ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_62f1, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_62f4, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_62f7, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_62fa, 5); if(jmpd_func(0x100d_6524, 0x225)) return; /* jmp 0x100d6524 */
        }
    }
}
