using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_c85e-280e4165")]
        public void Method_0018_c85e()
        {
            ii(0x18_c85e, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x18_c862, 1); push(di);                                 /* push di */
            ii(0x18_c863, 1); push(si);                                 /* push si */
            ii(0x18_c864, 6); mov(memw[ds, 0x38], 0);                   /* mov word [0x38], 0x0 */
            ii(0x18_c86a, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_c86d, 6); mov(memw[es, bx + 0x16], 0x18);           /* mov word [es:bx+0x16], 0x18 */
            ii(0x18_c873, 5); or(memb[es, bx + 0x26], 0x1);             /* or byte [es:bx+0x26], 0x1 */
            ii(0x18_c878, 4); mov(di, memw[es, bx + 0x10]);             /* mov di, [es:bx+0x10] */
            ii(0x18_c87c, 2); or(di, di);                               /* or di, di */
            ii(0x18_c87e, 2); if(jnz(0x18_c881, 0x1)) goto l_0x18_c881; /* jnz 0xc881 */
            ii(0x18_c880, 1); inc(di);                                  /* inc di */
        l_0x18_c881:
            ii(0x18_c881, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_c883, 3); shr(ax, 0xc);                             /* shr ax, 0xc */
            ii(0x18_c886, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x18_c889, 4); test(di, 0xfff);                          /* test di, 0xfff */
            ii(0x18_c88d, 2); if(jz(0x18_c893, 0x4)) goto l_0x18_c893;  /* jz 0xc893 */
            ii(0x18_c88f, 1); inc(ax);                                  /* inc ax */
            ii(0x18_c890, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
        l_0x18_c893:
            ii(0x18_c893, 5); mov(memw[ss, bp - 0x2], 0x92);            /* mov word [bp-0x2], 0x92 */
            ii(0x18_c898, 3); mov(al, memb[ds, 0x980]);                 /* mov al, [0x980] */
            ii(0x18_c89b, 1); cbw();                                    /* cbw */
            ii(0x18_c89c, 1); dec(ax);                                  /* dec ax */
            ii(0x18_c89d, 2); if(jz(0x18_c8ed, 0x4e)) goto l_0x18_c8ed; /* jz 0xc8ed */
            ii(0x18_c89f, 1); dec(ax);                                  /* dec ax */
            ii(0x18_c8a0, 2); if(jz(0x18_c8ff, 0x5d)) goto l_0x18_c8ff; /* jz 0xc8ff */
            ii(0x18_c8a2, 1); dec(ax);                                  /* dec ax */
            ii(0x18_c8a3, 2); if(jz(0x18_c8de, 0x39)) goto l_0x18_c8de; /* jz 0xc8de */
            ii(0x18_c8a5, 1); dec(ax);                                  /* dec ax */
            ii(0x18_c8a6, 2); if(jnz(0x18_c8ab, 0x3)) goto l_0x18_c8ab; /* jnz 0xc8ab */
            ii(0x18_c8a8, 3); jmp(0x18_c93e, 0x93); goto l_0x18_c93e;   /* jmp 0xc93e */
        l_0x18_c8ab:
            ii(0x18_c8ab, 1); dec(ax);                                  /* dec ax */
            ii(0x18_c8ac, 2); if(jz(0x18_c908, 0x5a)) goto l_0x18_c908; /* jz 0xc908 */
            ii(0x18_c8ae, 2); push(0);                                  /* push 0x0 */
            ii(0x18_c8b0, 1); push(di);                                 /* push di */
            ii(0x18_c8b1, 3); call(0x18_bddb, -0xad9);                  /* call 0xbddb */
            ii(0x18_c8b4, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c8b5, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c8b6, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x18_c8b9, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x18_c8bc, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_c8be, 2); if(jz(0x18_c8de, 0x1e)) goto l_0x18_c8de; /* jz 0xc8de */
        l_0x18_c8c0:
            ii(0x18_c8c0, 3); mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0x18_c8c3, 3); or(ax, memw[ss, bp - 0xa]);               /* or ax, [bp-0xa] */
            ii(0x18_c8c6, 2); if(jz(0x18_c8cb, 0x3)) goto l_0x18_c8cb;  /* jz 0xc8cb */
            ii(0x18_c8c8, 3); jmp(0x18_c96e, 0xa3); goto l_0x18_c96e;   /* jmp 0xc96e */
        l_0x18_c8cb:
            ii(0x18_c8cb, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_c8ce, 6); mov(memw[es, bx + 0x16], 0x8);            /* mov word [es:bx+0x16], 0x8 */
            ii(0x18_c8d4, 3); mov(ax, memw[ds, 0x11fa]);                /* mov ax, [0x11fa] */
            ii(0x18_c8d7, 4); mov(memw[es, bx + 0x10], ax);             /* mov [es:bx+0x10], ax */
            ii(0x18_c8db, 3); jmp(0x18_ca8a, 0x1ac); goto l_0x18_ca8a;  /* jmp 0xca8a */
        l_0x18_c8de:
            ii(0x18_c8de, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x18_c8e1, 3); call(0x18_b058, -0x188c);                 /* call 0xb058 */
        l_0x18_c8e4:
            ii(0x18_c8e4, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c8e5, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x18_c8e8, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x18_c8eb, 2); jmp(0x18_c8c0, -0x2d); goto l_0x18_c8c0;  /* jmp 0xc8c0 */
        l_0x18_c8ed:
            ii(0x18_c8ed, 1); push(bx);                                 /* push bx */
            ii(0x18_c8ee, 3); call(0x18_b058, -0x1899);                 /* call 0xb058 */
            ii(0x18_c8f1, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c8f2, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x18_c8f5, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x18_c8f8, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_c8fa, 3); or(ax, memw[ss, bp - 0xa]);               /* or ax, [bp-0xa] */
            ii(0x18_c8fd, 2); if(jnz(0x18_c8c0, -0x3f)) goto l_0x18_c8c0; /* jnz 0xc8c0 */
        l_0x18_c8ff:
            ii(0x18_c8ff, 2); push(0);                                  /* push 0x0 */
            ii(0x18_c901, 1); push(di);                                 /* push di */
            ii(0x18_c902, 3); call(0x18_bddb, -0xb2a);                  /* call 0xbddb */
            ii(0x18_c905, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c906, 2); jmp(0x18_c8e4, -0x24); goto l_0x18_c8e4;  /* jmp 0xc8e4 */
        l_0x18_c908:
            ii(0x18_c908, 4); cmp(memw[ss, bp - 0x6], 0x1);             /* cmp word [bp-0x6], 0x1 */
            ii(0x18_c90c, 2); if(jnz(0x18_c944, 0x36)) goto l_0x18_c944; /* jnz 0xc944 */
            ii(0x18_c90e, 3); lea(ax, di + 0x7);                        /* lea ax, [di+0x7] */
            ii(0x18_c911, 3); mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x18_c914, 4); mov(memw[es, bx + 0x10], ax);             /* mov [es:bx+0x10], ax */
            ii(0x18_c918, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_c91c, 3); mov(memw[ds, bx + 0x10], ax);             /* mov [bx+0x10], ax */
            ii(0x18_c91f, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x18_c922, 3); call(0x18_b058, -0x18cd);                 /* call 0xb058 */
            ii(0x18_c925, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c926, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_c928, 3); lea(ax, si + 0x7);                        /* lea ax, [si+0x7] */
            ii(0x18_c92b, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x18_c92d, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x18_c92f, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x18_c932, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x18_c935, 1); push(si);                                 /* push si */
            ii(0x18_c936, 1); push(ax);                                 /* push ax */
            ii(0x18_c937, 3); call(0x18_d4de, 0xba4);                   /* call 0xd4de */
            ii(0x18_c93a, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c93b, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c93c, 2); jmp(0x18_c8c0, -0x7e); goto l_0x18_c8c0;  /* jmp 0xc8c0 */
        l_0x18_c93e:
            ii(0x18_c93e, 4); cmp(memw[ss, bp - 0x6], 0x1);             /* cmp word [bp-0x6], 0x1 */
            ii(0x18_c942, 2); if(jz(0x18_c947, 0x3)) goto l_0x18_c947;  /* jz 0xc947 */
        l_0x18_c944:
            ii(0x18_c944, 3); jmp(0x18_ca8a, 0x143); goto l_0x18_ca8a;  /* jmp 0xca8a */
        l_0x18_c947:
            ii(0x18_c947, 3); cmp(di, 0x7);                             /* cmp di, 0x7 */
            ii(0x18_c94a, 2); if(jae(0x18_c95a, 0xe)) goto l_0x18_c95a; /* jae 0xc95a */
            ii(0x18_c94c, 3); mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0x18_c94f, 4); mov(memw[es, bx + 0x10], ax);             /* mov [es:bx+0x10], ax */
            ii(0x18_c953, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_c957, 3); mov(memw[ds, bx + 0x10], ax);             /* mov [bx+0x10], ax */
        l_0x18_c95a:
            ii(0x18_c95a, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x18_c95d, 3); call(0x18_b058, -0x1908);                 /* call 0xb058 */
            ii(0x18_c960, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c961, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x18_c964, 3); mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x18_c967, 4); or(memb[ss, bp - 0x2], 0x60);             /* or byte [bp-0x2], 0x60 */
            ii(0x18_c96b, 3); jmp(0x18_c8c0, -0xae); goto l_0x18_c8c0;  /* jmp 0xc8c0 */
        l_0x18_c96e:
            ii(0x18_c96e, 3); mov(si, memw[ss, bp + 0x8]);              /* mov si, [bp+0x8] */
            ii(0x18_c971, 2); or(si, si);                               /* or si, si */
            ii(0x18_c973, 2); if(jnz(0x18_c9c5, 0x50)) goto l_0x18_c9c5; /* jnz 0xc9c5 */
            ii(0x18_c975, 5); cmp(memb[ds, 0x980], 0x4);                /* cmp byte [0x980], 0x4 */
            ii(0x18_c97a, 2); if(jl(0x18_c984, 0x8)) goto l_0x18_c984;  /* jl 0xc984 */
            ii(0x18_c97c, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x18_c97f, 3); call(0x18_c832, -0x150);                  /* call 0xc832 */
            ii(0x18_c982, 2); jmp(0x18_c98a, 0x6); goto l_0x18_c98a;    /* jmp 0xc98a */
        l_0x18_c984:
            ii(0x18_c984, 3); push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x18_c987, 3); call(0x18_dcef, 0x1365);                  /* call 0xdcef */
        l_0x18_c98a:
            ii(0x18_c98a, 1); pop(bx);                                  /* pop bx */
            ii(0x18_c98b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_c98d, 2); or(si, si);                               /* or si, si */
            ii(0x18_c98f, 2); if(jnz(0x18_c9c5, 0x34)) goto l_0x18_c9c5; /* jnz 0xc9c5 */
            ii(0x18_c991, 5); test(memw[ss, bp - 0x8], 0xffff);         /* test word [bp-0x8], 0xffff */
            ii(0x18_c996, 2); if(jz(0x18_c9a8, 0x10)) goto l_0x18_c9a8; /* jz 0xc9a8 */
            ii(0x18_c998, 1); push(si);                                 /* push si */
            ii(0x18_c999, 1); push(di);                                 /* push di */
            ii(0x18_c99a, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x18_c99d, 3); push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x18_c9a0, 3); call(0x18_c010, -0x993);                  /* call 0xc010 */
            ii(0x18_c9a3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_c9a6, 2); jmp(0x18_c9b9, 0x11); goto l_0x18_c9b9;   /* jmp 0xc9b9 */
        l_0x18_c9a8:
            ii(0x18_c9a8, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x18_c9ab, 4); mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x18_c9af, 3); mov(memw[ds, bx + 0x6], ax);              /* mov [bx+0x6], ax */
            ii(0x18_c9b2, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x18_c9b5, 3); call(0x18_b0af, -0x1909);                 /* call 0xb0af */
            ii(0x18_c9b8, 1); pop(bx);                                  /* pop bx */
        l_0x18_c9b9:
            ii(0x18_c9b9, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_c9bc, 6); mov(memw[es, bx + 0x16], 0x1f);           /* mov word [es:bx+0x16], 0x1f */
            ii(0x18_c9c2, 3); jmp(0x18_ca8a, 0xc5); goto l_0x18_ca8a;   /* jmp 0xca8a */
        l_0x18_c9c5:
            ii(0x18_c9c5, 3); mov(memw[ss, bp + 0x8], si);              /* mov [bp+0x8], si */
            ii(0x18_c9c8, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_c9cb, 4); mov(memw[es, bx + 0x16], si);             /* mov [es:bx+0x16], si */
            ii(0x18_c9cf, 5); and(memb[es, bx + 0x26], -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
        l_0x18_c9d4:
            ii(0x18_c9d4, 4); cmp(di, 0x1000);                          /* cmp di, 0x1000 */
            ii(0x18_c9d8, 2); if(jb(0x18_c9de, 0x4)) goto l_0x18_c9de;  /* jb 0xc9de */
            ii(0x18_c9da, 2); sub(si, si);                              /* sub si, si */
            ii(0x18_c9dc, 2); jmp(0x18_c9e3, 0x5); goto l_0x18_c9e3;    /* jmp 0xc9e3 */
        l_0x18_c9de:
            ii(0x18_c9de, 2); mov(si, di);                              /* mov si, di */
            ii(0x18_c9e0, 3); shl(si, 0x4);                             /* shl si, 0x4 */
        l_0x18_c9e3:
            ii(0x18_c9e3, 1); dec(si);                                  /* dec si */
            ii(0x18_c9e4, 3); mov(memw[ss, bp - 0x10], si);             /* mov [bp-0x10], si */
            ii(0x18_c9e7, 3); mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x18_c9ea, 3); mov(memb[ss, bp - 0xc], al);              /* mov [bp-0xc], al */
            ii(0x18_c9ed, 4); mov(memb[ss, bp - 0xb], 0);               /* mov byte [bp-0xb], 0x0 */
            ii(0x18_c9f1, 5); mov(memw[ss, bp - 0xe], 0);               /* mov word [bp-0xe], 0x0 */
            ii(0x18_c9f6, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x18_c9f9, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_c9fc, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x18_c9ff, 3); mov(ax, memw[ss, bp - 0x8]);              /* mov ax, [bp-0x8] */
            ii(0x18_ca02, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_ca05, 3); mov(cx, memw[ss, bp - 0xa]);              /* mov cx, [bp-0xa] */
            ii(0x18_ca08, 3); shr(cx, 0xc);                             /* shr cx, 0xc */
            ii(0x18_ca0b, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x18_ca0d, 3); mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x18_ca10, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x18_ca13, 1); push(ax);                                 /* push ax */
            ii(0x18_ca14, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x18_ca17, 3); call(0x18_dc28, 0x120e);                  /* call 0xdc28 */
            ii(0x18_ca1a, 1); pop(bx);                                  /* pop bx */
            ii(0x18_ca1b, 1); pop(bx);                                  /* pop bx */
            ii(0x18_ca1c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_ca1e, 2); if(jnz(0x18_ca27, 0x7)) goto l_0x18_ca27; /* jnz 0xca27 */
            ii(0x18_ca20, 3); push(0x101);                              /* push 0x101 */
            ii(0x18_ca23, 3); call(0x18_d9c5, 0xf9f);                   /* call 0xd9c5 */
            ii(0x18_ca26, 1); pop(bx);                                  /* pop bx */
        l_0x18_ca27:
            ii(0x18_ca27, 3); mov(al, memb[ds, 0x14]);                  /* mov al, [0x14] */
            ii(0x18_ca2a, 3); and(ax, 0x60);                            /* and ax, 0x60 */
            ii(0x18_ca2d, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_ca30, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_ca32, 2); if(jz(0x18_ca4c, 0x18)) goto l_0x18_ca4c; /* jz 0xca4c */
            ii(0x18_ca34, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x18_ca37, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x18_ca3a, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x18_ca3c, 1); push(ax);                                 /* push ax */
            ii(0x18_ca3d, 3); lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x18_ca40, 1); push(ax);                                 /* push ax */
            ii(0x18_ca41, 2); push(0);                                  /* push 0x0 */
            ii(0x18_ca43, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x18_ca46, 3); call(0x18_dad3, 0x108a);                  /* call 0xdad3 */
            ii(0x18_ca49, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x18_ca4c:
            ii(0x18_ca4c, 5); add(memw[ss, bp - 0xa], 0x1000);          /* add word [bp-0xa], 0x1000 */
            ii(0x18_ca51, 4); adc(memw[ss, bp - 0x8], 0);               /* adc word [bp-0x8], 0x0 */
            ii(0x18_ca55, 3); mov(bx, memw[ss, bp + 0x8]);              /* mov bx, [bp+0x8] */
            ii(0x18_ca58, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_ca5b, 4); add(bx, memw[ds, 0xaa0]);                 /* add bx, [0xaa0] */
            ii(0x18_ca5f, 4); mov(es, memw[ds, 0xaa2]);                 /* mov es, [0xaa2] */
            ii(0x18_ca63, 4); mov(memb[es, bx], 0x3);                   /* mov byte [es:bx], 0x3 */
            ii(0x18_ca67, 4); add(memw[ss, bp + 0x8], 0x8);             /* add word [bp+0x8], 0x8 */
            ii(0x18_ca6b, 1); push(si);                                 /* push si */
            ii(0x18_ca6c, 3); call(0x18_daf7, 0x1088);                  /* call 0xdaf7 */
            ii(0x18_ca6f, 1); pop(bx);                                  /* pop bx */
            ii(0x18_ca70, 2); sub(di, ax);                              /* sub di, ax */
            ii(0x18_ca72, 2); if(jz(0x18_ca77, 0x3)) goto l_0x18_ca77;  /* jz 0xca77 */
            ii(0x18_ca74, 3); jmp(0x18_c9d4, -0xa3); goto l_0x18_c9d4;  /* jmp 0xc9d4 */
        l_0x18_ca77:
            ii(0x18_ca77, 3); mov(bx, memw[ss, bp + 0x8]);              /* mov bx, [bp+0x8] */
            ii(0x18_ca7a, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_ca7d, 4); add(bx, memw[ds, 0xaa0]);                 /* add bx, [0xaa0] */
            ii(0x18_ca81, 4); mov(es, memw[ds, 0xaa2]);                 /* mov es, [0xaa2] */
            ii(0x18_ca85, 5); and(memb[es, bx - 0x1], -0x3 /* 0xfd */); /* and byte [es:bx-0x1], 0xfd */
        l_0x18_ca8a:
            ii(0x18_ca8a, 1); pop(si);                                  /* pop si */
            ii(0x18_ca8b, 1); pop(di);                                  /* pop di */
            ii(0x18_ca8c, 1); leave();                                  /* leave */
            ii(0x18_ca8d, 1); ret();                                    /* ret */
        }
    }
}
