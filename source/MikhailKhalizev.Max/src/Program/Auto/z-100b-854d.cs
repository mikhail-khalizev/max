using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_854d-ed89aec8")]
        public void Method_100b_854d()
        {
            ii(0x100b_854d, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_8552, 5); call(Definitions.sys_check_available_stack_size, 0xa_d7fb); /* call 0x10165d52 */
            ii(0x100b_8557, 1); push(ebx);                              /* push ebx */
            ii(0x100b_8558, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8559, 1); push(esi);                              /* push esi */
            ii(0x100b_855a, 1); push(edi);                              /* push edi */
            ii(0x100b_855b, 1); push(ebp);                              /* push ebp */
            ii(0x100b_855c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_855e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_8564, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_8567, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_856a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_856d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_8570, 5); call(0x100c_b364, 0x1_2def);            /* call 0x100cb364 */
            ii(0x100b_8575, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_8578, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_857b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_857d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_857e, 1); pop(edi);                               /* pop edi */
            ii(0x100b_857f, 1); pop(esi);                               /* pop esi */
            ii(0x100b_8580, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8581, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_8582, 1); ret();                                  /* ret */
        }
    }
}
