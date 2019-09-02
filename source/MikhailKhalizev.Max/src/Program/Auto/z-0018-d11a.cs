using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d11a-b5796cfb")]
        public void Method_0018_d11a()
        {
            ii(0x18_d11a, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x18_d11e, 1); push(di);                                 /* push di */
            ii(0x18_d11f, 1); push(si);                                 /* push si */
            ii(0x18_d120, 5); cmp(memw[ss, bp + 4], 0x80);              /* cmp word [bp+0x4], 0x80 */
            ii(0x18_d125, 2); if(jb(0x18_d13d, 0x16)) goto l_0x18_d13d; /* jb 0xd13d */
            ii(0x18_d127, 3); lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x18_d12a, 1); push(ax);                                 /* push ax */
            ii(0x18_d12b, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x18_d12e, 3); call(0x18_dc8e, 0xb5d);                   /* call 0xdc8e */
            ii(0x18_d131, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d132, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d133, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_d135, 2); if(jz(0x18_d13d, 6)) goto l_0x18_d13d;    /* jz 0xd13d */
            ii(0x18_d137, 4); test(memb[ss, bp - 0xe], 0x10);           /* test byte [bp-0xe], 0x10 */
            ii(0x18_d13b, 2); if(jnz(0x18_d140, 3)) goto l_0x18_d140;   /* jnz 0xd140 */
        l_0x18_d13d:
            ii(0x18_d13d, 3); jmp(0x18_d1c5, 0x85); goto l_0x18_d1c5;   /* jmp 0xd1c5 */
        l_0x18_d140:
            ii(0x18_d140, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x18_d143, 3); mov(memw[ds, 0x38], ax);                  /* mov [0x38], ax */
            ii(0x18_d146, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_d148, 3); shr(bx, 3);                               /* shr bx, 0x3 */
            ii(0x18_d14b, 4); les(di, memw[ds, 0xaa0]);                 /* les di, [0xaa0] */
            ii(0x18_d14f, 4); test(memb[es, bx + di], 1);               /* test byte [es:bx+di], 0x1 */
            ii(0x18_d153, 2); if(jz(0x18_d1b3, 0x5e)) goto l_0x18_d1b3; /* jz 0xd1b3 */
            ii(0x18_d155, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_d15a, 2); if(jz(0x18_d1b3, 0x57)) goto l_0x18_d1b3; /* jz 0xd1b3 */
            ii(0x18_d15c, 3); mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x18_d15f, 3); mov(dx, memw[ss, bp - 0x14]);             /* mov dx, [bp-0x14] */
            ii(0x18_d162, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x18_d165, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x18_d168, 5); mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x18_d16d, 5); mov(memw[ss, bp - 6], 8);                 /* mov word [bp-0x6], 0x8 */
            ii(0x18_d172, 3); mov(ax, memw[ds, 0x97c]);                 /* mov ax, [0x97c] */
            ii(0x18_d175, 3); shr(ax, 3);                               /* shr ax, 0x3 */
            ii(0x18_d178, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x18_d17b, 3); mov(si, 0x10);                            /* mov si, 0x10 */
            ii(0x18_d17e, 2); jmp(0x18_d1ae, 0x2e); goto l_0x18_d1ae;   /* jmp 0xd1ae */
        l_0x18_d180:
            ii(0x18_d180, 3); mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x18_d183, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x18_d185, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x18_d188, 3); add(bx, memw[ss, bp - 8]);                /* add bx, [bp-0x8] */
            ii(0x18_d18b, 3); mov(es, memw[ss, bp - 6]);                /* mov es, [bp-0x6] */
            ii(0x18_d18e, 4); cmp(memw[es, bx + 2], ax);                /* cmp [es:bx+0x2], ax */
            ii(0x18_d192, 2); if(jnz(0x18_d1ad, 0x19)) goto l_0x18_d1ad; /* jnz 0xd1ad */
            ii(0x18_d194, 4); mov(al, memb[es, bx + 4]);                /* mov al, [es:bx+0x4] */
            ii(0x18_d198, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x18_d19a, 3); cmp(ax, memw[ss, bp - 0xa]);              /* cmp ax, [bp-0xa] */
            ii(0x18_d19d, 2); if(jnz(0x18_d1ad, 0xe)) goto l_0x18_d1ad; /* jnz 0xd1ad */
            ii(0x18_d19f, 4); cmp(memb[es, bx + 5], ah);                /* cmp [es:bx+0x5], ah */
            ii(0x18_d1a3, 2); if(jz(0x18_d1ad, 8)) goto l_0x18_d1ad;    /* jz 0xd1ad */
            ii(0x18_d1a5, 4); les(bx, memw[ds, 0xaa0]);                 /* les bx, [0xaa0] */
            ii(0x18_d1a9, 4); or(memb[es, bx + si], 1);                 /* or byte [es:bx+si], 0x1 */
        l_0x18_d1ad:
            ii(0x18_d1ad, 1); inc(si);                                  /* inc si */
        l_0x18_d1ae:
            ii(0x18_d1ae, 3); cmp(memw[ss, bp - 4], si);                /* cmp [bp-0x4], si */
            ii(0x18_d1b1, 2); if(ja(0x18_d180, -0x33)) goto l_0x18_d180; /* ja 0xd180 */
        l_0x18_d1b3:
            ii(0x18_d1b3, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x18_d1b6, 3); call(0x18_dd01, 0xb48);                   /* call 0xdd01 */
            ii(0x18_d1b9, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1ba, 2); push(1);                                  /* push 0x1 */
            ii(0x18_d1bc, 3); call(0x18_a5a9, -0x2c16);                 /* call 0xa5a9 */
            ii(0x18_d1bf, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1c0, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x18_d1c3, 2); jmp(0x18_d1c7, 2); goto l_0x18_d1c7;      /* jmp 0xd1c7 */
        l_0x18_d1c5:
            ii(0x18_d1c5, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x18_d1c7:
            ii(0x18_d1c7, 1); pop(si);                                  /* pop si */
            ii(0x18_d1c8, 1); pop(di);                                  /* pop di */
            ii(0x18_d1c9, 1); leave();                                  /* leave */
            ii(0x18_d1ca, 1); ret();                                    /* ret */
        }
    }
}
