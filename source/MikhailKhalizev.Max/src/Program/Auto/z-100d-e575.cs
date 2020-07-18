using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_e575-6350370f")]
        public void Method_100d_e575()
        {
            ii(0x100d_e575, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100d_e57a, 5);  call(Definitions.sys_check_available_stack_size, 0x8_77d3);/* call 0x10165d52 */
            ii(0x100d_e57f, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_e580, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_e581, 1);  push(edx);                            /* push edx */
            ii(0x100d_e582, 1);  push(esi);                            /* push esi */
            ii(0x100d_e583, 1);  push(edi);                            /* push edi */
            ii(0x100d_e584, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_e585, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_e587, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_e58d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_e590, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e593, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e599, 5);  call(0x100d_5018, -0x9586);           /* call 0x100d5018 */
            ii(0x100d_e59e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_e5a0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e5a3, 7);  cmp(dx, memw[ds, eax + 995]);         /* cmp dx, [eax+0x3e3] */
            ii(0x100d_e5aa, 6);  if(jl(0x100d_e6f9, 0x149)) goto l_0x100d_e6f9;/* jl 0x100de6f9 */
            ii(0x100d_e5b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e5b3, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e5b9, 5);  call(0x100d_0149, -0xe475);           /* call 0x100d0149 */
            ii(0x100d_e5be, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_e5c1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_e5c5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_e5c8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_e5cb, 6);  add(edx, 0x1cf);                      /* add edx, 0x1cf */
            ii(0x100d_e5d1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_e5d3, 5);  call(0x1007_6730, -0x6_7ea8);         /* call 0x10076730 */
            ii(0x100d_e5d8, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100d_e5da, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_e5df, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x100d_e5e4, 5);  call(0x1007_1e00, -0x6_c7e9);         /* call 0x10071e00 */
            ii(0x100d_e5e9, 4);  mov(dx, memw[ds, ebx + 8]);           /* mov dx, [ebx+0x8] */
            ii(0x100d_e5ed, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_e5f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e5f3, 4);  add(memw[ds, eax + 79], dx);          /* add [eax+0x4f], dx */
            ii(0x100d_e5f7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e5fa, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e600, 5);  call(0x100d_5018, -0x95ed);           /* call 0x100d5018 */
            ii(0x100d_e605, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_e608, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e60b, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_e610, 5);  call(0x100e_08bc, 0x22a7);            /* call 0x100e08bc */
            ii(0x100d_e615, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100d_e618, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_e61d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_e61f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_e622, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_e624, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_e626, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e629, 3);  mov(eax, memd[ds, eax + 77]);         /* mov eax, [eax+0x4d] */
            ii(0x100d_e62c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_e62f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_e631, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_e634, 4);  mov(memw[ds, edx + 79], ax);          /* mov [edx+0x4f], ax */
            ii(0x100d_e638, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e63b, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e641, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_e644, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_e647, 3);  mov(edx, memd[ds, edx + 64]);         /* mov edx, [edx+0x40] */
            ii(0x100d_e64a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_e64d, 3);  call_abs(memd[ds, edx + 8]);          /* call dword [edx+0x8] */
            ii(0x100d_e650, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e653, 6);  mov(eax, memd[ds, eax + 837]);        /* mov eax, [eax+0x345] */
            ii(0x100d_e659, 5);  call(0x100d_0149, -0xe515);           /* call 0x100d0149 */
            ii(0x100d_e65e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_e661, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x100d_e664, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e667, 5);  add(eax, 0x3af);                      /* add eax, 0x3af */
            ii(0x100d_e66c, 5);  call(0x1008_b268, -0x5_3409);         /* call 0x1008b268 */
            ii(0x100d_e671, 1);  cwde();                               /* cwde */
            ii(0x100d_e672, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_e674, 2);  if(jl(0x100d_e6b4, 0x3e)) goto l_0x100d_e6b4;/* jl 0x100de6b4 */
            ii(0x100d_e676, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_e67a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_e67d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_e67f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e682, 5);  add(eax, 0x1cf);                      /* add eax, 0x1cf */
            ii(0x100d_e687, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_e689, 5);  call(0x1007_6730, -0x6_7f5e);         /* call 0x10076730 */
            ii(0x100d_e68e, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x100d_e691, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100d_e694, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_e699, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x100d_e69e, 5);  call(0x1007_1e00, -0x6_c8a3);         /* call 0x10071e00 */
            ii(0x100d_e6a3, 1);  cwde();                               /* cwde */
            ii(0x100d_e6a4, 3);  imul(ebx, eax);                       /* imul ebx, eax */
            ii(0x100d_e6a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e6aa, 3);  mov(eax, memd[ds, eax + 77]);         /* mov eax, [eax+0x4d] */
            ii(0x100d_e6ad, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_e6b0, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x100d_e6b2, 2);  if(jle(0x100d_e6b6, 2)) goto l_0x100d_e6b6;/* jle 0x100de6b6 */
        l_0x100d_e6b4:
            ii(0x100d_e6b4, 2);  jmp(0x100d_e6d6, 0x20); goto l_0x100d_e6d6;/* jmp 0x100de6d6 */
        l_0x100d_e6b6:
            ii(0x100d_e6b6, 5);  call(0x100d_51e4, -0x94d7);           /* call 0x100d51e4 */
            ii(0x100d_e6bb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_e6bd, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_e6bf, 5);  call(0x100d_5204, -0x94c0);           /* call 0x100d5204 */
            ii(0x100d_e6c4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_e6c6, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_e6c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e6cb, 6);  mov(eax, memd[ds, eax + 987]);        /* mov eax, [eax+0x3db] */
            ii(0x100d_e6d1, 5);  call(0x100c_fa7c, -0xec5a);           /* call 0x100cfa7c */
        l_0x100d_e6d6:
            ii(0x100d_e6d6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e6d9, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_e6dc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_e6df, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_e6e2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_e6e5, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_e6eb, 5);  call(0x100d_0149, -0xe5a7);           /* call 0x100d0149 */
            ii(0x100d_e6f0, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_e6f3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_e6f6, 3);  call_abs(memd[ds, ebx + 24]);         /* call dword [ebx+0x18] */
        l_0x100d_e6f9:
            ii(0x100d_e6f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_e6fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_e6fc, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_e6fd, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_e6fe, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_e6ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_e700, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_e701, 1);  ret();                                /* ret */
        }
    }
}
