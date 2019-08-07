using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("931d2d7a-fcc2-4a06-8115-17e0b9305b76")]
        public void Method_0015_ba47()
        {
            ii(0x15_ba47, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x15_ba4b, 1); pushw(si);                                /* push si */
            ii(0x15_ba4c, 1); pushw(ds);                                /* push ds */
            ii(0x15_ba4d, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_ba50, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_ba52, 4); mov(memb_a16[ss, bp - 0xc], 0);           /* mov byte [bp-0xc], 0x0 */
            ii(0x15_ba56, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_ba58, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_ba5b, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_ba5e, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x15_ba61, 2); jmpw(0x15_bae0, 0x7d); goto l_0x15_bae0;  /* jmp 0xbae0 */
        l_0x15_ba63:
            ii(0x15_ba63, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x15_ba66, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_ba69, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
        l_0x15_ba6e:
            ii(0x15_ba6e, 5); mov(memw_a16[ss, bp - 0x2], 0x2);         /* mov word [bp-0x2], 0x2 */
            ii(0x15_ba73, 3); jmpw(0x15_baff, 0x89); goto l_0x15_baff;  /* jmp 0xbaff */
        l_0x15_ba76:
            ii(0x15_ba76, 3); mov(ax, memw_a16[ss, bp + 0x12]);         /* mov ax, [bp+0x12] */
            ii(0x15_ba79, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x15_ba7c, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_ba7f, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x15_ba82, 2); jmpw(0x15_ba6e, -0x16); goto l_0x15_ba6e; /* jmp 0xba6e */
        l_0x15_ba84:
            ii(0x15_ba84, 3); mov(ax, memw_a16[ss, bp + 0x12]);         /* mov ax, [bp+0x12] */
            ii(0x15_ba87, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x15_ba8a, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_ba8d, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x15_ba90, 4); cmp(memw_a16[ss, bp + 0xe], 0x7);         /* cmp word [bp+0xe], 0x7 */
            ii(0x15_ba94, 2); if(jnzw(0x15_ba9b, 0x5)) goto l_0x15_ba9b; /* jnz 0xba9b */
            ii(0x15_ba96, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x15_ba99, 2); jmpw(0x15_ba9e, 0x3); goto l_0x15_ba9e;   /* jmp 0xba9e */
        l_0x15_ba9b:
            ii(0x15_ba9b, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x15_ba9e:
            ii(0x15_ba9e, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_baa1, 2); jmpw(0x15_baff, 0x5c); goto l_0x15_baff;  /* jmp 0xbaff */
        l_0x15_baa3:
            ii(0x15_baa3, 3); mov(ax, memw_a16[ss, bp + 0x12]);         /* mov ax, [bp+0x12] */
            ii(0x15_baa6, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x15_baa9, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_baac, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x15_baaf, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x15_bab2, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_bab5, 5); mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
            ii(0x15_baba, 5); mov(memw_a16[ss, bp - 0x2], 0x6);         /* mov word [bp-0x2], 0x6 */
            ii(0x15_babf, 2); jmpw(0x15_baff, 0x3e); goto l_0x15_baff;  /* jmp 0xbaff */
        l_0x15_bac1:
            ii(0x15_bac1, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x15_bac4, 3); mov(cx, memw_a16[ss, bp + 0x12]);         /* mov cx, [bp+0x12] */
            ii(0x15_bac7, 3); mov(memw_a16[ss, bp - 0xa], cx);          /* mov [bp-0xa], cx */
            ii(0x15_baca, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
        l_0x15_bacd:
            ii(0x15_bacd, 5); mov(memw_a16[ss, bp - 0x2], 0x4);         /* mov word [bp-0x2], 0x4 */
            ii(0x15_bad2, 2); jmpw(0x15_baff, 0x2b); goto l_0x15_baff;  /* jmp 0xbaff */
        l_0x15_bad4:
            ii(0x15_bad4, 3); inc(memb_a16[ss, bp - 0xc]);              /* inc byte [bp-0xc] */
            ii(0x15_bad7, 2); jmpw(0x15_bacd, -0xc); goto l_0x15_bacd;  /* jmp 0xbacd */
        l_0x15_bad9:
            ii(0x15_bad9, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_bade, 2); jmpw(0x15_baff, 0x1f); goto l_0x15_baff;  /* jmp 0xbaff */
        l_0x15_bae0:
            ii(0x15_bae0, 3); cmp(ax, 0x8);                             /* cmp ax, 0x8 */
            ii(0x15_bae3, 2); if(jaw(0x15_bad9, -0xc)) goto l_0x15_bad9; /* ja 0xbad9 */
            ii(0x15_bae5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_bae7, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x15_bae8, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx + 0x66cd]))
            {
                case 0x15_ba63:
                    goto l_0x15_ba63;
                case 0x15_ba76:
                    goto l_0x15_ba76;
                case 0x15_ba84:
                    goto l_0x15_ba84;
                case 0x15_baa3:
                    goto l_0x15_baa3;
                case 0x15_bac1:
                    goto l_0x15_bac1;
                case 0x15_bad4:
                    goto l_0x15_bad4;
                case 0x15_bad9:
                    goto l_0x15_bad9;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx+0x66cd] */
        //    ii(0x15_baed, 18); /* Служебная область с абсолютными адресами переходов. {0x15_ba84, 0x15_bad9, 0x15_ba63, 0x15_bac1, 0x15_bad9, 0x15_ba76, 0x15_baa3, 0x15_ba84, 0x15_bad4}. */
        l_0x15_baff:
            ii(0x15_baff, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_bb02, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x15_bb05, 3); mov(memw_a16[ds, 0x2134], ax);            /* mov [0x2134], ax */
            ii(0x15_bb08, 4); mov(memw_a16[ds, 0x2136], dx);            /* mov [0x2136], dx */
            ii(0x15_bb0c, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_bb0f, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x15_bb12, 3); mov(memw_a16[ds, 0x2138], ax);            /* mov [0x2138], ax */
            ii(0x15_bb15, 4); mov(memw_a16[ds, 0x213a], dx);            /* mov [0x213a], dx */
            ii(0x15_bb19, 3); jmpw(0x15_bba3, 0x87); goto l_0x15_bba3;  /* jmp 0xbba3 */
        l_0x15_bb1c:
            ii(0x15_bb1c, 3); mov(bx, memw_a16[ss, bp + 0x16]);         /* mov bx, [bp+0x16] */
            ii(0x15_bb1f, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x15_bb21, 3); les(si, ss, bp + 0x18);                   /* les si, [bp+0x18] */
            ii(0x15_bb24, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x15_bb27, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_bb2a, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_bb2d, 4); cmp(memb_a16[ss, bp - 0xc], 0);           /* cmp byte [bp-0xc], 0x0 */
            ii(0x15_bb31, 2); if(jzw(0x15_bb54, 0x21)) goto l_0x15_bb54; /* jz 0xbb54 */
            ii(0x15_bb33, 1); cwd();                                    /* cwd */
            ii(0x15_bb34, 3); mov(cx, memw_a16[ss, bp + 0x12]);         /* mov cx, [bp+0x12] */
            ii(0x15_bb37, 3); mov(bx, memw_a16[ss, bp + 0x14]);         /* mov bx, [bp+0x14] */
            ii(0x15_bb3a, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x15_bb3c, 2); sbb(bx, dx);                              /* sbb bx, dx */
            ii(0x15_bb3e, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_bb41, 1); cwd();                                    /* cwd */
            ii(0x15_bb42, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x15_bb44, 2); sbb(bx, dx);                              /* sbb bx, dx */
            ii(0x15_bb46, 3); sub(cx, memw_a16[ss, bp + 0xa]);          /* sub cx, [bp+0xa] */
            ii(0x15_bb49, 3); sbb(bx, memw_a16[ss, bp + 0xc]);          /* sbb bx, [bp+0xc] */
            ii(0x15_bb4c, 4); mov(memw_a16[ds, 0x2134], cx);            /* mov [0x2134], cx */
            ii(0x15_bb50, 4); mov(memw_a16[ds, 0x2136], bx);            /* mov [0x2136], bx */
        l_0x15_bb54:
            ii(0x15_bb54, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_bb57, 3); mov(ax, 0x2134);                          /* mov ax, 0x2134 */
            ii(0x15_bb5a, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_bb5d, 3); mov(memw_a16[ss, bp - 0x4], ds);          /* mov [bp-0x4], ds */
            ii(0x15_bb60, 1); pushw(ds);                                /* push ds */
            ii(0x15_bb61, 1); pushw(ax);                                /* push ax */
            ii(0x15_bb62, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_bb65, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_bb68, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_bb6b, 1); pushw(cs);                                /* push cs */
            ii(0x15_bb6c, 3); callw(0x15_ba46, -0x129);                 /* call 0xba46 */
            ii(0x15_bb6f, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_bb72, 2); jmpw(0x15_bb7a, 0x6); goto l_0x15_bb7a;   /* jmp 0xbb7a */
        l_0x15_bb74:
            ii(0x15_bb74, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x15_bb77, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
        l_0x15_bb7a:
            ii(0x15_bb7a, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x15_bb7d, 3); add(ax, memw_a16[ss, bp - 0x2]);          /* add ax, [bp-0x2] */
            ii(0x15_bb80, 3); cmp(ax, memw_a16[ss, bp - 0x12]);         /* cmp ax, [bp-0x12] */
            ii(0x15_bb83, 2); if(jlew(0x15_bba3, 0x1e)) goto l_0x15_bba3; /* jle 0xbba3 */
            ii(0x15_bb85, 5); cmp(memw_a16[ss, bp - 0x12], 0x1000);     /* cmp word [bp-0x12], 0x1000 */
            ii(0x15_bb8a, 2); if(jgew(0x15_bba3, 0x17)) goto l_0x15_bba3; /* jge 0xbba3 */
            ii(0x15_bb8c, 4); cmp(memw_a16[ss, bp - 0x12], 0);          /* cmp word [bp-0x12], 0x0 */
            ii(0x15_bb90, 2); if(jlw(0x15_bb74, -0x1e)) goto l_0x15_bb74; /* jl 0xbb74 */
            ii(0x15_bb92, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x15_bb95, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_bb98, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_bb9b, 3); mov(si, memw_a16[ss, bp - 0x12]);         /* mov si, [bp-0x12] */
            ii(0x15_bb9e, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
            ii(0x15_bba1, 2); jmpw(0x15_bb74, -0x2f); goto l_0x15_bb74; /* jmp 0xbb74 */
        l_0x15_bba3:
            ii(0x15_bba3, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x15_bba6, 3); dec(memw_a16[ss, bp + 0x16]);             /* dec word [bp+0x16] */
            ii(0x15_bba9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_bbab, 2); if(jzw(0x15_bbb0, 0x3)) goto l_0x15_bbb0; /* jz 0xbbb0 */
            ii(0x15_bbad, 3); jmpw(0x15_bb1c, -0x94); goto l_0x15_bb1c; /* jmp 0xbb1c */
        l_0x15_bbb0:
            ii(0x15_bbb0, 1); popw(ds);                                 /* pop ds */
            ii(0x15_bbb1, 1); popw(si);                                 /* pop si */
            ii(0x15_bbb2, 1); leavew();                                 /* leave */
            ii(0x15_bbb3, 1); retfw(); return;                          /* retf */
        }
    }
}
