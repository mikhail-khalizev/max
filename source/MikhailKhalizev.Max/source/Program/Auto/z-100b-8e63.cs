using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8e63-33df2c4d")]
        public void Method_100b_8e63()
        {
            ii(0x100b_8e63, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_8e68, 5);  call(Definitions.sys_check_available_stack_size, 0xa_cee5);/* call 0x10165d52 */
            ii(0x100b_8e6d, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_8e6e, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_8e6f, 1);  push(esi);                            /* push esi */
            ii(0x100b_8e70, 1);  push(edi);                            /* push edi */
            ii(0x100b_8e71, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8e72, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8e74, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_8e7a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8e7d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_8e80, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8e83, 5);  call(0x100b_8f63, 0xdb);              /* call 0x100b8f63 */
            ii(0x100b_8e88, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_8e8b, 3);  add(edx, 0x10);                       /* add edx, 0x10 */
            ii(0x100b_8e8e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8e91, 5);  call(0x1007_5e64, -0x4_3032);         /* call 0x10075e64 */
            ii(0x100b_8e96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8e99, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_8e9b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_8e9c, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_8e9d, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_8e9e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8e9f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8ea0, 1);  ret();                                /* ret */
        }
    }
}
