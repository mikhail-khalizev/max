using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e33d-7f3404f")]
        public void Method_1010_e33d()
        {
            ii(0x1010_e33d, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_e342, 5);  call(Definitions.sys_check_available_stack_size, 0x5_7a0b);/* call 0x10165d52 */
            ii(0x1010_e347, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_e348, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_e349, 1);  push(edx);                            /* push edx */
            ii(0x1010_e34a, 1);  push(esi);                            /* push esi */
            ii(0x1010_e34b, 1);  push(edi);                            /* push edi */
            ii(0x1010_e34c, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_e34d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_e34f, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_e355, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_e358, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e35b, 5);  call(0x1010_e171, -0x1ef);            /* call 0x1010e171 */
            ii(0x1010_e360, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e363, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1010_e367, 3);  sub(eax, 0xc);                        /* sub eax, 0xc */
            ii(0x1010_e36a, 1);  cwde();                               /* cwde */
            ii(0x1010_e36b, 5);  call(0x1010_94b1, -0x4ebf);           /* call 0x101094b1 */
            ii(0x1010_e370, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e373, 5);  call(0x1010_e1e9, -0x18f);            /* call 0x1010e1e9 */
            ii(0x1010_e378, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_e37a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_e37b, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_e37c, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_e37d, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_e37e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_e37f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_e380, 1);  ret();                                /* ret */
        }
    }
}
