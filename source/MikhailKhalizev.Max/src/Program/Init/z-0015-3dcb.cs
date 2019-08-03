using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("909064ca-204b-4232-bee5-0c9cde175cdd")]
        public void Method_0015_3dcb()
        {
            ii(0x15_3dcb, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x15_3dcd, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x15_3dd1, 2); if(jzw(0x15_3de2, 0xf)) goto l_0x15_3de2; /* jz 0x3de2 */
            ii(0x15_3dd3, 1); dec(dx);                                  /* dec dx */
            ii(0x15_3dd4, 3); mov(si, memw_a16[ds, bx + 0x4]);          /* mov si, [bx+0x4] */
            ii(0x15_3dd7, 1); dec(si);                                  /* dec si */
            ii(0x15_3dd8, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x15_3dda, 2); if(jbw(0x15_3de1, 0x5)) goto l_0x15_3de1; /* jb 0x3de1 */
            ii(0x15_3ddc, 3); cmp(memw_a16[ds, bx - 0x2], dx);          /* cmp [bx-0x2], dx */
            ii(0x15_3ddf, 2); if(jaew(0x15_3e17, 0x36)) goto l_0x15_3e17; /* jae 0x3e17 */
        l_0x15_3de1:
            ii(0x15_3de1, 1); inc(dx);                                  /* inc dx */
        l_0x15_3de2:
            ii(0x15_3de2, 1); pushw(bx);                                /* push bx */
            ii(0x15_3de3, 1); pushw(cx);                                /* push cx */
            ii(0x15_3de4, 2); mov(si, ds);                              /* mov si, ds */
            ii(0x15_3de6, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_3de8, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x15_3dea, 2); shr(ax, cl);                              /* shr ax, cl */
            ii(0x15_3dec, 2); if(jnzw(0x15_3df1, 0x3)) goto l_0x15_3df1; /* jnz 0x3df1 */
            ii(0x15_3dee, 3); mov(ax, 0x1000);                          /* mov ax, 0x1000 */
        l_0x15_3df1:
            ii(0x15_3df1, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x15_3df5, 2); if(jzw(0x15_3e01, 0xa)) goto l_0x15_3e01; /* jz 0x3e01 */
            ii(0x15_3df7, 2); add(ax, si);                              /* add ax, si */
            ii(0x15_3df9, 4); mov(bx, memw_a16[ds, 0x3c18]);            /* mov bx, [0x3c18] */
            ii(0x15_3dfd, 2); sub(ax, bx);                              /* sub ax, bx */
            ii(0x15_3dff, 2); mov(es, bx);                              /* mov es, bx */
        l_0x15_3e01:
            ii(0x15_3e01, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_3e03, 2); mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x15_3e05, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_3e07, 1); popw(cx);                                 /* pop cx */
            ii(0x15_3e08, 1); popw(bx);                                 /* pop bx */
            ii(0x15_3e09, 2); if(jbw(0x15_3e1b, 0x10)) goto l_0x15_3e1b; /* jb 0x3e1b */
            ii(0x15_3e0b, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_3e0d, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x15_3e11, 2); if(jzw(0x15_3e17, 0x4)) goto l_0x15_3e17; /* jz 0x3e17 */
            ii(0x15_3e13, 1); dec(dx);                                  /* dec dx */
            ii(0x15_3e14, 3); mov(memw_a16[ds, bx - 0x2], dx);          /* mov [bx-0x2], dx */
        l_0x15_3e17:
            ii(0x15_3e17, 1); clc();                                    /* clc */
            ii(0x15_3e18, 2); jmpw(0x15_3e1b, 0x1); goto l_0x15_3e1b;   /* jmp 0x3e1b */
        //  ii(0x15_3e1a, 1); Недостижимый код.
l_0x15_3e1b:
            ii(0x15_3e1b, 1); retw(); return;                           /* ret */
        }
    }
}