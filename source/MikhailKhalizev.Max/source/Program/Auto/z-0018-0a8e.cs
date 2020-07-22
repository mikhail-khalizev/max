using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0a8e-930cdd26")]
        public void Method_0018_0a8e()
        {
            ii(0x18_0a8e, 4);  enter(8, 0);                            /* enter 0x8, 0x0 */
            ii(0x18_0a92, 1);  push(di);                               /* push di */
            ii(0x18_0a93, 1);  push(si);                               /* push si */
            ii(0x18_0a94, 1);  push(ds);                               /* push ds */
            ii(0x18_0a95, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x18_0a98, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_0a9a, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x18_0a9d, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x18_0aa0, 3);  call(0x18_0a56, -0x4d);                 /* call 0xa56 */
            ii(0x18_0aa3, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_0aa5, 2);  if(jnz(0x18_0aac, 5)) goto l_0x18_0aac; /* jnz 0xaac */
            ii(0x18_0aa7, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x18_0aaa, 2);  jmp(0x18_0aea, 0x3e); goto l_0x18_0aea; /* jmp 0xaea */
        l_0x18_0aac:
            ii(0x18_0aac, 3);  call(0x18_0a40, -0x6f);                 /* call 0xa40 */
            ii(0x18_0aaf, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_0ab1, 2);  if(jz(0x18_0ac4, 0x11)) goto l_0x18_0ac4;/* jz 0xac4 */
            ii(0x18_0ab3, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x18_0ab6, 3);  shr(ax, 3);                             /* shr ax, 0x3 */
            ii(0x18_0ab9, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x18_0abb, 3);  mov(cx, 0x50);                          /* mov cx, 0x50 */
            ii(0x18_0abe, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x18_0ac0, 4);  or(memb[es, bx], 0x40);                 /* or byte [es:bx], 0x40 */
        l_0x18_0ac4:
            ii(0x18_0ac4, 1);  push(di);                               /* push di */
            ii(0x18_0ac5, 1);  push(si);                               /* push si */
            ii(0x18_0ac6, 3);  mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x18_0ac9, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x18_0acc, 3);  lsl(di, bx);                            /* lsl di, bx */
            ii(0x18_0acf, 2);  xor(si, si);                            /* xor si, si */
            ii(0x18_0ad1, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x18_0ad3, 2);  mov(bx, cx);                            /* mov bx, cx */
            ii(0x18_0ad5, 2);  mov(cx, dx);                            /* mov cx, dx */
            ii(0x18_0ad7, 3);  mov(ax, 0x600);                         /* mov ax, 0x600 */
            ii(0x18_0ada, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x18_0adc, 1);  pop(si);                                /* pop si */
            ii(0x18_0add, 1);  pop(di);                                /* pop di */
            ii(0x18_0ade, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x18_0ae1, 1);  cmc();                                  /* cmc */
            ii(0x18_0ae2, 2);  rcl(ax, 1);                             /* rcl ax, 1 */
            ii(0x18_0ae4, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_0ae7, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
        l_0x18_0aea:
            ii(0x18_0aea, 1);  pop(ds);                                /* pop ds */
            ii(0x18_0aeb, 1);  pop(si);                                /* pop si */
            ii(0x18_0aec, 1);  pop(di);                                /* pop di */
            ii(0x18_0aed, 1);  leave();                                /* leave */
            ii(0x18_0aee, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
