using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_84f4-318a0743")]
        public void Method_100e_84f4()
        {
            ii(0x100e_84f4, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_84f9, 5); call(Definitions.sys_check_available_stack_size, 0x7_d854); /* call 0x10165d52 */
            ii(0x100e_84fe, 1); push(ebx);                              /* push ebx */
            ii(0x100e_84ff, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8500, 1); push(esi);                              /* push esi */
            ii(0x100e_8501, 1); push(edi);                              /* push edi */
            ii(0x100e_8502, 1); push(ebp);                              /* push ebp */
            ii(0x100e_8503, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8505, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_850b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_850e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_8511, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_8514, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100e_8516, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_8519, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_851c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_851f, 5); call(0x100e_852c, 8);                   /* call 0x100e852c */
            ii(0x100e_8524, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8526, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8527, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8528, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8529, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_852a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_852b, 1); ret();                                  /* ret */
        }
    }
}
