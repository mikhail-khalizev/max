using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6b20-5c28b8b1")]
        public void Method_1007_6b20()
        {
            ii(0x1007_6b20, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6b25, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f228);/* call 0x10165d52 */
            ii(0x1007_6b2a, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6b2b, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6b2c, 1);  push(edx);                            /* push edx */
            ii(0x1007_6b2d, 1);  push(esi);                            /* push esi */
            ii(0x1007_6b2e, 1);  push(edi);                            /* push edi */
            ii(0x1007_6b2f, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6b30, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6b32, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6b38, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6b3b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6b3e, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1007_6b41, 5);  call(0x1007_6c68, 0x122);             /* call 0x10076c68 */
            ii(0x1007_6b46, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6b49, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6b4c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6b4e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6b4f, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6b50, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6b51, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6b52, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6b53, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6b54, 1);  ret();                                /* ret */
        }
    }
}
