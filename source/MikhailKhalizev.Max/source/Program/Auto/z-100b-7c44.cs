using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7c44-9cf93717")]
        public void Method_100b_7c44()
        {
            ii(0x100b_7c44, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_7c49, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e104);/* call 0x10165d52 */
            ii(0x100b_7c4e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7c4f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7c50, 1);  push(edx);                            /* push edx */
            ii(0x100b_7c51, 1);  push(esi);                            /* push esi */
            ii(0x100b_7c52, 1);  push(edi);                            /* push edi */
            ii(0x100b_7c53, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7c54, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7c56, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_7c5c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7c5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7c62, 5);  call(0x1007_6b58, -0x4_110f);         /* call 0x10076b58 */
            ii(0x100b_7c67, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7c6a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7c6d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7c6f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7c70, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7c71, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7c72, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_7c73, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7c74, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7c75, 1);  ret();                                /* ret */
        }
    }
}
