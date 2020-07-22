using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_aaf5-bbc30101")]
        public void Method_0019_aaf5()
        {
            ii(0x19_aaf5, 4);  enter(0x50, 0);                         /* enter 0x50, 0x0 */
            ii(0x19_aaf9, 1);  push(di);                               /* push di */
            ii(0x19_aafa, 1);  push(si);                               /* push si */
            ii(0x19_aafb, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_aafe, 4);  mov(ax, memw[es, bx + 60]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_ab02, 4);  mov(dx, memw[es, bx + 62]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_ab06, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_ab09, 3);  mov(memw[ss, bp - 24], dx);             /* mov [bp-0x18], dx */
            ii(0x19_ab0c, 4);  mov(cx, memw[es, bx + 28]);             /* mov cx, [es:bx+0x1c] */
            ii(0x19_ab10, 4);  mov(si, memw[es, bx + 30]);             /* mov si, [es:bx+0x1e] */
            ii(0x19_ab14, 3);  mov(memw[ss, bp - 44], cx);             /* mov [bp-0x2c], cx */
            ii(0x19_ab17, 3);  mov(memw[ss, bp - 42], si);             /* mov [bp-0x2a], si */
            ii(0x19_ab1a, 2);  mov(es, si);                            /* mov es, si */
            ii(0x19_ab1c, 2);  mov(bx, cx);                            /* mov bx, cx */
            ii(0x19_ab1e, 4);  mov(di, memw[es, bx + 40]);             /* mov di, [es:bx+0x28] */
            ii(0x19_ab22, 3);  mov(memw[ss, bp - 40], di);             /* mov [bp-0x28], di */
            ii(0x19_ab25, 5);  mov(memw[ss, bp - 10], 0);              /* mov word [bp-0xa], 0x0 */
            ii(0x19_ab2a, 2);  sub(di, di);                            /* sub di, di */
            ii(0x19_ab2c, 3);  mov(memw[ss, bp - 68], di);             /* mov [bp-0x44], di */
            ii(0x19_ab2f, 3);  mov(memw[ss, bp - 70], di);             /* mov [bp-0x46], di */
            ii(0x19_ab32, 3);  mov(memw[ss, bp - 36], di);             /* mov [bp-0x24], di */
            ii(0x19_ab35, 3);  mov(memw[ss, bp - 38], di);             /* mov [bp-0x26], di */
            ii(0x19_ab38, 3);  mov(memw[ss, bp - 32], di);             /* mov [bp-0x20], di */
            ii(0x19_ab3b, 3);  mov(memw[ss, bp - 34], di);             /* mov [bp-0x22], di */
            ii(0x19_ab3e, 3);  mov(memw[ss, bp - 52], di);             /* mov [bp-0x34], di */
            ii(0x19_ab41, 3);  mov(memw[ss, bp - 54], di);             /* mov [bp-0x36], di */
            ii(0x19_ab44, 3);  mov(memw[ss, bp - 78], di);             /* mov [bp-0x4e], di */
            ii(0x19_ab47, 3);  mov(memw[ss, bp - 80], di);             /* mov [bp-0x50], di */
            ii(0x19_ab4a, 5);  test(memb[es, bx + 16], 0x10);          /* test byte [es:bx+0x10], 0x10 */
            ii(0x19_ab4f, 2);  if(jz(0x19_ab68, 0x17)) goto l_0x19_ab68;/* jz 0xab68 */
            ii(0x19_ab51, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x19_ab53, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_ab55, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_ab59, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_ab5d, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_ab60, 3);  mov(memw[ss, bp - 78], dx);             /* mov [bp-0x4e], dx */
            ii(0x19_ab63, 5);  mov(memb[ds, 0x19f3], 2);               /* mov byte [0x19f3], 0x2 */
        l_0x19_ab68:
            ii(0x19_ab68, 5);  cmp(memb[ds, 0x19f3], 0);               /* cmp byte [0x19f3], 0x0 */
            ii(0x19_ab6d, 2);  if(jz(0x19_ab74, 5)) goto l_0x19_ab74;  /* jz 0xab74 */
            ii(0x19_ab6f, 5);  mov(memw[ss, bp + 4], 1);               /* mov word [bp+0x4], 0x1 */
        l_0x19_ab74:
            ii(0x19_ab74, 3);  mov(al, memb[ds, 0x19f3]);              /* mov al, [0x19f3] */
            ii(0x19_ab77, 1);  cbw();                                  /* cbw */
            ii(0x19_ab78, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_ab7b, 4);  mov(memw[es, bx + 92], ax);             /* mov [es:bx+0x5c], ax */
            ii(0x19_ab7f, 3);  mov(memw[ss, bp - 56], di);             /* mov [bp-0x38], di */
            ii(0x19_ab82, 3);  cmp(memw[ss, bp + 4], di);              /* cmp [bp+0x4], di */
            ii(0x19_ab85, 2);  if(jz(0x19_abed, 0x66)) goto l_0x19_abed;/* jz 0xabed */
            ii(0x19_ab87, 1);  push(es);                               /* push es */
            ii(0x19_ab88, 1);  push(bx);                               /* push bx */
            ii(0x19_ab89, 1);  push(di);                               /* push di */
            ii(0x19_ab8a, 3);  call(0x19_a8a9, -0x2e4);                /* call 0xa8a9 */
            ii(0x19_ab8d, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_ab90, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x19_ab93, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_ab96, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ab99, 3);  call(0x19_a7e5, -0x3b7);                /* call 0xa7e5 */
            ii(0x19_ab9c, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x19_ab9f, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
        l_0x19_aba2:
            ii(0x19_aba2, 5);  cmp(memb[ds, 0x19f2], 0);               /* cmp byte [0x19f2], 0x0 */
            ii(0x19_aba7, 2);  if(jz(0x19_abc2, 0x19)) goto l_0x19_abc2;/* jz 0xabc2 */
            ii(0x19_aba9, 5);  cmp(memb[ds, 0x19f3], 0);               /* cmp byte [0x19f3], 0x0 */
            ii(0x19_abae, 2);  if(jz(0x19_abc2, 0x12)) goto l_0x19_abc2;/* jz 0xabc2 */
            ii(0x19_abb0, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_abb3, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_abb6, 3);  add(memw[ss, bp - 18], ax);             /* add [bp-0x12], ax */
            ii(0x19_abb9, 3);  adc(memw[ss, bp - 16], dx);             /* adc [bp-0x10], dx */
            ii(0x19_abbc, 3);  add(memw[ss, bp - 22], ax);             /* add [bp-0x16], ax */
            ii(0x19_abbf, 3);  adc(memw[ss, bp - 20], dx);             /* adc [bp-0x14], dx */
        l_0x19_abc2:
            ii(0x19_abc2, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_abc5, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_abc8, 4);  cmp(memw[ss, bp + 4], 1);               /* cmp word [bp+0x4], 0x1 */
            ii(0x19_abcc, 1);  cmc();                                  /* cmc */
            ii(0x19_abcd, 2);  sbb(ax, ax);                            /* sbb ax, ax */
            ii(0x19_abcf, 2);  and(al, 0xfb);                          /* and al, 0xfb */
            ii(0x19_abd1, 1);  push(ax);                               /* push ax */
            ii(0x19_abd2, 2);  push(1);                                /* push 0x1 */
            ii(0x19_abd4, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_abd7, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_abda, 3);  call(0x19_c975, 0x1d98);                /* call 0xc975 */
            ii(0x19_abdd, 3);  mov(memw[ss, bp - 70], ax);             /* mov [bp-0x46], ax */
            ii(0x19_abe0, 3);  mov(memw[ss, bp - 68], dx);             /* mov [bp-0x44], dx */
            ii(0x19_abe3, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_abe5, 2);  if(jnz(0x19_ac0c, 0x25)) goto l_0x19_ac0c;/* jnz 0xac0c */
        l_0x19_abe7:
            ii(0x19_abe7, 3);  mov(ax, 0x51b);                         /* mov ax, 0x51b */
            ii(0x19_abea, 3);  jmp(0x19_b222, 0x635); goto l_0x19_b222;/* jmp 0xb222 */
        l_0x19_abed:
            ii(0x19_abed, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_abf0, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_abf3, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x19_abf6, 1);  inc(ax);                                /* inc ax */
            ii(0x19_abf7, 1);  push(ax);                               /* push ax */
            ii(0x19_abf8, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_abfa, 3);  call(0x19_a8a9, -0x354);                /* call 0xa8a9 */
            ii(0x19_abfd, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_ac00, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x19_ac03, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_ac05, 2);  if(jnz(0x19_aba2, -0x65)) goto l_0x19_aba2;/* jnz 0xaba2 */
            ii(0x19_ac07, 3);  mov(memw[ss, bp - 56], si);             /* mov [bp-0x38], si */
            ii(0x19_ac0a, 2);  jmp(0x19_abed, -0x1f); goto l_0x19_abed;/* jmp 0xabed */
        l_0x19_ac0c:
            ii(0x19_ac0c, 5);  cmp(memb[ds, 0x19f2], 0);               /* cmp byte [0x19f2], 0x0 */
            ii(0x19_ac11, 2);  if(jnz(0x19_ac16, 3)) goto l_0x19_ac16; /* jnz 0xac16 */
            ii(0x19_ac13, 3);  jmp(0x19_acb8, 0xa2); goto l_0x19_acb8; /* jmp 0xacb8 */
        l_0x19_ac16:
            ii(0x19_ac16, 5);  cmp(memb[ds, 0x19f3], 2);               /* cmp byte [0x19f3], 0x2 */
            ii(0x19_ac1b, 2);  if(jnz(0x19_ac36, 0x19)) goto l_0x19_ac36;/* jnz 0xac36 */
            ii(0x19_ac1d, 3);  mov(dx, memw[ss, bp - 68]);             /* mov dx, [bp-0x44] */
            ii(0x19_ac20, 3);  mov(memw[ds, 0x19ea], ax);              /* mov [0x19ea], ax */
            ii(0x19_ac23, 4);  mov(memw[ds, 0x19ec], dx);              /* mov [0x19ec], dx */
            ii(0x19_ac27, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_ac2a, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_ac2d, 3);  mov(memw[ds, 0x19ee], ax);              /* mov [0x19ee], ax */
            ii(0x19_ac30, 4);  mov(memw[ds, 0x19f0], dx);              /* mov [0x19f0], dx */
            ii(0x19_ac34, 2);  jmp(0x19_ac65, 0x2f); goto l_0x19_ac65; /* jmp 0xac65 */
        l_0x19_ac36:
            ii(0x19_ac36, 5);  cmp(memb[ds, 0x19f3], 1);               /* cmp byte [0x19f3], 0x1 */
            ii(0x19_ac3b, 2);  if(jnz(0x19_ac57, 0x1a)) goto l_0x19_ac57;/* jnz 0xac57 */
            ii(0x19_ac3d, 6);  mov(memw[ds, 0x19ea], 0);               /* mov word [0x19ea], 0x0 */
            ii(0x19_ac43, 6);  mov(memw[ds, 0x19ec], 1);               /* mov word [0x19ec], 0x1 */
            ii(0x19_ac49, 6);  mov(memw[ds, 0x19ee], 0);               /* mov word [0x19ee], 0x0 */
            ii(0x19_ac4f, 6);  mov(memw[ds, 0x19f0], 0x2000);          /* mov word [0x19f0], 0x2000 */
            ii(0x19_ac55, 2);  jmp(0x19_ac65, 0xe); goto l_0x19_ac65;  /* jmp 0xac65 */
        l_0x19_ac57:
            ii(0x19_ac57, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_ac59, 3);  mov(memw[ds, 0x19f0], ax);              /* mov [0x19f0], ax */
            ii(0x19_ac5c, 3);  mov(memw[ds, 0x19ee], ax);              /* mov [0x19ee], ax */
            ii(0x19_ac5f, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_ac62, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
        l_0x19_ac65:
            ii(0x19_ac65, 4);  push(memw[ds, 0x19e6]);                 /* push word [0x19e6] */
            ii(0x19_ac69, 4);  push(memw[ds, 0x19ec]);                 /* push word [0x19ec] */
            ii(0x19_ac6d, 4);  push(memw[ds, 0x19ea]);                 /* push word [0x19ea] */
            ii(0x19_ac71, 3);  mov(ax, memw[ds, 0x19ee]);              /* mov ax, [0x19ee] */
            ii(0x19_ac74, 4);  mov(dx, memw[ds, 0x19f0]);              /* mov dx, [0x19f0] */
            ii(0x19_ac78, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_ac7b, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x19_ac7e, 1);  push(dx);                               /* push dx */
            ii(0x19_ac7f, 1);  push(ax);                               /* push ax */
            ii(0x19_ac80, 3);  push(0x92);                             /* push 0x92 */
            ii(0x19_ac83, 3);  call(0x19_cc1a, 0x1f94);                /* call 0xcc1a */
            ii(0x19_ac86, 4);  push(memw[ds, 0x19e4]);                 /* push word [0x19e4] */
            ii(0x19_ac8a, 4);  push(memw[ds, 0x19ec]);                 /* push word [0x19ec] */
            ii(0x19_ac8e, 4);  push(memw[ds, 0x19ea]);                 /* push word [0x19ea] */
            ii(0x19_ac92, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x19_ac95, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x19_ac98, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_ac9b, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x19_ac9e, 1);  push(dx);                               /* push dx */
            ii(0x19_ac9f, 1);  push(ax);                               /* push ax */
            ii(0x19_aca0, 3);  push(0x9a);                             /* push 0x9a */
            ii(0x19_aca3, 3);  call(0x19_cc1a, 0x1f74);                /* call 0xcc1a */
            ii(0x19_aca6, 3);  push(memw[ss, bp - 68]);                /* push word [bp-0x44] */
            ii(0x19_aca9, 3);  push(memw[ss, bp - 70]);                /* push word [bp-0x46] */
            ii(0x19_acac, 3);  push(memw[ss, bp - 78]);                /* push word [bp-0x4e] */
            ii(0x19_acaf, 3);  push(memw[ss, bp - 80]);                /* push word [bp-0x50] */
            ii(0x19_acb2, 3);  call(0x19_ca89, 0x1dd4);                /* call 0xca89 */
            ii(0x19_acb5, 3);  jmp(0x19_ad8a, 0xd2); goto l_0x19_ad8a; /* jmp 0xad8a */
        l_0x19_acb8:
            ii(0x19_acb8, 3);  mov(ax, memw[ds, 0x19ea]);              /* mov ax, [0x19ea] */
            ii(0x19_acbb, 4);  mov(dx, memw[ds, 0x19ec]);              /* mov dx, [0x19ec] */
            ii(0x19_acbf, 3);  cmp(memw[ss, bp - 68], dx);             /* cmp [bp-0x44], dx */
            ii(0x19_acc2, 2);  if(ja(0x19_acfc, 0x38)) goto l_0x19_acfc;/* ja 0xacfc */
            ii(0x19_acc4, 2);  if(jb(0x19_accb, 5)) goto l_0x19_accb;  /* jb 0xaccb */
            ii(0x19_acc6, 3);  cmp(memw[ss, bp - 70], ax);             /* cmp [bp-0x46], ax */
            ii(0x19_acc9, 2);  if(jae(0x19_acfc, 0x31)) goto l_0x19_acfc;/* jae 0xacfc */
        l_0x19_accb:
            ii(0x19_accb, 1);  push(ds);                               /* push ds */
            ii(0x19_accc, 3);  push(0x20b1);                           /* push 0x20b1 */
            ii(0x19_accf, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_acd2, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_acd5, 1);  nop();                                  /* nop */
            ii(0x19_acd6, 1);  push(cs);                               /* push cs */
            ii(0x19_acd7, 3);  call(0x19_d52d, 0x2853);                /* call 0xd52d */
            ii(0x19_acda, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_acdd, 3);  mov(memw[ss, bp - 70], ax);             /* mov [bp-0x46], ax */
            ii(0x19_ace0, 3);  mov(memw[ss, bp - 68], dx);             /* mov [bp-0x44], dx */
            ii(0x19_ace3, 3);  mov(ax, memw[ds, 0x19ea]);              /* mov ax, [0x19ea] */
            ii(0x19_ace6, 4);  mov(dx, memw[ds, 0x19ec]);              /* mov dx, [0x19ec] */
            ii(0x19_acea, 3);  cmp(memw[ss, bp - 68], dx);             /* cmp [bp-0x44], dx */
            ii(0x19_aced, 2);  if(ja(0x19_acfc, 0xd)) goto l_0x19_acfc;/* ja 0xacfc */
            ii(0x19_acef, 2);  if(jb(0x19_acf6, 5)) goto l_0x19_acf6;  /* jb 0xacf6 */
            ii(0x19_acf1, 3);  cmp(memw[ss, bp - 70], ax);             /* cmp [bp-0x46], ax */
            ii(0x19_acf4, 2);  if(jae(0x19_acfc, 6)) goto l_0x19_acfc; /* jae 0xacfc */
        l_0x19_acf6:
            ii(0x19_acf6, 3);  mov(ax, 0x524);                         /* mov ax, 0x524 */
            ii(0x19_acf9, 3);  jmp(0x19_b222, 0x526); goto l_0x19_b222;/* jmp 0xb222 */
        l_0x19_acfc:
            ii(0x19_acfc, 5);  cmp(memb[ds, 0x19f3], 0);               /* cmp byte [0x19f3], 0x0 */
            ii(0x19_ad01, 2);  if(jnz(0x19_ad06, 3)) goto l_0x19_ad06; /* jnz 0xad06 */
            ii(0x19_ad03, 3);  jmp(0x19_ad8a, 0x84); goto l_0x19_ad8a; /* jmp 0xad8a */
        l_0x19_ad06:
            ii(0x19_ad06, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_ad09, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_ad0c, 3);  add(ax, memw[ss, bp - 70]);             /* add ax, [bp-0x46] */
            ii(0x19_ad0f, 3);  adc(dx, memw[ss, bp - 68]);             /* adc dx, [bp-0x44] */
            ii(0x19_ad12, 4);  mov(cx, memw[ds, 0x19ee]);              /* mov cx, [0x19ee] */
            ii(0x19_ad16, 4);  mov(bx, memw[ds, 0x19f0]);              /* mov bx, [0x19f0] */
            ii(0x19_ad1a, 4);  add(cx, memw[ds, 0x19ea]);              /* add cx, [0x19ea] */
            ii(0x19_ad1e, 4);  adc(bx, memw[ds, 0x19ec]);              /* adc bx, [0x19ec] */
            ii(0x19_ad22, 2);  cmp(dx, bx);                            /* cmp dx, bx */
            ii(0x19_ad24, 2);  if(jb(0x19_ad8a, 0x64)) goto l_0x19_ad8a;/* jb 0xad8a */
            ii(0x19_ad26, 2);  if(ja(0x19_ad2c, 4)) goto l_0x19_ad2c;  /* ja 0xad2c */
            ii(0x19_ad28, 2);  cmp(ax, cx);                            /* cmp ax, cx */
            ii(0x19_ad2a, 2);  if(jbe(0x19_ad8a, 0x5e)) goto l_0x19_ad8a;/* jbe 0xad8a */
        l_0x19_ad2c:
            ii(0x19_ad2c, 4);  push(memw[ds, 0x19e6]);                 /* push word [0x19e6] */
            ii(0x19_ad30, 4);  push(memw[ds, 0x19ec]);                 /* push word [0x19ec] */
            ii(0x19_ad34, 4);  push(memw[ds, 0x19ea]);                 /* push word [0x19ea] */
            ii(0x19_ad38, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_ad3b, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_ad3e, 4);  sub(ax, memw[ds, 0x19ea]);              /* sub ax, [0x19ea] */
            ii(0x19_ad42, 4);  sbb(dx, memw[ds, 0x19ec]);              /* sbb dx, [0x19ec] */
            ii(0x19_ad46, 3);  add(ax, memw[ss, bp - 70]);             /* add ax, [bp-0x46] */
            ii(0x19_ad49, 3);  adc(dx, memw[ss, bp - 68]);             /* adc dx, [bp-0x44] */
            ii(0x19_ad4c, 4);  add(memw[ds, 0x19ee], ax);              /* add [0x19ee], ax */
            ii(0x19_ad50, 4);  adc(memw[ds, 0x19f0], dx);              /* adc [0x19f0], dx */
            ii(0x19_ad54, 3);  mov(ax, memw[ds, 0x19ee]);              /* mov ax, [0x19ee] */
            ii(0x19_ad57, 4);  mov(dx, memw[ds, 0x19f0]);              /* mov dx, [0x19f0] */
            ii(0x19_ad5b, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_ad5e, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x19_ad61, 1);  push(dx);                               /* push dx */
            ii(0x19_ad62, 1);  push(ax);                               /* push ax */
            ii(0x19_ad63, 3);  push(0x92);                             /* push 0x92 */
            ii(0x19_ad66, 3);  call(0x19_cc1a, 0x1eb1);                /* call 0xcc1a */
            ii(0x19_ad69, 4);  push(memw[ds, 0x19e4]);                 /* push word [0x19e4] */
            ii(0x19_ad6d, 4);  push(memw[ds, 0x19ec]);                 /* push word [0x19ec] */
            ii(0x19_ad71, 4);  push(memw[ds, 0x19ea]);                 /* push word [0x19ea] */
            ii(0x19_ad75, 3);  mov(ax, memw[ds, 0x19ee]);              /* mov ax, [0x19ee] */
            ii(0x19_ad78, 4);  mov(dx, memw[ds, 0x19f0]);              /* mov dx, [0x19f0] */
            ii(0x19_ad7c, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x19_ad7f, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x19_ad82, 1);  push(dx);                               /* push dx */
            ii(0x19_ad83, 1);  push(ax);                               /* push ax */
            ii(0x19_ad84, 3);  push(0x9a);                             /* push 0x9a */
            ii(0x19_ad87, 3);  call(0x19_cc1a, 0x1e90);                /* call 0xcc1a */
        l_0x19_ad8a:
            ii(0x19_ad8a, 1);  nop();                                  /* nop */
            ii(0x19_ad8b, 1);  push(cs);                               /* push cs */
            ii(0x19_ad8c, 3);  call(0x19_daf8, 0x2d69);                /* call 0xdaf8 */
            ii(0x19_ad8f, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_ad92, 5);  push(memw[es, bx + 298]);               /* push word [es:bx+0x12a] */
            ii(0x19_ad97, 2);  push(1);                                /* push 0x1 */
            ii(0x19_ad99, 3);  push(memw[ss, bp - 68]);                /* push word [bp-0x44] */
            ii(0x19_ad9c, 3);  push(memw[ss, bp - 70]);                /* push word [bp-0x46] */
            ii(0x19_ad9f, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_ada2, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_ada5, 3);  call(0x19_de46, 0x309e);                /* call 0xde46 */
            ii(0x19_ada8, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_adab, 4);  mov(memw[es, bx + 88], ax);             /* mov [es:bx+0x58], ax */
            ii(0x19_adaf, 4);  mov(memw[es, bx + 90], dx);             /* mov [es:bx+0x5a], dx */
            ii(0x19_adb3, 3);  mov(ax, memw[ss, bp - 70]);             /* mov ax, [bp-0x46] */
            ii(0x19_adb6, 3);  mov(dx, memw[ss, bp - 68]);             /* mov dx, [bp-0x44] */
            ii(0x19_adb9, 4);  mov(memw[es, bx + 76], ax);             /* mov [es:bx+0x4c], ax */
            ii(0x19_adbd, 4);  mov(memw[es, bx + 78], dx);             /* mov [es:bx+0x4e], dx */
            ii(0x19_adc1, 3);  mov(al, memb[ss, bp + 4]);              /* mov al, [bp+0x4] */
            ii(0x19_adc4, 5);  mov(memb[es, bx + 194], al);            /* mov [es:bx+0xc2], al */
            ii(0x19_adc9, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_adcc, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_adcf, 5);  mov(memw[es, bx + 190], ax);            /* mov [es:bx+0xbe], ax */
            ii(0x19_add4, 5);  mov(memw[es, bx + 192], dx);            /* mov [es:bx+0xc0], dx */
            ii(0x19_add9, 5);  cmp(memb[ds, 0x19f2], 0);               /* cmp byte [0x19f2], 0x0 */
            ii(0x19_adde, 2);  if(jz(0x19_adf3, 0x13)) goto l_0x19_adf3;/* jz 0xadf3 */
            ii(0x19_ade0, 5);  cmp(memb[ds, 0x19f3], 0);               /* cmp byte [0x19f3], 0x0 */
            ii(0x19_ade5, 2);  if(jz(0x19_adf3, 0xc)) goto l_0x19_adf3;/* jz 0xadf3 */
            ii(0x19_ade7, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_adea, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_aded, 3);  add(memw[ss, bp - 70], ax);             /* add [bp-0x46], ax */
            ii(0x19_adf0, 3);  adc(memw[ss, bp - 68], dx);             /* adc [bp-0x44], dx */
        l_0x19_adf3:
            ii(0x19_adf3, 5);  mov(memb[ds, 0x19f2], 0);               /* mov byte [0x19f2], 0x0 */
            ii(0x19_adf8, 3);  jmp(0x19_b173, 0x378); goto l_0x19_b173;/* jmp 0xb173 */
        l_0x19_adfb:
            ii(0x19_adfb, 3);  mov(ax, memw[ss, bp - 68]);             /* mov ax, [bp-0x44] */
            ii(0x19_adfe, 3);  or(ax, memw[ss, bp - 70]);              /* or ax, [bp-0x46] */
            ii(0x19_ae01, 2);  if(jz(0x19_ae12, 0xf)) goto l_0x19_ae12;/* jz 0xae12 */
            ii(0x19_ae03, 5);  cmp(memb[ds, 0x1a03], 0);               /* cmp byte [0x1a03], 0x0 */
            ii(0x19_ae08, 2);  if(jz(0x19_ae10, 6)) goto l_0x19_ae10;  /* jz 0xae10 */
            ii(0x19_ae0a, 4);  test(memb[ss, bp - 71], 0x10);          /* test byte [bp-0x47], 0x10 */
            ii(0x19_ae0e, 2);  if(jnz(0x19_ae12, 2)) goto l_0x19_ae12; /* jnz 0xae12 */
        l_0x19_ae10:
            ii(0x19_ae10, 2);  jmp(0x19_ae8d, 0x7b); goto l_0x19_ae8d; /* jmp 0xae8d */
        l_0x19_ae12:
            ii(0x19_ae12, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_ae15, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ae18, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x19_ae1b, 1);  inc(ax);                                /* inc ax */
            ii(0x19_ae1c, 1);  push(ax);                               /* push ax */
            ii(0x19_ae1d, 3);  call(0x19_a8a9, -0x577);                /* call 0xa8a9 */
            ii(0x19_ae20, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_ae23, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x19_ae26, 5);  cmp(memb[ds, 0x1a03], 0);               /* cmp byte [0x1a03], 0x0 */
            ii(0x19_ae2b, 2);  if(jz(0x19_ae3b, 0xe)) goto l_0x19_ae3b;/* jz 0xae3b */
            ii(0x19_ae2d, 4);  test(memb[ss, bp - 71], 0x10);          /* test byte [bp-0x47], 0x10 */
            ii(0x19_ae31, 2);  if(jz(0x19_ae3b, 8)) goto l_0x19_ae3b;  /* jz 0xae3b */
            ii(0x19_ae33, 4);  add(memw[ss, bp - 22], 0);              /* add word [bp-0x16], 0x0 */
            ii(0x19_ae37, 4);  adc(memw[ss, bp - 20], 1);              /* adc word [bp-0x14], 0x1 */
        l_0x19_ae3b:
            ii(0x19_ae3b, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_ae3e, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_ae41, 3);  push(memw[ss, bp - 56]);                /* push word [bp-0x38] */
            ii(0x19_ae44, 2);  push(1);                                /* push 0x1 */
            ii(0x19_ae46, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_ae49, 3);  push(memw[ss, bp - 22]);                /* push word [bp-0x16] */
            ii(0x19_ae4c, 3);  call(0x19_c975, 0x1b26);                /* call 0xc975 */
            ii(0x19_ae4f, 3);  mov(memw[ss, bp - 70], ax);             /* mov [bp-0x46], ax */
            ii(0x19_ae52, 3);  mov(memw[ss, bp - 68], dx);             /* mov [bp-0x44], dx */
            ii(0x19_ae55, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_ae57, 2);  if(jnz(0x19_ae5c, 3)) goto l_0x19_ae5c; /* jnz 0xae5c */
            ii(0x19_ae59, 3);  jmp(0x19_abe7, -0x275); goto l_0x19_abe7;/* jmp 0xabe7 */
        l_0x19_ae5c:
            ii(0x19_ae5c, 5);  cmp(memb[ds, 0x1a03], 0);               /* cmp byte [0x1a03], 0x0 */
            ii(0x19_ae61, 2);  if(jz(0x19_ae7a, 0x17)) goto l_0x19_ae7a;/* jz 0xae7a */
            ii(0x19_ae63, 4);  test(memb[ss, bp - 71], 0x10);          /* test byte [bp-0x47], 0x10 */
            ii(0x19_ae67, 2);  if(jz(0x19_ae7a, 0x11)) goto l_0x19_ae7a;/* jz 0xae7a */
            ii(0x19_ae69, 3);  mov(dx, memw[ss, bp - 68]);             /* mov dx, [bp-0x44] */
            ii(0x19_ae6c, 3);  add(ax, 0xffff);                        /* add ax, 0xffff */
            ii(0x19_ae6f, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x19_ae72, 5);  mov(memw[ss, bp - 70], 0);              /* mov word [bp-0x46], 0x0 */
            ii(0x19_ae77, 3);  mov(memw[ss, bp - 68], dx);             /* mov [bp-0x44], dx */
        l_0x19_ae7a:
            ii(0x19_ae7a, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_ae7d, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_ae80, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_ae83, 5);  add(memw[es, bx + 190], ax);            /* add [es:bx+0xbe], ax */
            ii(0x19_ae88, 5);  adc(memw[es, bx + 192], dx);            /* adc [es:bx+0xc0], dx */
        l_0x19_ae8d:
            ii(0x19_ae8d, 4);  test(memb[ss, bp - 71], 0x10);          /* test byte [bp-0x47], 0x10 */
            ii(0x19_ae91, 2);  if(jnz(0x19_ae96, 3)) goto l_0x19_ae96; /* jnz 0xae96 */
            ii(0x19_ae93, 3);  jmp(0x19_af37, 0xa1); goto l_0x19_af37; /* jmp 0xaf37 */
        l_0x19_ae96:
            ii(0x19_ae96, 4);  imul(bx, memw[ss, bp - 56], 0x18);      /* imul bx, [bp-0x38], 0x18 */
            ii(0x19_ae9a, 3);  add(bx, memw[ss, bp - 26]);             /* add bx, [bp-0x1a] */
            ii(0x19_ae9d, 3);  mov(es, memw[ss, bp - 24]);             /* mov es, [bp-0x18] */
            ii(0x19_aea0, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_aea2, 4);  mov(memw[es, bx + 6], ax);              /* mov [es:bx+0x6], ax */
            ii(0x19_aea6, 4);  mov(memw[es, bx + 4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x19_aeaa, 1);  push(ax);                               /* push ax */
            ii(0x19_aeab, 1);  push(ax);                               /* push ax */
            ii(0x19_aeac, 3);  push(memw[ss, bp - 68]);                /* push word [bp-0x44] */
            ii(0x19_aeaf, 3);  push(memw[ss, bp - 70]);                /* push word [bp-0x46] */
            ii(0x19_aeb2, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_aeb6, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_aeb9, 3);  call(0x19_de46, 0x2f8a);                /* call 0xde46 */
            ii(0x19_aebc, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_aebf, 3);  mov(memw[ss, bp - 48], dx);             /* mov [bp-0x30], dx */
            ii(0x19_aec2, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_aec4, 2);  if(jnz(0x19_aec9, 3)) goto l_0x19_aec9; /* jnz 0xaec9 */
            ii(0x19_aec6, 3);  jmp(0x19_abe7, -0x2e2); goto l_0x19_abe7;/* jmp 0xabe7 */
        l_0x19_aec9:
            ii(0x19_aec9, 3);  mov(ax, memw[ss, bp - 48]);             /* mov ax, [bp-0x30] */
            ii(0x19_aecc, 4);  imul(bx, memw[ss, bp - 56], 0x18);      /* imul bx, [bp-0x38], 0x18 */
            ii(0x19_aed0, 3);  add(bx, memw[ss, bp - 26]);             /* add bx, [bp-0x1a] */
            ii(0x19_aed3, 3);  mov(es, memw[ss, bp - 24]);             /* mov es, [bp-0x18] */
            ii(0x19_aed6, 4);  mov(memw[es, bx + 20], ax);             /* mov [es:bx+0x14], ax */
            ii(0x19_aeda, 6);  mov(memw[es, bx + 22], 0);              /* mov word [es:bx+0x16], 0x0 */
            ii(0x19_aee0, 1);  push(ax);                               /* push ax */
            ii(0x19_aee1, 2);  mov(si, bx);                            /* mov si, bx */
            ii(0x19_aee3, 2);  mov(di, es);                            /* mov di, es */
            ii(0x19_aee5, 1);  nop();                                  /* nop */
            ii(0x19_aee6, 1);  push(cs);                               /* push cs */
            ii(0x19_aee7, 3);  call(0x1a_100b, 0x6121);                /* call 0x100b */
            ii(0x19_aeea, 1);  pop(bx);                                /* pop bx */
            ii(0x19_aeeb, 2);  mov(cl, 8);                             /* mov cl, 0x8 */
            ii(0x19_aeed, 5);  call_far_abs(0x80, 0x4378);             /* call word 0x80:0x4378 */
            ii(0x19_aef2, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_aef5, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_aef8, 2);  mov(es, di);                            /* mov es, di */
            ii(0x19_aefa, 5);  test(memb[es, si + 9], 0x20);           /* test byte [es:si+0x9], 0x20 */
            ii(0x19_aeff, 2);  if(jz(0x19_af07, 6)) goto l_0x19_af07;  /* jz 0xaf07 */
            ii(0x19_af01, 4);  or(memb[ss, bp - 29], 0x40);            /* or byte [bp-0x1d], 0x40 */
            ii(0x19_af05, 2);  jmp(0x19_af0b, 4); goto l_0x19_af0b;    /* jmp 0xaf0b */
        l_0x19_af07:
            ii(0x19_af07, 4);  and(memb[ss, bp - 29], -0x41 /* 0xbf */);/* and byte [bp-0x1d], 0xbf */
        l_0x19_af0b:
            ii(0x19_af0b, 4);  imul(si, memw[ss, bp - 56], 0x18);      /* imul si, [bp-0x38], 0x18 */
            ii(0x19_af0f, 3);  mov(bx, memw[ss, bp - 26]);             /* mov bx, [bp-0x1a] */
            ii(0x19_af12, 5);  test(memb[es, bx + si + 8], 4);         /* test byte [es:bx+si+0x8], 0x4 */
            ii(0x19_af17, 2);  if(jz(0x19_af1d, 4)) goto l_0x19_af1d;  /* jz 0xaf1d */
            ii(0x19_af19, 4);  or(memb[ss, bp - 30], 8);               /* or byte [bp-0x1e], 0x8 */
        l_0x19_af1d:
            ii(0x19_af1d, 3);  mov(ax, 9);                             /* mov ax, 0x9 */
            ii(0x19_af20, 3);  mov(bx, memw[ss, bp - 48]);             /* mov bx, [bp-0x30] */
            ii(0x19_af23, 3);  mov(cx, memw[ss, bp - 30]);             /* mov cx, [bp-0x1e] */
            ii(0x19_af26, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_af28, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_af2b, 3);  push(memw[ss, bp - 50]);                /* push word [bp-0x32] */
            ii(0x19_af2e, 5);  call_far_abs(0x80, 0x55dc);             /* call word 0x80:0x55dc */
            ii(0x19_af33, 1);  pop(bx);                                /* pop bx */
            ii(0x19_af34, 1);  pop(bx);                                /* pop bx */
            ii(0x19_af35, 2);  jmp(0x19_af4c, 0x15); goto l_0x19_af4c; /* jmp 0xaf4c */
        l_0x19_af37:
            ii(0x19_af37, 3);  mov(ax, memw[ss, bp - 70]);             /* mov ax, [bp-0x46] */
            ii(0x19_af3a, 3);  mov(dx, memw[ss, bp - 68]);             /* mov dx, [bp-0x44] */
            ii(0x19_af3d, 4);  imul(si, memw[ss, bp - 56], 0x18);      /* imul si, [bp-0x38], 0x18 */
            ii(0x19_af41, 3);  les(bx, memw[ss, bp - 26]);             /* les bx, [bp-0x1a] */
            ii(0x19_af44, 4);  mov(memw[es, bx + si + 4], ax);         /* mov [es:bx+si+0x4], ax */
            ii(0x19_af48, 4);  mov(memw[es, bx + si + 6], dx);         /* mov [es:bx+si+0x6], dx */
        l_0x19_af4c:
            ii(0x19_af4c, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x19_af4f, 3);  mov(memw[ss, bp - 36], dx);             /* mov [bp-0x24], dx */
            ii(0x19_af52, 5);  mov(memw[ss, bp - 62], 0);              /* mov word [bp-0x3e], 0x0 */
            ii(0x19_af57, 3);  jmp(0x19_b064, 0x10a); goto l_0x19_b064;/* jmp 0xb064 */
        l_0x19_af5a:
            ii(0x19_af5a, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_af5d, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_af60, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_af63, 5);  push(memw[es, bx + 180]);               /* push word [es:bx+0xb4] */
            ii(0x19_af68, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_af6b, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_af6e, 3);  push(memw[ss, bp - 64]);                /* push word [bp-0x40] */
            ii(0x19_af71, 3);  push(memw[ss, bp - 66]);                /* push word [bp-0x42] */
            ii(0x19_af74, 3);  call(0x19_cbcd, 0x1c56);                /* call 0xcbcd */
        l_0x19_af77:
            ii(0x19_af77, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_af7a, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_af7c, 3);  cmp(dx, memw[ss, bp - 64]);             /* cmp dx, [bp-0x40] */
            ii(0x19_af7f, 2);  if(jae(0x19_af84, 3)) goto l_0x19_af84; /* jae 0xaf84 */
            ii(0x19_af81, 3);  jmp(0x19_b042, 0xbe); goto l_0x19_b042; /* jmp 0xb042 */
        l_0x19_af84:
            ii(0x19_af84, 2);  if(ja(0x19_af8e, 8)) goto l_0x19_af8e;  /* ja 0xaf8e */
            ii(0x19_af86, 3);  cmp(ax, memw[ss, bp - 66]);             /* cmp ax, [bp-0x42] */
            ii(0x19_af89, 2);  if(ja(0x19_af8e, 3)) goto l_0x19_af8e;  /* ja 0xaf8e */
            ii(0x19_af8b, 3);  jmp(0x19_b042, 0xb4); goto l_0x19_b042; /* jmp 0xb042 */
        l_0x19_af8e:
            ii(0x19_af8e, 5);  cmp(memb[ds, 0x19f4], 0);               /* cmp byte [0x19f4], 0x0 */
            ii(0x19_af93, 2);  if(jz(0x19_af98, 3)) goto l_0x19_af98;  /* jz 0xaf98 */
            ii(0x19_af95, 3);  jmp(0x19_b042, 0xaa); goto l_0x19_b042; /* jmp 0xb042 */
        l_0x19_af98:
            ii(0x19_af98, 1);  push(dx);                               /* push dx */
            ii(0x19_af99, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x19_af9b, 3);  mov(bx, memw[ss, bp - 66]);             /* mov bx, [bp-0x42] */
            ii(0x19_af9e, 2);  sub(cx, bx);                            /* sub cx, bx */
            ii(0x19_afa0, 1);  push(cx);                               /* push cx */
            ii(0x19_afa1, 1);  push(dx);                               /* push dx */
            ii(0x19_afa2, 1);  push(dx);                               /* push dx */
            ii(0x19_afa3, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_afa6, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_afa9, 1);  push(dx);                               /* push dx */
            ii(0x19_afaa, 1);  push(ax);                               /* push ax */
            ii(0x19_afab, 2);  mov(si, bx);                            /* mov si, bx */
            ii(0x19_afad, 3);  call(0x19_de46, 0x2e96);                /* call 0xde46 */
            ii(0x19_afb0, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_afb3, 3);  mov(memw[ss, bp - 48], dx);             /* mov [bp-0x30], dx */
            ii(0x19_afb6, 2);  add(ax, si);                            /* add ax, si */
            ii(0x19_afb8, 2);  jmp(0x19_b02f, 0x75); goto l_0x19_b02f; /* jmp 0xb02f */
        l_0x19_afba:
            ii(0x19_afba, 3);  cmp(ax, 1);                             /* cmp ax, 0x1 */
            ii(0x19_afbd, 2);  if(jnz(0x19_b006, 0x47)) goto l_0x19_b006;/* jnz 0xb006 */
            ii(0x19_afbf, 2);  push(0);                                /* push 0x0 */
            ii(0x19_afc1, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_afc4, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_afc7, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_afca, 5);  push(memw[es, bx + 180]);               /* push word [es:bx+0xb4] */
            ii(0x19_afcf, 5);  call_far_abs(0x80, 0x3b06);             /* call word 0x80:0x3b06 */
            ii(0x19_afd4, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_afd7, 2);  push(0);                                /* push 0x0 */
            ii(0x19_afd9, 2);  push(0);                                /* push 0x0 */
            ii(0x19_afdb, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_afde, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_afe1, 2);  push(0);                                /* push 0x0 */
            ii(0x19_afe3, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x19_afe6, 3);  call(0x19_de46, 0x2e5d);                /* call 0xde46 */
            ii(0x19_afe9, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_afec, 3);  mov(memw[ss, bp - 48], dx);             /* mov [bp-0x30], dx */
            ii(0x19_afef, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_aff2, 5);  push(memw[es, bx + 180]);               /* push word [es:bx+0xb4] */
            ii(0x19_aff7, 3);  push(memw[ss, bp - 66]);                /* push word [bp-0x42] */
            ii(0x19_affa, 3);  lea(ax, memw[ss, bp - 50]);             /* lea ax, [bp-0x32] */
            ii(0x19_affd, 1);  push(ss);                               /* push ss */
            ii(0x19_affe, 1);  push(ax);                               /* push ax */
            ii(0x19_afff, 1);  nop();                                  /* nop */
            ii(0x19_b000, 1);  push(cs);                               /* push cs */
            ii(0x19_b001, 3);  call(0x1a_0e81, 0x5e7d);                /* call 0xe81 */
            ii(0x19_b004, 2);  jmp(0x19_b039, 0x33); goto l_0x19_b039; /* jmp 0xb039 */
        l_0x19_b006:
            ii(0x19_b006, 3);  cmp(ax, 3);                             /* cmp ax, 0x3 */
            ii(0x19_b009, 2);  if(jnz(0x19_b042, 0x37)) goto l_0x19_b042;/* jnz 0xb042 */
            ii(0x19_b00b, 5);  cmp(memb[ds, 0x19f4], 0);               /* cmp byte [0x19f4], 0x0 */
            ii(0x19_b010, 2);  if(jnz(0x19_b042, 0x30)) goto l_0x19_b042;/* jnz 0xb042 */
            ii(0x19_b012, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b014, 3);  push(memw[ss, bp - 40]);                /* push word [bp-0x28] */
            ii(0x19_b017, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b019, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b01b, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_b01e, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_b021, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b023, 3);  push(memw[ss, bp - 40]);                /* push word [bp-0x28] */
            ii(0x19_b026, 3);  call(0x19_de46, 0x2e1d);                /* call 0xde46 */
            ii(0x19_b029, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_b02c, 3);  mov(memw[ss, bp - 48], dx);             /* mov [bp-0x30], dx */
        l_0x19_b02f:
            ii(0x19_b02f, 1);  push(dx);                               /* push dx */
            ii(0x19_b030, 1);  push(ax);                               /* push ax */
            ii(0x19_b031, 1);  nop();                                  /* nop */
            ii(0x19_b032, 1);  push(cs);                               /* push cs */
            ii(0x19_b033, 3);  call(0x1a_0faf, 0x5f79);                /* call 0xfaf */
            ii(0x19_b036, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x19_b039:
            ii(0x19_b039, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_b03c, 3);  push(memw[ss, bp - 50]);                /* push word [bp-0x32] */
            ii(0x19_b03f, 3);  call(0x19_df78, 0x2f36);                /* call 0xdf78 */
        l_0x19_b042:
            ii(0x19_b042, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_b045, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_b047, 3);  add(memw[ss, bp - 6], ax);              /* add [bp-0x6], ax */
            ii(0x19_b04a, 3);  adc(memw[ss, bp - 4], dx);              /* adc [bp-0x4], dx */
            ii(0x19_b04d, 3);  add(memw[ss, bp - 70], ax);             /* add [bp-0x46], ax */
            ii(0x19_b050, 3);  adc(memw[ss, bp - 68], dx);             /* adc [bp-0x44], dx */
            ii(0x19_b053, 3);  add(memw[ss, bp - 38], ax);             /* add [bp-0x26], ax */
            ii(0x19_b056, 3);  adc(memw[ss, bp - 36], dx);             /* adc [bp-0x24], dx */
            ii(0x19_b059, 4);  add(memw[ss, bp - 34], 1);              /* add word [bp-0x22], 0x1 */
            ii(0x19_b05d, 4);  adc(memw[ss, bp - 32], 0);              /* adc word [bp-0x20], 0x0 */
            ii(0x19_b061, 3);  inc(memw[ss, bp - 62]);                 /* inc word [bp-0x3e] */
        l_0x19_b064:
            ii(0x19_b064, 3);  mov(ax, memw[ss, bp - 62]);             /* mov ax, [bp-0x3e] */
            ii(0x19_b067, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_b069, 4);  imul(si, memw[ss, bp - 56], 0x18);      /* imul si, [bp-0x38], 0x18 */
            ii(0x19_b06d, 3);  les(bx, memw[ss, bp - 26]);             /* les bx, [bp-0x1a] */
            ii(0x19_b070, 4);  cmp(memw[es, bx + si + 18], dx);        /* cmp [es:bx+si+0x12], dx */
            ii(0x19_b074, 2);  if(jb(0x19_b0d1, 0x5b)) goto l_0x19_b0d1;/* jb 0xb0d1 */
            ii(0x19_b076, 2);  if(ja(0x19_b07e, 6)) goto l_0x19_b07e;  /* ja 0xb07e */
            ii(0x19_b078, 4);  cmp(memw[es, bx + si + 16], ax);        /* cmp [es:bx+si+0x10], ax */
            ii(0x19_b07c, 2);  if(jbe(0x19_b0d1, 0x53)) goto l_0x19_b0d1;/* jbe 0xb0d1 */
        l_0x19_b07e:
            ii(0x19_b07e, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_b081, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_b084, 3);  push(memw[ss, bp - 56]);                /* push word [bp-0x38] */
            ii(0x19_b087, 1);  push(ax);                               /* push ax */
            ii(0x19_b088, 3);  lea(ax, memw[ss, bp - 66]);             /* lea ax, [bp-0x42] */
            ii(0x19_b08b, 1);  push(ss);                               /* push ss */
            ii(0x19_b08c, 1);  push(ax);                               /* push ax */
            ii(0x19_b08d, 3);  lea(cx, memw[ss, bp - 60]);             /* lea cx, [bp-0x3c] */
            ii(0x19_b090, 1);  push(ss);                               /* push ss */
            ii(0x19_b091, 1);  push(cx);                               /* push cx */
            ii(0x19_b092, 3);  lea(cx, memw[ss, bp - 14]);             /* lea cx, [bp-0xe] */
            ii(0x19_b095, 1);  push(ss);                               /* push ss */
            ii(0x19_b096, 1);  push(cx);                               /* push cx */
            ii(0x19_b097, 3);  call(0x19_dc78, 0x2bde);                /* call 0xdc78 */
            ii(0x19_b09a, 3);  mov(memw[ss, bp - 72], ax);             /* mov [bp-0x48], ax */
            ii(0x19_b09d, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_b09f, 2);  if(jz(0x19_b0a4, 3)) goto l_0x19_b0a4;  /* jz 0xb0a4 */
            ii(0x19_b0a1, 3);  jmp(0x19_afba, -0xea); goto l_0x19_afba;/* jmp 0xafba */
        l_0x19_b0a4:
            ii(0x19_b0a4, 5);  cmp(memb[ds, 0x19f4], 1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_b0a9, 2);  if(jz(0x19_b0ae, 3)) goto l_0x19_b0ae;  /* jz 0xb0ae */
            ii(0x19_b0ab, 3);  jmp(0x19_af5a, -0x154); goto l_0x19_af5a;/* jmp 0xaf5a */
        l_0x19_b0ae:
            ii(0x19_b0ae, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_b0b1, 5);  push(memw[es, bx + 198]);               /* push word [es:bx+0xc6] */
            ii(0x19_b0b6, 5);  push(memw[es, bx + 196]);               /* push word [es:bx+0xc4] */
            ii(0x19_b0bb, 3);  push(memw[ss, bp - 64]);                /* push word [bp-0x40] */
            ii(0x19_b0be, 3);  push(memw[ss, bp - 66]);                /* push word [bp-0x42] */
            ii(0x19_b0c1, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_b0c4, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_b0c7, 4);  call_far_ind(memw[ds, 0x1a04]);         /* call far word [0x1a04] */
            ii(0x19_b0cb, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_b0ce, 3);  jmp(0x19_af77, -0x15a); goto l_0x19_af77;/* jmp 0xaf77 */
        l_0x19_b0d1:
            ii(0x19_b0d1, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x19_b0d4, 3);  mov(dx, memw[ss, bp - 4]);              /* mov dx, [bp-0x4] */
            ii(0x19_b0d7, 4);  imul(bx, memw[ss, bp - 56], 0x18);      /* imul bx, [bp-0x38], 0x18 */
            ii(0x19_b0db, 3);  les(si, memw[ss, bp - 26]);             /* les si, [bp-0x1a] */
            ii(0x19_b0de, 4);  cmp(memw[es, bx + si + 2], dx);         /* cmp [es:bx+si+0x2], dx */
            ii(0x19_b0e2, 2);  if(jb(0x19_b162, 0x7e)) goto l_0x19_b162;/* jb 0xb162 */
            ii(0x19_b0e4, 2);  if(ja(0x19_b0eb, 5)) goto l_0x19_b0eb;  /* ja 0xb0eb */
            ii(0x19_b0e6, 3);  cmp(memw[es, bx + si], ax);             /* cmp [es:bx+si], ax */
            ii(0x19_b0e9, 2);  if(jbe(0x19_b162, 0x77)) goto l_0x19_b162;/* jbe 0xb162 */
        l_0x19_b0eb:
            ii(0x19_b0eb, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b0ed, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b0ef, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x19_b0f2, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_b0f5, 3);  mov(cx, memw[es, bx + si]);             /* mov cx, [es:bx+si] */
            ii(0x19_b0f8, 4);  mov(di, memw[es, bx + si + 2]);         /* mov di, [es:bx+si+0x2] */
            ii(0x19_b0fc, 2);  sub(cx, ax);                            /* sub cx, ax */
            ii(0x19_b0fe, 2);  sbb(di, dx);                            /* sbb di, dx */
            ii(0x19_b100, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_b103, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_b105, 2);  cmp(di, dx);                            /* cmp di, dx */
            ii(0x19_b107, 2);  if(jb(0x19_b113, 0xa)) goto l_0x19_b113;/* jb 0xb113 */
            ii(0x19_b109, 2);  if(ja(0x19_b10f, 4)) goto l_0x19_b10f;  /* ja 0xb10f */
            ii(0x19_b10b, 2);  cmp(cx, ax);                            /* cmp cx, ax */
            ii(0x19_b10d, 2);  if(jbe(0x19_b113, 4)) goto l_0x19_b113; /* jbe 0xb113 */
        l_0x19_b10f:
            ii(0x19_b10f, 2);  mov(di, dx);                            /* mov di, dx */
            ii(0x19_b111, 2);  mov(cx, ax);                            /* mov cx, ax */
        l_0x19_b113:
            ii(0x19_b113, 3);  mov(memw[ss, bp - 8], cx);              /* mov [bp-0x8], cx */
            ii(0x19_b116, 1);  push(dx);                               /* push dx */
            ii(0x19_b117, 1);  push(cx);                               /* push cx */
            ii(0x19_b118, 3);  call(0x19_de46, 0x2d2b);                /* call 0xde46 */
            ii(0x19_b11b, 3);  mov(memw[ss, bp - 50], ax);             /* mov [bp-0x32], ax */
            ii(0x19_b11e, 3);  mov(memw[ss, bp - 48], dx);             /* mov [bp-0x30], dx */
            ii(0x19_b121, 5);  cmp(memb[ds, 0x19f4], 0);               /* cmp byte [0x19f4], 0x0 */
            ii(0x19_b126, 2);  if(jnz(0x19_b137, 0xf)) goto l_0x19_b137;/* jnz 0xb137 */
            ii(0x19_b128, 2);  push(0);                                /* push 0x0 */
            ii(0x19_b12a, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x19_b12d, 1);  push(dx);                               /* push dx */
            ii(0x19_b12e, 1);  push(ax);                               /* push ax */
            ii(0x19_b12f, 1);  nop();                                  /* nop */
            ii(0x19_b130, 1);  push(cs);                               /* push cs */
            ii(0x19_b131, 3);  call(0x1a_0faf, 0x5e7b);                /* call 0xfaf */
            ii(0x19_b134, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x19_b137:
            ii(0x19_b137, 3);  push(memw[ss, bp - 48]);                /* push word [bp-0x30] */
            ii(0x19_b13a, 3);  push(memw[ss, bp - 50]);                /* push word [bp-0x32] */
            ii(0x19_b13d, 3);  call(0x19_df78, 0x2e38);                /* call 0xdf78 */
            ii(0x19_b140, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_b143, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_b145, 3);  add(memw[ss, bp - 6], ax);              /* add [bp-0x6], ax */
            ii(0x19_b148, 3);  adc(memw[ss, bp - 4], dx);              /* adc [bp-0x4], dx */
            ii(0x19_b14b, 3);  add(memw[ss, bp - 70], ax);             /* add [bp-0x46], ax */
            ii(0x19_b14e, 3);  adc(memw[ss, bp - 68], dx);             /* adc [bp-0x44], dx */
            ii(0x19_b151, 3);  add(memw[ss, bp - 38], ax);             /* add [bp-0x26], ax */
            ii(0x19_b154, 3);  adc(memw[ss, bp - 36], dx);             /* adc [bp-0x24], dx */
            ii(0x19_b157, 4);  add(memw[ss, bp - 54], 1);              /* add word [bp-0x36], 0x1 */
            ii(0x19_b15b, 4);  adc(memw[ss, bp - 52], 0);              /* adc word [bp-0x34], 0x0 */
            ii(0x19_b15f, 3);  jmp(0x19_b0d1, -0x91); goto l_0x19_b0d1;/* jmp 0xb0d1 */
        l_0x19_b162:
            ii(0x19_b162, 4);  cmp(memw[ss, bp + 4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x19_b166, 2);  if(jnz(0x19_b170, 8)) goto l_0x19_b170; /* jnz 0xb170 */
            ii(0x19_b168, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_b16a, 3);  mov(memw[ss, bp - 68], ax);             /* mov [bp-0x44], ax */
            ii(0x19_b16d, 3);  mov(memw[ss, bp - 70], ax);             /* mov [bp-0x46], ax */
        l_0x19_b170:
            ii(0x19_b170, 3);  inc(memw[ss, bp - 56]);                 /* inc word [bp-0x38] */
        l_0x19_b173:
            ii(0x19_b173, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x19_b176, 3);  les(bx, memw[ss, bp - 44]);             /* les bx, [bp-0x2c] */
            ii(0x19_b179, 4);  cmp(memw[es, bx + 68], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_b17d, 2);  if(jbe(0x19_b1cd, 0x4e)) goto l_0x19_b1cd;/* jbe 0xb1cd */
            ii(0x19_b17f, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_b181, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x19_b184, 3);  mov(memw[ss, bp - 6], cx);              /* mov [bp-0x6], cx */
            ii(0x19_b187, 3);  imul(bx, ax, 0x18);                     /* imul bx, ax, 0x18 */
            ii(0x19_b18a, 3);  les(si, memw[ss, bp - 26]);             /* les si, [bp-0x1a] */
            ii(0x19_b18d, 4);  mov(ax, memw[es, bx + si + 2]);         /* mov ax, [es:bx+si+0x2] */
            ii(0x19_b191, 3);  or(ax, memw[es, bx + si]);              /* or ax, [es:bx+si] */
            ii(0x19_b194, 2);  if(jz(0x19_b170, -0x26)) goto l_0x19_b170;/* jz 0xb170 */
            ii(0x19_b196, 4);  imul(bx, memw[ss, bp - 56], 0x18);      /* imul bx, [bp-0x38], 0x18 */
            ii(0x19_b19a, 2);  add(bx, si);                            /* add bx, si */
            ii(0x19_b19c, 4);  mov(ax, memw[es, bx + 8]);              /* mov ax, [es:bx+0x8] */
            ii(0x19_b1a0, 3);  mov(memw[ss, bp - 72], ax);             /* mov [bp-0x48], ax */
            ii(0x19_b1a3, 2);  mov(ax, es);                            /* mov ax, es */
            ii(0x19_b1a5, 3);  les(si, memw[ss, bp - 44]);             /* les si, [bp-0x2c] */
            ii(0x19_b1a8, 5);  test(memb[es, si + 16], 0x10);          /* test byte [es:si+0x10], 0x10 */
            ii(0x19_b1ad, 2);  if(jnz(0x19_b1b2, 3)) goto l_0x19_b1b2; /* jnz 0xb1b2 */
            ii(0x19_b1af, 3);  jmp(0x19_adfb, -0x3b7); goto l_0x19_adfb;/* jmp 0xadfb */
        l_0x19_b1b2:
            ii(0x19_b1b2, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_b1b4, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_b1b8, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_b1bc, 4);  add(ax, memw[ds, 0x19ea]);              /* add ax, [0x19ea] */
            ii(0x19_b1c0, 4);  adc(dx, memw[ds, 0x19ec]);              /* adc dx, [0x19ec] */
            ii(0x19_b1c4, 3);  mov(memw[ss, bp - 70], ax);             /* mov [bp-0x46], ax */
            ii(0x19_b1c7, 3);  mov(memw[ss, bp - 68], dx);             /* mov [bp-0x44], dx */
            ii(0x19_b1ca, 3);  jmp(0x19_ae8d, -0x340); goto l_0x19_ae8d;/* jmp 0xae8d */
        l_0x19_b1cd:
            ii(0x19_b1cd, 4);  mov(ax, memw[es, bx + 26]);             /* mov ax, [es:bx+0x1a] */
            ii(0x19_b1d1, 4);  or(ax, memw[es, bx + 24]);              /* or ax, [es:bx+0x18] */
            ii(0x19_b1d5, 2);  if(jz(0x19_b1f5, 0x1e)) goto l_0x19_b1f5;/* jz 0xb1f5 */
            ii(0x19_b1d7, 5);  imul(ax, memw[es, bx + 24], 0x18);      /* imul ax, [es:bx+0x18], 0x18 */
            ii(0x19_b1dc, 3);  add(ax, memw[ss, bp - 26]);             /* add ax, [bp-0x1a] */
            ii(0x19_b1df, 3);  mov(dx, memw[ss, bp - 24]);             /* mov dx, [bp-0x18] */
            ii(0x19_b1e2, 3);  sub(ax, 0x18);                          /* sub ax, 0x18 */
            ii(0x19_b1e5, 1);  push(dx);                               /* push dx */
            ii(0x19_b1e6, 1);  push(ax);                               /* push ax */
            ii(0x19_b1e7, 3);  call(0x19_cd74, 0x1b8a);                /* call 0xcd74 */
            ii(0x19_b1ea, 3);  les(bx, memw[ss, bp - 44]);             /* les bx, [bp-0x2c] */
            ii(0x19_b1ed, 4);  add(memw[es, bx + 28], ax);             /* add [es:bx+0x1c], ax */
            ii(0x19_b1f1, 4);  adc(memw[es, bx + 30], dx);             /* adc [es:bx+0x1e], dx */
        l_0x19_b1f5:
            ii(0x19_b1f5, 3);  les(bx, memw[ss, bp - 44]);             /* les bx, [bp-0x2c] */
            ii(0x19_b1f8, 4);  mov(ax, memw[es, bx + 34]);             /* mov ax, [es:bx+0x22] */
            ii(0x19_b1fc, 4);  or(ax, memw[es, bx + 32]);              /* or ax, [es:bx+0x20] */
            ii(0x19_b200, 2);  if(jz(0x19_b220, 0x1e)) goto l_0x19_b220;/* jz 0xb220 */
            ii(0x19_b202, 5);  imul(ax, memw[es, bx + 32], 0x18);      /* imul ax, [es:bx+0x20], 0x18 */
            ii(0x19_b207, 3);  add(ax, memw[ss, bp - 26]);             /* add ax, [bp-0x1a] */
            ii(0x19_b20a, 3);  mov(dx, memw[ss, bp - 24]);             /* mov dx, [bp-0x18] */
            ii(0x19_b20d, 3);  sub(ax, 0x18);                          /* sub ax, 0x18 */
            ii(0x19_b210, 1);  push(dx);                               /* push dx */
            ii(0x19_b211, 1);  push(ax);                               /* push ax */
            ii(0x19_b212, 3);  call(0x19_cd74, 0x1b5f);                /* call 0xcd74 */
            ii(0x19_b215, 3);  les(bx, memw[ss, bp - 44]);             /* les bx, [bp-0x2c] */
            ii(0x19_b218, 4);  add(memw[es, bx + 36], ax);             /* add [es:bx+0x24], ax */
            ii(0x19_b21c, 4);  adc(memw[es, bx + 38], dx);             /* adc [es:bx+0x26], dx */
        l_0x19_b220:
            ii(0x19_b220, 2);  sub(ax, ax);                            /* sub ax, ax */
        l_0x19_b222:
            ii(0x19_b222, 1);  pop(si);                                /* pop si */
            ii(0x19_b223, 1);  pop(di);                                /* pop di */
            ii(0x19_b224, 1);  leave();                                /* leave */
            ii(0x19_b225, 3);  ret(6);                                 /* ret 0x6 */
        }
    }
}
