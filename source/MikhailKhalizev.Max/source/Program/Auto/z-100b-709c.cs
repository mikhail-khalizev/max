using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_709c-2382f524")]
        public void Method_100b_709c()
        {
            ii(0x100b_709c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_70a1, 5);  call(Definitions.sys_check_available_stack_size, 0xa_ecac);/* call 0x10165d52 */
            ii(0x100b_70a6, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_70a7, 1);  push(esi);                            /* push esi */
            ii(0x100b_70a8, 1);  push(edi);                            /* push edi */
            ii(0x100b_70a9, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_70aa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_70ac, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_70b2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_70b5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_70b8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_70bb, 5);  call(0x1008_b0e4, -0x2_bfdc);         /* call 0x1008b0e4 */
            ii(0x100b_70c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_70c2, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100b_70c4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_70c7, 5);  call(0x100a_297d, -0x1_474f);         /* call 0x100a297d */
            ii(0x100b_70cc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_70ce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_70cf, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_70d0, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_70d1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_70d2, 1);  ret();                                /* ret */
        }
    }
}
