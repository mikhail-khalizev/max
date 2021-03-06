using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9141-d3b9090f")]
        public void Method_0000_9141()
        {
            ii(0x9141, 1);  push(bp);                                  /* push bp */
            ii(0x9142, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x9144, 3);  sub(sp, 2);                                /* sub sp, 0x2 */
            ii(0x9147, 1);  push(si);                                  /* push si */
            ii(0x9148, 5);  mov(memw[ss, bp - 2], 0);                  /* mov word [bp-0x2], 0x0 */
        l_0x914d:
            ii(0x914d, 3);  call(0x90c6, -0x8a);                       /* call 0x90c6 */
            ii(0x9150, 2);  mov(si, ax);                               /* mov si, ax */
            ii(0x9152, 3);  cmp(si, 0xa);                              /* cmp si, 0xa */
            ii(0x9155, 2);  if(jnz(0x915c, 5)) goto l_0x915c;          /* jnz 0x915c */
            ii(0x9157, 3);  mov(ax, 0xfffe);                           /* mov ax, 0xfffe */
            ii(0x915a, 2);  jmp(0x9196, 0x3a); goto l_0x9196;          /* jmp 0x9196 */
        l_0x915c:
            ii(0x915c, 3);  cmp(si, 0x2a);                             /* cmp si, 0x2a */
            ii(0x915f, 2);  if(jnz(0x9166, 5)) goto l_0x9166;          /* jnz 0x9166 */
            ii(0x9161, 3);  mov(ax, 0xfffd);                           /* mov ax, 0xfffd */
            ii(0x9164, 2);  jmp(0x9196, 0x30); goto l_0x9196;          /* jmp 0x9196 */
        l_0x9166:
            ii(0x9166, 3);  cmp(si, 0x40);                             /* cmp si, 0x40 */
            ii(0x9169, 2);  if(jnz(0x9170, 5)) goto l_0x9170;          /* jnz 0x9170 */
            ii(0x916b, 3);  mov(ax, 0xfffc);                           /* mov ax, 0xfffc */
            ii(0x916e, 2);  jmp(0x9196, 0x26); goto l_0x9196;          /* jmp 0x9196 */
        l_0x9170:
            ii(0x9170, 3);  lea(ax, memw[ds, si - 48]);                /* lea ax, [si-0x30] */
            ii(0x9173, 3);  cmp(ax, 9);                                /* cmp ax, 0x9 */
            ii(0x9176, 2);  if(ja(0x914d, -0x2b)) goto l_0x914d;       /* ja 0x914d */
        l_0x9178:
            ii(0x9178, 3);  mov(ax, 0xa);                              /* mov ax, 0xa */
            ii(0x917b, 3);  imul(memw[ss, bp - 2]);                    /* imul word [bp-0x2] */
            ii(0x917e, 2);  add(ax, si);                               /* add ax, si */
            ii(0x9180, 3);  sub(ax, 0x30);                             /* sub ax, 0x30 */
            ii(0x9183, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x9186, 3);  call(0x90c6, -0xc3);                       /* call 0x90c6 */
            ii(0x9189, 2);  mov(si, ax);                               /* mov si, ax */
            ii(0x918b, 3);  lea(ax, memw[ds, si - 48]);                /* lea ax, [si-0x30] */
            ii(0x918e, 3);  cmp(ax, 9);                                /* cmp ax, 0x9 */
            ii(0x9191, 2);  if(jbe(0x9178, -0x1b)) goto l_0x9178;      /* jbe 0x9178 */
            ii(0x9193, 3);  mov(ax, memw[ss, bp - 2]);                 /* mov ax, [bp-0x2] */
        l_0x9196:
            ii(0x9196, 1);  pop(si);                                   /* pop si */
            ii(0x9197, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x9199, 1);  pop(bp);                                   /* pop bp */
            ii(0x919a, 1);  ret();                                     /* ret */
        }
    }
}
