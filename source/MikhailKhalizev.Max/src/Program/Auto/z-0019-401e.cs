using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a3811a4-97e6-462f-9bf6-06a5ee46a025")]
        public void Method_0019_401e()
        {
            ii(0x19_401e, 4); mov(ax, memw_a16[es, di + 0x2]);          /* mov ax, [es:di+0x2] */
            ii(0x19_4022, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4024, 2); if(jnzw(0x19_402f, 0x9)) goto l_0x19_402f; /* jnz 0x402f */
            ii(0x19_4026, 4); mov(memw_a16[es, di + 0x2], ds);          /* mov [es:di+0x2], ds */
            ii(0x19_402a, 3); mov(memw_a16[es, di], bx);                /* mov [es:di], bx */
            ii(0x19_402d, 2); jmpw(0x19_4043, 0x14); goto l_0x19_4043;  /* jmp 0x4043 */
        l_0x19_402f:
            ii(0x19_402f, 1); pushw(es);                                /* push es */
            ii(0x19_4030, 4); les(si, es, di + 0x8);                    /* les si, [es:di+0x8] */
            ii(0x19_4034, 4); mov(memw_a16[es, si + 0xe], ds);          /* mov [es:si+0xe], ds */
            ii(0x19_4038, 4); mov(memw_a16[es, si + 0xc], bx);          /* mov [es:si+0xc], bx */
            ii(0x19_403c, 3); mov(memw_a16[ds, bx + 0x12], es);         /* mov [bx+0x12], es */
            ii(0x19_403f, 3); mov(memw_a16[ds, bx + 0x10], si);         /* mov [bx+0x10], si */
            ii(0x19_4042, 1); popw(es);                                 /* pop es */
        l_0x19_4043:
            ii(0x19_4043, 4); mov(memw_a16[es, di + 0xa], ds);          /* mov [es:di+0xa], ds */
            ii(0x19_4047, 4); mov(memw_a16[es, di + 0x8], bx);          /* mov [es:di+0x8], bx */
            ii(0x19_404b, 4); mov(memw_a16[es, di + 0x6], ds);          /* mov [es:di+0x6], ds */
            ii(0x19_404f, 4); mov(memw_a16[es, di + 0x4], bx);          /* mov [es:di+0x4], bx */
            ii(0x19_4053, 1); retw(); return;                           /* ret */
        }
    }
}
