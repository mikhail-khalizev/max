using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fbec3137-b7f1-4494-8d32-4cc7a3c818a2")]
        public void Method_0017_790e()
        {
            ii(0x17_790e, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x17_7912, 1); pushw(di);                                /* push di */
            ii(0x17_7913, 1); pushw(si);                                /* push si */
            ii(0x17_7914, 1); pushw(ds);                                /* push ds */
            ii(0x17_7915, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7918, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_791a, 5); mov(memw_a16[ss, bp - 0x6], 0xffff);      /* mov word [bp-0x6], 0xffff */
            ii(0x17_791f, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x17_7924, 2); jmpw(0x17_7929, 0x3); goto l_0x17_7929;   /* jmp 0x7929 */
        l_0x17_7926:
            ii(0x17_7926, 3); inc(memw_a16[ss, bp - 0x8]);              /* inc word [bp-0x8] */
        l_0x17_7929:
            ii(0x17_7929, 3); mov(ax, memw_a16[ds, 0x519e]);            /* mov ax, [0x519e] */
            ii(0x17_792c, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x17_792f, 2); if(jaew(0x17_7958, 0x27)) goto l_0x17_7958; /* jae 0x7958 */
            ii(0x17_7931, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7935, 3); mov(si, memw_a16[ss, bp - 0x8]);          /* mov si, [bp-0x8] */
            ii(0x17_7938, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_793b, 2); and(al, 0x80);                            /* and al, 0x80 */
            ii(0x17_793d, 2); cmp(al, -0x80 /* 0x80 */);                /* cmp al, 0x80 */
            ii(0x17_793f, 2); if(jzw(0x17_7956, 0x15)) goto l_0x17_7956; /* jz 0x7956 */
            ii(0x17_7941, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x17_7943, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7946, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x17_794a, 4); mov(ax, memw_a16[es, bx + si + 0x2]);     /* mov ax, [es:bx+si+0x2] */
            ii(0x17_794e, 3); or(ax, memw_a16[es, bx + si]);            /* or ax, [es:bx+si] */
            ii(0x17_7951, 2); if(jzw(0x17_7956, 0x3)) goto l_0x17_7956; /* jz 0x7956 */
            ii(0x17_7953, 2); jmpw(0x17_7958, 0x3); goto l_0x17_7958;   /* jmp 0x7958 */
        //    ii(0x17_7955, 1); nop();                                    /* nop */
        l_0x17_7956:
            ii(0x17_7956, 2); jmpw(0x17_7926, -0x32); goto l_0x17_7926; /* jmp 0x7926 */
        l_0x17_7958:
            ii(0x17_7958, 3); mov(ax, memw_a16[ds, 0x519e]);            /* mov ax, [0x519e] */
            ii(0x17_795b, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x17_795e, 2); if(jbw(0x17_7968, 0x8)) goto l_0x17_7968; /* jb 0x7968 */
            ii(0x17_7960, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_7963, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7964, 1); popw(si);                                 /* pop si */
            ii(0x17_7965, 1); popw(di);                                 /* pop di */
            ii(0x17_7966, 1); leavew();                                 /* leave */
            ii(0x17_7967, 1); retfw(); return;                          /* retf */
        l_0x17_7968:
            ii(0x17_7968, 3); mov(bx, memw_a16[ss, bp - 0x8]);          /* mov bx, [bp-0x8] */
            ii(0x17_796b, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_796e, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7972, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x17_7975, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7979, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_797c, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_797f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x17_7981, 2); if(jnzw(0x17_7986, 0x3)) goto l_0x17_7986; /* jnz 0x7986 */
            ii(0x17_7983, 3); jmpw(0x17_7a33, 0xad); goto l_0x17_7a33;  /* jmp 0x7a33 */
        l_0x17_7986:
            ii(0x17_7986, 1); nop();                                    /* nop */
            ii(0x17_7987, 1); pushw(cs);                                /* push cs */
            ii(0x17_7988, 3); callw(0x17_8ff5, 0x166a);                 /* call 0x8ff5 */
            ii(0x17_798b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_798e, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_7991, 2); if(jnzw(0x17_79a2, 0xf)) goto l_0x17_79a2; /* jnz 0x79a2 */
            ii(0x17_7993, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7995, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_7998, 1); pushw(cs);                                /* push cs */
            ii(0x17_7999, 3); callw(0x17_7bea, 0x24e);                  /* call 0x7bea */
            ii(0x17_799c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_799f, 3); jmpw(0x17_7a33, 0x91); goto l_0x17_7a33;  /* jmp 0x7a33 */
        l_0x17_79a2:
            ii(0x17_79a2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_79a4, 1); pushw(ax);                                /* push ax */
            ii(0x17_79a5, 3); mov(ax, memw_a16[ds, 0x4fd8]);            /* mov ax, [0x4fd8] */
            ii(0x17_79a8, 4); mov(dx, memw_a16[ds, 0x4fda]);            /* mov dx, [0x4fda] */
            ii(0x17_79ac, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_79ae, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_79b0, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_79b2, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_79b4, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_79b6, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_79b8, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_79ba, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_79bc, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_79be, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_79c0, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_79c2, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_79c4, 1); pushw(dx);                                /* push dx */
            ii(0x17_79c5, 1); pushw(ax);                                /* push ax */
            ii(0x17_79c6, 1); pushw(cs);                                /* push cs */
            ii(0x17_79c7, 3); callw(0x17_7dac, 0x3e2);                  /* call 0x7dac */
            ii(0x17_79ca, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_79cd, 3); mov(ax, memw_a16[ds, 0x4fd8]);            /* mov ax, [0x4fd8] */
            ii(0x17_79d0, 4); mov(dx, memw_a16[ds, 0x4fda]);            /* mov dx, [0x4fda] */
            ii(0x17_79d4, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_79d7, 1); pushw(dx);                                /* push dx */
            ii(0x17_79d8, 1); pushw(ax);                                /* push ax */
            ii(0x17_79d9, 4); pushw(memw_a16[ds, 0x1fea]);              /* push word [0x1fea] */
            ii(0x17_79dd, 1); nop();                                    /* nop */
            ii(0x17_79de, 1); pushw(cs);                                /* push cs */
            ii(0x17_79df, 3); callw(0x17_89bc, 0xfda);                  /* call 0x89bc */
            ii(0x17_79e2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_79e5, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_79e8, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_79eb, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_79ed, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_79ef, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_79f1, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_79f3, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_79f5, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_79f7, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_79f9, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_79fb, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_79fd, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_79ff, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7a01, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7a03, 1); pushw(dx);                                /* push dx */
            ii(0x17_7a04, 1); pushw(ax);                                /* push ax */
            ii(0x17_7a05, 4); pushw(memw_a16[ds, 0x4fba]);              /* push word [0x4fba] */
            ii(0x17_7a09, 1); nop();                                    /* nop */
            ii(0x17_7a0a, 1); pushw(cs);                                /* push cs */
            ii(0x17_7a0b, 3); callw(0x17_89bc, 0xfae);                  /* call 0x89bc */
            ii(0x17_7a0e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_7a11, 1); pushw(ds);                                /* push ds */
            ii(0x17_7a12, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_7a15, 4); les(di, ds, 0x1fe8);                      /* les di, [0x1fe8] */
            ii(0x17_7a19, 4); lds(si, ds, 0x4fb8);                      /* lds si, [0x4fb8] */
            ii(0x17_7a1d, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x17_7a20, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7a21, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_7a23, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_7a26, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_7a29, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_7a2c, 1); pushw(cs);                                /* push cs */
            ii(0x17_7a2d, 3); callw(0x17_7dac, 0x37c);                  /* call 0x7dac */
            ii(0x17_7a30, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x17_7a33:
            ii(0x17_7a33, 3); mov(bx, memw_a16[ss, bp - 0x8]);          /* mov bx, [bp-0x8] */
            ii(0x17_7a36, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7a39, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7a3d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_7a3f, 4); mov(memw_a16[es, bx + si + 0x2], ax);     /* mov [es:bx+si+0x2], ax */
            ii(0x17_7a43, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x17_7a46, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_7a49, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7a4a, 1); popw(si);                                 /* pop si */
            ii(0x17_7a4b, 1); popw(di);                                 /* pop di */
            ii(0x17_7a4c, 1); leavew();                                 /* leave */
            ii(0x17_7a4d, 1); retfw(); return;                          /* retf */
        }
    }
}
