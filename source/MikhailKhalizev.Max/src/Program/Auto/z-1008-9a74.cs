using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9a74-661f555f")]
        public void Method_1008_9a74()
        {
            ii(0x1008_9a74, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9a79, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c2d4);/* call 0x10165d52 */
            ii(0x1008_9a7e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9a7f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9a80, 1);  push(edx);                            /* push edx */
            ii(0x1008_9a81, 1);  push(esi);                            /* push esi */
            ii(0x1008_9a82, 1);  push(edi);                            /* push edi */
            ii(0x1008_9a83, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9a84, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9a86, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_9a8c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9a8f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9a92, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_9a95, 5);  call(0x1007_6338, -0x1_3762);         /* call 0x10076338 */
            ii(0x1008_9a9a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9a9d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9aa0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9aa2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9aa3, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9aa4, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9aa5, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9aa6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9aa7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9aa8, 1);  ret();                                /* ret */
        }
    }
}
