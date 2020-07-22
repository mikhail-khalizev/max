using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ba3c-44769898")]
        public void Method_1013_ba3c()
        {
            ii(0x1013_ba3c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_ba41, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a30c);/* call 0x10165d52 */
            ii(0x1013_ba46, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_ba47, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ba48, 1);  push(edx);                            /* push edx */
            ii(0x1013_ba49, 1);  push(esi);                            /* push esi */
            ii(0x1013_ba4a, 1);  push(edi);                            /* push edi */
            ii(0x1013_ba4b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ba4c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ba4e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_ba54, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_ba57, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ba5a, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1013_ba5d, 5);  call(0x1013_b325, -0x73d);            /* call 0x1013b325 */
            ii(0x1013_ba62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ba65, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_ba68, 2);  if(jz(0x1013_ba74, 0xa)) goto l_0x1013_ba74;/* jz 0x1013ba74 */
            ii(0x1013_ba6a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ba6d, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_ba6f, 5);  call(Definitions.sys_fclose, 0x3_65f5);/* call 0x10172069 */
        l_0x1013_ba74:
            ii(0x1013_ba74, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ba77, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x1013_ba7d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_ba7f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_ba80, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_ba81, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_ba82, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_ba83, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_ba84, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_ba85, 1);  ret();                                /* ret */
        }
    }
}
