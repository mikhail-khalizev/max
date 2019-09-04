using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e44d-4715ec18")]
        public void Method_1009_e44d()
        {
            ii(0x1009_e44d, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_e452, 5);  call(Definitions.sys_check_available_stack_size, 0xc_78fb);/* call 0x10165d52 */
            ii(0x1009_e457, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_e458, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e459, 1);  push(esi);                            /* push esi */
            ii(0x1009_e45a, 1);  push(edi);                            /* push edi */
            ii(0x1009_e45b, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e45c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e45e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_e464, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_e467, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_e46a, 5);  mov(edx, StringDefinitions.Survey);   /* mov edx, 0x101a0797 */
            ii(0x1009_e46f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e472, 5);  call(Definitions.sys_strcpy, 0xc_7a58);/* call 0x10165ecf */
            ii(0x1009_e477, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e47a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_e47d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e480, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e482, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e483, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e484, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e485, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e486, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_e487, 1);  ret();                                /* ret */
        }
    }
}
