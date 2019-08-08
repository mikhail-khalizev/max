using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d43b03dc-5107-4eda-b753-0a46ba8336b8")]
        public void Method_1012_85cc()
        {
            ii(0x1012_85cc, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1012_85cf, 6); mov(memb_a32[ss, ebp - 0xac], al);      /* mov [ebp-0xac], al */
            ii(0x1012_85d5, 7); cmp(memb_a32[ss, ebp - 0xac], 0x34);    /* cmp byte [ebp-0xac], 0x34 */
            ii(0x1012_85dc, 6); if(jad_func(0x1012_84f0, -0xf2)) return; /* ja 0x101284f0 */
            ii(0x1012_85e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_85e4, 6); mov(al, memb_a32[ss, ebp - 0xac]);      /* mov al, [ebp-0xac] */
            ii(0x1012_85ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_85ed, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_84f8])) return; /* jmp dword [cs:eax+0x101284f8] */
        }
    }
}
