using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3f2a-90e3e801")]
        public void Method_0019_3f2a()
        {
            ii(0x19_3f2a, 1); inc(cx);                                  /* inc cx */
            ii(0x19_3f2b, 3); and(cl, 0xfe);                            /* and cl, 0xfe */
            ii(0x19_3f2e, 1); pushw(bx);                                /* push bx */
            ii(0x19_3f2f, 1); cld();                                    /* cld */
            ii(0x19_3f30, 3); mov(si, memw_a16[ds, bx + 0x8]);          /* mov si, [bx+0x8] */
            ii(0x19_3f33, 3); mov(bx, memw_a16[ds, bx + 0xa]);          /* mov bx, [bx+0xa] */
            ii(0x19_3f36, 2); xor(di, di);                              /* xor di, di */
            ii(0x19_3f38, 2); jmpw(0x19_3f5d, 0x23); goto l_0x19_3f5d;  /* jmp 0x3f5d */
        l_0x19_3f3a:
            ii(0x19_3f3a, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_3f3c, 1); popw(bx);                                 /* pop bx */
            ii(0x19_3f3d, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x19_3f3f, 2); if(jnzw(0x19_3f83, 0x42)) goto l_0x19_3f83; /* jnz 0x3f83 */
            ii(0x19_3f41, 1); pushw(bx);                                /* push bx */
            ii(0x19_3f42, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
            ii(0x19_3f45, 3); mov(bx, memw_a16[ds, bx + 0x8]);          /* mov bx, [bx+0x8] */
            ii(0x19_3f48, 2); cmp(bx, si);                              /* cmp bx, si */
            ii(0x19_3f4a, 2); if(jzw(0x19_3f82, 0x36)) goto l_0x19_3f82; /* jz 0x3f82 */
            ii(0x19_3f4c, 1); dec(bx);                                  /* dec bx */
            ii(0x19_3f4d, 2); xor(di, di);                              /* xor di, di */
            ii(0x19_3f4f, 2); jmpw(0x19_3f5d, 0xc); goto l_0x19_3f5d;   /* jmp 0x3f5d */
        //  ii(0x19_3f51, 1); Недостижимый код.
        l_0x19_3f52:
            ii(0x19_3f52, 3); lea(dx, si - 0x2);                        /* lea dx, [si-0x2] */
            ii(0x19_3f55, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x19_3f57, 2); if(jaew(0x19_3f3a, -0x1f)) goto l_0x19_3f3a; /* jae 0x3f3a */
            ii(0x19_3f59, 2); add(si, ax);                              /* add si, ax */
            ii(0x19_3f5b, 2); if(jbw(0x19_3f80, 0x23)) goto l_0x19_3f80; /* jb 0x3f80 */
        l_0x19_3f5d:
            ii(0x19_3f5d, 1); lodsw_a16();                              /* lodsw */
            ii(0x19_3f5e, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x19_3f60, 2); if(jzw(0x19_3f52, -0x10)) goto l_0x19_3f52; /* jz 0x3f52 */
            ii(0x19_3f62, 2); mov(di, si);                              /* mov di, si */
        l_0x19_3f64:
            ii(0x19_3f64, 1); dec(ax);                                  /* dec ax */
            ii(0x19_3f65, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x19_3f67, 2); if(jaew(0x19_3f8c, 0x23)) goto l_0x19_3f8c; /* jae 0x3f8c */
            ii(0x19_3f69, 2); add(si, ax);                              /* add si, ax */
            ii(0x19_3f6b, 2); if(jbw(0x19_3f80, 0x13)) goto l_0x19_3f80; /* jb 0x3f80 */
            ii(0x19_3f6d, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x19_3f6f, 1); lodsw_a16();                              /* lodsw */
            ii(0x19_3f70, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x19_3f72, 2); if(jzw(0x19_3f52, -0x22)) goto l_0x19_3f52; /* jz 0x3f52 */
            ii(0x19_3f74, 2); add(ax, dx);                              /* add ax, dx */
            ii(0x19_3f76, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x19_3f79, 2); mov(si, di);                              /* mov si, di */
            ii(0x19_3f7b, 3); mov(memw_a16[ds, si - 0x2], ax);          /* mov [si-0x2], ax */
            ii(0x19_3f7e, 2); jmpw(0x19_3f64, -0x1c); goto l_0x19_3f64; /* jmp 0x3f64 */
        l_0x19_3f80:
            ii(0x19_3f80, 2); mov(ax, ax);                              /* mov ax, ax */
        l_0x19_3f82:
            ii(0x19_3f82, 1); popw(bx);                                 /* pop bx */
        l_0x19_3f83:
            ii(0x19_3f83, 3); mov(ax, memw_a16[ds, bx + 0x6]);          /* mov ax, [bx+0x6] */
            ii(0x19_3f86, 3); mov(memw_a16[ds, bx + 0x8], ax);          /* mov [bx+0x8], ax */
            ii(0x19_3f89, 1); stc();                                    /* stc */
            ii(0x19_3f8a, 2); jmpw(0x19_3fa5, 0x19); goto l_0x19_3fa5;  /* jmp 0x3fa5 */
        l_0x19_3f8c:
            ii(0x19_3f8c, 1); popw(bx);                                 /* pop bx */
            ii(0x19_3f8d, 3); mov(memw_a16[ds, si - 0x2], cx);          /* mov [si-0x2], cx */
            ii(0x19_3f90, 2); if(jzw(0x19_3f9b, 0x9)) goto l_0x19_3f9b; /* jz 0x3f9b */
            ii(0x19_3f92, 2); add(di, cx);                              /* add di, cx */
            ii(0x19_3f94, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x19_3f96, 1); dec(ax);                                  /* dec ax */
            ii(0x19_3f97, 2); mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x19_3f99, 2); sub(di, cx);                              /* sub di, cx */
        l_0x19_3f9b:
            ii(0x19_3f9b, 2); add(di, cx);                              /* add di, cx */
            ii(0x19_3f9d, 3); mov(memw_a16[ds, bx + 0x8], di);          /* mov [bx+0x8], di */
            ii(0x19_3fa0, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_3fa2, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_3fa4, 1); clc();                                    /* clc */
        l_0x19_3fa5:
            ii(0x19_3fa5, 1); retw(); return;                           /* ret */
        }
    }
}
