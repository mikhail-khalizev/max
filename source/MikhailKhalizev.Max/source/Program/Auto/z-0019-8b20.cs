using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8b20-29b35a3e")]
        public void Method_0019_8b20()
        {
            ii(0x19_8b20, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_8b24, 1);  push(di);                               /* push di */
            ii(0x19_8b25, 1);  push(si);                               /* push si */
            ii(0x19_8b26, 5);  mov(memw[ss, bp - 6], 1);               /* mov word [bp-0x6], 0x1 */
            ii(0x19_8b2b, 2);  sub(si, si);                            /* sub si, si */
            ii(0x19_8b2d, 1);  push(si);                               /* push si */
            ii(0x19_8b2e, 1);  push(si);                               /* push si */
            ii(0x19_8b2f, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_8b32, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_8b35, 1);  push(si);                               /* push si */
            ii(0x19_8b36, 2);  push(0x20);                             /* push 0x20 */
            ii(0x19_8b38, 3);  call(0x19_de46, 0x530b);                /* call 0xde46 */
            ii(0x19_8b3b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_8b3e, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_8b41, 2);  jmp(0x19_8b63, 0x20); goto l_0x19_8b63; /* jmp 0x8b63 */
        l_0x19_8b43:
            ii(0x19_8b43, 4);  cmp(memw[ss, bp - 6], 0);               /* cmp word [bp-0x6], 0x0 */
            ii(0x19_8b47, 2);  if(jz(0x19_8b6b, 0x22)) goto l_0x19_8b6b;/* jz 0x8b6b */
            ii(0x19_8b49, 2);  add(bx, si);                            /* add bx, si */
            ii(0x19_8b4b, 3);  mov(al, memb[ds, bx + 1]);              /* mov al, [bx+0x1] */
            ii(0x19_8b4e, 2);  mov(bl, memb[ds, bx]);                  /* mov bl, [bx] */
            ii(0x19_8b50, 2);  sub(bh, bh);                            /* sub bh, bh */
            ii(0x19_8b52, 3);  les(di, memw[ss, bp - 4]);              /* les di, [bp-0x4] */
            ii(0x19_8b55, 3);  cmp(memb[es, bx + di], al);             /* cmp [es:bx+di], al */
            ii(0x19_8b58, 2);  if(jz(0x19_8b61, 7)) goto l_0x19_8b61;  /* jz 0x8b61 */
            ii(0x19_8b5a, 5);  mov(memw[ss, bp - 6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x19_8b5f, 2);  jmp(0x19_8b63, 2); goto l_0x19_8b63;    /* jmp 0x8b63 */
        l_0x19_8b61:
            ii(0x19_8b61, 1);  inc(si);                                /* inc si */
            ii(0x19_8b62, 1);  inc(si);                                /* inc si */
        l_0x19_8b63:
            ii(0x19_8b63, 3);  mov(bx, memw[ss, bp + 4]);              /* mov bx, [bp+0x4] */
            ii(0x19_8b66, 3);  cmp(memb[ds, bx + si], 0);              /* cmp byte [bx+si], 0x0 */
            ii(0x19_8b69, 2);  if(jnz(0x19_8b43, -0x28)) goto l_0x19_8b43;/* jnz 0x8b43 */
        l_0x19_8b6b:
            ii(0x19_8b6b, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_8b6e, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_8b71, 3);  call(0x19_df78, 0x5404);                /* call 0xdf78 */
            ii(0x19_8b74, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x19_8b77, 1);  pop(si);                                /* pop si */
            ii(0x19_8b78, 1);  pop(di);                                /* pop di */
            ii(0x19_8b79, 1);  leave();                                /* leave */
            ii(0x19_8b7a, 3);  ret(6);                                 /* ret 0x6 */
        }
    }
}
