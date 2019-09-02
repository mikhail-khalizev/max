using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ab71-1774f099")]
        public void Method_0018_ab71()
        {
            ii(0x18_ab71, 3); mov(cx, memw[ss, bp + 4]);                /* mov cx, [bp+0x4] */
            ii(0x18_ab74, 2); push(edx);                                /* push edx */
            ii(0x18_ab76, 2); push(eax);                                /* push eax */
            ii(0x18_ab78, 5); movzx(edx, memw[ss, bp + 18]);            /* movzx edx, word [bp+0x12] */
            ii(0x18_ab7d, 4); cmp(cx, memw[ds, 0xc26]);                 /* cmp cx, [0xc26] */
            ii(0x18_ab81, 2); if(jz(0x18_abb8, 0x35)) goto l_0x18_abb8; /* jz 0xabb8 */
            ii(0x18_ab83, 4); cmp(cx, memw[ds, 0xc3c]);                 /* cmp cx, [0xc3c] */
            ii(0x18_ab87, 2); if(jz(0x18_abb8, 0x2f)) goto l_0x18_abb8; /* jz 0xabb8 */
            ii(0x18_ab89, 4); lar(eax, cx);                             /* lar eax, cx */
            ii(0x18_ab8d, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x18_ab92, 2); if(jb(0x18_abb8, 0x24)) goto l_0x18_abb8; /* jb 0xabb8 */
            ii(0x18_ab94, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x18_ab96, 3); shl(di, 3);                               /* shl di, 0x3 */
            ii(0x18_ab99, 1); cld();                                    /* cld */
            ii(0x18_ab9a, 4); mov(es, memw[ds, 0xc24]);                 /* mov es, [0xc24] */
            ii(0x18_ab9e, 4); add(di, 0x44d6);                          /* add di, 0x44d6 */
            ii(0x18_aba2, 1); push(di);                                 /* push di */
            ii(0x18_aba3, 2); mov(al, 0xe8);                            /* mov al, 0xe8 */
            ii(0x18_aba5, 1); stosb();                                  /* stosb */
            ii(0x18_aba6, 3); mov(ax, 0x56bc);                          /* mov ax, 0x56bc */
            ii(0x18_aba9, 2); sub(ax, di);                              /* sub ax, di */
            ii(0x18_abab, 1); stosw();                                  /* stosw */
            ii(0x18_abac, 2); mov(al, 0xea);                            /* mov al, 0xea */
            ii(0x18_abae, 1); stosb();                                  /* stosb */
            ii(0x18_abaf, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_abb1, 1); stosw();                                  /* stosw */
            ii(0x18_abb2, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_abb4, 1); stosw();                                  /* stosw */
            ii(0x18_abb5, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x18_abb7, 1); pop(dx);                                  /* pop dx */
        l_0x18_abb8:
            ii(0x18_abb8, 3); mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0x18_abbb, 1); push(cs);                                 /* push cs */
            ii(0x18_abbc, 3); call(0x18_a3b9, -0x806);                  /* call 0xa3b9 */
            ii(0x18_abbf, 2); pop(eax);                                 /* pop eax */
            ii(0x18_abc1, 2); pop(edx);                                 /* pop edx */
            ii(0x18_abc3, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x18_abc5, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x18_abc8, 5); cmp(memb[ds, 0xc44], 0);                  /* cmp byte [0xc44], 0x0 */
            ii(0x18_abcd, 2); if(ja_func(0x18_ac3c, 0x6d)) return;      /* ja 0xac3c */
            ii(0x18_abcf, 3); sub(cx, 0x1b);                            /* sub cx, 0x1b */
            ii(0x18_abd2, 3); cmp(cx, 0x14);                            /* cmp cx, 0x14 */
            ii(0x18_abd5, 2); if(jae(0x18_abe1, 0xa)) goto l_0x18_abe1; /* jae 0xabe1 */
            ii(0x18_abd7, 3); mov(ax, 0x42c0);                          /* mov ax, 0x42c0 */
            ii(0x18_abda, 1); inc(cx);                                  /* inc cx */
            ii(0x18_abdb, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x18_abdd, 2); if(jb(0x18_abe1, 2)) goto l_0x18_abe1;    /* jb 0xabe1 */
            ii(0x18_abdf, 2); if(jmp_func(0x18_ac3c, 0x5b)) return;     /* jmp 0xac3c */
        l_0x18_abe1:
            ii(0x18_abe1, 3); if(jmp_func(0x18_ac98, 0xb4)) return;     /* jmp 0xac98 */
        }
    }
}
