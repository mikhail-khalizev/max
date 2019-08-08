using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a51fad7f-6b27-4458-872d-cb2eefd57eb4")]
        public void Method_0015_f0ce()
        {
            ii(0x15_f0ce, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x15_f0d2, 1); pushw(di);                                /* push di */
            ii(0x15_f0d3, 1); pushw(si);                                /* push si */
            ii(0x15_f0d4, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x15_f0d7, 1); pushw(ss);                                /* push ss */
            ii(0x15_f0d8, 1); pushw(ax);                                /* push ax */
            ii(0x15_f0d9, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_f0dc, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x15_f0e1, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f0e4, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_f0e7, 2); if(jzw(0x15_f0ec, 0x3)) goto l_0x15_f0ec; /* jz 0xf0ec */
            ii(0x15_f0e9, 3); jmpw(0x15_f0f2, 0x6); goto l_0x15_f0f2;   /* jmp 0xf0f2 */
        l_0x15_f0ec:
            ii(0x15_f0ec, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_f0ef, 3); jmpw(0x15_f15a, 0x68); goto l_0x15_f15a;  /* jmp 0xf15a */
        l_0x15_f0f2:
            ii(0x15_f0f2, 3); mov(al, memb_a16[ss, bp - 0xc]);          /* mov al, [bp-0xc] */
            ii(0x15_f0f5, 3); mov(ah, memb_a16[ss, bp - 0x9]);          /* mov ah, [bp-0x9] */
            ii(0x15_f0f8, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x15_f0fb, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x15_f0fe, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_f101, 3); mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x15_f104, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x15_f107, 3); mov(cx, memw_a16[ss, bp - 0x10]);         /* mov cx, [bp-0x10] */
            ii(0x15_f10a, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x15_f10d, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_f110, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_f113, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x15_f116, 2); if(jzw(0x15_f11b, 0x3)) goto l_0x15_f11b; /* jz 0xf11b */
            ii(0x15_f118, 3); jmpw(0x15_f13e, 0x23); goto l_0x15_f13e;  /* jmp 0xf13e */
        l_0x15_f11b:
            ii(0x15_f11b, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_f11e, 3); or(ax, memw_a16[ss, bp - 0x8]);           /* or ax, [bp-0x8] */
            ii(0x15_f121, 2); if(jzw(0x15_f126, 0x3)) goto l_0x15_f126; /* jz 0xf126 */
            ii(0x15_f123, 3); jmpw(0x15_f13e, 0x18); goto l_0x15_f13e;  /* jmp 0xf13e */
        l_0x15_f126:
            ii(0x15_f126, 4); cmp(memb_a16[ss, bp - 0xb], 0);           /* cmp byte [bp-0xb], 0x0 */
            ii(0x15_f12a, 2); if(jzw(0x15_f12f, 0x3)) goto l_0x15_f12f; /* jz 0xf12f */
            ii(0x15_f12c, 3); jmpw(0x15_f13e, 0xf); goto l_0x15_f13e;   /* jmp 0xf13e */
        l_0x15_f12f:
            ii(0x15_f12f, 4); cmp(memb_a16[ss, bp - 0xa], 0);           /* cmp byte [bp-0xa], 0x0 */
            ii(0x15_f133, 2); if(jzw(0x15_f138, 0x3)) goto l_0x15_f138; /* jz 0xf138 */
            ii(0x15_f135, 3); jmpw(0x15_f13e, 0x6); goto l_0x15_f13e;   /* jmp 0xf13e */
        l_0x15_f138:
            ii(0x15_f138, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_f13b, 3); jmpw(0x15_f15a, 0x1c); goto l_0x15_f15a;  /* jmp 0xf15a */
        l_0x15_f13e:
            ii(0x15_f13e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_f141, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_f144, 3); add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0x15_f147, 3); adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0x15_f14a, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x15_f14d, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_f150, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x15_f154, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_f157, 3); jmpw(0x15_f15a, 0); goto l_0x15_f15a;     /* jmp 0xf15a */
        l_0x15_f15a:
            ii(0x15_f15a, 1); popw(si);                                 /* pop si */
            ii(0x15_f15b, 1); popw(di);                                 /* pop di */
            ii(0x15_f15c, 1); leavew();                                 /* leave */
            ii(0x15_f15d, 1); retw(); return;                           /* ret */
        }
    }
}