using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0f5f-83c2c79f")]
        public void Method_001a_0f5f()
        {
            ii(0x1a_0f5f, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x1a_0f63, 1);  push(es);                               /* push es */
            ii(0x1a_0f64, 1);  push(ds);                               /* push ds */
            ii(0x1a_0f65, 1);  push(si);                               /* push si */
            ii(0x1a_0f66, 1);  push(di);                               /* push di */
            ii(0x1a_0f67, 1);  push(cx);                               /* push cx */
            ii(0x1a_0f68, 3);  lds(si, memw[ss, bp + 10]);             /* lds si, [bp+0xa] */
            ii(0x1a_0f6b, 3);  les(di, memw[ss, bp + 6]);              /* les di, [bp+0x6] */
            ii(0x1a_0f6e, 2);  mov(ax, di);                            /* mov ax, di */
            ii(0x1a_0f70, 3);  mov(cx, memw[ss, bp + 14]);             /* mov cx, [bp+0xe] */
            ii(0x1a_0f73, 2);  if(jcxz(0x1a_0fa6, 0x31)) goto l_0x1a_0fa6;/* jcxz 0xfa6 */
            ii(0x1a_0f75, 2);  mov(ax, es);                            /* mov ax, es */
            ii(0x1a_0f77, 3);  cmp(ax, memw[ss, bp + 12]);             /* cmp ax, [bp+0xc] */
            ii(0x1a_0f7a, 2);  if(jnz(0x1a_0f96, 0x1a)) goto l_0x1a_0f96;/* jnz 0xf96 */
            ii(0x1a_0f7c, 2);  cmp(di, si);                            /* cmp di, si */
            ii(0x1a_0f7e, 2);  if(jbe(0x1a_0f96, 0x16)) goto l_0x1a_0f96;/* jbe 0xf96 */
            ii(0x1a_0f80, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x1a_0f82, 2);  add(ax, cx);                            /* add ax, cx */
            ii(0x1a_0f84, 2);  cmp(di, ax);                            /* cmp di, ax */
            ii(0x1a_0f86, 2);  if(jae(0x1a_0f96, 0xe)) goto l_0x1a_0f96;/* jae 0xf96 */
            ii(0x1a_0f88, 2);  mov(ax, di);                            /* mov ax, di */
            ii(0x1a_0f8a, 2);  add(si, cx);                            /* add si, cx */
            ii(0x1a_0f8c, 2);  add(di, cx);                            /* add di, cx */
            ii(0x1a_0f8e, 1);  dec(si);                                /* dec si */
            ii(0x1a_0f8f, 1);  dec(di);                                /* dec di */
            ii(0x1a_0f90, 1);  std();                                  /* std */
            ii(0x1a_0f91, 2);  rep(() => movsb());                     /* rep movsb */
            ii(0x1a_0f93, 1);  cld();                                  /* cld */
            ii(0x1a_0f94, 2);  jmp(0x1a_0fa6, 0x10); goto l_0x1a_0fa6; /* jmp 0xfa6 */
        l_0x1a_0f96:
            ii(0x1a_0f96, 2);  mov(ax, di);                            /* mov ax, di */
            ii(0x1a_0f98, 2);  test(al, 1);                            /* test al, 0x1 */
            ii(0x1a_0f9a, 2);  if(jz(0x1a_0f9e, 2)) goto l_0x1a_0f9e;  /* jz 0xf9e */
            ii(0x1a_0f9c, 1);  movsb();                                /* movsb */
            ii(0x1a_0f9d, 1);  dec(cx);                                /* dec cx */
        l_0x1a_0f9e:
            ii(0x1a_0f9e, 2);  shr(cx, 1);                             /* shr cx, 1 */
            ii(0x1a_0fa0, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x1a_0fa2, 2);  adc(cx, cx);                            /* adc cx, cx */
            ii(0x1a_0fa4, 2);  rep(() => movsb());                     /* rep movsb */
        l_0x1a_0fa6:
            ii(0x1a_0fa6, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x1a_0fa8, 1);  pop(cx);                                /* pop cx */
            ii(0x1a_0fa9, 1);  pop(di);                                /* pop di */
            ii(0x1a_0faa, 1);  pop(si);                                /* pop si */
            ii(0x1a_0fab, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0fac, 1);  pop(es);                                /* pop es */
            ii(0x1a_0fad, 1);  leave();                                /* leave */
            ii(0x1a_0fae, 1);  retf();                                 /* retf */
        }
    }
}
