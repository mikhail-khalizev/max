using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_80ac-68b4c0c0")]
        public void Method_1014_80ac()
        {
            ii(0x1014_80ac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_80b1, 5);  call(Definitions.sys_check_available_stack_size, 0x1_dc9c);/* call 0x10165d52 */
            ii(0x1014_80b6, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_80b7, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_80b8, 1);  push(esi);                            /* push esi */
            ii(0x1014_80b9, 1);  push(edi);                            /* push edi */
            ii(0x1014_80ba, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_80bb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_80bd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_80c3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_80c6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_80c9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_80cc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_80cf, 5);  call(0x1013_b4b3, -0xcc21);           /* call 0x1013b4b3 */
            ii(0x1014_80d4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_80d7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_80da, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_80dc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_80dd, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_80de, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_80df, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_80e0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_80e1, 1);  ret();                                /* ret */
        }
    }
}
