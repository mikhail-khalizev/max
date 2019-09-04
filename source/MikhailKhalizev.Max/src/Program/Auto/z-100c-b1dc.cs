using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b1dc-6b84d480")]
        public void Method_100c_b1dc()
        {
            ii(0x100c_b1dc, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_b1e1, 5); call(Definitions.sys_check_available_stack_size, 0x9_ab6c); /* call 0x10165d52 */
            ii(0x100c_b1e6, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b1e7, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b1e8, 1); push(edx);                              /* push edx */
            ii(0x100c_b1e9, 1); push(esi);                              /* push esi */
            ii(0x100c_b1ea, 1); push(edi);                              /* push edi */
            ii(0x100c_b1eb, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b1ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b1ee, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b1f4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b1f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b1fa, 5); call(0x1007_6d58, -0x5_44a7);           /* call 0x10076d58 */
            ii(0x100c_b1ff, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_b202, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100c_b205, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_b208, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_b20b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_b20e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_b211, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b213, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b214, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b215, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b216, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b217, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b218, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b219, 1); ret();                                  /* ret */
        }
    }
}
