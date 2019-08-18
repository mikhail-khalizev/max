using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c9e7-30b9d2d5")]
        public void Method_0019_c9e7()
        {
            ii(0x19_c9e7, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x19_c9eb, 1); pushw(di);                                /* push di */
            ii(0x19_c9ec, 1); pushw(si);                                /* push si */
            ii(0x19_c9ed, 5); mov(memw_a16[ss, bp - 0x4], 0xffff);      /* mov word [bp-0x4], 0xffff */
            ii(0x19_c9f2, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x19_c9f7, 2); jmpw(0x19_c9fc, 0x3); goto l_0x19_c9fc;   /* jmp 0xc9fc */
        l_0x19_c9f9:
            ii(0x19_c9f9, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_c9fc:
            ii(0x19_c9fc, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_c9ff, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_ca01, 4); cmp(dx, memw_a16[ds, 0x2162]);            /* cmp dx, [0x2162] */
            ii(0x19_ca05, 2); if(jaw(0x19_ca2d, 0x26)) goto l_0x19_ca2d; /* ja 0xca2d */
            ii(0x19_ca07, 2); if(jbw(0x19_ca0f, 0x6)) goto l_0x19_ca0f; /* jb 0xca0f */
            ii(0x19_ca09, 4); cmp(ax, memw_a16[ds, 0x2160]);            /* cmp ax, [0x2160] */
            ii(0x19_ca0d, 2); if(jaew(0x19_ca2d, 0x1e)) goto l_0x19_ca2d; /* jae 0xca2d */
        l_0x19_ca0f:
            ii(0x19_ca0f, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_ca12, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_ca15, 4); imul(bx, memw_a16[ss, bp - 0x2], 0xc);    /* imul bx, [bp-0x2], 0xc */
            ii(0x19_ca19, 4); cmp(memw_a16[ds, bx + 0x2164], ax);       /* cmp [bx+0x2164], ax */
            ii(0x19_ca1d, 2); if(jnzw(0x19_c9f9, -0x26)) goto l_0x19_c9f9; /* jnz 0xc9f9 */
            ii(0x19_ca1f, 4); cmp(memw_a16[ds, bx + 0x2166], dx);       /* cmp [bx+0x2166], dx */
            ii(0x19_ca23, 2); if(jnzw(0x19_c9f9, -0x2c)) goto l_0x19_c9f9; /* jnz 0xc9f9 */
            ii(0x19_ca25, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_ca28, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_ca2b, 2); jmpw(0x19_c9f9, -0x34); goto l_0x19_c9f9; /* jmp 0xc9f9 */
        l_0x19_ca2d:
            ii(0x19_ca2d, 4); cmp(memw_a16[ss, bp - 0x4], -0x1 /* 0xff */); /* cmp word [bp-0x4], 0xffff */
            ii(0x19_ca31, 2); if(jzw(0x19_ca81, 0x4e)) goto l_0x19_ca81; /* jz 0xca81 */
            ii(0x19_ca33, 4); imul(bx, memw_a16[ss, bp - 0x4], 0xc);    /* imul bx, [bp-0x4], 0xc */
            ii(0x19_ca37, 4); pushw(memw_a16[ds, bx + 0x216e]);         /* push word [bx+0x216e] */
            ii(0x19_ca3b, 4); pushw(memw_a16[ds, bx + 0x216c]);         /* push word [bx+0x216c] */
            ii(0x19_ca3f, 3); callw(0x19_c94d, -0xf5);                  /* call 0xc94d */
            ii(0x19_ca42, 5); sub(memw_a16[ds, 0x2160], 0x1);           /* sub word [0x2160], 0x1 */
            ii(0x19_ca47, 5); sbb(memw_a16[ds, 0x2162], 0);             /* sbb word [0x2162], 0x0 */
        l_0x19_ca4c:
            ii(0x19_ca4c, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_ca4f, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x19_ca52, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_ca54, 4); cmp(dx, memw_a16[ds, 0x2162]);            /* cmp dx, [0x2162] */
            ii(0x19_ca58, 2); if(jaw(0x19_ca7c, 0x22)) goto l_0x19_ca7c; /* ja 0xca7c */
            ii(0x19_ca5a, 2); if(jbw(0x19_ca62, 0x6)) goto l_0x19_ca62; /* jb 0xca62 */
            ii(0x19_ca5c, 4); cmp(ax, memw_a16[ds, 0x2160]);            /* cmp ax, [0x2160] */
            ii(0x19_ca60, 2); if(jaew(0x19_ca7c, 0x1a)) goto l_0x19_ca7c; /* jae 0xca7c */
        l_0x19_ca62:
            ii(0x19_ca62, 4); imul(ax, memw_a16[ss, bp - 0x4], 0xc);    /* imul ax, [bp-0x4], 0xc */
            ii(0x19_ca66, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_ca68, 3); add(ax, 0x2164);                          /* add ax, 0x2164 */
            ii(0x19_ca6b, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x19_ca6d, 4); lea(di, bx + 0x2158);                     /* lea di, [bx+0x2158] */
            ii(0x19_ca71, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_ca73, 1); pushw(ds);                                /* push ds */
            ii(0x19_ca74, 1); popw(es);                                 /* pop es */
            ii(0x19_ca75, 3); mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0x19_ca78, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x19_ca7a, 2); jmpw(0x19_ca4c, -0x30); goto l_0x19_ca4c; /* jmp 0xca4c */
        l_0x19_ca7c:
            ii(0x19_ca7c, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_ca7f, 2); jmpw(0x19_ca83, 0x2); goto l_0x19_ca83;   /* jmp 0xca83 */
        l_0x19_ca81:
            ii(0x19_ca81, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_ca83:
            ii(0x19_ca83, 1); popw(si);                                 /* pop si */
            ii(0x19_ca84, 1); popw(di);                                 /* pop di */
            ii(0x19_ca85, 1); leavew();                                 /* leave */
            ii(0x19_ca86, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
