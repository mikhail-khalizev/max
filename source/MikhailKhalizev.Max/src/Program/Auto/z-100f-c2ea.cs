using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c2ea-d947e49b")]
        public void Method_100f_c2ea()
        {
            ii(0x100f_c2ea, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_c2ef, 5);  call(Definitions.sys_check_available_stack_size, 0x6_9a5e);/* call 0x10165d52 */
            ii(0x100f_c2f4, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_c2f5, 1);  push(esi);                            /* push esi */
            ii(0x100f_c2f6, 1);  push(edi);                            /* push edi */
            ii(0x100f_c2f7, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_c2f8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_c2fa, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100f_c300, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_c303, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100f_c306, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100f_c309, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_c30c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100f_c30f, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x100f_c312, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_c315, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100f_c318, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x100f_c31c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_c31f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_c322, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_c325, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_c327, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_c328, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_c329, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_c32a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_c32b, 1);  ret();                                /* ret */
        }
    }
}
