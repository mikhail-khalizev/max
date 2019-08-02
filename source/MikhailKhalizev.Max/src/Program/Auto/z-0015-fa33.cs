using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e2cb0540-0244-4178-b01d-2e2107967507")]
        public void Method_0015_fa33()
        {
            ii(0x15_fa33, 1); pushw(ds);                                /* push ds */
            ii(0x15_fa34, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fa37, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fa39, 5); cmp(memw_a16[ds, 0x3182], -0x1 /* 0xff */); /* cmp word [0x3182], 0xffff */
            ii(0x15_fa3e, 2); if(jnzw(0x15_fa66, 0x26)) goto l_0x15_fa66; /* jnz 0xfa66 */
            ii(0x15_fa40, 1); pushw(ds);                                /* push ds */
            ii(0x15_fa41, 3); pushw(0x317c);                            /* push 0x317c */
            ii(0x15_fa44, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x15_fa49, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fa4a, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fa4b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_fa4d, 2); if(jnzw(0x15_fa58, 0x9)) goto l_0x15_fa58; /* jnz 0xfa58 */
            ii(0x15_fa4f, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x15_fa54, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fa56, 2); if(jzw(0x15_fa60, 0x8)) goto l_0x15_fa60; /* jz 0xfa60 */
        l_0x15_fa58:
            ii(0x15_fa58, 6); mov(memw_a16[ds, 0x3182], 0x1);           /* mov word [0x3182], 0x1 */
            ii(0x15_fa5e, 2); jmpw(0x15_fa66, 0x6); goto l_0x15_fa66;   /* jmp 0xfa66 */
        l_0x15_fa60:
            ii(0x15_fa60, 6); mov(memw_a16[ds, 0x3182], 0);             /* mov word [0x3182], 0x0 */
        l_0x15_fa66:
            ii(0x15_fa66, 3); mov(ax, memw_a16[ds, 0x3182]);            /* mov ax, [0x3182] */
            ii(0x15_fa69, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fa6a, 1); retw(); return;                           /* ret */
        }
    }
}