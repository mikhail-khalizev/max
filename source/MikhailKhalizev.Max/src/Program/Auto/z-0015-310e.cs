using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b460d09b-da76-4444-a75c-fa82e5d9973a")]
        public void Method_0015_310e()
        {
            ii(0x15_310e, 1); pushw(bp);                                /* push bp */
            ii(0x15_310f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_3111, 3); sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0x15_3114, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x15_3117, 4); cmp(bx, memw_a16[ds, 0x3c1f]);            /* cmp bx, [0x3c1f] */
            ii(0x15_311b, 2); if(jbw(0x15_3124, 0x7)) goto l_0x15_3124; /* jb 0x3124 */
            ii(0x15_311d, 3); mov(ax, 0x900);                           /* mov ax, 0x900 */
            ii(0x15_3120, 1); stc();                                    /* stc */
        l_0x15_3121:
            ii(0x15_3121, 3); if(jmpw_func(0x15_2cd9, -0x44b)) return;  /* jmp 0x2cd9 */
        l_0x15_3124:
            ii(0x15_3124, 6); cmp(memw_a16[ds, 0x3f68], 0xd6d6);        /* cmp word [0x3f68], 0xd6d6 */
            ii(0x15_312a, 2); if(jnzw(0x15_3130, 0x4)) goto l_0x15_3130; /* jnz 0x3130 */
            ii(0x15_312c, 4); callw_abs(memw_a16[ds, 0x3f6a]);          /* call word [0x3f6a] */
        l_0x15_3130:
            ii(0x15_3130, 5); test(memb_a16[ds, bx + 0x3c21], 0x20);    /* test byte [bx+0x3c21], 0x20 */
            ii(0x15_3135, 2); if(jzw(0x15_3142, 0xb)) goto l_0x15_3142; /* jz 0x3142 */
            ii(0x15_3137, 3); mov(ax, 0x4202);                          /* mov ax, 0x4202 */
            ii(0x15_313a, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x15_313c, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x15_313e, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_3140, 2); if(jbw(0x15_3121, -0x21)) goto l_0x15_3121; /* jb 0x3121 */
        l_0x15_3142:
            ii(0x15_3142, 5); test(memb_a16[ds, bx + 0x3c21], 0x80);    /* test byte [bx+0x3c21], 0x80 */
            ii(0x15_3147, 2); if(jzw(0x15_31c5, 0x7c)) goto l_0x15_31c5; /* jz 0x31c5 */
            ii(0x15_3149, 3); mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x15_314c, 3); mov(es, memw_a16[ss, bp + 0xa]);          /* mov es, [bp+0xa] */
            ii(0x15_314f, 3); lds(dx, ss, bp + 0x8);                    /* lds dx, [bp+0x8] */
            ii(0x15_3152, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_3154, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_3157, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_315a, 1); cld();                                    /* cld */
            ii(0x15_315b, 1); pushw(di);                                /* push di */
            ii(0x15_315c, 1); pushw(si);                                /* push si */
            ii(0x15_315d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_315f, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x15_3161, 3); mov(memw_a16[ss, bp - 0x8], sp);          /* mov [bp-0x8], sp */
            ii(0x15_3164, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x15_3167, 2); if(jcxzw(0x15_31a8, 0x3f)) goto l_0x15_31a8; /* jcxz 0x31a8 */
            ii(0x15_3169, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x15_316b, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_316d, 2); if(jnzw(0x15_31c0, 0x51)) goto l_0x15_31c0; /* jnz 0x31c0 */
            ii(0x15_316f, 1); pushw(ds);                                /* push ds */
            ii(0x15_3170, 3); mov(ds, memw_a16[ss, bp - 0x6]);          /* mov ds, [bp-0x6] */
            ii(0x15_3173, 1); nop();                                    /* nop */
            ii(0x15_3174, 1); pushw(cs);                                /* push cs */
            ii(0x15_3175, 3); callw(0x15_3b54, 0x9dc);                  /* call 0x3b54 */
            ii(0x15_3178, 3); cmp(ax, 0xa8);                            /* cmp ax, 0xa8 */
            ii(0x15_317b, 2); if(jbew(0x15_31c7, 0x4a)) goto l_0x15_31c7; /* jbe 0x31c7 */
            ii(0x15_317d, 1); popw(ds);                                 /* pop ds */
            ii(0x15_317e, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x15_3181, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x15_3183, 3); mov(dx, 0x200);                           /* mov dx, 0x200 */
            ii(0x15_3186, 3); cmp(ax, 0x228);                           /* cmp ax, 0x228 */
            ii(0x15_3189, 2); if(jaew(0x15_318e, 0x3)) goto l_0x15_318e; /* jae 0x318e */
            ii(0x15_318b, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
        l_0x15_318e:
            ii(0x15_318e, 2); sub(sp, dx);                              /* sub sp, dx */
            ii(0x15_3190, 2); mov(dx, sp);                              /* mov dx, sp */
            ii(0x15_3192, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_3194, 1); pushw(ss);                                /* push ss */
            ii(0x15_3195, 1); popw(es);                                 /* pop es */
            ii(0x15_3196, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
        l_0x15_3199:
            ii(0x15_3199, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_319a, 2); cmp(al, 0xa);                             /* cmp al, 0xa */
            ii(0x15_319c, 2); if(jzw(0x15_31aa, 0xc)) goto l_0x15_31aa; /* jz 0x31aa */
        l_0x15_319e:
            ii(0x15_319e, 2); cmp(di, bx);                              /* cmp di, bx */
            ii(0x15_31a0, 2); if(jzw(0x15_31bb, 0x19)) goto l_0x15_31bb; /* jz 0x31bb */
        l_0x15_31a2:
            ii(0x15_31a2, 1); stosb_a16();                              /* stosb */
            ii(0x15_31a3, 2); if(loopw_a16(0x15_3199, -0xc)) goto l_0x15_3199; /* loop 0x3199 */
            ii(0x15_31a5, 3); callw(0x15_31ce, 0x26);                   /* call 0x31ce */
        l_0x15_31a8:
            ii(0x15_31a8, 2); if(jmpw_func(0x15_3223, 0x79)) return;    /* jmp 0x3223 */
        l_0x15_31aa:
            ii(0x15_31aa, 2); mov(al, 0xd);                             /* mov al, 0xd */
            ii(0x15_31ac, 2); cmp(di, bx);                              /* cmp di, bx */
            ii(0x15_31ae, 2); if(jnzw(0x15_31b3, 0x3)) goto l_0x15_31b3; /* jnz 0x31b3 */
            ii(0x15_31b0, 3); callw(0x15_31ce, 0x1b);                   /* call 0x31ce */
        l_0x15_31b3:
            ii(0x15_31b3, 1); stosb_a16();                              /* stosb */
            ii(0x15_31b4, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x15_31b6, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x15_31b9, 2); jmpw(0x15_319e, -0x1d); goto l_0x15_319e; /* jmp 0x319e */
        l_0x15_31bb:
            ii(0x15_31bb, 3); callw(0x15_31ce, 0x10);                   /* call 0x31ce */
            ii(0x15_31be, 2); jmpw(0x15_31a2, -0x1e); goto l_0x15_31a2; /* jmp 0x31a2 */
        l_0x15_31c0:
            ii(0x15_31c0, 1); popw(si);                                 /* pop si */
            ii(0x15_31c1, 1); popw(di);                                 /* pop di */
            ii(0x15_31c2, 3); mov(ds, memw_a16[ss, bp - 0x6]);          /* mov ds, [bp-0x6] */
        l_0x15_31c5:
            ii(0x15_31c5, 2); if(jmpw_func(0x15_3234, 0x6d)) return;    /* jmp 0x3234 */
        l_0x15_31c7:
            ii(0x15_31c7, 3); mov(ax, 0xfffc);                          /* mov ax, 0xfffc */
            ii(0x15_31ca, 1); pushw(cs);                                /* push cs */
            ii(0x15_31cb, 3); callw(0x15_3abe, 0x8f0);                  /* call 0x3abe */
        }
    }
}
