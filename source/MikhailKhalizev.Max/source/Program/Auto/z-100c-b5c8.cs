using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b5c8-6d114312")]
        public void Method_100c_b5c8()
        {
            ii(0x100c_b5c8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_b5cd, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a780);/* call 0x10165d52 */
            ii(0x100c_b5d2, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b5d3, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b5d4, 1);  push(edx);                            /* push edx */
            ii(0x100c_b5d5, 1);  push(esi);                            /* push esi */
            ii(0x100c_b5d6, 1);  push(edi);                            /* push edi */
            ii(0x100c_b5d7, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b5d8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b5da, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_b5e0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b5e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b5e6, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100c_b5e9, 5);  call(0x1007_6b90, -0x5_4a5e);         /* call 0x10076b90 */
            ii(0x100c_b5ee, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_b5f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b5f3, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100c_b5f6, 5);  call(0x1007_6b90, -0x5_4a6b);         /* call 0x10076b90 */
            ii(0x100c_b5fb, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_b5fd, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_b600, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b603, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b605, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b606, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b607, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b608, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_b609, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b60a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b60b, 1);  ret();                                /* ret */
        }
    }
}
