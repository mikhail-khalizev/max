using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_053f-9d1d7374")]
        public void Method_001a_053f()
        {
            ii(0x1a_053f, 4);  enter(0xa8, 0);                         /* enter 0xa8, 0x0 */
            ii(0x1a_0543, 1);  push(ds);                               /* push ds */
            ii(0x1a_0544, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_0547, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_0549, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_054b, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x1a_054e, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_0551, 1);  push(ds);                               /* push ds */
            ii(0x1a_0552, 3);  push(0x3756);                           /* push 0x3756 */
            ii(0x1a_0555, 5);  call_far_abs(0x80, 0x5ba0);             /* call word 0x80:0x5ba0 */
            ii(0x1a_055a, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_055b, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_055c, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x1a_055e, 2);  if(jz(0x1a_0579, 0x19)) goto l_0x1a_0579;/* jz 0x579 */
            ii(0x1a_0560, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x1a_0563, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x1a_0566, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_0569, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_056c, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_056f, 5);  call_far_abs(0x90, 0x5a3);              /* call word 0x90:0x5a3 */
            ii(0x1a_0574, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_0576, 3);  jmp(0x1a_0605, 0x8c); goto l_0x1a_0605; /* jmp 0x605 */
        l_0x1a_0579:
            ii(0x1a_0579, 3);  mov(ax, memw[ds, 0x32aa]);              /* mov ax, [0x32aa] */
            ii(0x1a_057c, 4);  or(ax, memw[ds, 0x32a8]);               /* or ax, [0x32a8] */
            ii(0x1a_0580, 2);  if(jz(0x1a_05a2, 0x20)) goto l_0x1a_05a2;/* jz 0x5a2 */
            ii(0x1a_0582, 3);  lea(ax, memw[ss, bp - 4]);              /* lea ax, [bp-0x4] */
            ii(0x1a_0585, 1);  push(ss);                               /* push ss */
            ii(0x1a_0586, 1);  push(ax);                               /* push ax */
            ii(0x1a_0587, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_058a, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_058d, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x1a_0590, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x1a_0593, 4);  call_far_ind(memw[ds, 0x32a8]);         /* call far word [0x32a8] */
            ii(0x1a_0597, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x1a_059a, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_059d, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x1a_05a0, 2);  jmp(0x1a_0605, 0x63); goto l_0x1a_0605; /* jmp 0x605 */
        l_0x1a_05a2:
            ii(0x1a_05a2, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x1a_05a5, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x1a_05a8, 1);  push(cs);                               /* push cs */
            ii(0x1a_05a9, 3);  call(0x1a_0409, -0x1a3);                /* call 0x409 */
            ii(0x1a_05ac, 4);  mov(memw[ss, bp - 136], ax);            /* mov [bp-0x88], ax */
            ii(0x1a_05b0, 4);  mov(memw[ss, bp - 134], dx);            /* mov [bp-0x86], dx */
            ii(0x1a_05b4, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x1a_05b6, 2);  if(jz(0x1a_0602, 0x4a)) goto l_0x1a_0602;/* jz 0x602 */
            ii(0x1a_05b8, 4);  lea(ax, memw[ss, bp - 132]);            /* lea ax, [bp-0x84] */
            ii(0x1a_05bc, 1);  push(ss);                               /* push ss */
            ii(0x1a_05bd, 1);  push(ax);                               /* push ax */
            ii(0x1a_05be, 4);  push(memw[ss, bp - 134]);               /* push word [bp-0x86] */
            ii(0x1a_05c2, 4);  push(memw[ss, bp - 136]);               /* push word [bp-0x88] */
            ii(0x1a_05c6, 3);  call(0x19_ff6c, -0x65d);                /* call 0xff6c */
            ii(0x1a_05c9, 1);  push(dx);                               /* push dx */
            ii(0x1a_05ca, 1);  push(ax);                               /* push ax */
            ii(0x1a_05cb, 5);  call_far_abs(0x80, 0x4508);             /* call word 0x80:0x4508 */
            ii(0x1a_05d0, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_05d1, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_05d2, 4);  lea(ax, memw[ss, bp - 168]);            /* lea ax, [bp-0xa8] */
            ii(0x1a_05d6, 1);  push(ss);                               /* push ss */
            ii(0x1a_05d7, 1);  push(ax);                               /* push ax */
            ii(0x1a_05d8, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_05db, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_05de, 3);  call(0x19_ff6c, -0x675);                /* call 0xff6c */
            ii(0x1a_05e1, 1);  push(dx);                               /* push dx */
            ii(0x1a_05e2, 1);  push(ax);                               /* push ax */
            ii(0x1a_05e3, 5);  call_far_abs(0x80, 0x4508);             /* call word 0x80:0x4508 */
            ii(0x1a_05e8, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_05e9, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_05ea, 4);  lea(ax, memw[ss, bp - 132]);            /* lea ax, [bp-0x84] */
            ii(0x1a_05ee, 1);  push(ss);                               /* push ss */
            ii(0x1a_05ef, 1);  push(ax);                               /* push ax */
            ii(0x1a_05f0, 4);  lea(ax, memw[ss, bp - 168]);            /* lea ax, [bp-0xa8] */
            ii(0x1a_05f4, 1);  push(ss);                               /* push ss */
            ii(0x1a_05f5, 1);  push(ax);                               /* push ax */
            ii(0x1a_05f6, 3);  call(0x19_ffd5, -0x624);                /* call 0xffd5 */
            ii(0x1a_05f9, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x1a_05fb, 2);  if(jz(0x1a_0602, 5)) goto l_0x1a_0602;  /* jz 0x602 */
            ii(0x1a_05fd, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x1a_0600, 2);  jmp(0x1a_0604, 2); goto l_0x1a_0604;    /* jmp 0x604 */
        l_0x1a_0602:
            ii(0x1a_0602, 2);  sub(ax, ax);                            /* sub ax, ax */
        l_0x1a_0604:
            ii(0x1a_0604, 1);  cwd();                                  /* cwd */
        l_0x1a_0605:
            ii(0x1a_0605, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0606, 1);  leave();                                /* leave */
            ii(0x1a_0607, 3);  retf(0xa);                              /* retf 0xa */
        }
    }
}
