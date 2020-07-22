using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f634-d8cbbd00")]
        public void Method_1014_f634()
        {
            ii(0x1014_f634, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_f639, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6714);/* call 0x10165d52 */
            ii(0x1014_f63e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_f63f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_f640, 1);  push(esi);                            /* push esi */
            ii(0x1014_f641, 1);  push(edi);                            /* push edi */
            ii(0x1014_f642, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f643, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f645, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_f64b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_f64e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f651, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f654, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_f656, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1014_f659, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f65d, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1014_f65f, 2);  if(jz(0x1014_f66a, 9)) goto l_0x1014_f66a;/* jz 0x1014f66a */
            ii(0x1014_f661, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f664, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1014_f668, 2);  if(jnz(0x1014_f66c, 2)) goto l_0x1014_f66c;/* jnz 0x1014f66c */
        l_0x1014_f66a:
            ii(0x1014_f66a, 2);  jmp(0x1014_f67c, 0x10); goto l_0x1014_f67c;/* jmp 0x1014f67c */
        l_0x1014_f66c:
            ii(0x1014_f66c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f670, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f673, 7);  cmp(memb[ds, eax + 171], 0);          /* cmp byte [eax+0xab], 0x0 */
            ii(0x1014_f67a, 2);  if(jz(0x1014_f681, 5)) goto l_0x1014_f681;/* jz 0x1014f681 */
        l_0x1014_f67c:
            ii(0x1014_f67c, 5);  jmp(0x1014_f784, 0x103); goto l_0x1014_f784;/* jmp 0x1014f784 */
        l_0x1014_f681:
            ii(0x1014_f681, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f685, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f688, 7);  mov(memb[ds, eax + 171], 1);          /* mov byte [eax+0xab], 0x1 */
            ii(0x1014_f68f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f693, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f696, 7);  mov(memb[ds, eax + 176], 1);          /* mov byte [eax+0xb0], 0x1 */
            ii(0x1014_f69d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6a0, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_f6a3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f6a8, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1014_f6ae, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1014_f6b4, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f6b9, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1014_f6bc, 2);  if(jnz(0x1014_f6c6, 8)) goto l_0x1014_f6c6;/* jnz 0x1014f6c6 */
            ii(0x1014_f6be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6c1, 5);  call(0x100a_9eb9, -0xa_580d);         /* call 0x100a9eb9 */
        l_0x1014_f6c6:
            ii(0x1014_f6c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6c9, 5);  call(0x1014_9fa8, -0x5726);           /* call 0x10149fa8 */
            ii(0x1014_f6ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6d1, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f6d6, 2);  if(jnz(0x1014_f6e1, 9)) goto l_0x1014_f6e1;/* jnz 0x1014f6e1 */
            ii(0x1014_f6d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6db, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1014_f6df, 2);  if(jz(0x1014_f6e3, 2)) goto l_0x1014_f6e3;/* jz 0x1014f6e3 */
        l_0x1014_f6e1:
            ii(0x1014_f6e1, 2);  jmp(0x1014_f6eb, 8); goto l_0x1014_f6eb;/* jmp 0x1014f6eb */
        l_0x1014_f6e3:
            ii(0x1014_f6e3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6e6, 5);  call(0x1015_c858, 0xd16d);            /* call 0x1015c858 */
        l_0x1014_f6eb:
            ii(0x1014_f6eb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6ee, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1014_f6f3, 2);  if(jz(0x1014_f6ff, 0xa)) goto l_0x1014_f6ff;/* jz 0x1014f6ff */
            ii(0x1014_f6f5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f6f8, 5);  cmp(memw[ds, eax + 8], 0x41);         /* cmp word [eax+0x8], 0x41 */
            ii(0x1014_f6fd, 2);  if(jnz(0x1014_f724, 0x25)) goto l_0x1014_f724;/* jnz 0x1014f724 */
        l_0x1014_f6ff:
            ii(0x1014_f6ff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f702, 6);  mov(memw[ds, eax + 51], 8);           /* mov word [eax+0x33], 0x8 */
            ii(0x1014_f708, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f70b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_f70d, 3);  mov(dl, memb[ds, eax + 41]);          /* mov dl, [eax+0x29] */
            ii(0x1014_f710, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f713, 4);  mov(ax, memw[ds, eax + 51]);          /* mov ax, [eax+0x33] */
            ii(0x1014_f717, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1014_f719, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_f71c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f71f, 5);  call(0x1014_9b07, -0x5c1d);           /* call 0x10149b07 */
        l_0x1014_f724:
            ii(0x1014_f724, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f728, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f72b, 5);  call(0x100a_9060, -0xa_66d0);         /* call 0x100a9060 */
            ii(0x1014_f730, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f734, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_f736, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1014_f73b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1014_f73d, 2);  if(jnz(0x1014_f749, 0xa)) goto l_0x1014_f749;/* jnz 0x1014f749 */
            ii(0x1014_f73f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f742, 5);  call(0x1014_f544, -0x203);            /* call 0x1014f544 */
            ii(0x1014_f747, 2);  jmp(0x1014_f784, 0x3b); goto l_0x1014_f784;/* jmp 0x1014f784 */
        l_0x1014_f749:
            ii(0x1014_f749, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f74c, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1014_f751, 2);  if(jnz(0x1014_f766, 0x13)) goto l_0x1014_f766;/* jnz 0x1014f766 */
            ii(0x1014_f753, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f756, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_f758, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1014_f75b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_f75d, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1014_f762, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1014_f764, 2);  if(jz(0x1014_f768, 2)) goto l_0x1014_f768;/* jz 0x1014f768 */
        l_0x1014_f766:
            ii(0x1014_f766, 2);  jmp(0x1014_f784, 0x1c); goto l_0x1014_f784;/* jmp 0x1014f784 */
        l_0x1014_f768:
            ii(0x1014_f768, 5);  call(0x100d_5470, -0x7_a2fd);         /* call 0x100d5470 */
            ii(0x1014_f76d, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1014_f770, 5);  mov(ebx, 0x3eb);                      /* mov ebx, 0x3eb */
            ii(0x1014_f775, 5);  mov(edx, 0x3ea);                      /* mov edx, 0x3ea */
            ii(0x1014_f77a, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1014_f77f, 5);  call(0x1013_daea, -0x1_1c9a);         /* call 0x1013daea */
        l_0x1014_f784:
            ii(0x1014_f784, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_f786, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_f787, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_f788, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_f789, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_f78a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_f78b, 1);  ret();                                /* ret */
        }
    }
}
