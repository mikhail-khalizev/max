using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f673932e-4b08-459a-94be-33ca9df9933f")]
        public void Method_0015_ec09()
        {
            ii(0x15_ec09, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x15_ec0d, 1); pushw(di);                                /* push di */
            ii(0x15_ec0e, 1); pushw(si);                                /* push si */
            ii(0x15_ec0f, 5); callw_far_abs(0x80, 0x5740);              /* call word 0x80:0x5740 */
            ii(0x15_ec14, 3); mov(memw_a16[ds, 0x2e08], ax);            /* mov [0x2e08], ax */
            ii(0x15_ec17, 5); cmp(memw_a16[ds, 0x2e08], 0);             /* cmp word [0x2e08], 0x0 */
            ii(0x15_ec1c, 2); if(jzw(0x15_ec21, 0x3)) goto l_0x15_ec21; /* jz 0xec21 */
            ii(0x15_ec1e, 3); jmpw(0x15_ec27, 0x6); goto l_0x15_ec27;   /* jmp 0xec27 */
        l_0x15_ec21:
            ii(0x15_ec21, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ec24, 3); jmpw(0x15_ec7c, 0x55); goto l_0x15_ec7c;  /* jmp 0xec7c */
        l_0x15_ec27:
            ii(0x15_ec27, 5); mov(memw_a16[ss, bp - 0x4], 0x53);        /* mov word [bp-0x4], 0x53 */
            ii(0x15_ec2c, 5); mov(memw_a16[ss, bp - 0x2], 0x98);        /* mov word [bp-0x2], 0x98 */
            ii(0x15_ec31, 3); lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x15_ec34, 1); pushw(ss);                                /* push ss */
            ii(0x15_ec35, 1); pushw(ax);                                /* push ax */
            ii(0x15_ec36, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_ec39, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x15_ec3e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ec41, 4); or(memb_a16[ss, bp - 0x6], 0x40);         /* or byte [bp-0x6], 0x40 */
            ii(0x15_ec45, 3); mov(al, memb_a16[ss, bp - 0x7]);          /* mov al, [bp-0x7] */
            ii(0x15_ec48, 2); and(al, 0xfa);                            /* and al, 0xfa */
            ii(0x15_ec4a, 2); or(al, 0x9a);                             /* or al, 0x9a */
            ii(0x15_ec4c, 3); mov(memb_a16[ss, bp - 0x7], al);          /* mov [bp-0x7], al */
            ii(0x15_ec4f, 3); lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x15_ec52, 1); pushw(ss);                                /* push ss */
            ii(0x15_ec53, 1); pushw(ax);                                /* push ax */
            ii(0x15_ec54, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_ec57, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x15_ec5c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ec5f, 5); callw_far_abs(0x98, 0xfc);                /* call word 0x98:0xfc */
            ii(0x15_ec64, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_ec67, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_ec6a, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_ec6d, 3); mov(memw_a16[ds, 0x2e04], ax);            /* mov [0x2e04], ax */
            ii(0x15_ec70, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_ec73, 3); mov(memw_a16[ds, 0x2e06], ax);            /* mov [0x2e06], ax */
            ii(0x15_ec76, 3); mov(ax, memw_a16[ds, 0x2e04]);            /* mov ax, [0x2e04] */
            ii(0x15_ec79, 3); jmpw(0x15_ec7c, 0); goto l_0x15_ec7c;     /* jmp 0xec7c */
        l_0x15_ec7c:
            ii(0x15_ec7c, 1); popw(si);                                 /* pop si */
            ii(0x15_ec7d, 1); popw(di);                                 /* pop di */
            ii(0x15_ec7e, 1); leavew();                                 /* leave */
            ii(0x15_ec7f, 1); retfw(); return;                          /* retf */
        }
    }
}
