using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b73b316-5f0d-4118-ab2c-948331914657")]
        public void Method_0019_89cb()
        {
            ii(0x19_89cb, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x19_89cf, 1); pushw(di);                                /* push di */
            ii(0x19_89d0, 1); pushw(si);                                /* push si */
            ii(0x19_89d1, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_89d4, 3); jmpw(0x19_8a10, 0x39); goto l_0x19_8a10;  /* jmp 0x8a10 */
        l_0x19_89d7:
            ii(0x19_89d7, 5); mov(memw_a16[ss, bp - 0xa], 0x9);         /* mov word [bp-0xa], 0x9 */
            ii(0x19_89dc, 5); mov(memw_a16[ss, bp - 0xe], 0x1824);      /* mov word [bp-0xe], 0x1824 */
            ii(0x19_89e1, 3); mov(memw_a16[ss, bp - 0xc], ds);          /* mov [bp-0xc], ds */
            ii(0x19_89e4, 3); jmpw(0x19_8a2f, 0x48); goto l_0x19_8a2f;  /* jmp 0x8a2f */
        l_0x19_89e7:
            ii(0x19_89e7, 5); mov(memw_a16[ss, bp - 0xa], 0x5);         /* mov word [bp-0xa], 0x5 */
            ii(0x19_89ec, 5); mov(memw_a16[ss, bp - 0xe], 0x182e);      /* mov word [bp-0xe], 0x182e */
            ii(0x19_89f1, 3); mov(memw_a16[ss, bp - 0xc], ds);          /* mov [bp-0xc], ds */
            ii(0x19_89f4, 3); jmpw(0x19_8a2f, 0x38); goto l_0x19_8a2f;  /* jmp 0x8a2f */
        l_0x19_89f7:
            ii(0x19_89f7, 5); mov(memw_a16[ss, bp - 0xa], 0x5);         /* mov word [bp-0xa], 0x5 */
            ii(0x19_89fc, 5); mov(memw_a16[ss, bp - 0xe], 0x1834);      /* mov word [bp-0xe], 0x1834 */
            ii(0x19_8a01, 3); mov(memw_a16[ss, bp - 0xc], ds);          /* mov [bp-0xc], ds */
            ii(0x19_8a04, 3); jmpw(0x19_8a2f, 0x28); goto l_0x19_8a2f;  /* jmp 0x8a2f */
        l_0x19_8a07:
            ii(0x19_8a07, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8a0a, 3); jmpw(0x19_8a86, 0x79); goto l_0x19_8a86;  /* jmp 0x8a86 */
        //    ii(0x19_8a0d, 3); jmpw(0x19_8a2f, 0x1f); goto l_0x19_8a2f;  /* jmp 0x8a2f */
        l_0x19_8a10:
            ii(0x19_8a10, 3); sub(ax, 0x34);                            /* sub ax, 0x34 */
            ii(0x19_8a13, 2); if(jgew(0x19_8a18, 0x3)) goto l_0x19_8a18; /* jge 0x8a18 */
            ii(0x19_8a15, 3); jmpw(0x19_8a07, -0x11); goto l_0x19_8a07; /* jmp 0x8a07 */
        l_0x19_8a18:
            ii(0x19_8a18, 3); sub(ax, 0x7);                             /* sub ax, 0x7 */
            ii(0x19_8a1b, 2); if(jgw(0x19_8a20, 0x3)) goto l_0x19_8a20; /* jg 0x8a20 */
            ii(0x19_8a1d, 3); jmpw(0x19_89d7, -0x49); goto l_0x19_89d7; /* jmp 0x89d7 */
        l_0x19_8a20:
            ii(0x19_8a20, 1); dec(ax);                                  /* dec ax */
            ii(0x19_8a21, 2); if(jnzw(0x19_8a26, 0x3)) goto l_0x19_8a26; /* jnz 0x8a26 */
            ii(0x19_8a23, 3); jmpw(0x19_89e7, -0x3f); goto l_0x19_89e7; /* jmp 0x89e7 */
        l_0x19_8a26:
            ii(0x19_8a26, 1); dec(ax);                                  /* dec ax */
            ii(0x19_8a27, 2); if(jnzw(0x19_8a2c, 0x3)) goto l_0x19_8a2c; /* jnz 0x8a2c */
            ii(0x19_8a29, 3); jmpw(0x19_89f7, -0x35); goto l_0x19_89f7; /* jmp 0x89f7 */
        l_0x19_8a2c:
            ii(0x19_8a2c, 3); jmpw(0x19_8a07, -0x28); goto l_0x19_8a07; /* jmp 0x8a07 */
        l_0x19_8a2f:
            ii(0x19_8a2f, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8a32, 4); mov(ax, memw_a16[es, bx + 0x36]);         /* mov ax, [es:bx+0x36] */
            ii(0x19_8a36, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_8a38, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_8a3b, 4); or(cx, memw_a16[es, bx + 0x32]);          /* or cx, [es:bx+0x32] */
            ii(0x19_8a3f, 3); or(ax, 0);                                /* or ax, 0x0 */
            ii(0x19_8a42, 3); sub(cx, memw_a16[ss, bp - 0xa]);          /* sub cx, [bp-0xa] */
            ii(0x19_8a45, 1); inc(cx);                                  /* inc cx */
            ii(0x19_8a46, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x19_8a49, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_8a4c, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x19_8a4f, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x19_8a52, 3); add(ax, memw_a16[ss, bp - 0xa]);          /* add ax, [bp-0xa] */
            ii(0x19_8a55, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_8a58, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x19_8a5b:
            ii(0x19_8a5b, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_8a5e, 3); cmp(memw_a16[ss, bp - 0xe], ax);          /* cmp [bp-0xe], ax */
            ii(0x19_8a61, 2); if(jbw(0x19_8a66, 0x3)) goto l_0x19_8a66; /* jb 0x8a66 */
            ii(0x19_8a63, 3); jmpw(0x19_8a86, 0x20); goto l_0x19_8a86;  /* jmp 0x8a86 */
        l_0x19_8a66:
            ii(0x19_8a66, 3); les(bx, ss, bp - 0xe);                    /* les bx, [bp-0xe] */
            ii(0x19_8a69, 3); inc(memw_a16[ss, bp - 0xe]);              /* inc word [bp-0xe] */
            ii(0x19_8a6c, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_8a6f, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_8a72, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x19_8a75, 3); cmp(memb_a16[es, bx], al);                /* cmp [es:bx], al */
            ii(0x19_8a78, 2); if(jnzw(0x19_8a7d, 0x3)) goto l_0x19_8a7d; /* jnz 0x8a7d */
            ii(0x19_8a7a, 3); jmpw(0x19_8a83, 0x6); goto l_0x19_8a83;   /* jmp 0x8a83 */
        l_0x19_8a7d:
            ii(0x19_8a7d, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8a80, 3); jmpw(0x19_8a86, 0x3); goto l_0x19_8a86;   /* jmp 0x8a86 */
        l_0x19_8a83:
            ii(0x19_8a83, 3); jmpw(0x19_8a5b, -0x2b); goto l_0x19_8a5b; /* jmp 0x8a5b */
        l_0x19_8a86:
            ii(0x19_8a86, 1); popw(si);                                 /* pop si */
            ii(0x19_8a87, 1); popw(di);                                 /* pop di */
            ii(0x19_8a88, 1); leavew();                                 /* leave */
            ii(0x19_8a89, 1); retfw(); return;                          /* retf */
        }
    }
}
