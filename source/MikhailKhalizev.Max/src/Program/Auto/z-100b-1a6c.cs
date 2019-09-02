using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1a6c-1aceb1c0")]
        public void Method_100b_1a6c()
        {
            ii(0x100b_1a6c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_1a71, 5); call(Definitions.sys_check_available_stack_size, 0xb_42dc); /* call 0x10165d52 */
            ii(0x100b_1a76, 1); push(ebx);                              /* push ebx */
            ii(0x100b_1a77, 1); push(ecx);                              /* push ecx */
            ii(0x100b_1a78, 1); push(edx);                              /* push edx */
            ii(0x100b_1a79, 1); push(esi);                              /* push esi */
            ii(0x100b_1a7a, 1); push(edi);                              /* push edi */
            ii(0x100b_1a7b, 1); push(ebp);                              /* push ebp */
            ii(0x100b_1a7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1a7e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_1a84, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_1a87, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_1a8a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_1a8d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1a90, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_1a93, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1a96, 3); call_abs(memd[ds, edx + 0x3c]);         /* call dword [edx+0x3c] */
            ii(0x100b_1a99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1a9b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_1a9c, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1a9d, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1a9e, 1); pop(edx);                               /* pop edx */
            ii(0x100b_1a9f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_1aa0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_1aa1, 1); ret();                                  /* ret */
        }
    }
}
