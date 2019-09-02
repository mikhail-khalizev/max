using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_963c-f13918d9")]
        public void Method_1009_963c()
        {
            ii(0x1009_963c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_9641, 5); call(Definitions.sys_check_available_stack_size, 0xc_c70c); /* call 0x10165d52 */
            ii(0x1009_9646, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9647, 1); push(esi);                              /* push esi */
            ii(0x1009_9648, 1); push(edi);                              /* push edi */
            ii(0x1009_9649, 1); push(ebp);                              /* push ebp */
            ii(0x1009_964a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_964c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9652, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9655, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_9658, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1009_965b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_965d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_965e, 1); pop(edi);                               /* pop edi */
            ii(0x1009_965f, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9660, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9661, 1); ret();                                  /* ret */
        }
    }
}
