using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aa94ccae-37a1-41a9-97ac-a2b4bef3a0f1")]
        public void Method_0019_78d4()
        {
            ii(0x19_78d4, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x19_78d8, 1); pushw(di);                                /* push di */
            ii(0x19_78d9, 1); pushw(si);                                /* push si */
            ii(0x19_78da, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x19_78dd, 1); pushw(ss);                                /* push ss */
            ii(0x19_78de, 1); pushw(ax);                                /* push ax */
            ii(0x19_78df, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_78e2, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x19_78e7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_78ea, 3); mov(al, memb_a16[ss, bp - 0x9]);          /* mov al, [bp-0x9] */
            ii(0x19_78ed, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_78ef, 3); shl(ax, 0x8);                             /* shl ax, 0x8 */
            ii(0x19_78f2, 3); mov(cl, memb_a16[ss, bp - 0xc]);          /* mov cl, [bp-0xc] */
            ii(0x19_78f5, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x19_78f7, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_78f9, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x19_78fc, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x19_78fe, 3); add(cx, memw_a16[ss, bp + 0x6]);          /* add cx, [bp+0x6] */
            ii(0x19_7901, 3); adc(dx, memw_a16[ss, bp + 0x8]);          /* adc dx, [bp+0x8] */
            ii(0x19_7904, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x19_7907, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_790a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_790d, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x19_7910, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x19_7913, 3); mov(memb_a16[ss, bp - 0xc], al);          /* mov [bp-0xc], al */
            ii(0x19_7916, 3); mov(al, memb_a16[ss, bp - 0x1]);          /* mov al, [bp-0x1] */
            ii(0x19_7919, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_791b, 3); mov(memb_a16[ss, bp - 0x9], al);          /* mov [bp-0x9], al */
            ii(0x19_791e, 3); mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x19_7921, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x19_7924, 3); mov(cx, memw_a16[ss, bp - 0x10]);         /* mov cx, [bp-0x10] */
            ii(0x19_7927, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x19_792a, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_792d, 4); test(memb_a16[ss, bp - 0xa], 0x80);       /* test byte [bp-0xa], 0x80 */
            ii(0x19_7931, 2); if(jnzw(0x19_7936, 0x3)) goto l_0x19_7936; /* jnz 0x7936 */
            ii(0x19_7933, 3); jmpw(0x19_7979, 0x43); goto l_0x19_7979;  /* jmp 0x7979 */
        l_0x19_7936:
            ii(0x19_7936, 4); and(memb_a16[ss, bp - 0xa], 0x7f);        /* and byte [bp-0xa], 0x7f */
            ii(0x19_793a, 2); pushw(0xc);                               /* push 0xc */
            ii(0x19_793c, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x19_793f, 1); pushw(ax);                                /* push ax */
            ii(0x19_7940, 5); callw_far_abs(0x80, 0x433c);              /* call word 0x80:0x433c */
            ii(0x19_7945, 5); or(memw_a16[ss, bp - 0x8], 0xfff);        /* or word [bp-0x8], 0xfff */
            ii(0x19_794a, 4); or(memw_a16[ss, bp - 0x6], 0);            /* or word [bp-0x6], 0x0 */
            ii(0x19_794e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_7951, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x19_7954, 3); sub(memw_a16[ss, bp - 0x8], ax);          /* sub [bp-0x8], ax */
            ii(0x19_7957, 3); sbb(memw_a16[ss, bp - 0x6], dx);          /* sbb [bp-0x6], dx */
            ii(0x19_795a, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x19_795e, 2); if(jbew(0x19_7963, 0x3)) goto l_0x19_7963; /* jbe 0x7963 */
            ii(0x19_7960, 3); jmpw(0x19_796c, 0x9); goto l_0x19_796c;   /* jmp 0x796c */
        l_0x19_7963:
            ii(0x19_7963, 4); cmp(memw_a16[ss, bp - 0x8], -0x1 /* 0xff */); /* cmp word [bp-0x8], 0xffff */
            ii(0x19_7967, 2); if(jaw(0x19_796c, 0x3)) goto l_0x19_796c; /* ja 0x796c */
            ii(0x19_7969, 3); jmpw(0x19_7976, 0xa); goto l_0x19_7976;   /* jmp 0x7976 */
        l_0x19_796c:
            ii(0x19_796c, 5); mov(memw_a16[ss, bp - 0x8], 0xffff);      /* mov word [bp-0x8], 0xffff */
            ii(0x19_7971, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x19_7976:
            ii(0x19_7976, 3); jmpw(0x19_7985, 0xc); goto l_0x19_7985;   /* jmp 0x7985 */
        l_0x19_7979:
            ii(0x19_7979, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_797c, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x19_797f, 3); sub(memw_a16[ss, bp - 0x8], ax);          /* sub [bp-0x8], ax */
            ii(0x19_7982, 3); sbb(memw_a16[ss, bp - 0x6], dx);          /* sbb [bp-0x6], dx */
        l_0x19_7985:
            ii(0x19_7985, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_7988, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_798b, 4); mov(memb_a16[ss, bp - 0xa], 0);           /* mov byte [bp-0xa], 0x0 */
            ii(0x19_798f, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x19_7992, 1); pushw(ss);                                /* push ss */
            ii(0x19_7993, 1); pushw(ax);                                /* push ax */
            ii(0x19_7994, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_7997, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x19_799c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_799f, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_79a2, 3); jmpw(0x19_79a5, 0); goto l_0x19_79a5;     /* jmp 0x79a5 */
        l_0x19_79a5:
            ii(0x19_79a5, 1); popw(si);                                 /* pop si */
            ii(0x19_79a6, 1); popw(di);                                 /* pop di */
            ii(0x19_79a7, 1); leavew();                                 /* leave */
            ii(0x19_79a8, 1); retw(); return;                           /* ret */
        }
    }
}
