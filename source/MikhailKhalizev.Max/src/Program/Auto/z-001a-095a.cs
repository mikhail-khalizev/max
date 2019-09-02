using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_095a-e058454b")]
        public void Method_001a_095a()
        {
            ii(0x1a_095a, 4); enter(0xa6, 0);                           /* enter 0xa6, 0x0 */
            ii(0x1a_095e, 1); push(si);                                 /* push si */
            ii(0x1a_095f, 1); push(ds);                                 /* push ds */
            ii(0x1a_0960, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0963, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0965, 3); jmp(0x1a_0a2b, 0xc3); goto l_0x1a_0a2b;   /* jmp 0xa2b */
        l_0x1a_0968:
            ii(0x1a_0968, 4); cmp(memb[es, bx], 0x20);                  /* cmp byte [es:bx], 0x20 */
            ii(0x1a_096c, 2); if(jz(0x1a_0974, 6)) goto l_0x1a_0974;    /* jz 0x974 */
            ii(0x1a_096e, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x1a_0972, 2); if(jnz(0x1a_0977, 3)) goto l_0x1a_0977;   /* jnz 0x977 */
        l_0x1a_0974:
            ii(0x1a_0974, 3); jmp(0x1a_0a37, 0xc0); goto l_0x1a_0a37;   /* jmp 0xa37 */
        l_0x1a_0977:
            ii(0x1a_0977, 6); mov(memw[ss, bp - 166], 0);               /* mov word [bp-0xa6], 0x0 */
            ii(0x1a_097d, 2); jmp(0x1a_0992, 0x13); goto l_0x1a_0992;   /* jmp 0x992 */
        l_0x1a_097f:
            ii(0x1a_097f, 4); mov(memb[ss, bp + si - 164], al);         /* mov [bp+si-0xa4], al */
            ii(0x1a_0983, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x1a_0985, 2); if(jz(0x1a_09a4, 0x1d)) goto l_0x1a_09a4; /* jz 0x9a4 */
            ii(0x1a_0987, 2); or(al, al);                               /* or al, al */
            ii(0x1a_0989, 2); if(jz(0x1a_09a4, 0x19)) goto l_0x1a_09a4; /* jz 0x9a4 */
            ii(0x1a_098b, 4); inc(memw[ss, bp - 166]);                  /* inc word [bp-0xa6] */
            ii(0x1a_098f, 3); inc(memw[ss, bp + 18]);                   /* inc word [bp+0x12] */
        l_0x1a_0992:
            ii(0x1a_0992, 3); les(bx, memw[ss, bp + 18]);               /* les bx, [bp+0x12] */
            ii(0x1a_0995, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x1a_0998, 4); mov(si, memw[ss, bp - 166]);              /* mov si, [bp-0xa6] */
            ii(0x1a_099c, 4); mov(memb[ss, bp + si - 164], al);         /* mov [bp+si-0xa4], al */
            ii(0x1a_09a0, 2); cmp(al, 0x3b);                            /* cmp al, 0x3b */
            ii(0x1a_09a2, 2); if(jnz(0x1a_097f, -0x25)) goto l_0x1a_097f; /* jnz 0x97f */
        l_0x1a_09a4:
            ii(0x1a_09a4, 5); cmp(memw[ss, bp - 166], 0);               /* cmp word [bp-0xa6], 0x0 */
            ii(0x1a_09a9, 2); if(jz(0x1a_09c6, 0x1b)) goto l_0x1a_09c6; /* jz 0x9c6 */
            ii(0x1a_09ab, 4); mov(si, memw[ss, bp - 166]);              /* mov si, [bp-0xa6] */
            ii(0x1a_09af, 5); cmp(memb[ss, bp + si - 165], 0x3a);       /* cmp byte [bp+si-0xa5], 0x3a */
            ii(0x1a_09b4, 2); if(jz(0x1a_09c6, 0x10)) goto l_0x1a_09c6; /* jz 0x9c6 */
            ii(0x1a_09b6, 5); cmp(memb[ss, bp + si - 165], 0x5c);       /* cmp byte [bp+si-0xa5], 0x5c */
            ii(0x1a_09bb, 2); if(jz(0x1a_09c6, 9)) goto l_0x1a_09c6;    /* jz 0x9c6 */
            ii(0x1a_09bd, 5); mov(memb[ss, bp + si - 164], 0x5c);       /* mov byte [bp+si-0xa4], 0x5c */
            ii(0x1a_09c2, 4); inc(memw[ss, bp - 166]);                  /* inc word [bp-0xa6] */
        l_0x1a_09c6:
            ii(0x1a_09c6, 4); mov(si, memw[ss, bp - 166]);              /* mov si, [bp-0xa6] */
            ii(0x1a_09ca, 5); mov(memb[ss, bp + si - 164], 0);          /* mov byte [bp+si-0xa4], 0x0 */
            ii(0x1a_09cf, 4); lea(ax, memw[ss, bp - 164]);              /* lea ax, [bp-0xa4] */
            ii(0x1a_09d3, 1); push(ss);                                 /* push ss */
            ii(0x1a_09d4, 1); push(ax);                                 /* push ax */
            ii(0x1a_09d5, 3); push(memw[ss, bp + 16]);                  /* push word [bp+0x10] */
            ii(0x1a_09d8, 3); push(memw[ss, bp + 14]);                  /* push word [bp+0xe] */
            ii(0x1a_09db, 3); call(0x19_ff4a, -0xa94);                  /* call 0xff4a */
            ii(0x1a_09de, 4); lea(ax, memw[ss, bp - 164]);              /* lea ax, [bp-0xa4] */
            ii(0x1a_09e2, 1); push(ss);                                 /* push ss */
            ii(0x1a_09e3, 1); push(ax);                                 /* push ax */
            ii(0x1a_09e4, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_09e7, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_09ea, 3); call(0x19_ff4a, -0xaa3);                  /* call 0xff4a */
            ii(0x1a_09ed, 4); lea(ax, memw[ss, bp - 164]);              /* lea ax, [bp-0xa4] */
            ii(0x1a_09f1, 1); push(ss);                                 /* push ss */
            ii(0x1a_09f2, 1); push(ax);                                 /* push ax */
            ii(0x1a_09f3, 1); push(cs);                                 /* push cs */
            ii(0x1a_09f4, 3); call(0x1a_092a, -0xcd);                   /* call 0x92a */
            ii(0x1a_09f7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_09f9, 2); if(jz(0x1a_0a19, 0x1e)) goto l_0x1a_0a19; /* jz 0xa19 */
            ii(0x1a_09fb, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_09fe, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x1a_0a01, 4); lea(ax, memw[ss, bp - 164]);              /* lea ax, [bp-0xa4] */
            ii(0x1a_0a05, 1); push(ss);                                 /* push ss */
            ii(0x1a_0a06, 1); push(ax);                                 /* push ax */
            ii(0x1a_0a07, 3); call(0x19_ff6c, -0xa9e);                  /* call 0xff6c */
            ii(0x1a_0a0a, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0a0d, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x1a_0a10, 5); call_far_abs(0x80, 0x44e4);               /* call word 0x80:0x44e4 */
            ii(0x1a_0a15, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_0a16, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_0a17, 2); jmp(0x1a_0a37, 0x1e); goto l_0x1a_0a37;   /* jmp 0xa37 */
        l_0x1a_0a19:
            ii(0x1a_0a19, 3); les(bx, memw[ss, bp + 18]);               /* les bx, [bp+0x12] */
            ii(0x1a_0a1c, 4); cmp(memb[es, bx], 0x3b);                  /* cmp byte [es:bx], 0x3b */
            ii(0x1a_0a20, 2); if(jz(0x1a_0a28, 6)) goto l_0x1a_0a28;    /* jz 0xa28 */
            ii(0x1a_0a22, 4); cmp(memb[es, bx], 0x20);                  /* cmp byte [es:bx], 0x20 */
            ii(0x1a_0a26, 2); if(jnz(0x1a_0a2b, 3)) goto l_0x1a_0a2b;   /* jnz 0xa2b */
        l_0x1a_0a28:
            ii(0x1a_0a28, 3); inc(memw[ss, bp + 18]);                   /* inc word [bp+0x12] */
        l_0x1a_0a2b:
            ii(0x1a_0a2b, 3); les(bx, memw[ss, bp + 18]);               /* les bx, [bp+0x12] */
            ii(0x1a_0a2e, 4); cmp(memb[es, bx], 0x3b);                  /* cmp byte [es:bx], 0x3b */
            ii(0x1a_0a32, 2); if(jz(0x1a_0a37, 3)) goto l_0x1a_0a37;    /* jz 0xa37 */
            ii(0x1a_0a34, 3); jmp(0x1a_0968, -0xcf); goto l_0x1a_0968;  /* jmp 0x968 */
        l_0x1a_0a37:
            ii(0x1a_0a37, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0a3a, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x1a_0a3d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x1a_0a3f, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_0a40, 1); pop(si);                                  /* pop si */
            ii(0x1a_0a41, 1); leave();                                  /* leave */
            ii(0x1a_0a42, 3); retf(0x10);                               /* retf 0x10 */
        }
    }
}
