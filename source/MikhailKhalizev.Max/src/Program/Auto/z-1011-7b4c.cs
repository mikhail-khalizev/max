using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7b4c-1f52da27")]
        public void Method_1011_7b4c()
        {
            ii(0x1011_7b4c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_7b51, 5); call(Definitions.sys_check_available_stack_size, 0x4_e1fc); /* call 0x10165d52 */
            ii(0x1011_7b56, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7b57, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7b58, 1); push(esi);                              /* push esi */
            ii(0x1011_7b59, 1); push(edi);                              /* push edi */
            ii(0x1011_7b5a, 1); push(ebp);                              /* push ebp */
            ii(0x1011_7b5b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7b5d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7b63, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_7b66, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_7b69, 5); mov(ebx, 0x101b_66dc);                  /* mov ebx, 0x101b66dc */
            ii(0x1011_7b6e, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x1011_7b73, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_7b76, 5); call(Definitions.sys_call_dtor_arr_v2, 0x4_e465); /* call 0x10165fe0 */
            ii(0x1011_7b7b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_7b7e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_7b81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7b83, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7b84, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7b85, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7b86, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7b87, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7b88, 1); ret();                                  /* ret */
        }
    }
}
