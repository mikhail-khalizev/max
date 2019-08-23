using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_0cc7-224b69f2")]
        public void Method_0001_0cc7()
        {
            ii(0x1_0cc7, 4);  enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x1_0ccb, 1);  pushw(si);                                /* push si */
            ii(0x1_0ccc, 5);  mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x1_0cd1, 3);  les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x1_0cd4, 6);  mov(memw_a16[es, bx + 0x16], 0x1);        /* mov word [es:bx+0x16], 0x1 */
            ii(0x1_0cda, 4);  mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x1_0cde, 3);  mov(memw_a16[ds, 0x38], ax);              /* mov [0x38], ax */
            ii(0x1_0ce1, 3);  mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x1_0ce4:
            ii(0x1_0ce4, 3);  lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x1_0ce7, 1);  pushw(ax);                                /* push ax */
            ii(0x1_0ce8, 3);  pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1_0ceb, 3);  callw(0x1_1c5e, 0xf70);                   /* call 0x1c5e */
            ii(0x1_0cee, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0cef, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0cf0, 4);  test(memb_a16[ss, bp - 0x8], 0x10);       /* test byte [bp-0x8], 0x10 */
            ii(0x1_0cf4, 2);  if(jzw(0x1_0d11, 0x1b)) goto l_0x1_0d11;  /* jz 0xd11 */
            ii(0x1_0cf6, 3);  mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x1_0cf9, 3);  les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x1_0cfc, 4);  cmp(memw_a16[es, bx + 0x2], ax);          /* cmp [es:bx+0x2], ax */
            ii(0x1_0d00, 2);  if(jzw(0x1_0d11, 0xf)) goto l_0x1_0d11;   /* jz 0xd11 */
            ii(0x1_0d02, 2);  mov(bx, ax);                              /* mov bx, ax */
            ii(0x1_0d04, 3);  shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x1_0d07, 4);  les(si, ds, 0xaa0);                       /* les si, [0xaa0] */
            ii(0x1_0d0b, 4);  test(memb_a16[es, bx + si], 0x1);         /* test byte [es:bx+si], 0x1 */
            ii(0x1_0d0f, 2);  if(jnzw(0x1_0d14, 0x3)) goto l_0x1_0d14;  /* jnz 0xd14 */
        l_0x1_0d11:
            ii(0x1_0d11, 3);  jmpw(0x1_0df6, 0xe2); goto l_0x1_0df6;    /* jmp 0xdf6 */
        l_0x1_0d14:
            ii(0x1_0d14, 4);  cmp(memw_a16[ss, bp - 0xe], 0x10);        /* cmp word [bp-0xe], 0x10 */
            ii(0x1_0d18, 2);  if(jaw(0x1_0d1c, 0x2)) goto l_0x1_0d1c;   /* ja 0xd1c */
            ii(0x1_0d1a, 2);  if(jbw(0x1_0d7d, 0x61)) goto l_0x1_0d7d;  /* jb 0xd7d */
        l_0x1_0d1c:
            ii(0x1_0d1c, 3);  pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x1_0d1f, 3);  callw(0x1_1ac7, 0xda5);                   /* call 0x1ac7 */
            ii(0x1_0d22, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d23, 2);  pushw(0);                                 /* push 0x0 */
            ii(0x1_0d25, 1);  pushw(ax);                                /* push ax */
            ii(0x1_0d26, 3);  pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x1_0d29, 3);  pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x1_0d2c, 3);  callw(0x1_1b8c, 0xe5d);                   /* call 0x1b8c */
            ii(0x1_0d2f, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d30, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d31, 1);  pushw(dx);                                /* push dx */
            ii(0x1_0d32, 1);  pushw(ax);                                /* push ax */
            ii(0x1_0d33, 3);  callw(0xffe0, -0xd56);                    /* call 0xffe0 */
            ii(0x1_0d36, 3);  add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x1_0d39:
            ii(0x1_0d39, 3);  mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x1_0d3c, 3);  shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x1_0d3f, 4);  les(si, ds, 0xaa0);                       /* les si, [0xaa0] */
            ii(0x1_0d43, 3);  mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x1_0d46, 1);  cbw();                                    /* cbw */
            ii(0x1_0d47, 3);  mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x1_0d4a, 3);  pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1_0d4d, 3);  callw(0x1_1cd1, 0xf81);                   /* call 0x1cd1 */
            ii(0x1_0d50, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d51, 4);  test(memb_a16[ss, bp - 0x6], 0x10);       /* test byte [bp-0x6], 0x10 */
            ii(0x1_0d55, 2);  if(jzw(0x1_0d70, 0x19)) goto l_0x1_0d70;  /* jz 0xd70 */
            ii(0x1_0d57, 5);  test(memb_a16[ds, 0x15], 0x4);            /* test byte [0x15], 0x4 */
            ii(0x1_0d5c, 2);  if(jnzw(0x1_0d70, 0x12)) goto l_0x1_0d70; /* jnz 0xd70 */
            ii(0x1_0d5e, 3);  pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x1_0d61, 3);  pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x1_0d64, 3);  pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x1_0d67, 3);  pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1_0d6a, 3);  callw(0x1_15e9, 0x87c);                   /* call 0x15e9 */
            ii(0x1_0d6d, 3);  add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x1_0d70:
            ii(0x1_0d70, 4);  test(memb_a16[ss, bp - 0x6], 0x2);        /* test byte [bp-0x6], 0x2 */
            ii(0x1_0d74, 2);  if(jzw(0x1_0dcb, 0x55)) goto l_0x1_0dcb;  /* jz 0xdcb */
            ii(0x1_0d76, 4);  add(memw_a16[ss, bp - 0x2], 0x8);         /* add word [bp-0x2], 0x8 */
            ii(0x1_0d7a, 3);  jmpw(0x1_0ce4, -0x99); goto l_0x1_0ce4;   /* jmp 0xce4 */
        l_0x1_0d7d:
            ii(0x1_0d7d, 3);  pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x1_0d80, 3);  pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x1_0d83, 3);  callw(0x1_1b8c, 0xe06);                   /* call 0x1b8c */
            ii(0x1_0d86, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d87, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0d88, 4);  mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x1_0d8c, 3);  mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x1_0d8f, 3);  mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1_0d92, 4);  mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x1_0d96, 3);  cmp(memw_a16[ds, bx + 0x6], ax);          /* cmp [bx+0x6], ax */
            ii(0x1_0d99, 2);  if(jzw(0x1_0db7, 0x1c)) goto l_0x1_0db7;  /* jz 0xdb7 */
            ii(0x1_0d9b, 3);  pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x1_0d9e, 3);  callw(0xf07f, -0x1d22);                   /* call 0xf07f */
            ii(0x1_0da1, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0da2, 2);  or(ax, ax);                               /* or ax, ax */
            ii(0x1_0da4, 2);  if(jzw(0x1_0db7, 0x11)) goto l_0x1_0db7;  /* jz 0xdb7 */
            ii(0x1_0da6, 4);  mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x1_0daa, 3);  mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x1_0dad, 3);  les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x1_0db0, 4);  mov(memw_a16[es, bx + 0x16], ax);         /* mov [es:bx+0x16], ax */
            ii(0x1_0db4, 1);  popw(si);                                 /* pop si */
            ii(0x1_0db5, 1);  leavew();                                 /* leave */
            ii(0x1_0db6, 1);  retw(); return;                           /* ret */
        l_0x1_0db7:
            ii(0x1_0db7, 3);  pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x1_0dba, 3);  callw(0x1_1ac7, 0xd0a);                   /* call 0x1ac7 */
            ii(0x1_0dbd, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_0dbe, 4);  mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x1_0dc2, 3);  add(ax, memw_a16[ds, bx + 0x6]);          /* add ax, [bx+0x6] */
            ii(0x1_0dc5, 3);  mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1_0dc8, 3);  jmpw(0x1_0d39, -0x92); goto l_0x1_0d39;   /* jmp 0xd39 */
        l_0x1_0dcb:
            ii(0x1_0dcb, 3);  les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x1_0dce, 5);  and(memb_a16[es, bx + 0x26], -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
            ii(0x1_0dd3, 4);  mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x1_0dd7, 4);  mov(memw_a16[es, bx + 0x16], ax);         /* mov [es:bx+0x16], ax */
            ii(0x1_0ddb, 6);  mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
            ii(0x1_0de1, 3);  mov(ax, memw_a16[ds, 0x38]);              /* mov ax, [0x38] */
            ii(0x1_0de4, 4);  cmp(memw_a16[es, bx + 0x4], ax);          /* cmp [es:bx+0x4], ax */
            ii(0x1_0de8, 2);  if(jnzw(0x1_0df0, 0x6)) goto l_0x1_0df0;  /* jnz 0xdf0 */
            ii(0x1_0dea, 6);  mov(memw_a16[es, bx + 0x4], 0);           /* mov word [es:bx+0x4], 0x0 */
        l_0x1_0df0:
            ii(0x1_0df0, 2);  pushw(0x1);                               /* push 0x1 */
            ii(0x1_0df2, 3);  callw(0xe579, -0x287c);                   /* call 0xe579 */
            ii(0x1_0df5, 1);  popw(bx);                                 /* pop bx */
        l_0x1_0df6:
            ii(0x1_0df6, 1);  popw(si);                                 /* pop si */
            ii(0x1_0df7, 1);  leavew();                                 /* leave */
            ii(0x1_0df8, 1);  retw();                                   /* ret */
        }
    }
}
