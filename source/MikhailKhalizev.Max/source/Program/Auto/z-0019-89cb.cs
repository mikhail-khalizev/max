using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_89cb-e8f765ce")]
        public void Method_0019_89cb()
        {
            ii(0x19_89cb, 4);  enter(0x16, 0);                         /* enter 0x16, 0x0 */
            ii(0x19_89cf, 1);  push(di);                               /* push di */
            ii(0x19_89d0, 1);  push(si);                               /* push si */
            ii(0x19_89d1, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_89d4, 3);  jmp(0x19_8a10, 0x39); goto l_0x19_8a10; /* jmp 0x8a10 */
        l_0x19_89d7:
            ii(0x19_89d7, 5);  mov(memw[ss, bp - 10], 9);              /* mov word [bp-0xa], 0x9 */
            ii(0x19_89dc, 5);  mov(memw[ss, bp - 14], 0x1824);         /* mov word [bp-0xe], 0x1824 */
            ii(0x19_89e1, 3);  mov(memw[ss, bp - 12], ds);             /* mov [bp-0xc], ds */
            ii(0x19_89e4, 3);  jmp(0x19_8a2f, 0x48); goto l_0x19_8a2f; /* jmp 0x8a2f */
        l_0x19_89e7:
            ii(0x19_89e7, 5);  mov(memw[ss, bp - 10], 5);              /* mov word [bp-0xa], 0x5 */
            ii(0x19_89ec, 5);  mov(memw[ss, bp - 14], 0x182e);         /* mov word [bp-0xe], 0x182e */
            ii(0x19_89f1, 3);  mov(memw[ss, bp - 12], ds);             /* mov [bp-0xc], ds */
            ii(0x19_89f4, 3);  jmp(0x19_8a2f, 0x38); goto l_0x19_8a2f; /* jmp 0x8a2f */
        l_0x19_89f7:
            ii(0x19_89f7, 5);  mov(memw[ss, bp - 10], 5);              /* mov word [bp-0xa], 0x5 */
            ii(0x19_89fc, 5);  mov(memw[ss, bp - 14], 0x1834);         /* mov word [bp-0xe], 0x1834 */
            ii(0x19_8a01, 3);  mov(memw[ss, bp - 12], ds);             /* mov [bp-0xc], ds */
            ii(0x19_8a04, 3);  jmp(0x19_8a2f, 0x28); goto l_0x19_8a2f; /* jmp 0x8a2f */
        l_0x19_8a07:
            ii(0x19_8a07, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_8a0a, 3);  jmp(0x19_8a86, 0x79); goto l_0x19_8a86; /* jmp 0x8a86 */
        //  ii(0x19_8a0d, 3);  Недостижимый код.
        l_0x19_8a10:
            ii(0x19_8a10, 3);  sub(ax, 0x34);                          /* sub ax, 0x34 */
            ii(0x19_8a13, 2);  if(jge(0x19_8a18, 3)) goto l_0x19_8a18; /* jge 0x8a18 */
            ii(0x19_8a15, 3);  jmp(0x19_8a07, -0x11); goto l_0x19_8a07;/* jmp 0x8a07 */
        l_0x19_8a18:
            ii(0x19_8a18, 3);  sub(ax, 7);                             /* sub ax, 0x7 */
            ii(0x19_8a1b, 2);  if(jg(0x19_8a20, 3)) goto l_0x19_8a20;  /* jg 0x8a20 */
            ii(0x19_8a1d, 3);  jmp(0x19_89d7, -0x49); goto l_0x19_89d7;/* jmp 0x89d7 */
        l_0x19_8a20:
            ii(0x19_8a20, 1);  dec(ax);                                /* dec ax */
            ii(0x19_8a21, 2);  if(jnz(0x19_8a26, 3)) goto l_0x19_8a26; /* jnz 0x8a26 */
            ii(0x19_8a23, 3);  jmp(0x19_89e7, -0x3f); goto l_0x19_89e7;/* jmp 0x89e7 */
        l_0x19_8a26:
            ii(0x19_8a26, 1);  dec(ax);                                /* dec ax */
            ii(0x19_8a27, 2);  if(jnz(0x19_8a2c, 3)) goto l_0x19_8a2c; /* jnz 0x8a2c */
            ii(0x19_8a29, 3);  jmp(0x19_89f7, -0x35); goto l_0x19_89f7;/* jmp 0x89f7 */
        l_0x19_8a2c:
            ii(0x19_8a2c, 3);  jmp(0x19_8a07, -0x28); goto l_0x19_8a07;/* jmp 0x8a07 */
        l_0x19_8a2f:
            ii(0x19_8a2f, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_8a32, 4);  mov(ax, memw[es, bx + 54]);             /* mov ax, [es:bx+0x36] */
            ii(0x19_8a36, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_8a38, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_8a3b, 4);  or(cx, memw[es, bx + 50]);              /* or cx, [es:bx+0x32] */
            ii(0x19_8a3f, 3);  or(ax, 0);                              /* or ax, 0x0 */
            ii(0x19_8a42, 3);  sub(cx, memw[ss, bp - 10]);             /* sub cx, [bp-0xa] */
            ii(0x19_8a45, 1);  inc(cx);                                /* inc cx */
            ii(0x19_8a46, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x19_8a49, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_8a4c, 3);  mov(ax, memw[ss, bp - 14]);             /* mov ax, [bp-0xe] */
            ii(0x19_8a4f, 3);  mov(dx, memw[ss, bp - 12]);             /* mov dx, [bp-0xc] */
            ii(0x19_8a52, 3);  add(ax, memw[ss, bp - 10]);             /* add ax, [bp-0xa] */
            ii(0x19_8a55, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_8a58, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
        l_0x19_8a5b:
            ii(0x19_8a5b, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x19_8a5e, 3);  cmp(memw[ss, bp - 14], ax);             /* cmp [bp-0xe], ax */
            ii(0x19_8a61, 2);  if(jb(0x19_8a66, 3)) goto l_0x19_8a66;  /* jb 0x8a66 */
            ii(0x19_8a63, 3);  jmp(0x19_8a86, 0x20); goto l_0x19_8a86; /* jmp 0x8a86 */
        l_0x19_8a66:
            ii(0x19_8a66, 3);  les(bx, memw[ss, bp - 14]);             /* les bx, [bp-0xe] */
            ii(0x19_8a69, 3);  inc(memw[ss, bp - 14]);                 /* inc word [bp-0xe] */
            ii(0x19_8a6c, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_8a6f, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_8a72, 3);  inc(memw[ss, bp - 4]);                  /* inc word [bp-0x4] */
            ii(0x19_8a75, 3);  cmp(memb[es, bx], al);                  /* cmp [es:bx], al */
            ii(0x19_8a78, 2);  if(jnz(0x19_8a7d, 3)) goto l_0x19_8a7d; /* jnz 0x8a7d */
            ii(0x19_8a7a, 3);  jmp(0x19_8a83, 6); goto l_0x19_8a83;    /* jmp 0x8a83 */
        l_0x19_8a7d:
            ii(0x19_8a7d, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_8a80, 3);  jmp(0x19_8a86, 3); goto l_0x19_8a86;    /* jmp 0x8a86 */
        l_0x19_8a83:
            ii(0x19_8a83, 3);  jmp(0x19_8a5b, -0x2b); goto l_0x19_8a5b;/* jmp 0x8a5b */
        l_0x19_8a86:
            ii(0x19_8a86, 1);  pop(si);                                /* pop si */
            ii(0x19_8a87, 1);  pop(di);                                /* pop di */
            ii(0x19_8a88, 1);  leave();                                /* leave */
            ii(0x19_8a89, 1);  retf();                                 /* retf */
        }
    }
}
