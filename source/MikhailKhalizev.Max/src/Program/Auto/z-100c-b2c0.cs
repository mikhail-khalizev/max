using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b2c0-733e1cca")]
        public void Method_100c_b2c0()
        {
            ii(0x100c_b2c0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_b2c5, 5);  call(Definitions.sys_check_available_stack_size, 0x9_aa88);/* call 0x10165d52 */
            ii(0x100c_b2ca, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b2cb, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b2cc, 1);  push(edx);                            /* push edx */
            ii(0x100c_b2cd, 1);  push(esi);                            /* push esi */
            ii(0x100c_b2ce, 1);  push(edi);                            /* push edi */
            ii(0x100c_b2cf, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b2d0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b2d2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_b2d8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b2db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b2de, 4);  mov(ax, memw[ds, eax + 7]);           /* mov ax, [eax+0x7] */
            ii(0x100c_b2e2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b2e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b2e8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b2ea, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b2eb, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b2ec, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b2ed, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_b2ee, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b2ef, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b2f0, 1);  ret();                                /* ret */
        }
    }
}
