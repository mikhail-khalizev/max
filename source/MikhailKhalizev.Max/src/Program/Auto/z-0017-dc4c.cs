using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07dfe0f3-db9f-4793-8189-22a036223177")]
        public void Method_0017_dc4c()
        {
            ii(0x17_dc4c, 1); pushw(bp);                                /* push bp */
            ii(0x17_dc4d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dc4f, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x17_dc52, 1); pushw(si);                                /* push si */
            ii(0x17_dc53, 1); pushw(di);                                /* push di */
            ii(0x17_dc54, 2); xor(dl, dl);                              /* xor dl, dl */
            ii(0x17_dc56, 3); mov(memb_a16[ss, bp - 0x1], dl);          /* mov [bp-0x1], dl */
            ii(0x17_dc59, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
        l_0x17_dc5c:
            ii(0x17_dc5c, 1); lodsb_a16();                              /* lodsb */
            ii(0x17_dc5d, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x17_dc5f, 2); if(jzw(0x17_dc5c, -0x5)) goto l_0x17_dc5c; /* jz 0xdc5c */
            ii(0x17_dc61, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x17_dc63, 2); if(jaw(0x17_dc6b, 0x6)) goto l_0x17_dc6b; /* ja 0xdc6b */
            ii(0x17_dc65, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x17_dc67, 2); if(jbw(0x17_dc6b, 0x2)) goto l_0x17_dc6b; /* jb 0xdc6b */
            ii(0x17_dc69, 2); jmpw(0x17_dc5c, -0xf); goto l_0x17_dc5c;  /* jmp 0xdc5c */
        l_0x17_dc6b:
            ii(0x17_dc6b, 2); cmp(al, 0x2b);                            /* cmp al, 0x2b */
            ii(0x17_dc6d, 2); if(jzw(0x17_dc77, 0x8)) goto l_0x17_dc77; /* jz 0xdc77 */
            ii(0x17_dc6f, 2); cmp(al, 0x2d);                            /* cmp al, 0x2d */
            ii(0x17_dc71, 2); if(jnzw(0x17_dc78, 0x5)) goto l_0x17_dc78; /* jnz 0xdc78 */
            ii(0x17_dc73, 4); or(memb_a16[ss, bp - 0x1], 0x2);          /* or byte [bp-0x1], 0x2 */
        l_0x17_dc77:
            ii(0x17_dc77, 1); lodsb_a16();                              /* lodsb */
        l_0x17_dc78:
            ii(0x17_dc78, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x17_dc7b, 2); if(jcxzw(0x17_dc8a, 0xd)) goto l_0x17_dc8a; /* jcxz 0xdc8a */
            ii(0x17_dc7d, 3); cmp(cx, 0x1);                             /* cmp cx, 0x1 */
            ii(0x17_dc80, 2); if(jzw(0x17_dc87, 0x5)) goto l_0x17_dc87; /* jz 0xdc87 */
            ii(0x17_dc82, 3); cmp(cx, 0x24);                            /* cmp cx, 0x24 */
            ii(0x17_dc85, 2); if(jbew(0x17_dca3, 0x1c)) goto l_0x17_dca3; /* jbe 0xdca3 */
        l_0x17_dc87:
            ii(0x17_dc87, 3); jmpw(0x17_dd15, 0x8b); goto l_0x17_dd15;  /* jmp 0xdd15 */
        l_0x17_dc8a:
            ii(0x17_dc8a, 3); mov(cx, 0xa);                             /* mov cx, 0xa */
            ii(0x17_dc8d, 2); cmp(al, 0x30);                            /* cmp al, 0x30 */
            ii(0x17_dc8f, 2); if(jnzw(0x17_dca3, 0x12)) goto l_0x17_dca3; /* jnz 0xdca3 */
            ii(0x17_dc91, 3); cmp(memb_a16[ds, si], 0x78);              /* cmp byte [si], 0x78 */
            ii(0x17_dc94, 2); if(jzw(0x17_dca0, 0xa)) goto l_0x17_dca0; /* jz 0xdca0 */
            ii(0x17_dc96, 3); cmp(memb_a16[ds, si], 0x58);              /* cmp byte [si], 0x58 */
            ii(0x17_dc99, 2); if(jzw(0x17_dca0, 0x5)) goto l_0x17_dca0; /* jz 0xdca0 */
            ii(0x17_dc9b, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x17_dc9e, 2); jmpw(0x17_dca3, 0x3); goto l_0x17_dca3;   /* jmp 0xdca3 */
        l_0x17_dca0:
            ii(0x17_dca0, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
        l_0x17_dca3:
            ii(0x17_dca3, 3); mov(memw_a16[ss, bp + 0xa], cx);          /* mov [bp+0xa], cx */
            ii(0x17_dca6, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x17_dca9, 2); if(jnzw(0x17_dcbb, 0x10)) goto l_0x17_dcbb; /* jnz 0xdcbb */
            ii(0x17_dcab, 2); cmp(al, 0x30);                            /* cmp al, 0x30 */
            ii(0x17_dcad, 2); if(jnzw(0x17_dcbb, 0xc)) goto l_0x17_dcbb; /* jnz 0xdcbb */
            ii(0x17_dcaf, 3); cmp(memb_a16[ds, si], 0x78);              /* cmp byte [si], 0x78 */
            ii(0x17_dcb2, 2); if(jzw(0x17_dcb9, 0x5)) goto l_0x17_dcb9; /* jz 0xdcb9 */
            ii(0x17_dcb4, 3); cmp(memb_a16[ds, si], 0x58);              /* cmp byte [si], 0x58 */
            ii(0x17_dcb7, 2); if(jnzw(0x17_dcbb, 0x2)) goto l_0x17_dcbb; /* jnz 0xdcbb */
        l_0x17_dcb9:
            ii(0x17_dcb9, 1); inc(si);                                  /* inc si */
            ii(0x17_dcba, 1); lodsb_a16();                              /* lodsb */
        l_0x17_dcbb:
            ii(0x17_dcbb, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x17_dcbd, 2); xor(bx, bx);                              /* xor bx, bx */
        l_0x17_dcbf:
            ii(0x17_dcbf, 3); callw(0x17_dd53, 0x91);                   /* call 0xdd53 */
            ii(0x17_dcc2, 2); if(jbw(0x17_dd1e, 0x5a)) goto l_0x17_dd1e; /* jb 0xdd1e */
            ii(0x17_dcc4, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x17_dcc7, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_dcc9, 2); if(jaew(0x17_dd1e, 0x53)) goto l_0x17_dd1e; /* jae 0xdd1e */
            ii(0x17_dccb, 4); or(memb_a16[ss, bp - 0x1], 0x8);          /* or byte [bp-0x1], 0x8 */
            ii(0x17_dccf, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_dcd1, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_dcd3, 2); mul(cx);                                  /* mul cx */
            ii(0x17_dcd5, 2); if(jaew(0x17_dcdb, 0x4)) goto l_0x17_dcdb; /* jae 0xdcdb */
            ii(0x17_dcd7, 4); or(memb_a16[ss, bp - 0x1], 0x4);          /* or byte [bp-0x1], 0x4 */
        l_0x17_dcdb:
            ii(0x17_dcdb, 1); pushw(ax);                                /* push ax */
            ii(0x17_dcdc, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_dcde, 2); mul(cx);                                  /* mul cx */
            ii(0x17_dce0, 1); popw(cx);                                 /* pop cx */
            ii(0x17_dce1, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x17_dce3, 2); if(jaew(0x17_dce9, 0x4)) goto l_0x17_dce9; /* jae 0xdce9 */
            ii(0x17_dce5, 4); or(memb_a16[ss, bp - 0x1], 0x4);          /* or byte [bp-0x1], 0x4 */
        l_0x17_dce9:
            ii(0x17_dce9, 2); add(ax, di);                              /* add ax, di */
            ii(0x17_dceb, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_dcee, 2); if(jaew(0x17_dcf4, 0x4)) goto l_0x17_dcf4; /* jae 0xdcf4 */
            ii(0x17_dcf0, 4); or(memb_a16[ss, bp - 0x1], 0x4);          /* or byte [bp-0x1], 0x4 */
        l_0x17_dcf4:
            ii(0x17_dcf4, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_dcf6, 1); lodsb_a16();                              /* lodsb */
            ii(0x17_dcf7, 2); jmpw(0x17_dcbf, -0x3a); goto l_0x17_dcbf; /* jmp 0xdcbf */
        l_0x17_dcf9:
            ii(0x17_dcf9, 6); mov(memw_a16[ds, 0x1c4e], 0x22);          /* mov word [0x1c4e], 0x22 */
            ii(0x17_dcff, 3); mov(dx, 0x7fff);                          /* mov dx, 0x7fff */
            ii(0x17_dd02, 3); mov(bx, 0xffff);                          /* mov bx, 0xffff */
            ii(0x17_dd05, 4); test(memb_a16[ss, bp - 0x1], 0x1);        /* test byte [bp-0x1], 0x1 */
            ii(0x17_dd09, 2); if(jzw(0x17_dd35, 0x2a)) goto l_0x17_dd35; /* jz 0xdd35 */
            ii(0x17_dd0b, 4); or(dx, 0x8000);                           /* or dx, 0x8000 */
            ii(0x17_dd0f, 4); and(memb_a16[ss, bp - 0x1], -0x3 /* 0xfd */); /* and byte [bp-0x1], 0xfd */
            ii(0x17_dd13, 2); jmpw(0x17_dd35, 0x20); goto l_0x17_dd35;  /* jmp 0xdd35 */
        l_0x17_dd15:
            ii(0x17_dd15, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x17_dd18, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x17_dd1a, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x17_dd1c, 2); jmpw(0x17_dd35, 0x17); goto l_0x17_dd35;  /* jmp 0xdd35 */
        l_0x17_dd1e:
            ii(0x17_dd1e, 1); dec(si);                                  /* dec si */
            ii(0x17_dd1f, 4); test(memb_a16[ss, bp - 0x1], 0x8);        /* test byte [bp-0x1], 0x8 */
            ii(0x17_dd23, 2); if(jzw(0x17_dd15, -0x10)) goto l_0x17_dd15; /* jz 0xdd15 */
            ii(0x17_dd25, 4); test(memb_a16[ss, bp - 0x1], 0x4);        /* test byte [bp-0x1], 0x4 */
            ii(0x17_dd29, 2); if(jnzw(0x17_dcf9, -0x32)) goto l_0x17_dcf9; /* jnz 0xdcf9 */
            ii(0x17_dd2b, 4); test(memb_a16[ss, bp - 0x1], 0x1);        /* test byte [bp-0x1], 0x1 */
            ii(0x17_dd2f, 2); if(jnzw(0x17_dd35, 0x4)) goto l_0x17_dd35; /* jnz 0xdd35 */
            ii(0x17_dd31, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_dd33, 2); if(jsw(0x17_dcf9, -0x3c)) goto l_0x17_dcf9; /* js 0xdcf9 */
        l_0x17_dd35:
            ii(0x17_dd35, 3); mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x17_dd38, 2); or(di, di);                               /* or di, di */
            ii(0x17_dd3a, 2); if(jzw(0x17_dd3e, 0x2)) goto l_0x17_dd3e; /* jz 0xdd3e */
            ii(0x17_dd3c, 2); mov(memw_a16[ds, di], si);                /* mov [di], si */
        l_0x17_dd3e:
            ii(0x17_dd3e, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_dd40, 4); test(memb_a16[ss, bp - 0x1], 0x2);        /* test byte [bp-0x1], 0x2 */
            ii(0x17_dd44, 2); if(jzw(0x17_dd4d, 0x7)) goto l_0x17_dd4d; /* jz 0xdd4d */
            ii(0x17_dd46, 2); neg(ax);                                  /* neg ax */
            ii(0x17_dd48, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_dd4b, 2); neg(dx);                                  /* neg dx */
        l_0x17_dd4d:
            ii(0x17_dd4d, 1); popw(di);                                 /* pop di */
            ii(0x17_dd4e, 1); popw(si);                                 /* pop si */
            ii(0x17_dd4f, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_dd51, 1); popw(bp);                                 /* pop bp */
            ii(0x17_dd52, 1); retfw(); return;                          /* retf */
        }
    }
}
