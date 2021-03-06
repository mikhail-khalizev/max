using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a740-b8e2bc05")]
        public void Method_100f_a740()
        {
            ii(0x100f_a740, 3);  mov(al, memb[ss, ebp - 100]);         /* mov al, [ebp-0x64] */
            ii(0x100f_a743, 2);  sub(al, 0xc);                         /* sub al, 0xc */
            ii(0x100f_a745, 3);  mov(memb[ss, ebp - 124], al);         /* mov [ebp-0x7c], al */
            ii(0x100f_a748, 4);  cmp(memb[ss, ebp - 124], 0xf);        /* cmp byte [ebp-0x7c], 0xf */
            ii(0x100f_a74c, 2);  if(ja_func(0x100f_a6fc, -0x52)) return;/* ja 0x100fa6fc */
            ii(0x100f_a74e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_a750, 3);  mov(al, memb[ss, ebp - 124]);         /* mov al, [ebp-0x7c] */
            ii(0x100f_a753, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100f_a756, 7);  jmp_abs(memd[cs, eax + 0x100f_a700]); /* jmp dword [cs:eax+0x100fa700] */
        }
    }
}
