using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ab4c-980e8776")]
        public void Method_1008_ab4c()
        {
            ii(0x1008_ab4c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_ab51, 5); call(Definitions.sys_check_available_stack_size, 0xd_b1fc); /* call 0x10165d52 */
            ii(0x1008_ab56, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ab57, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ab58, 1); push(edx);                              /* push edx */
            ii(0x1008_ab59, 1); push(esi);                              /* push esi */
            ii(0x1008_ab5a, 1); push(edi);                              /* push edi */
            ii(0x1008_ab5b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ab5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ab5e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_ab64, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ab67, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ab6a, 5); call(0x1013_a0af, 0xa_f540);            /* call 0x1013a0af */
            ii(0x1008_ab6f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ab72, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_ab75, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_ab78, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ab7b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_ab7e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_ab81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ab83, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ab84, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ab85, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ab86, 1); pop(edx);                               /* pop edx */
            ii(0x1008_ab87, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ab88, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ab89, 1); ret();                                  /* ret */
        }
    }
}
