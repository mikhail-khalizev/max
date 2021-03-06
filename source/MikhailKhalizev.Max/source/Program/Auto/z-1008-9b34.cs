using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9b34-2a9d0710")]
        public void Method_1008_9b34()
        {
            ii(0x1008_9b34, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9b39, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c214);/* call 0x10165d52 */
            ii(0x1008_9b3e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9b3f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9b40, 1);  push(edx);                            /* push edx */
            ii(0x1008_9b41, 1);  push(esi);                            /* push esi */
            ii(0x1008_9b42, 1);  push(edi);                            /* push edi */
            ii(0x1008_9b43, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9b44, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9b46, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_9b4c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9b4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9b52, 5);  call(0x1007_6c30, -0x1_2f27);         /* call 0x10076c30 */
            ii(0x1008_9b57, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9b5a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9b5d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9b5f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9b60, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9b61, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9b62, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9b63, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9b64, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9b65, 1);  ret();                                /* ret */
        }
    }
}
