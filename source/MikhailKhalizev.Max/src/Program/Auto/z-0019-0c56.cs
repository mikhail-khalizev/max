using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0c56-563edde4")]
        public void Method_0019_0c56()
        {
            ii(0x19_0c56, 4); enter(0xe, 0);                            /* enter 0xe, 0x0 */
            ii(0x19_0c5a, 1); push(di);                                 /* push di */
            ii(0x19_0c5b, 1); push(si);                                 /* push si */
            ii(0x19_0c5c, 3); lea(ax, memw[ss, bp - 0xc]);              /* lea ax, [bp-0xc] */
            ii(0x19_0c5f, 1); push(ss);                                 /* push ss */
            ii(0x19_0c60, 1); push(ax);                                 /* push ax */
            ii(0x19_0c61, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_0c64, 1); nop();                                    /* nop */
            ii(0x19_0c65, 1); push(cs);                                 /* push cs */
            ii(0x19_0c66, 3); call(0x19_4412, 0x37a9);                  /* call 0x4412 */
            ii(0x19_0c69, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_0c6c, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_0c6f, 2); if(jz(0x19_0c74, 3)) goto l_0x19_0c74;    /* jz 0xc74 */
            ii(0x19_0c71, 3); jmp(0x19_0c7d, 9); goto l_0x19_0c7d;      /* jmp 0xc7d */
        l_0x19_0c74:
            ii(0x19_0c74, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_0c77, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x19_0c7a, 3); jmp(0x19_0d04, 0x87); goto l_0x19_0d04;   /* jmp 0xd04 */
        l_0x19_0c7d:
            ii(0x19_0c7d, 3); mov(al, memb[ss, bp - 5]);                /* mov al, [bp-0x5] */
            ii(0x19_0c80, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_0c82, 3); shl(ax, 8);                               /* shl ax, 0x8 */
            ii(0x19_0c85, 3); mov(cl, memb[ss, bp - 8]);                /* mov cl, [bp-0x8] */
            ii(0x19_0c88, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x19_0c8a, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_0c8c, 3); mov(cx, memw[ss, bp - 0xa]);              /* mov cx, [bp-0xa] */
            ii(0x19_0c8f, 3); mov(memw[ss, bp - 4], cx);                /* mov [bp-0x4], cx */
            ii(0x19_0c92, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_0c95, 4); cmp(memw[ss, bp - 2], 0x10);              /* cmp word [bp-0x2], 0x10 */
            ii(0x19_0c99, 2); if(jae(0x19_0c9e, 3)) goto l_0x19_0c9e;   /* jae 0xc9e */
            ii(0x19_0c9b, 3); jmp(0x19_0cb5, 0x17); goto l_0x19_0cb5;   /* jmp 0xcb5 */
        l_0x19_0c9e:
            ii(0x19_0c9e, 2); if(jbe(0x19_0ca3, 3)) goto l_0x19_0ca3;   /* jbe 0xca3 */
            ii(0x19_0ca0, 3); jmp(0x19_0cac, 9); goto l_0x19_0cac;      /* jmp 0xcac */
        l_0x19_0ca3:
            ii(0x19_0ca3, 4); cmp(memw[ss, bp - 4], 0);                 /* cmp word [bp-0x4], 0x0 */
            ii(0x19_0ca7, 2); if(jae(0x19_0cac, 3)) goto l_0x19_0cac;   /* jae 0xcac */
            ii(0x19_0ca9, 3); jmp(0x19_0cb5, 9); goto l_0x19_0cb5;      /* jmp 0xcb5 */
        l_0x19_0cac:
            ii(0x19_0cac, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_0caf, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x19_0cb2, 3); jmp(0x19_0d04, 0x4f); goto l_0x19_0d04;   /* jmp 0xd04 */
        l_0x19_0cb5:
            ii(0x19_0cb5, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_0cb8, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x19_0cbb, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x19_0cbd, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x19_0cbf, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x19_0cc1, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x19_0cc3, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x19_0cc5, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x19_0cc7, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x19_0cc9, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x19_0ccb, 3); mov(memw[ss, bp + 8], ax);                /* mov [bp+0x8], ax */
            ii(0x19_0cce, 4); test(memb[ss, bp - 4], 0xf);              /* test byte [bp-0x4], 0xf */
            ii(0x19_0cd2, 2); if(jnz(0x19_0cd7, 3)) goto l_0x19_0cd7;   /* jnz 0xcd7 */
            ii(0x19_0cd4, 3); jmp(0x19_0cfb, 0x24); goto l_0x19_0cfb;   /* jmp 0xcfb */
        l_0x19_0cd7:
            ii(0x19_0cd7, 3); mov(al, memb[ss, bp - 4]);                /* mov al, [bp-0x4] */
            ii(0x19_0cda, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x19_0cdd, 3); add(ax, memw[ss, bp + 6]);                /* add ax, [bp+0x6] */
            ii(0x19_0ce0, 3); mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x19_0ce3, 3); mov(ax, memw[ss, bp - 0xe]);              /* mov ax, [bp-0xe] */
            ii(0x19_0ce6, 3); cmp(memw[ss, bp + 6], ax);                /* cmp [bp+0x6], ax */
            ii(0x19_0ce9, 2); if(ja(0x19_0cee, 3)) goto l_0x19_0cee;    /* ja 0xcee */
            ii(0x19_0ceb, 3); jmp(0x19_0cf5, 7); goto l_0x19_0cf5;      /* jmp 0xcf5 */
        l_0x19_0cee:
            ii(0x19_0cee, 3); inc(memw[ss, bp + 8]);                    /* inc word [bp+0x8] */
            ii(0x19_0cf1, 4); sub(memw[ss, bp - 0xe], 0x10);            /* sub word [bp-0xe], 0x10 */
        l_0x19_0cf5:
            ii(0x19_0cf5, 3); mov(ax, memw[ss, bp - 0xe]);              /* mov ax, [bp-0xe] */
            ii(0x19_0cf8, 3); mov(memw[ss, bp + 6], ax);                /* mov [bp+0x6], ax */
        l_0x19_0cfb:
            ii(0x19_0cfb, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_0cfe, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x19_0d01, 3); jmp(0x19_0d04, 0); goto l_0x19_0d04;      /* jmp 0xd04 */
        l_0x19_0d04:
            ii(0x19_0d04, 1); pop(si);                                  /* pop si */
            ii(0x19_0d05, 1); pop(di);                                  /* pop di */
            ii(0x19_0d06, 1); leave();                                  /* leave */
            ii(0x19_0d07, 1); retf();                                   /* retf */
        }
    }
}
