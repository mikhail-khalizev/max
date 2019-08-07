using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("33bdd8d6-a6ff-4911-ac7b-2a0d48d821f1")]
        public void Method_0013_dddc()
        {
            ii(0x13_dddc, 1); pushw(bp);                                /* push bp */
            ii(0x13_dddd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_dddf, 1); pushw(di);                                /* push di */
            ii(0x13_dde0, 1); pushw(si);                                /* push si */
            ii(0x13_dde1, 1); pushw(bx);                                /* push bx */
            ii(0x13_dde2, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_dde4, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_dde7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_dde9, 2); if(jgew(0x13_ddfc, 0x11)) goto l_0x13_ddfc; /* jge 0xddfc */
            ii(0x13_ddeb, 1); inc(di);                                  /* inc di */
            ii(0x13_ddec, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x13_ddef, 2); neg(ax);                                  /* neg ax */
            ii(0x13_ddf1, 2); neg(dx);                                  /* neg dx */
            ii(0x13_ddf3, 3); sbb(ax, 0);                               /* sbb ax, 0x0 */
            ii(0x13_ddf6, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x13_ddf9, 3); mov(memw_a16[ss, bp + 0x6], dx);          /* mov [bp+0x6], dx */
        l_0x13_ddfc:
            ii(0x13_ddfc, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x13_ddff, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_de01, 2); if(jgew(0x13_de14, 0x11)) goto l_0x13_de14; /* jge 0xde14 */
            ii(0x13_de03, 1); inc(di);                                  /* inc di */
            ii(0x13_de04, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x13_de07, 2); neg(ax);                                  /* neg ax */
            ii(0x13_de09, 2); neg(dx);                                  /* neg dx */
            ii(0x13_de0b, 3); sbb(ax, 0);                               /* sbb ax, 0x0 */
            ii(0x13_de0e, 3); mov(memw_a16[ss, bp + 0xc], ax);          /* mov [bp+0xc], ax */
            ii(0x13_de11, 3); mov(memw_a16[ss, bp + 0xa], dx);          /* mov [bp+0xa], dx */
        l_0x13_de14:
            ii(0x13_de14, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_de16, 2); if(jnzw(0x13_de2d, 0x15)) goto l_0x13_de2d; /* jnz 0xde2d */
            ii(0x13_de18, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x13_de1b, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x13_de1e, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x13_de20, 2); div(cx);                                  /* div cx */
            ii(0x13_de22, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_de24, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_de27, 2); div(cx);                                  /* div cx */
            ii(0x13_de29, 2); mov(dx, bx);                              /* mov dx, bx */
            ii(0x13_de2b, 2); jmpw(0x13_de65, 0x38); goto l_0x13_de65;  /* jmp 0xde65 */
        l_0x13_de2d:
            ii(0x13_de2d, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_de2f, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x13_de32, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_de35, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        l_0x13_de38:
            ii(0x13_de38, 2); shr(bx, 0x1);                             /* shr bx, 1 */
            ii(0x13_de3a, 2); rcr(cx, 0x1);                             /* rcr cx, 1 */
            ii(0x13_de3c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_de3e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_de40, 2); or(bx, bx);                               /* or bx, bx */
            ii(0x13_de42, 2); if(jnzw(0x13_de38, -0xc)) goto l_0x13_de38; /* jnz 0xde38 */
            ii(0x13_de44, 2); div(cx);                                  /* div cx */
            ii(0x13_de46, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_de48, 3); mul(memw_a16[ss, bp + 0xc]);              /* mul word [bp+0xc] */
            ii(0x13_de4b, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x13_de4c, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_de4f, 2); mul(si);                                  /* mul si */
            ii(0x13_de51, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x13_de53, 2); if(jbw(0x13_de61, 0xc)) goto l_0x13_de61; /* jb 0xde61 */
            ii(0x13_de55, 3); cmp(dx, memw_a16[ss, bp + 0x8]);          /* cmp dx, [bp+0x8] */
            ii(0x13_de58, 2); if(jaw(0x13_de61, 0x7)) goto l_0x13_de61; /* ja 0xde61 */
            ii(0x13_de5a, 2); if(jbw(0x13_de62, 0x6)) goto l_0x13_de62; /* jb 0xde62 */
            ii(0x13_de5c, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x13_de5f, 2); if(jbew(0x13_de62, 0x1)) goto l_0x13_de62; /* jbe 0xde62 */
        l_0x13_de61:
            ii(0x13_de61, 1); dec(si);                                  /* dec si */
        l_0x13_de62:
            ii(0x13_de62, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x13_de64, 1); xchg(si, ax);                             /* xchg si, ax */
        l_0x13_de65:
            ii(0x13_de65, 1); dec(di);                                  /* dec di */
            ii(0x13_de66, 2); if(jnzw(0x13_de6f, 0x7)) goto l_0x13_de6f; /* jnz 0xde6f */
            ii(0x13_de68, 2); neg(dx);                                  /* neg dx */
            ii(0x13_de6a, 2); neg(ax);                                  /* neg ax */
            ii(0x13_de6c, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
        l_0x13_de6f:
            ii(0x13_de6f, 1); popw(bx);                                 /* pop bx */
            ii(0x13_de70, 1); popw(si);                                 /* pop si */
            ii(0x13_de71, 1); popw(di);                                 /* pop di */
            ii(0x13_de72, 1); popw(bp);                                 /* pop bp */
            ii(0x13_de73, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
