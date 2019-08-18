using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb3a6-89226663")]
        public void Method_0000_b3a6()
        {
            ii(0xb3a6, 3);    mov(ax, 0x204);                           /* mov ax, 0x204 */
            ii(0xb3a9, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0xb3ab:
            ii(0xb3ab, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb3ad, 4);    mov(memd_a16[es, di], edx);               /* mov [es:di], edx */
            ii(0xb3b1, 4);    mov(memw_a16[es, di + 0x4], cx);          /* mov [es:di+0x4], cx */
            ii(0xb3b5, 3);    add(di, 0x6);                             /* add di, 0x6 */
            ii(0xb3b8, 1);    inc(bx);                                  /* inc bx */
            ii(0xb3b9, 4);    cmp(bx, 0xff);                            /* cmp bx, 0xff */
            ii(0xb3bd, 2);    if(jbew(0xb3ab, -0x14)) goto l_0xb3ab;    /* jbe 0xb3ab */
            ii(0xb3bf, 3);    mov(ax, 0x202);                           /* mov ax, 0x202 */
            ii(0xb3c2, 2);    xor(bl, bl);                              /* xor bl, bl */
        l_0xb3c4:
            ii(0xb3c4, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb3c6, 4);    mov(memd_a16[es, di], edx);               /* mov [es:di], edx */
            ii(0xb3ca, 4);    mov(memw_a16[es, di + 0x4], cx);          /* mov [es:di+0x4], cx */
            ii(0xb3ce, 3);    add(di, 0x6);                             /* add di, 0x6 */
            ii(0xb3d1, 2);    inc(bl);                                  /* inc bl */
            ii(0xb3d3, 3);    cmp(bl, 0x1f);                            /* cmp bl, 0x1f */
            ii(0xb3d6, 2);    if(jbew(0xb3c4, -0x14)) goto l_0xb3c4;    /* jbe 0xb3c4 */
            ii(0xb3d8, 1);    retfw(); return;                          /* retf */
        }
    }
}
