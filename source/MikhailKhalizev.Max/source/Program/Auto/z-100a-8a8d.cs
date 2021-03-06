using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_8a8d-ac37215")]
        public void Method_100a_8a8d()
        {
            ii(0x100a_8a8d, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_8a92, 5);  call(Definitions.sys_check_available_stack_size, 0xb_d2bb);/* call 0x10165d52 */
            ii(0x100a_8a97, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_8a98, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_8a99, 1);  push(edx);                            /* push edx */
            ii(0x100a_8a9a, 1);  push(esi);                            /* push esi */
            ii(0x100a_8a9b, 1);  push(edi);                            /* push edi */
            ii(0x100a_8a9c, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_8a9d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_8a9f, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_8aa5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_8aa8, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8aac, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_8ab2, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8ab8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_8abd, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_8ac0, 2);  if(jnz(0x100a_8ad8, 0x16)) goto l_0x100a_8ad8;/* jnz 0x100a8ad8 */
            ii(0x100a_8ac2, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8ac6, 6);  imul(edx, eax, 0xc5);                 /* imul edx, eax, 0xc5 */
            ii(0x100a_8acc, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x100a_8ad1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100a_8ad3, 5);  call(0x100b_b2ef, 0x1_2817);          /* call 0x100bb2ef */
        l_0x100a_8ad8:
            ii(0x100a_8ad8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_8ada, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_8adb, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_8adc, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_8add, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_8ade, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_8adf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_8ae0, 1);  ret();                                /* ret */
        }
    }
}
