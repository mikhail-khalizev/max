using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d412-98ee89ae")]
        public void Method_100c_d412()
        {
            ii(0x100c_d412, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d417, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8936);/* call 0x10165d52 */
            ii(0x100c_d41c, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d41d, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d41e, 1);  push(edx);                            /* push edx */
            ii(0x100c_d41f, 1);  push(esi);                            /* push esi */
            ii(0x100c_d420, 1);  push(edi);                            /* push edi */
            ii(0x100c_d421, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d422, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d424, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_d42a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_d42d, 4);  mov(memb[ss, ebp - 8], 0x2f);         /* mov byte [ebp-0x8], 0x2f */
            ii(0x100c_d431, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_d434, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d436, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d437, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d438, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d439, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_d43a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d43b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d43c, 1);  ret();                                /* ret */
        }
    }
}
