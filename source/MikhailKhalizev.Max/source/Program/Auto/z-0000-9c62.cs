using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9c62-c21cc925")]
        public void Method_0000_9c62()
        {
            ii(0x9c62, 5);  cmp(memb[ds, 0x34], 0x15);                 /* cmp byte [0x34], 0x15 */
            ii(0x9c67, 3);  mov(ax, 0);                                /* mov ax, 0x0 */
            ii(0x9c6a, 2);  if(jnz(0x9c91, 0x25)) goto l_0x9c91;       /* jnz 0x9c91 */
            ii(0x9c6c, 2);  mov(ah, 0xc0);                             /* mov ah, 0xc0 */
            ii(0x9c6e, 2);  @int(0x15);                                /* int 0x15 */
            ii(0x9c70, 3);  mov(ax, 0);                                /* mov ax, 0x0 */
            ii(0x9c73, 2);  if(jb(0x9c91, 0x1c)) goto l_0x9c91;        /* jb 0x9c91 */
            ii(0x9c75, 4);  mov(cx, memw[es, bx + 2]);                 /* mov cx, [es:bx+0x2] */
            ii(0x9c79, 3);  cmp(cl, -0x20 /* 0xe0 */);                 /* cmp cl, 0xe0 */
            ii(0x9c7c, 2);  if(jb(0x9c91, 0x13)) goto l_0x9c91;        /* jb 0x9c91 */
            ii(0x9c7e, 3);  cmp(cl, -8 /* 0xf8 */);                    /* cmp cl, 0xf8 */
            ii(0x9c81, 2);  if(jle(0x9c8d, 0xa)) goto l_0x9c8d;        /* jle 0x9c8d */
            ii(0x9c83, 3);  cmp(cl, -4 /* 0xfc */);                    /* cmp cl, 0xfc */
            ii(0x9c86, 2);  if(jnz(0x9c91, 9)) goto l_0x9c91;          /* jnz 0x9c91 */
            ii(0x9c88, 3);  cmp(ch, 4);                                /* cmp ch, 0x4 */
            ii(0x9c8b, 2);  if(jl(0x9c91, 4)) goto l_0x9c91;           /* jl 0x9c91 */
        l_0x9c8d:
            ii(0x9c8d, 4);  mov(al, memb[es, bx + 5]);                 /* mov al, [es:bx+0x5] */
        l_0x9c91:
            ii(0x9c91, 1);  ret();                                     /* ret */
        }
    }
}
