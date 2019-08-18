using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8af10e0-1dee-4c2d-8681-e854f77fa33b")]
        public void Method_0018_dc8e()
        {
            ii(0x18_dc8e, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_dc90, 1); pushw(si);                                /* push si */
            ii(0x18_dc91, 4); mov(si, memw_a16[ss, bx + 0x2]);          /* mov si, [ss:bx+0x2] */
            ii(0x18_dc95, 4); cmp(si, memw_a16[ds, 0x97c]);             /* cmp si, [0x97c] */
            ii(0x18_dc99, 2); if(jaew_func(0x18_dc8a, -0x11)) return;   /* jae 0xdc8a */
            ii(0x18_dc9b, 1); pushw(ds);                                /* push ds */
            ii(0x18_dc9c, 1); pushw(bp);                                /* push bp */
            ii(0x18_dc9d, 4); mov(bp, memw_a16[ss, bx + 0x4]);          /* mov bp, [ss:bx+0x4] */
            ii(0x18_dca1, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_dca6, 2); if(jzw(0x18_dcd0, 0x28)) goto l_0x18_dcd0; /* jz 0xdcd0 */
            ii(0x18_dca8, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_dcaa, 1); popw(ds);                                 /* pop ds */
            ii(0x18_dcab, 3); and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
        l_0x18_dcae:
            ii(0x18_dcae, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_dcaf, 3); mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x18_dcb2, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_dcb3, 3); mov(memw_a16[ss, bp + 0], ax);            /* mov [bp], ax */
            ii(0x18_dcb6, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_dcb7, 3); mov(memb_a16[ss, bp + 0x2], al);          /* mov [bp+0x2], al */
            ii(0x18_dcba, 3); mov(memb_a16[ss, bp + 0x8], ah);          /* mov [bp+0x8], ah */
            ii(0x18_dcbd, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_dcbe, 2); and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x18_dcc0, 3); mov(memb_a16[ss, bp + 0x9], al);          /* mov [bp+0x9], al */
            ii(0x18_dcc3, 3); mov(memb_a16[ss, bp + 0x3], ah);          /* mov [bp+0x3], ah */
            ii(0x18_dcc6, 5); mov(memw_a16[ss, bp + 0x6], 0);           /* mov word [bp+0x6], 0x0 */
            ii(0x18_dccb, 1); inc(ax);                                  /* inc ax */
        l_0x18_dccc:
            ii(0x18_dccc, 1); popw(bp);                                 /* pop bp */
            ii(0x18_dccd, 1); popw(ds);                                 /* pop ds */
            ii(0x18_dcce, 1); popw(si);                                 /* pop si */
            ii(0x18_dccf, 1); retw(); return;                           /* ret */
        l_0x18_dcd0:
            ii(0x18_dcd0, 1); pushw(ds);                                /* push ds */
            ii(0x18_dcd1, 1); popw(es);                                 /* pop es */
            ii(0x18_dcd2, 2); pushd(edi);                               /* push edi */
            ii(0x18_dcd4, 3); xor(edi, edi);                            /* xor edi, edi */
            ii(0x18_dcd7, 3); mov(di, 0x8c0);                           /* mov di, 0x8c0 */
            ii(0x18_dcda, 2); mov(si, di);                              /* mov si, di */
            ii(0x18_dcdc, 4); mov(bx, memw_a16[ss, bx + 0x2]);          /* mov bx, [ss:bx+0x2] */
            ii(0x18_dce0, 3); mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0x18_dce3, 1); pushw(cs);                                /* push cs */
            ii(0x18_dce4, 3); callw(0x18_a3b9, -0x392e);                /* call 0xa3b9 */
            ii(0x18_dce7, 2); popd(edi);                                /* pop edi */
            ii(0x18_dce9, 2); if(jaew(0x18_dcae, -0x3d)) goto l_0x18_dcae; /* jae 0xdcae */
            ii(0x18_dceb, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_dced, 2); jmpw(0x18_dccc, -0x23); goto l_0x18_dccc; /* jmp 0xdccc */
        }
    }
}
