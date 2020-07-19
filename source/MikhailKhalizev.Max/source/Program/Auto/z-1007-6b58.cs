using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6b58-14637627")]
        public void Method_1007_6b58()
        {
            ii(0x1007_6b58, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6b5d, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f1f0);/* call 0x10165d52 */
            ii(0x1007_6b62, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6b63, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6b64, 1);  push(edx);                            /* push edx */
            ii(0x1007_6b65, 1);  push(esi);                            /* push esi */
            ii(0x1007_6b66, 1);  push(edi);                            /* push edi */
            ii(0x1007_6b67, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6b68, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6b6a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6b70, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6b73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6b76, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1007_6b79, 5);  call(0x1007_6c68, 0xea);              /* call 0x10076c68 */
            ii(0x1007_6b7e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6b81, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6b84, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6b86, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6b87, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6b88, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6b89, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6b8a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6b8b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6b8c, 1);  ret();                                /* ret */
        }
    }
}
