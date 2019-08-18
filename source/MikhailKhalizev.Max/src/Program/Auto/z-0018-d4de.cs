using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d4de-8ad805d1")]
        public void Method_0018_d4de()
        {
            ii(0x18_d4de, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x18_d4e2, 1); pushw(di);                                /* push di */
            ii(0x18_d4e3, 1); pushw(si);                                /* push si */
            ii(0x18_d4e4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_d4e7, 3); dec(memw_a16[ss, bp + 0x6]);              /* dec word [bp+0x6] */
            ii(0x18_d4ea, 3); cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x18_d4ed, 2); if(jnzw(0x18_d4f2, 0x3)) goto l_0x18_d4f2; /* jnz 0xd4f2 */
            ii(0x18_d4ef, 3); jmpw(0x18_d581, 0x8f); goto l_0x18_d581;  /* jmp 0xd581 */
        l_0x18_d4f2:
            ii(0x18_d4f2, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x18_d4f5, 1); pushw(ax);                                /* push ax */
            ii(0x18_d4f6, 4); mov(cx, memw_a16[ds, 0xc38]);             /* mov cx, [0xc38] */
            ii(0x18_d4fa, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x18_d4fd, 1); pushw(cx);                                /* push cx */
            ii(0x18_d4fe, 3); callw(0x18_dc8e, 0x78d);                  /* call 0xdc8e */
            ii(0x18_d501, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d502, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d503, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_d506, 3); shr(ax, 0xc);                             /* shr ax, 0xc */
            ii(0x18_d509, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x18_d50c, 3); shl(cx, 0x4);                             /* shl cx, 0x4 */
            ii(0x18_d50f, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x18_d512, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x18_d515, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x18_d518, 1); pushw(ax);                                /* push ax */
            ii(0x18_d519, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_d51c, 3); callw(0x18_dc28, 0x709);                  /* call 0xdc28 */
            ii(0x18_d51f, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d520, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d521, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_d524, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x18_d526, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_d528, 3); mov(memw_a16[ss, bp - 0x8], bx);          /* mov [bp-0x8], bx */
            ii(0x18_d52b, 3); mov(memw_a16[ss, bp - 0x6], es);          /* mov [bp-0x6], es */
            ii(0x18_d52e, 4); cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x18_d532, 2); if(jzw(0x18_d53a, 0x6)) goto l_0x18_d53a; /* jz 0xd53a */
            ii(0x18_d534, 4); cmp(memb_a16[es, bx], 0x5a);              /* cmp byte [es:bx], 0x5a */
            ii(0x18_d538, 2); if(jnzw(0x18_d581, 0x47)) goto l_0x18_d581; /* jnz 0xd581 */
        l_0x18_d53a:
            ii(0x18_d53a, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_d53d, 3); sub(ax, memw_a16[ss, bp + 0x6]);          /* sub ax, [bp+0x6] */
            ii(0x18_d540, 1); dec(ax);                                  /* dec ax */
            ii(0x18_d541, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_d544, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_d547, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x18_d54a, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x18_d54c, 3); mov(cx, memw_a16[ss, bp - 0x8]);          /* mov cx, [bp-0x8] */
            ii(0x18_d54f, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x18_d551, 1); pushw(cx);                                /* push cx */
            ii(0x18_d552, 1); pushw(ds);                                /* push ds */
            ii(0x18_d553, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x18_d555, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x18_d557, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x18_d559, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x18_d55c, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x18_d55e, 1); popw(ds);                                 /* pop ds */
            ii(0x18_d55f, 1); popw(cx);                                 /* pop cx */
            ii(0x18_d560, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x18_d562, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x18_d564, 4); mov(memb_a16[es, si], 0x4d);              /* mov byte [es:si], 0x4d */
            ii(0x18_d568, 3); mov(di, memw_a16[ss, bp - 0x4]);          /* mov di, [bp-0x4] */
            ii(0x18_d56b, 1); dec(di);                                  /* dec di */
            ii(0x18_d56c, 4); mov(memw_a16[es, si + 0x3], di);          /* mov [es:si+0x3], di */
            ii(0x18_d570, 6); mov(memw_a16[es, si + 0x1], 0);           /* mov word [es:si+0x1], 0x0 */
            ii(0x18_d576, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x18_d578, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_d57a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_d57d, 4); sub(memw_a16[es, si + 0x3], ax);          /* sub [es:si+0x3], ax */
        l_0x18_d581:
            ii(0x18_d581, 1); popw(si);                                 /* pop si */
            ii(0x18_d582, 1); popw(di);                                 /* pop di */
            ii(0x18_d583, 1); leavew();                                 /* leave */
            ii(0x18_d584, 1); retw(); return;                           /* ret */
        //  ii(0x18_d585, 237); Недостижимый (и не декодированный) код.
        //    ii(0x18_d672, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
        //    ii(0x18_d676, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
        //    ii(0x18_d67b, 2); if(jzw(0x18_d6b8, 0x3b)) goto l_0x18_d6b8; /* jz 0xd6b8 */
        //    ii(0x18_d67d, 5); cmp(memb_a16[ds, 0xa16], 0);              /* cmp byte [0xa16], 0x0 */
        //    ii(0x18_d682, 2); if(jnzw(0x18_d6b8, 0x34)) goto l_0x18_d6b8; /* jnz 0xd6b8 */
        //    ii(0x18_d684, 3); mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
        //    ii(0x18_d687, 4); mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
        //    ii(0x18_d68b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
        //    ii(0x18_d68e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        //    ii(0x18_d691, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
        //    ii(0x18_d696, 2); if(jnzw(0x18_d6a1, 0x9)) goto l_0x18_d6a1; /* jnz 0xd6a1 */
        l_0x18_d698:
            ii(0x18_d698, 3); mov(ax, memw_a16[ds, 0xaa8]);             /* mov ax, [0xaa8] */
            ii(0x18_d69b, 4); mov(dx, memw_a16[ds, 0xaaa]);             /* mov dx, [0xaaa] */
            ii(0x18_d69f, 1); leavew();                                 /* leave */
            ii(0x18_d6a0, 1); retw(); return;                           /* ret */
        l_0x18_d6a1:
            ii(0x18_d6a1, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_d6a4, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_d6a7, 4); sub(ax, memw_a16[ds, 0x98]);              /* sub ax, [0x98] */
            ii(0x18_d6ab, 4); sbb(dx, memw_a16[ds, 0x9a]);              /* sbb dx, [0x9a] */
            ii(0x18_d6af, 1); pushw(dx);                                /* push dx */
            ii(0x18_d6b0, 1); pushw(ax);                                /* push ax */
            ii(0x18_d6b1, 3); callw(0x18_dbd7, 0x523);                  /* call 0xdbd7 */
            ii(0x18_d6b4, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d6b5, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d6b6, 1); leavew();                                 /* leave */
            ii(0x18_d6b7, 1); retw(); return;                           /* ret */
        l_0x18_d6b8:
            ii(0x18_d6b8, 5); mov(memw_a16[ss, bp - 0x14], 0x3);        /* mov word [bp-0x14], 0x3 */
        l_0x18_d6bd:
            ii(0x18_d6bd, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_d6c0, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_d6c3, 4); sub(ax, memw_a16[ds, 0xaa8]);             /* sub ax, [0xaa8] */
            ii(0x18_d6c7, 4); sbb(dx, memw_a16[ds, 0xaaa]);             /* sbb dx, [0xaaa] */
            ii(0x18_d6cb, 3); add(ax, 0xfff);                           /* add ax, 0xfff */
            ii(0x18_d6ce, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x18_d6d1, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x18_d6d4, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x18_d6d7, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x18_d6da, 5); mov(memw_a16[ss, bp - 0xe], 0x3);         /* mov word [bp-0xe], 0x3 */
        l_0x18_d6df:
            ii(0x18_d6df, 4); callw_abs(memw_a16[ds, 0xaa4]);           /* call word [0xaa4] */
            ii(0x18_d6e3, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_d6e6, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_d6e9, 3); cmp(dx, memw_a16[ss, bp - 0xa]);          /* cmp dx, [bp-0xa] */
            ii(0x18_d6ec, 2); if(jgw(0x18_d701, 0x13)) goto l_0x18_d701; /* jg 0xd701 */
            ii(0x18_d6ee, 2); if(jlw(0x18_d6f5, 0x5)) goto l_0x18_d6f5; /* jl 0xd6f5 */
            ii(0x18_d6f0, 3); cmp(ax, memw_a16[ss, bp - 0xc]);          /* cmp ax, [bp-0xc] */
            ii(0x18_d6f3, 2); if(jaew(0x18_d701, 0xc)) goto l_0x18_d701; /* jae 0xd701 */
        l_0x18_d6f5:
            ii(0x18_d6f5, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x18_d6f9, 2); if(jnzw(0x18_d698, -0x63)) goto l_0x18_d698; /* jnz 0xd698 */
            ii(0x18_d6fb, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x18_d6fe, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
        l_0x18_d701:
            ii(0x18_d701, 4); cmp(memw_a16[ss, bp - 0xa], 0);           /* cmp word [bp-0xa], 0x0 */
            ii(0x18_d705, 2); if(jgw(0x18_d70f, 0x8)) goto l_0x18_d70f; /* jg 0xd70f */
            ii(0x18_d707, 2); if(jlw(0x18_d698, -0x71)) goto l_0x18_d698; /* jl 0xd698 */
            ii(0x18_d709, 4); cmp(memw_a16[ss, bp - 0xc], 0);           /* cmp word [bp-0xc], 0x0 */
            ii(0x18_d70d, 2); if(jzw(0x18_d698, -0x77)) goto l_0x18_d698; /* jz 0xd698 */
        l_0x18_d70f:
            ii(0x18_d70f, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x18_d712, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_d715, 4); callw_abs(memw_a16[ds, 0xaa6]);           /* call word [0xaa6] */
            ii(0x18_d719, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d71a, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d71b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_d71e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_d721, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_d723, 2); if(jnzw(0x18_d73b, 0x16)) goto l_0x18_d73b; /* jnz 0xd73b */
            ii(0x18_d725, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x18_d729, 2); if(jzw(0x18_d733, 0x8)) goto l_0x18_d733; /* jz 0xd733 */
            ii(0x18_d72b, 3); dec(memw_a16[ss, bp - 0xe]);              /* dec word [bp-0xe] */
            ii(0x18_d72e, 2); if(jnsw(0x18_d733, 0x3)) goto l_0x18_d733; /* jns 0xd733 */
            ii(0x18_d730, 3); jmpw(0x18_d698, -0x9b); goto l_0x18_d698; /* jmp 0xd698 */
        l_0x18_d733:
            ii(0x18_d733, 3); sar(memw_a16[ss, bp - 0xa], 0x1);         /* sar word [bp-0xa], 1 */
            ii(0x18_d736, 3); rcr(memw_a16[ss, bp - 0xc], 0x1);         /* rcr word [bp-0xc], 1 */
            ii(0x18_d739, 2); jmpw(0x18_d6df, -0x5c); goto l_0x18_d6df; /* jmp 0xd6df */
        l_0x18_d73b:
            ii(0x18_d73b, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_d73e, 1); pushw(ax);                                /* push ax */
            ii(0x18_d73f, 3); callw(0x18_dbbc, 0x47a);                  /* call 0xdbbc */
            ii(0x18_d742, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d743, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d744, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x18_d747, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x18_d74a, 1); cli();                                    /* cli */
            ii(0x18_d74b, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x18_d74e, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x18_d751, 4); cmp(memw_a16[ds, 0x9a], dx);              /* cmp [0x9a], dx */
            ii(0x18_d755, 2); if(jaw(0x18_d768, 0x11)) goto l_0x18_d768; /* ja 0xd768 */
            ii(0x18_d757, 2); if(jbw(0x18_d75f, 0x6)) goto l_0x18_d75f; /* jb 0xd75f */
            ii(0x18_d759, 4); cmp(memw_a16[ds, 0x98], ax);              /* cmp [0x98], ax */
            ii(0x18_d75d, 2); if(jaw(0x18_d768, 0x9)) goto l_0x18_d768; /* ja 0xd768 */
        l_0x18_d75f:
            ii(0x18_d75f, 3); mov(ax, memw_a16[ds, 0x9a]);              /* mov ax, [0x9a] */
            ii(0x18_d762, 4); or(ax, memw_a16[ds, 0x98]);               /* or ax, [0x98] */
            ii(0x18_d766, 2); if(jnzw(0x18_d7b4, 0x4c)) goto l_0x18_d7b4; /* jnz 0xd7b4 */
        l_0x18_d768:
            ii(0x18_d768, 3); mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x18_d76b, 4); mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x18_d76f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_d772, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_d775, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x18_d778, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x18_d77b, 3); mov(memw_a16[ds, 0x98], ax);              /* mov [0x98], ax */
            ii(0x18_d77e, 4); mov(memw_a16[ds, 0x9a], dx);              /* mov [0x9a], dx */
            ii(0x18_d782, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_d785, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_d788, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_d78a, 1); pushw(dx);                                /* push dx */
            ii(0x18_d78b, 1); pushw(ax);                                /* push ax */
            ii(0x18_d78c, 3); callw(0x18_db67, 0x3d8);                  /* call 0xdb67 */
            ii(0x18_d78f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_d792, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_d794, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_d796, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_d798, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x18_d79b, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x18_d79e, 3); callw(0x18_db67, 0x3c6);                  /* call 0xdb67 */
            ii(0x18_d7a1, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_d7a4, 4); add(memw_a16[ss, bp - 0x12], 0x1);        /* add word [bp-0x12], 0x1 */
            ii(0x18_d7a8, 4); adc(memw_a16[ss, bp - 0x10], 0);          /* adc word [bp-0x10], 0x0 */
            ii(0x18_d7ac, 4); sub(memw_a16[ss, bp - 0xc], 0x10);        /* sub word [bp-0xc], 0x10 */
            ii(0x18_d7b0, 4); sbb(memw_a16[ss, bp - 0xa], 0);           /* sbb word [bp-0xa], 0x0 */
        l_0x18_d7b4:
            ii(0x18_d7b4, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x18_d7b7, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_d7ba, 3); callw(0x18_dbbc, 0x3ff);                  /* call 0xdbbc */
            ii(0x18_d7bd, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d7be, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d7bf, 3); add(ax, memw_a16[ss, bp - 0x12]);         /* add ax, [bp-0x12] */
            ii(0x18_d7c2, 3); adc(dx, memw_a16[ss, bp - 0x10]);         /* adc dx, [bp-0x10] */
            ii(0x18_d7c5, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_d7c8, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_d7cb, 4); cmp(memw_a16[ds, 0x9e], dx);              /* cmp [0x9e], dx */
            ii(0x18_d7cf, 2); if(jaw(0x18_d7e0, 0xf)) goto l_0x18_d7e0; /* ja 0xd7e0 */
            ii(0x18_d7d1, 2); if(jbw(0x18_d7d9, 0x6)) goto l_0x18_d7d9; /* jb 0xd7d9 */
            ii(0x18_d7d3, 4); cmp(memw_a16[ds, 0x9c], ax);              /* cmp [0x9c], ax */
            ii(0x18_d7d7, 2); if(jaew(0x18_d7e0, 0x7)) goto l_0x18_d7e0; /* jae 0xd7e0 */
        l_0x18_d7d9:
            ii(0x18_d7d9, 3); mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x18_d7dc, 4); mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
        l_0x18_d7e0:
            ii(0x18_d7e0, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x18_d7e3, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_d7e6, 3); callw(0x18_dbbc, 0x3d3);                  /* call 0xdbbc */
            ii(0x18_d7e9, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d7ea, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d7eb, 1); pushw(dx);                                /* push dx */
            ii(0x18_d7ec, 1); pushw(ax);                                /* push ax */
            ii(0x18_d7ed, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x18_d7f0, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x18_d7f3, 3); callw(0x18_c010, -0x17e6);                /* call 0xc010 */
            ii(0x18_d7f6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_d7f9, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_d7fe, 2); if(jnzw(0x18_d811, 0x11)) goto l_0x18_d811; /* jnz 0xd811 */
            ii(0x18_d800, 4); pushw(memw_a16[ds, 0x1204]);              /* push word [0x1204] */
            ii(0x18_d804, 4); pushw(memw_a16[ds, 0x1202]);              /* push word [0x1202] */
            ii(0x18_d808, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x18_d80b, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x18_d80e, 3); callw(0x18_c436, -0x13db);                /* call 0xc436 */
        l_0x18_d811:
            ii(0x18_d811, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x18_d816, 2); if(jzw(0x18_d826, 0xe)) goto l_0x18_d826; /* jz 0xd826 */
            ii(0x18_d818, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x18_d81b, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x18_d81e, 4); add(memw_a16[ds, 0xaa8], ax);             /* add [0xaa8], ax */
            ii(0x18_d822, 4); adc(memw_a16[ds, 0xaaa], dx);             /* adc [0xaaa], dx */
        l_0x18_d826:
            ii(0x18_d826, 3); dec(memw_a16[ss, bp - 0x14]);             /* dec word [bp-0x14] */
            ii(0x18_d829, 4); cmp(memw_a16[ss, bp - 0x14], 0);          /* cmp word [bp-0x14], 0x0 */
            ii(0x18_d82d, 2); if(jgw(0x18_d832, 0x3)) goto l_0x18_d832; /* jg 0xd832 */
            ii(0x18_d82f, 3); jmpw(0x18_d698, -0x19a); goto l_0x18_d698; /* jmp 0xd698 */
        l_0x18_d832:
            ii(0x18_d832, 3); jmpw(0x18_d6bd, -0x178); goto l_0x18_d6bd; /* jmp 0xd6bd */
        //    ii(0x18_d835, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
        //    ii(0x18_d839, 1); pushw(si);                                /* push si */
        //    ii(0x18_d83a, 3); callw(0x18_f39c, 0x1b5f);                 /* call 0xf39c */
        //    ii(0x18_d83d, 2); or(ax, ax);                               /* or ax, ax */
        //    ii(0x18_d83f, 2); if(jzw(0x18_d847, 0x6)) goto l_0x18_d847; /* jz 0xd847 */
        //    ii(0x18_d841, 2); sub(ax, ax);                              /* sub ax, ax */
        //    ii(0x18_d843, 1); cwd();                                    /* cwd */
        //    ii(0x18_d844, 1); popw(si);                                 /* pop si */
        //    ii(0x18_d845, 1); leavew();                                 /* leave */
        //    ii(0x18_d846, 1); retw(); return;                           /* ret */
        l_0x18_d847:
            ii(0x18_d847, 5); cmp(memw_a16[ds, 0xadc], 0);              /* cmp word [0xadc], 0x0 */
            ii(0x18_d84c, 2); if(jzw(0x18_d85e, 0x10)) goto l_0x18_d85e; /* jz 0xd85e */
            ii(0x18_d84e, 3); callw(0x18_d945, 0xf4);                   /* call 0xd945 */
            ii(0x18_d851, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_d854, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_d856, 2); if(jzw(0x18_d85e, 0x6)) goto l_0x18_d85e; /* jz 0xd85e */
            ii(0x18_d858, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_d85b, 1); popw(si);                                 /* pop si */
            ii(0x18_d85c, 1); leavew();                                 /* leave */
            ii(0x18_d85d, 1); retw(); return;                           /* ret */
        l_0x18_d85e:
            ii(0x18_d85e, 4); pushw(memw_a16[ds, 0xae]);                /* push word [0xae] */
            ii(0x18_d862, 4); pushw(memw_a16[ds, 0xac]);                /* push word [0xac] */
            ii(0x18_d866, 3); callw(0x18_dbd7, 0x36e);                  /* call 0xdbd7 */
            ii(0x18_d869, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d86a, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d86b, 4); mov(cx, memw_a16[ds, 0xece]);             /* mov cx, [0xece] */
            ii(0x18_d86f, 3); shr(cx, 0x6);                             /* shr cx, 0x6 */
            ii(0x18_d872, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_d874, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x18_d876, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x18_d878, 4); mov(cx, memw_a16[ds, 0xece]);             /* mov cx, [0xece] */
            ii(0x18_d87c, 3); shl(cx, 0xa);                             /* shl cx, 0xa */
            ii(0x18_d87f, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_d881, 2); sub(ax, bx);                              /* sub ax, bx */
            ii(0x18_d883, 2); sbb(dx, si);                              /* sbb dx, si */
            ii(0x18_d885, 1); popw(si);                                 /* pop si */
            ii(0x18_d886, 1); leavew();                                 /* leave */
            ii(0x18_d887, 1); retw(); return;                           /* ret */
        //  ii(0x18_d888, 189); Недостижимый (и не декодированный) код.
        //    ii(0x18_d945, 1); pushw(si);                                /* push si */
        //    ii(0x18_d946, 2); xor(ax, ax);                              /* xor ax, ax */
        //    ii(0x18_d948, 5); test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
        //    ii(0x18_d94d, 2); if(jnzw(0x18_d99e, 0x4f)) goto l_0x18_d99e; /* jnz 0xd99e */
        //    ii(0x18_d94f, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
        //    ii(0x18_d954, 2); if(jnzw(0x18_d95c, 0x6)) goto l_0x18_d95c; /* jnz 0xd95c */
        //    ii(0x18_d956, 3); callw(0x18_f455, 0x1afc);                 /* call 0xf455 */
        //    ii(0x18_d959, 3); mov(memw_a16[ds, 0xaf0], ax);             /* mov [0xaf0], ax */
        l_0x18_d95c:
            ii(0x18_d95c, 2); xor(dx, dx);                              /* xor dx, dx */
        l_0x18_d95e:
            ii(0x18_d95e, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x18_d960, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_d962, 6); sub(memw_a16[ds, 0x996], 0x180);          /* sub word [0x996], 0x180 */
            ii(0x18_d968, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_d96a, 1); popw(ss);                                 /* pop ss */
            ii(0x18_d96b, 4); mov(sp, memw_a16[ds, 0x996]);             /* mov sp, [0x996] */
            ii(0x18_d96f, 3); sub(sp, 0x10);                            /* sub sp, 0x10 */
            ii(0x18_d972, 1); pushw(bx);                                /* push bx */
            ii(0x18_d973, 1); pushw(ax);                                /* push ax */
            ii(0x18_d974, 1); pushw(dx);                                /* push dx */
            ii(0x18_d975, 5); if(jmpw_far_abs(0x18, 0x1e22)) return;    /* jmp word 0x18:0x1e22 */
            ii(0x18_d97a, 1); pushw(si);                                /* push si */
            ii(0x18_d97b, 3); mov(si, 0xada);                           /* mov si, 0xada */
            ii(0x18_d97e, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x18_d980:
            ii(0x18_d980, 1); inc(si);                                  /* inc si */
            ii(0x18_d981, 1); inc(si);                                  /* inc si */
            ii(0x18_d982, 4); cmp(si, 0xaec);                           /* cmp si, 0xaec */
            ii(0x18_d986, 2); if(jaew(0x18_d99e, 0x16)) goto l_0x18_d99e; /* jae 0xd99e */
            ii(0x18_d988, 2); cmp(memw_a16[ds, si], ax);                /* cmp [si], ax */
            ii(0x18_d98a, 2); if(jnzw(0x18_d980, -0xc)) goto l_0x18_d980; /* jnz 0xd980 */
            ii(0x18_d98c, 1); pushw(bp);                                /* push bp */
            ii(0x18_d98d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_d98f, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x18_d992, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_d995, 1); popw(bp);                                 /* pop bp */
            ii(0x18_d996, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x18_d999, 2); div(cx);                                  /* div cx */
            ii(0x18_d99b, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_d99c, 2); jmpw(0x18_d95e, -0x40); goto l_0x18_d95e; /* jmp 0xd95e */
        l_0x18_d99e:
            ii(0x18_d99e, 1); cwd();                                    /* cwd */
            ii(0x18_d99f, 1); popw(si);                                 /* pop si */
            ii(0x18_d9a0, 1); retw(); return;                           /* ret */
        //  ii(0x18_d9a1, 36); Недостижимый (и не декодированный) код.
        //    ii(0x18_d9c5, 5); if(jmpw_far_abs(0x18, 0x22ad)) return;    /* jmp word 0x18:0x22ad */
        //    ii(0x18_d9ca, 1); pushw(bp);                                /* push bp */
        //    ii(0x18_d9cb, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x18_d9cd, 1); pushw(si);                                /* push si */
        //    ii(0x18_d9ce, 1); pushw(di);                                /* push di */
        //    ii(0x18_d9cf, 1); pushw(ds);                                /* push ds */
        //    ii(0x18_d9d0, 3); callw(0x18_db82, 0x1af);                  /* call 0xdb82 */
        //    ii(0x18_d9d3, 2); xor(si, si);                              /* xor si, si */
        //    ii(0x18_d9d5, 2); xor(di, di);                              /* xor di, di */
        //    ii(0x18_d9d7, 3); lsl(cx, bx);                              /* lsl cx, bx */
        //    ii(0x18_d9da, 2); if(jcxzw(0x18_da01, 0x25)) goto l_0x18_da01; /* jcxz 0xda01 */
        //    ii(0x18_d9dc, 1); pushw(ds);                                /* push ds */
        //    ii(0x18_d9dd, 1); popw(es);                                 /* pop es */
        //    ii(0x18_d9de, 1); pushw(bx);                                /* push bx */
        //    ii(0x18_d9df, 1); popw(ds);                                 /* pop ds */
        //    ii(0x18_d9e0, 3); add(cx, 0x1);                             /* add cx, 0x1 */
        //    ii(0x18_d9e3, 2); rcr(cx, 0x1);                             /* rcr cx, 1 */
        //    ii(0x18_d9e5, 1); cld();                                    /* cld */
        //    ii(0x18_d9e6, 2); rep_a16(() => movsw_a16());               /* rep movsw */
        //    ii(0x18_d9e8, 2); if(jaew(0x18_d9eb, 0x1)) goto l_0x18_d9eb; /* jae 0xd9eb */
        //    ii(0x18_d9ea, 1); movsb_a16();                              /* movsb */
        l_0x18_d9eb:
            ii(0x18_d9eb, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_d9ed, 3); cmp(bx, memw_a16[ss, bp + 0x8]);          /* cmp bx, [bp+0x8] */
            ii(0x18_d9f0, 2); if(jnzw(0x18_da01, 0xf)) goto l_0x18_da01; /* jnz 0xda01 */
            ii(0x18_d9f2, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x18_d9f5, 3); mov(dx, memw_a16[ss, bp + 0x4]);          /* mov dx, [bp+0x4] */
            ii(0x18_d9f8, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x18_d9fb, 1); pushw(cs);                                /* push cs */
            ii(0x18_d9fc, 3); callw(0x18_a3b9, -0x3646);                /* call 0xa3b9 */
            ii(0x18_d9ff, 1); pushw(ss);                                /* push ss */
            ii(0x18_da00, 1); popw(ss);                                 /* pop ss */
        l_0x18_da01:
            ii(0x18_da01, 1); popw(ds);                                 /* pop ds */
            ii(0x18_da02, 1); popw(di);                                 /* pop di */
            ii(0x18_da03, 1); popw(si);                                 /* pop si */
            ii(0x18_da04, 1); popw(bp);                                 /* pop bp */
            ii(0x18_da05, 1); retw(); return;                           /* ret */
        //  ii(0x18_da06, 142); Недостижимый (и не декодированный) код.
        //    ii(0x18_da94, 1); pushw(bp);                                /* push bp */
        //    ii(0x18_da95, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x18_da97, 2); pushw(0x8);                               /* push 0x8 */
        //    ii(0x18_da99, 1); popw(ds);                                 /* pop ds */
        //    ii(0x18_da9a, 1); pushfw();                                 /* pushfw */
        //    ii(0x18_da9b, 1); cli();                                    /* cli */
        //    ii(0x18_da9c, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
        //    ii(0x18_da9f, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
        //    ii(0x18_daa2, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
        //    ii(0x18_daa5, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
        //    ii(0x18_daa7, 3); mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
        //    ii(0x18_daaa, 3); mov(memb_a16[ds, bx + 0x5], al);          /* mov [bx+0x5], al */
        //    ii(0x18_daad, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        //    ii(0x18_dab0, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
        //    ii(0x18_dab3, 3); mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x18_dab6:
            ii(0x18_dab6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dab8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_daba, 2); if(loopw_a16(0x18_dab6, -0x6)) goto l_0x18_dab6; /* loop 0xdab6 */
            ii(0x18_dabc, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x18_dabf, 3); mov(memb_a16[ds, bx + 0x4], dl);          /* mov [bx+0x4], dl */
            ii(0x18_dac2, 3); mov(memb_a16[ds, bx + 0x7], dh);          /* mov [bx+0x7], dh */
            ii(0x18_dac5, 1); popw(dx);                                 /* pop dx */
            ii(0x18_dac6, 1); popw(bp);                                 /* pop bp */
            ii(0x18_dac7, 1); popw(ax);                                 /* pop ax */
            ii(0x18_dac8, 2); mov(cx, ss);                              /* mov cx, ss */
            ii(0x18_daca, 2); mov(ss, cx);                              /* mov ss, cx */
            ii(0x18_dacc, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_dace, 1); popw(ds);                                 /* pop ds */
            ii(0x18_dacf, 1); pushw(dx);                                /* push dx */
            ii(0x18_dad0, 1); popfw();                                  /* popfw */
            ii(0x18_dad1, 2); if(jmpw_abs(ax)) return;                  /* jmp ax */
            ii(0x18_dad3, 1); pushw(bp);                                /* push bp */
            ii(0x18_dad4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_dad6, 1); pushw(es);                                /* push es */
            ii(0x18_dad7, 1); pushw(di);                                /* push di */
            ii(0x18_dad8, 3); mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
            ii(0x18_dadb, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x18_dade, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x18_dae1, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x18_dae4, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_dae6, 1); cld();                                    /* cld */
            ii(0x18_dae7, 3); sub(cx, 0x1);                             /* sub cx, 0x1 */
            ii(0x18_daea, 1); inc(cx);                                  /* inc cx */
            ii(0x18_daeb, 2); rcr(cx, 0x1);                             /* rcr cx, 1 */
            ii(0x18_daed, 2); rep_a16(() => stosw_a16());               /* rep stosw */
            ii(0x18_daef, 2); rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x18_daf1, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x18_daf3, 1); popw(di);                                 /* pop di */
            ii(0x18_daf4, 1); popw(es);                                 /* pop es */
            ii(0x18_daf5, 1); popw(bp);                                 /* pop bp */
            ii(0x18_daf6, 1); retw(); return;                           /* ret */
        }
    }
}
