using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b460-edeecd7")]
        public void Method_100c_b460()
        {
            ii(0x100c_b460, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b465, 5); call(Definitions.sys_check_available_stack_size, 0x9_a8e8); /* call 0x10165d52 */
            ii(0x100c_b46a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b46b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b46c, 1); push(edx);                              /* push edx */
            ii(0x100c_b46d, 1); push(esi);                              /* push esi */
            ii(0x100c_b46e, 1); push(edi);                              /* push edi */
            ii(0x100c_b46f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b470, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b472, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_b478, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b47b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b47e, 3); mov(al, memb[ds, eax + 31]);            /* mov al, [eax+0x1f] */
            ii(0x100c_b481, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100c_b484, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_b487, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b489, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b48a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b48b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b48c, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b48d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b48e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b48f, 1); ret();                                  /* ret */
        }
    }
}
