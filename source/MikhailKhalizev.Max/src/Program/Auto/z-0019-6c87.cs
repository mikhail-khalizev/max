using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6c87-44cfd934")]
        public void Method_0019_6c87()
        {
            ii(0x19_6c87, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6c8a, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x19_6c8e, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x19_6c92, 2); if(jnzw(0x19_6c97, 0x3)) goto l_0x19_6c97; /* jnz 0x6c97 */
            ii(0x19_6c94, 3); jmpw(0x19_6c9a, 0x3); goto l_0x19_6c9a;   /* jmp 0x6c9a */
        l_0x19_6c97:
            ii(0x19_6c97, 3); jmpw(0x19_6cc7, 0x2d); goto l_0x19_6cc7;  /* jmp 0x6cc7 */
        l_0x19_6c9a:
            ii(0x19_6c9a, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x19_6c9d, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_6c9f, 3); add(memw_a16[ss, bp - 0x6e], ax);         /* add [bp-0x6e], ax */
            ii(0x19_6ca2, 3); adc(memw_a16[ss, bp - 0x6c], dx);         /* adc [bp-0x6c], dx */
            ii(0x19_6ca5, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x19_6ca8, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_6caa, 3); sub(memw_a16[ss, bp - 0x7a], ax);         /* sub [bp-0x7a], ax */
            ii(0x19_6cad, 3); sbb(memw_a16[ss, bp - 0x78], dx);         /* sbb [bp-0x78], dx */
            ii(0x19_6cb0, 3); mov(ax, memw_a16[ss, bp - 0x34]);         /* mov ax, [bp-0x34] */
            ii(0x19_6cb3, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_6cb5, 4); add(memw_a16[ss, bp - 0x82], ax);         /* add [bp-0x82], ax */
            ii(0x19_6cb9, 3); adc(memw_a16[ss, bp - 0x80], dx);         /* adc [bp-0x80], dx */
            ii(0x19_6cbc, 3); mov(ax, memw_a16[ss, bp - 0x78]);         /* mov ax, [bp-0x78] */
            ii(0x19_6cbf, 3); or(ax, memw_a16[ss, bp - 0x7a]);          /* or ax, [bp-0x7a] */
            ii(0x19_6cc2, 2); if(jzw(0x19_6cc7, 0x3)) goto l_0x19_6cc7; /* jz 0x6cc7 */
            ii(0x19_6cc4, 3); if(jmpw_func(0x19_6bfe, -0xc9)) return;   /* jmp 0x6bfe */
        l_0x19_6cc7:
            ii(0x19_6cc7, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x19_6cca, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x19_6ccd, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x19_6cd1, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x19_6cd5, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x19_6cd8, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x19_6cdb, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x19_6cde, 3); mov(dx, memw_a16[ss, bp - 0x64]);         /* mov dx, [bp-0x64] */
            ii(0x19_6ce1, 3); mov(memw_a16[ss, bp - 0x38], ax);         /* mov [bp-0x38], ax */
            ii(0x19_6ce4, 3); mov(memw_a16[ss, bp - 0x36], dx);         /* mov [bp-0x36], dx */
            ii(0x19_6ce7, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x19_6ceb, 2); if(jnzw(0x19_6cf0, 0x3)) goto l_0x19_6cf0; /* jnz 0x6cf0 */
            ii(0x19_6ced, 3); jmpw(0x19_6cf3, 0x3); goto l_0x19_6cf3;   /* jmp 0x6cf3 */
        l_0x19_6cf0:
            ii(0x19_6cf0, 3); if(jmpw_func(0x19_7817, 0xb24)) return;   /* jmp 0x7817 */
        l_0x19_6cf3:
            ii(0x19_6cf3, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x19_6cf7, 3); mov(dx, memw_a16[ss, bp - 0x80]);         /* mov dx, [bp-0x80] */
            ii(0x19_6cfa, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x19_6cfd, 3); mov(memw_a16[ss, bp - 0x32], dx);         /* mov [bp-0x32], dx */
            ii(0x19_6d00, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x19_6d05, 3); if(jmpw_func(0x19_7817, 0xb0f)) return;   /* jmp 0x7817 */
        }
    }
}
