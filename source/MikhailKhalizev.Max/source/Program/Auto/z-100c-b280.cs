using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b280-13434e6")]
        public void Method_100c_b280()
        {
            ii(0x100c_b280, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_b285, 5);  call(Definitions.sys_check_available_stack_size, 0x9_aac8);/* call 0x10165d52 */
            ii(0x100c_b28a, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b28b, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b28c, 1);  push(edx);                            /* push edx */
            ii(0x100c_b28d, 1);  push(esi);                            /* push esi */
            ii(0x100c_b28e, 1);  push(edi);                            /* push edi */
            ii(0x100c_b28f, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b290, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b292, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_b298, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b29b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b29e, 5);  call(0x1013_a0af, 0x6_ee0c);          /* call 0x1013a0af */
            ii(0x100c_b2a3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b2a6, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100c_b2a9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b2ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b2af, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b2b2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_b2b5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b2b7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b2b8, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b2b9, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b2ba, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_b2bb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b2bc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b2bd, 1);  ret();                                /* ret */
        }
    }
}
