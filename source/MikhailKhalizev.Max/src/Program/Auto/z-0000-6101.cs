using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2f1fce1f-1bcd-4bcd-952b-470e7d93d5e1")]
        public void Method_0000_6101()
        {
            ii(0x6101, 1);    pushw(cx);                                /* push cx */
            ii(0x6102, 4);    and(dx, 0xf000);                          /* and dx, 0xf000 */
            ii(0x6106, 4);    mov(cx, memw_a16[ds, 0xdee]);             /* mov cx, [0xdee] */
            ii(0x610a, 1);    dec(cx);                                  /* dec cx */
            ii(0x610b, 2);    if(jnzw(0x6132, 0x25)) goto l_0x6132;     /* jnz 0x6132 */
            ii(0x610d, 3);    mov(ax, 0xde05);                          /* mov ax, 0xde05 */
        l_0x6110:
            ii(0x6110, 5);    calld_a16_far_ind(ds, 0xd5a);             /* call far dword [0xd5a] */
            ii(0x6115, 3);    mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
        l_0x6118:
            ii(0x6118, 4);    and(memw_a32[es, edi], ax);               /* and [es:edi], ax */
            ii(0x611c, 4);    inc(memw_a16[ds, 0xdf8]);                 /* inc word [0xdf8] */
            ii(0x6120, 9);    sub(memd_a16[ds, 0xaa8], 0x1000);         /* sub dword [0xaa8], 0x1000 */
            ii(0x6129, 4);    add(edi, 0x4);                            /* add edi, 0x4 */
            ii(0x612d, 1);    dec(cx);                                  /* dec cx */
            ii(0x612e, 2);    if(jnsw(0x6118, -0x18)) goto l_0x6118;    /* jns 0x6118 */
            ii(0x6130, 1);    popw(cx);                                 /* pop cx */
            ii(0x6131, 1);    retw(); return;                           /* ret */
        l_0x6132:
            ii(0x6132, 3);    mov(ax, 0xdf01);                          /* mov ax, 0xdf01 */
            ii(0x6135, 2);    jmpw(0x6110, -0x27); goto l_0x6110;       /* jmp 0x6110 */
        }
    }
}
