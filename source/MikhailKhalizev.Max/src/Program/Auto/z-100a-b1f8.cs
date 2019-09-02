using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b1f8-eac309dc")]
        public void Method_100a_b1f8()
        {
            ii(0x100a_b1f8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_b1fd, 5); call(Definitions.sys_check_available_stack_size, 0xb_ab50); /* call 0x10165d52 */
            ii(0x100a_b202, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b203, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b204, 1); push(esi);                              /* push esi */
            ii(0x100a_b205, 1); push(edi);                              /* push edi */
            ii(0x100a_b206, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b207, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b209, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b20f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b212, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b215, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b218, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b21b, 5); call(0x1007_6c98, -0x3_4588);           /* call 0x10076c98 */
            ii(0x100a_b220, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_b223, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_b226, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b228, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b229, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b22a, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b22b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b22c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b22d, 1); ret();                                  /* ret */
        }
    }
}
