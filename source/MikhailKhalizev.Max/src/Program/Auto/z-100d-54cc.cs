using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_54cc-1ec20a8f")]
        public void Method_100d_54cc()
        {
            ii(0x100d_54cc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_54d1, 5);  call(Definitions.sys_check_available_stack_size, 0x9_087c);/* call 0x10165d52 */
            ii(0x100d_54d6, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_54d7, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_54d8, 1);  push(esi);                            /* push esi */
            ii(0x100d_54d9, 1);  push(edi);                            /* push edi */
            ii(0x100d_54da, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_54db, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_54dd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_54e3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_54e6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_54e9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_54ec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_54ef, 5);  call(0x100c_b850, -0x9ca4);           /* call 0x100cb850 */
            ii(0x100d_54f4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_54f7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_54fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_54fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_54fd, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_54fe, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_54ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5500, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5501, 1);  ret();                                /* ret */
        }
    }
}
