using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0de5193f-2e85-4d0c-826c-0652bde4fb8f")]
        public void Method_0015_7ecf()
        {
            ii(0x15_7ecf, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_7ed3, 1); pushw(di);                                /* push di */
            ii(0x15_7ed4, 1); pushw(si);                                /* push si */
            ii(0x15_7ed5, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_7ed8, 3); jmpw(0x15_80ab, 0x1d0); goto l_0x15_80ab; /* jmp 0x80ab */
        l_0x15_7edb:
            ii(0x15_7edb, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_7edd, 1); pushw(ds);                                /* push ds */
            ii(0x15_7ede, 3); pushw(0x489c);                            /* push 0x489c */
            ii(0x15_7ee1, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7ee4, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_7ee8, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7eeb, 4); mov(ax, memw_a16[es, bx + 0x32]);         /* mov ax, [es:bx+0x32] */
            ii(0x15_7eef, 4); mov(dx, memw_a16[es, bx + 0x34]);         /* mov dx, [es:bx+0x34] */
            ii(0x15_7ef3, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x15_7ef6, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_7ef9, 1); pushw(dx);                                /* push dx */
            ii(0x15_7efa, 1); pushw(ax);                                /* push ax */
            ii(0x15_7efb, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_7f00, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7f03, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_7f05, 1); pushw(ds);                                /* push ds */
            ii(0x15_7f06, 3); pushw(0x489c);                            /* push 0x489c */
            ii(0x15_7f09, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f0c, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_7f10, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f13, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_7f17, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_7f1b, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_7f20, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7f23, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f26, 5); add(memw_a16[es, bx + 0x32], 0x4);        /* add word [es:bx+0x32], 0x4 */
            ii(0x15_7f2b, 5); adc(memw_a16[es, bx + 0x34], 0);          /* adc word [es:bx+0x34], 0x0 */
            ii(0x15_7f30, 3); jmpw(0x15_80d4, 0x1a1); goto l_0x15_80d4; /* jmp 0x80d4 */
        l_0x15_7f33:
            ii(0x15_7f33, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_7f35, 1); pushw(ds);                                /* push ds */
            ii(0x15_7f36, 3); pushw(0x489c);                            /* push 0x489c */
            ii(0x15_7f39, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f3c, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_7f40, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f43, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_7f47, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_7f4b, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_7f50, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7f53, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f56, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x15_7f5a, 4); sub(memw_a16[ds, 0x489c], ax);            /* sub [0x489c], ax */
            ii(0x15_7f5e, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_7f60, 1); pushw(ds);                                /* push ds */
            ii(0x15_7f61, 3); pushw(0x489c);                            /* push 0x489c */
            ii(0x15_7f64, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f67, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_7f6b, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f6e, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_7f72, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_7f76, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_7f7b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7f7e, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f81, 5); add(memw_a16[es, bx + 0x32], 0x2);        /* add word [es:bx+0x32], 0x2 */
            ii(0x15_7f86, 5); adc(memw_a16[es, bx + 0x34], 0);          /* adc word [es:bx+0x34], 0x0 */
            ii(0x15_7f8b, 3); jmpw(0x15_80d4, 0x146); goto l_0x15_80d4; /* jmp 0x80d4 */
        l_0x15_7f8e:
            ii(0x15_7f8e, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_7f90, 1); pushw(ds);                                /* push ds */
            ii(0x15_7f91, 3); pushw(0x489f);                            /* push 0x489f */
            ii(0x15_7f94, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f97, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_7f9b, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7f9e, 4); mov(ax, memw_a16[es, bx + 0x32]);         /* mov ax, [es:bx+0x32] */
            ii(0x15_7fa2, 4); mov(dx, memw_a16[es, bx + 0x34]);         /* mov dx, [es:bx+0x34] */
            ii(0x15_7fa6, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x15_7fa9, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_7fac, 1); pushw(dx);                                /* push dx */
            ii(0x15_7fad, 1); pushw(ax);                                /* push ax */
            ii(0x15_7fae, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_7fb3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7fb6, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_7fb8, 1); pushw(ds);                                /* push ds */
            ii(0x15_7fb9, 3); pushw(0x489f);                            /* push 0x489f */
            ii(0x15_7fbc, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7fbf, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_7fc3, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7fc6, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_7fca, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_7fce, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_7fd3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_7fd6, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7fd9, 5); add(memw_a16[es, bx + 0x32], 0x3);        /* add word [es:bx+0x32], 0x3 */
            ii(0x15_7fde, 5); adc(memw_a16[es, bx + 0x34], 0);          /* adc word [es:bx+0x34], 0x0 */
            ii(0x15_7fe3, 3); jmpw(0x15_80d4, 0xee); goto l_0x15_80d4;  /* jmp 0x80d4 */
        l_0x15_7fe6:
            ii(0x15_7fe6, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_7fe8, 1); pushw(ds);                                /* push ds */
            ii(0x15_7fe9, 3); pushw(0x489e);                            /* push 0x489e */
            ii(0x15_7fec, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7fef, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_7ff3, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_7ff6, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_7ffa, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_7ffe, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_8003, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_8006, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_8008, 1); pushw(ds);                                /* push ds */
            ii(0x15_8009, 3); pushw(0x489f);                            /* push 0x489f */
            ii(0x15_800c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_800f, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_8013, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8016, 4); mov(ax, memw_a16[es, bx + 0x32]);         /* mov ax, [es:bx+0x32] */
            ii(0x15_801a, 4); mov(dx, memw_a16[es, bx + 0x34]);         /* mov dx, [es:bx+0x34] */
            ii(0x15_801e, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x15_8021, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_8024, 1); pushw(dx);                                /* push dx */
            ii(0x15_8025, 1); pushw(ax);                                /* push ax */
            ii(0x15_8026, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_802b, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_802e, 3); mov(al, memb_a16[ds, 0x489f]);            /* mov al, [0x489f] */
            ii(0x15_8031, 4); or(memb_a16[ds, 0x489e], al);             /* or [0x489e], al */
            ii(0x15_8035, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_8037, 1); pushw(ds);                                /* push ds */
            ii(0x15_8038, 3); pushw(0x489e);                            /* push 0x489e */
            ii(0x15_803b, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_803e, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_8042, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8045, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_8049, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_804d, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_8052, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_8055, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8058, 5); add(memw_a16[es, bx + 0x32], 0x3);        /* add word [es:bx+0x32], 0x3 */
            ii(0x15_805d, 5); adc(memw_a16[es, bx + 0x34], 0);          /* adc word [es:bx+0x34], 0x0 */
            ii(0x15_8062, 3); jmpw(0x15_80d4, 0x6f); goto l_0x15_80d4;  /* jmp 0x80d4 */
        l_0x15_8065:
            ii(0x15_8065, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8068, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x15_806c, 3); mov(memw_a16[ds, 0x489c], ax);            /* mov [0x489c], ax */
            ii(0x15_806f, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_8071, 1); pushw(ds);                                /* push ds */
            ii(0x15_8072, 3); pushw(0x489c);                            /* push 0x489c */
            ii(0x15_8075, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8078, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_807c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_807f, 4); pushw(memw_a16[es, bx + 0x12]);           /* push word [es:bx+0x12] */
            ii(0x15_8083, 4); pushw(memw_a16[es, bx + 0x10]);           /* push word [es:bx+0x10] */
            ii(0x15_8087, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_808c, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_808f, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_8092, 5); add(memw_a16[es, bx + 0x32], 0x2);        /* add word [es:bx+0x32], 0x2 */
            ii(0x15_8097, 5); adc(memw_a16[es, bx + 0x34], 0);          /* adc word [es:bx+0x34], 0x0 */
            ii(0x15_809c, 3); jmpw(0x15_80d4, 0x35); goto l_0x15_80d4;  /* jmp 0x80d4 */
        l_0x15_809f:
            ii(0x15_809f, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_80a2, 3); jmpw(0x15_80da, 0x35); goto l_0x15_80da;  /* jmp 0x80da */
        //  ii(0x15_80a5, 6); Недостижимый код.
l_0x15_80ab:
            ii(0x15_80ab, 3); sub(ax, 0x429);                           /* sub ax, 0x429 */
            ii(0x15_80ae, 2); if(jnzw(0x15_80b3, 0x3)) goto l_0x15_80b3; /* jnz 0x80b3 */
            ii(0x15_80b0, 3); jmpw(0x15_7f33, -0x180); goto l_0x15_7f33; /* jmp 0x7f33 */
        l_0x15_80b3:
            ii(0x15_80b3, 3); sub(ax, 0x60);                            /* sub ax, 0x60 */
            ii(0x15_80b6, 2); if(jnzw(0x15_80bb, 0x3)) goto l_0x15_80bb; /* jnz 0x80bb */
            ii(0x15_80b8, 3); jmpw(0x15_8065, -0x56); goto l_0x15_8065; /* jmp 0x8065 */
        l_0x15_80bb:
            ii(0x15_80bb, 3); sub(ax, 0x3d);                            /* sub ax, 0x3d */
            ii(0x15_80be, 2); if(jnzw(0x15_80c3, 0x3)) goto l_0x15_80c3; /* jnz 0x80c3 */
            ii(0x15_80c0, 3); jmpw(0x15_7f8e, -0x135); goto l_0x15_7f8e; /* jmp 0x7f8e */
        l_0x15_80c3:
            ii(0x15_80c3, 1); dec(ax);                                  /* dec ax */
            ii(0x15_80c4, 2); if(jnzw(0x15_80c9, 0x3)) goto l_0x15_80c9; /* jnz 0x80c9 */
            ii(0x15_80c6, 3); jmpw(0x15_7edb, -0x1ee); goto l_0x15_7edb; /* jmp 0x7edb */
        l_0x15_80c9:
            ii(0x15_80c9, 3); sub(ax, 0x7b9);                           /* sub ax, 0x7b9 */
            ii(0x15_80cc, 2); if(jnzw(0x15_80d1, 0x3)) goto l_0x15_80d1; /* jnz 0x80d1 */
            ii(0x15_80ce, 3); jmpw(0x15_7fe6, -0xeb); goto l_0x15_7fe6; /* jmp 0x7fe6 */
        l_0x15_80d1:
            ii(0x15_80d1, 3); jmpw(0x15_809f, -0x35); goto l_0x15_809f; /* jmp 0x809f */
        l_0x15_80d4:
            ii(0x15_80d4, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_80d7, 3); jmpw(0x15_80da, 0); goto l_0x15_80da;     /* jmp 0x80da */
        l_0x15_80da:
            ii(0x15_80da, 1); popw(si);                                 /* pop si */
            ii(0x15_80db, 1); popw(di);                                 /* pop di */
            ii(0x15_80dc, 1); leavew();                                 /* leave */
            ii(0x15_80dd, 1); retfw(); return;                          /* retf */
        }
    }
}
