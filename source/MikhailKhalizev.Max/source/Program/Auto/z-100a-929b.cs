using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_929b-8600a8a3")]
        public void Method_100a_929b()
        {
            ii(0x100a_929b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_92a0, 5);  call(Definitions.sys_check_available_stack_size, 0xb_caad);/* call 0x10165d52 */
            ii(0x100a_92a5, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_92a6, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_92a7, 1);  push(esi);                            /* push esi */
            ii(0x100a_92a8, 1);  push(edi);                            /* push edi */
            ii(0x100a_92a9, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_92aa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_92ac, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_92b2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_92b5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_92b8, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_92bc, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_92c2, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_92c8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_92cd, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_92d0, 2);  if(jnz(0x100a_92f5, 0x23)) goto l_0x100a_92f5;/* jnz 0x100a92f5 */
            ii(0x100a_92d2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_92d5, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_92d8, 5);  call(0x1007_5e64, -0x3_3479);         /* call 0x10075e64 */
            ii(0x100a_92dd, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_92df, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_92e3, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x100a_92e9, 5);  mov(ebx, 0x101c_31c4);                /* mov ebx, 0x101c31c4 */
            ii(0x100a_92ee, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_92f0, 5);  call(0x100c_2abd, 0x1_97c8);          /* call 0x100c2abd */
        l_0x100a_92f5:
            ii(0x100a_92f5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_92f7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_92f8, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_92f9, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_92fa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_92fb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_92fc, 1);  ret();                                /* ret */
        }
    }
}
