using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_66ac-6a209174")]
        public void Method_1007_66ac()
        {
            ii(0x1007_66ac, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_66b1, 5); call(Definitions.sys_check_available_stack_size, 0xe_f69c); /* call 0x10165d52 */
            ii(0x1007_66b6, 1); push(ebx);                              /* push ebx */
            ii(0x1007_66b7, 1); push(ecx);                              /* push ecx */
            ii(0x1007_66b8, 1); push(esi);                              /* push esi */
            ii(0x1007_66b9, 1); push(edi);                              /* push edi */
            ii(0x1007_66ba, 1); push(ebp);                              /* push ebp */
            ii(0x1007_66bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_66bd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_66c3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_66c6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_66c9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_66cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_66cf, 5); call(0x1013_abc3, 0xc_44ef);            /* call 0x1013abc3 */
            ii(0x1007_66d4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_66d7, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1007_66da, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_66dd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_66e0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_66e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_66e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_66e8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_66e9, 1); pop(edi);                               /* pop edi */
            ii(0x1007_66ea, 1); pop(esi);                               /* pop esi */
            ii(0x1007_66eb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_66ec, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_66ed, 1); ret();                                  /* ret */
        }
    }
}
