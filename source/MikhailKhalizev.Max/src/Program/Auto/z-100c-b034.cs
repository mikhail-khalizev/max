using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b034-eba017f7")]
        public void Method_100c_b034()
        {
            ii(0x100c_b034, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_b039, 5); call(Definitions.sys_check_available_stack_size, 0x9_ad14); /* call 0x10165d52 */
            ii(0x100c_b03e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b03f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b040, 1); push(edx);                              /* push edx */
            ii(0x100c_b041, 1); push(esi);                              /* push esi */
            ii(0x100c_b042, 1); push(edi);                              /* push edi */
            ii(0x100c_b043, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b044, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b046, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b04c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b04f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b052, 5); call(0x1013_a0af, 0x6_f058);            /* call 0x1013a0af */
            ii(0x100c_b057, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b05a, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100c_b05d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_b060, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b063, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_b066, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_b069, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b06b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b06c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b06d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b06e, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b06f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b070, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b071, 1); ret();                                  /* ret */
        }
    }
}
