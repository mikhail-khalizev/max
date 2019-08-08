using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c541060-3d1c-4a27-9769-2bd19becd9a9")]
        public void Method_1013_353c()
        {
            ii(0x1013_353c, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1013_353f, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x1013_3542, 4); cmp(memb_a32[ss, ebp - 0x40], 0x7);     /* cmp byte [ebp-0x40], 0x7 */
            ii(0x1013_3546, 2); if(jad_func(0x1013_3517, -0x31)) return; /* ja 0x10133517 */
            ii(0x1013_3548, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_354a, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1013_354d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_3550, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1013_351c])) return; /* jmp dword [cs:eax+0x1013351c] */
        }
    }
}
