using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c6fc-141e037f")]
        public void Method_1009_c6fc()
        {
            ii(0x1009_c6fc, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_c701, 5); call(Definitions.sys_check_available_stack_size, 0xc_964c); /* call 0x10165d52 */
            ii(0x1009_c706, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c707, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c708, 1); push(edx);                              /* push edx */
            ii(0x1009_c709, 1); push(esi);                              /* push esi */
            ii(0x1009_c70a, 1); push(edi);                              /* push edi */
            ii(0x1009_c70b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c70c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c70e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c714, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c717, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c71a, 5); call(0x1013_a0af, 0x9_d990);            /* call 0x1013a0af */
            ii(0x1009_c71f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c722, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1009_c725, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c728, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c72b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c72e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_c731, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c733, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c734, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c735, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c736, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c737, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c738, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c739, 1); ret();                                  /* ret */
        }
    }
}
