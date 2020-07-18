using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3334-7ee5db96")]
        public void Method_1012_3334()
        {
            ii(0x1012_3334, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_3339, 5);  call(Definitions.sys_check_available_stack_size, 0x4_2a14);/* call 0x10165d52 */
            ii(0x1012_333e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_333f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_3340, 1);  push(esi);                            /* push esi */
            ii(0x1012_3341, 1);  push(edi);                            /* push edi */
            ii(0x1012_3342, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_3343, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_3345, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_334b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_334e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_3351, 3);  mov(edi, memd[ss, ebp - 8]);          /* mov edi, [ebp-0x8] */
            ii(0x1012_3354, 3);  mov(esi, memd[ss, ebp - 4]);          /* mov esi, [ebp-0x4] */
            ii(0x1012_3357, 2);  movsw();                              /* movsw */
            ii(0x1012_3359, 1);  movsb();                              /* movsb */
            ii(0x1012_335a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_335d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_3360, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_3363, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_3365, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_3366, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_3367, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_3368, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_3369, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_336a, 1);  ret();                                /* ret */
        }
    }
}
