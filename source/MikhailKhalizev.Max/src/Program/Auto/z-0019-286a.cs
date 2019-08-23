using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_286a-137e0a5a")]
        public void Method_0019_286a()
        {
            ii(0x19_286a, 3); mov(ax, 0x3500);                          /* mov ax, 0x3500 */
            ii(0x19_286d, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_286f, 4); mov(memw_a16[ds, 0x3c04], bx);            /* mov [0x3c04], bx */
            ii(0x19_2873, 4); mov(memw_a16[ds, 0x3c06], es);            /* mov [0x3c06], es */
            ii(0x19_2877, 1); pushw(cs);                                /* push cs */
            ii(0x19_2878, 1); popw(ds);                                 /* pop ds */
            ii(0x19_2879, 3); mov(ax, 0x2500);                          /* mov ax, 0x2500 */
            ii(0x19_287c, 3); mov(dx, 0x2d63);                          /* mov dx, 0x2d63 */
            ii(0x19_287f, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_2881, 1); pushw(ss);                                /* push ss */
            ii(0x19_2882, 1); popw(ds);                                 /* pop ds */
            ii(0x19_2883, 4); mov(cx, memw_a16[ds, 0x3f7a]);            /* mov cx, [0x3f7a] */
            ii(0x19_2887, 2); if(jcxzw(0x19_28b7, 0x2e)) goto l_0x19_28b7; /* jcxz 0x28b7 */
            ii(0x19_2889, 4); mov(es, memw_a16[ds, 0x3c18]);            /* mov es, [0x3c18] */
            ii(0x19_288d, 5); mov(si, memw_a16[es, 0x2c]);              /* mov si, [es:0x2c] */
            ii(0x19_2892, 4); lds(ax, ds, 0x3f7c);                      /* lds ax, [0x3f7c] */
            ii(0x19_2896, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_2898, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x19_289a, 5); callw_a16_far_ind(ss, 0x3f78);            /* call far word [ss:0x3f78] */
            ii(0x19_289f, 2); if(jaew(0x19_28a6, 0x5)) goto l_0x19_28a6; /* jae 0x28a6 */
            ii(0x19_28a1, 1); pushw(ss);                                /* push ss */
            ii(0x19_28a2, 1); popw(ds);                                 /* pop ds */
            ii(0x19_28a3, 3); if(jmpw_func(0x19_3ab8, 0x1212)) return;  /* jmp 0x3ab8 */
        l_0x19_28a6:
            ii(0x19_28a6, 5); lds(ax, ss, 0x3f80);                      /* lds ax, [ss:0x3f80] */
            ii(0x19_28ab, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_28ad, 3); mov(bx, 0x3);                             /* mov bx, 0x3 */
            ii(0x19_28b0, 5); callw_a16_far_ind(ss, 0x3f78);            /* call far word [ss:0x3f78] */
            ii(0x19_28b5, 1); pushw(ss);                                /* push ss */
            ii(0x19_28b6, 1); popw(ds);                                 /* pop ds */
        l_0x19_28b7:
            ii(0x19_28b7, 4); mov(es, memw_a16[ds, 0x3c18]);            /* mov es, [0x3c18] */
            ii(0x19_28bb, 5); mov(cx, memw_a16[es, 0x2c]);              /* mov cx, [es:0x2c] */
            ii(0x19_28c0, 2); if(jcxzw(0x19_2900, 0x3e)) goto l_0x19_2900; /* jcxz 0x2900 */
            ii(0x19_28c2, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_28c4, 2); xor(di, di);                              /* xor di, di */
        l_0x19_28c6:
            ii(0x19_28c6, 4); cmp(memb_a16[es, di], 0);                 /* cmp byte [es:di], 0x0 */
            ii(0x19_28ca, 2); if(jzw(0x19_2900, 0x34)) goto l_0x19_2900; /* jz 0x2900 */
            ii(0x19_28cc, 3); mov(cx, 0xd);                             /* mov cx, 0xd */
            ii(0x19_28cf, 3); mov(si, 0x3bf6);                          /* mov si, 0x3bf6 */
            ii(0x19_28d2, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x19_28d4, 2); if(jzw(0x19_28e1, 0xb)) goto l_0x19_28e1; /* jz 0x28e1 */
            ii(0x19_28d6, 3); mov(cx, 0x7fff);                          /* mov cx, 0x7fff */
            ii(0x19_28d9, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_28db, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_28dd, 2); if(jnzw(0x19_2900, 0x21)) goto l_0x19_2900; /* jnz 0x2900 */
            ii(0x19_28df, 2); jmpw(0x19_28c6, -0x1b); goto l_0x19_28c6; /* jmp 0x28c6 */
        l_0x19_28e1:
            ii(0x19_28e1, 1); pushw(es);                                /* push es */
            ii(0x19_28e2, 1); pushw(ds);                                /* push ds */
            ii(0x19_28e3, 1); popw(es);                                 /* pop es */
            ii(0x19_28e4, 1); popw(ds);                                 /* pop ds */
            ii(0x19_28e5, 2); mov(si, di);                              /* mov si, di */
            ii(0x19_28e7, 3); mov(di, 0x3c21);                          /* mov di, 0x3c21 */
            ii(0x19_28ea, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x19_28ec:
            ii(0x19_28ec, 1); lodsb_a16();                              /* lodsb */
            ii(0x19_28ed, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x19_28ef, 2); if(jbw(0x19_28fe, 0xd)) goto l_0x19_28fe; /* jb 0x28fe */
            ii(0x19_28f1, 2); shl(al, cl);                              /* shl al, cl */
            ii(0x19_28f3, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x19_28f4, 1); lodsb_a16();                              /* lodsb */
            ii(0x19_28f5, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x19_28f7, 2); if(jbw(0x19_28fe, 0x5)) goto l_0x19_28fe; /* jb 0x28fe */
            ii(0x19_28f9, 2); or(al, dl);                               /* or al, dl */
            ii(0x19_28fb, 1); stosb_a16();                              /* stosb */
            ii(0x19_28fc, 2); jmpw(0x19_28ec, -0x12); goto l_0x19_28ec; /* jmp 0x28ec */
        l_0x19_28fe:
            ii(0x19_28fe, 1); pushw(ss);                                /* push ss */
            ii(0x19_28ff, 1); popw(ds);                                 /* pop ds */
        l_0x19_2900:
            ii(0x19_2900, 3); mov(bx, 0x4);                             /* mov bx, 0x4 */
        l_0x19_2903:
            ii(0x19_2903, 5); and(memb_a16[ds, bx + 0x3c21], -0x41 /* 0xbf */); /* and byte [bx+0x3c21], 0xbf */
            ii(0x19_2908, 3); mov(ax, 0x4400);                          /* mov ax, 0x4400 */
            ii(0x19_290b, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_290d, 2); if(jbw(0x19_2919, 0xa)) goto l_0x19_2919; /* jb 0x2919 */
            ii(0x19_290f, 3); test(dl, 0x80);                           /* test dl, 0x80 */
            ii(0x19_2912, 2); if(jzw(0x19_2919, 0x5)) goto l_0x19_2919; /* jz 0x2919 */
            ii(0x19_2914, 5); or(memb_a16[ds, bx + 0x3c21], 0x40);      /* or byte [bx+0x3c21], 0x40 */
        l_0x19_2919:
            ii(0x19_2919, 1); dec(bx);                                  /* dec bx */
            ii(0x19_291a, 2); if(jnsw(0x19_2903, -0x19)) goto l_0x19_2903; /* jns 0x2903 */
            ii(0x19_291c, 3); mov(si, 0x3f84);                          /* mov si, 0x3f84 */
            ii(0x19_291f, 3); mov(di, 0x3f84);                          /* mov di, 0x3f84 */
            ii(0x19_2922, 3); callw(0x19_29df, 0xba);                   /* call 0x29df */
            ii(0x19_2925, 3); mov(si, 0x3f84);                          /* mov si, 0x3f84 */
            ii(0x19_2928, 3); mov(di, 0x3f84);                          /* mov di, 0x3f84 */
            ii(0x19_292b, 3); callw(0x19_29df, 0xb1);                   /* call 0x29df */
            ii(0x19_292e, 1); retfw();                                  /* retf */
        }
    }
}
