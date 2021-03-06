using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4d8a-fdad8814")]
        public void Method_1012_4d8a()
        {
            ii(0x1012_4d8a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_4d8f, 5);  call(Definitions.sys_check_available_stack_size, 0x4_0fbe);/* call 0x10165d52 */
            ii(0x1012_4d94, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_4d95, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_4d96, 1);  push(edx);                            /* push edx */
            ii(0x1012_4d97, 1);  push(esi);                            /* push esi */
            ii(0x1012_4d98, 1);  push(edi);                            /* push edi */
            ii(0x1012_4d99, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_4d9a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_4d9c, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_4da2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_4da5, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_4da7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_4daa, 5);  call(Definitions.sys_strlen, 0x4_d118);/* call 0x10171ec7 */
            ii(0x1012_4daf, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1012_4db2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_4db4, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1012_4db6, 5);  call(0x1012_4890, -0x52b);            /* call 0x10124890 */
            ii(0x1012_4dbb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_4dbd, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1012_4dc2, 5);  mov(eax, StringDefinitions.Control29);/* mov eax, 0x101a8184 */
            ii(0x1012_4dc7, 5);  call(0x1012_4890, -0x53c);            /* call 0x10124890 */
            ii(0x1012_4dcc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_4dce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_4dcf, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_4dd0, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_4dd1, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_4dd2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_4dd3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_4dd4, 1);  ret();                                /* ret */
        }
    }
}
