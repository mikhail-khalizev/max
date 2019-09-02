using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0a2c-7b858644")]
        public void Method_1012_0a2c()
        {
            ii(0x1012_0a2c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0a31, 5); call(Definitions.sys_check_available_stack_size, 0x4_531c); /* call 0x10165d52 */
            ii(0x1012_0a36, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0a37, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0a38, 1); push(edx);                              /* push edx */
            ii(0x1012_0a39, 1); push(esi);                              /* push esi */
            ii(0x1012_0a3a, 1); push(edi);                              /* push edi */
            ii(0x1012_0a3b, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0a3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0a3e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_0a44, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_0a47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_0a4a, 3); mov(al, memb[ds, eax + 0xe]);           /* mov al, [eax+0xe] */
            ii(0x1012_0a4d, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1012_0a50, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1012_0a53, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0a55, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0a56, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0a57, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0a58, 1); pop(edx);                               /* pop edx */
            ii(0x1012_0a59, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0a5a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0a5b, 1); ret();                                  /* ret */
        }
    }
}
