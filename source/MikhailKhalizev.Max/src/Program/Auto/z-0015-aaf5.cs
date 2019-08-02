using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9146137-e386-439f-b6d5-a2e3d676f898")]
        public void Method_0015_aaf5()
        {
            ii(0x15_aaf5, 4); enterw(0x50, 0);                          /* enter 0x50, 0x0 */
            ii(0x15_aaf9, 1); pushw(di);                                /* push di */
            ii(0x15_aafa, 1); pushw(si);                                /* push si */
            ii(0x15_aafb, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_aafe, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x15_ab02, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x15_ab06, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_ab09, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x15_ab0c, 4); mov(cx, memw_a16[es, bx + 0x1c]);         /* mov cx, [es:bx+0x1c] */
            ii(0x15_ab10, 4); mov(si, memw_a16[es, bx + 0x1e]);         /* mov si, [es:bx+0x1e] */
            ii(0x15_ab14, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_ab17, 3); mov(memw_a16[ss, bp - 0x2a], si);         /* mov [bp-0x2a], si */
            ii(0x15_ab1a, 2); mov(es, si);                              /* mov es, si */
            ii(0x15_ab1c, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x15_ab1e, 4); mov(di, memw_a16[es, bx + 0x28]);         /* mov di, [es:bx+0x28] */
            ii(0x15_ab22, 3); mov(memw_a16[ss, bp - 0x28], di);         /* mov [bp-0x28], di */
            ii(0x15_ab25, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_ab2a, 2); sub(di, di);                              /* sub di, di */
            ii(0x15_ab2c, 3); mov(memw_a16[ss, bp - 0x44], di);         /* mov [bp-0x44], di */
            ii(0x15_ab2f, 3); mov(memw_a16[ss, bp - 0x46], di);         /* mov [bp-0x46], di */
            ii(0x15_ab32, 3); mov(memw_a16[ss, bp - 0x24], di);         /* mov [bp-0x24], di */
            ii(0x15_ab35, 3); mov(memw_a16[ss, bp - 0x26], di);         /* mov [bp-0x26], di */
            ii(0x15_ab38, 3); mov(memw_a16[ss, bp - 0x20], di);         /* mov [bp-0x20], di */
            ii(0x15_ab3b, 3); mov(memw_a16[ss, bp - 0x22], di);         /* mov [bp-0x22], di */
            ii(0x15_ab3e, 3); mov(memw_a16[ss, bp - 0x34], di);         /* mov [bp-0x34], di */
            ii(0x15_ab41, 3); mov(memw_a16[ss, bp - 0x36], di);         /* mov [bp-0x36], di */
            ii(0x15_ab44, 3); mov(memw_a16[ss, bp - 0x4e], di);         /* mov [bp-0x4e], di */
            ii(0x15_ab47, 3); mov(memw_a16[ss, bp - 0x50], di);         /* mov [bp-0x50], di */
            ii(0x15_ab4a, 5); test(memb_a16[es, bx + 0x10], 0x10);      /* test byte [es:bx+0x10], 0x10 */
            ii(0x15_ab4f, 2); if(jzw(0x15_ab68, 0x17)) goto l_0x15_ab68; /* jz 0xab68 */
            ii(0x15_ab51, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_ab53, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_ab55, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_ab59, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_ab5d, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_ab60, 3); mov(memw_a16[ss, bp - 0x4e], dx);         /* mov [bp-0x4e], dx */
            ii(0x15_ab63, 5); mov(memb_a16[ds, 0x19f3], 0x2);           /* mov byte [0x19f3], 0x2 */
        l_0x15_ab68:
            ii(0x15_ab68, 5); cmp(memb_a16[ds, 0x19f3], 0);             /* cmp byte [0x19f3], 0x0 */
            ii(0x15_ab6d, 2); if(jzw(0x15_ab74, 0x5)) goto l_0x15_ab74; /* jz 0xab74 */
            ii(0x15_ab6f, 5); mov(memw_a16[ss, bp + 0x4], 0x1);         /* mov word [bp+0x4], 0x1 */
        l_0x15_ab74:
            ii(0x15_ab74, 3); mov(al, memb_a16[ds, 0x19f3]);            /* mov al, [0x19f3] */
            ii(0x15_ab77, 1); cbw();                                    /* cbw */
            ii(0x15_ab78, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_ab7b, 4); mov(memw_a16[es, bx + 0x5c], ax);         /* mov [es:bx+0x5c], ax */
            ii(0x15_ab7f, 3); mov(memw_a16[ss, bp - 0x38], di);         /* mov [bp-0x38], di */
            ii(0x15_ab82, 3); cmp(memw_a16[ss, bp + 0x4], di);          /* cmp [bp+0x4], di */
            ii(0x15_ab85, 2); if(jzw(0x15_abed, 0x66)) goto l_0x15_abed; /* jz 0xabed */
            ii(0x15_ab87, 1); pushw(es);                                /* push es */
            ii(0x15_ab88, 1); pushw(bx);                                /* push bx */
            ii(0x15_ab89, 1); pushw(di);                                /* push di */
            ii(0x15_ab8a, 3); callw(0x15_a8a9, -0x2e4);                 /* call 0xa8a9 */
            ii(0x15_ab8d, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_ab90, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x15_ab93, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ab96, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ab99, 3); callw(0x15_a7e5, -0x3b7);                 /* call 0xa7e5 */
            ii(0x15_ab9c, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_ab9f, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
        l_0x15_aba2:
            ii(0x15_aba2, 5); cmp(memb_a16[ds, 0x19f2], 0);             /* cmp byte [0x19f2], 0x0 */
            ii(0x15_aba7, 2); if(jzw(0x15_abc2, 0x19)) goto l_0x15_abc2; /* jz 0xabc2 */
            ii(0x15_aba9, 5); cmp(memb_a16[ds, 0x19f3], 0);             /* cmp byte [0x19f3], 0x0 */
            ii(0x15_abae, 2); if(jzw(0x15_abc2, 0x12)) goto l_0x15_abc2; /* jz 0xabc2 */
            ii(0x15_abb0, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_abb3, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_abb6, 3); add(memw_a16[ss, bp - 0x12], ax);         /* add [bp-0x12], ax */
            ii(0x15_abb9, 3); adc(memw_a16[ss, bp - 0x10], dx);         /* adc [bp-0x10], dx */
            ii(0x15_abbc, 3); add(memw_a16[ss, bp - 0x16], ax);         /* add [bp-0x16], ax */
            ii(0x15_abbf, 3); adc(memw_a16[ss, bp - 0x14], dx);         /* adc [bp-0x14], dx */
        l_0x15_abc2:
            ii(0x15_abc2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_abc5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_abc8, 4); cmp(memw_a16[ss, bp + 0x4], 0x1);         /* cmp word [bp+0x4], 0x1 */
            ii(0x15_abcc, 1); cmc();                                    /* cmc */
            ii(0x15_abcd, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_abcf, 2); and(al, 0xfb);                            /* and al, 0xfb */
            ii(0x15_abd1, 1); pushw(ax);                                /* push ax */
            ii(0x15_abd2, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_abd4, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_abd7, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_abda, 3); callw(0x15_c975, 0x1d98);                 /* call 0xc975 */
            ii(0x15_abdd, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x15_abe0, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x15_abe3, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_abe5, 2); if(jnzw(0x15_ac0c, 0x25)) goto l_0x15_ac0c; /* jnz 0xac0c */
        l_0x15_abe7:
            ii(0x15_abe7, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x15_abea, 3); jmpw(0x15_b222, 0x635); goto l_0x15_b222; /* jmp 0xb222 */
        l_0x15_abed:
            ii(0x15_abed, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_abf0, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_abf3, 3); mov(ax, memw_a16[ss, bp - 0x38]);         /* mov ax, [bp-0x38] */
            ii(0x15_abf6, 1); inc(ax);                                  /* inc ax */
            ii(0x15_abf7, 1); pushw(ax);                                /* push ax */
            ii(0x15_abf8, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_abfa, 3); callw(0x15_a8a9, -0x354);                 /* call 0xa8a9 */
            ii(0x15_abfd, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_ac00, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x15_ac03, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_ac05, 2); if(jnzw(0x15_aba2, -0x65)) goto l_0x15_aba2; /* jnz 0xaba2 */
            ii(0x15_ac07, 3); mov(memw_a16[ss, bp - 0x38], si);         /* mov [bp-0x38], si */
            ii(0x15_ac0a, 2); jmpw(0x15_abed, -0x1f); goto l_0x15_abed; /* jmp 0xabed */
        l_0x15_ac0c:
            ii(0x15_ac0c, 5); cmp(memb_a16[ds, 0x19f2], 0);             /* cmp byte [0x19f2], 0x0 */
            ii(0x15_ac11, 2); if(jnzw(0x15_ac16, 0x3)) goto l_0x15_ac16; /* jnz 0xac16 */
            ii(0x15_ac13, 3); jmpw(0x15_acb8, 0xa2); goto l_0x15_acb8;  /* jmp 0xacb8 */
        l_0x15_ac16:
            ii(0x15_ac16, 5); cmp(memb_a16[ds, 0x19f3], 0x2);           /* cmp byte [0x19f3], 0x2 */
            ii(0x15_ac1b, 2); if(jnzw(0x15_ac36, 0x19)) goto l_0x15_ac36; /* jnz 0xac36 */
            ii(0x15_ac1d, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x15_ac20, 3); mov(memw_a16[ds, 0x19ea], ax);            /* mov [0x19ea], ax */
            ii(0x15_ac23, 4); mov(memw_a16[ds, 0x19ec], dx);            /* mov [0x19ec], dx */
            ii(0x15_ac27, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_ac2a, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_ac2d, 3); mov(memw_a16[ds, 0x19ee], ax);            /* mov [0x19ee], ax */
            ii(0x15_ac30, 4); mov(memw_a16[ds, 0x19f0], dx);            /* mov [0x19f0], dx */
            ii(0x15_ac34, 2); jmpw(0x15_ac65, 0x2f); goto l_0x15_ac65;  /* jmp 0xac65 */
        l_0x15_ac36:
            ii(0x15_ac36, 5); cmp(memb_a16[ds, 0x19f3], 0x1);           /* cmp byte [0x19f3], 0x1 */
            ii(0x15_ac3b, 2); if(jnzw(0x15_ac57, 0x1a)) goto l_0x15_ac57; /* jnz 0xac57 */
            ii(0x15_ac3d, 6); mov(memw_a16[ds, 0x19ea], 0);             /* mov word [0x19ea], 0x0 */
            ii(0x15_ac43, 6); mov(memw_a16[ds, 0x19ec], 0x1);           /* mov word [0x19ec], 0x1 */
            ii(0x15_ac49, 6); mov(memw_a16[ds, 0x19ee], 0);             /* mov word [0x19ee], 0x0 */
            ii(0x15_ac4f, 6); mov(memw_a16[ds, 0x19f0], 0x2000);        /* mov word [0x19f0], 0x2000 */
            ii(0x15_ac55, 2); jmpw(0x15_ac65, 0xe); goto l_0x15_ac65;   /* jmp 0xac65 */
        l_0x15_ac57:
            ii(0x15_ac57, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_ac59, 3); mov(memw_a16[ds, 0x19f0], ax);            /* mov [0x19f0], ax */
            ii(0x15_ac5c, 3); mov(memw_a16[ds, 0x19ee], ax);            /* mov [0x19ee], ax */
            ii(0x15_ac5f, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_ac62, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
        l_0x15_ac65:
            ii(0x15_ac65, 4); pushw(memw_a16[ds, 0x19e6]);              /* push word [0x19e6] */
            ii(0x15_ac69, 4); pushw(memw_a16[ds, 0x19ec]);              /* push word [0x19ec] */
            ii(0x15_ac6d, 4); pushw(memw_a16[ds, 0x19ea]);              /* push word [0x19ea] */
            ii(0x15_ac71, 3); mov(ax, memw_a16[ds, 0x19ee]);            /* mov ax, [0x19ee] */
            ii(0x15_ac74, 4); mov(dx, memw_a16[ds, 0x19f0]);            /* mov dx, [0x19f0] */
            ii(0x15_ac78, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_ac7b, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x15_ac7e, 1); pushw(dx);                                /* push dx */
            ii(0x15_ac7f, 1); pushw(ax);                                /* push ax */
            ii(0x15_ac80, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x15_ac83, 3); callw(0x15_cc1a, 0x1f94);                 /* call 0xcc1a */
            ii(0x15_ac86, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x15_ac8a, 4); pushw(memw_a16[ds, 0x19ec]);              /* push word [0x19ec] */
            ii(0x15_ac8e, 4); pushw(memw_a16[ds, 0x19ea]);              /* push word [0x19ea] */
            ii(0x15_ac92, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x15_ac95, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x15_ac98, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_ac9b, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x15_ac9e, 1); pushw(dx);                                /* push dx */
            ii(0x15_ac9f, 1); pushw(ax);                                /* push ax */
            ii(0x15_aca0, 3); pushw(0x9a);                              /* push 0x9a */
            ii(0x15_aca3, 3); callw(0x15_cc1a, 0x1f74);                 /* call 0xcc1a */
            ii(0x15_aca6, 3); pushw(memw_a16[ss, bp - 0x44]);           /* push word [bp-0x44] */
            ii(0x15_aca9, 3); pushw(memw_a16[ss, bp - 0x46]);           /* push word [bp-0x46] */
            ii(0x15_acac, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x15_acaf, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x15_acb2, 3); callw(0x15_ca89, 0x1dd4);                 /* call 0xca89 */
            ii(0x15_acb5, 3); jmpw(0x15_ad8a, 0xd2); goto l_0x15_ad8a;  /* jmp 0xad8a */
        l_0x15_acb8:
            ii(0x15_acb8, 3); mov(ax, memw_a16[ds, 0x19ea]);            /* mov ax, [0x19ea] */
            ii(0x15_acbb, 4); mov(dx, memw_a16[ds, 0x19ec]);            /* mov dx, [0x19ec] */
            ii(0x15_acbf, 3); cmp(memw_a16[ss, bp - 0x44], dx);         /* cmp [bp-0x44], dx */
            ii(0x15_acc2, 2); if(jaw(0x15_acfc, 0x38)) goto l_0x15_acfc; /* ja 0xacfc */
            ii(0x15_acc4, 2); if(jbw(0x15_accb, 0x5)) goto l_0x15_accb; /* jb 0xaccb */
            ii(0x15_acc6, 3); cmp(memw_a16[ss, bp - 0x46], ax);         /* cmp [bp-0x46], ax */
            ii(0x15_acc9, 2); if(jaew(0x15_acfc, 0x31)) goto l_0x15_acfc; /* jae 0xacfc */
        l_0x15_accb:
            ii(0x15_accb, 1); pushw(ds);                                /* push ds */
            ii(0x15_accc, 3); pushw(0x20b1);                            /* push 0x20b1 */
            ii(0x15_accf, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_acd2, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_acd5, 1); nop();                                    /* nop */
            ii(0x15_acd6, 1); pushw(cs);                                /* push cs */
            ii(0x15_acd7, 3); callw(0x15_d52d, 0x2853);                 /* call 0xd52d */
            ii(0x15_acda, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_acdd, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x15_ace0, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x15_ace3, 3); mov(ax, memw_a16[ds, 0x19ea]);            /* mov ax, [0x19ea] */
            ii(0x15_ace6, 4); mov(dx, memw_a16[ds, 0x19ec]);            /* mov dx, [0x19ec] */
            ii(0x15_acea, 3); cmp(memw_a16[ss, bp - 0x44], dx);         /* cmp [bp-0x44], dx */
            ii(0x15_aced, 2); if(jaw(0x15_acfc, 0xd)) goto l_0x15_acfc; /* ja 0xacfc */
            ii(0x15_acef, 2); if(jbw(0x15_acf6, 0x5)) goto l_0x15_acf6; /* jb 0xacf6 */
            ii(0x15_acf1, 3); cmp(memw_a16[ss, bp - 0x46], ax);         /* cmp [bp-0x46], ax */
            ii(0x15_acf4, 2); if(jaew(0x15_acfc, 0x6)) goto l_0x15_acfc; /* jae 0xacfc */
        l_0x15_acf6:
            ii(0x15_acf6, 3); mov(ax, 0x524);                           /* mov ax, 0x524 */
            ii(0x15_acf9, 3); jmpw(0x15_b222, 0x526); goto l_0x15_b222; /* jmp 0xb222 */
        l_0x15_acfc:
            ii(0x15_acfc, 5); cmp(memb_a16[ds, 0x19f3], 0);             /* cmp byte [0x19f3], 0x0 */
            ii(0x15_ad01, 2); if(jnzw(0x15_ad06, 0x3)) goto l_0x15_ad06; /* jnz 0xad06 */
            ii(0x15_ad03, 3); jmpw(0x15_ad8a, 0x84); goto l_0x15_ad8a;  /* jmp 0xad8a */
        l_0x15_ad06:
            ii(0x15_ad06, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_ad09, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_ad0c, 3); add(ax, memw_a16[ss, bp - 0x46]);         /* add ax, [bp-0x46] */
            ii(0x15_ad0f, 3); adc(dx, memw_a16[ss, bp - 0x44]);         /* adc dx, [bp-0x44] */
            ii(0x15_ad12, 4); mov(cx, memw_a16[ds, 0x19ee]);            /* mov cx, [0x19ee] */
            ii(0x15_ad16, 4); mov(bx, memw_a16[ds, 0x19f0]);            /* mov bx, [0x19f0] */
            ii(0x15_ad1a, 4); add(cx, memw_a16[ds, 0x19ea]);            /* add cx, [0x19ea] */
            ii(0x15_ad1e, 4); adc(bx, memw_a16[ds, 0x19ec]);            /* adc bx, [0x19ec] */
            ii(0x15_ad22, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x15_ad24, 2); if(jbw(0x15_ad8a, 0x64)) goto l_0x15_ad8a; /* jb 0xad8a */
            ii(0x15_ad26, 2); if(jaw(0x15_ad2c, 0x4)) goto l_0x15_ad2c; /* ja 0xad2c */
            ii(0x15_ad28, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x15_ad2a, 2); if(jbew(0x15_ad8a, 0x5e)) goto l_0x15_ad8a; /* jbe 0xad8a */
        l_0x15_ad2c:
            ii(0x15_ad2c, 4); pushw(memw_a16[ds, 0x19e6]);              /* push word [0x19e6] */
            ii(0x15_ad30, 4); pushw(memw_a16[ds, 0x19ec]);              /* push word [0x19ec] */
            ii(0x15_ad34, 4); pushw(memw_a16[ds, 0x19ea]);              /* push word [0x19ea] */
            ii(0x15_ad38, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_ad3b, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_ad3e, 4); sub(ax, memw_a16[ds, 0x19ea]);            /* sub ax, [0x19ea] */
            ii(0x15_ad42, 4); sbb(dx, memw_a16[ds, 0x19ec]);            /* sbb dx, [0x19ec] */
            ii(0x15_ad46, 3); add(ax, memw_a16[ss, bp - 0x46]);         /* add ax, [bp-0x46] */
            ii(0x15_ad49, 3); adc(dx, memw_a16[ss, bp - 0x44]);         /* adc dx, [bp-0x44] */
            ii(0x15_ad4c, 4); add(memw_a16[ds, 0x19ee], ax);            /* add [0x19ee], ax */
            ii(0x15_ad50, 4); adc(memw_a16[ds, 0x19f0], dx);            /* adc [0x19f0], dx */
            ii(0x15_ad54, 3); mov(ax, memw_a16[ds, 0x19ee]);            /* mov ax, [0x19ee] */
            ii(0x15_ad57, 4); mov(dx, memw_a16[ds, 0x19f0]);            /* mov dx, [0x19f0] */
            ii(0x15_ad5b, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_ad5e, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x15_ad61, 1); pushw(dx);                                /* push dx */
            ii(0x15_ad62, 1); pushw(ax);                                /* push ax */
            ii(0x15_ad63, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x15_ad66, 3); callw(0x15_cc1a, 0x1eb1);                 /* call 0xcc1a */
            ii(0x15_ad69, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x15_ad6d, 4); pushw(memw_a16[ds, 0x19ec]);              /* push word [0x19ec] */
            ii(0x15_ad71, 4); pushw(memw_a16[ds, 0x19ea]);              /* push word [0x19ea] */
            ii(0x15_ad75, 3); mov(ax, memw_a16[ds, 0x19ee]);            /* mov ax, [0x19ee] */
            ii(0x15_ad78, 4); mov(dx, memw_a16[ds, 0x19f0]);            /* mov dx, [0x19f0] */
            ii(0x15_ad7c, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_ad7f, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x15_ad82, 1); pushw(dx);                                /* push dx */
            ii(0x15_ad83, 1); pushw(ax);                                /* push ax */
            ii(0x15_ad84, 3); pushw(0x9a);                              /* push 0x9a */
            ii(0x15_ad87, 3); callw(0x15_cc1a, 0x1e90);                 /* call 0xcc1a */
        l_0x15_ad8a:
            ii(0x15_ad8a, 1); nop();                                    /* nop */
            ii(0x15_ad8b, 1); pushw(cs);                                /* push cs */
            ii(0x15_ad8c, 3); callw(0x15_daf8, 0x2d69);                 /* call 0xdaf8 */
            ii(0x15_ad8f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_ad92, 5); pushw(memw_a16[es, bx + 0x12a]);          /* push word [es:bx+0x12a] */
            ii(0x15_ad97, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_ad99, 3); pushw(memw_a16[ss, bp - 0x44]);           /* push word [bp-0x44] */
            ii(0x15_ad9c, 3); pushw(memw_a16[ss, bp - 0x46]);           /* push word [bp-0x46] */
            ii(0x15_ad9f, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_ada2, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_ada5, 3); callw(0x15_de46, 0x309e);                 /* call 0xde46 */
            ii(0x15_ada8, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_adab, 4); mov(memw_a16[es, bx + 0x58], ax);         /* mov [es:bx+0x58], ax */
            ii(0x15_adaf, 4); mov(memw_a16[es, bx + 0x5a], dx);         /* mov [es:bx+0x5a], dx */
            ii(0x15_adb3, 3); mov(ax, memw_a16[ss, bp - 0x46]);         /* mov ax, [bp-0x46] */
            ii(0x15_adb6, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x15_adb9, 4); mov(memw_a16[es, bx + 0x4c], ax);         /* mov [es:bx+0x4c], ax */
            ii(0x15_adbd, 4); mov(memw_a16[es, bx + 0x4e], dx);         /* mov [es:bx+0x4e], dx */
            ii(0x15_adc1, 3); mov(al, memb_a16[ss, bp + 0x4]);          /* mov al, [bp+0x4] */
            ii(0x15_adc4, 5); mov(memb_a16[es, bx + 0xc2], al);         /* mov [es:bx+0xc2], al */
            ii(0x15_adc9, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_adcc, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_adcf, 5); mov(memw_a16[es, bx + 0xbe], ax);         /* mov [es:bx+0xbe], ax */
            ii(0x15_add4, 5); mov(memw_a16[es, bx + 0xc0], dx);         /* mov [es:bx+0xc0], dx */
            ii(0x15_add9, 5); cmp(memb_a16[ds, 0x19f2], 0);             /* cmp byte [0x19f2], 0x0 */
            ii(0x15_adde, 2); if(jzw(0x15_adf3, 0x13)) goto l_0x15_adf3; /* jz 0xadf3 */
            ii(0x15_ade0, 5); cmp(memb_a16[ds, 0x19f3], 0);             /* cmp byte [0x19f3], 0x0 */
            ii(0x15_ade5, 2); if(jzw(0x15_adf3, 0xc)) goto l_0x15_adf3; /* jz 0xadf3 */
            ii(0x15_ade7, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_adea, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_aded, 3); add(memw_a16[ss, bp - 0x46], ax);         /* add [bp-0x46], ax */
            ii(0x15_adf0, 3); adc(memw_a16[ss, bp - 0x44], dx);         /* adc [bp-0x44], dx */
        l_0x15_adf3:
            ii(0x15_adf3, 5); mov(memb_a16[ds, 0x19f2], 0);             /* mov byte [0x19f2], 0x0 */
            ii(0x15_adf8, 3); jmpw(0x15_b173, 0x378); goto l_0x15_b173; /* jmp 0xb173 */
        l_0x15_adfb:
            ii(0x15_adfb, 3); mov(ax, memw_a16[ss, bp - 0x44]);         /* mov ax, [bp-0x44] */
            ii(0x15_adfe, 3); or(ax, memw_a16[ss, bp - 0x46]);          /* or ax, [bp-0x46] */
            ii(0x15_ae01, 2); if(jzw(0x15_ae12, 0xf)) goto l_0x15_ae12; /* jz 0xae12 */
            ii(0x15_ae03, 5); cmp(memb_a16[ds, 0x1a03], 0);             /* cmp byte [0x1a03], 0x0 */
            ii(0x15_ae08, 2); if(jzw(0x15_ae10, 0x6)) goto l_0x15_ae10; /* jz 0xae10 */
            ii(0x15_ae0a, 4); test(memb_a16[ss, bp - 0x47], 0x10);      /* test byte [bp-0x47], 0x10 */
            ii(0x15_ae0e, 2); if(jnzw(0x15_ae12, 0x2)) goto l_0x15_ae12; /* jnz 0xae12 */
        l_0x15_ae10:
            ii(0x15_ae10, 2); jmpw(0x15_ae8d, 0x7b); goto l_0x15_ae8d;  /* jmp 0xae8d */
        l_0x15_ae12:
            ii(0x15_ae12, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ae15, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ae18, 3); mov(ax, memw_a16[ss, bp - 0x38]);         /* mov ax, [bp-0x38] */
            ii(0x15_ae1b, 1); inc(ax);                                  /* inc ax */
            ii(0x15_ae1c, 1); pushw(ax);                                /* push ax */
            ii(0x15_ae1d, 3); callw(0x15_a8a9, -0x577);                 /* call 0xa8a9 */
            ii(0x15_ae20, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_ae23, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x15_ae26, 5); cmp(memb_a16[ds, 0x1a03], 0);             /* cmp byte [0x1a03], 0x0 */
            ii(0x15_ae2b, 2); if(jzw(0x15_ae3b, 0xe)) goto l_0x15_ae3b; /* jz 0xae3b */
            ii(0x15_ae2d, 4); test(memb_a16[ss, bp - 0x47], 0x10);      /* test byte [bp-0x47], 0x10 */
            ii(0x15_ae31, 2); if(jzw(0x15_ae3b, 0x8)) goto l_0x15_ae3b; /* jz 0xae3b */
            ii(0x15_ae33, 4); add(memw_a16[ss, bp - 0x16], 0);          /* add word [bp-0x16], 0x0 */
            ii(0x15_ae37, 4); adc(memw_a16[ss, bp - 0x14], 0x1);        /* adc word [bp-0x14], 0x1 */
        l_0x15_ae3b:
            ii(0x15_ae3b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ae3e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ae41, 3); pushw(memw_a16[ss, bp - 0x38]);           /* push word [bp-0x38] */
            ii(0x15_ae44, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_ae46, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_ae49, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_ae4c, 3); callw(0x15_c975, 0x1b26);                 /* call 0xc975 */
            ii(0x15_ae4f, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x15_ae52, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x15_ae55, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_ae57, 2); if(jnzw(0x15_ae5c, 0x3)) goto l_0x15_ae5c; /* jnz 0xae5c */
            ii(0x15_ae59, 3); jmpw(0x15_abe7, -0x275); goto l_0x15_abe7; /* jmp 0xabe7 */
        l_0x15_ae5c:
            ii(0x15_ae5c, 5); cmp(memb_a16[ds, 0x1a03], 0);             /* cmp byte [0x1a03], 0x0 */
            ii(0x15_ae61, 2); if(jzw(0x15_ae7a, 0x17)) goto l_0x15_ae7a; /* jz 0xae7a */
            ii(0x15_ae63, 4); test(memb_a16[ss, bp - 0x47], 0x10);      /* test byte [bp-0x47], 0x10 */
            ii(0x15_ae67, 2); if(jzw(0x15_ae7a, 0x11)) goto l_0x15_ae7a; /* jz 0xae7a */
            ii(0x15_ae69, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x15_ae6c, 3); add(ax, 0xffff);                          /* add ax, 0xffff */
            ii(0x15_ae6f, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_ae72, 5); mov(memw_a16[ss, bp - 0x46], 0);          /* mov word [bp-0x46], 0x0 */
            ii(0x15_ae77, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
        l_0x15_ae7a:
            ii(0x15_ae7a, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_ae7d, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_ae80, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_ae83, 5); add(memw_a16[es, bx + 0xbe], ax);         /* add [es:bx+0xbe], ax */
            ii(0x15_ae88, 5); adc(memw_a16[es, bx + 0xc0], dx);         /* adc [es:bx+0xc0], dx */
        l_0x15_ae8d:
            ii(0x15_ae8d, 4); test(memb_a16[ss, bp - 0x47], 0x10);      /* test byte [bp-0x47], 0x10 */
            ii(0x15_ae91, 2); if(jnzw(0x15_ae96, 0x3)) goto l_0x15_ae96; /* jnz 0xae96 */
            ii(0x15_ae93, 3); jmpw(0x15_af37, 0xa1); goto l_0x15_af37;  /* jmp 0xaf37 */
        l_0x15_ae96:
            ii(0x15_ae96, 4); imul(bx, memw_a16[ss, bp - 0x38], 0x18);  /* imul bx, [bp-0x38], 0x18 */
            ii(0x15_ae9a, 3); add(bx, memw_a16[ss, bp - 0x1a]);         /* add bx, [bp-0x1a] */
            ii(0x15_ae9d, 3); mov(es, memw_a16[ss, bp - 0x18]);         /* mov es, [bp-0x18] */
            ii(0x15_aea0, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_aea2, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x15_aea6, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x15_aeaa, 1); pushw(ax);                                /* push ax */
            ii(0x15_aeab, 1); pushw(ax);                                /* push ax */
            ii(0x15_aeac, 3); pushw(memw_a16[ss, bp - 0x44]);           /* push word [bp-0x44] */
            ii(0x15_aeaf, 3); pushw(memw_a16[ss, bp - 0x46]);           /* push word [bp-0x46] */
            ii(0x15_aeb2, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_aeb6, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_aeb9, 3); callw(0x15_de46, 0x2f8a);                 /* call 0xde46 */
            ii(0x15_aebc, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_aebf, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
            ii(0x15_aec2, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_aec4, 2); if(jnzw(0x15_aec9, 0x3)) goto l_0x15_aec9; /* jnz 0xaec9 */
            ii(0x15_aec6, 3); jmpw(0x15_abe7, -0x2e2); goto l_0x15_abe7; /* jmp 0xabe7 */
        l_0x15_aec9:
            ii(0x15_aec9, 3); mov(ax, memw_a16[ss, bp - 0x30]);         /* mov ax, [bp-0x30] */
            ii(0x15_aecc, 4); imul(bx, memw_a16[ss, bp - 0x38], 0x18);  /* imul bx, [bp-0x38], 0x18 */
            ii(0x15_aed0, 3); add(bx, memw_a16[ss, bp - 0x1a]);         /* add bx, [bp-0x1a] */
            ii(0x15_aed3, 3); mov(es, memw_a16[ss, bp - 0x18]);         /* mov es, [bp-0x18] */
            ii(0x15_aed6, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x15_aeda, 6); mov(memw_a16[es, bx + 0x16], 0);          /* mov word [es:bx+0x16], 0x0 */
            ii(0x15_aee0, 1); pushw(ax);                                /* push ax */
            ii(0x15_aee1, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x15_aee3, 2); mov(di, es);                              /* mov di, es */
            ii(0x15_aee5, 1); nop();                                    /* nop */
            ii(0x15_aee6, 1); pushw(cs);                                /* push cs */
            ii(0x15_aee7, 3); callw(0x16_100b, 0x6121);                 /* call 0x100b */
            ii(0x15_aeea, 1); popw(bx);                                 /* pop bx */
            ii(0x15_aeeb, 2); mov(cl, 0x8);                             /* mov cl, 0x8 */
            ii(0x15_aeed, 5); callw_far_abs(0x80, 0x4378);              /* call word 0x80:0x4378 */
            ii(0x15_aef2, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_aef5, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x15_aef8, 2); mov(es, di);                              /* mov es, di */
            ii(0x15_aefa, 5); test(memb_a16[es, si + 0x9], 0x20);       /* test byte [es:si+0x9], 0x20 */
            ii(0x15_aeff, 2); if(jzw(0x15_af07, 0x6)) goto l_0x15_af07; /* jz 0xaf07 */
            ii(0x15_af01, 4); or(memb_a16[ss, bp - 0x1d], 0x40);        /* or byte [bp-0x1d], 0x40 */
            ii(0x15_af05, 2); jmpw(0x15_af0b, 0x4); goto l_0x15_af0b;   /* jmp 0xaf0b */
        l_0x15_af07:
            ii(0x15_af07, 4); and(memb_a16[ss, bp - 0x1d], -0x41 /* 0xbf */); /* and byte [bp-0x1d], 0xbf */
        l_0x15_af0b:
            ii(0x15_af0b, 4); imul(si, memw_a16[ss, bp - 0x38], 0x18);  /* imul si, [bp-0x38], 0x18 */
            ii(0x15_af0f, 3); mov(bx, memw_a16[ss, bp - 0x1a]);         /* mov bx, [bp-0x1a] */
            ii(0x15_af12, 5); test(memb_a16[es, bx + si + 0x8], 0x4);   /* test byte [es:bx+si+0x8], 0x4 */
            ii(0x15_af17, 2); if(jzw(0x15_af1d, 0x4)) goto l_0x15_af1d; /* jz 0xaf1d */
            ii(0x15_af19, 4); or(memb_a16[ss, bp - 0x1e], 0x8);         /* or byte [bp-0x1e], 0x8 */
        l_0x15_af1d:
            ii(0x15_af1d, 3); mov(ax, 0x9);                             /* mov ax, 0x9 */
            ii(0x15_af20, 3); mov(bx, memw_a16[ss, bp - 0x30]);         /* mov bx, [bp-0x30] */
            ii(0x15_af23, 3); mov(cx, memw_a16[ss, bp - 0x1e]);         /* mov cx, [bp-0x1e] */
            ii(0x15_af26, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_af28, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_af2b, 3); pushw(memw_a16[ss, bp - 0x32]);           /* push word [bp-0x32] */
            ii(0x15_af2e, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_af33, 1); popw(bx);                                 /* pop bx */
            ii(0x15_af34, 1); popw(bx);                                 /* pop bx */
            ii(0x15_af35, 2); jmpw(0x15_af4c, 0x15); goto l_0x15_af4c;  /* jmp 0xaf4c */
        l_0x15_af37:
            ii(0x15_af37, 3); mov(ax, memw_a16[ss, bp - 0x46]);         /* mov ax, [bp-0x46] */
            ii(0x15_af3a, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x15_af3d, 4); imul(si, memw_a16[ss, bp - 0x38], 0x18);  /* imul si, [bp-0x38], 0x18 */
            ii(0x15_af41, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x15_af44, 4); mov(memw_a16[es, bx + si + 0x4], ax);     /* mov [es:bx+si+0x4], ax */
            ii(0x15_af48, 4); mov(memw_a16[es, bx + si + 0x6], dx);     /* mov [es:bx+si+0x6], dx */
        l_0x15_af4c:
            ii(0x15_af4c, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_af4f, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
            ii(0x15_af52, 5); mov(memw_a16[ss, bp - 0x3e], 0);          /* mov word [bp-0x3e], 0x0 */
            ii(0x15_af57, 3); jmpw(0x15_b064, 0x10a); goto l_0x15_b064; /* jmp 0xb064 */
        l_0x15_af5a:
            ii(0x15_af5a, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_af5d, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_af60, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_af63, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_af68, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_af6b, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_af6e, 3); pushw(memw_a16[ss, bp - 0x40]);           /* push word [bp-0x40] */
            ii(0x15_af71, 3); pushw(memw_a16[ss, bp - 0x42]);           /* push word [bp-0x42] */
            ii(0x15_af74, 3); callw(0x15_cbcd, 0x1c56);                 /* call 0xcbcd */
        l_0x15_af77:
            ii(0x15_af77, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_af7a, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_af7c, 3); cmp(dx, memw_a16[ss, bp - 0x40]);         /* cmp dx, [bp-0x40] */
            ii(0x15_af7f, 2); if(jaew(0x15_af84, 0x3)) goto l_0x15_af84; /* jae 0xaf84 */
            ii(0x15_af81, 3); jmpw(0x15_b042, 0xbe); goto l_0x15_b042;  /* jmp 0xb042 */
        l_0x15_af84:
            ii(0x15_af84, 2); if(jaw(0x15_af8e, 0x8)) goto l_0x15_af8e; /* ja 0xaf8e */
            ii(0x15_af86, 3); cmp(ax, memw_a16[ss, bp - 0x42]);         /* cmp ax, [bp-0x42] */
            ii(0x15_af89, 2); if(jaw(0x15_af8e, 0x3)) goto l_0x15_af8e; /* ja 0xaf8e */
            ii(0x15_af8b, 3); jmpw(0x15_b042, 0xb4); goto l_0x15_b042;  /* jmp 0xb042 */
        l_0x15_af8e:
            ii(0x15_af8e, 5); cmp(memb_a16[ds, 0x19f4], 0);             /* cmp byte [0x19f4], 0x0 */
            ii(0x15_af93, 2); if(jzw(0x15_af98, 0x3)) goto l_0x15_af98; /* jz 0xaf98 */
            ii(0x15_af95, 3); jmpw(0x15_b042, 0xaa); goto l_0x15_b042;  /* jmp 0xb042 */
        l_0x15_af98:
            ii(0x15_af98, 1); pushw(dx);                                /* push dx */
            ii(0x15_af99, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x15_af9b, 3); mov(bx, memw_a16[ss, bp - 0x42]);         /* mov bx, [bp-0x42] */
            ii(0x15_af9e, 2); sub(cx, bx);                              /* sub cx, bx */
            ii(0x15_afa0, 1); pushw(cx);                                /* push cx */
            ii(0x15_afa1, 1); pushw(dx);                                /* push dx */
            ii(0x15_afa2, 1); pushw(dx);                                /* push dx */
            ii(0x15_afa3, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_afa6, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_afa9, 1); pushw(dx);                                /* push dx */
            ii(0x15_afaa, 1); pushw(ax);                                /* push ax */
            ii(0x15_afab, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x15_afad, 3); callw(0x15_de46, 0x2e96);                 /* call 0xde46 */
            ii(0x15_afb0, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_afb3, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
            ii(0x15_afb6, 2); add(ax, si);                              /* add ax, si */
            ii(0x15_afb8, 2); jmpw(0x15_b02f, 0x75); goto l_0x15_b02f;  /* jmp 0xb02f */
        l_0x15_afba:
            ii(0x15_afba, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x15_afbd, 2); if(jnzw(0x15_b006, 0x47)) goto l_0x15_b006; /* jnz 0xb006 */
            ii(0x15_afbf, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_afc1, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_afc4, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_afc7, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_afca, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_afcf, 5); callw_far_abs(0x80, 0x3b06);              /* call word 0x80:0x3b06 */
            ii(0x15_afd4, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_afd7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_afd9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_afdb, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_afde, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_afe1, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_afe3, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x15_afe6, 3); callw(0x15_de46, 0x2e5d);                 /* call 0xde46 */
            ii(0x15_afe9, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_afec, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
            ii(0x15_afef, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_aff2, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_aff7, 3); pushw(memw_a16[ss, bp - 0x42]);           /* push word [bp-0x42] */
            ii(0x15_affa, 3); lea(ax, bp - 0x32);                       /* lea ax, [bp-0x32] */
            ii(0x15_affd, 1); pushw(ss);                                /* push ss */
            ii(0x15_affe, 1); pushw(ax);                                /* push ax */
            ii(0x15_afff, 1); nop();                                    /* nop */
            ii(0x15_b000, 1); pushw(cs);                                /* push cs */
            ii(0x15_b001, 3); callw(0x16_0e81, 0x5e7d);                 /* call 0xe81 */
            ii(0x15_b004, 2); jmpw(0x15_b039, 0x33); goto l_0x15_b039;  /* jmp 0xb039 */
        l_0x15_b006:
            ii(0x15_b006, 3); cmp(ax, 0x3);                             /* cmp ax, 0x3 */
            ii(0x15_b009, 2); if(jnzw(0x15_b042, 0x37)) goto l_0x15_b042; /* jnz 0xb042 */
            ii(0x15_b00b, 5); cmp(memb_a16[ds, 0x19f4], 0);             /* cmp byte [0x19f4], 0x0 */
            ii(0x15_b010, 2); if(jnzw(0x15_b042, 0x30)) goto l_0x15_b042; /* jnz 0xb042 */
            ii(0x15_b012, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b014, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_b017, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b019, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b01b, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_b01e, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_b021, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b023, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_b026, 3); callw(0x15_de46, 0x2e1d);                 /* call 0xde46 */
            ii(0x15_b029, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_b02c, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
        l_0x15_b02f:
            ii(0x15_b02f, 1); pushw(dx);                                /* push dx */
            ii(0x15_b030, 1); pushw(ax);                                /* push ax */
            ii(0x15_b031, 1); nop();                                    /* nop */
            ii(0x15_b032, 1); pushw(cs);                                /* push cs */
            ii(0x15_b033, 3); callw(0x16_0faf, 0x5f79);                 /* call 0xfaf */
            ii(0x15_b036, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x15_b039:
            ii(0x15_b039, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_b03c, 3); pushw(memw_a16[ss, bp - 0x32]);           /* push word [bp-0x32] */
            ii(0x15_b03f, 3); callw(0x15_df78, 0x2f36);                 /* call 0xdf78 */
        l_0x15_b042:
            ii(0x15_b042, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_b045, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_b047, 3); add(memw_a16[ss, bp - 0x6], ax);          /* add [bp-0x6], ax */
            ii(0x15_b04a, 3); adc(memw_a16[ss, bp - 0x4], dx);          /* adc [bp-0x4], dx */
            ii(0x15_b04d, 3); add(memw_a16[ss, bp - 0x46], ax);         /* add [bp-0x46], ax */
            ii(0x15_b050, 3); adc(memw_a16[ss, bp - 0x44], dx);         /* adc [bp-0x44], dx */
            ii(0x15_b053, 3); add(memw_a16[ss, bp - 0x26], ax);         /* add [bp-0x26], ax */
            ii(0x15_b056, 3); adc(memw_a16[ss, bp - 0x24], dx);         /* adc [bp-0x24], dx */
            ii(0x15_b059, 4); add(memw_a16[ss, bp - 0x22], 0x1);        /* add word [bp-0x22], 0x1 */
            ii(0x15_b05d, 4); adc(memw_a16[ss, bp - 0x20], 0);          /* adc word [bp-0x20], 0x0 */
            ii(0x15_b061, 3); inc(memw_a16[ss, bp - 0x3e]);             /* inc word [bp-0x3e] */
        l_0x15_b064:
            ii(0x15_b064, 3); mov(ax, memw_a16[ss, bp - 0x3e]);         /* mov ax, [bp-0x3e] */
            ii(0x15_b067, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_b069, 4); imul(si, memw_a16[ss, bp - 0x38], 0x18);  /* imul si, [bp-0x38], 0x18 */
            ii(0x15_b06d, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x15_b070, 4); cmp(memw_a16[es, bx + si + 0x12], dx);    /* cmp [es:bx+si+0x12], dx */
            ii(0x15_b074, 2); if(jbw(0x15_b0d1, 0x5b)) goto l_0x15_b0d1; /* jb 0xb0d1 */
            ii(0x15_b076, 2); if(jaw(0x15_b07e, 0x6)) goto l_0x15_b07e; /* ja 0xb07e */
            ii(0x15_b078, 4); cmp(memw_a16[es, bx + si + 0x10], ax);    /* cmp [es:bx+si+0x10], ax */
            ii(0x15_b07c, 2); if(jbew(0x15_b0d1, 0x53)) goto l_0x15_b0d1; /* jbe 0xb0d1 */
        l_0x15_b07e:
            ii(0x15_b07e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_b081, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_b084, 3); pushw(memw_a16[ss, bp - 0x38]);           /* push word [bp-0x38] */
            ii(0x15_b087, 1); pushw(ax);                                /* push ax */
            ii(0x15_b088, 3); lea(ax, bp - 0x42);                       /* lea ax, [bp-0x42] */
            ii(0x15_b08b, 1); pushw(ss);                                /* push ss */
            ii(0x15_b08c, 1); pushw(ax);                                /* push ax */
            ii(0x15_b08d, 3); lea(cx, bp - 0x3c);                       /* lea cx, [bp-0x3c] */
            ii(0x15_b090, 1); pushw(ss);                                /* push ss */
            ii(0x15_b091, 1); pushw(cx);                                /* push cx */
            ii(0x15_b092, 3); lea(cx, bp - 0xe);                        /* lea cx, [bp-0xe] */
            ii(0x15_b095, 1); pushw(ss);                                /* push ss */
            ii(0x15_b096, 1); pushw(cx);                                /* push cx */
            ii(0x15_b097, 3); callw(0x15_dc78, 0x2bde);                 /* call 0xdc78 */
            ii(0x15_b09a, 3); mov(memw_a16[ss, bp - 0x48], ax);         /* mov [bp-0x48], ax */
            ii(0x15_b09d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_b09f, 2); if(jzw(0x15_b0a4, 0x3)) goto l_0x15_b0a4; /* jz 0xb0a4 */
            ii(0x15_b0a1, 3); jmpw(0x15_afba, -0xea); goto l_0x15_afba; /* jmp 0xafba */
        l_0x15_b0a4:
            ii(0x15_b0a4, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x15_b0a9, 2); if(jzw(0x15_b0ae, 0x3)) goto l_0x15_b0ae; /* jz 0xb0ae */
            ii(0x15_b0ab, 3); jmpw(0x15_af5a, -0x154); goto l_0x15_af5a; /* jmp 0xaf5a */
        l_0x15_b0ae:
            ii(0x15_b0ae, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_b0b1, 5); pushw(memw_a16[es, bx + 0xc6]);           /* push word [es:bx+0xc6] */
            ii(0x15_b0b6, 5); pushw(memw_a16[es, bx + 0xc4]);           /* push word [es:bx+0xc4] */
            ii(0x15_b0bb, 3); pushw(memw_a16[ss, bp - 0x40]);           /* push word [bp-0x40] */
            ii(0x15_b0be, 3); pushw(memw_a16[ss, bp - 0x42]);           /* push word [bp-0x42] */
            ii(0x15_b0c1, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_b0c4, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_b0c7, 4); callw_a16_far_ind(ds, 0x1a04);            /* call far word [0x1a04] */
            ii(0x15_b0cb, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_b0ce, 3); jmpw(0x15_af77, -0x15a); goto l_0x15_af77; /* jmp 0xaf77 */
        l_0x15_b0d1:
            ii(0x15_b0d1, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_b0d4, 3); mov(dx, memw_a16[ss, bp - 0x4]);          /* mov dx, [bp-0x4] */
            ii(0x15_b0d7, 4); imul(bx, memw_a16[ss, bp - 0x38], 0x18);  /* imul bx, [bp-0x38], 0x18 */
            ii(0x15_b0db, 3); les(si, ss, bp - 0x1a);                   /* les si, [bp-0x1a] */
            ii(0x15_b0de, 4); cmp(memw_a16[es, bx + si + 0x2], dx);     /* cmp [es:bx+si+0x2], dx */
            ii(0x15_b0e2, 2); if(jbw(0x15_b162, 0x7e)) goto l_0x15_b162; /* jb 0xb162 */
            ii(0x15_b0e4, 2); if(jaw(0x15_b0eb, 0x5)) goto l_0x15_b0eb; /* ja 0xb0eb */
            ii(0x15_b0e6, 3); cmp(memw_a16[es, bx + si], ax);           /* cmp [es:bx+si], ax */
            ii(0x15_b0e9, 2); if(jbew(0x15_b162, 0x77)) goto l_0x15_b162; /* jbe 0xb162 */
        l_0x15_b0eb:
            ii(0x15_b0eb, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b0ed, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b0ef, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_b0f2, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_b0f5, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x15_b0f8, 4); mov(di, memw_a16[es, bx + si + 0x2]);     /* mov di, [es:bx+si+0x2] */
            ii(0x15_b0fc, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x15_b0fe, 2); sbb(di, dx);                              /* sbb di, dx */
            ii(0x15_b100, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_b103, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_b105, 2); cmp(di, dx);                              /* cmp di, dx */
            ii(0x15_b107, 2); if(jbw(0x15_b113, 0xa)) goto l_0x15_b113; /* jb 0xb113 */
            ii(0x15_b109, 2); if(jaw(0x15_b10f, 0x4)) goto l_0x15_b10f; /* ja 0xb10f */
            ii(0x15_b10b, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x15_b10d, 2); if(jbew(0x15_b113, 0x4)) goto l_0x15_b113; /* jbe 0xb113 */
        l_0x15_b10f:
            ii(0x15_b10f, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_b111, 2); mov(cx, ax);                              /* mov cx, ax */
        l_0x15_b113:
            ii(0x15_b113, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x15_b116, 1); pushw(dx);                                /* push dx */
            ii(0x15_b117, 1); pushw(cx);                                /* push cx */
            ii(0x15_b118, 3); callw(0x15_de46, 0x2d2b);                 /* call 0xde46 */
            ii(0x15_b11b, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_b11e, 3); mov(memw_a16[ss, bp - 0x30], dx);         /* mov [bp-0x30], dx */
            ii(0x15_b121, 5); cmp(memb_a16[ds, 0x19f4], 0);             /* cmp byte [0x19f4], 0x0 */
            ii(0x15_b126, 2); if(jnzw(0x15_b137, 0xf)) goto l_0x15_b137; /* jnz 0xb137 */
            ii(0x15_b128, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b12a, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_b12d, 1); pushw(dx);                                /* push dx */
            ii(0x15_b12e, 1); pushw(ax);                                /* push ax */
            ii(0x15_b12f, 1); nop();                                    /* nop */
            ii(0x15_b130, 1); pushw(cs);                                /* push cs */
            ii(0x15_b131, 3); callw(0x16_0faf, 0x5e7b);                 /* call 0xfaf */
            ii(0x15_b134, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x15_b137:
            ii(0x15_b137, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_b13a, 3); pushw(memw_a16[ss, bp - 0x32]);           /* push word [bp-0x32] */
            ii(0x15_b13d, 3); callw(0x15_df78, 0x2e38);                 /* call 0xdf78 */
            ii(0x15_b140, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_b143, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_b145, 3); add(memw_a16[ss, bp - 0x6], ax);          /* add [bp-0x6], ax */
            ii(0x15_b148, 3); adc(memw_a16[ss, bp - 0x4], dx);          /* adc [bp-0x4], dx */
            ii(0x15_b14b, 3); add(memw_a16[ss, bp - 0x46], ax);         /* add [bp-0x46], ax */
            ii(0x15_b14e, 3); adc(memw_a16[ss, bp - 0x44], dx);         /* adc [bp-0x44], dx */
            ii(0x15_b151, 3); add(memw_a16[ss, bp - 0x26], ax);         /* add [bp-0x26], ax */
            ii(0x15_b154, 3); adc(memw_a16[ss, bp - 0x24], dx);         /* adc [bp-0x24], dx */
            ii(0x15_b157, 4); add(memw_a16[ss, bp - 0x36], 0x1);        /* add word [bp-0x36], 0x1 */
            ii(0x15_b15b, 4); adc(memw_a16[ss, bp - 0x34], 0);          /* adc word [bp-0x34], 0x0 */
            ii(0x15_b15f, 3); jmpw(0x15_b0d1, -0x91); goto l_0x15_b0d1; /* jmp 0xb0d1 */
        l_0x15_b162:
            ii(0x15_b162, 4); cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x15_b166, 2); if(jnzw(0x15_b170, 0x8)) goto l_0x15_b170; /* jnz 0xb170 */
            ii(0x15_b168, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_b16a, 3); mov(memw_a16[ss, bp - 0x44], ax);         /* mov [bp-0x44], ax */
            ii(0x15_b16d, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
        l_0x15_b170:
            ii(0x15_b170, 3); inc(memw_a16[ss, bp - 0x38]);             /* inc word [bp-0x38] */
        l_0x15_b173:
            ii(0x15_b173, 3); mov(ax, memw_a16[ss, bp - 0x38]);         /* mov ax, [bp-0x38] */
            ii(0x15_b176, 3); les(bx, ss, bp - 0x2c);                   /* les bx, [bp-0x2c] */
            ii(0x15_b179, 4); cmp(memw_a16[es, bx + 0x44], ax);         /* cmp [es:bx+0x44], ax */
            ii(0x15_b17d, 2); if(jbew(0x15_b1cd, 0x4e)) goto l_0x15_b1cd; /* jbe 0xb1cd */
            ii(0x15_b17f, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_b181, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x15_b184, 3); mov(memw_a16[ss, bp - 0x6], cx);          /* mov [bp-0x6], cx */
            ii(0x15_b187, 3); imul(bx, ax, 0x18);                       /* imul bx, ax, 0x18 */
            ii(0x15_b18a, 3); les(si, ss, bp - 0x1a);                   /* les si, [bp-0x1a] */
            ii(0x15_b18d, 4); mov(ax, memw_a16[es, bx + si + 0x2]);     /* mov ax, [es:bx+si+0x2] */
            ii(0x15_b191, 3); or(ax, memw_a16[es, bx + si]);            /* or ax, [es:bx+si] */
            ii(0x15_b194, 2); if(jzw(0x15_b170, -0x26)) goto l_0x15_b170; /* jz 0xb170 */
            ii(0x15_b196, 4); imul(bx, memw_a16[ss, bp - 0x38], 0x18);  /* imul bx, [bp-0x38], 0x18 */
            ii(0x15_b19a, 2); add(bx, si);                              /* add bx, si */
            ii(0x15_b19c, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x15_b1a0, 3); mov(memw_a16[ss, bp - 0x48], ax);         /* mov [bp-0x48], ax */
            ii(0x15_b1a3, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x15_b1a5, 3); les(si, ss, bp - 0x2c);                   /* les si, [bp-0x2c] */
            ii(0x15_b1a8, 5); test(memb_a16[es, si + 0x10], 0x10);      /* test byte [es:si+0x10], 0x10 */
            ii(0x15_b1ad, 2); if(jnzw(0x15_b1b2, 0x3)) goto l_0x15_b1b2; /* jnz 0xb1b2 */
            ii(0x15_b1af, 3); jmpw(0x15_adfb, -0x3b7); goto l_0x15_adfb; /* jmp 0xadfb */
        l_0x15_b1b2:
            ii(0x15_b1b2, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_b1b4, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_b1b8, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_b1bc, 4); add(ax, memw_a16[ds, 0x19ea]);            /* add ax, [0x19ea] */
            ii(0x15_b1c0, 4); adc(dx, memw_a16[ds, 0x19ec]);            /* adc dx, [0x19ec] */
            ii(0x15_b1c4, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x15_b1c7, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x15_b1ca, 3); jmpw(0x15_ae8d, -0x340); goto l_0x15_ae8d; /* jmp 0xae8d */
        l_0x15_b1cd:
            ii(0x15_b1cd, 4); mov(ax, memw_a16[es, bx + 0x1a]);         /* mov ax, [es:bx+0x1a] */
            ii(0x15_b1d1, 4); or(ax, memw_a16[es, bx + 0x18]);          /* or ax, [es:bx+0x18] */
            ii(0x15_b1d5, 2); if(jzw(0x15_b1f5, 0x1e)) goto l_0x15_b1f5; /* jz 0xb1f5 */
            ii(0x15_b1d7, 5); imul(ax, memw_a16[es, bx + 0x18], 0x18);  /* imul ax, [es:bx+0x18], 0x18 */
            ii(0x15_b1dc, 3); add(ax, memw_a16[ss, bp - 0x1a]);         /* add ax, [bp-0x1a] */
            ii(0x15_b1df, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x15_b1e2, 3); sub(ax, 0x18);                            /* sub ax, 0x18 */
            ii(0x15_b1e5, 1); pushw(dx);                                /* push dx */
            ii(0x15_b1e6, 1); pushw(ax);                                /* push ax */
            ii(0x15_b1e7, 3); callw(0x15_cd74, 0x1b8a);                 /* call 0xcd74 */
            ii(0x15_b1ea, 3); les(bx, ss, bp - 0x2c);                   /* les bx, [bp-0x2c] */
            ii(0x15_b1ed, 4); add(memw_a16[es, bx + 0x1c], ax);         /* add [es:bx+0x1c], ax */
            ii(0x15_b1f1, 4); adc(memw_a16[es, bx + 0x1e], dx);         /* adc [es:bx+0x1e], dx */
        l_0x15_b1f5:
            ii(0x15_b1f5, 3); les(bx, ss, bp - 0x2c);                   /* les bx, [bp-0x2c] */
            ii(0x15_b1f8, 4); mov(ax, memw_a16[es, bx + 0x22]);         /* mov ax, [es:bx+0x22] */
            ii(0x15_b1fc, 4); or(ax, memw_a16[es, bx + 0x20]);          /* or ax, [es:bx+0x20] */
            ii(0x15_b200, 2); if(jzw(0x15_b220, 0x1e)) goto l_0x15_b220; /* jz 0xb220 */
            ii(0x15_b202, 5); imul(ax, memw_a16[es, bx + 0x20], 0x18);  /* imul ax, [es:bx+0x20], 0x18 */
            ii(0x15_b207, 3); add(ax, memw_a16[ss, bp - 0x1a]);         /* add ax, [bp-0x1a] */
            ii(0x15_b20a, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x15_b20d, 3); sub(ax, 0x18);                            /* sub ax, 0x18 */
            ii(0x15_b210, 1); pushw(dx);                                /* push dx */
            ii(0x15_b211, 1); pushw(ax);                                /* push ax */
            ii(0x15_b212, 3); callw(0x15_cd74, 0x1b5f);                 /* call 0xcd74 */
            ii(0x15_b215, 3); les(bx, ss, bp - 0x2c);                   /* les bx, [bp-0x2c] */
            ii(0x15_b218, 4); add(memw_a16[es, bx + 0x24], ax);         /* add [es:bx+0x24], ax */
            ii(0x15_b21c, 4); adc(memw_a16[es, bx + 0x26], dx);         /* adc [es:bx+0x26], dx */
        l_0x15_b220:
            ii(0x15_b220, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_b222:
            ii(0x15_b222, 1); popw(si);                                 /* pop si */
            ii(0x15_b223, 1); popw(di);                                 /* pop di */
            ii(0x15_b224, 1); leavew();                                 /* leave */
            ii(0x15_b225, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
