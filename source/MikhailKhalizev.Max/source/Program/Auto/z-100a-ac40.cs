using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ac40-9bcb2e0d")]
        public void Method_100a_ac40()
        {
            ii(0x100a_ac40, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_ac45, 5);  call(Definitions.sys_check_available_stack_size, 0xb_b108);/* call 0x10165d52 */
            ii(0x100a_ac4a, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_ac4b, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_ac4c, 1);  push(edx);                            /* push edx */
            ii(0x100a_ac4d, 1);  push(esi);                            /* push esi */
            ii(0x100a_ac4e, 1);  push(edi);                            /* push edi */
            ii(0x100a_ac4f, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_ac50, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_ac52, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_ac58, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ac5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ac5e, 5);  call(0x1007_6d58, -0x3_3f0b);         /* call 0x10076d58 */
            ii(0x100a_ac63, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ac66, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100a_ac69, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ac6c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ac6f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_ac72, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_ac75, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ac77, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ac78, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_ac79, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_ac7a, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_ac7b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_ac7c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_ac7d, 1);  ret();                                /* ret */
        }
    }
}
