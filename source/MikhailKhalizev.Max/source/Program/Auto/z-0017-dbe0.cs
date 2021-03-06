using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dbe0-2027082c")]
        public void Method_0017_dbe0()
        {
            ii(0x17_dbe0, 1);  push(bp);                               /* push bp */
            ii(0x17_dbe1, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_dbe3, 3);  sub(sp, 2);                             /* sub sp, 0x2 */
            ii(0x17_dbe6, 1);  push(si);                               /* push si */
            ii(0x17_dbe7, 1);  push(di);                               /* push di */
            ii(0x17_dbe8, 1);  push(ds);                               /* push ds */
            ii(0x17_dbe9, 1);  pop(es);                                /* pop es */
            ii(0x17_dbea, 3);  mov(di, memw[ss, bp + 8]);              /* mov di, [bp+0x8] */
            ii(0x17_dbed, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x17_dbef, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x17_dbf2, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x17_dbf4, 2);  not(cx);                                /* not cx */
            ii(0x17_dbf6, 1);  dec(cx);                                /* dec cx */
            ii(0x17_dbf7, 2);  if(jcxz(0x17_dc33, 0x3a)) goto l_0x17_dc33;/* jcxz 0xdc33 */
            ii(0x17_dbf9, 1);  dec(cx);                                /* dec cx */
            ii(0x17_dbfa, 3);  mov(memw[ss, bp - 2], cx);              /* mov [bp-0x2], cx */
            ii(0x17_dbfd, 3);  mov(di, memw[ss, bp + 6]);              /* mov di, [bp+0x6] */
            ii(0x17_dc00, 2);  mov(bx, di);                            /* mov bx, di */
            ii(0x17_dc02, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x17_dc04, 3);  mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x17_dc07, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x17_dc09, 2);  not(cx);                                /* not cx */
            ii(0x17_dc0b, 1);  dec(cx);                                /* dec cx */
            ii(0x17_dc0c, 2);  mov(dx, cx);                            /* mov dx, cx */
            ii(0x17_dc0e, 3);  sub(dx, memw[ss, bp - 2]);              /* sub dx, [bp-0x2] */
            ii(0x17_dc11, 2);  if(jbe(0x17_dc38, 0x25)) goto l_0x17_dc38;/* jbe 0xdc38 */
            ii(0x17_dc13, 2);  mov(di, bx);                            /* mov di, bx */
        l_0x17_dc15:
            ii(0x17_dc15, 3);  mov(si, memw[ss, bp + 8]);              /* mov si, [bp+0x8] */
            ii(0x17_dc18, 1);  lodsb();                                /* lodsb */
            ii(0x17_dc19, 2);  mov(di, bx);                            /* mov di, bx */
            ii(0x17_dc1b, 2);  mov(cx, dx);                            /* mov cx, dx */
            ii(0x17_dc1d, 2);  repne(() => scasb());                   /* repne scasb */
            ii(0x17_dc1f, 2);  if(jnz(0x17_dc38, 0x17)) goto l_0x17_dc38;/* jnz 0xdc38 */
            ii(0x17_dc21, 2);  mov(dx, cx);                            /* mov dx, cx */
            ii(0x17_dc23, 2);  mov(bx, di);                            /* mov bx, di */
            ii(0x17_dc25, 3);  mov(cx, memw[ss, bp - 2]);              /* mov cx, [bp-0x2] */
            ii(0x17_dc28, 2);  if(jcxz(0x17_dc2e, 4)) goto l_0x17_dc2e;/* jcxz 0xdc2e */
            ii(0x17_dc2a, 2);  repe(() => cmpsb());                    /* repe cmpsb */
            ii(0x17_dc2c, 2);  if(jnz(0x17_dc15, -0x19)) goto l_0x17_dc15;/* jnz 0xdc15 */
        l_0x17_dc2e:
            ii(0x17_dc2e, 3);  lea(ax, memw[ds, bx - 1]);              /* lea ax, [bx-0x1] */
            ii(0x17_dc31, 2);  jmp(0x17_dc3a, 7); goto l_0x17_dc3a;    /* jmp 0xdc3a */
        l_0x17_dc33:
            ii(0x17_dc33, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_dc36, 2);  jmp(0x17_dc3a, 2); goto l_0x17_dc3a;    /* jmp 0xdc3a */
        l_0x17_dc38:
            ii(0x17_dc38, 2);  xor(ax, ax);                            /* xor ax, ax */
        l_0x17_dc3a:
            ii(0x17_dc3a, 1);  pop(di);                                /* pop di */
            ii(0x17_dc3b, 1);  pop(si);                                /* pop si */
            ii(0x17_dc3c, 2);  mov(sp, bp);                            /* mov sp, bp */
            ii(0x17_dc3e, 1);  pop(bp);                                /* pop bp */
            ii(0x17_dc3f, 1);  retf();                                 /* retf */
        }
    }
}
