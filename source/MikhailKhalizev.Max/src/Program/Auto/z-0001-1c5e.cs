using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1c5e-bd48eb00")]
        public void Method_0001_1c5e()
        {
            ii(0x1_1c5e, 2);  mov(bx, sp);                              /* mov bx, sp */
            ii(0x1_1c60, 1);  push(si);                                 /* push si */
            ii(0x1_1c61, 4);  mov(si, memw[ss, bx + 2]);                /* mov si, [ss:bx+0x2] */
            ii(0x1_1c65, 4);  cmp(si, memw[ds, 0x97c]);                 /* cmp si, [0x97c] */
            ii(0x1_1c69, 2);  if(jae_func(0x1_1c5a, -0x11)) return;     /* jae 0x1c5a */
            ii(0x1_1c6b, 1);  push(ds);                                 /* push ds */
            ii(0x1_1c6c, 1);  push(bp);                                 /* push bp */
            ii(0x1_1c6d, 4);  mov(bp, memw[ss, bx + 4]);                /* mov bp, [ss:bx+0x4] */
            ii(0x1_1c71, 5);  cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x1_1c76, 2);  if(jz(0x1_1ca0, 0x28)) goto l_0x1_1ca0;   /* jz 0x1ca0 */
            ii(0x1_1c78, 2);  push(8);                                  /* push 0x8 */
            ii(0x1_1c7a, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_1c7b, 3);  and(si, -8 /* 0xf8 */);                   /* and si, 0xfff8 */
        l_0x1_1c7e:
            ii(0x1_1c7e, 1);  lodsw();                                  /* lodsw */
            ii(0x1_1c7f, 3);  mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x1_1c82, 1);  lodsw();                                  /* lodsw */
            ii(0x1_1c83, 3);  mov(memw[ss, bp], ax);                    /* mov [bp], ax */
            ii(0x1_1c86, 1);  lodsw();                                  /* lodsw */
            ii(0x1_1c87, 3);  mov(memb[ss, bp + 2], al);                /* mov [bp+0x2], al */
            ii(0x1_1c8a, 3);  mov(memb[ss, bp + 8], ah);                /* mov [bp+0x8], ah */
            ii(0x1_1c8d, 1);  lodsw();                                  /* lodsw */
            ii(0x1_1c8e, 2);  and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x1_1c90, 3);  mov(memb[ss, bp + 9], al);                /* mov [bp+0x9], al */
            ii(0x1_1c93, 3);  mov(memb[ss, bp + 3], ah);                /* mov [bp+0x3], ah */
            ii(0x1_1c96, 5);  mov(memw[ss, bp + 6], 0);                 /* mov word [bp+0x6], 0x0 */
            ii(0x1_1c9b, 1);  inc(ax);                                  /* inc ax */
        l_0x1_1c9c:
            ii(0x1_1c9c, 1);  pop(bp);                                  /* pop bp */
            ii(0x1_1c9d, 1);  pop(ds);                                  /* pop ds */
            ii(0x1_1c9e, 1);  pop(si);                                  /* pop si */
            ii(0x1_1c9f, 1);  ret(); return;                            /* ret */
        l_0x1_1ca0:
            ii(0x1_1ca0, 1);  push(ds);                                 /* push ds */
            ii(0x1_1ca1, 1);  pop(es);                                  /* pop es */
            ii(0x1_1ca2, 2);  push(edi);                                /* push edi */
            ii(0x1_1ca4, 3);  xor(edi, edi);                            /* xor edi, edi */
            ii(0x1_1ca7, 3);  mov(di, 0x8c0);                           /* mov di, 0x8c0 */
            ii(0x1_1caa, 2);  mov(si, di);                              /* mov si, di */
            ii(0x1_1cac, 4);  mov(bx, memw[ss, bx + 2]);                /* mov bx, [ss:bx+0x2] */
            ii(0x1_1cb0, 3);  mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0x1_1cb3, 1);  push(cs);                                 /* push cs */
            ii(0x1_1cb4, 3);  call(0xe389, -0x392e);                    /* call 0xe389 */
            ii(0x1_1cb7, 2);  pop(edi);                                 /* pop edi */
            ii(0x1_1cb9, 2);  if(jae(0x1_1c7e, -0x3d)) goto l_0x1_1c7e; /* jae 0x1c7e */
            ii(0x1_1cbb, 2);  xor(ax, ax);                              /* xor ax, ax */
            ii(0x1_1cbd, 2);  jmp(0x1_1c9c, -0x23); goto l_0x1_1c9c;    /* jmp 0x1c9c */
        }
    }
}
