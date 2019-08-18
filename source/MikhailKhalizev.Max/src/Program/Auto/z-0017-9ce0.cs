using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9ce0-39d35f5d")]
        public void Method_0017_9ce0()
        {
            ii(0x17_9ce0, 4); enterw(0x24, 0);                          /* enter 0x24, 0x0 */
            ii(0x17_9ce4, 1); pushw(si);                                /* push si */
            ii(0x17_9ce5, 1); pushw(ds);                                /* push ds */
            ii(0x17_9ce6, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_9ce9, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_9ceb, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x17_9cf0, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9cf3, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x17_9cf7, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x17_9cfb, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_9cfd, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_9cff, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_9d01, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_9d03, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_9d05, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_9d07, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9d09, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9d0b, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9d0d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9d0f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9d11, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9d13, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9d15, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9d17, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_9d1a, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x17_9d1d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_9d20, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_9d23, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x17_9d27, 2); if(jzw(0x17_9d35, 0xc)) goto l_0x17_9d35; /* jz 0x9d35 */
            ii(0x17_9d29, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_9d2c, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_9d2f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_9d32, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_9d35:
            ii(0x17_9d35, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_9d38, 4); mov(ax, memw_a16[es, bx + 0x16]);         /* mov ax, [es:bx+0x16] */
            ii(0x17_9d3c, 4); or(ax, memw_a16[es, bx + 0x14]);          /* or ax, [es:bx+0x14] */
            ii(0x17_9d40, 2); if(jzw(0x17_9d45, 0x3)) goto l_0x17_9d45; /* jz 0x9d45 */
            ii(0x17_9d42, 3); jmpw(0x17_9e88, 0x143); goto l_0x17_9e88; /* jmp 0x9e88 */
        l_0x17_9d45:
            ii(0x17_9d45, 4); mov(ax, memw_a16[es, bx + 0x1a]);         /* mov ax, [es:bx+0x1a] */
            ii(0x17_9d49, 4); or(ax, memw_a16[es, bx + 0x18]);          /* or ax, [es:bx+0x18] */
            ii(0x17_9d4d, 2); if(jzw(0x17_9d52, 0x3)) goto l_0x17_9d52; /* jz 0x9d52 */
            ii(0x17_9d4f, 3); jmpw(0x17_9e22, 0xd0); goto l_0x17_9e22;  /* jmp 0x9e22 */
        l_0x17_9d52:
            ii(0x17_9d52, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_9d55, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_9d58, 1); pushw(cs);                                /* push cs */
            ii(0x17_9d59, 3); callw(0x17_bbf8, 0x1e9c);                 /* call 0xbbf8 */
            ii(0x17_9d5c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9d5f, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_9d62, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x17_9d65, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_9d68, 2); if(jnzw(0x17_9d71, 0x7)) goto l_0x17_9d71; /* jnz 0x9d71 */
            ii(0x17_9d6a, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_9d6c, 2); if(jnzw(0x17_9d71, 0x3)) goto l_0x17_9d71; /* jnz 0x9d71 */
            ii(0x17_9d6e, 3); jmpw(0x17_9e0e, 0x9d); goto l_0x17_9e0e;  /* jmp 0x9e0e */
        l_0x17_9d71:
            ii(0x17_9d71, 1); pushw(cs);                                /* push cs */
            ii(0x17_9d72, 3); callw(0x17_c6f0, 0x297b);                 /* call 0xc6f0 */
            ii(0x17_9d75, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_9d78, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_9d7b, 2); if(jnzw(0x17_9d80, 0x3)) goto l_0x17_9d80; /* jnz 0x9d80 */
            ii(0x17_9d7d, 3); jmpw(0x17_9e0c, 0x8c); goto l_0x17_9e0c;  /* jmp 0x9e0c */
        l_0x17_9d80:
            ii(0x17_9d80, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x17_9d83, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x17_9d86, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_9d89, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_9d8c, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_9d8e, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_9d90, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_9d92, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_9d94, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9d96, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9d98, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9d9a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9d9c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9d9e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9da0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9da2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9da4, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_9da7, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_9daa, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_9dac, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_9daf, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_9db2, 1); pushw(dx);                                /* push dx */
            ii(0x17_9db3, 1); pushw(ax);                                /* push ax */
            ii(0x17_9db4, 3); mov(al, memb_a16[ds, 0x51b5]);            /* mov al, [0x51b5] */
            ii(0x17_9db7, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_9db9, 1); pushw(ax);                                /* push ax */
            ii(0x17_9dba, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_9dbd, 1); pushw(cs);                                /* push cs */
            ii(0x17_9dbe, 3); callw(0x17_c48e, 0x26cd);                 /* call 0xc48e */
            ii(0x17_9dc1, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_9dc4, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_9dc7, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_9dca, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9dcd, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_9dd1, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_9dd5, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_9dd8, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x17_9ddc, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_9de2, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_9de7, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_9dea, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_9ded, 4); sub(memw_a16[ds, 0x1fc4], ax);            /* sub [0x1fc4], ax */
            ii(0x17_9df1, 4); sbb(memw_a16[ds, 0x1fc6], dx);            /* sbb [0x1fc6], dx */
            ii(0x17_9df5, 4); sub(memw_a16[ds, 0x1fac], ax);            /* sub [0x1fac], ax */
            ii(0x17_9df9, 4); sbb(memw_a16[ds, 0x1fae], dx);            /* sbb [0x1fae], dx */
            ii(0x17_9dfd, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x17_9e02, 2); if(jgew(0x17_9e0c, 0x8)) goto l_0x17_9e0c; /* jge 0x9e0c */
            ii(0x17_9e04, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_9e06, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x17_9e09, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x17_9e0c:
            ii(0x17_9e0c, 2); jmpw(0x17_9e22, 0x14); goto l_0x17_9e22;  /* jmp 0x9e22 */
        l_0x17_9e0e:
            ii(0x17_9e0e, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9e11, 6); mov(memw_a16[es, bx + 0x20], 0x8012);     /* mov word [es:bx+0x20], 0x8012 */
            ii(0x17_9e17, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_9e1d, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_9e22:
            ii(0x17_9e22, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9e25, 5); cmp(memw_a16[es, bx + 0x18], 0x1);        /* cmp word [es:bx+0x18], 0x1 */
            ii(0x17_9e2a, 2); if(jnzw(0x17_9e83, 0x57)) goto l_0x17_9e83; /* jnz 0x9e83 */
            ii(0x17_9e2c, 5); cmp(memw_a16[es, bx + 0x1a], 0);          /* cmp word [es:bx+0x1a], 0x0 */
            ii(0x17_9e31, 2); if(jnzw(0x17_9e83, 0x50)) goto l_0x17_9e83; /* jnz 0x9e83 */
            ii(0x17_9e33, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x17_9e36, 1); pushw(ss);                                /* push ss */
            ii(0x17_9e37, 1); pushw(ax);                                /* push ax */
            ii(0x17_9e38, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_9e3b, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_9e3e, 1); pushw(cs);                                /* push cs */
            ii(0x17_9e3f, 3); callw(0x17_bcb8, 0x1e76);                 /* call 0xbcb8 */
            ii(0x17_9e42, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_9e45, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_9e48, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_9e4a, 2); if(jzw(0x17_9e60, 0x14)) goto l_0x17_9e60; /* jz 0x9e60 */
            ii(0x17_9e4c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9e4f, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x17_9e53, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_9e59, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_9e5e, 2); jmpw(0x17_9e83, 0x23); goto l_0x17_9e83;  /* jmp 0x9e83 */
        l_0x17_9e60:
            ii(0x17_9e60, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_9e63, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_9e66, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9e69, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_9e6d, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_9e71, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_9e74, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x17_9e78, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_9e7e, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
        l_0x17_9e83:
            ii(0x17_9e83, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9e84, 1); popw(si);                                 /* pop si */
            ii(0x17_9e85, 1); leavew();                                 /* leave */
            ii(0x17_9e86, 1); retfw(); return;                          /* retf */
        //  ii(0x17_9e87, 1); Недостижимый (и не декодированный) код.
        l_0x17_9e88:
            ii(0x17_9e88, 6); cmp(memw_a16[es, bx + 0x16], 0x1000);     /* cmp word [es:bx+0x16], 0x1000 */
            ii(0x17_9e8e, 2); if(jbw(0x17_9ece, 0x3e)) goto l_0x17_9ece; /* jb 0x9ece */
            ii(0x17_9e90, 2); if(jaw(0x17_9e92, 0)) goto l_0x17_9e92;   /* ja 0x9e92 */
        l_0x17_9e92:
            ii(0x17_9e92, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_9e95, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_9e98, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_9e9a, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_9e9c, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_9e9e, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_9ea0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9ea2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9ea4, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9ea6, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9ea8, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9eaa, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9eac, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_9eae, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_9eb0, 4); add(ax, memw_a16[es, bx + 0x14]);         /* add ax, [es:bx+0x14] */
            ii(0x17_9eb4, 4); adc(dx, memw_a16[es, bx + 0x16]);         /* adc dx, [es:bx+0x16] */
            ii(0x17_9eb8, 4); mov(ch, memb_a16[ds, 0x519c]);            /* mov ch, [0x519c] */
            ii(0x17_9ebc, 3); shl(ch, 0x4);                             /* shl ch, 0x4 */
            ii(0x17_9ebf, 2); sub(cl, cl);                              /* sub cl, cl */
            ii(0x17_9ec1, 3); mov(bx, 0x1000);                          /* mov bx, 0x1000 */
            ii(0x17_9ec4, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_9ec6, 2); if(jbw(0x17_9edb, 0x13)) goto l_0x17_9edb; /* jb 0x9edb */
            ii(0x17_9ec8, 2); if(jaw(0x17_9ece, 0x4)) goto l_0x17_9ece; /* ja 0x9ece */
            ii(0x17_9eca, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_9ecc, 2); if(jbew(0x17_9edb, 0xd)) goto l_0x17_9edb; /* jbe 0x9edb */
        l_0x17_9ece:
            ii(0x17_9ece, 5); mov(memw_a16[ss, bp - 0x14], 0x8012);     /* mov word [bp-0x14], 0x8012 */
            ii(0x17_9ed3, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9ed6, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_9edb:
            ii(0x17_9edb, 4); cmp(memw_a16[ss, bp - 0x14], 0);          /* cmp word [bp-0x14], 0x0 */
            ii(0x17_9edf, 2); if(jzw(0x17_9ee4, 0x3)) goto l_0x17_9ee4; /* jz 0x9ee4 */
            ii(0x17_9ee1, 3); jmpw(0x17_9f66, 0x82); goto l_0x17_9f66;  /* jmp 0x9f66 */
        l_0x17_9ee4:
            ii(0x17_9ee4, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9ee7, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_9eeb, 4); mov(dx, memw_a16[es, bx + 0x16]);         /* mov dx, [es:bx+0x16] */
            ii(0x17_9eef, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_9ef2, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x17_9ef6, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_9ef8, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_9efa, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_9efc, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_9efe, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f00, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f02, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f04, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f06, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f08, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f0a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f0c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f0e, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x17_9f11, 3); mov(memw_a16[ss, bp - 0x1a], dx);         /* mov [bp-0x1a], dx */
            ii(0x17_9f14, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_9f17, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_9f1a, 2); jmpw(0x17_9f24, 0x8); goto l_0x17_9f24;   /* jmp 0x9f24 */
        l_0x17_9f1c:
            ii(0x17_9f1c, 4); add(memw_a16[ss, bp - 0xe], 0x1);         /* add word [bp-0xe], 0x1 */
            ii(0x17_9f20, 4); adc(memw_a16[ss, bp - 0xc], 0);           /* adc word [bp-0xc], 0x0 */
        l_0x17_9f24:
            ii(0x17_9f24, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x17_9f27, 3); mov(dx, memw_a16[ss, bp - 0x1a]);         /* mov dx, [bp-0x1a] */
            ii(0x17_9f2a, 3); add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0x17_9f2d, 3); adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0x17_9f30, 3); cmp(dx, memw_a16[ss, bp - 0xc]);          /* cmp dx, [bp-0xc] */
            ii(0x17_9f33, 2); if(jbw(0x17_9f66, 0x31)) goto l_0x17_9f66; /* jb 0x9f66 */
            ii(0x17_9f35, 2); if(jaw(0x17_9f3c, 0x5)) goto l_0x17_9f3c; /* ja 0x9f3c */
            ii(0x17_9f37, 3); cmp(ax, memw_a16[ss, bp - 0xe]);          /* cmp ax, [bp-0xe] */
            ii(0x17_9f3a, 2); if(jbw(0x17_9f66, 0x2a)) goto l_0x17_9f66; /* jb 0x9f66 */
        l_0x17_9f3c:
            ii(0x17_9f3c, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_9f3f, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_9f42, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_9f46, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_9f4a, 3); callw(0x17_90c4, -0xe89);                 /* call 0x90c4 */
            ii(0x17_9f4d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_9f50, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_9f52, 2); if(jzw(0x17_9f64, 0x10)) goto l_0x17_9f64; /* jz 0x9f64 */
            ii(0x17_9f54, 5); mov(memw_a16[ss, bp - 0x14], 0x8012);     /* mov word [bp-0x14], 0x8012 */
            ii(0x17_9f59, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9f5c, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_9f61, 2); jmpw(0x17_9f66, 0x3); goto l_0x17_9f66;   /* jmp 0x9f66 */
        //    ii(0x17_9f63, 1); nop();                                    /* nop */
        l_0x17_9f64:
            ii(0x17_9f64, 2); jmpw(0x17_9f1c, -0x4a); goto l_0x17_9f1c; /* jmp 0x9f1c */
        l_0x17_9f66:
            ii(0x17_9f66, 4); cmp(memw_a16[ss, bp - 0x14], 0);          /* cmp word [bp-0x14], 0x0 */
            ii(0x17_9f6a, 2); if(jzw(0x17_9f6f, 0x3)) goto l_0x17_9f6f; /* jz 0x9f6f */
            ii(0x17_9f6c, 3); jmpw(0x17_a0d6, 0x167); goto l_0x17_a0d6; /* jmp 0xa0d6 */
        l_0x17_9f6f:
            ii(0x17_9f6f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9f72, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_9f76, 4); mov(dx, memw_a16[es, bx + 0x16]);         /* mov dx, [es:bx+0x16] */
            ii(0x17_9f7a, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_9f7c, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_9f7e, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_9f81, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x17_9f85, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_9f87, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_9f89, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_9f8b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_9f8d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f8f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f91, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f93, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f95, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f97, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f99, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_9f9b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_9f9d, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x17_9fa0, 3); mov(memw_a16[ss, bp - 0x1a], dx);         /* mov [bp-0x1a], dx */
            ii(0x17_9fa3, 4); and(cx, 0xf000);                          /* and cx, 0xf000 */
            ii(0x17_9fa7, 3); mov(memw_a16[ss, bp - 0xa], cx);          /* mov [bp-0xa], cx */
            ii(0x17_9faa, 3); mov(memw_a16[ss, bp - 0x8], si);          /* mov [bp-0x8], si */
            ii(0x17_9fad, 1); pushw(cs);                                /* push cs */
            ii(0x17_9fae, 3); callw(0x17_c6f0, 0x273f);                 /* call 0xc6f0 */
            ii(0x17_9fb1, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_9fb4, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_9fb7, 2); if(jnzw(0x17_9fbc, 0x3)) goto l_0x17_9fbc; /* jnz 0x9fbc */
            ii(0x17_9fb9, 3); jmpw(0x17_a086, 0xca); goto l_0x17_a086;  /* jmp 0xa086 */
        l_0x17_9fbc:
            ii(0x17_9fbc, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_9fbf, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x17_9fc2, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_9fc5, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x17_9fc9, 4); mov(memw_a16[es, bx + 0x16], dx);         /* mov [es:bx+0x16], dx */
            ii(0x17_9fcd, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_9fd0, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x17_9fd4, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_9fda, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_9fdf, 4); mov(ax, memw_a16[es, bx + 0x1a]);         /* mov ax, [es:bx+0x1a] */
            ii(0x17_9fe3, 4); or(ax, memw_a16[es, bx + 0x18]);          /* or ax, [es:bx+0x18] */
            ii(0x17_9fe7, 2); if(jnzw(0x17_a00a, 0x21)) goto l_0x17_a00a; /* jnz 0xa00a */
            ii(0x17_9fe9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_9feb, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_9fee, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_9ff1, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_9ff4, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_9ff7, 3); mov(al, memb_a16[ds, 0x51b5]);            /* mov al, [0x51b5] */
            ii(0x17_9ffa, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_9ffc, 1); pushw(ax);                                /* push ax */
            ii(0x17_9ffd, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_a000, 1); pushw(cs);                                /* push cs */
            ii(0x17_a001, 3); callw(0x17_c48e, 0x248a);                 /* call 0xc48e */
            ii(0x17_a004, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x17_a007, 2); jmpw(0x17_a086, 0x7d); goto l_0x17_a086;  /* jmp 0xa086 */
        //    ii(0x17_a009, 1); nop();                                    /* nop */
        l_0x17_a00a:
            ii(0x17_a00a, 3); mov(ax, memw_a16[ds, 0x1fc4]);            /* mov ax, [0x1fc4] */
            ii(0x17_a00d, 4); mov(dx, memw_a16[ds, 0x1fc6]);            /* mov dx, [0x1fc6] */
            ii(0x17_a011, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x17_a014, 2); if(jlw(0x17_a024, 0xe)) goto l_0x17_a024; /* jl 0xa024 */
            ii(0x17_a016, 2); if(jgw(0x17_a01d, 0x5)) goto l_0x17_a01d; /* jg 0xa01d */
            ii(0x17_a018, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x17_a01b, 2); if(jbew(0x17_a024, 0x7)) goto l_0x17_a024; /* jbe 0xa024 */
        l_0x17_a01d:
            ii(0x17_a01d, 5); mov(memw_a16[ss, bp - 0x14], 0x8016);     /* mov word [bp-0x14], 0x8016 */
            ii(0x17_a022, 2); jmpw(0x17_a086, 0x62); goto l_0x17_a086;  /* jmp 0xa086 */
        l_0x17_a024:
            ii(0x17_a024, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x17_a027, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x17_a02b, 2); if(jzw(0x17_a086, 0x59)) goto l_0x17_a086; /* jz 0xa086 */
            ii(0x17_a02d, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_a030, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_a033, 4); sub(ax, memw_a16[ds, 0x1fc4]);            /* sub ax, [0x1fc4] */
            ii(0x17_a037, 4); sbb(dx, memw_a16[ds, 0x1fc6]);            /* sbb dx, [0x1fc6] */
            ii(0x17_a03b, 4); sub(ax, memw_a16[ds, 0x1fc0]);            /* sub ax, [0x1fc0] */
            ii(0x17_a03f, 4); sbb(dx, memw_a16[ds, 0x1fc2]);            /* sbb dx, [0x1fc2] */
            ii(0x17_a043, 4); add(ax, memw_a16[ds, 0x1fb4]);            /* add ax, [0x1fb4] */
            ii(0x17_a047, 4); adc(dx, memw_a16[ds, 0x1fb6]);            /* adc dx, [0x1fb6] */
            ii(0x17_a04b, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x17_a04e, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_a051, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_a054, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x17_a057, 4); mov(cx, memw_a16[ds, 0x1f50]);            /* mov cx, [0x1f50] */
            ii(0x17_a05b, 4); mov(bx, memw_a16[ds, 0x1f52]);            /* mov bx, [0x1f52] */
            ii(0x17_a05f, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_a061, 2); if(jlw(0x17_a086, 0x23)) goto l_0x17_a086; /* jl 0xa086 */
            ii(0x17_a063, 2); if(jgw(0x17_a069, 0x4)) goto l_0x17_a069; /* jg 0xa069 */
            ii(0x17_a065, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_a067, 2); if(jbew(0x17_a086, 0x1d)) goto l_0x17_a086; /* jbe 0xa086 */
        l_0x17_a069:
            ii(0x17_a069, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_a06b, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x17_a06d, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x17_a070, 3); mov(memw_a16[ss, bp - 0x22], dx);         /* mov [bp-0x22], dx */
            ii(0x17_a073, 1); pushw(dx);                                /* push dx */
            ii(0x17_a074, 1); pushw(ax);                                /* push ax */
            ii(0x17_a075, 1); nop();                                    /* nop */
            ii(0x17_a076, 1); pushw(cs);                                /* push cs */
            ii(0x17_a077, 3); callw(0x17_8ba6, -0x14d4);                /* call 0x8ba6 */
            ii(0x17_a07a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_a07d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_a07f, 2); if(jnzw(0x17_a086, 0x5)) goto l_0x17_a086; /* jnz 0xa086 */
            ii(0x17_a081, 5); mov(memw_a16[ss, bp - 0x14], 0x8014);     /* mov word [bp-0x14], 0x8014 */
        l_0x17_a086:
            ii(0x17_a086, 4); cmp(memw_a16[ss, bp - 0x14], 0);          /* cmp word [bp-0x14], 0x0 */
            ii(0x17_a08a, 2); if(jzw(0x17_a0a6, 0x1a)) goto l_0x17_a0a6; /* jz 0xa0a6 */
            ii(0x17_a08c, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_a08f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a092, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x17_a096, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_a09c, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_a0a1, 1); popw(ds);                                 /* pop ds */
            ii(0x17_a0a2, 1); popw(si);                                 /* pop si */
            ii(0x17_a0a3, 1); leavew();                                 /* leave */
            ii(0x17_a0a4, 1); retfw(); return;                          /* retf */
        //  ii(0x17_a0a5, 1); Недостижимый (и не декодированный) код.
        l_0x17_a0a6:
            ii(0x17_a0a6, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_a0a9, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_a0ac, 4); sub(memw_a16[ds, 0x1fac], ax);            /* sub [0x1fac], ax */
            ii(0x17_a0b0, 4); sbb(memw_a16[ds, 0x1fae], dx);            /* sbb [0x1fae], dx */
            ii(0x17_a0b4, 5); cmp(memw_a16[ds, 0x1fae], 0);             /* cmp word [0x1fae], 0x0 */
            ii(0x17_a0b9, 2); if(jgew(0x17_a0c3, 0x8)) goto l_0x17_a0c3; /* jge 0xa0c3 */
            ii(0x17_a0bb, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_a0bd, 3); mov(memw_a16[ds, 0x1fae], ax);            /* mov [0x1fae], ax */
            ii(0x17_a0c0, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
        l_0x17_a0c3:
            ii(0x17_a0c3, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_a0c6, 4); sub(memw_a16[ds, 0x1fc4], ax);            /* sub [0x1fc4], ax */
            ii(0x17_a0ca, 4); sbb(memw_a16[ds, 0x1fc6], dx);            /* sbb [0x1fc6], dx */
            ii(0x17_a0ce, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a0d1, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
        l_0x17_a0d6:
            ii(0x17_a0d6, 1); popw(ds);                                 /* pop ds */
            ii(0x17_a0d7, 1); popw(si);                                 /* pop si */
            ii(0x17_a0d8, 1); leavew();                                 /* leave */
            ii(0x17_a0d9, 1); retfw(); return;                          /* retf */
        }
    }
}
