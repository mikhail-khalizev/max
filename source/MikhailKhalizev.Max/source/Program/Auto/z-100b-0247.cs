using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0247-8a7cbd62")]
        public void Method_100b_0247()
        {
            ii(0x100b_0247, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_024c, 5);  call(Definitions.sys_check_available_stack_size, 0xb_5b01);/* call 0x10165d52 */
            ii(0x100b_0251, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_0252, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_0253, 1);  push(edx);                            /* push edx */
            ii(0x100b_0254, 1);  push(esi);                            /* push esi */
            ii(0x100b_0255, 1);  push(edi);                            /* push edi */
            ii(0x100b_0256, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_0257, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_0259, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_025f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_0262, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_0269, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_026c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_026e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_026f, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_0270, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_0271, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_0272, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_0273, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_0274, 1);  ret();                                /* ret */
        }
    }
}
