using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1b2a-6875d1af")]
        public void my_string_dtor()
        {
            ii(0x1014_1b2a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_1b2f, 5);  call(Definitions.sys_check_available_stack_size, 0x2_421e);/* call 0x10165d52 */
            ii(0x1014_1b34, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_1b35, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1b36, 1);  push(esi);                            /* push esi */
            ii(0x1014_1b37, 1);  push(edi);                            /* push edi */
            ii(0x1014_1b38, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1b39, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1b3b, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_1b41, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_1b44, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_1b47, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1b4a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_1b4c, 5);  call(Definitions.my_string_release, 0x8cb);/* call 0x1014241c */
            ii(0x1014_1b51, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1b54, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1b57, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_1b5a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_1b5c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_1b5d, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_1b5e, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_1b5f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1b60, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_1b61, 1);  ret();                                /* ret */
        }
    }
}
