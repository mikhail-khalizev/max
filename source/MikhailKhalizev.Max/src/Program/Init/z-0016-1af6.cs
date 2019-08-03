using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cc77acf-c0ad-40ad-9b9b-77a57ea6ce7e")]
        public void Method_0016_1af6()
        {
            ii(0x16_1af6, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x16_1afa, 1); pushw(di);                                /* push di */
            ii(0x16_1afb, 1); pushw(si);                                /* push si */
            ii(0x16_1afc, 5); callw_far_abs(0x80, 0x1878);              /* call word 0x80:0x1878 */
            ii(0x16_1b01, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x16_1b04, 4); cmp(memw_a16[ss, bp - 0xc], 0);           /* cmp word [bp-0xc], 0x0 */
            ii(0x16_1b08, 2); if(jzw(0x16_1b0d, 0x3)) goto l_0x16_1b0d; /* jz 0x1b0d */
            ii(0x16_1b0a, 3); jmpw(0x16_1b13, 0x6); goto l_0x16_1b13;   /* jmp 0x1b13 */
        l_0x16_1b0d:
            ii(0x16_1b0d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x16_1b10, 3); jmpw(0x16_1b43, 0x30); goto l_0x16_1b43;  /* jmp 0x1b43 */
        l_0x16_1b13:
            ii(0x16_1b13, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x16_1b18, 5); mov(memw_a16[ss, bp - 0x2], 0x90);        /* mov word [bp-0x2], 0x90 */
            ii(0x16_1b1d, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x16_1b20, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x16_1b23, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x16_1b28, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x16_1b2b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x16_1b2e, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x16_1b31, 1); pushw(ss);                                /* push ss */
            ii(0x16_1b32, 1); pushw(ax);                                /* push ax */
            ii(0x16_1b33, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x16_1b35, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x16_1b3a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x16_1b3d, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x16_1b40, 3); jmpw(0x16_1b43, 0); goto l_0x16_1b43;     /* jmp 0x1b43 */
        l_0x16_1b43:
            ii(0x16_1b43, 1); popw(si);                                 /* pop si */
            ii(0x16_1b44, 1); popw(di);                                 /* pop di */
            ii(0x16_1b45, 1); leavew();                                 /* leave */
            ii(0x16_1b46, 1); retfw(); return;                          /* retf */
        }
    }
}
