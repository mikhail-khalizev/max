using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a628-b5484c79")]
        public void Method_100c_a628()
        {
            ii(0x100c_a628, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_a62d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b720);/* call 0x10165d52 */
            ii(0x100c_a632, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_a633, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_a634, 1);  push(esi);                            /* push esi */
            ii(0x100c_a635, 1);  push(edi);                            /* push edi */
            ii(0x100c_a636, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_a637, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_a639, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_a63f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a642, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a645, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100c_a64a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a64d, 5);  call(0x1013_a1be, 0x6_fb6c);          /* call 0x1013a1be */
            ii(0x100c_a652, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a655, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a658, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_a65b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_a65e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_a660, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_a661, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_a662, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_a663, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_a664, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_a665, 1);  ret();                                /* ret */
        }
    }
}
