using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cdca-6f49e96f")]
        public void Method_1008_cdca()
        {
            ii(0x1008_cdca, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_cdcf, 5); call(Definitions.sys_check_available_stack_size, 0xd_8f7e); /* call 0x10165d52 */
            ii(0x1008_cdd4, 1); push(ebx);                              /* push ebx */
            ii(0x1008_cdd5, 1); push(ecx);                              /* push ecx */
            ii(0x1008_cdd6, 1); push(edx);                              /* push edx */
            ii(0x1008_cdd7, 1); push(esi);                              /* push esi */
            ii(0x1008_cdd8, 1); push(edi);                              /* push edi */
            ii(0x1008_cdd9, 1); push(ebp);                              /* push ebp */
            ii(0x1008_cdda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_cddc, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_cde2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_cde5, 7); mov(memd[ss, ebp - 0x8], 0x4);          /* mov dword [ebp-0x8], 0x4 */
            ii(0x1008_cdec, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_cdef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_cdf1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_cdf2, 1); pop(edi);                               /* pop edi */
            ii(0x1008_cdf3, 1); pop(esi);                               /* pop esi */
            ii(0x1008_cdf4, 1); pop(edx);                               /* pop edx */
            ii(0x1008_cdf5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_cdf6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_cdf7, 1); ret();                                  /* ret */
        }
    }
}
