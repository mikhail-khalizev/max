using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9c8c-a792e70f")]
        public void Method_1013_9c8c()
        {
            ii(0x1013_9c8c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_9c91, 5); call(Definitions.sys_check_available_stack_size, 0x2_c0bc); /* call 0x10165d52 */
            ii(0x1013_9c96, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9c97, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9c98, 1); push(esi);                              /* push esi */
            ii(0x1013_9c99, 1); push(edi);                              /* push edi */
            ii(0x1013_9c9a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9c9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9c9d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9ca3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9ca6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_9ca9, 5); mov(ebx, 0x101b_6e14);                  /* mov ebx, 0x101b6e14 */
            ii(0x1013_9cae, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1013_9cb3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9cb6, 5); call(Definitions.sys_call_dtor_arr_v2, 0x2_c325); /* call 0x10165fe0 */
            ii(0x1013_9cbb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_9cbe, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_9cc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9cc3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9cc4, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9cc5, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9cc6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9cc7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9cc8, 1); ret();                                  /* ret */
        }
    }
}
