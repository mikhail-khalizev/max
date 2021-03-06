using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bf34-40c797f3")]
        public void Method_100f_bf34()
        {
            ii(0x100f_bf34, 3);  mov(al, memb[ss, ebp - 64]);          /* mov al, [ebp-0x40] */
            ii(0x100f_bf37, 3);  mov(memb[ss, ebp - 68], al);          /* mov [ebp-0x44], al */
            ii(0x100f_bf3a, 4);  cmp(memb[ss, ebp - 68], 6);           /* cmp byte [ebp-0x44], 0x6 */
            ii(0x100f_bf3e, 2);  if(ja_func(0x100f_bf15, -0x2b)) return;/* ja 0x100fbf15 */
            ii(0x100f_bf40, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_bf42, 3);  mov(al, memb[ss, ebp - 68]);          /* mov al, [ebp-0x44] */
            ii(0x100f_bf45, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100f_bf48, 7);  jmp_abs(memd[cs, eax + 0x100f_bf18]); /* jmp dword [cs:eax+0x100fbf18] */
        }
    }
}
