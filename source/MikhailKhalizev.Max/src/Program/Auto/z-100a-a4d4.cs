using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a4d4-9d402bd4")]
        public void Method_100a_a4d4()
        {
            ii(0x100a_a4d4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_a4d9, 5);  call(Definitions.sys_check_available_stack_size, 0xb_b874);/* call 0x10165d52 */
            ii(0x100a_a4de, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_a4df, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_a4e0, 1);  push(esi);                            /* push esi */
            ii(0x100a_a4e1, 1);  push(edi);                            /* push edi */
            ii(0x100a_a4e2, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_a4e3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_a4e5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_a4eb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a4ee, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_a4f1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_a4f6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a4f9, 5);  call(0x1013_b0a5, 0x9_0ba7);          /* call 0x1013b0a5 */
            ii(0x100a_a4fe, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a501, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a504, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_a507, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_a50a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_a50c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_a50d, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_a50e, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_a50f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_a510, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_a511, 1);  ret();                                /* ret */
        }
    }
}
