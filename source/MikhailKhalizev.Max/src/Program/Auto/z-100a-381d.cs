using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_381d-c1ef41d5")]
        public void Method_100a_381d()
        {
            ii(0x100a_381d, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_3822, 5); call(Definitions.sys_check_available_stack_size, 0xc_252b); /* call 0x10165d52 */
            ii(0x100a_3827, 1); push(ebx);                              /* push ebx */
            ii(0x100a_3828, 1); push(ecx);                              /* push ecx */
            ii(0x100a_3829, 1); push(edx);                              /* push edx */
            ii(0x100a_382a, 1); push(esi);                              /* push esi */
            ii(0x100a_382b, 1); push(edi);                              /* push edi */
            ii(0x100a_382c, 1); push(ebp);                              /* push ebp */
            ii(0x100a_382d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_382f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3835, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3838, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_383f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3842, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3844, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3845, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3846, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3847, 1); pop(edx);                               /* pop edx */
            ii(0x100a_3848, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3849, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_384a, 1); ret();                                  /* ret */
        }
    }
}
