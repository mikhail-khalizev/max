using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("456bc23e-4e7c-43de-a4d4-447eae04d386")]
        public void Method_0013_5122()
        {
            ii(0x13_5122, 1); pushw(ds);                                /* push ds */
            ii(0x13_5123, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_5126, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_5128, 1); pushw(ds);                                /* push ds */
            ii(0x13_5129, 3); pushw(0x192);                             /* push 0x192 */
            ii(0x13_512c, 1); nop();                                    /* nop */
            ii(0x13_512d, 1); pushw(cs);                                /* push cs */
            ii(0x13_512e, 3); callw(0x13_100a, -0x4127);                /* call 0x100a */
            ii(0x13_5131, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5134, 1); pushw(ds);                                /* push ds */
            ii(0x13_5135, 3); pushw(0x1b7);                             /* push 0x1b7 */
            ii(0x13_5138, 1); nop();                                    /* nop */
            ii(0x13_5139, 1); pushw(cs);                                /* push cs */
            ii(0x13_513a, 3); callw(0x13_100a, -0x4133);                /* call 0x100a */
            ii(0x13_513d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5140, 5); cmp(memb_a16[ds, 0x39], 0);               /* cmp byte [0x39], 0x0 */
            ii(0x13_5145, 2); if(jzw(0x13_514c, 0x5)) goto l_0x13_514c; /* jz 0x514c */
            ii(0x13_5147, 3); mov(ax, 0x1ca);                           /* mov ax, 0x1ca */
            ii(0x13_514a, 2); jmpw(0x13_514f, 0x3); goto l_0x13_514f;   /* jmp 0x514f */
        l_0x13_514c:
            ii(0x13_514c, 3); mov(ax, 0x1ce);                           /* mov ax, 0x1ce */
        l_0x13_514f:
            ii(0x13_514f, 1); pushw(ds);                                /* push ds */
            ii(0x13_5150, 1); pushw(ax);                                /* push ax */
            ii(0x13_5151, 1); nop();                                    /* nop */
            ii(0x13_5152, 1); pushw(cs);                                /* push cs */
            ii(0x13_5153, 3); callw(0x13_100a, -0x414c);                /* call 0x100a */
            ii(0x13_5156, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5159, 4); pushw(memw_a16[ds, 0x26]);                /* push word [0x26] */
            ii(0x13_515d, 4); pushw(memw_a16[ds, 0x24]);                /* push word [0x24] */
            ii(0x13_5161, 1); pushw(ds);                                /* push ds */
            ii(0x13_5162, 3); pushw(0x1d3);                             /* push 0x1d3 */
            ii(0x13_5165, 1); nop();                                    /* nop */
            ii(0x13_5166, 1); pushw(cs);                                /* push cs */
            ii(0x13_5167, 3); callw(0x13_100a, -0x4160);                /* call 0x100a */
            ii(0x13_516a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_516d, 4); pushw(memw_a16[ds, 0x32]);                /* push word [0x32] */
            ii(0x13_5171, 4); pushw(memw_a16[ds, 0x30]);                /* push word [0x30] */
            ii(0x13_5175, 1); pushw(ds);                                /* push ds */
            ii(0x13_5176, 3); pushw(0x1ea);                             /* push 0x1ea */
            ii(0x13_5179, 1); nop();                                    /* nop */
            ii(0x13_517a, 1); pushw(cs);                                /* push cs */
            ii(0x13_517b, 3); callw(0x13_100a, -0x4174);                /* call 0x100a */
            ii(0x13_517e, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5181, 4); pushw(memw_a16[ds, 0x36]);                /* push word [0x36] */
            ii(0x13_5185, 4); pushw(memw_a16[ds, 0x34]);                /* push word [0x34] */
            ii(0x13_5189, 1); pushw(ds);                                /* push ds */
            ii(0x13_518a, 3); pushw(0x201);                             /* push 0x201 */
            ii(0x13_518d, 1); nop();                                    /* nop */
            ii(0x13_518e, 1); pushw(cs);                                /* push cs */
            ii(0x13_518f, 3); callw(0x13_100a, -0x4188);                /* call 0x100a */
            ii(0x13_5192, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5195, 4); pushw(memw_a16[ds, 0x16]);                /* push word [0x16] */
            ii(0x13_5199, 4); pushw(memw_a16[ds, 0x14]);                /* push word [0x14] */
            ii(0x13_519d, 1); pushw(ds);                                /* push ds */
            ii(0x13_519e, 3); pushw(0x218);                             /* push 0x218 */
            ii(0x13_51a1, 1); nop();                                    /* nop */
            ii(0x13_51a2, 1); pushw(cs);                                /* push cs */
            ii(0x13_51a3, 3); callw(0x13_100a, -0x419c);                /* call 0x100a */
            ii(0x13_51a6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_51a9, 4); pushw(memw_a16[ds, 0x1a]);                /* push word [0x1a] */
            ii(0x13_51ad, 4); pushw(memw_a16[ds, 0x18]);                /* push word [0x18] */
            ii(0x13_51b1, 1); pushw(ds);                                /* push ds */
            ii(0x13_51b2, 3); pushw(0x22e);                             /* push 0x22e */
            ii(0x13_51b5, 1); nop();                                    /* nop */
            ii(0x13_51b6, 1); pushw(cs);                                /* push cs */
            ii(0x13_51b7, 3); callw(0x13_100a, -0x41b0);                /* call 0x100a */
            ii(0x13_51ba, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_51bd, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_51bf, 3); pushw(0x400);                             /* push 0x400 */
            ii(0x13_51c2, 3); mov(ax, memw_a16[ds, 0x1fc0]);            /* mov ax, [0x1fc0] */
            ii(0x13_51c5, 4); mov(dx, memw_a16[ds, 0x1fc2]);            /* mov dx, [0x1fc2] */
            ii(0x13_51c9, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_51cb, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_51cd, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_51cf, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_51d1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_51d3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_51d5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_51d7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_51d9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_51db, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_51dd, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_51df, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_51e1, 1); pushw(dx);                                /* push dx */
            ii(0x13_51e2, 1); pushw(ax);                                /* push ax */
            ii(0x13_51e3, 1); nop();                                    /* nop */
            ii(0x13_51e4, 1); pushw(cs);                                /* push cs */
            ii(0x13_51e5, 3); callw(0x12_dddc, -0x740c);                /* call 0xdddc */
            ii(0x13_51e8, 1); pushw(dx);                                /* push dx */
            ii(0x13_51e9, 1); pushw(ax);                                /* push ax */
            ii(0x13_51ea, 1); pushw(ds);                                /* push ds */
            ii(0x13_51eb, 3); pushw(0x244);                             /* push 0x244 */
            ii(0x13_51ee, 1); nop();                                    /* nop */
            ii(0x13_51ef, 1); pushw(cs);                                /* push cs */
            ii(0x13_51f0, 3); callw(0x13_100a, -0x41e9);                /* call 0x100a */
            ii(0x13_51f3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_51f6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_51f8, 3); pushw(0x400);                             /* push 0x400 */
            ii(0x13_51fb, 3); mov(ax, memw_a16[ds, 0x1fc8]);            /* mov ax, [0x1fc8] */
            ii(0x13_51fe, 4); mov(dx, memw_a16[ds, 0x1fca]);            /* mov dx, [0x1fca] */
            ii(0x13_5202, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5204, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5206, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5208, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_520a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_520c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_520e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5210, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5212, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5214, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5216, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5218, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_521a, 1); pushw(dx);                                /* push dx */
            ii(0x13_521b, 1); pushw(ax);                                /* push ax */
            ii(0x13_521c, 1); nop();                                    /* nop */
            ii(0x13_521d, 1); pushw(cs);                                /* push cs */
            ii(0x13_521e, 3); callw(0x12_dddc, -0x7445);                /* call 0xdddc */
            ii(0x13_5221, 1); pushw(dx);                                /* push dx */
            ii(0x13_5222, 1); pushw(ax);                                /* push ax */
            ii(0x13_5223, 1); pushw(ds);                                /* push ds */
            ii(0x13_5224, 3); pushw(0x272);                             /* push 0x272 */
            ii(0x13_5227, 1); nop();                                    /* nop */
            ii(0x13_5228, 1); pushw(cs);                                /* push cs */
            ii(0x13_5229, 3); callw(0x13_100a, -0x4222);                /* call 0x100a */
            ii(0x13_522c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_522f, 1); pushw(ds);                                /* push ds */
            ii(0x13_5230, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_5233, 1); pushw(ds);                                /* push ds */
            ii(0x13_5234, 3); pushw(0x289);                             /* push 0x289 */
            ii(0x13_5237, 1); nop();                                    /* nop */
            ii(0x13_5238, 1); pushw(cs);                                /* push cs */
            ii(0x13_5239, 3); callw(0x13_100a, -0x4232);                /* call 0x100a */
            ii(0x13_523c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_523f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5240, 1); retfw(); return;                          /* retf */
        }
    }
}
