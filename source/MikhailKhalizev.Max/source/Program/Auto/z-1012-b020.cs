using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b020-b70f20a1")]
        public void Method_1012_b020()
        {
            ii(0x1012_b020, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_b025, 5);  call(Definitions.sys_check_available_stack_size, 0x3_ad28);/* call 0x10165d52 */
            ii(0x1012_b02a, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_b02b, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_b02c, 1);  push(edx);                            /* push edx */
            ii(0x1012_b02d, 1);  push(esi);                            /* push esi */
            ii(0x1012_b02e, 1);  push(edi);                            /* push edi */
            ii(0x1012_b02f, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_b030, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_b032, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_b038, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_b03b, 7);  mov(memb[ds, 0x101c_5c1c], 0x29);     /* mov byte [0x101c5c1c], 0x29 */
            ii(0x1012_b042, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_b045, 5);  call(0x1007_6154, -0xb_4ef6);         /* call 0x10076154 */
            ii(0x1012_b04a, 6);  mov(memw[ds, 0x101c_5c1d], ax);       /* mov [0x101c5c1d], ax */
            ii(0x1012_b050, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_b055, 5);  call(0x1012_5be9, -0x5471);           /* call 0x10125be9 */
            ii(0x1012_b05a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_b05c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_b05d, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_b05e, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_b05f, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_b060, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_b061, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_b062, 1);  ret();                                /* ret */
        }
    }
}
