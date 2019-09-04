using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6d67-26a0725b")]
        public void Method_0000_6d67()
        {
            ii(0x6d67, 1);  push(si);                                  /* push si */
            ii(0x6d68, 3);  mov(si, 0x9f00);                           /* mov si, 0x9f00 */
            ii(0x6d6b, 2);  jmp(0x6d70, 3); goto l_0x6d70;             /* jmp 0x6d70 */
        l_0x6d6d:
            ii(0x6d6d, 3);  add(si, 0x40);                             /* add si, 0x40 */
        l_0x6d70:
            ii(0x6d70, 4);  cmp(si, 0xa000);                           /* cmp si, 0xa000 */
            ii(0x6d74, 2);  if(jz(0x6d85, 0xf)) goto l_0x6d85;         /* jz 0x6d85 */
            ii(0x6d76, 3);  push(0x92);                                /* push 0x92 */
            ii(0x6d79, 1);  push(si);                                  /* push si */
            ii(0x6d7a, 3);  call(0x6d46, -0x37);                       /* call 0x6d46 */
            ii(0x6d7d, 1);  pop(bx);                                   /* pop bx */
            ii(0x6d7e, 1);  pop(bx);                                   /* pop bx */
            ii(0x6d7f, 2);  jmp(0x6d6d, -0x14); goto l_0x6d6d;         /* jmp 0x6d6d */
        l_0x6d81:
            ii(0x6d81, 4);  add(si, 0x200);                            /* add si, 0x200 */
        l_0x6d85:
            ii(0x6d85, 2);  or(si, si);                                /* or si, si */
            ii(0x6d87, 2);  if(jz(0x6da9, 0x20)) goto l_0x6da9;        /* jz 0x6da9 */
            ii(0x6d89, 2);  mov(cx, si);                               /* mov cx, si */
            ii(0x6d8b, 3);  shr(cx, 0xc);                              /* shr cx, 0xc */
            ii(0x6d8e, 3);  mov(ax, 0xd000);                           /* mov ax, 0xd000 */
            ii(0x6d91, 2);  shr(ax, cl);                               /* shr ax, cl */
            ii(0x6d93, 3);  and(ax, 1);                                /* and ax, 0x1 */
            ii(0x6d96, 3);  cmp(ax, 1);                                /* cmp ax, 0x1 */
            ii(0x6d99, 2);  sbb(ax, ax);                               /* sbb ax, ax */
            ii(0x6d9b, 2);  and(al, 0xf8);                             /* and al, 0xf8 */
            ii(0x6d9d, 3);  add(ax, 0x9a);                             /* add ax, 0x9a */
            ii(0x6da0, 1);  push(ax);                                  /* push ax */
            ii(0x6da1, 1);  push(si);                                  /* push si */
            ii(0x6da2, 3);  call(0x6d46, -0x5f);                       /* call 0x6d46 */
            ii(0x6da5, 1);  pop(bx);                                   /* pop bx */
            ii(0x6da6, 1);  pop(bx);                                   /* pop bx */
            ii(0x6da7, 2);  jmp(0x6d81, -0x28); goto l_0x6d81;         /* jmp 0x6d81 */
        l_0x6da9:
            ii(0x6da9, 1);  pop(si);                                   /* pop si */
            ii(0x6daa, 1);  ret();                                     /* ret */
        }
    }
}
