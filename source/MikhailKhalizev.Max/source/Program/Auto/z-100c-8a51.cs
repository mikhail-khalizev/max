using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8a51-bf8f6be4")]
        public void Method_100c_8a51()
        {
            ii(0x100c_8a51, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_8a56, 5);  call(Definitions.sys_check_available_stack_size, 0x9_d2f7);/* call 0x10165d52 */
            ii(0x100c_8a5b, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_8a5c, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8a5d, 1);  push(esi);                            /* push esi */
            ii(0x100c_8a5e, 1);  push(edi);                            /* push edi */
            ii(0x100c_8a5f, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_8a60, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8a62, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_8a68, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8a6b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_8a6e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8a71, 5);  call(0x100c_8a87, 0x11);              /* call 0x100c8a87 */
            ii(0x100c_8a76, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8a79, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_8a7c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8a7f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_8a81, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_8a82, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_8a83, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_8a84, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_8a85, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_8a86, 1);  ret();                                /* ret */
        }
    }
}
