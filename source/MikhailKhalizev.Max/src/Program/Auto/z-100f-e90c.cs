using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e90c-e1262055")]
        public void Method_100f_e90c()
        {
            ii(0x100f_e90c, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100f_e90f, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
            ii(0x100f_e912, 4);  cmp(memb[ss, ebp - 24], 4);           /* cmp byte [ebp-0x18], 0x4 */
            ii(0x100f_e916, 2);  if(ja_func(0x100f_e8f6, -0x22)) return;/* ja 0x100fe8f6 */
            ii(0x100f_e918, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_e91a, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x100f_e91d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100f_e920, 7);  jmp_abs(memd[cs, eax + 0x100f_e8f8]); /* jmp dword [cs:eax+0x100fe8f8] */
        }
    }
}
