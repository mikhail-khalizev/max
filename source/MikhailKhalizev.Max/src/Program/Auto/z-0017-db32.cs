using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_db32-e267901b")]
        public void Method_0017_db32()
        {
            ii(0x17_db32, 1); push(bp);                                 /* push bp */
            ii(0x17_db33, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_db35, 1); push(di);                                 /* push di */
            ii(0x17_db36, 1); push(si);                                 /* push si */
            ii(0x17_db37, 4); mov(si, memw[ds, 0x1c75]);                /* mov si, [0x1c75] */
            ii(0x17_db3b, 2); or(si, si);                               /* or si, si */
            ii(0x17_db3d, 2); if(jz(0x17_db89, 0x4a)) goto l_0x17_db89; /* jz 0xdb89 */
            ii(0x17_db3f, 4); cmp(memw[ss, bp + 0x6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x17_db43, 2); if(jz(0x17_db89, 0x44)) goto l_0x17_db89; /* jz 0xdb89 */
            ii(0x17_db45, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_db48, 1); nop();                                    /* nop */
            ii(0x17_db49, 1); push(cs);                                 /* push cs */
            ii(0x17_db4a, 3); call(0x17_db16, -0x37);                   /* call 0xdb16 */
            ii(0x17_db4d, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_db50, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_db52, 2); jmp(0x17_db84, 0x30); goto l_0x17_db84;   /* jmp 0xdb84 */
        l_0x17_db54:
            ii(0x17_db54, 2); push(memw[ds, si]);                       /* push word [si] */
            ii(0x17_db56, 1); nop();                                    /* nop */
            ii(0x17_db57, 1); push(cs);                                 /* push cs */
            ii(0x17_db58, 3); call(0x17_db16, -0x45);                   /* call 0xdb16 */
            ii(0x17_db5b, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_db5e, 2); cmp(ax, di);                              /* cmp ax, di */
            ii(0x17_db60, 2); if(jle(0x17_db82, 0x20)) goto l_0x17_db82; /* jle 0xdb82 */
            ii(0x17_db62, 2); mov(bx, memw[ds, si]);                    /* mov bx, [si] */
            ii(0x17_db64, 3); cmp(memb[ds, bx + di], 0x3d);             /* cmp byte [bx+di], 0x3d */
            ii(0x17_db67, 2); if(jnz(0x17_db82, 0x19)) goto l_0x17_db82; /* jnz 0xdb82 */
            ii(0x17_db69, 1); push(di);                                 /* push di */
            ii(0x17_db6a, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_db6d, 1); push(bx);                                 /* push bx */
            ii(0x17_db6e, 1); nop();                                    /* nop */
            ii(0x17_db6f, 1); push(cs);                                 /* push cs */
            ii(0x17_db70, 3); call(0x17_e276, 0x703);                   /* call 0xe276 */
            ii(0x17_db73, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_db76, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_db78, 2); if(jnz(0x17_db82, 0x8)) goto l_0x17_db82; /* jnz 0xdb82 */
            ii(0x17_db7a, 2); mov(ax, memw[ds, si]);                    /* mov ax, [si] */
            ii(0x17_db7c, 2); add(ax, di);                              /* add ax, di */
            ii(0x17_db7e, 1); inc(ax);                                  /* inc ax */
            ii(0x17_db7f, 2); jmp(0x17_db8b, 0xa); goto l_0x17_db8b;    /* jmp 0xdb8b */
        //  ii(0x17_db81, 1); nop();                                    /* nop */
        l_0x17_db82:
            ii(0x17_db82, 1); inc(si);                                  /* inc si */
            ii(0x17_db83, 1); inc(si);                                  /* inc si */
        l_0x17_db84:
            ii(0x17_db84, 3); cmp(memw[ds, si], 0);                     /* cmp word [si], 0x0 */
            ii(0x17_db87, 2); if(jnz(0x17_db54, -0x35)) goto l_0x17_db54; /* jnz 0xdb54 */
        l_0x17_db89:
            ii(0x17_db89, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x17_db8b:
            ii(0x17_db8b, 1); pop(si);                                  /* pop si */
            ii(0x17_db8c, 1); pop(di);                                  /* pop di */
            ii(0x17_db8d, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_db8f, 1); pop(bp);                                  /* pop bp */
            ii(0x17_db90, 1); retf();                                   /* retf */
        }
    }
}
