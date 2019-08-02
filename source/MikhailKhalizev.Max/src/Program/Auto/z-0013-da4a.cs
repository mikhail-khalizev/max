using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d490237b-4b2b-4738-b9c2-90390fa35289")]
        public void Method_0013_da4a()
        {
            ii(0x13_da4a, 1); pushw(ax);                                /* push ax */
            ii(0x13_da4b, 1); pushw(bx);                                /* push bx */
            ii(0x13_da4c, 1); pushw(cx);                                /* push cx */
            ii(0x13_da4d, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x13_da4f, 2); sub(cx, dx);                              /* sub cx, dx */
            ii(0x13_da51, 2); if(jcxzw(0x13_da65, 0x12)) goto l_0x13_da65; /* jcxz 0xda65 */
            ii(0x13_da53, 1); pushw(cx);                                /* push cx */
            ii(0x13_da54, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x13_da57, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x13_da59, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_da5b, 1); popw(cx);                                 /* pop cx */
            ii(0x13_da5c, 2); if(jbw(0x13_da6b, 0xd)) goto l_0x13_da6b; /* jb 0xda6b */
            ii(0x13_da5e, 3); add(memw_a16[ss, bp - 0x2], ax);          /* add [bp-0x2], ax */
            ii(0x13_da61, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x13_da63, 2); if(jaw(0x13_da6b, 0x6)) goto l_0x13_da6b; /* ja 0xda6b */
        l_0x13_da65:
            ii(0x13_da65, 1); popw(cx);                                 /* pop cx */
            ii(0x13_da66, 1); popw(bx);                                 /* pop bx */
            ii(0x13_da67, 1); popw(ax);                                 /* pop ax */
            ii(0x13_da68, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_da6a, 1); retw(); return;                           /* ret */
        l_0x13_da6b:
            ii(0x13_da6b, 1); lahf();                                   /* lahf */
            ii(0x13_da6c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_da6f, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x13_da73, 2); jnzw_func(0x13_da94, 0x1f);               /* jnz 0xda94 */
            ii(0x13_da75, 1); sahf();                                   /* sahf */
            ii(0x13_da76, 2); if(jaew(0x13_da7c, 0x4)) goto l_0x13_da7c; /* jae 0xda7c */
            ii(0x13_da78, 2); mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0x13_da7a, 2); jmpw_func(0x13_da9a, 0x1e); return;       /* jmp 0xda9a */
        l_0x13_da7c:
            ii(0x13_da7c, 5); test(memb_a16[ds, bx + 0x1c5d], 0x40);    /* test byte [bx+0x1c5d], 0x40 */
            ii(0x13_da81, 2); if(jzw(0x13_da8e, 0xb)) goto l_0x13_da8e; /* jz 0xda8e */
            ii(0x13_da83, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x13_da86, 3); cmp(memb_a16[ds, bx], 0x1a);              /* cmp byte [bx], 0x1a */
            ii(0x13_da89, 2); if(jnzw(0x13_da8e, 0x3)) goto l_0x13_da8e; /* jnz 0xda8e */
            ii(0x13_da8b, 1); clc();                                    /* clc */
            ii(0x13_da8c, 2); jmpw_func(0x13_da9a, 0xc); return;        /* jmp 0xda9a */
        l_0x13_da8e:
            ii(0x13_da8e, 1); stc();                                    /* stc */
            ii(0x13_da8f, 3); mov(ax, 0x1c00);                          /* mov ax, 0x1c00 */
            ii(0x13_da92, 2); jmpw_func(0x13_da9a, 0x6); return;        /* jmp 0xda9a */
        }
    }
}
