using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e949-2b11986f")]
        public void Method_0019_e949()
        {
            ii(0x19_e949, 4); enter(0xe, 0);                            /* enter 0xe, 0x0 */
            ii(0x19_e94d, 1); push(di);                                 /* push di */
            ii(0x19_e94e, 1); push(si);                                 /* push si */
            ii(0x19_e94f, 1); push(ds);                                 /* push ds */
            ii(0x19_e950, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_e953, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_e955, 4); mov(es, memw[ds, 0x3fd2]);                /* mov es, [0x3fd2] */
            ii(0x19_e959, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_e95d, 5); mov(memw[ss, bp - 12], 0);                /* mov word [bp-0xc], 0x0 */
            ii(0x19_e962, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x19_e965, 1); push(ds);                                 /* push ds */
            ii(0x19_e966, 3); push(0x2d76);                             /* push 0x2d76 */
            ii(0x19_e969, 1); push(ds);                                 /* push ds */
            ii(0x19_e96a, 3); push(0x2d65);                             /* push 0x2d65 */
            ii(0x19_e96d, 3); call(0x19_fcad, 0x133d);                  /* call 0xfcad */
            ii(0x19_e970, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_e973, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x19_e976, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_e978, 2); if(jnz(0x19_e97d, 3)) goto l_0x19_e97d;   /* jnz 0xe97d */
            ii(0x19_e97a, 3); jmp(0x19_e9ed, 0x70); goto l_0x19_e9ed;   /* jmp 0xe9ed */
        l_0x19_e97d:
            ii(0x19_e97d, 3); call_far_ind(memw[ss, bp - 8]);           /* call far word [bp-0x8] */
            ii(0x19_e980, 3); mov(memw[ss, bp - 14], ax);               /* mov [bp-0xe], ax */
            ii(0x19_e983, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_e986, 2); if(jnz(0x19_e98b, 3)) goto l_0x19_e98b;   /* jnz 0xe98b */
            ii(0x19_e988, 3); jmp(0x19_e9ed, 0x62); goto l_0x19_e9ed;   /* jmp 0xe9ed */
        l_0x19_e98b:
            ii(0x19_e98b, 3); mov(bx, memw[ss, bp - 14]);               /* mov bx, [bp-0xe] */
            ii(0x19_e98e, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_e991, 4); push(memw[ds, bx + 0x2d8c]);              /* push word [bx+0x2d8c] */
            ii(0x19_e995, 4); push(memw[ds, bx + 0x2d8a]);              /* push word [bx+0x2d8a] */
            ii(0x19_e999, 5); call_far_abs(0x80, 0x5ba0);               /* call word 0x80:0x5ba0 */
            ii(0x19_e99e, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_e9a1, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_e9a4, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_e9a7, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_e9a9, 2); if(jnz(0x19_e9ae, 3)) goto l_0x19_e9ae;   /* jnz 0xe9ae */
            ii(0x19_e9ab, 3); jmp(0x19_e9ed, 0x3f); goto l_0x19_e9ed;   /* jmp 0xe9ed */
        l_0x19_e9ae:
            ii(0x19_e9ae, 3); push(memw[ss, bp + 16]);                  /* push word [bp+0x10] */
            ii(0x19_e9b1, 3); push(memw[ss, bp + 14]);                  /* push word [bp+0xe] */
            ii(0x19_e9b4, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_e9b7, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_e9ba, 1); nop();                                    /* nop */
            ii(0x19_e9bb, 1); push(cs);                                 /* push cs */
            ii(0x19_e9bc, 3); call(0x19_e868, -0x157);                  /* call 0xe868 */
            ii(0x19_e9bf, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_e9c2, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_e9c5, 2); if(jz(0x19_e9ca, 3)) goto l_0x19_e9ca;    /* jz 0xe9ca */
            ii(0x19_e9c7, 3); jmp(0x19_e9ed, 0x23); goto l_0x19_e9ed;   /* jmp 0xe9ed */
        l_0x19_e9ca:
            ii(0x19_e9ca, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_e9cd, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_e9d0, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_e9d3, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_e9d6, 3); les(bx, memw[ss, bp + 14]);               /* les bx, [bp+0xe] */
            ii(0x19_e9d9, 4); call_far_ind(memw[es, bx + 28]);          /* call far word [es:bx+0x1c] */
            ii(0x19_e9dd, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_e9e0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_e9e2, 2); if(jnz(0x19_e9e7, 3)) goto l_0x19_e9e7;   /* jnz 0xe9e7 */
            ii(0x19_e9e4, 3); jmp(0x19_e9ed, 6); goto l_0x19_e9ed;      /* jmp 0xe9ed */
        l_0x19_e9e7:
            ii(0x19_e9e7, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_e9ea, 3); jmp(0x19_ea61, 0x74); goto l_0x19_ea61;   /* jmp 0xea61 */
        l_0x19_e9ed:
            ii(0x19_e9ed, 3); les(bx, memw[ss, bp - 12]);               /* les bx, [bp-0xc] */
            ii(0x19_e9f0, 4); mov(ax, memw[es, bx + 66]);               /* mov ax, [es:bx+0x42] */
            ii(0x19_e9f4, 4); mov(dx, memw[es, bx + 68]);               /* mov dx, [es:bx+0x44] */
            ii(0x19_e9f8, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_e9fb, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
        l_0x19_e9fe:
            ii(0x19_e9fe, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_ea01, 3); or(ax, memw[ss, bp - 4]);                 /* or ax, [bp-0x4] */
            ii(0x19_ea04, 2); if(jnz(0x19_ea09, 3)) goto l_0x19_ea09;   /* jnz 0xea09 */
            ii(0x19_ea06, 3); jmp(0x19_ea5b, 0x52); goto l_0x19_ea5b;   /* jmp 0xea5b */
        l_0x19_ea09:
            ii(0x19_ea09, 3); push(memw[ss, bp + 16]);                  /* push word [bp+0x10] */
            ii(0x19_ea0c, 3); push(memw[ss, bp + 14]);                  /* push word [bp+0xe] */
            ii(0x19_ea0f, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_ea12, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_ea15, 1); nop();                                    /* nop */
            ii(0x19_ea16, 1); push(cs);                                 /* push cs */
            ii(0x19_ea17, 3); call(0x19_e868, -0x1b2);                  /* call 0xe868 */
            ii(0x19_ea1a, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_ea1d, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_ea20, 2); if(jz(0x19_ea25, 3)) goto l_0x19_ea25;    /* jz 0xea25 */
            ii(0x19_ea22, 3); jmp(0x19_ea48, 0x23); goto l_0x19_ea48;   /* jmp 0xea48 */
        l_0x19_ea25:
            ii(0x19_ea25, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_ea28, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_ea2b, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_ea2e, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_ea31, 3); les(bx, memw[ss, bp + 14]);               /* les bx, [bp+0xe] */
            ii(0x19_ea34, 4); call_far_ind(memw[es, bx + 28]);          /* call far word [es:bx+0x1c] */
            ii(0x19_ea38, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_ea3b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_ea3d, 2); if(jnz(0x19_ea42, 3)) goto l_0x19_ea42;   /* jnz 0xea42 */
            ii(0x19_ea3f, 3); jmp(0x19_ea48, 6); goto l_0x19_ea48;      /* jmp 0xea48 */
        l_0x19_ea42:
            ii(0x19_ea42, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_ea45, 3); jmp(0x19_ea61, 0x19); goto l_0x19_ea61;   /* jmp 0xea61 */
        l_0x19_ea48:
            ii(0x19_ea48, 3); les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0x19_ea4b, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_ea4e, 4); mov(dx, memw[es, bx + 2]);                /* mov dx, [es:bx+0x2] */
            ii(0x19_ea52, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_ea55, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_ea58, 3); jmp(0x19_e9fe, -0x5d); goto l_0x19_e9fe;  /* jmp 0xe9fe */
        l_0x19_ea5b:
            ii(0x19_ea5b, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_ea5e, 3); jmp(0x19_ea61, 0); goto l_0x19_ea61;      /* jmp 0xea61 */
        l_0x19_ea61:
            ii(0x19_ea61, 1); pop(ds);                                  /* pop ds */
            ii(0x19_ea62, 1); pop(si);                                  /* pop si */
            ii(0x19_ea63, 1); pop(di);                                  /* pop di */
            ii(0x19_ea64, 1); leave();                                  /* leave */
            ii(0x19_ea65, 1); retf();                                   /* retf */
        }
    }
}
