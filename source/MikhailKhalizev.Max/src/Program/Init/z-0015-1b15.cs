using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81591826-1a0f-4d0a-a839-a9eefe60031b")]
        public void Method_0015_1b15()
        {
            ii(0x15_1b15, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x15_1b19, 1); pushw(ds);                                /* push ds */
            ii(0x15_1b1a, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_1b1d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_1b1f, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x15_1b24, 5); mov(memw_a16[ss, bp - 0x4], 0x392c);      /* mov word [bp-0x4], 0x392c */
            ii(0x15_1b29, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
            ii(0x15_1b2c, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_1b2f, 1); inc(ax);                                  /* inc ax */
            ii(0x15_1b30, 2); if(jzw(0x15_1b6f, 0x3d)) goto l_0x15_1b6f; /* jz 0x1b6f */
            ii(0x15_1b32, 1); dec(ax);                                  /* dec ax */
            ii(0x15_1b33, 2); if(jzw(0x15_1b6f, 0x3a)) goto l_0x15_1b6f; /* jz 0x1b6f */
            ii(0x15_1b35, 1); dec(ax);                                  /* dec ax */
            ii(0x15_1b36, 2); if(jzw(0x15_1b4b, 0x13)) goto l_0x15_1b4b; /* jz 0x1b4b */
            ii(0x15_1b38, 1); dec(ax);                                  /* dec ax */
            ii(0x15_1b39, 2); if(jnzw(0x15_1b3e, 0x3)) goto l_0x15_1b3e; /* jnz 0x1b3e */
            ii(0x15_1b3b, 3); jmpw(0x15_1bd6, 0x98); goto l_0x15_1bd6;  /* jmp 0x1bd6 */
        l_0x15_1b3e:
            ii(0x15_1b3e, 1); dec(ax);                                  /* dec ax */
            ii(0x15_1b3f, 2); if(jnzw(0x15_1b44, 0x3)) goto l_0x15_1b44; /* jnz 0x1b44 */
            ii(0x15_1b41, 3); jmpw(0x15_1bee, 0xaa); goto l_0x15_1bee;  /* jmp 0x1bee */
        l_0x15_1b44:
            ii(0x15_1b44, 5); mov(memw_a16[ss, bp + 0xa], 0);           /* mov word [bp+0xa], 0x0 */
            ii(0x15_1b49, 2); jmpw(0x15_1b6f, 0x24); goto l_0x15_1b6f;  /* jmp 0x1b6f */
        l_0x15_1b4b:
            ii(0x15_1b4b, 4); cmp(memw_a16[ss, bp + 0xc], 0);           /* cmp word [bp+0xc], 0x0 */
            ii(0x15_1b4f, 2); if(jzw(0x15_1b6f, 0x1e)) goto l_0x15_1b6f; /* jz 0x1b6f */
            ii(0x15_1b51, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_1b54, 4); pushw(memw_a16[ds, 0x3a72]);              /* push word [0x3a72] */
            ii(0x15_1b58, 4); pushw(memw_a16[ds, 0x3a70]);              /* push word [0x3a70] */
            ii(0x15_1b5c, 1); pushw(ds);                                /* push ds */
            ii(0x15_1b5d, 3); pushw(0x3a90);                            /* push 0x3a90 */
        l_0x15_1b60:
            ii(0x15_1b60, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_1b63, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_1b66, 3); callw(0x15_1e1c, 0x2b3);                  /* call 0x1e1c */
            ii(0x15_1b69, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x15_1b6c, 3); add(memw_a16[ss, bp - 0x4], ax);          /* add [bp-0x4], ax */
        l_0x15_1b6f:
            ii(0x15_1b6f, 3); les(bx, ss, bp + 0x12);                   /* les bx, [bp+0x12] */
            ii(0x15_1b72, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_1b76, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_1b79, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_1b7c, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_1b7f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_1b82, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_1b85, 1); pushw(cs);                                /* push cs */
            ii(0x15_1b86, 3); callw(0x15_1e37, 0x2ae);                  /* call 0x1e37 */
            ii(0x15_1b89, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_1b8c, 3); mov(ax, memw_a16[ds, 0x3a76]);            /* mov ax, [0x3a76] */
            ii(0x15_1b8f, 4); or(ax, memw_a16[ds, 0x3a74]);             /* or ax, [0x3a74] */
            ii(0x15_1b93, 2); if(jzw(0x15_1bca, 0x35)) goto l_0x15_1bca; /* jz 0x1bca */
            ii(0x15_1b95, 3); les(bx, ss, bp + 0x12);                   /* les bx, [bp+0x12] */
            ii(0x15_1b98, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_1b9c, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_1b9f, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_1ba2, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_1ba5, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_1ba8, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_1bab, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_1bae, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_1bb1, 4); pushw(memw_a16[ds, 0x3a72]);              /* push word [0x3a72] */
            ii(0x15_1bb5, 4); pushw(memw_a16[ds, 0x3a70]);              /* push word [0x3a70] */
            ii(0x15_1bb9, 3); pushw(0x100);                             /* push 0x100 */
            ii(0x15_1bbc, 1); pushw(ds);                                /* push ds */
            ii(0x15_1bbd, 3); pushw(0x392c);                            /* push 0x392c */
            ii(0x15_1bc0, 4); callw_a16_far_ind(ds, 0x3a74);            /* call far word [0x3a74] */
            ii(0x15_1bc4, 3); add(sp, 0x1a);                            /* add sp, 0x1a */
            ii(0x15_1bc7, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
        l_0x15_1bca:
            ii(0x15_1bca, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x15_1bce, 2); if(jzw(0x15_1c09, 0x39)) goto l_0x15_1c09; /* jz 0x1c09 */
            ii(0x15_1bd0, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_1bd3, 1); popw(ds);                                 /* pop ds */
            ii(0x15_1bd4, 1); leavew();                                 /* leave */
            ii(0x15_1bd5, 1); retfw(); return;                          /* retf */
        l_0x15_1bd6:
            ii(0x15_1bd6, 4); cmp(memw_a16[ss, bp + 0xc], 0);           /* cmp word [bp+0xc], 0x0 */
            ii(0x15_1bda, 2); if(jzw(0x15_1b6f, -0x6d)) goto l_0x15_1b6f; /* jz 0x1b6f */
            ii(0x15_1bdc, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_1bdf, 4); pushw(memw_a16[ds, 0x3a72]);              /* push word [0x3a72] */
            ii(0x15_1be3, 4); pushw(memw_a16[ds, 0x3a70]);              /* push word [0x3a70] */
            ii(0x15_1be7, 1); pushw(ds);                                /* push ds */
            ii(0x15_1be8, 3); pushw(0x3aa2);                            /* push 0x3aa2 */
            ii(0x15_1beb, 3); jmpw(0x15_1b60, -0x8e); goto l_0x15_1b60; /* jmp 0x1b60 */
        l_0x15_1bee:
            ii(0x15_1bee, 4); cmp(memw_a16[ss, bp + 0xc], 0);           /* cmp word [bp+0xc], 0x0 */
            ii(0x15_1bf2, 2); if(jnzw(0x15_1bf7, 0x3)) goto l_0x15_1bf7; /* jnz 0x1bf7 */
            ii(0x15_1bf4, 3); jmpw(0x15_1b6f, -0x88); goto l_0x15_1b6f; /* jmp 0x1b6f */
        l_0x15_1bf7:
            ii(0x15_1bf7, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_1bfa, 4); pushw(memw_a16[ds, 0x3a72]);              /* push word [0x3a72] */
            ii(0x15_1bfe, 4); pushw(memw_a16[ds, 0x3a70]);              /* push word [0x3a70] */
            ii(0x15_1c02, 1); pushw(ds);                                /* push ds */
            ii(0x15_1c03, 3); pushw(0x3ab2);                            /* push 0x3ab2 */
            ii(0x15_1c06, 3); jmpw(0x15_1b60, -0xa9); goto l_0x15_1b60; /* jmp 0x1b60 */
        l_0x15_1c09:
            ii(0x15_1c09, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_1c0c, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x15_1c0e, 4); mov(bx, memw_a16[ds, bx + 0x3a3a]);       /* mov bx, [bx+0x3a3a] */
            ii(0x15_1c12, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x15_1c14, 4); mov(ax, memw_a16[ds, bx + 0x3a2c]);       /* mov ax, [bx+0x3a2c] */
            ii(0x15_1c18, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_1c1b, 5); mov(memw_a16[ss, bp - 0xa], 0x392c);      /* mov word [bp-0xa], 0x392c */
            ii(0x15_1c20, 2); jmpw(0x15_1c2c, 0xa); goto l_0x15_1c2c;   /* jmp 0x1c2c */
        l_0x15_1c22:
            ii(0x15_1c22, 2); mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x15_1c24, 1); pushw(ax);                                /* push ax */
            ii(0x15_1c25, 3); callw_abs(memw_a16[ss, bp - 0x8]);        /* call word [bp-0x8] */
            ii(0x15_1c28, 1); popw(bx);                                 /* pop bx */
            ii(0x15_1c29, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x15_1c2c:
            ii(0x15_1c2c, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x15_1c2f, 3); cmp(memb_a16[ds, bx], 0);                 /* cmp byte [bx], 0x0 */
            ii(0x15_1c32, 2); if(jnzw(0x15_1c22, -0x12)) goto l_0x15_1c22; /* jnz 0x1c22 */
            ii(0x15_1c34, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x15_1c36, 3); sub(ax, 0x392c);                          /* sub ax, 0x392c */
            ii(0x15_1c39, 1); popw(ds);                                 /* pop ds */
            ii(0x15_1c3a, 1); leavew();                                 /* leave */
            ii(0x15_1c3b, 1); retfw(); return;                          /* retf */
        }
    }
}
