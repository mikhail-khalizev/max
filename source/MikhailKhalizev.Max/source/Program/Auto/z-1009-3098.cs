using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_3098-768b0ca2")]
        public void Method_1009_3098()
        {
            ii(0x1009_3098, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_309d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_2cb0);/* call 0x10165d52 */
            ii(0x1009_30a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_30a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_30a4, 1);  push(esi);                            /* push esi */
            ii(0x1009_30a5, 1);  push(edi);                            /* push edi */
            ii(0x1009_30a6, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_30a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_30a9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_30af, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_30b2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_30b5, 5);  mov(edx, StringDefinitions.ManageBuildings);/* mov edx, 0x101a05f1 */
            ii(0x1009_30ba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_30bd, 5);  call(Definitions.sys_strcpy, 0xd_2e0d);/* call 0x10165ecf */
            ii(0x1009_30c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_30c5, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_30c8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_30cb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_30cd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_30ce, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_30cf, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_30d0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_30d1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_30d2, 1);  ret();                                /* ret */
        }
    }
}
