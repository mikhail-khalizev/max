using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e501-5ab12644")]
        public void Method_1010_e501()
        {
            ii(0x1010_e501, 5);  push(0x19c);                          /* push 0x19c */
            ii(0x1010_e506, 5);  call(Definitions.sys_check_available_stack_size, 0x5_7847);/* call 0x10165d52 */
            ii(0x1010_e50b, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_e50c, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_e50d, 1);  push(edx);                            /* push edx */
            ii(0x1010_e50e, 1);  push(esi);                            /* push esi */
            ii(0x1010_e50f, 1);  push(edi);                            /* push edi */
            ii(0x1010_e510, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_e511, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_e513, 6);  sub(esp, 0x180);                      /* sub esp, 0x180 */
            ii(0x1010_e519, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x1010_e51c, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_e520, 2);  if(jz(0x1010_e542, 0x20)) goto l_0x1010_e542;/* jz 0x1010e542 */
            ii(0x1010_e522, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_e527, 5);  mov(eax, 0x67);                       /* mov eax, 0x67 */
            ii(0x1010_e52c, 5);  call(0x100c_aafc, -0x4_3a35);         /* call 0x100caafc */
            ii(0x1010_e531, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x1010_e536, 5);  mov(eax, 0x68);                       /* mov eax, 0x68 */
            ii(0x1010_e53b, 5);  call(0x100c_aafc, -0x4_3a44);         /* call 0x100caafc */
            ii(0x1010_e540, 2);  jmp(0x1010_e560, 0x1e); goto l_0x1010_e560;/* jmp 0x1010e560 */
        l_0x1010_e542:
            ii(0x1010_e542, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_e547, 5);  mov(eax, 0x67);                       /* mov eax, 0x67 */
            ii(0x1010_e54c, 5);  call(0x100c_aafc, -0x4_3a55);         /* call 0x100caafc */
            ii(0x1010_e551, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_e556, 5);  mov(eax, 0x68);                       /* mov eax, 0x68 */
            ii(0x1010_e55b, 5);  call(0x100c_aafc, -0x4_3a64);         /* call 0x100caafc */
        l_0x1010_e560:
            ii(0x1010_e560, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_e562, 5);  mov(eax, 0x69);                       /* mov eax, 0x69 */
            ii(0x1010_e567, 5);  call(0x100c_aafc, -0x4_3a70);         /* call 0x100caafc */
            ii(0x1010_e56c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_e56e, 5);  mov(eax, 0x6a);                       /* mov eax, 0x6a */
            ii(0x1010_e573, 5);  call(0x100c_aafc, -0x4_3a7c);         /* call 0x100caafc */
            ii(0x1010_e578, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_e57c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_e57e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_e581, 6);  mov(memd[ss, ebp - 324], eax);        /* mov [ebp-0x144], eax */
            ii(0x1010_e587, 6);  lea(eax, memd[ss, ebp - 336]);        /* lea eax, [ebp-0x150] */
            ii(0x1010_e58d, 5);  call(0x1010_e1e9, -0x3a9);            /* call 0x1010e1e9 */
            ii(0x1010_e592, 10);  mov(memd[ss, ebp - 332], 0);         /* mov dword [ebp-0x14c], 0x0 */
        l_0x1010_e59c:
            ii(0x1010_e59c, 5);  call(/* sys */ 0x1016_b208, 0x5_cc67);/* call 0x1016b208 */
            ii(0x1010_e5a1, 6);  mov(memd[ss, ebp - 320], eax);        /* mov [ebp-0x140], eax */
            ii(0x1010_e5a7, 7);  cmp(memd[ss, ebp - 320], 0);          /* cmp dword [ebp-0x140], 0x0 */
            ii(0x1010_e5ae, 2);  if(jle(0x1010_e5bc, 0xc)) goto l_0x1010_e5bc;/* jle 0x1010e5bc */
            ii(0x1010_e5b0, 10);  cmp(memd[ss, ebp - 320], 0x7000);    /* cmp dword [ebp-0x140], 0x7000 */
            ii(0x1010_e5ba, 2);  if(jl(0x1010_e5be, 2)) goto l_0x1010_e5be;/* jl 0x1010e5be */
        l_0x1010_e5bc:
            ii(0x1010_e5bc, 2);  jmp(0x1010_e5c2, 4); goto l_0x1010_e5c2;/* jmp 0x1010e5c2 */
        l_0x1010_e5be:
            ii(0x1010_e5be, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_e5c2:
            ii(0x1010_e5c2, 10);  mov(memd[ss, ebp - 340], 0);         /* mov dword [ebp-0x154], 0x0 */
            ii(0x1010_e5cc, 2);  jmp(0x1010_e5da, 0xc); goto l_0x1010_e5da;/* jmp 0x1010e5da */
        l_0x1010_e5ce:
            ii(0x1010_e5ce, 6);  mov(eax, memd[ss, ebp - 340]);        /* mov eax, [ebp-0x154] */
            ii(0x1010_e5d4, 6);  inc(memd[ss, ebp - 340]);             /* inc dword [ebp-0x154] */
        l_0x1010_e5da:
            ii(0x1010_e5da, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e5e1, 3);  cmp(eax, 0x13);                       /* cmp eax, 0x13 */
            ii(0x1010_e5e4, 6);  if(jge(0x1010_e6ce, 0xe4)) goto l_0x1010_e6ce;/* jge 0x1010e6ce */
            ii(0x1010_e5ea, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e5f1, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_e5f4, 8);  cmp(memd[ds, eax + ebp - 316], 0);    /* cmp dword [eax+ebp-0x13c], 0x0 */
            ii(0x1010_e5fc, 6);  if(jz(0x1010_e6c9, 0xc7)) goto l_0x1010_e6c9;/* jz 0x1010e6c9 */
            ii(0x1010_e602, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e609, 5);  add(eax, 0x7000);                     /* add eax, 0x7000 */
            ii(0x1010_e60e, 6);  cmp(eax, memd[ss, ebp - 320]);        /* cmp eax, [ebp-0x140] */
            ii(0x1010_e614, 2);  if(jnz(0x1010_e63b, 0x25)) goto l_0x1010_e63b;/* jnz 0x1010e63b */
            ii(0x1010_e616, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_e61a, 2);  if(jnz(0x1010_e632, 0x16)) goto l_0x1010_e632;/* jnz 0x1010e632 */
            ii(0x1010_e61c, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e623, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_e626, 7);  mov(eax, memd[ds, eax + ebp - 316]);  /* mov eax, [eax+ebp-0x13c] */
            ii(0x1010_e62d, 5);  call(0x100c_fbbe, -0x3_ea74);         /* call 0x100cfbbe */
        l_0x1010_e632:
            ii(0x1010_e632, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_e636, 5);  jmp(0x1010_e6ce, 0x93); goto l_0x1010_e6ce;/* jmp 0x1010e6ce */
        l_0x1010_e63b:
            ii(0x1010_e63b, 7);  movsx(edx, memw[ss, ebp - 340]);      /* movsx edx, word [ebp-0x154] */
            ii(0x1010_e642, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_e645, 6);  mov(eax, memd[ss, ebp - 320]);        /* mov eax, [ebp-0x140] */
            ii(0x1010_e64b, 7);  cmp(eax, memd[ds, edx + ebp - 236]);  /* cmp eax, [edx+ebp-0xec] */
            ii(0x1010_e652, 2);  if(jnz(0x1010_e66b, 0x17)) goto l_0x1010_e66b;/* jnz 0x1010e66b */
            ii(0x1010_e654, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e65b, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_e65e, 7);  mov(eax, memd[ds, eax + ebp - 240]);  /* mov eax, [eax+ebp-0xf0] */
            ii(0x1010_e665, 6);  mov(memd[ss, ebp - 320], eax);        /* mov [ebp-0x140], eax */
        l_0x1010_e66b:
            ii(0x1010_e66b, 7);  movsx(edx, memw[ss, ebp - 340]);      /* movsx edx, word [ebp-0x154] */
            ii(0x1010_e672, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_e675, 6);  mov(eax, memd[ss, ebp - 320]);        /* mov eax, [ebp-0x140] */
            ii(0x1010_e67b, 7);  cmp(eax, memd[ds, edx + ebp - 240]);  /* cmp eax, [edx+ebp-0xf0] */
            ii(0x1010_e682, 2);  if(jnz(0x1010_e6c9, 0x45)) goto l_0x1010_e6c9;/* jnz 0x1010e6c9 */
            ii(0x1010_e684, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e68b, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1010_e68e, 2);  if(jge(0x1010_e6a6, 0x16)) goto l_0x1010_e6a6;/* jge 0x1010e6a6 */
            ii(0x1010_e690, 7);  movsx(eax, memw[ss, ebp - 340]);      /* movsx eax, word [ebp-0x154] */
            ii(0x1010_e697, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_e69a, 7);  mov(eax, memd[ds, eax + ebp - 316]);  /* mov eax, [eax+ebp-0x13c] */
            ii(0x1010_e6a1, 5);  call(0x100c_fbbe, -0x3_eae8);         /* call 0x100cfbbe */
        l_0x1010_e6a6:
            ii(0x1010_e6a6, 10);  add(memd[ss, ebp - 320], 0xffff_fc18);/* add dword [ebp-0x140], 0xfffffc18 */
            ii(0x1010_e6b0, 7);  movsx(edx, memw[ss, ebp - 340]);      /* movsx edx, word [ebp-0x154] */
            ii(0x1010_e6b7, 3);  imul(edx, edx, 0xc);                  /* imul edx, edx, 0xc */
            ii(0x1010_e6ba, 6);  lea(eax, memd[ss, ebp - 336]);        /* lea eax, [ebp-0x150] */
            ii(0x1010_e6c0, 7);  call_abs(memd[ds, edx + ebp - 232]);  /* call dword [edx+ebp-0xe8] */
            ii(0x1010_e6c7, 2);  jmp(0x1010_e6ce, 5); goto l_0x1010_e6ce;/* jmp 0x1010e6ce */
        l_0x1010_e6c9:
            ii(0x1010_e6c9, 5);  jmp(0x1010_e5ce, -0x100); goto l_0x1010_e5ce;/* jmp 0x1010e5ce */
        l_0x1010_e6ce:
            ii(0x1010_e6ce, 7);  cmp(memd[ss, ebp - 328], 0);          /* cmp dword [ebp-0x148], 0x0 */
            ii(0x1010_e6d5, 2);  if(jz(0x1010_e6f1, 0x1a)) goto l_0x1010_e6f1;/* jz 0x1010e6f1 */
            ii(0x1010_e6d7, 6);  lea(eax, memd[ss, ebp - 336]);        /* lea eax, [ebp-0x150] */
            ii(0x1010_e6dd, 5);  call(0x1010_e171, -0x571);            /* call 0x1010e171 */
            ii(0x1010_e6e2, 10);  mov(memd[ss, ebp - 344], 0);         /* mov dword [ebp-0x158], 0x0 */
            ii(0x1010_e6ec, 5);  jmp(0x1010_e7d0, 0xdf); goto l_0x1010_e7d0;/* jmp 0x1010e7d0 */
        l_0x1010_e6f1:
            ii(0x1010_e6f1, 7);  cmp(memd[ss, ebp - 332], 0);          /* cmp dword [ebp-0x14c], 0x0 */
            ii(0x1010_e6f8, 6);  if(jz(0x1010_e59c, -0x162)) goto l_0x1010_e59c;/* jz 0x1010e59c */
            ii(0x1010_e6fe, 6);  lea(eax, memd[ss, ebp - 336]);        /* lea eax, [ebp-0x150] */
            ii(0x1010_e704, 5);  call(0x1010_e171, -0x598);            /* call 0x1010e171 */
            ii(0x1010_e709, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_e70c, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1010_e70f, 10);  mov(memd[ss, ebp - 348], 0);         /* mov dword [ebp-0x15c], 0x0 */
            ii(0x1010_e719, 2);  jmp(0x1010_e727, 0xc); goto l_0x1010_e727;/* jmp 0x1010e727 */
        l_0x1010_e71b:
            ii(0x1010_e71b, 6);  mov(eax, memd[ss, ebp - 348]);        /* mov eax, [ebp-0x15c] */
            ii(0x1010_e721, 6);  inc(memd[ss, ebp - 348]);             /* inc dword [ebp-0x15c] */
        l_0x1010_e727:
            ii(0x1010_e727, 7);  movsx(eax, memw[ss, ebp - 348]);      /* movsx eax, word [ebp-0x15c] */
            ii(0x1010_e72e, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1010_e731, 6);  if(jge(0x1010_e7c6, 0x8f)) goto l_0x1010_e7c6;/* jge 0x1010e7c6 */
            ii(0x1010_e737, 6);  mov(al, memb[ss, ebp - 348]);         /* mov al, [ebp-0x15c] */
            ii(0x1010_e73d, 2);  add(al, 0x67);                        /* add al, 0x67 */
            ii(0x1010_e73f, 3);  movsx(eax, al);                       /* movsx eax, al */
            ii(0x1010_e742, 5);  call(0x1007_5fdc, -0x9_876b);         /* call 0x10075fdc */
            ii(0x1010_e747, 6);  mov(memd[ss, ebp - 352], eax);        /* mov [ebp-0x160], eax */
            ii(0x1010_e74d, 4);  cmp(memb[ss, ebp - 12], 0);           /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1010_e751, 2);  if(jz(0x1010_e75f, 0xc)) goto l_0x1010_e75f;/* jz 0x1010e75f */
            ii(0x1010_e753, 7);  movsx(eax, memw[ss, ebp - 352]);      /* movsx eax, word [ebp-0x160] */
            ii(0x1010_e75a, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1010_e75d, 2);  if(jz(0x1010_e761, 2)) goto l_0x1010_e761;/* jz 0x1010e761 */
        l_0x1010_e75f:
            ii(0x1010_e75f, 2);  jmp(0x1010_e79c, 0x3b); goto l_0x1010_e79c;/* jmp 0x1010e79c */
        l_0x1010_e761:
            ii(0x1010_e761, 5);  mov(ecx, 0x1e);                       /* mov ecx, 0x1e */
            ii(0x1010_e766, 6);  lea(ebx, memd[ss, ebp - 384]);        /* lea ebx, [ebp-0x180] */
            ii(0x1010_e76c, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x1010_e771, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1010_e776, 5);  call(0x1010_6281, -0x84fa);           /* call 0x10106281 */
            ii(0x1010_e77b, 6);  lea(ebx, memd[ss, ebp - 384]);        /* lea ebx, [ebp-0x180] */
            ii(0x1010_e781, 6);  mov(al, memb[ss, ebp - 348]);         /* mov al, [ebp-0x15c] */
            ii(0x1010_e787, 2);  add(al, 0x63);                        /* add al, 0x63 */
            ii(0x1010_e789, 3);  movsx(edx, al);                       /* movsx edx, al */
            ii(0x1010_e78c, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1010_e791, 5);  call(0x1010_6205, -0x8591);           /* call 0x10106205 */
            ii(0x1010_e796, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1010_e79a, 2);  jmp(0x1010_e7c1, 0x25); goto l_0x1010_e7c1;/* jmp 0x1010e7c1 */
        l_0x1010_e79c:
            ii(0x1010_e79c, 7);  movsx(eax, memw[ss, ebp - 348]);      /* movsx eax, word [ebp-0x15c] */
            ii(0x1010_e7a3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_e7a6, 6);  mov(ebx, memd[ds, eax + 0x101b_b444]);/* mov ebx, [eax+0x101bb444] */
            ii(0x1010_e7ac, 6);  mov(al, memb[ss, ebp - 348]);         /* mov al, [ebp-0x15c] */
            ii(0x1010_e7b2, 2);  add(al, 0x63);                        /* add al, 0x63 */
            ii(0x1010_e7b4, 3);  movsx(edx, al);                       /* movsx edx, al */
            ii(0x1010_e7b7, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1010_e7bc, 5);  call(0x1010_6205, -0x85bc);           /* call 0x10106205 */
        l_0x1010_e7c1:
            ii(0x1010_e7c1, 5);  jmp(0x1010_e71b, -0xab); goto l_0x1010_e71b;/* jmp 0x1010e71b */
        l_0x1010_e7c6:
            ii(0x1010_e7c6, 10);  mov(memd[ss, ebp - 344], 1);         /* mov dword [ebp-0x158], 0x1 */
        l_0x1010_e7d0:
            ii(0x1010_e7d0, 6);  mov(eax, memd[ss, ebp - 344]);        /* mov eax, [ebp-0x158] */
            ii(0x1010_e7d6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_e7d8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_e7d9, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_e7da, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_e7db, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_e7dc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_e7dd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_e7de, 1);  ret();                                /* ret */
        }
    }
}
