using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2188463e-3c71-448f-8aad-df0f2ea816b7")]
        public void Method_0014_d4de()
        {
            ii(0x14_d4de, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x14_d4e2, 1); pushw(di);                                /* push di */
            ii(0x14_d4e3, 1); pushw(si);                                /* push si */
            ii(0x14_d4e4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_d4e7, 3); dec(memw_a16[ss, bp + 0x6]);              /* dec word [bp+0x6] */
            ii(0x14_d4ea, 3); cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x14_d4ed, 2); if(jnzw(0x14_d4f2, 0x3)) goto l_0x14_d4f2; /* jnz 0xd4f2 */
            ii(0x14_d4ef, 3); jmpw(0x14_d581, 0x8f); goto l_0x14_d581;  /* jmp 0xd581 */
        l_0x14_d4f2:
            ii(0x14_d4f2, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x14_d4f5, 1); pushw(ax);                                /* push ax */
            ii(0x14_d4f6, 4); mov(cx, memw_a16[ds, 0xc38]);             /* mov cx, [0xc38] */
            ii(0x14_d4fa, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x14_d4fd, 1); pushw(cx);                                /* push cx */
            ii(0x14_d4fe, 3); callw(0x14_dc8e, 0x78d);                  /* call 0xdc8e */
            ii(0x14_d501, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d502, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d503, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_d506, 3); shr(ax, 0xc);                             /* shr ax, 0xc */
            ii(0x14_d509, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x14_d50c, 3); shl(cx, 0x4);                             /* shl cx, 0x4 */
            ii(0x14_d50f, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x14_d512, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x14_d515, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x14_d518, 1); pushw(ax);                                /* push ax */
            ii(0x14_d519, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_d51c, 3); callw(0x14_dc28, 0x709);                  /* call 0xdc28 */
            ii(0x14_d51f, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d520, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d521, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x14_d524, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x14_d526, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_d528, 3); mov(memw_a16[ss, bp - 0x8], bx);          /* mov [bp-0x8], bx */
            ii(0x14_d52b, 3); mov(memw_a16[ss, bp - 0x6], es);          /* mov [bp-0x6], es */
            ii(0x14_d52e, 4); cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x14_d532, 2); if(jzw(0x14_d53a, 0x6)) goto l_0x14_d53a; /* jz 0xd53a */
            ii(0x14_d534, 4); cmp(memb_a16[es, bx], 0x5a);              /* cmp byte [es:bx], 0x5a */
            ii(0x14_d538, 2); if(jnzw(0x14_d581, 0x47)) goto l_0x14_d581; /* jnz 0xd581 */
        l_0x14_d53a:
            ii(0x14_d53a, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x14_d53d, 3); sub(ax, memw_a16[ss, bp + 0x6]);          /* sub ax, [bp+0x6] */
            ii(0x14_d540, 1); dec(ax);                                  /* dec ax */
            ii(0x14_d541, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_d544, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x14_d547, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x14_d54a, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x14_d54c, 3); mov(cx, memw_a16[ss, bp - 0x8]);          /* mov cx, [bp-0x8] */
            ii(0x14_d54f, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x14_d551, 1); pushw(cx);                                /* push cx */
            ii(0x14_d552, 1); pushw(ds);                                /* push ds */
            ii(0x14_d553, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x14_d555, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x14_d557, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x14_d559, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x14_d55c, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_d55e, 1); popw(ds);                                 /* pop ds */
            ii(0x14_d55f, 1); popw(cx);                                 /* pop cx */
            ii(0x14_d560, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x14_d562, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x14_d564, 4); mov(memb_a16[es, si], 0x4d);              /* mov byte [es:si], 0x4d */
            ii(0x14_d568, 3); mov(di, memw_a16[ss, bp - 0x4]);          /* mov di, [bp-0x4] */
            ii(0x14_d56b, 1); dec(di);                                  /* dec di */
            ii(0x14_d56c, 4); mov(memw_a16[es, si + 0x3], di);          /* mov [es:si+0x3], di */
            ii(0x14_d570, 6); mov(memw_a16[es, si + 0x1], 0);           /* mov word [es:si+0x1], 0x0 */
            ii(0x14_d576, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x14_d578, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x14_d57a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x14_d57d, 4); sub(memw_a16[es, si + 0x3], ax);          /* sub [es:si+0x3], ax */
        l_0x14_d581:
            ii(0x14_d581, 1); popw(si);                                 /* pop si */
            ii(0x14_d582, 1); popw(di);                                 /* pop di */
            ii(0x14_d583, 1); leavew();                                 /* leave */
            ii(0x14_d584, 1); retw(); return;                           /* ret */
        }
    }
}
