using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_875f-cc227cc2")]
        public void Method_1009_875f()
        {
            ii(0x1009_875f, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_8764, 5); call(Definitions.sys_check_available_stack_size, 0xc_d5e9); /* call 0x10165d52 */
            ii(0x1009_8769, 1); push(ebx);                              /* push ebx */
            ii(0x1009_876a, 1); push(ecx);                              /* push ecx */
            ii(0x1009_876b, 1); push(esi);                              /* push esi */
            ii(0x1009_876c, 1); push(edi);                              /* push edi */
            ii(0x1009_876d, 1); push(ebp);                              /* push ebp */
            ii(0x1009_876e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_8770, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_8776, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_8779, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_877c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_877f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8782, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_8785, 5); call(0x1008_aab4, -0xdcd6);             /* call 0x1008aab4 */
            ii(0x1009_878a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_878c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_878d, 1); pop(edi);                               /* pop edi */
            ii(0x1009_878e, 1); pop(esi);                               /* pop esi */
            ii(0x1009_878f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_8790, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_8791, 1); ret();                                  /* ret */
        }
    }
}
