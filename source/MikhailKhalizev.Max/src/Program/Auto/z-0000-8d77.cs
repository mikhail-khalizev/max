using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8d77-26a0725b")]
        public void Method_0000_8d77()
        {
            ii(0x8d77, 1);    pushw(si);                                /* push si */
            ii(0x8d78, 3);    mov(si, 0x9f00);                          /* mov si, 0x9f00 */
            ii(0x8d7b, 2);    jmpw(0x8d80, 0x3); goto l_0x8d80;         /* jmp 0x8d80 */
        l_0x8d7d:
            ii(0x8d7d, 3);    add(si, 0x40);                            /* add si, 0x40 */
        l_0x8d80:
            ii(0x8d80, 4);    cmp(si, 0xa000);                          /* cmp si, 0xa000 */
            ii(0x8d84, 2);    if(jzw(0x8d95, 0xf)) goto l_0x8d95;       /* jz 0x8d95 */
            ii(0x8d86, 3);    pushw(0x92);                              /* push 0x92 */
            ii(0x8d89, 1);    pushw(si);                                /* push si */
            ii(0x8d8a, 3);    callw(0x8d56, -0x37);                     /* call 0x8d56 */
            ii(0x8d8d, 1);    popw(bx);                                 /* pop bx */
            ii(0x8d8e, 1);    popw(bx);                                 /* pop bx */
            ii(0x8d8f, 2);    jmpw(0x8d7d, -0x14); goto l_0x8d7d;       /* jmp 0x8d7d */
        l_0x8d91:
            ii(0x8d91, 4);    add(si, 0x200);                           /* add si, 0x200 */
        l_0x8d95:
            ii(0x8d95, 2);    or(si, si);                               /* or si, si */
            ii(0x8d97, 2);    if(jzw(0x8db9, 0x20)) goto l_0x8db9;      /* jz 0x8db9 */
            ii(0x8d99, 2);    mov(cx, si);                              /* mov cx, si */
            ii(0x8d9b, 3);    shr(cx, 0xc);                             /* shr cx, 0xc */
            ii(0x8d9e, 3);    mov(ax, 0xd000);                          /* mov ax, 0xd000 */
            ii(0x8da1, 2);    shr(ax, cl);                              /* shr ax, cl */
            ii(0x8da3, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x8da6, 3);    cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x8da9, 2);    sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x8dab, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x8dad, 3);    add(ax, 0x9a);                            /* add ax, 0x9a */
            ii(0x8db0, 1);    pushw(ax);                                /* push ax */
            ii(0x8db1, 1);    pushw(si);                                /* push si */
            ii(0x8db2, 3);    callw(0x8d56, -0x5f);                     /* call 0x8d56 */
            ii(0x8db5, 1);    popw(bx);                                 /* pop bx */
            ii(0x8db6, 1);    popw(bx);                                 /* pop bx */
            ii(0x8db7, 2);    jmpw(0x8d91, -0x28); goto l_0x8d91;       /* jmp 0x8d91 */
        l_0x8db9:
            ii(0x8db9, 1);    popw(si);                                 /* pop si */
            ii(0x8dba, 1);    retw();                                   /* ret */
        }
    }
}
