using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ab16-8cc311e3")]
        public void Method_0017_ab16()
        {
            ii(0x17_ab16, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x17_ab1a, 1);  push(ds);                               /* push ds */
            ii(0x17_ab1b, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_ab1e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_ab20, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_ab22, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_ab25, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_ab28, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x17_ab2b, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_ab2e, 5);  and(memb[es, bx + 44], -2 /* 0xfe */);  /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_ab33, 6);  test(memw[es, bx + 10], 0xffff);        /* test word [es:bx+0xa], 0xffff */
            ii(0x17_ab39, 2);  if(jz(0x17_ab44, 9)) goto l_0x17_ab44;  /* jz 0xab44 */
            ii(0x17_ab3b, 5);  mov(memw[ss, bp - 10], 0x8023);         /* mov word [bp-0xa], 0x8023 */
            ii(0x17_ab40, 3);  jmp(0x17_ac16, 0xd3); goto l_0x17_ac16; /* jmp 0xac16 */
        //  ii(0x17_ab43, 1);  nop();                                  /* nop */
        l_0x17_ab44:
            ii(0x17_ab44, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_ab47, 4);  mov(ax, memw[es, bx + 8]);              /* mov ax, [es:bx+0x8] */
            ii(0x17_ab4b, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x17_ab4e, 1);  push(ax);                               /* push ax */
            ii(0x17_ab4f, 1);  push(cs);                               /* push cs */
            ii(0x17_ab50, 3);  call(0x17_c79c, 0x1c49);                /* call 0xc79c */
            ii(0x17_ab53, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_ab56, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x17_ab59, 3);  mov(memw[ss, bp - 12], dx);             /* mov [bp-0xc], dx */
            ii(0x17_ab5c, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x17_ab5f, 2);  if(jnz(0x17_ab6e, 0xd)) goto l_0x17_ab6e;/* jnz 0xab6e */
            ii(0x17_ab61, 2);  cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x17_ab63, 2);  if(jnz(0x17_ab6e, 9)) goto l_0x17_ab6e; /* jnz 0xab6e */
            ii(0x17_ab65, 5);  mov(memw[ss, bp - 10], 0x8023);         /* mov word [bp-0xa], 0x8023 */
            ii(0x17_ab6a, 3);  jmp(0x17_ac16, 0xa9); goto l_0x17_ac16; /* jmp 0xac16 */
        //  ii(0x17_ab6d, 1);  nop();                                  /* nop */
        l_0x17_ab6e:
            ii(0x17_ab6e, 3);  add(ax, 0);                             /* add ax, 0x0 */
            ii(0x17_ab71, 3);  adc(dx, 1);                             /* adc dx, 0x1 */
            ii(0x17_ab74, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_ab76, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_ab78, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_ab7a, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_ab7c, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_ab7e, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_ab80, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_ab82, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_ab84, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_ab86, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_ab88, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_ab8a, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_ab8c, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_ab8f, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
        l_0x17_ab92:
            ii(0x17_ab92, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x17_ab95, 3);  push(memw[ss, bp - 14]);                /* push word [bp-0xe] */
            ii(0x17_ab98, 4);  push(memw[ds, 0x4ff6]);                 /* push word [0x4ff6] */
            ii(0x17_ab9c, 4);  push(memw[ds, 0x4ff4]);                 /* push word [0x4ff4] */
            ii(0x17_aba0, 3);  call(0x17_90c4, -0x1adf);               /* call 0x90c4 */
            ii(0x17_aba3, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_aba6, 3);  cmp(ax, memw[ss, bp - 20]);             /* cmp ax, [bp-0x14] */
            ii(0x17_aba9, 2);  if(jnz(0x17_abbe, 0x13)) goto l_0x17_abbe;/* jnz 0xabbe */
            ii(0x17_abab, 4);  add(memw[ss, bp - 4], 1);               /* add word [bp-0x4], 0x1 */
            ii(0x17_abaf, 4);  adc(memw[ss, bp - 2], 0);               /* adc word [bp-0x2], 0x0 */
            ii(0x17_abb3, 4);  add(memw[ss, bp - 14], 1);              /* add word [bp-0xe], 0x1 */
            ii(0x17_abb7, 4);  adc(memw[ss, bp - 12], 0);              /* adc word [bp-0xc], 0x0 */
            ii(0x17_abbb, 2);  jmp(0x17_ab92, -0x2b); goto l_0x17_ab92;/* jmp 0xab92 */
        //  ii(0x17_abbd, 1);  nop();                                  /* nop */
        l_0x17_abbe:
            ii(0x17_abbe, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_abc1, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_abc4, 4);  mov(memw[es, bx + 20], ax);             /* mov [es:bx+0x14], ax */
            ii(0x17_abc8, 6);  mov(memw[es, bx + 22], 0);              /* mov word [es:bx+0x16], 0x0 */
            ii(0x17_abce, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x17_abd1, 4);  mov(memw[es, bx + 28], ax);             /* mov [es:bx+0x1c], ax */
            ii(0x17_abd5, 6);  mov(memw[es, bx + 30], 0);              /* mov word [es:bx+0x1e], 0x0 */
            ii(0x17_abdb, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_abde, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_abe1, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_abe3, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_abe5, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_abe7, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_abe9, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_abeb, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_abed, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_abef, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_abf1, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_abf3, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_abf5, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_abf7, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_abf9, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x17_abfc, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
            ii(0x17_abff, 4);  mov(memw[es, bx + 8], dx);              /* mov [es:bx+0x8], dx */
            ii(0x17_ac03, 6);  mov(memw[es, bx + 10], 0);              /* mov word [es:bx+0xa], 0x0 */
            ii(0x17_ac09, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_ac0c, 4);  mov(memw[es, bx + 4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x17_ac10, 6);  mov(memw[es, bx + 6], 0);               /* mov word [es:bx+0x6], 0x0 */
        l_0x17_ac16:
            ii(0x17_ac16, 4);  cmp(memw[ss, bp - 10], 0);              /* cmp word [bp-0xa], 0x0 */
            ii(0x17_ac1a, 2);  if(jz(0x17_ac30, 0x14)) goto l_0x17_ac30;/* jz 0xac30 */
            ii(0x17_ac1c, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x17_ac1f, 1);  cwd();                                  /* cwd */
            ii(0x17_ac20, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_ac23, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x17_ac27, 4);  mov(memw[es, bx + 34], dx);             /* mov [es:bx+0x22], dx */
            ii(0x17_ac2b, 5);  or(memb[es, bx + 44], 1);               /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_ac30:
            ii(0x17_ac30, 1);  pop(ds);                                /* pop ds */
            ii(0x17_ac31, 1);  leave();                                /* leave */
            ii(0x17_ac32, 1);  retf();                                 /* retf */
        }
    }
}
