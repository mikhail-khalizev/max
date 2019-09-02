using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_09fc-f8c9ff4e")]
        public void Method_1012_09fc()
        {
            ii(0x1012_09fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0a01, 5); call(Definitions.sys_check_available_stack_size, 0x4_534c); /* call 0x10165d52 */
            ii(0x1012_0a06, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0a07, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0a08, 1); push(edx);                              /* push edx */
            ii(0x1012_0a09, 1); push(esi);                              /* push esi */
            ii(0x1012_0a0a, 1); push(edi);                              /* push edi */
            ii(0x1012_0a0b, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0a0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0a0e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_0a14, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_0a17, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_0a1a, 3); mov(al, memb[ds, eax + 0x14]);          /* mov al, [eax+0x14] */
            ii(0x1012_0a1d, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1012_0a20, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1012_0a23, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0a25, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0a26, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0a27, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0a28, 1); pop(edx);                               /* pop edx */
            ii(0x1012_0a29, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0a2a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0a2b, 1); ret();                                  /* ret */
        }
    }
}
