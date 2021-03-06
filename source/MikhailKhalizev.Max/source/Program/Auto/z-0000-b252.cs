using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb252-deafb8c6")]
        public void Method_0000_b252()
        {
            ii(0xb252, 5);  cmp(memb[ds, 0xe00], 0);                   /* cmp byte [0xe00], 0x0 */
            ii(0xb257, 2);  if(jz_func(0xb251, -8)) return;            /* jz 0xb251 */
            ii(0xb259, 3);  call(0x4f8a, -0x62d2);                     /* call 0x4f8a */
            ii(0xb25c, 3);  call(0x375c, -0x7b03);                     /* call 0x375c */
            ii(0xb25f, 5);  cmp(memb[ds, 0xdff], 0);                   /* cmp byte [0xdff], 0x0 */
            ii(0xb264, 2);  if(jz(0xb27c, 0x16)) goto l_0xb27c;        /* jz 0xb27c */
            ii(0xb266, 4);  mov(cx, memw[ds, 0xece]);                  /* mov cx, [0xece] */
            ii(0xb26a, 4);  sub(cx, 0x1000);                           /* sub cx, 0x1000 */
            ii(0xb26e, 3);  shr(cx, 0xc);                              /* shr cx, 0xc */
            ii(0xb271, 1);  inc(cx);                                   /* inc cx */
            ii(0xb272, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0xb277, 2);  if(jz_func(0xb21b, -0x5e)) return;         /* jz 0xb21b */
            ii(0xb279, 3);  if(jmp_func(0xafec, -0x290)) return;       /* jmp 0xafec */
        l_0xb27c:
            ii(0xb27c, 4);  mov(cx, memw[ds, 0xdfa]);                  /* mov cx, [0xdfa] */
            ii(0xb280, 2);  if(jcxz_func(0xb251, -0x31)) return;       /* jcxz 0xb251 */
            ii(0xb282, 5);  cmp(memw[ds, 0xadc], 0);                   /* cmp word [0xadc], 0x0 */
            ii(0xb287, 2);  if(jz_func(0xb251, -0x38)) return;         /* jz 0xb251 */
            ii(0xb289, 1);  push(si);                                  /* push si */
            ii(0xb28a, 1);  push(di);                                  /* push di */
            ii(0xb28b, 6);  movzx(eax, memw[ds, 0xeca]);               /* movzx eax, word [0xeca] */
            ii(0xb291, 4);  shl(eax, 0xa);                             /* shl eax, 0xa */
            ii(0xb295, 5);  mov(edx, memd[ds, 0x98]);                  /* mov edx, [0x98] */
            ii(0xb29a, 4);  shl(edx, 4);                               /* shl edx, 0x4 */
            ii(0xb29e, 3);  sub(edx, eax);                             /* sub edx, eax */
            ii(0xb2a1, 3);  neg(edx);                                  /* neg edx */
            ii(0xb2a4, 3);  and(dh, 0xf);                              /* and dh, 0xf */
            ii(0xb2a7, 2);  push(eax);                                 /* push eax */
            ii(0xb2a9, 3);  or(ax, 0xeee);                             /* or ax, 0xeee */
            ii(0xb2ac, 2);  push(eax);                                 /* push eax */
            ii(0xb2ae, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0xb2b0, 2);  push(0);                                   /* push 0x0 */
            ii(0xb2b2, 1);  push(dx);                                  /* push dx */
            ii(0xb2b3, 4);  push(memw[ds, 0xadc]);                     /* push word [0xadc] */
            ii(0xb2b7, 1);  push(ss);                                  /* push ss */
            ii(0xb2b8, 1);  push(bx);                                  /* push bx */
            ii(0xb2b9, 2);  push(0);                                   /* push 0x0 */
            ii(0xb2bb, 2);  push(0);                                   /* push 0x0 */
            ii(0xb2bd, 2);  push(4);                                   /* push 0x4 */
            ii(0xb2bf, 2);  mov(si, sp);                               /* mov si, sp */
            ii(0xb2c1, 6);  mov(edi, 0x1000);                          /* mov edi, 0x1000 */
            ii(0xb2c7, 3);  shr(cx, 2);                                /* shr cx, 0x2 */
        l_0xb2ca:
            ii(0xb2ca, 2);  mov(ah, 0xb);                              /* mov ah, 0xb */
            ii(0xb2cc, 4);  call_far_ind(memw[ds, 0xaec]);             /* call far word [0xaec] */
            ii(0xb2d0, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xb2d2, 2);  if(jz(0xb311, 0x3d)) goto l_0xb311;        /* jz 0xb311 */
            ii(0xb2d4, 3);  add(memd[ds, bx], edi);                    /* add [bx], edi */
            ii(0xb2d7, 4);  add(memd[ds, si + 12], edi);               /* add [si+0xc], edi */
            ii(0xb2db, 2);  if(loop(0xb2ca, -0x13)) goto l_0xb2ca;     /* loop 0xb2ca */
            ii(0xb2dd, 3);  call(0x3880, -0x7a60);                     /* call 0x3880 */
            ii(0xb2e0, 2);  push(0x38);                                /* push 0x38 */
            ii(0xb2e2, 1);  pop(es);                                   /* pop es */
            ii(0xb2e3, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0xb2e5, 4);  mov(ebx, memd[ds, bx + 20]);               /* mov ebx, [bx+0x14] */
            ii(0xb2e9, 3);  mov(eax, ebx);                             /* mov eax, ebx */
            ii(0xb2ec, 3);  or(ax, 0xeee);                             /* or ax, 0xeee */
            ii(0xb2ef, 4);  mov(cx, memw[ds, 0xdfa]);                  /* mov cx, [0xdfa] */
            ii(0xb2f3, 3);  shr(cx, 2);                                /* shr cx, 0x2 */
        l_0xb2f6:
            ii(0xb2f6, 5);  cmp(eax, memd_a32[es, ebx]);               /* cmp eax, [es:ebx] */
            ii(0xb2fb, 2);  if(jnz(0xb30e, 0x11)) goto l_0xb30e;       /* jnz 0xb30e */
            ii(0xb2fd, 3);  add(ebx, edi);                             /* add ebx, edi */
            ii(0xb300, 3);  add(eax, edi);                             /* add eax, edi */
            ii(0xb303, 2);  if(loop(0xb2f6, -0xf)) goto l_0xb2f6;      /* loop 0xb2f6 */
            ii(0xb305, 3);  call(0x3f1c, -0x73ec);                     /* call 0x3f1c */
        l_0xb308:
            ii(0xb308, 3);  add(sp, 0x18);                             /* add sp, 0x18 */
            ii(0xb30b, 1);  pop(di);                                   /* pop di */
            ii(0xb30c, 1);  pop(si);                                   /* pop si */
            ii(0xb30d, 1);  ret(); return;                             /* ret */
        l_0xb30e:
            ii(0xb30e, 3);  call(0x3f1c, -0x73f5);                     /* call 0x3f1c */
        l_0xb311:
            ii(0xb311, 4);  mov(cx, memw[ds, 0xdfa]);                  /* mov cx, [0xdfa] */
            ii(0xb315, 4);  add(memw[ds, 0xeca], cx);                  /* add [0xeca], cx */
            ii(0xb319, 3);  mov(ax, memw[ds, 0xaa]);                   /* mov ax, [0xaa] */
            ii(0xb31c, 3);  add(ah, 2);                                /* add ah, 0x2 */
            ii(0xb31f, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0xb321, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0xb323, 2);  xor(di, di);                               /* xor di, di */
            ii(0xb325, 2);  shr(cx, 1);                                /* shr cx, 1 */
            ii(0xb327, 2);  rep(() => stosw());                        /* rep stosw */
            ii(0xb329, 3);  call(0x53e7, -0x5f45);                     /* call 0x53e7 */
            ii(0xb32c, 2);  jmp(0xb308, -0x26); goto l_0xb308;         /* jmp 0xb308 */
        }
    }
}
