using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_bddb-9d00b9d0")]
        public void Method_0018_bddb()
        {
            ii(0x18_bddb, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
        l_0x18_bddf:
            ii(0x18_bddf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_bde1, 3); mov(memw_a16[ds, 0x11fc], ax);            /* mov [0x11fc], ax */
            ii(0x18_bde4, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x18_bde7, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
        l_0x18_bdea:
            ii(0x18_bdea, 1); cli();                                    /* cli */
            ii(0x18_bdeb, 3); mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x18_bdee, 4); mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x18_bdf2, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_bdf5, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_bdf8, 4); cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0x18_bdfc, 2); if(jaw(0x18_be14, 0x16)) goto l_0x18_be14; /* ja 0xbe14 */
            ii(0x18_bdfe, 2); if(jbw(0x18_be06, 0x6)) goto l_0x18_be06; /* jb 0xbe06 */
            ii(0x18_be00, 4); cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0x18_be04, 2); if(jaew(0x18_be14, 0xe)) goto l_0x18_be14; /* jae 0xbe14 */
        l_0x18_be06:
            ii(0x18_be06, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x18_be0a, 2); if(jgw(0x18_be19, 0xd)) goto l_0x18_be19; /* jg 0xbe19 */
            ii(0x18_be0c, 2); if(jlw(0x18_be14, 0x6)) goto l_0x18_be14; /* jl 0xbe14 */
            ii(0x18_be0e, 4); cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x18_be12, 2); if(jnzw(0x18_be19, 0x5)) goto l_0x18_be19; /* jnz 0xbe19 */
        l_0x18_be14:
            ii(0x18_be14, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_be16, 1); cwd();                                    /* cwd */
            ii(0x18_be17, 1); leavew();                                 /* leave */
            ii(0x18_be18, 1); retw(); return;                           /* ret */
        l_0x18_be19:
            ii(0x18_be19, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_be1b, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_be1e, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_be21, 3); callw(0x18_db51, 0x1d2d);                 /* call 0xdb51 */
            ii(0x18_be24, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_be27, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_be2a, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x18_be2d:
            ii(0x18_be2d, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_be30, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x18_be33, 2); if(jnzw(0x18_be38, 0x3)) goto l_0x18_be38; /* jnz 0xbe38 */
            ii(0x18_be35, 3); jmpw(0x18_bf95, 0x15d); goto l_0x18_bf95; /* jmp 0xbf95 */
        l_0x18_be38:
            ii(0x18_be38, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_be3a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_be3d, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_be40, 3); callw(0x18_db51, 0x1d0e);                 /* call 0xdb51 */
            ii(0x18_be43, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_be46, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x18_be49, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x18_be4c, 3); cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0x18_be4f, 2); if(jgew(0x18_be54, 0x3)) goto l_0x18_be54; /* jge 0xbe54 */
            ii(0x18_be51, 3); jmpw(0x18_bf32, 0xde); goto l_0x18_bf32;  /* jmp 0xbf32 */
        l_0x18_be54:
            ii(0x18_be54, 2); if(jgw(0x18_be5e, 0x8)) goto l_0x18_be5e; /* jg 0xbe5e */
            ii(0x18_be56, 3); cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x18_be59, 2); if(jaew(0x18_be5e, 0x3)) goto l_0x18_be5e; /* jae 0xbe5e */
            ii(0x18_be5b, 3); jmpw(0x18_bf32, 0xd4); goto l_0x18_bf32;  /* jmp 0xbf32 */
        l_0x18_be5e:
            ii(0x18_be5e, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x18_be63, 2); if(jnzw(0x18_be98, 0x33)) goto l_0x18_be98; /* jnz 0xbe98 */
            ii(0x18_be65, 3); callw(0x18_f39c, 0x3534);                 /* call 0xf39c */
            ii(0x18_be68, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_be6a, 2); if(jnzw(0x18_be98, 0x2c)) goto l_0x18_be98; /* jnz 0xbe98 */
            ii(0x18_be6c, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_be6f, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_be72, 3); add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0x18_be75, 3); adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0x18_be78, 1); pushw(dx);                                /* push dx */
            ii(0x18_be79, 1); pushw(ax);                                /* push ax */
            ii(0x18_be7a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_be7d, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_be80, 3); callw(0x18_f2d8, 0x3455);                 /* call 0xf2d8 */
            ii(0x18_be83, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_be86, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x18_be89, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_be8b, 2); if(jlew(0x18_be91, 0x4)) goto l_0x18_be91; /* jle 0xbe91 */
            ii(0x18_be8d, 1); sti();                                    /* sti */
            ii(0x18_be8e, 3); jmpw(0x18_bddf, -0xb2); goto l_0x18_bddf; /* jmp 0xbddf */
        l_0x18_be91:
            ii(0x18_be91, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_be93, 2); if(jgew(0x18_be98, 0x3)) goto l_0x18_be98; /* jge 0xbe98 */
            ii(0x18_be95, 3); jmpw(0x18_bf95, 0xfd); goto l_0x18_bf95;  /* jmp 0xbf95 */
        l_0x18_be98:
            ii(0x18_be98, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x18_be9b, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x18_be9e, 3); cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x18_bea1, 2); if(jnzw(0x18_bea8, 0x5)) goto l_0x18_bea8; /* jnz 0xbea8 */
            ii(0x18_bea3, 3); cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0x18_bea6, 2); if(jzw(0x18_bedc, 0x34)) goto l_0x18_bedc; /* jz 0xbedc */
        l_0x18_bea8:
            ii(0x18_bea8, 3); sub(ax, memw_a16[ss, bp + 0x4]);          /* sub ax, [bp+0x4] */
            ii(0x18_beab, 3); sbb(dx, memw_a16[ss, bp + 0x6]);          /* sbb dx, [bp+0x6] */
            ii(0x18_beae, 1); pushw(dx);                                /* push dx */
            ii(0x18_beaf, 1); pushw(ax);                                /* push ax */
            ii(0x18_beb0, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_beb2, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_beb5, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_beb8, 3); add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0x18_bebb, 3); adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0x18_bebe, 1); pushw(dx);                                /* push dx */
            ii(0x18_bebf, 1); pushw(ax);                                /* push ax */
            ii(0x18_bec0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_bec2, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_bec5, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_bec8, 3); callw(0x18_db67, 0x1c9c);                 /* call 0xdb67 */
            ii(0x18_becb, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_bece, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_bed1, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_bed4, 1); pushw(dx);                                /* push dx */
            ii(0x18_bed5, 1); pushw(ax);                                /* push ax */
            ii(0x18_bed6, 3); callw(0x18_db67, 0x1c8e);                 /* call 0xdb67 */
            ii(0x18_bed9, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x18_bedc:
            ii(0x18_bedc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_bede, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_bee1, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_bee4, 3); callw(0x18_db51, 0x1c6a);                 /* call 0xdb51 */
            ii(0x18_bee7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_beea, 1); pushw(dx);                                /* push dx */
            ii(0x18_beeb, 1); pushw(ax);                                /* push ax */
            ii(0x18_beec, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_beee, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_bef1, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_bef4, 3); callw(0x18_db67, 0x1c70);                 /* call 0xdb67 */
            ii(0x18_bef7, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_befa, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_befd, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_bf00, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_bf02, 2); if(jzw(0x18_bf15, 0x11)) goto l_0x18_bf15; /* jz 0xbf15 */
            ii(0x18_bf04, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_bf07, 1); pushw(ax);                                /* push ax */
            ii(0x18_bf08, 3); callw(0x18_bcce, -0x23d);                 /* call 0xbcce */
            ii(0x18_bf0b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_bf0d, 2); if(jnzw(0x18_bf15, 0x6)) goto l_0x18_bf15; /* jnz 0xbf15 */
            ii(0x18_bf0f, 2); pushw(0x1d);                              /* push 0x1d */
            ii(0x18_bf11, 3); callw(0x18_d9c5, 0x1ab1);                 /* call 0xd9c5 */
            ii(0x18_bf14, 1); popw(bx);                                 /* pop bx */
        l_0x18_bf15:
            ii(0x18_bf15, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_bf18, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_bf1b, 2); neg(ax);                                  /* neg ax */
            ii(0x18_bf1d, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x18_bf20, 2); neg(dx);                                  /* neg dx */
            ii(0x18_bf22, 1); pushw(dx);                                /* push dx */
            ii(0x18_bf23, 1); pushw(ax);                                /* push ax */
            ii(0x18_bf24, 3); callw(0x18_bda2, -0x185);                 /* call 0xbda2 */
            ii(0x18_bf27, 1); popw(bx);                                 /* pop bx */
            ii(0x18_bf28, 1); popw(bx);                                 /* pop bx */
            ii(0x18_bf29, 1); sti();                                    /* sti */
            ii(0x18_bf2a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_bf2d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_bf30, 1); leavew();                                 /* leave */
            ii(0x18_bf31, 1); retw(); return;                           /* ret */
        l_0x18_bf32:
            ii(0x18_bf32, 4); cmp(memw_a16[ds, 0x11fc], dx);            /* cmp [0x11fc], dx */
            ii(0x18_bf36, 2); if(jaw(0x18_bf47, 0xf)) goto l_0x18_bf47; /* ja 0xbf47 */
            ii(0x18_bf38, 2); if(jbw(0x18_bf40, 0x6)) goto l_0x18_bf40; /* jb 0xbf40 */
            ii(0x18_bf3a, 4); cmp(memw_a16[ds, 0x11fa], ax);            /* cmp [0x11fa], ax */
            ii(0x18_bf3e, 2); if(jaew(0x18_bf47, 0x7)) goto l_0x18_bf47; /* jae 0xbf47 */
        l_0x18_bf40:
            ii(0x18_bf40, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x18_bf43, 4); mov(memw_a16[ds, 0x11fc], dx);            /* mov [0x11fc], dx */
        l_0x18_bf47:
            ii(0x18_bf47, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_bf49, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_bf4c, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_bf4f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_bf52, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_bf55, 1); pushw(dx);                                /* push dx */
            ii(0x18_bf56, 1); pushw(ax);                                /* push ax */
            ii(0x18_bf57, 3); callw(0x18_db51, 0x1bf7);                 /* call 0xdb51 */
            ii(0x18_bf5a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_bf5d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_bf60, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_bf63, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_bf65, 2); if(jnzw(0x18_bf6a, 0x3)) goto l_0x18_bf6a; /* jnz 0xbf6a */
            ii(0x18_bf67, 3); jmpw(0x18_be2d, -0x13d); goto l_0x18_be2d; /* jmp 0xbe2d */
        l_0x18_bf6a:
            ii(0x18_bf6a, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x18_bf6d, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x18_bf70, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x18_bf73, 2); if(jbw(0x18_bf8c, 0x17)) goto l_0x18_bf8c; /* jb 0xbf8c */
            ii(0x18_bf75, 2); if(jaw(0x18_bf7c, 0x5)) goto l_0x18_bf7c; /* ja 0xbf7c */
            ii(0x18_bf77, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x18_bf7a, 2); if(jbw(0x18_bf8c, 0x10)) goto l_0x18_bf8c; /* jb 0xbf8c */
        l_0x18_bf7c:
            ii(0x18_bf7c, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_bf7f, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_bf82, 3); callw(0x18_bcce, -0x2b7);                 /* call 0xbcce */
            ii(0x18_bf85, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_bf87, 2); if(jzw(0x18_bf8c, 0x3)) goto l_0x18_bf8c; /* jz 0xbf8c */
            ii(0x18_bf89, 3); jmpw(0x18_be2d, -0x15f); goto l_0x18_be2d; /* jmp 0xbe2d */
        l_0x18_bf8c:
            ii(0x18_bf8c, 2); pushw(0x1d);                              /* push 0x1d */
            ii(0x18_bf8e, 3); callw(0x18_d9c5, 0x1a34);                 /* call 0xd9c5 */
            ii(0x18_bf91, 1); popw(bx);                                 /* pop bx */
            ii(0x18_bf92, 3); jmpw(0x18_be2d, -0x168); goto l_0x18_be2d; /* jmp 0xbe2d */
        l_0x18_bf95:
            ii(0x18_bf95, 1); sti();                                    /* sti */
            ii(0x18_bf96, 5); cmp(memw_a16[ds, 0x1206], 0);             /* cmp word [0x1206], 0x0 */
            ii(0x18_bf9b, 2); if(jnzw(0x18_bfa0, 0x3)) goto l_0x18_bfa0; /* jnz 0xbfa0 */
            ii(0x18_bf9d, 3); jmpw(0x18_be14, -0x18c); goto l_0x18_be14; /* jmp 0xbe14 */
        l_0x18_bfa0:
            ii(0x18_bfa0, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x18_bfa3, 3); inc(memw_a16[ss, bp - 0x14]);             /* inc word [bp-0x14] */
            ii(0x18_bfa6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_bfa8, 2); if(jzw(0x18_bfad, 0x3)) goto l_0x18_bfad; /* jz 0xbfad */
            ii(0x18_bfaa, 3); jmpw(0x18_be14, -0x199); goto l_0x18_be14; /* jmp 0xbe14 */
        l_0x18_bfad:
            ii(0x18_bfad, 3); mov(ax, memw_a16[ds, 0x1206]);            /* mov ax, [0x1206] */
            ii(0x18_bfb0, 3); shr(ax, 0x6);                             /* shr ax, 0x6 */
            ii(0x18_bfb3, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x18_bfb5, 3); mov(ax, memw_a16[ds, 0x1206]);            /* mov ax, [0x1206] */
            ii(0x18_bfb8, 3); shl(ax, 0xa);                             /* shl ax, 0xa */
            ii(0x18_bfbb, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x18_bfbd, 1); cwd();                                    /* cwd */
            ii(0x18_bfbe, 2); or(dx, bx);                               /* or dx, bx */
            ii(0x18_bfc0, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x18_bfc3, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x18_bfc6, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_bfc9, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_bfcc, 3); callw(0x18_dbd7, 0x1c08);                 /* call 0xdbd7 */
            ii(0x18_bfcf, 1); popw(bx);                                 /* pop bx */
            ii(0x18_bfd0, 1); popw(bx);                                 /* pop bx */
            ii(0x18_bfd1, 3); cmp(dx, memw_a16[ss, bp - 0x10]);         /* cmp dx, [bp-0x10] */
            ii(0x18_bfd4, 2); if(jlw(0x18_bfe3, 0xd)) goto l_0x18_bfe3; /* jl 0xbfe3 */
            ii(0x18_bfd6, 2); if(jgw(0x18_bfdd, 0x5)) goto l_0x18_bfdd; /* jg 0xbfdd */
            ii(0x18_bfd8, 3); cmp(ax, memw_a16[ss, bp - 0x12]);         /* cmp ax, [bp-0x12] */
            ii(0x18_bfdb, 2); if(jbew(0x18_bfe3, 0x6)) goto l_0x18_bfe3; /* jbe 0xbfe3 */
        l_0x18_bfdd:
            ii(0x18_bfdd, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x18_bfe0, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
        l_0x18_bfe3:
            ii(0x18_bfe3, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x18_bfe5, 3); mov(ax, memw_a16[ds, 0xaa8]);             /* mov ax, [0xaa8] */
            ii(0x18_bfe8, 4); mov(dx, memw_a16[ds, 0xaaa]);             /* mov dx, [0xaaa] */
            ii(0x18_bfec, 3); add(ax, memw_a16[ss, bp - 0x12]);         /* add ax, [bp-0x12] */
            ii(0x18_bfef, 3); adc(dx, memw_a16[ss, bp - 0x10]);         /* adc dx, [bp-0x10] */
            ii(0x18_bff2, 1); pushw(dx);                                /* push dx */
            ii(0x18_bff3, 1); pushw(ax);                                /* push ax */
            ii(0x18_bff4, 3); callw(0x18_d672, 0x167b);                 /* call 0xd672 */
            ii(0x18_bff7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_bffa, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_bffc, 2); if(jzw(0x18_c001, 0x3)) goto l_0x18_c001; /* jz 0xc001 */
            ii(0x18_bffe, 3); jmpw(0x18_bdea, -0x217); goto l_0x18_bdea; /* jmp 0xbdea */
        l_0x18_c001:
            ii(0x18_c001, 3); jmpw(0x18_be14, -0x1f0); goto l_0x18_be14; /* jmp 0xbe14 */
        }
    }
}
