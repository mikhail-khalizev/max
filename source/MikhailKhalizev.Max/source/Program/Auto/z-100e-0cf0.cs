using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0cf0-731cdcfe")]
        public void Method_100e_0cf0()
        {
            ii(0x100e_0cf0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_0cf5, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5058);/* call 0x10165d52 */
            ii(0x100e_0cfa, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_0cfb, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0cfc, 1);  push(edx);                            /* push edx */
            ii(0x100e_0cfd, 1);  push(esi);                            /* push esi */
            ii(0x100e_0cfe, 1);  push(edi);                            /* push edi */
            ii(0x100e_0cff, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0d00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0d02, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_0d08, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0d0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0d0e, 5);  call(0x1007_6b58, -0x6_a1bb);         /* call 0x10076b58 */
            ii(0x100e_0d13, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0d16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0d19, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0d1b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0d1c, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0d1d, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_0d1e, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_0d1f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_0d20, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_0d21, 1);  ret();                                /* ret */
        }
    }
}
