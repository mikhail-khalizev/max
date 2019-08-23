using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_da4a-6de5014f")]
        public void Method_0017_da4a()
        {
            ii(0x17_da4a, 1); push(ax);                                 /* push ax */
            ii(0x17_da4b, 1); push(bx);                                 /* push bx */
            ii(0x17_da4c, 1); push(cx);                                 /* push cx */
            ii(0x17_da4d, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x17_da4f, 2); sub(cx, dx);                              /* sub cx, dx */
            ii(0x17_da51, 2); if(jcxz(0x17_da65, 0x12)) goto l_0x17_da65; /* jcxz 0xda65 */
            ii(0x17_da53, 1); push(cx);                                 /* push cx */
            ii(0x17_da54, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x17_da57, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x17_da59, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_da5b, 1); pop(cx);                                  /* pop cx */
            ii(0x17_da5c, 2); if(jb(0x17_da6b, 0xd)) goto l_0x17_da6b;  /* jb 0xda6b */
            ii(0x17_da5e, 3); add(memw[ss, bp - 0x2], ax);              /* add [bp-0x2], ax */
            ii(0x17_da61, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x17_da63, 2); if(ja(0x17_da6b, 0x6)) goto l_0x17_da6b;  /* ja 0xda6b */
        l_0x17_da65:
            ii(0x17_da65, 1); pop(cx);                                  /* pop cx */
            ii(0x17_da66, 1); pop(bx);                                  /* pop bx */
            ii(0x17_da67, 1); pop(ax);                                  /* pop ax */
            ii(0x17_da68, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_da6a, 1); ret(); return;                            /* ret */
        l_0x17_da6b:
            ii(0x17_da6b, 1); lahf();                                   /* lahf */
            ii(0x17_da6c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_da6f, 4); cmp(memw[ss, bp - 0x2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x17_da73, 2); if(jnz_func(0x17_da94, 0x1f)) return;     /* jnz 0xda94 */
            ii(0x17_da75, 1); sahf();                                   /* sahf */
            ii(0x17_da76, 2); if(jae(0x17_da7c, 0x4)) goto l_0x17_da7c; /* jae 0xda7c */
            ii(0x17_da78, 2); mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0x17_da7a, 2); if(jmp_func(0x17_da9a, 0x1e)) return;     /* jmp 0xda9a */
        l_0x17_da7c:
            ii(0x17_da7c, 5); test(memb[ds, bx + 0x1c5d], 0x40);        /* test byte [bx+0x1c5d], 0x40 */
            ii(0x17_da81, 2); if(jz(0x17_da8e, 0xb)) goto l_0x17_da8e;  /* jz 0xda8e */
            ii(0x17_da83, 3); mov(bx, memw[ss, bp + 0x8]);              /* mov bx, [bp+0x8] */
            ii(0x17_da86, 3); cmp(memb[ds, bx], 0x1a);                  /* cmp byte [bx], 0x1a */
            ii(0x17_da89, 2); if(jnz(0x17_da8e, 0x3)) goto l_0x17_da8e; /* jnz 0xda8e */
            ii(0x17_da8b, 1); clc();                                    /* clc */
            ii(0x17_da8c, 2); if(jmp_func(0x17_da9a, 0xc)) return;      /* jmp 0xda9a */
        l_0x17_da8e:
            ii(0x17_da8e, 1); stc();                                    /* stc */
            ii(0x17_da8f, 3); mov(ax, 0x1c00);                          /* mov ax, 0x1c00 */
            ii(0x17_da92, 2); if(jmp_func(0x17_da9a, 0x6)) return;      /* jmp 0xda9a */
        }
    }
}
