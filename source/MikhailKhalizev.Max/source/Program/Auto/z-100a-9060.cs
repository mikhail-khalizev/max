using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9060-5e5fd2ac")]
        public void Method_100a_9060()
        {
            ii(0x100a_9060, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_9065, 5);  call(Definitions.sys_check_available_stack_size, 0xb_cce8);/* call 0x10165d52 */
            ii(0x100a_906a, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_906b, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_906c, 1);  push(esi);                            /* push esi */
            ii(0x100a_906d, 1);  push(edi);                            /* push edi */
            ii(0x100a_906e, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_906f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_9071, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_9077, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_907a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_907d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_9081, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_9087, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_908d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_9092, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_9095, 2);  if(jnz(0x100a_90a0, 9)) goto l_0x100a_90a0;/* jnz 0x100a90a0 */
            ii(0x100a_9097, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_909a, 4);  test(memb[ds, eax + 20], 0x40);       /* test byte [eax+0x14], 0x40 */
            ii(0x100a_909e, 2);  if(jnz(0x100a_90a2, 2)) goto l_0x100a_90a2;/* jnz 0x100a90a2 */
        l_0x100a_90a0:
            ii(0x100a_90a0, 2);  jmp(0x100a_90bb, 0x19); goto l_0x100a_90bb;/* jmp 0x100a90bb */
        l_0x100a_90a2:
            ii(0x100a_90a2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_90a5, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_90a9, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x100a_90af, 5);  mov(ebx, 0x101c_31c4);                /* mov ebx, 0x101c31c4 */
            ii(0x100a_90b4, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_90b6, 5);  call(0x100c_36ab, 0x1_a5f0);          /* call 0x100c36ab */
        l_0x100a_90bb:
            ii(0x100a_90bb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_90be, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100a_90c3, 5);  call(0x100a_5ef0, -0x31d8);           /* call 0x100a5ef0 */
            ii(0x100a_90c8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_90ca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_90cb, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_90cc, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_90cd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_90ce, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_90cf, 1);  ret();                                /* ret */
        }
    }
}
