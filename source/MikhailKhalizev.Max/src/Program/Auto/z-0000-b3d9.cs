using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb3d9-aad4f5ff")]
        public void Method_0000_b3d9()
        {
            ii(0xb3d9, 2);    mov(cx, es);                              /* mov cx, es */
            ii(0xb3db, 2);    if(jcxz(0xb40f, 0x32)) goto l_0xb40f;     /* jcxz 0xb40f */
            ii(0xb3dd, 3);    mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0xb3e0, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0xb3e2:
            ii(0xb3e2, 4);    mov(edx, memd[es, di]);                   /* mov edx, [es:di] */
            ii(0xb3e6, 4);    mov(cx, memw[es, di + 0x4]);              /* mov cx, [es:di+0x4] */
            ii(0xb3ea, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb3ec, 3);    add(di, 0x6);                             /* add di, 0x6 */
            ii(0xb3ef, 1);    inc(bx);                                  /* inc bx */
            ii(0xb3f0, 4);    cmp(bx, 0xff);                            /* cmp bx, 0xff */
            ii(0xb3f4, 2);    if(jbe(0xb3e2, -0x14)) goto l_0xb3e2;     /* jbe 0xb3e2 */
            ii(0xb3f6, 3);    mov(ax, 0x203);                           /* mov ax, 0x203 */
            ii(0xb3f9, 2);    xor(bl, bl);                              /* xor bl, bl */
        l_0xb3fb:
            ii(0xb3fb, 4);    mov(edx, memd[es, di]);                   /* mov edx, [es:di] */
            ii(0xb3ff, 4);    mov(cx, memw[es, di + 0x4]);              /* mov cx, [es:di+0x4] */
            ii(0xb403, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb405, 3);    add(di, 0x6);                             /* add di, 0x6 */
            ii(0xb408, 2);    inc(bl);                                  /* inc bl */
            ii(0xb40a, 3);    cmp(bl, 0x1f);                            /* cmp bl, 0x1f */
            ii(0xb40d, 2);    if(jbe(0xb3fb, -0x14)) goto l_0xb3fb;     /* jbe 0xb3fb */
        l_0xb40f:
            ii(0xb40f, 1);    retf();                                   /* retf */
        }
    }
}
