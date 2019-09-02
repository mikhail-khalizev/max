using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b004-7ca3984")]
        public void Method_100a_b004()
        {
            ii(0x100a_b004, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_b009, 5); call(Definitions.sys_check_available_stack_size, 0xb_ad44); /* call 0x10165d52 */
            ii(0x100a_b00e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b00f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b010, 1); push(edx);                              /* push edx */
            ii(0x100a_b011, 1); push(esi);                              /* push esi */
            ii(0x100a_b012, 1); push(edi);                              /* push edi */
            ii(0x100a_b013, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b014, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b016, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b01c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_b01f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b022, 5); call(0x1007_6d58, -0x3_42cf);           /* call 0x10076d58 */
            ii(0x100a_b027, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_b02a, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100a_b02d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b030, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b033, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_b036, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_b039, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b03b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b03c, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b03d, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b03e, 1); pop(edx);                               /* pop edx */
            ii(0x100a_b03f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b040, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b041, 1); ret();                                  /* ret */
        }
    }
}
