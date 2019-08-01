using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a3448b3-4718-46b5-95ed-1015851043a8")]
        public void Method_0014_ce29()
        {
            ii(0x14_ce29, 4); enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x14_ce2d, 1); pushw(di);                                /* push di */
            ii(0x14_ce2e, 1); pushw(si);                                /* push si */
            ii(0x14_ce2f, 4); mov(memb_a16[ss, bp - 0x4], 0);           /* mov byte [bp-0x4], 0x0 */
            ii(0x14_ce33, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_ce36, 4); mov(di, memw_a16[es, bx + 0x6]);          /* mov di, [es:bx+0x6] */
            ii(0x14_ce3a, 3); lea(ax, bp - 0x1a);                       /* lea ax, [bp-0x1a] */
            ii(0x14_ce3d, 1); pushw(ax);                                /* push ax */
            ii(0x14_ce3e, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x14_ce42, 3); callw(0x14_dc8e, 0xe49);                  /* call 0xdc8e */
            ii(0x14_ce45, 1); popw(bx);                                 /* pop bx */
            ii(0x14_ce46, 1); popw(bx);                                 /* pop bx */
            ii(0x14_ce47, 3); mov(al, memb_a16[ss, bp - 0x12]);         /* mov al, [bp-0x12] */
            ii(0x14_ce4a, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x14_ce4c, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x14_ce4f, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x14_ce51, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_ce54, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x14_ce58, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x14_ce5c, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x14_ce5f, 1); cbw();                                    /* cbw */
            ii(0x14_ce60, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x14_ce63, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x14_ce65, 2); if(jnzw(0x14_ce73, 0xc)) goto l_0x14_ce73; /* jnz 0xce73 */
            ii(0x14_ce67, 3); mov(ax, memw_a16[ds, 0xc26]);             /* mov ax, [0xc26] */
            ii(0x14_ce6a, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_ce6d, 4); cmp(memw_a16[es, bx + 0x22], ax);         /* cmp [es:bx+0x22], ax */
            ii(0x14_ce71, 2); if(jnzw(0x14_ce8a, 0x17)) goto l_0x14_ce8a; /* jnz 0xce8a */
        l_0x14_ce73:
            ii(0x14_ce73, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x14_ce76, 3); and(ax, 0x18);                            /* and ax, 0x18 */
            ii(0x14_ce79, 3); cmp(ax, 0x10);                            /* cmp ax, 0x10 */
            ii(0x14_ce7c, 2); if(jzw(0x14_cea4, 0x26)) goto l_0x14_cea4; /* jz 0xcea4 */
            ii(0x14_ce7e, 3); cmp(ax, 0x18);                            /* cmp ax, 0x18 */
            ii(0x14_ce81, 2); if(jnzw(0x14_ce8a, 0x7)) goto l_0x14_ce8a; /* jnz 0xce8a */
            ii(0x14_ce83, 5); cmp(memb_a16[ds, 0x980], 0x4);            /* cmp byte [0x980], 0x4 */
            ii(0x14_ce88, 2); if(jlw(0x14_cea4, 0x1a)) goto l_0x14_cea4; /* jl 0xcea4 */
        l_0x14_ce8a:
            ii(0x14_ce8a, 4); cmp(memb_a16[ss, bp - 0x4], 0);           /* cmp byte [bp-0x4], 0x0 */
            ii(0x14_ce8e, 2); if(jzw(0x14_ce93, 0x3)) goto l_0x14_ce93; /* jz 0xce93 */
            ii(0x14_ce90, 3); jmpw(0x14_d052, 0x1bf); goto l_0x14_d052; /* jmp 0xd052 */
        l_0x14_ce93:
            ii(0x14_ce93, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_ce96, 6); mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
            ii(0x14_ce9c, 5); or(memb_a16[es, bx + 0x26], 0x1);         /* or byte [es:bx+0x26], 0x1 */
            ii(0x14_cea1, 3); jmpw(0x14_d052, 0x1ae); goto l_0x14_d052; /* jmp 0xd052 */
        l_0x14_cea4:
            ii(0x14_cea4, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cea7, 5); and(memb_a16[es, bx + 0x26], -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
            ii(0x14_ceac, 4); cmp(memw_a16[ss, bp - 0x18], 0x10);       /* cmp word [bp-0x18], 0x10 */
            ii(0x14_ceb0, 2); if(jbw(0x14_ced6, 0x24)) goto l_0x14_ced6; /* jb 0xced6 */
            ii(0x14_ceb2, 3); mov(al, memb_a16[ds, 0x980]);             /* mov al, [0x980] */
            ii(0x14_ceb5, 1); cbw();                                    /* cbw */
            ii(0x14_ceb6, 2); jmpw(0x14_cebd, 0x5); goto l_0x14_cebd;   /* jmp 0xcebd */
        l_0x14_ceb8:
            ii(0x14_ceb8, 3); inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
            ii(0x14_cebb, 2); jmpw(0x14_cf12, 0x55); goto l_0x14_cf12;  /* jmp 0xcf12 */
        l_0x14_cebd:
            ii(0x14_cebd, 3); cmp(ax, 0x5);                             /* cmp ax, 0x5 */
            ii(0x14_cec0, 2); if(jaw(0x14_cf12, 0x50)) goto l_0x14_cf12; /* ja 0xcf12 */
            ii(0x14_cec2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x14_cec4, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x14_cec5, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx + 0x33aa]))
            {
                case 0x14_ceb8:
                    goto l_0x14_ceb8;
                case 0x14_cf12:
                    goto l_0x14_cf12;
                case 0x14_d052:
                    goto l_0x14_d052;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx+0x33aa] */
        //    ii(0x14_ceca, 12); /* Служебная область с абсолютными адресами переходов. {0x14_d052, 0x14_ceb8, 0x14_d052, 0x14_cf12, 0x14_cf12, 0x14_cf12}. */
        l_0x14_ced6:
            ii(0x14_ced6, 3); mov(al, memb_a16[ds, 0x980]);             /* mov al, [0x980] */
            ii(0x14_ced9, 1); cbw();                                    /* cbw */
            ii(0x14_ceda, 2); jmpw(0x14_cef9, 0x1d); goto l_0x14_cef9;  /* jmp 0xcef9 */
        l_0x14_cedc:
            ii(0x14_cedc, 3); inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
            ii(0x14_cedf, 2); jmpw(0x14_cf12, 0x31); goto l_0x14_cf12;  /* jmp 0xcf12 */
        l_0x14_cee1:
            ii(0x14_cee1, 4); test(di, 0x3);                            /* test di, 0x3 */
            ii(0x14_cee5, 2); if(jnzw(0x14_cf12, 0x2b)) goto l_0x14_cf12; /* jnz 0xcf12 */
        l_0x14_cee7:
            ii(0x14_cee7, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x14_ceea, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x14_ceed, 3); callw(0x14_dbbc, 0xccc);                  /* call 0xdbbc */
            ii(0x14_cef0, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cef1, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cef2, 2); cmp(ax, di);                              /* cmp ax, di */
            ii(0x14_cef4, 2); if(jnzw(0x14_cf12, 0x1c)) goto l_0x14_cf12; /* jnz 0xcf12 */
            ii(0x14_cef6, 3); jmpw(0x14_d052, 0x159); goto l_0x14_d052; /* jmp 0xd052 */
        l_0x14_cef9:
            ii(0x14_cef9, 3); cmp(ax, 0x5);                             /* cmp ax, 0x5 */
            ii(0x14_cefc, 2); if(jaw(0x14_cf12, 0x14)) goto l_0x14_cf12; /* ja 0xcf12 */
            ii(0x14_cefe, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x14_cf00, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x14_cf01, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx + 0x33e6]))
            {
                case 0x14_cedc:
                    goto l_0x14_cedc;
                case 0x14_cee1:
                    goto l_0x14_cee1;
                case 0x14_cee7:
                    goto l_0x14_cee7;
                case 0x14_cf12:
                    goto l_0x14_cf12;
                case 0x14_d052:
                    goto l_0x14_d052;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx+0x33e6] */
        //    ii(0x14_cf06, 12); /* Служебная область с абсолютными адресами переходов. {0x14_cedc, 0x14_d052, 0x14_cf12, 0x14_d052, 0x14_cee7, 0x14_cee1}. */
        l_0x14_cf12:
            ii(0x14_cf12, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x14_cf15, 3); callw(0x14_daf7, 0xbdf);                  /* call 0xdaf7 */
            ii(0x14_cf18, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf19, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cf1c, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x14_cf20, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x14_cf24, 3); mov(memw_a16[ds, bx + 0x10], ax);         /* mov [bx+0x10], ax */
            ii(0x14_cf27, 3); mov(ax, 0x4800);                          /* mov ax, 0x4800 */
            ii(0x14_cf2a, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cf2d, 4); mov(memw_a16[es, bx + 0x16], ax);         /* mov [es:bx+0x16], ax */
            ii(0x14_cf31, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x14_cf35, 3); mov(memw_a16[ds, bx + 0x16], ax);         /* mov [bx+0x16], ax */
            ii(0x14_cf38, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_cf3a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_cf3d, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x14_cf40, 3); callw(0x14_c85e, -0x6e5);                 /* call 0xc85e */
            ii(0x14_cf43, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_cf46, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cf49, 5); test(memb_a16[es, bx + 0x26], 0x1);       /* test byte [es:bx+0x26], 0x1 */
            ii(0x14_cf4e, 2); if(jzw(0x14_cf53, 0x3)) goto l_0x14_cf53; /* jz 0xcf53 */
            ii(0x14_cf50, 3); jmpw(0x14_ce8a, -0xc9); goto l_0x14_ce8a; /* jmp 0xce8a */
        l_0x14_cf53:
            ii(0x14_cf53, 4); mov(si, memw_a16[es, bx + 0x16]);         /* mov si, [es:bx+0x16] */
            ii(0x14_cf57, 4); test(memb_a16[ss, bp - 0x6], 0xc0);       /* test byte [bp-0x6], 0xc0 */
            ii(0x14_cf5b, 2); if(jzw(0x14_cf7b, 0x1e)) goto l_0x14_cf7b; /* jz 0xcf7b */
            ii(0x14_cf5d, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x14_cf60, 1); pushw(si);                                /* push si */
            ii(0x14_cf61, 3); callw(0x14_a786, -0x27de);                /* call 0xa786 */
            ii(0x14_cf64, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf65, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf66, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_cf68, 2); if(jnzw(0x14_cf7b, 0x11)) goto l_0x14_cf7b; /* jnz 0xcf7b */
            ii(0x14_cf6a, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cf6d, 4); mov(memw_a16[es, bx + 0x6], si);          /* mov [es:bx+0x6], si */
            ii(0x14_cf71, 1); pushw(es);                                /* push es */
            ii(0x14_cf72, 1); pushw(bx);                                /* push bx */
            ii(0x14_cf73, 3); callw(0x14_ccf7, -0x27f);                 /* call 0xccf7 */
            ii(0x14_cf76, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf77, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf78, 3); jmpw(0x14_ce8a, -0xf1); goto l_0x14_ce8a; /* jmp 0xce8a */
        l_0x14_cf7b:
            ii(0x14_cf7b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_cf7d, 3); callw(0x14_a5a9, -0x29d7);                /* call 0xa5a9 */
            ii(0x14_cf80, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf81, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x14_cf84, 1); pushw(ax);                                /* push ax */
            ii(0x14_cf85, 1); pushw(si);                                /* push si */
            ii(0x14_cf86, 3); callw(0x14_dc8e, 0xd05);                  /* call 0xdc8e */
            ii(0x14_cf89, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf8a, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf8b, 5); cmp(memb_a16[ds, 0x980], 0x4);            /* cmp byte [0x980], 0x4 */
            ii(0x14_cf90, 2); if(jnzw(0x14_cf96, 0x4)) goto l_0x14_cf96; /* jnz 0xcf96 */
            ii(0x14_cf92, 4); or(memb_a16[ss, bp - 0x2], 0x60);         /* or byte [bp-0x2], 0x60 */
        l_0x14_cf96:
            ii(0x14_cf96, 1); pushw(di);                                /* push di */
            ii(0x14_cf97, 3); callw(0x14_d0fa, 0x160);                  /* call 0xd0fa */
            ii(0x14_cf9a, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cf9b, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_cf9e, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x14_cfa2, 3); mov(al, memb_a16[ss, bp - 0x6]);          /* mov al, [bp-0x6] */
            ii(0x14_cfa5, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x14_cfa7, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_cfaa, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x14_cfae, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x14_cfb2, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x14_cfb5, 1); pushw(di);                                /* push di */
            ii(0x14_cfb6, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x14_cfb9, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x14_cfbc, 3); callw(0x14_dbbc, 0xbfd);                  /* call 0xdbbc */
            ii(0x14_cfbf, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cfc0, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cfc1, 1); pushw(dx);                                /* push dx */
            ii(0x14_cfc2, 1); pushw(ax);                                /* push ax */
            ii(0x14_cfc3, 3); callw(0x14_d9ca, 0xa04);                  /* call 0xd9ca */
            ii(0x14_cfc6, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_cfc9, 5); cmp(memb_a16[ds, 0x980], 0x4);            /* cmp byte [0x980], 0x4 */
            ii(0x14_cfce, 2); if(jlw(0x14_cfee, 0x1e)) goto l_0x14_cfee; /* jl 0xcfee */
            ii(0x14_cfd0, 3); mov(al, memb_a16[ss, bp - 0x6]);          /* mov al, [bp-0x6] */
            ii(0x14_cfd3, 2); and(al, 0x10);                            /* and al, 0x10 */
            ii(0x14_cfd5, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x14_cfd7, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_cfda, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x14_cfde, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x14_cfe2, 3); or(memb_a16[es, bx], al);                 /* or [es:bx], al */
            ii(0x14_cfe5, 1); pushw(di);                                /* push di */
            ii(0x14_cfe6, 3); callw(0x14_dd01, 0xd18);                  /* call 0xdd01 */
            ii(0x14_cfe9, 1); popw(bx);                                 /* pop bx */
            ii(0x14_cfea, 2); mov(di, si);                              /* mov di, si */
            ii(0x14_cfec, 2); jmpw(0x14_cff3, 0x5); goto l_0x14_cff3;   /* jmp 0xcff3 */
        l_0x14_cfee:
            ii(0x14_cfee, 1); pushw(si);                                /* push si */
            ii(0x14_cfef, 3); callw(0x14_dd01, 0xd0f);                  /* call 0xdd01 */
            ii(0x14_cff2, 1); popw(bx);                                 /* pop bx */
        l_0x14_cff3:
            ii(0x14_cff3, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x14_cff6, 3); mov(memb_a16[ss, bp - 0x8], al);          /* mov [bp-0x8], al */
            ii(0x14_cff9, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x14_cffc, 1); pushw(ax);                                /* push ax */
            ii(0x14_cffd, 1); pushw(di);                                /* push di */
            ii(0x14_cffe, 3); callw(0x14_dc28, 0xc27);                  /* call 0xdc28 */
            ii(0x14_d001, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d002, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d003, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_d005, 2); if(jnzw(0x14_d00e, 0x7)) goto l_0x14_d00e; /* jnz 0xd00e */
            ii(0x14_d007, 3); pushw(0x102);                             /* push 0x102 */
            ii(0x14_d00a, 3); callw(0x14_d9c5, 0x9b8);                  /* call 0xd9c5 */
            ii(0x14_d00d, 1); popw(bx);                                 /* pop bx */
        l_0x14_d00e:
            ii(0x14_d00e, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_d011, 4); mov(bx, memw_a16[es, bx + 0x6]);          /* mov bx, [es:bx+0x6] */
            ii(0x14_d015, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_d018, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x14_d01c, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x14_d020, 4); mov(memb_a16[es, bx], 0x1);               /* mov byte [es:bx], 0x1 */
            ii(0x14_d024, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_d027, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x14_d02a, 3); callw(0x14_ccf7, -0x336);                 /* call 0xccf7 */
            ii(0x14_d02d, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d02e, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d02f, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x14_d032, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x14_d035, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x14_d038, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x14_d03b, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x14_d03e, 1); pushw(di);                                /* push di */
            ii(0x14_d03f, 3); callw(0x14_d585, 0x543);                  /* call 0xd585 */
            ii(0x14_d042, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x14_d045, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x14_d047, 3); callw(0x14_a5a9, -0x2aa1);                /* call 0xa5a9 */
            ii(0x14_d04a, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d04b, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x14_d04e, 4); mov(memw_a16[es, bx + 0x6], di);          /* mov [es:bx+0x6], di */
        l_0x14_d052:
            ii(0x14_d052, 1); popw(si);                                 /* pop si */
            ii(0x14_d053, 1); popw(di);                                 /* pop di */
            ii(0x14_d054, 1); leavew();                                 /* leave */
            ii(0x14_d055, 1); retw(); return;                           /* ret */
        }
    }
}
