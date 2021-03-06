using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_7dc0-8c3521ec")]
        public void Method_0019_7dc0()
        {
            ii(0x19_7dc0, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_7dc4, 1);  push(di);                               /* push di */
            ii(0x19_7dc5, 1);  push(si);                               /* push si */
            ii(0x19_7dc6, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_7dcb, 4);  cmp(memw[ss, bp + 8], 1);               /* cmp word [bp+0x8], 0x1 */
            ii(0x19_7dcf, 2);  if(jz(0x19_7dd4, 3)) goto l_0x19_7dd4;  /* jz 0x7dd4 */
            ii(0x19_7dd1, 3);  jmp(0x19_7de4, 0x10); goto l_0x19_7de4; /* jmp 0x7de4 */
        l_0x19_7dd4:
            ii(0x19_7dd4, 2);  push(0);                                /* push 0x0 */
            ii(0x19_7dd6, 3);  mov(al, memb[ss, bp + 6]);              /* mov al, [bp+0x6] */
            ii(0x19_7dd9, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_7ddb, 1);  push(ax);                               /* push ax */
            ii(0x19_7ddc, 1);  nop();                                  /* nop */
            ii(0x19_7ddd, 1);  push(cs);                               /* push cs */
            ii(0x19_7dde, 3);  call(0x19_606f, -0x1d72);               /* call 0x606f */
            ii(0x19_7de1, 3);  add(sp, 4);                             /* add sp, 0x4 */
        l_0x19_7de4:
            ii(0x19_7de4, 4);  mov(es, memw[ds, 0x3faa]);              /* mov es, [0x3faa] */
            ii(0x19_7de8, 3);  mov(bx, memw[ss, bp + 6]);              /* mov bx, [bp+0x6] */
            ii(0x19_7deb, 5);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_7df0, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_7df2, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_7df4, 3);  mov(al, memb[ss, bp + 8]);              /* mov al, [bp+0x8] */
            ii(0x19_7df7, 3);  mov(bx, memw[ss, bp + 6]);              /* mov bx, [bp+0x6] */
            ii(0x19_7dfa, 5);  mov(memb[es, bx + 2], al);              /* mov [es:bx+0x2], al */
            ii(0x19_7dff, 3);  jmp(0x19_7e10, 0xe); goto l_0x19_7e10;  /* jmp 0x7e10 */
        l_0x19_7e02:
            ii(0x19_7e02, 3);  les(bx, memw[ss, bp - 6]);              /* les bx, [bp-0x6] */
            ii(0x19_7e05, 4);  mov(al, memb[es, bx + 1]);              /* mov al, [es:bx+0x1] */
            ii(0x19_7e09, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_7e0b, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_7e0d, 3);  inc(memw[ss, bp - 2]);                  /* inc word [bp-0x2] */
        l_0x19_7e10:
            ii(0x19_7e10, 3);  cmp(memw[ss, bp + 8], si);              /* cmp [bp+0x8], si */
            ii(0x19_7e13, 2);  if(jnz(0x19_7e18, 3)) goto l_0x19_7e18; /* jnz 0x7e18 */
            ii(0x19_7e15, 3);  jmp(0x19_7e40, 0x28); goto l_0x19_7e40; /* jmp 0x7e40 */
        l_0x19_7e18:
            ii(0x19_7e18, 4);  mov(es, memw[ds, 0x3fa2]);              /* mov es, [0x3fa2] */
            ii(0x19_7e1c, 4);  mov(ax, memw[es, 0x122]);               /* mov ax, [es:0x122] */
            ii(0x19_7e20, 5);  mov(dx, memw[es, 0x124]);               /* mov dx, [es:0x124] */
            ii(0x19_7e25, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x19_7e27, 3);  shl(cx, 3);                             /* shl cx, 0x3 */
            ii(0x19_7e2a, 2);  add(ax, cx);                            /* add ax, cx */
            ii(0x19_7e2c, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_7e2f, 3);  mov(memw[ss, bp - 4], dx);              /* mov [bp-0x4], dx */
            ii(0x19_7e32, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x19_7e35, 5);  call_far_abs(0x80, 0xce0);              /* call word 0x80:0xce0 */
            ii(0x19_7e3a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_7e3d, 3);  jmp(0x19_7e02, -0x3e); goto l_0x19_7e02;/* jmp 0x7e02 */
        l_0x19_7e40:
            ii(0x19_7e40, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_7e43, 3);  jmp(0x19_7e46, 0); goto l_0x19_7e46;    /* jmp 0x7e46 */
        l_0x19_7e46:
            ii(0x19_7e46, 1);  pop(si);                                /* pop si */
            ii(0x19_7e47, 1);  pop(di);                                /* pop di */
            ii(0x19_7e48, 1);  leave();                                /* leave */
            ii(0x19_7e49, 1);  retf();                                 /* retf */
        }
    }
}
