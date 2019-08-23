using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0074-97470015")]
        public void Method_0019_0074()
        {
            ii(0x19_0074, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_0078, 1); push(si);                                 /* push si */
            ii(0x19_0079, 1); push(di);                                 /* push di */
            ii(0x19_007a, 1); push(ds);                                 /* push ds */
            ii(0x19_007b, 5); movzx(edi, memw[ss, bp + 0x6]);           /* movzx edi, word [bp+0x6] */
            ii(0x19_0080, 5); movzx(esi, memw[ss, bp + 0x8]);           /* movzx esi, word [bp+0x8] */
            ii(0x19_0085, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x19_0087, 1); nop();                                    /* nop */
            ii(0x19_0088, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_008b, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_008d, 4); mov(es, memw[ds, 0x124]);                 /* mov es, [0x124] */
            ii(0x19_0091, 3); mov(al, memb[es, di]);                    /* mov al, [es:di] */
            ii(0x19_0094, 2); and(al, 0x3);                             /* and al, 0x3 */
            ii(0x19_0096, 4); if(jz(0x19_0120, 0x86)) goto l_0x19_0120; /* jz 0x120 */
            ii(0x19_009a, 4); mov(bl, memb[es, di + 0x1]);              /* mov bl, [es:di+0x1] */
            ii(0x19_009e, 3); mov(memb[ds, si + 0x38], bl);             /* mov [si+0x38], bl */
            ii(0x19_00a1, 3); movzx(bx, bl);                            /* movzx bx, bl */
            ii(0x19_00a4, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_00a7, 2); cmp(al, 0x1);                             /* cmp al, 0x1 */
            ii(0x19_00a9, 4); if(jz(0x19_00c4, 0x17)) goto l_0x19_00c4; /* jz 0xc4 */
            ii(0x19_00ad, 1); push(di);                                 /* push di */
            ii(0x19_00ae, 3); movzx(di, al);                            /* movzx di, al */
            ii(0x19_00b1, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x19_00b4, 1); push(es);                                 /* push es */
            ii(0x19_00b5, 3); push(memw[ds, si + 0x2c]);                /* push word [si+0x2c] */
            ii(0x19_00b8, 1); nop();                                    /* nop */
            ii(0x19_00b9, 1); push(cs);                                 /* push cs */
            ii(0x19_00ba, 3); call(0x19_04d0, 0x413);                   /* call 0x4d0 */
            ii(0x19_00bd, 1); pop(bx);                                  /* pop bx */
            ii(0x19_00be, 3); mov(memb[ds, si + 0x38], al);             /* mov [si+0x38], al */
            ii(0x19_00c1, 1); pop(es);                                  /* pop es */
            ii(0x19_00c2, 1); pop(bx);                                  /* pop bx */
            ii(0x19_00c3, 1); nop();                                    /* nop */
        l_0x19_00c4:
            ii(0x19_00c4, 6); movzx(edx, memw[es, di + 0x6]);           /* movzx edx, word [es:di+0x6] */
            ii(0x19_00ca, 5); mov(eax, memd[es, di + 0x2]);             /* mov eax, [es:di+0x2] */
            ii(0x19_00cf, 4); lar(ecx, dx);                             /* lar ecx, dx */
            ii(0x19_00d3, 5); bt(ecx, 0x16);                            /* bt ecx, 0x16 */
            ii(0x19_00d8, 2); if(jb(0x19_00e8, 0xe)) goto l_0x19_00e8;  /* jb 0xe8 */
            ii(0x19_00da, 1); push(ds);                                 /* push ds */
            ii(0x19_00db, 1); push(si);                                 /* push si */
            ii(0x19_00dc, 1); push(bx);                                 /* push bx */
            ii(0x19_00dd, 1); push(cs);                                 /* push cs */
            ii(0x19_00de, 5); lea(ecx, memd[ds, 0xc7a]);                /* lea ecx, [0xc7a] */
            ii(0x19_00e3, 1); push(cx);                                 /* push cx */
            ii(0x19_00e4, 2); jmp(0x19_0104, 0x1e); goto l_0x19_0104;   /* jmp 0x104 */
        //  ii(0x19_00e6, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x19_00e8:
            ii(0x19_00e8, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x19_00ea, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00ec, 2); pushd(esi);                               /* push esi */
            ii(0x19_00ee, 2); pushd(ebx);                               /* push ebx */
            ii(0x19_00f0, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x19_00f2, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00f4, 5); lea(ecx, memd[ds, 0xc80]);                /* lea ecx, [0xc80] */
            ii(0x19_00f9, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00fb, 4); mov(ss, memw[ds, 0]);                     /* mov ss, [0x0] */
            ii(0x19_00ff, 4); movzx(esp, sp);                           /* movzx esp, sp */
            ii(0x19_0103, 1); nop();                                    /* nop */
        l_0x19_0104:
            ii(0x19_0104, 2); pushd(edx);                               /* push edx */
            ii(0x19_0106, 2); pushd(eax);                               /* push eax */
            ii(0x19_0108, 2); retfd(); return;                          /* o32 retf */
        //  ii(0x19_010a, 22); Недостижимый код.
        l_0x19_0120:
            ii(0x19_0120, 1); pop(ds);                                  /* pop ds */
            ii(0x19_0121, 1); pop(di);                                  /* pop di */
            ii(0x19_0122, 1); pop(si);                                  /* pop si */
            ii(0x19_0123, 1); pop(bp);                                  /* pop bp */
            ii(0x19_0124, 1); retf();                                   /* retf */
        }
    }
}
