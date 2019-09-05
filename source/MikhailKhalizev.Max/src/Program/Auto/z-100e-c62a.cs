using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c62a-17c33a80")]
        public void Method_100e_c62a()
        {
            ii(0x100e_c62a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_c62f, 5);  call(Definitions.sys_check_available_stack_size, 0x7_971e);/* call 0x10165d52 */
            ii(0x100e_c634, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_c635, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_c636, 1);  push(edx);                            /* push edx */
            ii(0x100e_c637, 1);  push(esi);                            /* push esi */
            ii(0x100e_c638, 1);  push(edi);                            /* push edi */
            ii(0x100e_c639, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_c63a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_c63c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_c642, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_c645, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x100e_c64a, 5);  call(0x1007_6338, -0x7_6317);         /* call 0x10076338 */
            ii(0x100e_c64f, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x100e_c652, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_c654, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100e_c656, 5);  call(0x1007_64b8, -0x7_61a3);         /* call 0x100764b8 */
            ii(0x100e_c65b, 2);  jmp(0x100e_c665, 8); goto l_0x100e_c665;/* jmp 0x100ec665 */
        l_0x100e_c65d:
            ii(0x100e_c65d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c660, 5);  call(0x1007_6bf8, -0x7_5a6d);         /* call 0x10076bf8 */
        l_0x100e_c665:
            ii(0x100e_c665, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c667, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c66a, 5);  call(0x1013_ad71, 0x4_e702);          /* call 0x1013ad71 */
            ii(0x100e_c66f, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_c671, 2);  if(jz(0x100e_c6c5, 0x52)) goto l_0x100e_c6c5;/* jz 0x100ec6c5 */
            ii(0x100e_c673, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c676, 5);  call(0x1007_63a0, -0x7_62db);         /* call 0x100763a0 */
            ii(0x100e_c67b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c67d, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c680, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c684, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_c686, 2);  if(jnz(0x100e_c697, 0xf)) goto l_0x100e_c697;/* jnz 0x100ec697 */
            ii(0x100e_c688, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c68b, 5);  call(0x1007_63a0, -0x7_62f0);         /* call 0x100763a0 */
            ii(0x100e_c690, 5);  cmp(memw[ds, eax + 8], 0x33);         /* cmp word [eax+0x8], 0x33 */
            ii(0x100e_c695, 2);  if(jz(0x100e_c699, 2)) goto l_0x100e_c699;/* jz 0x100ec699 */
        l_0x100e_c697:
            ii(0x100e_c697, 2);  jmp(0x100e_c6b1, 0x18); goto l_0x100e_c6b1;/* jmp 0x100ec6b1 */
        l_0x100e_c699:
            ii(0x100e_c699, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c69c, 5);  call(0x1007_63a0, -0x7_6301);         /* call 0x100763a0 */
            ii(0x100e_c6a1, 5);  call(0x1007_623c, -0x7_646a);         /* call 0x1007623c */
            ii(0x100e_c6a6, 5);  call(0x100e_f36c, 0x2cc1);            /* call 0x100ef36c */
            ii(0x100e_c6ab, 1);  cwde();                               /* cwde */
            ii(0x100e_c6ac, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100e_c6af, 2);  if(jg(0x100e_c6b3, 2)) goto l_0x100e_c6b3;/* jg 0x100ec6b3 */
        l_0x100e_c6b1:
            ii(0x100e_c6b1, 2);  jmp(0x100e_c6c3, 0x10); goto l_0x100e_c6c3;/* jmp 0x100ec6c3 */
        l_0x100e_c6b3:
            ii(0x100e_c6b3, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_c6b7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c6b9, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c6bc, 5);  call(0x1007_5f6c, -0x7_6755);         /* call 0x10075f6c */
            ii(0x100e_c6c1, 2);  jmp(0x100e_c6df, 0x1c); goto l_0x100e_c6df;/* jmp 0x100ec6df */
        l_0x100e_c6c3:
            ii(0x100e_c6c3, 2);  jmp(0x100e_c65d, -0x68); goto l_0x100e_c65d;/* jmp 0x100ec65d */
        l_0x100e_c6c5:
            ii(0x100e_c6c5, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_c6c9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c6cb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c6ce, 5);  call(0x1007_5f6c, -0x7_6767);         /* call 0x10075f6c */
            ii(0x100e_c6d3, 2);  jmp(0x100e_c6df, 0xa); goto l_0x100e_c6df;/* jmp 0x100ec6df */
        //  ii(0x100e_c6d5, 10);  Недостижимый код.
        l_0x100e_c6df:
            ii(0x100e_c6df, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100e_c6e2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_c6e4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_c6e5, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_c6e6, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_c6e7, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_c6e8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_c6e9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_c6ea, 1);  ret();                                /* ret */
        }
    }
}
