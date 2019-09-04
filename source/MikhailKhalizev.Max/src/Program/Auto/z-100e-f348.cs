using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f348-3c464e9d")]
        public void Method_100e_f348()
        {
            ii(0x100e_f348, 1); push(ebx);                              /* push ebx */
            ii(0x100e_f349, 1); push(ecx);                              /* push ecx */
            ii(0x100e_f34a, 1); push(edx);                              /* push edx */
            ii(0x100e_f34b, 1); push(esi);                              /* push esi */
            ii(0x100e_f34c, 1); push(edi);                              /* push edi */
            ii(0x100e_f34d, 1); push(ebp);                              /* push ebp */
            ii(0x100e_f34e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f350, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_f356, 7); mov(memd[ss, ebp - 4], 0x32);           /* mov dword [ebp-0x4], 0x32 */
            ii(0x100e_f35d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_f360, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f362, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_f363, 1); pop(edi);                               /* pop edi */
            ii(0x100e_f364, 1); pop(esi);                               /* pop esi */
            ii(0x100e_f365, 1); pop(edx);                               /* pop edx */
            ii(0x100e_f366, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_f367, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_f368, 1); ret();                                  /* ret */
        }
    }
}
