using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c217-fcf3512a")]
        public void Method_1013_c217()
        {
            ii(0x1013_c217, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c21c, 5); call(Definitions.sys_check_available_stack_size, 0x2_9b31); /* call 0x10165d52 */
            ii(0x1013_c221, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c222, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c223, 1); push(esi);                              /* push esi */
            ii(0x1013_c224, 1); push(edi);                              /* push edi */
            ii(0x1013_c225, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c226, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c228, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c22e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c231, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c234, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_c237, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c23a, 5); call(0x1013_c1ce, -0x71);               /* call 0x1013c1ce */
            ii(0x1013_c23f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c242, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c245, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_c248, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1013_c24b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_c24e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_c251, 3); call_abs(memd[ds, ebx + 0xc]);          /* call dword [ebx+0xc] */
            ii(0x1013_c254, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c256, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c257, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c258, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c259, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c25a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c25b, 1); ret();                                  /* ret */
        }
    }
}
