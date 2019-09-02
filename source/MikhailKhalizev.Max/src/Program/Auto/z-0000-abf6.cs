using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xabf6-89226663")]
        public void Method_0000_abf6()
        {
            ii(0xabf6, 3);    mov(ax, 0x204);                           /* mov ax, 0x204 */
            ii(0xabf9, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0xabfb:
            ii(0xabfb, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xabfd, 4);    mov(memd[es, di], edx);                   /* mov [es:di], edx */
            ii(0xac01, 4);    mov(memw[es, di + 4], cx);                /* mov [es:di+0x4], cx */
            ii(0xac05, 3);    add(di, 6);                               /* add di, 0x6 */
            ii(0xac08, 1);    inc(bx);                                  /* inc bx */
            ii(0xac09, 4);    cmp(bx, 0xff);                            /* cmp bx, 0xff */
            ii(0xac0d, 2);    if(jbe(0xabfb, -0x14)) goto l_0xabfb;     /* jbe 0xabfb */
            ii(0xac0f, 3);    mov(ax, 0x202);                           /* mov ax, 0x202 */
            ii(0xac12, 2);    xor(bl, bl);                              /* xor bl, bl */
        l_0xac14:
            ii(0xac14, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac16, 4);    mov(memd[es, di], edx);                   /* mov [es:di], edx */
            ii(0xac1a, 4);    mov(memw[es, di + 4], cx);                /* mov [es:di+0x4], cx */
            ii(0xac1e, 3);    add(di, 6);                               /* add di, 0x6 */
            ii(0xac21, 2);    inc(bl);                                  /* inc bl */
            ii(0xac23, 3);    cmp(bl, 0x1f);                            /* cmp bl, 0x1f */
            ii(0xac26, 2);    if(jbe(0xac14, -0x14)) goto l_0xac14;     /* jbe 0xac14 */
            ii(0xac28, 1);    retf();                                   /* retf */
        }
    }
}
