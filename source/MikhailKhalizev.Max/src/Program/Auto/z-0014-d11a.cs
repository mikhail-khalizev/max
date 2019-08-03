using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ddcddfda-c3af-4d6d-bfea-bbd3d3be6f5a")]
        public void Method_0014_d11a()
        {
            ii(0x14_d11a, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x14_d11e, 1); pushw(di);                                /* push di */
            ii(0x14_d11f, 1); pushw(si);                                /* push si */
            ii(0x14_d120, 5); cmp(memw_a16[ss, bp + 0x4], 0x80);        /* cmp word [bp+0x4], 0x80 */
            ii(0x14_d125, 2); if(jbw(0x14_d13d, 0x16)) goto l_0x14_d13d; /* jb 0xd13d */
            ii(0x14_d127, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x14_d12a, 1); pushw(ax);                                /* push ax */
            ii(0x14_d12b, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x14_d12e, 3); callw(0x14_dc8e, 0xb5d);                  /* call 0xdc8e */
            ii(0x14_d131, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d132, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d133, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_d135, 2); if(jzw(0x14_d13d, 0x6)) goto l_0x14_d13d; /* jz 0xd13d */
            ii(0x14_d137, 4); test(memb_a16[ss, bp - 0xe], 0x10);       /* test byte [bp-0xe], 0x10 */
            ii(0x14_d13b, 2); if(jnzw(0x14_d140, 0x3)) goto l_0x14_d140; /* jnz 0xd140 */
        l_0x14_d13d:
            ii(0x14_d13d, 3); jmpw(0x14_d1c5, 0x85); goto l_0x14_d1c5;  /* jmp 0xd1c5 */
        l_0x14_d140:
            ii(0x14_d140, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x14_d143, 3); mov(memw_a16[ds, 0x38], ax);              /* mov [0x38], ax */
            ii(0x14_d146, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x14_d148, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x14_d14b, 4); les(di, ds, 0xaa0);                       /* les di, [0xaa0] */
            ii(0x14_d14f, 4); test(memb_a16[es, bx + di], 0x1);         /* test byte [es:bx+di], 0x1 */
            ii(0x14_d153, 2); if(jzw(0x14_d1b3, 0x5e)) goto l_0x14_d1b3; /* jz 0xd1b3 */
            ii(0x14_d155, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_d15a, 2); if(jzw(0x14_d1b3, 0x57)) goto l_0x14_d1b3; /* jz 0xd1b3 */
            ii(0x14_d15c, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x14_d15f, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x14_d162, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x14_d165, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x14_d168, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x14_d16d, 5); mov(memw_a16[ss, bp - 0x6], 0x8);         /* mov word [bp-0x6], 0x8 */
            ii(0x14_d172, 3); mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0x14_d175, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x14_d178, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_d17b, 3); mov(si, 0x10);                            /* mov si, 0x10 */
            ii(0x14_d17e, 2); jmpw(0x14_d1ae, 0x2e); goto l_0x14_d1ae;  /* jmp 0xd1ae */
        l_0x14_d180:
            ii(0x14_d180, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x14_d183, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x14_d185, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x14_d188, 3); add(bx, memw_a16[ss, bp - 0x8]);          /* add bx, [bp-0x8] */
            ii(0x14_d18b, 3); mov(es, memw_a16[ss, bp - 0x6]);          /* mov es, [bp-0x6] */
            ii(0x14_d18e, 4); cmp(memw_a16[es, bx + 0x2], ax);          /* cmp [es:bx+0x2], ax */
            ii(0x14_d192, 2); if(jnzw(0x14_d1ad, 0x19)) goto l_0x14_d1ad; /* jnz 0xd1ad */
            ii(0x14_d194, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x14_d198, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x14_d19a, 3); cmp(ax, memw_a16[ss, bp - 0xa]);          /* cmp ax, [bp-0xa] */
            ii(0x14_d19d, 2); if(jnzw(0x14_d1ad, 0xe)) goto l_0x14_d1ad; /* jnz 0xd1ad */
            ii(0x14_d19f, 4); cmp(memb_a16[es, bx + 0x5], ah);          /* cmp [es:bx+0x5], ah */
            ii(0x14_d1a3, 2); if(jzw(0x14_d1ad, 0x8)) goto l_0x14_d1ad; /* jz 0xd1ad */
            ii(0x14_d1a5, 4); les(bx, ds, 0xaa0);                       /* les bx, [0xaa0] */
            ii(0x14_d1a9, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
        l_0x14_d1ad:
            ii(0x14_d1ad, 1); inc(si);                                  /* inc si */
        l_0x14_d1ae:
            ii(0x14_d1ae, 3); cmp(memw_a16[ss, bp - 0x4], si);          /* cmp [bp-0x4], si */
            ii(0x14_d1b1, 2); if(jaw(0x14_d180, -0x33)) goto l_0x14_d180; /* ja 0xd180 */
        l_0x14_d1b3:
            ii(0x14_d1b3, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x14_d1b6, 3); callw(0x14_dd01, 0xb48);                  /* call 0xdd01 */
            ii(0x14_d1b9, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1ba, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x14_d1bc, 3); callw(0x14_a5a9, -0x2c16);                /* call 0xa5a9 */
            ii(0x14_d1bf, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1c0, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x14_d1c3, 2); jmpw(0x14_d1c7, 0x2); goto l_0x14_d1c7;   /* jmp 0xd1c7 */
        l_0x14_d1c5:
            ii(0x14_d1c5, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x14_d1c7:
            ii(0x14_d1c7, 1); popw(si);                                 /* pop si */
            ii(0x14_d1c8, 1); popw(di);                                 /* pop di */
            ii(0x14_d1c9, 1); leavew();                                 /* leave */
            ii(0x14_d1ca, 1); retw(); return;                           /* ret */
        }
    }
}
