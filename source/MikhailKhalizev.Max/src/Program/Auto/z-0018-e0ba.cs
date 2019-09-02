using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e0ba-5c66f6ae")]
        public void Method_0018_e0ba()
        {
        l_0x18_e0ba:
            ii(0x18_e0ba, 4); mov(cx, memw[ds, 8]);                     /* mov cx, [0x8] */
            ii(0x18_e0be, 4); mov(bx, memw[ds, 2]);                     /* mov bx, [0x2] */
            ii(0x18_e0c2, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x18_e0c5, 6); test(memb[es, 0x14], 0x80);               /* test byte [es:0x14], 0x80 */
            ii(0x18_e0cb, 2); if(jz(0x18_e0d2, 5)) goto l_0x18_e0d2;    /* jz 0xe0d2 */
            ii(0x18_e0cd, 5); mov(bx, memw[es, 0xc0e]);                 /* mov bx, [es:0xc0e] */
        l_0x18_e0d2:
            ii(0x18_e0d2, 3); add(bx, 5);                               /* add bx, 0x5 */
            ii(0x18_e0d5, 2); sub(cx, bx);                              /* sub cx, bx */
            ii(0x18_e0d7, 2); if(jbe(0x18_e13d, 0x64)) goto l_0x18_e13d; /* jbe 0xe13d */
            ii(0x18_e0d9, 3); shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0x18_e0dc, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x18_e0de:
            ii(0x18_e0de, 2); xor(dx, dx);                              /* xor dx, dx */
        l_0x18_e0e0:
            ii(0x18_e0e0, 3); add(bx, 8);                               /* add bx, 0x8 */
            ii(0x18_e0e3, 2); cmp(memb[ds, bx], al);                    /* cmp [bx], al */
            ii(0x18_e0e5, 2); if(loopne(0x18_e0e0, -7)) goto l_0x18_e0e0; /* loopne 0xe0e0 */
            ii(0x18_e0e7, 2); if(jcxz(0x18_e135, 0x4c)) goto l_0x18_e135; /* jcxz 0xe135 */
        l_0x18_e0e9:
            ii(0x18_e0e9, 1); inc(dx);                                  /* inc dx */
            ii(0x18_e0ea, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x18_e0ec, 2); if(jz(0x18_e0f9, 0xb)) goto l_0x18_e0f9;  /* jz 0xe0f9 */
            ii(0x18_e0ee, 3); add(bx, 8);                               /* add bx, 0x8 */
            ii(0x18_e0f1, 2); cmp(memb[ds, bx], al);                    /* cmp [bx], al */
            ii(0x18_e0f3, 2); if(loope(0x18_e0e9, -0xc)) goto l_0x18_e0e9; /* loope 0xe0e9 */
            ii(0x18_e0f5, 2); if(jcxz(0x18_e135, 0x3e)) goto l_0x18_e135; /* jcxz 0xe135 */
            ii(0x18_e0f7, 2); jmp(0x18_e0de, -0x1b); goto l_0x18_e0de;  /* jmp 0xe0de */
        l_0x18_e0f9:
            ii(0x18_e0f9, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x18_e0fc, 5); mov(memw[es, 0xc0e], bx);                 /* mov [es:0xc0e], bx */
            ii(0x18_e101, 2); mov(ah, 0x93);                            /* mov ah, 0x93 */
            ii(0x18_e103, 3); xchg(memw[ds, bx + 4], ax);               /* xchg [bx+0x4], ax */
            ii(0x18_e106, 2); test(ah, ah);                             /* test ah, ah */
            ii(0x18_e108, 2); if(jnz(0x18_e121, 0x17)) goto l_0x18_e121; /* jnz 0xe121 */
            ii(0x18_e10a, 2); xor(al, al);                              /* xor al, al */
            ii(0x18_e10c, 2); mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x18_e10e, 3); mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0x18_e111, 3); mov(memw[ds, bx + 6], ax);                /* mov [bx+0x6], ax */
            ii(0x18_e114, 1); dec(dx);                                  /* dec dx */
            ii(0x18_e115, 2); if(jz(0x18_e11c, 5)) goto l_0x18_e11c;    /* jz 0xe11c */
            ii(0x18_e117, 3); sub(bx, 8);                               /* sub bx, 0x8 */
            ii(0x18_e11a, 2); jmp(0x18_e0f9, -0x23); goto l_0x18_e0f9;  /* jmp 0xe0f9 */
        l_0x18_e11c:
            ii(0x18_e11c, 4); mov(memw_a32[ss, ebp + 0x20], bx);        /* mov [ebp+0x20], bx */
            ii(0x18_e120, 1); ret(); return;                            /* ret */
        l_0x18_e121:
            ii(0x18_e121, 3); mov(memw[ds, bx + 4], ax);                /* mov [bx+0x4], ax */
            ii(0x18_e124, 3); add(bx, 8);                               /* add bx, 0x8 */
            ii(0x18_e127, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x18_e129, 2); if(jz(0x18_e130, 5)) goto l_0x18_e130;    /* jz 0xe130 */
            ii(0x18_e12b, 1); inc(dx);                                  /* inc dx */
            ii(0x18_e12c, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_e12e, 2); jmp(0x18_e121, -0xf); goto l_0x18_e121;   /* jmp 0xe121 */
        l_0x18_e130:
            ii(0x18_e130, 3); add(bx, 5);                               /* add bx, 0x5 */
            ii(0x18_e133, 2); jmp(0x18_e0de, -0x57); goto l_0x18_e0de;  /* jmp 0xe0de */
        l_0x18_e135:
            ii(0x18_e135, 6); test(memb[es, 0x14], 0x80);               /* test byte [es:0x14], 0x80 */
            ii(0x18_e13b, 2); if(jz_func(0x18_e150, 0x13)) return;      /* jz 0xe150 */
        l_0x18_e13d:
            ii(0x18_e13d, 3); mov(ax, 0x78);                            /* mov ax, 0x78 */
            ii(0x18_e140, 5); xchg(memw[es, 0xc0e], ax);                /* xchg [es:0xc0e], ax */
            ii(0x18_e145, 3); cmp(ax, 0x80);                            /* cmp ax, 0x80 */
            ii(0x18_e148, 2); if(jb_func(0x18_e14d, 3)) return;         /* jb 0xe14d */
            ii(0x18_e14a, 3); jmp(0x18_e0ba, -0x93); goto l_0x18_e0ba;  /* jmp 0xe0ba */
        }
    }
}
