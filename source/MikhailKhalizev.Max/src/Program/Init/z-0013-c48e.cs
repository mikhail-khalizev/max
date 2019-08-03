using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c3d4e486-3ddc-4628-adca-f474fe70130b")]
        public void Method_0013_c48e()
        {
            ii(0x13_c48e, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x13_c492, 1); pushw(ds);                                /* push ds */
            ii(0x13_c493, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_c496, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_c498, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_c49b, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x13_c49e, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_c4a0, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_c4a2, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_c4a4, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_c4a6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c4a8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c4aa, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c4ac, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c4ae, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c4b0, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c4b2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_c4b4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_c4b6, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x13_c4b9, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x13_c4bc, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_c4bf, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_c4c2, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_c4c4, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_c4c7, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_c4ca, 2); jmpw(0x13_c4dc, 0x10); goto l_0x13_c4dc;  /* jmp 0xc4dc */
        l_0x13_c4cc:
            ii(0x13_c4cc, 4); add(memw_a16[ss, bp - 0x8], 0x1);         /* add word [bp-0x8], 0x1 */
            ii(0x13_c4d0, 4); adc(memw_a16[ss, bp - 0x6], 0);           /* adc word [bp-0x6], 0x0 */
            ii(0x13_c4d4, 4); add(memw_a16[ss, bp - 0x4], 0x1);         /* add word [bp-0x4], 0x1 */
            ii(0x13_c4d8, 4); adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
        l_0x13_c4dc:
            ii(0x13_c4dc, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x13_c4df, 3); mov(dx, memw_a16[ss, bp + 0x10]);         /* mov dx, [bp+0x10] */
            ii(0x13_c4e2, 3); cmp(memw_a16[ss, bp - 0x6], dx);          /* cmp [bp-0x6], dx */
            ii(0x13_c4e5, 2); if(jaw(0x13_c55c, 0x75)) goto l_0x13_c55c; /* ja 0xc55c */
            ii(0x13_c4e7, 2); if(jbw(0x13_c4ee, 0x5)) goto l_0x13_c4ee; /* jb 0xc4ee */
            ii(0x13_c4e9, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x13_c4ec, 2); if(jaew(0x13_c55c, 0x6e)) goto l_0x13_c55c; /* jae 0xc55c */
        l_0x13_c4ee:
            ii(0x13_c4ee, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_c4f1, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_c4f4, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_c4f7, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_c4fb, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_c4ff, 3); callw(0x13_91e3, -0x331f);                /* call 0x91e3 */
            ii(0x13_c502, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c505, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_c508, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_c50b, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_c50e, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_c512, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_c516, 3); callw(0x13_91e3, -0x3336);                /* call 0x91e3 */
            ii(0x13_c519, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_c51c, 4); and(memb_a16[ss, bp - 0xc], -0x2 /* 0xfe */); /* and byte [bp-0xc], 0xfe */
            ii(0x13_c520, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x13_c523, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_c526, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_c528, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_c52b, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x13_c52e, 3); mov(ch, memb_a16[ss, bp + 0x12]);         /* mov ch, [bp+0x12] */
            ii(0x13_c531, 2); shl(ch, 0x1);                             /* shl ch, 1 */
            ii(0x13_c533, 2); xor(ah, ch);                              /* xor ah, ch */
            ii(0x13_c535, 3); and(ax, 0xe00);                           /* and ax, 0xe00 */
            ii(0x13_c538, 3); xor(memw_a16[ss, bp - 0xc], ax);          /* xor [bp-0xc], ax */
            ii(0x13_c53b, 3); xor(memw_a16[ss, bp - 0xa], dx);          /* xor [bp-0xa], dx */
            ii(0x13_c53e, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_c541, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x13_c544, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_c547, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_c54a, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_c54e, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_c552, 3); callw(0x13_9235, -0x3320);                /* call 0x9235 */
            ii(0x13_c555, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_c558, 3); jmpw(0x13_c4cc, -0x8f); goto l_0x13_c4cc; /* jmp 0xc4cc */
        //  ii(0x13_c55b, 1); Недостижимый код.
l_0x13_c55c:
            ii(0x13_c55c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c55d, 1); leavew();                                 /* leave */
            ii(0x13_c55e, 1); retfw(); return;                          /* retf */
        }
    }
}
