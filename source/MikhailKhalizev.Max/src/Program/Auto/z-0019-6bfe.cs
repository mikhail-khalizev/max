using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6bfe-20cab32")]
        public void Method_0019_6bfe()
        {
            ii(0x19_6bfe, 3); mov(ax, memw[ss, bp - 0x7a]);             /* mov ax, [bp-0x7a] */
            ii(0x19_6c01, 3); mov(memw[ss, bp - 0x70], ax);             /* mov [bp-0x70], ax */
            ii(0x19_6c04, 3); mov(ah, memb[ss, bp - 0x4]);              /* mov ah, [bp-0x4] */
            ii(0x19_6c07, 2); sub(al, al);                              /* sub al, al */
            ii(0x19_6c09, 3); mov(memw[ss, bp - 0x34], ax);             /* mov [bp-0x34], ax */
            ii(0x19_6c0c, 5); mov(memw[ss, bp - 0x32], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6c11, 3); push(memw[ss, bp - 0x6c]);                /* push word [bp-0x6c] */
            ii(0x19_6c14, 3); push(memw[ss, bp - 0x6e]);                /* push word [bp-0x6e] */
            ii(0x19_6c17, 3); push(memw[ss, bp - 0x7e]);                /* push word [bp-0x7e] */
            ii(0x19_6c1a, 1); nop();                                    /* nop */
            ii(0x19_6c1b, 1); push(cs);                                 /* push cs */
            ii(0x19_6c1c, 3); call(0x19_789c, 0xc7d);                   /* call 0x789c */
            ii(0x19_6c1f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6c22, 3); mov(memw[ss, bp - 0x74], ax);             /* mov [bp-0x74], ax */
            ii(0x19_6c25, 3); mov(memw[ss, bp - 0x58], ax);             /* mov [bp-0x58], ax */
            ii(0x19_6c28, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_6c2a, 3); mov(memw[ss, bp - 0x3a], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_6c2d, 3); mov(memw[ss, bp - 0x3c], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6c30, 3); mov(ax, memw[ds, 0x4898]);                /* mov ax, [0x4898] */
            ii(0x19_6c33, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_6c35, 3); cmp(dx, memw[ss, bp - 0x78]);             /* cmp dx, [bp-0x78] */
            ii(0x19_6c38, 2); if(jbe(0x19_6c3d, 0x3)) goto l_0x19_6c3d; /* jbe 0x6c3d */
            ii(0x19_6c3a, 3); jmp(0x19_6c71, 0x34); goto l_0x19_6c71;   /* jmp 0x6c71 */
        l_0x19_6c3d:
            ii(0x19_6c3d, 2); if(jae(0x19_6c42, 0x3)) goto l_0x19_6c42; /* jae 0x6c42 */
            ii(0x19_6c3f, 3); jmp(0x19_6c4a, 0x8); goto l_0x19_6c4a;    /* jmp 0x6c4a */
        l_0x19_6c42:
            ii(0x19_6c42, 3); cmp(ax, memw[ss, bp - 0x7a]);             /* cmp ax, [bp-0x7a] */
            ii(0x19_6c45, 2); if(jb(0x19_6c4a, 0x3)) goto l_0x19_6c4a;  /* jb 0x6c4a */
            ii(0x19_6c47, 3); jmp(0x19_6c71, 0x27); goto l_0x19_6c71;   /* jmp 0x6c71 */
        l_0x19_6c4a:
            ii(0x19_6c4a, 4); cmp(memw[ss, bp - 0x70], 0);              /* cmp word [bp-0x70], 0x0 */
            ii(0x19_6c4e, 2); if(jz(0x19_6c53, 0x3)) goto l_0x19_6c53;  /* jz 0x6c53 */
            ii(0x19_6c50, 3); jmp(0x19_6c58, 0x5); goto l_0x19_6c58;    /* jmp 0x6c58 */
        l_0x19_6c53:
            ii(0x19_6c53, 5); sub(memw[ss, bp - 0x70], 0x200);          /* sub word [bp-0x70], 0x200 */
        l_0x19_6c58:
            ii(0x19_6c58, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x19_6c5b, 3); mov(bx, memw[ss, bp - 0x74]);             /* mov bx, [bp-0x74] */
            ii(0x19_6c5e, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_6c60, 3); add(dx, memw[ss, bp - 0x7a]);             /* add dx, [bp-0x7a] */
            ii(0x19_6c63, 3); adc(cx, memw[ss, bp - 0x78]);             /* adc cx, [bp-0x78] */
            ii(0x19_6c66, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x19_6c69, 2); if(jb(0x19_6c71, 0x6)) goto l_0x19_6c71;  /* jb 0x6c71 */
            ii(0x19_6c6b, 3); mov(ax, memw[ds, 0x4898]);                /* mov ax, [0x4898] */
            ii(0x19_6c6e, 3); mov(memw[ss, bp - 0x70], ax);             /* mov [bp-0x70], ax */
        l_0x19_6c71:
            ii(0x19_6c71, 3); mov(ax, memw[ss, bp - 0x70]);             /* mov ax, [bp-0x70] */
            ii(0x19_6c74, 3); mov(memw[ss, bp - 0x38], ax);             /* mov [bp-0x38], ax */
            ii(0x19_6c77, 5); mov(memw[ss, bp - 0x36], 0);              /* mov word [bp-0x36], 0x0 */
            ii(0x19_6c7c, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x19_6c7f, 1); push(ss);                                 /* push ss */
            ii(0x19_6c80, 1); push(ax);                                 /* push ax */
            ii(0x19_6c81, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_6c84, 3); call(0x19_61c1, -0xac6);                  /* call 0x61c1 */
        }
    }
}
