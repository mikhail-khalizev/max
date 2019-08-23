using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_83a8-c502b1ca")]
        public void Method_100b_83a8()
        {
            ii(0x100b_83a8, 1); push(ebx);                              /* push ebx */
            ii(0x100b_83a9, 1); push(ecx);                              /* push ecx */
            ii(0x100b_83aa, 1); push(edx);                              /* push edx */
            ii(0x100b_83ab, 1); push(esi);                              /* push esi */
            ii(0x100b_83ac, 1); push(edi);                              /* push edi */
            ii(0x100b_83ad, 1); push(ebp);                              /* push ebp */
            ii(0x100b_83ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_83b0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_83b6, 7); mov(memd[ss, ebp - 0x4], 0x5);          /* mov dword [ebp-0x4], 0x5 */
            ii(0x100b_83bd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_83c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_83c2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_83c3, 1); pop(edi);                               /* pop edi */
            ii(0x100b_83c4, 1); pop(esi);                               /* pop esi */
            ii(0x100b_83c5, 1); pop(edx);                               /* pop edx */
            ii(0x100b_83c6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_83c7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_83c8, 1); ret();                                  /* ret */
        }
    }
}
