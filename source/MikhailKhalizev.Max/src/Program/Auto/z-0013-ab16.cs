using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a40e7b8-9ec8-4f29-b58d-4b67a3aed623")]
        public void Method_0013_ab16()
        {
            ii(0x13_ab16, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x13_ab1a, 1); pushw(ds);                                /* push ds */
            ii(0x13_ab1b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ab1e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ab20, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_ab22, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_ab25, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_ab28, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_ab2b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ab2e, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_ab33, 6); test(memw_a16[es, bx + 0xa], 0xffff);     /* test word [es:bx+0xa], 0xffff */
            ii(0x13_ab39, 2); if(jzw(0x13_ab44, 0x9)) goto l_0x13_ab44; /* jz 0xab44 */
            ii(0x13_ab3b, 5); mov(memw_a16[ss, bp - 0xa], 0x8023);      /* mov word [bp-0xa], 0x8023 */
            ii(0x13_ab40, 3); jmpw(0x13_ac16, 0xd3); goto l_0x13_ac16;  /* jmp 0xac16 */
        //  ii(0x13_ab43, 1); Недостижимый код.
l_0x13_ab44:
            ii(0x13_ab44, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ab47, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x13_ab4b, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x13_ab4e, 1); pushw(ax);                                /* push ax */
            ii(0x13_ab4f, 1); pushw(cs);                                /* push cs */
            ii(0x13_ab50, 3); callw(0x13_c79c, 0x1c49);                 /* call 0xc79c */
            ii(0x13_ab53, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_ab56, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_ab59, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x13_ab5c, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_ab5f, 2); if(jnzw(0x13_ab6e, 0xd)) goto l_0x13_ab6e; /* jnz 0xab6e */
            ii(0x13_ab61, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_ab63, 2); if(jnzw(0x13_ab6e, 0x9)) goto l_0x13_ab6e; /* jnz 0xab6e */
            ii(0x13_ab65, 5); mov(memw_a16[ss, bp - 0xa], 0x8023);      /* mov word [bp-0xa], 0x8023 */
            ii(0x13_ab6a, 3); jmpw(0x13_ac16, 0xa9); goto l_0x13_ac16;  /* jmp 0xac16 */
        //  ii(0x13_ab6d, 1); Недостижимый код.
l_0x13_ab6e:
            ii(0x13_ab6e, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_ab71, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_ab74, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_ab76, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_ab78, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_ab7a, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_ab7c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_ab7e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_ab80, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_ab82, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_ab84, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_ab86, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_ab88, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_ab8a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_ab8c, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_ab8f, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x13_ab92:
            ii(0x13_ab92, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x13_ab95, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x13_ab98, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_ab9c, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_aba0, 3); callw(0x13_90c4, -0x1adf);                /* call 0x90c4 */
            ii(0x13_aba3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_aba6, 3); cmp(ax, memw_a16[ss, bp - 0x14]);         /* cmp ax, [bp-0x14] */
            ii(0x13_aba9, 2); if(jnzw(0x13_abbe, 0x13)) goto l_0x13_abbe; /* jnz 0xabbe */
            ii(0x13_abab, 4); add(memw_a16[ss, bp - 0x4], 0x1);         /* add word [bp-0x4], 0x1 */
            ii(0x13_abaf, 4); adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
            ii(0x13_abb3, 4); add(memw_a16[ss, bp - 0xe], 0x1);         /* add word [bp-0xe], 0x1 */
            ii(0x13_abb7, 4); adc(memw_a16[ss, bp - 0xc], 0);           /* adc word [bp-0xc], 0x0 */
            ii(0x13_abbb, 2); jmpw(0x13_ab92, -0x2b); goto l_0x13_ab92; /* jmp 0xab92 */
        //  ii(0x13_abbd, 1); Недостижимый код.
l_0x13_abbe:
            ii(0x13_abbe, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_abc1, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_abc4, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x13_abc8, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x13_abce, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_abd1, 4); mov(memw_a16[es, bx + 0x1c], ax);         /* mov [es:bx+0x1c], ax */
            ii(0x13_abd5, 6); mov(memw_a16[es, bx + 0x1e], 0);          /* mov word [es:bx+0x1e], 0x0 */
            ii(0x13_abdb, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_abde, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_abe1, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_abe3, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_abe5, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_abe7, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_abe9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_abeb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_abed, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_abef, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_abf1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_abf3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_abf5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_abf7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_abf9, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_abfc, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x13_abff, 4); mov(memw_a16[es, bx + 0x8], dx);          /* mov [es:bx+0x8], dx */
            ii(0x13_ac03, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x13_ac09, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_ac0c, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x13_ac10, 6); mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
        l_0x13_ac16:
            ii(0x13_ac16, 4); cmp(memw_a16[ss, bp - 0xa], 0);           /* cmp word [bp-0xa], 0x0 */
            ii(0x13_ac1a, 2); if(jzw(0x13_ac30, 0x14)) goto l_0x13_ac30; /* jz 0xac30 */
            ii(0x13_ac1c, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_ac1f, 1); cwd();                                    /* cwd */
            ii(0x13_ac20, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ac23, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x13_ac27, 4); mov(memw_a16[es, bx + 0x22], dx);         /* mov [es:bx+0x22], dx */
            ii(0x13_ac2b, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x13_ac30:
            ii(0x13_ac30, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ac31, 1); leavew();                                 /* leave */
            ii(0x13_ac32, 1); retfw(); return;                          /* retf */
        }
    }
}
