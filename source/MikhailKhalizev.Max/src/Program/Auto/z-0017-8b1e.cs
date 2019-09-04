using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8b1e-5db8fb20")]
        public void Method_0017_8b1e()
        {
            ii(0x17_8b1e, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x17_8b22, 1); push(ds);                                 /* push ds */
            ii(0x17_8b23, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8b26, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8b28, 5); mov(memw[ss, bp - 4], 0);                 /* mov word [bp-0x4], 0x0 */
            ii(0x17_8b2d, 5); and(memw[ss, bp - 2], 0x7f00);            /* and word [bp-0x2], 0x7f00 */
            ii(0x17_8b32, 2); push(0);                                  /* push 0x0 */
            ii(0x17_8b34, 2); push(0);                                  /* push 0x0 */
            ii(0x17_8b36, 3); call(0x17_8f06, 0x3cd);                   /* call 0x8f06 */
            ii(0x17_8b39, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_8b3c, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x17_8b3f, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x17_8b42, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_8b45, 2); if(jnz(0x17_8b4b, 4)) goto l_0x17_8b4b;   /* jnz 0x8b4b */
            ii(0x17_8b47, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_8b49, 2); if(jz(0x17_8b4e, 3)) goto l_0x17_8b4e;    /* jz 0x8b4e */
        l_0x17_8b4b:
            ii(0x17_8b4b, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8b4c, 1); leave();                                  /* leave */
            ii(0x17_8b4d, 1); retf(); return;                           /* retf */
        l_0x17_8b4e:
            ii(0x17_8b4e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_8b50, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_8b53, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x17_8b56, 2); jmp(0x17_8b60, 8); goto l_0x17_8b60;      /* jmp 0x8b60 */
        l_0x17_8b58:
            ii(0x17_8b58, 4); add(memw[ss, bp - 8], 1);                 /* add word [bp-0x8], 0x1 */
            ii(0x17_8b5c, 4); adc(memw[ss, bp - 6], 0);                 /* adc word [bp-0x6], 0x0 */
        l_0x17_8b60:
            ii(0x17_8b60, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x17_8b63, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x17_8b66, 4); cmp(memw[ds, 0x1f52], dx);                /* cmp [0x1f52], dx */
            ii(0x17_8b6a, 2); if(jb(0x17_8b9c, 0x30)) goto l_0x17_8b9c; /* jb 0x8b9c */
            ii(0x17_8b6c, 2); if(ja(0x17_8b74, 6)) goto l_0x17_8b74;    /* ja 0x8b74 */
            ii(0x17_8b6e, 4); cmp(memw[ds, 0x1f50], ax);                /* cmp [0x1f50], ax */
            ii(0x17_8b72, 2); if(jbe(0x17_8b9c, 0x28)) goto l_0x17_8b9c; /* jbe 0x8b9c */
        l_0x17_8b74:
            ii(0x17_8b74, 1); push(dx);                                 /* push dx */
            ii(0x17_8b75, 1); push(ax);                                 /* push ax */
            ii(0x17_8b76, 4); push(memw[ds, 0x4fb6]);                   /* push word [0x4fb6] */
            ii(0x17_8b7a, 4); push(memw[ds, 0x4fb4]);                   /* push word [0x4fb4] */
            ii(0x17_8b7e, 3); call(0x17_9208, 0x687);                   /* call 0x9208 */
            ii(0x17_8b81, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_8b84, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_8b87, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_8b8a, 5); test(memw[ss, bp - 2], 0x8000);           /* test word [bp-0x2], 0x8000 */
            ii(0x17_8b8f, 2); if(jnz(0x17_8b9a, 9)) goto l_0x17_8b9a;   /* jnz 0x8b9a */
            ii(0x17_8b91, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x17_8b94, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x17_8b97, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8b98, 1); leave();                                  /* leave */
            ii(0x17_8b99, 1); retf(); return;                           /* retf */
        l_0x17_8b9a:
            ii(0x17_8b9a, 2); jmp(0x17_8b58, -0x44); goto l_0x17_8b58;  /* jmp 0x8b58 */
        l_0x17_8b9c:
            ii(0x17_8b9c, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_8b9f, 1); cwd();                                    /* cwd */
            ii(0x17_8ba0, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8ba1, 1); leave();                                  /* leave */
            ii(0x17_8ba2, 1); retf();                                   /* retf */
        }
    }
}
