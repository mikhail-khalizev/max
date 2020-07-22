using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9bd1-c1d1e0ce")]
        public void Method_0000_9bd1()
        {
            ii(0x9bd1, 1);  pushfw();                                  /* pushfw */
            ii(0x9bd2, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x9bd4, 1);  push(ax);                                  /* push ax */
            ii(0x9bd5, 1);  popfw();                                   /* popfw */
            ii(0x9bd6, 1);  pushfw();                                  /* pushfw */
            ii(0x9bd7, 1);  pop(ax);                                   /* pop ax */
            ii(0x9bd8, 3);  and(ah, 0xf0);                             /* and ah, 0xf0 */
            ii(0x9bdb, 3);  cmp(ah, -0x10 /* 0xf0 */);                 /* cmp ah, 0xf0 */
            ii(0x9bde, 2);  if(jz(0x9c04, 0x24)) goto l_0x9c04;        /* jz 0x9c04 */
            ii(0x9be0, 1);  push(sp);                                  /* push sp */
            ii(0x9be1, 1);  pop(bx);                                   /* pop bx */
            ii(0x9be2, 2);  cmp(bx, sp);                               /* cmp bx, sp */
            ii(0x9be4, 2);  if(jnz(0x9bff, 0x19)) goto l_0x9bff;       /* jnz 0x9bff */
            ii(0x9be6, 3);  mov(ax, 0xf000);                           /* mov ax, 0xf000 */
            ii(0x9be9, 1);  push(ax);                                  /* push ax */
            ii(0x9bea, 1);  popfw();                                   /* popfw */
            ii(0x9beb, 1);  pushfw();                                  /* pushfw */
            ii(0x9bec, 1);  pop(bx);                                   /* pop bx */
            ii(0x9bed, 2);  and(bx, ax);                               /* and bx, ax */
            ii(0x9bef, 2);  if(jz(0x9bfa, 9)) goto l_0x9bfa;           /* jz 0x9bfa */
            ii(0x9bf1, 3);  mov(ax, 3);                                /* mov ax, 0x3 */
            ii(0x9bf4, 4);  mov(memd[ds, 0x10f2], eax);                /* mov [0x10f2], eax */
            ii(0x9bf8, 2);  jmp(0x9c06, 0xc); goto l_0x9c06;           /* jmp 0x9c06 */
        l_0x9bfa:
            ii(0x9bfa, 3);  mov(ax, 2);                                /* mov ax, 0x2 */
            ii(0x9bfd, 2);  jmp(0x9c06, 7); goto l_0x9c06;             /* jmp 0x9c06 */
        l_0x9bff:
            ii(0x9bff, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x9c02, 2);  jmp(0x9c06, 2); goto l_0x9c06;             /* jmp 0x9c06 */
        l_0x9c04:
            ii(0x9c04, 2);  xor(ax, ax);                               /* xor ax, ax */
        l_0x9c06:
            ii(0x9c06, 1);  popfw();                                   /* popfw */
            ii(0x9c07, 1);  ret();                                     /* ret */
        }
    }
}
