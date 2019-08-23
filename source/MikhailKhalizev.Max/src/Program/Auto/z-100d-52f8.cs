using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_52f8-7e93caef")]
        public void Method_100d_52f8()
        {
            ii(0x100d_52f8, 1); push(ebx);                              /* push ebx */
            ii(0x100d_52f9, 1); push(ecx);                              /* push ecx */
            ii(0x100d_52fa, 1); push(edx);                              /* push edx */
            ii(0x100d_52fb, 1); push(esi);                              /* push esi */
            ii(0x100d_52fc, 1); push(edi);                              /* push edi */
            ii(0x100d_52fd, 1); push(ebp);                              /* push ebp */
            ii(0x100d_52fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5300, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_5306, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100d_530d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5310, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5312, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_5313, 1); pop(edi);                               /* pop edi */
            ii(0x100d_5314, 1); pop(esi);                               /* pop esi */
            ii(0x100d_5315, 1); pop(edx);                               /* pop edx */
            ii(0x100d_5316, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_5317, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_5318, 1); ret();                                  /* ret */
        }
    }
}
