using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cdd867fe-bfa7-419d-b48b-8dc2ea0b968c")]
        public void Method_0014_e0a9()
        {
            ii(0x14_e0a9, 4); mov(si, memw_a32[ss, ebp + 0x1c]);        /* mov si, [ebp+0x1c] */
            ii(0x14_e0ad, 2); or(si, si);                               /* or si, si */
            ii(0x14_e0af, 2); if(jlew_func(0x14_e062, -0x4f)) return;   /* jle 0xe062 */
            ii(0x14_e0b1, 3); pushw(0x4547);                            /* push 0x4547 */
            ii(0x14_e0b4, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e0b6, 1); popw(es);                                 /* pop es */
            ii(0x14_e0b7, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x14_e0b9, 1); popw(ds);                                 /* pop ds */
        l_0x14_e0ba:
            ii(0x14_e0ba, 4); mov(cx, memw_a16[ds, 0x8]);               /* mov cx, [0x8] */
            ii(0x14_e0be, 4); mov(bx, memw_a16[ds, 0x2]);               /* mov bx, [0x2] */
            ii(0x14_e0c2, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x14_e0c5, 6); test(memb_a16[es, 0x14], 0x80);           /* test byte [es:0x14], 0x80 */
            ii(0x14_e0cb, 2); if(jzw(0x14_e0d2, 0x5)) goto l_0x14_e0d2; /* jz 0xe0d2 */
            ii(0x14_e0cd, 5); mov(bx, memw_a16[es, 0xc0e]);             /* mov bx, [es:0xc0e] */
        l_0x14_e0d2:
            ii(0x14_e0d2, 3); add(bx, 0x5);                             /* add bx, 0x5 */
            ii(0x14_e0d5, 2); sub(cx, bx);                              /* sub cx, bx */
            ii(0x14_e0d7, 2); if(jbew(0x14_e13d, 0x64)) goto l_0x14_e13d; /* jbe 0xe13d */
            ii(0x14_e0d9, 3); shr(cx, 0x3);                             /* shr cx, 0x3 */
            ii(0x14_e0dc, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x14_e0de:
            ii(0x14_e0de, 2); xor(dx, dx);                              /* xor dx, dx */
        l_0x14_e0e0:
            ii(0x14_e0e0, 3); add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x14_e0e3, 2); cmp(memb_a16[ds, bx], al);                /* cmp [bx], al */
            ii(0x14_e0e5, 2); if(loopnew_a16(0x14_e0e0, -0x7)) goto l_0x14_e0e0; /* loopne 0xe0e0 */
            ii(0x14_e0e7, 2); if(jcxzw(0x14_e135, 0x4c)) goto l_0x14_e135; /* jcxz 0xe135 */
        l_0x14_e0e9:
            ii(0x14_e0e9, 1); inc(dx);                                  /* inc dx */
            ii(0x14_e0ea, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x14_e0ec, 2); if(jzw(0x14_e0f9, 0xb)) goto l_0x14_e0f9; /* jz 0xe0f9 */
            ii(0x14_e0ee, 3); add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x14_e0f1, 2); cmp(memb_a16[ds, bx], al);                /* cmp [bx], al */
            ii(0x14_e0f3, 2); if(loopew_a16(0x14_e0e9, -0xc)) goto l_0x14_e0e9; /* loope 0xe0e9 */
            ii(0x14_e0f5, 2); if(jcxzw(0x14_e135, 0x3e)) goto l_0x14_e135; /* jcxz 0xe135 */
            ii(0x14_e0f7, 2); jmpw(0x14_e0de, -0x1b); goto l_0x14_e0de; /* jmp 0xe0de */
        l_0x14_e0f9:
            ii(0x14_e0f9, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x14_e0fc, 5); mov(memw_a16[es, 0xc0e], bx);             /* mov [es:0xc0e], bx */
            ii(0x14_e101, 2); mov(ah, 0x93);                            /* mov ah, 0x93 */
            ii(0x14_e103, 3); xchg(memw_a16[ds, bx + 0x4], ax);         /* xchg [bx+0x4], ax */
            ii(0x14_e106, 2); test(ah, ah);                             /* test ah, ah */
            ii(0x14_e108, 2); if(jnzw(0x14_e121, 0x17)) goto l_0x14_e121; /* jnz 0xe121 */
            ii(0x14_e10a, 2); xor(al, al);                              /* xor al, al */
            ii(0x14_e10c, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x14_e10e, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x14_e111, 3); mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x14_e114, 1); dec(dx);                                  /* dec dx */
            ii(0x14_e115, 2); if(jzw(0x14_e11c, 0x5)) goto l_0x14_e11c; /* jz 0xe11c */
            ii(0x14_e117, 3); sub(bx, 0x8);                             /* sub bx, 0x8 */
            ii(0x14_e11a, 2); jmpw(0x14_e0f9, -0x23); goto l_0x14_e0f9; /* jmp 0xe0f9 */
        l_0x14_e11c:
            ii(0x14_e11c, 4); mov(memw_a32[ss, ebp + 0x20], bx);        /* mov [ebp+0x20], bx */
            ii(0x14_e120, 1); retw(); return;                           /* ret */
        l_0x14_e121:
            ii(0x14_e121, 3); mov(memw_a16[ds, bx + 0x4], ax);          /* mov [bx+0x4], ax */
            ii(0x14_e124, 3); add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x14_e127, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x14_e129, 2); if(jzw(0x14_e130, 0x5)) goto l_0x14_e130; /* jz 0xe130 */
            ii(0x14_e12b, 1); inc(dx);                                  /* inc dx */
            ii(0x14_e12c, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x14_e12e, 2); jmpw(0x14_e121, -0xf); goto l_0x14_e121;  /* jmp 0xe121 */
        l_0x14_e130:
            ii(0x14_e130, 3); add(bx, 0x5);                             /* add bx, 0x5 */
            ii(0x14_e133, 2); jmpw(0x14_e0de, -0x57); goto l_0x14_e0de; /* jmp 0xe0de */
        l_0x14_e135:
            ii(0x14_e135, 6); test(memb_a16[es, 0x14], 0x80);           /* test byte [es:0x14], 0x80 */
            ii(0x14_e13b, 2); if(jzw(0x14_e150, 0x13)) goto l_0x14_e150; /* jz 0xe150 */
        l_0x14_e13d:
            ii(0x14_e13d, 3); mov(ax, 0x78);                            /* mov ax, 0x78 */
            ii(0x14_e140, 5); xchg(memw_a16[es, 0xc0e], ax);            /* xchg [es:0xc0e], ax */
            ii(0x14_e145, 3); cmp(ax, 0x80);                            /* cmp ax, 0x80 */
            ii(0x14_e148, 2); if(jbw(0x14_e14d, 0x3)) goto l_0x14_e14d; /* jb 0xe14d */
            ii(0x14_e14a, 3); jmpw(0x14_e0ba, -0x93); goto l_0x14_e0ba; /* jmp 0xe0ba */
        l_0x14_e14d:
            ii(0x14_e14d, 3); if(jmpw_func(0x14_e062, -0xee)) return;   /* jmp 0xe062 */
        l_0x14_e150:
            ii(0x14_e150, 5); cmp(memw_a16[ds, 0x2], 0x10);             /* cmp word [0x2], 0x10 */
            ii(0x14_e155, 2); if(jbew(0x14_e14d, -0xa)) goto l_0x14_e14d; /* jbe 0xe14d */
            ii(0x14_e157, 6); mov(memw_a16[ds, 0x2], 0x10);             /* mov word [0x2], 0x10 */
            ii(0x14_e15d, 3); jmpw(0x14_e0ba, -0xa6); goto l_0x14_e0ba; /* jmp 0xe0ba */
        }
    }
}
