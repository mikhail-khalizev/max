using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0170-676eaff")]
        public void Method_0019_0170()
        {
            ii(0x19_0170, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_0174, 1); push(ds);                                 /* push ds */
            ii(0x19_0175, 2); pushd(esi);                               /* push esi */
            ii(0x19_0177, 2); pushd(edi);                               /* push edi */
            ii(0x19_0179, 2); pushd(ebx);                               /* push ebx */
            ii(0x19_017b, 3); mov(bx, 0xa8);                            /* mov bx, 0xa8 */
            ii(0x19_017e, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x19_0180, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_0183, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_0185, 2); test(al, 0x7);                            /* test al, 0x7 */
            ii(0x19_0187, 4); if(jnz(0x19_01ca, 0x3f)) goto l_0x19_01ca; /* jnz 0x1ca */
            ii(0x19_018b, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x19_018e, 2); cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0x19_0190, 4); if(jbe(0x19_01ca, 0x36)) goto l_0x19_01ca; /* jbe 0x1ca */
            ii(0x19_0194, 4); mov(es, memw[ds, 0x124]);                 /* mov es, [0x124] */
            ii(0x19_0198, 4); mov(dl, memb[es, si + 0x1]);              /* mov dl, [es:si+0x1] */
            ii(0x19_019c, 3); mov(cx, 0x120);                           /* mov cx, 0x120 */
            ii(0x19_019f, 3); mov(di, 0x2);                             /* mov di, 0x2 */
            ii(0x19_01a2, 2); mov(es, bx);                              /* mov es, bx */
        l_0x19_01a4:
            ii(0x19_01a4, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_01a6, 2); if(jcxz(0x19_01ae, 0x6)) goto l_0x19_01ae; /* jcxz 0x1ae */
            ii(0x19_01a8, 4); mov(memb[es, di - 0x1], dl);              /* mov [es:di-0x1], dl */
            ii(0x19_01ac, 2); jmp(0x19_01a4, -0xa); goto l_0x19_01a4;   /* jmp 0x1a4 */
        l_0x19_01ae:
            ii(0x19_01ae, 4); les(di, memw[ds, 0x122]);                 /* les di, [0x122] */
            ii(0x19_01b2, 4); mov(cx, memw[ds, 0x126]);                 /* mov cx, [0x126] */
        l_0x19_01b6:
            ii(0x19_01b6, 4); cmp(memb[es, di + 0x1], al);              /* cmp [es:di+0x1], al */
            ii(0x19_01ba, 4); if(jnz(0x19_01c2, 0x4)) goto l_0x19_01c2; /* jnz 0x1c2 */
            ii(0x19_01be, 4); mov(memb[es, di + 0x1], dl);              /* mov [es:di+0x1], dl */
        l_0x19_01c2:
            ii(0x19_01c2, 3); add(di, 0x8);                             /* add di, 0x8 */
            ii(0x19_01c5, 2); if(loop(0x19_01b6, -0x11)) goto l_0x19_01b6; /* loop 0x1b6 */
            ii(0x19_01c7, 3); mov(memb[es, si], cl);                    /* mov [es:si], cl */
        l_0x19_01ca:
            ii(0x19_01ca, 2); popd(ebx);                                /* pop ebx */
            ii(0x19_01cc, 2); popd(edi);                                /* pop edi */
            ii(0x19_01ce, 2); popd(esi);                                /* pop esi */
            ii(0x19_01d0, 1); pop(ds);                                  /* pop ds */
            ii(0x19_01d1, 1); leave();                                  /* leave */
            ii(0x19_01d2, 1); retf();                                   /* retf */
        }
    }
}
