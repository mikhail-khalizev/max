using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c055-cb322101")]
        public void Method_1013_c055()
        {
            ii(0x1013_c055, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_c05a, 5); call(Definitions.sys_check_available_stack_size, 0x2_9cf3); /* call 0x10165d52 */
            ii(0x1013_c05f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c060, 1); push(esi);                              /* push esi */
            ii(0x1013_c061, 1); push(edi);                              /* push edi */
            ii(0x1013_c062, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c063, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c065, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c06b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_c06e, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1013_c071, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1013_c074, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_c077, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1013_c079, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_c07e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c081, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c084, 5); call(/* sys */ 0x1017_2831, 0x3_67a8);  /* call 0x10172831 */
            ii(0x1013_c089, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c08b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c08c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c08d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c08e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c08f, 1); ret();                                  /* ret */
        }
    }
}
