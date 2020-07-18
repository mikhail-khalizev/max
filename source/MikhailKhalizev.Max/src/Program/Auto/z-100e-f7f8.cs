using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f7f8-2b6365e7")]
        public void Method_100e_f7f8()
        {
            ii(0x100e_f7f8, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_f7f9, 1);  push(esi);                            /* push esi */
            ii(0x100e_f7fa, 1);  push(edi);                            /* push edi */
            ii(0x100e_f7fb, 7);  movzx(eax, memb[ds, 0x101c_3644]);    /* movzx eax, byte [0x101c3644] */
            ii(0x100e_f802, 2);  and(al, 0xe0);                        /* and al, 0xe0 */
            ii(0x100e_f804, 3);  shl(eax, 3);                          /* shl eax, 0x3 */
            ii(0x100e_f807, 6);  add(eax, memd[ds, 0x101c_945c]);      /* add eax, [0x101c945c] */
            ii(0x100e_f80d, 5);  mov(memd[ds, 0x101b_8714], eax);      /* mov [0x101b8714], eax */
            ii(0x100e_f812, 7);  movzx(eax, memw[ds, 0x101c_3652]);    /* movzx eax, word [0x101c3652] */
            ii(0x100e_f819, 6);  mul(memd[ds, 0x101c_364c]);           /* mul dword [0x101c364c] */
            ii(0x100e_f81f, 2);  jmp(0x100e_f82c, 0xb); goto l_0x100e_f82c;/* jmp 0x100ef82c */
        l_0x100e_f821:
            ii(0x100e_f821, 5);  mov(eax, memd[ds, 0x101b_86d0]);      /* mov eax, [0x101b86d0] */
            ii(0x100e_f826, 6);  add(eax, memd[ds, 0x101c_364c]);      /* add eax, [0x101c364c] */
        l_0x100e_f82c:
            ii(0x100e_f82c, 5);  mov(memd[ds, 0x101b_86d0], eax);      /* mov [0x101b86d0], eax */
            ii(0x100e_f831, 3);  shr(eax, 0x10);                       /* shr eax, 0x10 */
            ii(0x100e_f834, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_f837, 6);  add(eax, memd[ds, 0x101c_3634]);      /* add eax, [0x101c3634] */
            ii(0x100e_f83d, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_f83f, 6);  add(eax, memd[ds, 0x101c_363c]);      /* add eax, [0x101c363c] */
            ii(0x100e_f845, 5);  mov(memd[ds, 0x101b_8718], eax);      /* mov [0x101b8718], eax */
            ii(0x100e_f84a, 6);  mov(edi, memd[ds, 0x101c_3638]);      /* mov edi, [0x101c3638] */
            ii(0x100e_f850, 9);  mov(memw[ds, 0x101b_86d4], 0);        /* mov word [0x101b86d4], 0x0 */
            ii(0x100e_f859, 9);  mov(memw[ds, 0x101b_86d6], 0);        /* mov word [0x101b86d6], 0x0 */
            ii(0x100e_f862, 6);  mov(ax, memw[ds, 0x101c_3650]);       /* mov ax, [0x101c3650] */
            ii(0x100e_f868, 6);  mov(memw[ds, 0x101b_86d8], ax);       /* mov [0x101b86d8], ax */
            ii(0x100e_f86e, 6);  mov(ax, memw[ds, 0x101c_3654]);       /* mov ax, [0x101c3654] */
            ii(0x100e_f874, 6);  mov(memw[ds, 0x101b_86da], ax);       /* mov [0x101b86da], ax */
        l_0x100e_f87a:
            ii(0x100e_f87a, 6);  mov(esi, memd[ds, 0x101b_8718]);      /* mov esi, [0x101b8718] */
            ii(0x100e_f880, 3);  movzx(eax, memw[ds, esi]);            /* movzx eax, word [esi] */
            ii(0x100e_f883, 2);  cmp(al, -1 /* 0xff */);               /* cmp al, 0xff */
            ii(0x100e_f885, 6);  if(jz(0x100e_fa04, 0x179)) goto l_0x100e_fa04;/* jz 0x100efa04 */
            ii(0x100e_f88b, 3);  movzx(ebx, ah);                       /* movzx ebx, ah */
            ii(0x100e_f88e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100e_f890, 1);  inc(esi);                             /* inc esi */
            ii(0x100e_f891, 1);  inc(esi);                             /* inc esi */
            ii(0x100e_f892, 6);  mov(memd[ds, 0x101b_8718], esi);      /* mov [0x101b8718], esi */
            ii(0x100e_f898, 6);  add(memd[ds, 0x101b_8718], ebx);      /* add [0x101b8718], ebx */
            ii(0x100e_f89e, 7);  add(memw[ds, 0x101b_86d4], ax);       /* add [0x101b86d4], ax */
            ii(0x100e_f8a5, 2);  if(jz(0x100e_f8fb, 0x54)) goto l_0x100e_f8fb;/* jz 0x100ef8fb */
            ii(0x100e_f8a7, 6);  mov(ax, memw[ds, 0x101b_86d4]);       /* mov ax, [0x101b86d4] */
            ii(0x100e_f8ad, 3);  shl(eax, 0x10);                       /* shl eax, 0x10 */
            ii(0x100e_f8b0, 1);  cdq();                                /* cdq */
            ii(0x100e_f8b1, 6);  div(memd[ds, 0x101c_3648]);           /* div dword [0x101c3648] */
            ii(0x100e_f8b7, 2);  inc(ax);                              /* inc ax */
            ii(0x100e_f8b9, 7);  sub(ax, memw[ds, 0x101b_86d6]);       /* sub ax, [0x101b86d6] */
            ii(0x100e_f8c0, 7);  add(memw[ds, 0x101b_86d6], ax);       /* add [0x101b86d6], ax */
            ii(0x100e_f8c7, 8);  cmp(memw[ds, 0x101b_86d8], 0);        /* cmp word [0x101b86d8], 0x0 */
            ii(0x100e_f8cf, 2);  if(jz(0x100e_f8ec, 0x1b)) goto l_0x100e_f8ec;/* jz 0x100ef8ec */
            ii(0x100e_f8d1, 7);  sub(memw[ds, 0x101b_86d8], ax);       /* sub [0x101b86d8], ax */
            ii(0x100e_f8d8, 2);  if(jge(0x100e_f8fb, 0x21)) goto l_0x100e_f8fb;/* jge 0x100ef8fb */
            ii(0x100e_f8da, 6);  mov(ax, memw[ds, 0x101b_86d8]);       /* mov ax, [0x101b86d8] */
            ii(0x100e_f8e0, 3);  neg(ax);                              /* neg ax */
            ii(0x100e_f8e3, 9);  mov(memw[ds, 0x101b_86d8], 0);        /* mov word [0x101b86d8], 0x0 */
        l_0x100e_f8ec:
            ii(0x100e_f8ec, 7);  sub(memw[ds, 0x101b_86da], ax);       /* sub [0x101b86da], ax */
            ii(0x100e_f8f3, 6);  if(jle(0x100e_fa04, 0x10b)) goto l_0x100e_fa04;/* jle 0x100efa04 */
            ii(0x100e_f8f9, 2);  add(edi, eax);                        /* add edi, eax */
        l_0x100e_f8fb:
            ii(0x100e_f8fb, 7);  movzx(eax, memw[ds, 0x101b_86d4]);    /* movzx eax, word [0x101b86d4] */
            ii(0x100e_f902, 2);  sub(esi, eax);                        /* sub esi, eax */
            ii(0x100e_f904, 3);  add(ax, bx);                          /* add ax, bx */
            ii(0x100e_f907, 6);  mov(memw[ds, 0x101b_86d4], ax);       /* mov [0x101b86d4], ax */
            ii(0x100e_f90d, 3);  shl(eax, 0x10);                       /* shl eax, 0x10 */
            ii(0x100e_f910, 1);  cdq();                                /* cdq */
            ii(0x100e_f911, 6);  div(memd[ds, 0x101c_3648]);           /* div dword [0x101c3648] */
            ii(0x100e_f917, 2);  inc(ax);                              /* inc ax */
            ii(0x100e_f919, 7);  movzx(ebp, memw[ds, 0x101b_86d6]);    /* movzx ebp, word [0x101b86d6] */
            ii(0x100e_f920, 3);  sub(ax, bp);                          /* sub ax, bp */
            ii(0x100e_f923, 7);  add(memw[ds, 0x101b_86d6], ax);       /* add [0x101b86d6], ax */
            ii(0x100e_f92a, 8);  cmp(memw[ds, 0x101b_86d8], 0);        /* cmp word [0x101b86d8], 0x0 */
            ii(0x100e_f932, 2);  if(jz(0x100e_f95d, 0x29)) goto l_0x100e_f95d;/* jz 0x100ef95d */
            ii(0x100e_f934, 7);  sub(memw[ds, 0x101b_86d8], ax);       /* sub [0x101b86d8], ax */
            ii(0x100e_f93b, 6);  if(jge(0x100e_f87a, -0xc7)) goto l_0x100e_f87a;/* jge 0x100ef87a */
            ii(0x100e_f941, 7);  add(bp, memw[ds, 0x101b_86d8]);       /* add bp, [0x101b86d8] */
            ii(0x100e_f948, 3);  add(bp, ax);                          /* add bp, ax */
            ii(0x100e_f94b, 6);  mov(ax, memw[ds, 0x101b_86d8]);       /* mov ax, [0x101b86d8] */
            ii(0x100e_f951, 3);  neg(ax);                              /* neg ax */
            ii(0x100e_f954, 9);  mov(memw[ds, 0x101b_86d8], 0);        /* mov word [0x101b86d8], 0x0 */
        l_0x100e_f95d:
            ii(0x100e_f95d, 7);  sub(memw[ds, 0x101b_86da], ax);       /* sub [0x101b86da], ax */
            ii(0x100e_f964, 2);  if(jge(0x100e_f976, 0x10)) goto l_0x100e_f976;/* jge 0x100ef976 */
            ii(0x100e_f966, 7);  add(ax, memw[ds, 0x101b_86da]);       /* add ax, [0x101b86da] */
            ii(0x100e_f96d, 9);  mov(memw[ds, 0x101b_86da], 0);        /* mov word [0x101b86da], 0x0 */
        l_0x100e_f976:
            ii(0x100e_f976, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100e_f978, 3);  if(jcxz(0x100e_f9aa, 0x2f)) goto l_0x100e_f9aa;/* jcxz 0x100ef9aa */
            ii(0x100e_f97b, 6);  add(edi, memd[ds, 0x101c_9474]);      /* add edi, [0x101c9474] */
            ii(0x100e_f981, 7);  cmp(memb[ds, 0x101c_3645], 0);        /* cmp byte [0x101c3645], 0x0 */
            ii(0x100e_f988, 2);  if(jz(0x100e_f9af, 0x25)) goto l_0x100e_f9af;/* jz 0x100ef9af */
            ii(0x100e_f98a, 5);  mov(eax, memd[ds, 0x101b_8714]);      /* mov eax, [0x101b8714] */
            ii(0x100e_f98f, 5);  mov(al, memb[ds, 0x101c_3645]);       /* mov al, [0x101c3645] */
            ii(0x100e_f994, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100e_f996, 2);  mov(ah, al);                          /* mov ah, al */
            ii(0x100e_f998, 3);  shr(cx, 1);                           /* shr cx, 1 */
            ii(0x100e_f99b, 3);  rep(() => stosw());                   /* rep stosw */
            ii(0x100e_f99e, 4);  adc(cx, 0);                           /* adc cx, 0x0 */
            ii(0x100e_f9a2, 2);  rep(() => stosb());                   /* rep stosb */
            ii(0x100e_f9a4, 6);  sub(edi, memd[ds, 0x101c_9474]);      /* sub edi, [0x101c9474] */
        l_0x100e_f9aa:
            ii(0x100e_f9aa, 5);  jmp(0x100e_f87a, -0x135); goto l_0x100e_f87a;/* jmp 0x100ef87a */
        l_0x100e_f9af:
            ii(0x100e_f9af, 5);  mov(eax, memd[ds, 0x101c_3648]);      /* mov eax, [0x101c3648] */
            ii(0x100e_f9b4, 2);  mul(ebp);                             /* mul ebp */
            ii(0x100e_f9b6, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x100e_f9b8, 5);  mov(eax, memd[ds, 0x101c_3640]);      /* mov eax, [0x101c3640] */
            ii(0x100e_f9bd, 6);  mov(edx, memd[ds, 0x101b_8714]);      /* mov edx, [0x101b8714] */
            ii(0x100e_f9c3, 2);  mov(bl, cl);                          /* mov bl, cl */
            ii(0x100e_f9c5, 3);  shr(cx, 1);                           /* shr cx, 1 */
            ii(0x100e_f9c8, 4);  adc(cx, 0);                           /* adc cx, 0x0 */
            ii(0x100e_f9cc, 3);  test(bl, 1);                          /* test bl, 0x1 */
            ii(0x100e_f9cf, 2);  if(jnz(0x100e_f9e4, 0x13)) goto l_0x100e_f9e4;/* jnz 0x100ef9e4 */
        l_0x100e_f9d1:
            ii(0x100e_f9d1, 2);  mov(ebx, ebp);                        /* mov ebx, ebp */
            ii(0x100e_f9d3, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x100e_f9d6, 3);  mov(al, memb[ds, esi + ebx]);         /* mov al, [esi+ebx] */
            ii(0x100e_f9d9, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x100e_f9db, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x100e_f9dd, 1);  stosb();                              /* stosb */
            ii(0x100e_f9de, 6);  add(ebp, memd[ds, 0x101c_3648]);      /* add ebp, [0x101c3648] */
        l_0x100e_f9e4:
            ii(0x100e_f9e4, 2);  mov(ebx, ebp);                        /* mov ebx, ebp */
            ii(0x100e_f9e6, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x100e_f9e9, 3);  mov(al, memb[ds, esi + ebx]);         /* mov al, [esi+ebx] */
            ii(0x100e_f9ec, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x100e_f9ee, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x100e_f9f0, 1);  stosb();                              /* stosb */
            ii(0x100e_f9f1, 6);  add(ebp, memd[ds, 0x101c_3648]);      /* add ebp, [0x101c3648] */
            ii(0x100e_f9f7, 2);  if(loop(0x100e_f9d1, -0x28)) goto l_0x100e_f9d1;/* loop 0x100ef9d1 */
            ii(0x100e_f9f9, 6);  sub(edi, memd[ds, 0x101c_9474]);      /* sub edi, [0x101c9474] */
            ii(0x100e_f9ff, 5);  jmp(0x100e_f87a, -0x18a); goto l_0x100e_f87a;/* jmp 0x100ef87a */
        l_0x100e_fa04:
            ii(0x100e_fa04, 7);  movzx(eax, memw[ds, 0x101b_7f5c]);    /* movzx eax, word [0x101b7f5c] */
            ii(0x100e_fa0b, 6);  add(memd[ds, 0x101c_3638], eax);      /* add [0x101c3638], eax */
            ii(0x100e_fa11, 7);  dec(memw[ds, 0x101c_3656]);           /* dec word [0x101c3656] */
            ii(0x100e_fa18, 6);  if(jnz(0x100e_f821, -0x1fd)) goto l_0x100e_f821;/* jnz 0x100ef821 */
            ii(0x100e_fa1e, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_fa1f, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_fa20, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_fa21, 1);  ret();                                /* ret */
        }
    }
}
