using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_23d8-1f1940b1")]
        public void my_string_compute_capacity_from_length()
        {
            ii(0x1014_23d8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_23dd, 5); call(Definitions.sys_check_available_stack_size, 0x2_3970); /* call 0x10165d52 */
            ii(0x1014_23e2, 1); push(ebx);                              /* push ebx */
            ii(0x1014_23e3, 1); push(ecx);                              /* push ecx */
            ii(0x1014_23e4, 1); push(edx);                              /* push edx */
            ii(0x1014_23e5, 1); push(esi);                              /* push esi */
            ii(0x1014_23e6, 1); push(edi);                              /* push edi */
            ii(0x1014_23e7, 1); push(ebp);                              /* push ebp */
            ii(0x1014_23e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_23ea, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_23f0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_23f3, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_23f7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_23f9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_23fc, 3); shl(edx, 6);                            /* shl edx, 0x6 */
            ii(0x1014_23ff, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1014_2401, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1014_2404, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x1014_2407, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1014_240a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_240d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_2410, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2412, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2413, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2414, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2415, 1); pop(edx);                               /* pop edx */
            ii(0x1014_2416, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_2417, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_2418, 1); ret();                                  /* ret */
        }
    }
}
