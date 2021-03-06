using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_79e0-cfd99754")]
        public void Method_100b_79e0()
        {
            ii(0x100b_79e0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_79e5, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e368);/* call 0x10165d52 */
            ii(0x100b_79ea, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_79eb, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_79ec, 1);  push(edx);                            /* push edx */
            ii(0x100b_79ed, 1);  push(esi);                            /* push esi */
            ii(0x100b_79ee, 1);  push(edi);                            /* push edi */
            ii(0x100b_79ef, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_79f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_79f2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_79f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_79fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_79fe, 4);  mov(ax, memw[ds, eax + 19]);          /* mov ax, [eax+0x13] */
            ii(0x100b_7a02, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7a05, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7a08, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7a0a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7a0b, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7a0c, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7a0d, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_7a0e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7a0f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7a10, 1);  ret();                                /* ret */
        }
    }
}
