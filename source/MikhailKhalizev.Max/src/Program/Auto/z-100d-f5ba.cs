using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f5ba-23f38bc5")]
        public void Method_100d_f5ba()
        {
            ii(0x100d_f5ba, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_f5bf, 5);  call(Definitions.sys_check_available_stack_size, 0x8_678e);/* call 0x10165d52 */
            ii(0x100d_f5c4, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_f5c5, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_f5c6, 1);  push(esi);                            /* push esi */
            ii(0x100d_f5c7, 1);  push(edi);                            /* push edi */
            ii(0x100d_f5c8, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_f5c9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_f5cb, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_f5d1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_f5d4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_f5d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f5da, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_f5dd, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100d_f5e0, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
            ii(0x100d_f5e3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_f5e6, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100d_f5e9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_f5ec, 5);  call(0x100d_f329, -0x2c8);            /* call 0x100df329 */
            ii(0x100d_f5f1, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100d_f5f3, 5);  call(0x1016_3f1e, 0x8_4926);          /* call 0x10163f1e */
            ii(0x100d_f5f8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_f5fa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_f5fb, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_f5fc, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_f5fd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_f5fe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_f5ff, 1);  ret();                                /* ret */
        }
    }
}
