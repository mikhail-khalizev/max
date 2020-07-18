using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ad54-71748f5a")]
        public void Method_100a_ad54()
        {
            ii(0x100a_ad54, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_ad59, 5);  call(Definitions.sys_check_available_stack_size, 0xb_aff4);/* call 0x10165d52 */
            ii(0x100a_ad5e, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_ad5f, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_ad60, 1);  push(edx);                            /* push edx */
            ii(0x100a_ad61, 1);  push(esi);                            /* push esi */
            ii(0x100a_ad62, 1);  push(edi);                            /* push edi */
            ii(0x100a_ad63, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_ad64, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_ad66, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_ad6c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ad6f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ad72, 5);  call(0x1013_a0af, 0x8_f338);          /* call 0x1013a0af */
            ii(0x100a_ad77, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ad7a, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100a_ad7d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ad80, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ad83, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_ad86, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_ad89, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ad8b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ad8c, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_ad8d, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_ad8e, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_ad8f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_ad90, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_ad91, 1);  ret();                                /* ret */
        }
    }
}
