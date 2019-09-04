using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_10e3-aee25da7")]
        public void Method_1008_10e3()
        {
            ii(0x1008_10e3, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_10e8, 5); call(Definitions.sys_check_available_stack_size, 0xe_4c65); /* call 0x10165d52 */
            ii(0x1008_10ed, 1); push(ebx);                              /* push ebx */
            ii(0x1008_10ee, 1); push(ecx);                              /* push ecx */
            ii(0x1008_10ef, 1); push(esi);                              /* push esi */
            ii(0x1008_10f0, 1); push(edi);                              /* push edi */
            ii(0x1008_10f1, 1); push(ebp);                              /* push ebp */
            ii(0x1008_10f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_10f4, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_10fa, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_10fd, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_1100, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_1103, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_1106, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_1109, 5); call(0x1008_aab4, 0x99a6);              /* call 0x1008aab4 */
            ii(0x1008_110e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_1110, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_1111, 1); pop(edi);                               /* pop edi */
            ii(0x1008_1112, 1); pop(esi);                               /* pop esi */
            ii(0x1008_1113, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_1114, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_1115, 1); ret();                                  /* ret */
        }
    }
}
