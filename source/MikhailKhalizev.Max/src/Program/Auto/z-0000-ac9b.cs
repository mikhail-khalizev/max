using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xac9b-c77ffa81")]
        public void Method_0000_ac9b()
        {
            ii(0xac9b, 2);    push(0);                                  /* push 0x0 */
            ii(0xac9d, 1);    pop(ds);                                  /* pop ds */
            ii(0xac9e, 1);    push(si);                                 /* push si */
            ii(0xac9f, 1);    push(di);                                 /* push di */
            ii(0xaca0, 3);    mov(si, 0x19c);                           /* mov si, 0x19c */
            ii(0xaca3, 2);    mov(di, memw[ds, si]);                    /* mov di, [si] */
            ii(0xaca5, 1);    push(di);                                 /* push di */
            ii(0xaca6, 3);    mov(cx, memw[ds, si + 0x2]);              /* mov cx, [si+0x2] */
            ii(0xaca9, 1);    push(cx);                                 /* push cx */
            ii(0xacaa, 5);    cmp(di, memw[ss, 0x56]);                  /* cmp di, [ss:0x56] */
            ii(0xacaf, 2);    if(jnz(0xacbf, 0xe)) goto l_0xacbf;       /* jnz 0xacbf */
            ii(0xacb1, 5);    cmp(cx, memw[ss, 0x58]);                  /* cmp cx, [ss:0x58] */
            ii(0xacb6, 2);    if(jnz(0xacbf, 0x7)) goto l_0xacbf;       /* jnz 0xacbf */
            ii(0xacb8, 4);    mov(memw[ds, si], 0x7750);                /* mov word [si], 0x7750 */
            ii(0xacbc, 3);    mov(memw[ds, si + 0x2], cs);              /* mov [si+0x2], cs */
        l_0xacbf:
            ii(0xacbf, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xacc1, 3);    pop(memw[ds, si + 0x2]);                  /* pop word [si+0x2] */
            ii(0xacc4, 2);    pop(memw[ds, si]);                        /* pop word [si] */
            ii(0xacc6, 1);    pop(di);                                  /* pop di */
            ii(0xacc7, 1);    pop(si);                                  /* pop si */
            ii(0xacc8, 1);    push(ss);                                 /* push ss */
            ii(0xacc9, 1);    pop(ds);                                  /* pop ds */
            ii(0xacca, 1);    ret();                                    /* ret */
        }
    }
}
