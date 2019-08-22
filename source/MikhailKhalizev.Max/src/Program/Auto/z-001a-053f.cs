using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_053f-9d1d7374")]
        public void Method_001a_053f()
        {
            ii(0x1a_053f, 4); enterw(0xa8, 0);                          /* enter 0xa8, 0x0 */
            ii(0x1a_0543, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0544, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0547, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0549, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_054b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x1a_054e, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_0551, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0552, 3); pushw(0x3756);                            /* push 0x3756 */
            ii(0x1a_0555, 5); callw_far_abs(0x80, 0x5ba0);              /* call word 0x80:0x5ba0 */
            ii(0x1a_055a, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_055b, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_055c, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_055e, 2); if(jzw(0x1a_0579, 0x19)) goto l_0x1a_0579; /* jz 0x579 */
            ii(0x1a_0560, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x1a_0563, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_0566, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_0569, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_056c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_056f, 5); callw_far_abs(0x90, 0x5a3);               /* call word 0x90:0x5a3 */
            ii(0x1a_0574, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x1a_0576, 3); jmpw(0x1a_0605, 0x8c); goto l_0x1a_0605;  /* jmp 0x605 */
        l_0x1a_0579:
            ii(0x1a_0579, 3); mov(ax, memw_a16[ds, 0x32aa]);            /* mov ax, [0x32aa] */
            ii(0x1a_057c, 4); or(ax, memw_a16[ds, 0x32a8]);             /* or ax, [0x32a8] */
            ii(0x1a_0580, 2); if(jzw(0x1a_05a2, 0x20)) goto l_0x1a_05a2; /* jz 0x5a2 */
            ii(0x1a_0582, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x1a_0585, 1); pushw(ss);                                /* push ss */
            ii(0x1a_0586, 1); pushw(ax);                                /* push ax */
            ii(0x1a_0587, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_058a, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_058d, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x1a_0590, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_0593, 4); callw_a16_far_ind(ds, 0x32a8);            /* call far word [0x32a8] */
            ii(0x1a_0597, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x1a_059a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1a_059d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x1a_05a0, 2); jmpw(0x1a_0605, 0x63); goto l_0x1a_0605;  /* jmp 0x605 */
        l_0x1a_05a2:
            ii(0x1a_05a2, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x1a_05a5, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_05a8, 1); pushw(cs);                                /* push cs */
            ii(0x1a_05a9, 3); callw(0x1a_0409, -0x1a3);                 /* call 0x409 */
            ii(0x1a_05ac, 4); mov(memw_a16[ss, bp - 0x88], ax);         /* mov [bp-0x88], ax */
            ii(0x1a_05b0, 4); mov(memw_a16[ss, bp - 0x86], dx);         /* mov [bp-0x86], dx */
            ii(0x1a_05b4, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_05b6, 2); if(jzw(0x1a_0602, 0x4a)) goto l_0x1a_0602; /* jz 0x602 */
            ii(0x1a_05b8, 4); lea(ax, bp - 0x84);                       /* lea ax, [bp-0x84] */
            ii(0x1a_05bc, 1); pushw(ss);                                /* push ss */
            ii(0x1a_05bd, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05be, 4); pushw(memw_a16[ss, bp - 0x86]);           /* push word [bp-0x86] */
            ii(0x1a_05c2, 4); pushw(memw_a16[ss, bp - 0x88]);           /* push word [bp-0x88] */
            ii(0x1a_05c6, 3); callw(0x19_ff6c, -0x65d);                 /* call 0xff6c */
            ii(0x1a_05c9, 1); pushw(dx);                                /* push dx */
            ii(0x1a_05ca, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05cb, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x1a_05d0, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_05d1, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_05d2, 4); lea(ax, bp - 0xa8);                       /* lea ax, [bp-0xa8] */
            ii(0x1a_05d6, 1); pushw(ss);                                /* push ss */
            ii(0x1a_05d7, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05d8, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_05db, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_05de, 3); callw(0x19_ff6c, -0x675);                 /* call 0xff6c */
            ii(0x1a_05e1, 1); pushw(dx);                                /* push dx */
            ii(0x1a_05e2, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05e3, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x1a_05e8, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_05e9, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_05ea, 4); lea(ax, bp - 0x84);                       /* lea ax, [bp-0x84] */
            ii(0x1a_05ee, 1); pushw(ss);                                /* push ss */
            ii(0x1a_05ef, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05f0, 4); lea(ax, bp - 0xa8);                       /* lea ax, [bp-0xa8] */
            ii(0x1a_05f4, 1); pushw(ss);                                /* push ss */
            ii(0x1a_05f5, 1); pushw(ax);                                /* push ax */
            ii(0x1a_05f6, 3); callw(0x19_ffd5, -0x624);                 /* call 0xffd5 */
            ii(0x1a_05f9, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_05fb, 2); if(jzw(0x1a_0602, 0x5)) goto l_0x1a_0602; /* jz 0x602 */
            ii(0x1a_05fd, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x1a_0600, 2); jmpw(0x1a_0604, 0x2); goto l_0x1a_0604;   /* jmp 0x604 */
        l_0x1a_0602:
            ii(0x1a_0602, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x1a_0604:
            ii(0x1a_0604, 1); cwd();                                    /* cwd */
        l_0x1a_0605:
            ii(0x1a_0605, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_0606, 1); leavew();                                 /* leave */
            ii(0x1a_0607, 3); retfw(0xa); return;                       /* retf 0xa */
        }
    }
}