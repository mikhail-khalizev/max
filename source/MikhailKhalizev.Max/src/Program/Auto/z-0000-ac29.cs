using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xac29-aad4f5ff")]
        public void Method_0000_ac29()
        {
            ii(0xac29, 2);  mov(cx, es);                               /* mov cx, es */
            ii(0xac2b, 2);  if(jcxz(0xac5f, 0x32)) goto l_0xac5f;      /* jcxz 0xac5f */
            ii(0xac2d, 3);  mov(ax, 0x205);                            /* mov ax, 0x205 */
            ii(0xac30, 2);  xor(bx, bx);                               /* xor bx, bx */
        l_0xac32:
            ii(0xac32, 4);  mov(edx, memd[es, di]);                    /* mov edx, [es:di] */
            ii(0xac36, 4);  mov(cx, memw[es, di + 4]);                 /* mov cx, [es:di+0x4] */
            ii(0xac3a, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xac3c, 3);  add(di, 6);                                /* add di, 0x6 */
            ii(0xac3f, 1);  inc(bx);                                   /* inc bx */
            ii(0xac40, 4);  cmp(bx, 0xff);                             /* cmp bx, 0xff */
            ii(0xac44, 2);  if(jbe(0xac32, -0x14)) goto l_0xac32;      /* jbe 0xac32 */
            ii(0xac46, 3);  mov(ax, 0x203);                            /* mov ax, 0x203 */
            ii(0xac49, 2);  xor(bl, bl);                               /* xor bl, bl */
        l_0xac4b:
            ii(0xac4b, 4);  mov(edx, memd[es, di]);                    /* mov edx, [es:di] */
            ii(0xac4f, 4);  mov(cx, memw[es, di + 4]);                 /* mov cx, [es:di+0x4] */
            ii(0xac53, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xac55, 3);  add(di, 6);                                /* add di, 0x6 */
            ii(0xac58, 2);  inc(bl);                                   /* inc bl */
            ii(0xac5a, 3);  cmp(bl, 0x1f);                             /* cmp bl, 0x1f */
            ii(0xac5d, 2);  if(jbe(0xac4b, -0x14)) goto l_0xac4b;      /* jbe 0xac4b */
        l_0xac5f:
            ii(0xac5f, 1);  retf();                                    /* retf */
        }
    }
}
