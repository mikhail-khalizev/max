using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_07cc-94dfec28")]
        public void Method_1012_07cc()
        {
            ii(0x1012_07cc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_07d1, 5);  call(Definitions.sys_check_available_stack_size, 0x4_557c);/* call 0x10165d52 */
            ii(0x1012_07d6, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_07d7, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_07d8, 1);  push(esi);                            /* push esi */
            ii(0x1012_07d9, 1);  push(edi);                            /* push edi */
            ii(0x1012_07da, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_07db, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_07dd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_07e3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_07e6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_07e9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_07ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_07ef, 5);  call(0x1013_a66b, 0x1_9e77);          /* call 0x1013a66b */
            ii(0x1012_07f4, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1012_07f7, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1012_07fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_07fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_07fd, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_07fe, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_07ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0800, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0801, 1);  ret();                                /* ret */
        }
    }
}
