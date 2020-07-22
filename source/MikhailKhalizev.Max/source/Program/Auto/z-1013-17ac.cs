using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_17ac-9f8b1d37")]
        public void Method_1013_17ac()
        {
            ii(0x1013_17ac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_17b1, 5);  call(Definitions.sys_check_available_stack_size, 0x3_459c);/* call 0x10165d52 */
            ii(0x1013_17b6, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_17b7, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_17b8, 1);  push(esi);                            /* push esi */
            ii(0x1013_17b9, 1);  push(edi);                            /* push edi */
            ii(0x1013_17ba, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_17bb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_17bd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_17c3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_17c6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_17c9, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_17ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_17d1, 5);  call(Definitions.my_dtor_0x101b_6edc, 0x946f);/* call 0x1013ac45 */
            ii(0x1013_17d6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_17d9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_17dc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_17df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_17e2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_17e4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_17e5, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_17e6, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_17e7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_17e8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_17e9, 1);  ret();                                /* ret */
        }
    }
}
