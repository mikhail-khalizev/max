using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ca6e-314af108")]
        public void Method_1013_ca6e()
        {
            ii(0x1013_ca6e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_ca73, 5);  call(Definitions.sys_check_available_stack_size, 0x2_92da);/* call 0x10165d52 */
            ii(0x1013_ca78, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_ca79, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ca7a, 1);  push(esi);                            /* push esi */
            ii(0x1013_ca7b, 1);  push(edi);                            /* push edi */
            ii(0x1013_ca7c, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ca7d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ca7f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_ca85, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_ca88, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_ca8b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ca8e, 5);  call(0x1013_cd6c, 0x2d9);             /* call 0x1013cd6c */
            ii(0x1013_ca93, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ca96, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_ca99, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_ca9c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_ca9e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_ca9f, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_caa0, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_caa1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_caa2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_caa3, 1);  ret();                                /* ret */
        }
    }
}
