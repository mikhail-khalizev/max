using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("509a0eec-d8f0-4daa-8215-5151766d5560")]
        public void Method_0014_ab71()
        {
            ii(0x14_ab71, 3); mov(cx, memw_a16[ss, bp + 0x4]);          /* mov cx, [bp+0x4] */
            ii(0x14_ab74, 2); pushd(edx);                               /* push edx */
            ii(0x14_ab76, 2); pushd(eax);                               /* push eax */
            ii(0x14_ab78, 5); movzx(edx, memw_a16[ss, bp + 0x12]);      /* movzx edx, word [bp+0x12] */
            ii(0x14_ab7d, 4); cmp(cx, memw_a16[ds, 0xc26]);             /* cmp cx, [0xc26] */
            ii(0x14_ab81, 2); if(jzw(0x14_abb8, 0x35)) goto l_0x14_abb8; /* jz 0xabb8 */
            ii(0x14_ab83, 4); cmp(cx, memw_a16[ds, 0xc3c]);             /* cmp cx, [0xc3c] */
            ii(0x14_ab87, 2); if(jzw(0x14_abb8, 0x2f)) goto l_0x14_abb8; /* jz 0xabb8 */
            ii(0x14_ab89, 4); lar(eax, cx);                             /* lar eax, cx */
            ii(0x14_ab8d, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x14_ab92, 2); if(jbw(0x14_abb8, 0x24)) goto l_0x14_abb8; /* jb 0xabb8 */
            ii(0x14_ab94, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x14_ab96, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x14_ab99, 1); cld();                                    /* cld */
            ii(0x14_ab9a, 4); mov(es, memw_a16[ds, 0xc24]);             /* mov es, [0xc24] */
            ii(0x14_ab9e, 4); add(di, 0x44d6);                          /* add di, 0x44d6 */
            ii(0x14_aba2, 1); pushw(di);                                /* push di */
            ii(0x14_aba3, 2); mov(al, 0xe8);                            /* mov al, 0xe8 */
            ii(0x14_aba5, 1); stosb_a16();                              /* stosb */
            ii(0x14_aba6, 3); mov(ax, 0x56bc);                          /* mov ax, 0x56bc */
            ii(0x14_aba9, 2); sub(ax, di);                              /* sub ax, di */
            ii(0x14_abab, 1); stosw_a16();                              /* stosw */
            ii(0x14_abac, 2); mov(al, 0xea);                            /* mov al, 0xea */
            ii(0x14_abae, 1); stosb_a16();                              /* stosb */
            ii(0x14_abaf, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x14_abb1, 1); stosw_a16();                              /* stosw */
            ii(0x14_abb2, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x14_abb4, 1); stosw_a16();                              /* stosw */
            ii(0x14_abb5, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x14_abb7, 1); popw(dx);                                 /* pop dx */
        l_0x14_abb8:
            ii(0x14_abb8, 3); mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0x14_abbb, 1); pushw(cs);                                /* push cs */
            ii(0x14_abbc, 3); callw(0x14_a3b9, -0x806);                 /* call 0xa3b9 */
            ii(0x14_abbf, 2); popd(eax);                                /* pop eax */
            ii(0x14_abc1, 2); popd(edx);                                /* pop edx */
            ii(0x14_abc3, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x14_abc5, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x14_abc8, 5); cmp(memb_a16[ds, 0xc44], 0);              /* cmp byte [0xc44], 0x0 */
            ii(0x14_abcd, 2); jaw_func(0x14_ac3c, 0x6d);                /* ja 0xac3c */
            ii(0x14_abcf, 3); sub(cx, 0x1b);                            /* sub cx, 0x1b */
            ii(0x14_abd2, 3); cmp(cx, 0x14);                            /* cmp cx, 0x14 */
            ii(0x14_abd5, 2); if(jaew(0x14_abe1, 0xa)) goto l_0x14_abe1; /* jae 0xabe1 */
            ii(0x14_abd7, 3); mov(ax, 0x42c0);                          /* mov ax, 0x42c0 */
            ii(0x14_abda, 1); inc(cx);                                  /* inc cx */
            ii(0x14_abdb, 2); shl(ax, cl);                              /* shl ax, cl */
            ii(0x14_abdd, 2); if(jbw(0x14_abe1, 0x2)) goto l_0x14_abe1; /* jb 0xabe1 */
            ii(0x14_abdf, 2); jmpw_func(0x14_ac3c, 0x5b); return;       /* jmp 0xac3c */
        l_0x14_abe1:
            ii(0x14_abe1, 3); jmpw_func(0x14_ac98, 0xb4); return;       /* jmp 0xac98 */
        }
    }
}
