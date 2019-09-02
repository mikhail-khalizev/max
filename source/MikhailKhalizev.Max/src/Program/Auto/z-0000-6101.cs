using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6101-93a09bd")]
        public void Method_0000_6101()
        {
            ii(0x6101, 1);    push(cx);                                 /* push cx */
            ii(0x6102, 4);    and(dx, 0xf000);                          /* and dx, 0xf000 */
            ii(0x6106, 4);    mov(cx, memw[ds, 0xdee]);                 /* mov cx, [0xdee] */
            ii(0x610a, 1);    dec(cx);                                  /* dec cx */
            ii(0x610b, 2);    if(jnz(0x6132, 0x25)) goto l_0x6132;      /* jnz 0x6132 */
            ii(0x610d, 3);    mov(ax, 0xde05);                          /* mov ax, 0xde05 */
        l_0x6110:
            ii(0x6110, 5);    calld_far_ind(memd[ds, 0xd5a]);           /* call far dword [0xd5a] */
            ii(0x6115, 3);    mov(ax, memw[ss, bp + 14]);               /* mov ax, [bp+0xe] */
        l_0x6118:
            ii(0x6118, 4);    and(memw_a32[es, edi], ax);               /* and [es:edi], ax */
            ii(0x611c, 4);    inc(memw[ds, 0xdf8]);                     /* inc word [0xdf8] */
            ii(0x6120, 9);    sub(memd[ds, 0xaa8], 0x1000);             /* sub dword [0xaa8], 0x1000 */
            ii(0x6129, 4);    add(edi, 4);                              /* add edi, 0x4 */
            ii(0x612d, 1);    dec(cx);                                  /* dec cx */
            ii(0x612e, 2);    if(jns(0x6118, -0x18)) goto l_0x6118;     /* jns 0x6118 */
            ii(0x6130, 1);    pop(cx);                                  /* pop cx */
            ii(0x6131, 1);    ret(); return;                            /* ret */
        l_0x6132:
            ii(0x6132, 3);    mov(ax, 0xdf01);                          /* mov ax, 0xdf01 */
            ii(0x6135, 2);    jmp(0x6110, -0x27); goto l_0x6110;        /* jmp 0x6110 */
        }
    }
}
