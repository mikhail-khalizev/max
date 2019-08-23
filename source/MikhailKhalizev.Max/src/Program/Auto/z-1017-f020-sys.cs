using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_f020-96abd08")]
        public void /* sys */ Method_1017_f020()
        {
            ii(0x1017_f020, 1); push(ebx);                              /* push ebx */
            ii(0x1017_f021, 1); push(ecx);                              /* push ecx */
            ii(0x1017_f022, 1); push(edx);                              /* push edx */
            ii(0x1017_f023, 1); push(esi);                              /* push esi */
            ii(0x1017_f024, 1); push(edi);                              /* push edi */
            ii(0x1017_f025, 1); push(ebp);                              /* push ebp */
            ii(0x1017_f026, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_f028, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_f02e, 5); call(/* sys */ 0x1017_ee0a, -0x229);    /* call 0x1017ee0a */
            ii(0x1017_f033, 10); mov(memd[ds, 0x101b_e558], 0);         /* mov dword [0x101be558], 0x0 */
            ii(0x1017_f03d, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_f044, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_f047, 1); leave();                                /* leave */
            ii(0x1017_f048, 1); pop(edi);                               /* pop edi */
            ii(0x1017_f049, 1); pop(esi);                               /* pop esi */
            ii(0x1017_f04a, 1); pop(edx);                               /* pop edx */
            ii(0x1017_f04b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_f04c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_f04d, 1); ret();                                  /* ret */
        }
    }
}
