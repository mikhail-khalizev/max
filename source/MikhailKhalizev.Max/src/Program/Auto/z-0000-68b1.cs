using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2886f141-e32f-49be-94b2-8c20803320fb")]
        public void Method_0000_68b1()
        {
            ii(0x68b1, 1);    pushw(cx);                                /* push cx */
            ii(0x68b2, 4);    and(dx, 0xf000);                          /* and dx, 0xf000 */
            ii(0x68b6, 4);    mov(cx, memw_a16[ds, 0xdee]);             /* mov cx, [0xdee] */
            ii(0x68ba, 1);    dec(cx);                                  /* dec cx */
            ii(0x68bb, 2);    if(jnzw(0x68e2, 0x25)) goto l_0x68e2;     /* jnz 0x68e2 */
            ii(0x68bd, 3);    mov(ax, 0xde05);                          /* mov ax, 0xde05 */
        l_0x68c0:
            ii(0x68c0, 5);    calld_a16_far_ind(ds, 0xd5a);             /* call far dword [0xd5a] */
            ii(0x68c5, 3);    mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
        l_0x68c8:
            ii(0x68c8, 4);    and(memw_a32[es, edi], ax);               /* and [es:edi], ax */
            ii(0x68cc, 4);    inc(memw_a16[ds, 0xdf8]);                 /* inc word [0xdf8] */
            ii(0x68d0, 9);    sub(memd_a16[ds, 0xaa8], 0x1000);         /* sub dword [0xaa8], 0x1000 */
            ii(0x68d9, 4);    add(edi, 0x4);                            /* add edi, 0x4 */
            ii(0x68dd, 1);    dec(cx);                                  /* dec cx */
            ii(0x68de, 2);    if(jnsw(0x68c8, -0x18)) goto l_0x68c8;    /* jns 0x68c8 */
            ii(0x68e0, 1);    popw(cx);                                 /* pop cx */
            ii(0x68e1, 1);    retw(); return;                           /* ret */
        l_0x68e2:
            ii(0x68e2, 3);    mov(ax, 0xdf01);                          /* mov ax, 0xdf01 */
            ii(0x68e5, 2);    jmpw(0x68c0, -0x27); goto l_0x68c0;       /* jmp 0x68c0 */
        }
    }
}
