using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69977654-dc0c-4410-ab34-7cbd79a922f0")]
        public void Method_1008_db38()
        {
            ii(0x1008_db38, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_db3b, 2); sub(al, 0x5);                           /* sub al, 0x5 */
            ii(0x1008_db3d, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1008_db40, 4); cmp(memb_a32[ss, ebp - 0x18], 0x6);     /* cmp byte [ebp-0x18], 0x6 */
            ii(0x1008_db44, 2); if(jad_func(0x1008_daf9, -0x4d)) return; /* ja 0x1008daf9 */
            ii(0x1008_db46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_db48, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1008_db4b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_db4e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1008_db1c])) return; /* jmp dword [cs:eax+0x1008db1c] */
        }
    }
}
