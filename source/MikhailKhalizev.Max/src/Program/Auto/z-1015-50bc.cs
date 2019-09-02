using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_50bc-7e93caef")]
        public void Method_1015_50bc()
        {
            ii(0x1015_50bc, 1); push(ebx);                              /* push ebx */
            ii(0x1015_50bd, 1); push(ecx);                              /* push ecx */
            ii(0x1015_50be, 1); push(edx);                              /* push edx */
            ii(0x1015_50bf, 1); push(esi);                              /* push esi */
            ii(0x1015_50c0, 1); push(edi);                              /* push edi */
            ii(0x1015_50c1, 1); push(ebp);                              /* push ebp */
            ii(0x1015_50c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_50c4, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1015_50ca, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1015_50d1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_50d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_50d6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_50d7, 1); pop(edi);                               /* pop edi */
            ii(0x1015_50d8, 1); pop(esi);                               /* pop esi */
            ii(0x1015_50d9, 1); pop(edx);                               /* pop edx */
            ii(0x1015_50da, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_50db, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_50dc, 1); ret();                                  /* ret */
        }
    }
}
