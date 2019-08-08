using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e1a83783-6e4e-427a-836f-d3bd26224d59")]
        public void Method_0000_b21b()
        {
            ii(0xb21b, 5);    mov(memw_a16[cs, 0x79f6], cx);            /* mov [cs:0x79f6], cx */
            ii(0xb220, 4);    mov(es, memw_a16[ds, 0xaa]);              /* mov es, [0xaa] */
            ii(0xb224, 3);    mov(di, 0x4);                             /* mov di, 0x4 */
            ii(0xb227, 5);    mov(eax, memd_a16[es, di - 0x4]);         /* mov eax, [es:di-0x4] */
            ii(0xb22c, 5);    mov(memd_a16[cs, 0x79f8], eax);           /* mov [cs:0x79f8], eax */
            ii(0xb231, 5);    cmp(memb_a16[ds, 0xe00], 0);              /* cmp byte [0xe00], 0x0 */
            ii(0xb236, 2);    if(jzw_func(0xb251, 0x19)) return;        /* jz 0xb251 */
        l_0xb238:
            ii(0xb238, 3);    mov(ax, 0xde04);                          /* mov ax, 0xde04 */
            ii(0xb23b, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xb23d, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xb23f, 4);    if(jnzw_func(0xae96, -0x3ad)) return;     /* jnz 0xae96 */
            ii(0xb243, 4);    inc(memw_a16[ds, 0xdf6]);                 /* inc word [0xdf6] */
            ii(0xb247, 4);    or(dx, 0x807);                            /* or dx, 0x807 */
            ii(0xb24b, 2);    xchg(edx, eax);                           /* xchg edx, eax */
            ii(0xb24d, 2);    stosd_a16();                              /* stosd */
            ii(0xb24f, 2);    if(loopw_a16(0xb238, -0x19)) goto l_0xb238; /* loop 0xb238 */
        }
    }
}
