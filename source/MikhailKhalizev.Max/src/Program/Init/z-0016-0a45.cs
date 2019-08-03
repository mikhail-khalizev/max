using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e956576-6d31-45b4-b326-addd43a6a2ac")]
        public void Method_0016_0a45()
        {
            ii(0x16_0a45, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x16_0a49, 1); pushw(si);                                /* push si */
            ii(0x16_0a4a, 1); pushw(ds);                                /* push ds */
            ii(0x16_0a4b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0a4e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0a50, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x16_0a53, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x16_0a57, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0a5c, 2); jmpw(0x16_0a61, 0x3); goto l_0x16_0a61;   /* jmp 0xa61 */
        l_0x16_0a5e:
            ii(0x16_0a5e, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0a61:
            ii(0x16_0a61, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x16_0a64, 3); or(ax, memw_a16[ss, bp + 0xc]);           /* or ax, [bp+0xc] */
            ii(0x16_0a67, 2); if(jzw(0x16_0ac0, 0x57)) goto l_0x16_0ac0; /* jz 0xac0 */
            ii(0x16_0a69, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0a6c, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0a6f, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0a73, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0a77, 2); if(jzw(0x16_0ac0, 0x47)) goto l_0x16_0ac0; /* jz 0xac0 */
            ii(0x16_0a79, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0a7d, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0a81, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0a84, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0a87, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_0a8a, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_0a8d, 1); pushw(ds);                                /* push ds */
            ii(0x16_0a8e, 3); pushw(0x37f6);                            /* push 0x37f6 */
            ii(0x16_0a91, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x16_0a93, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x16_0a98, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x16_0a9b, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x16_0a9e, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x16_0aa1, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0aa4, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0aa7, 4); pushw(memw_a16[ds, si + 0x388c]);         /* push word [si+0x388c] */
            ii(0x16_0aab, 4); pushw(memw_a16[ds, si + 0x388a]);         /* push word [si+0x388a] */
            ii(0x16_0aaf, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0ab2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0ab5, 1); pushw(cs);                                /* push cs */
            ii(0x16_0ab6, 3); callw(0x16_095a, -0x15f);                 /* call 0x95a */
            ii(0x16_0ab9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0abb, 2); if(jzw(0x16_0a5e, -0x5f)) goto l_0x16_0a5e; /* jz 0xa5e */
            ii(0x16_0abd, 3); jmpw(0x16_0cc8, 0x208); goto l_0x16_0cc8; /* jmp 0xcc8 */
        l_0x16_0ac0:
            ii(0x16_0ac0, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x16_0ac4, 2); if(jzw(0x16_0b26, 0x60)) goto l_0x16_0b26; /* jz 0xb26 */
            ii(0x16_0ac6, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0acb, 2); jmpw(0x16_0ad0, 0x3); goto l_0x16_0ad0;   /* jmp 0xad0 */
        l_0x16_0acd:
            ii(0x16_0acd, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0ad0:
            ii(0x16_0ad0, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0ad3, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0ad6, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0ada, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0ade, 2); if(jnzw(0x16_0ae3, 0x3)) goto l_0x16_0ae3; /* jnz 0xae3 */
            ii(0x16_0ae0, 3); jmpw(0x16_0ca7, 0x1c4); goto l_0x16_0ca7; /* jmp 0xca7 */
        l_0x16_0ae3:
            ii(0x16_0ae3, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0ae7, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0aeb, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0aee, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0af1, 1); pushw(ds);                                /* push ds */
            ii(0x16_0af2, 3); pushw(0x34b4);                            /* push 0x34b4 */
            ii(0x16_0af5, 1); pushw(ds);                                /* push ds */
            ii(0x16_0af6, 3); pushw(0x380b);                            /* push 0x380b */
            ii(0x16_0af9, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x16_0afb, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x16_0b00, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x16_0b03, 1); pushw(ds);                                /* push ds */
            ii(0x16_0b04, 3); pushw(0x34b4);                            /* push 0x34b4 */
            ii(0x16_0b07, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0b0a, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0b0d, 4); pushw(memw_a16[ds, si + 0x388c]);         /* push word [si+0x388c] */
            ii(0x16_0b11, 4); pushw(memw_a16[ds, si + 0x388a]);         /* push word [si+0x388a] */
            ii(0x16_0b15, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0b18, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0b1b, 1); pushw(cs);                                /* push cs */
            ii(0x16_0b1c, 3); callw(0x16_095a, -0x1c5);                 /* call 0x95a */
            ii(0x16_0b1f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0b21, 2); if(jzw(0x16_0acd, -0x56)) goto l_0x16_0acd; /* jz 0xacd */
            ii(0x16_0b23, 3); jmpw(0x16_0cc8, 0x1a2); goto l_0x16_0cc8; /* jmp 0xcc8 */
        l_0x16_0b26:
            ii(0x16_0b26, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0b2b, 2); jmpw(0x16_0b30, 0x3); goto l_0x16_0b30;   /* jmp 0xb30 */
        l_0x16_0b2d:
            ii(0x16_0b2d, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0b30:
            ii(0x16_0b30, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0b33, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0b36, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0b3a, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0b3e, 2); if(jzw(0x16_0b83, 0x43)) goto l_0x16_0b83; /* jz 0xb83 */
            ii(0x16_0b40, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0b44, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0b48, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0b4b, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0b4e, 1); pushw(ds);                                /* push ds */
            ii(0x16_0b4f, 3); pushw(0x33b4);                            /* push 0x33b4 */
            ii(0x16_0b52, 1); pushw(ds);                                /* push ds */
            ii(0x16_0b53, 3); pushw(0x382c);                            /* push 0x382c */
            ii(0x16_0b56, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x16_0b58, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x16_0b5d, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x16_0b60, 1); pushw(ds);                                /* push ds */
            ii(0x16_0b61, 3); pushw(0x33b4);                            /* push 0x33b4 */
            ii(0x16_0b64, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0b67, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0b6a, 4); pushw(memw_a16[ds, si + 0x388c]);         /* push word [si+0x388c] */
            ii(0x16_0b6e, 4); pushw(memw_a16[ds, si + 0x388a]);         /* push word [si+0x388a] */
            ii(0x16_0b72, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0b75, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0b78, 1); pushw(cs);                                /* push cs */
            ii(0x16_0b79, 3); callw(0x16_095a, -0x222);                 /* call 0x95a */
            ii(0x16_0b7c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0b7e, 2); if(jzw(0x16_0b2d, -0x53)) goto l_0x16_0b2d; /* jz 0xb2d */
            ii(0x16_0b80, 3); jmpw(0x16_0cc8, 0x145); goto l_0x16_0cc8; /* jmp 0xcc8 */
        l_0x16_0b83:
            ii(0x16_0b83, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0b88, 2); jmpw(0x16_0b8d, 0x3); goto l_0x16_0b8d;   /* jmp 0xb8d */
        l_0x16_0b8a:
            ii(0x16_0b8a, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0b8d:
            ii(0x16_0b8d, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0b90, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0b93, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0b97, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0b9b, 2); if(jzw(0x16_0bc0, 0x23)) goto l_0x16_0bc0; /* jz 0xbc0 */
            ii(0x16_0b9d, 1); pushw(ds);                                /* push ds */
            ii(0x16_0b9e, 3); pushw(0x32b4);                            /* push 0x32b4 */
            ii(0x16_0ba1, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0ba4, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0ba7, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0bab, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0baf, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0bb2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0bb5, 1); pushw(cs);                                /* push cs */
            ii(0x16_0bb6, 3); callw(0x16_095a, -0x25f);                 /* call 0x95a */
            ii(0x16_0bb9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0bbb, 2); if(jzw(0x16_0b8a, -0x33)) goto l_0x16_0b8a; /* jz 0xb8a */
            ii(0x16_0bbd, 3); jmpw(0x16_0cc8, 0x108); goto l_0x16_0cc8; /* jmp 0xcc8 */
        l_0x16_0bc0:
            ii(0x16_0bc0, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0bc5, 2); jmpw(0x16_0bca, 0x3); goto l_0x16_0bca;   /* jmp 0xbca */
        l_0x16_0bc7:
            ii(0x16_0bc7, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0bca:
            ii(0x16_0bca, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0bcd, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0bd0, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0bd4, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0bd8, 2); if(jzw(0x16_0bfd, 0x23)) goto l_0x16_0bfd; /* jz 0xbfd */
            ii(0x16_0bda, 1); pushw(ds);                                /* push ds */
            ii(0x16_0bdb, 3); pushw(0x384b);                            /* push 0x384b */
            ii(0x16_0bde, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0be1, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0be4, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0be8, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0bec, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0bef, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0bf2, 1); pushw(cs);                                /* push cs */
            ii(0x16_0bf3, 3); callw(0x16_095a, -0x29c);                 /* call 0x95a */
            ii(0x16_0bf6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0bf8, 2); if(jzw(0x16_0bc7, -0x33)) goto l_0x16_0bc7; /* jz 0xbc7 */
            ii(0x16_0bfa, 3); jmpw(0x16_0cc8, 0xcb); goto l_0x16_0cc8;  /* jmp 0xcc8 */
        l_0x16_0bfd:
            ii(0x16_0bfd, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0c02, 2); jmpw(0x16_0c07, 0x3); goto l_0x16_0c07;   /* jmp 0xc07 */
        l_0x16_0c04:
            ii(0x16_0c04, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0c07:
            ii(0x16_0c07, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0c0a, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0c0d, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0c11, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0c15, 2); if(jzw(0x16_0c3a, 0x23)) goto l_0x16_0c3a; /* jz 0xc3a */
            ii(0x16_0c17, 1); pushw(ds);                                /* push ds */
            ii(0x16_0c18, 3); pushw(0x35b4);                            /* push 0x35b4 */
            ii(0x16_0c1b, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0c1e, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0c21, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0c25, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0c29, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0c2c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0c2f, 1); pushw(cs);                                /* push cs */
            ii(0x16_0c30, 3); callw(0x16_095a, -0x2d9);                 /* call 0x95a */
            ii(0x16_0c33, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0c35, 2); if(jzw(0x16_0c04, -0x33)) goto l_0x16_0c04; /* jz 0xc04 */
            ii(0x16_0c37, 3); jmpw(0x16_0cc8, 0x8e); goto l_0x16_0cc8;  /* jmp 0xcc8 */
        l_0x16_0c3a:
            ii(0x16_0c3a, 5); cmp(memb_a16[ds, 0x36b4], 0);             /* cmp byte [0x36b4], 0x0 */
            ii(0x16_0c3f, 2); if(jzw(0x16_0ca7, 0x66)) goto l_0x16_0ca7; /* jz 0xca7 */
            ii(0x16_0c41, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x16_0c46, 2); jmpw(0x16_0c4b, 0x3); goto l_0x16_0c4b;   /* jmp 0xc4b */
        l_0x16_0c48:
            ii(0x16_0c48, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x16_0c4b:
            ii(0x16_0c4b, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x16_0c4e, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x16_0c51, 4); mov(ax, memw_a16[ds, bx + 0x388c]);       /* mov ax, [bx+0x388c] */
            ii(0x16_0c55, 4); or(ax, memw_a16[ds, bx + 0x388a]);        /* or ax, [bx+0x388a] */
            ii(0x16_0c59, 2); if(jzw(0x16_0ca7, 0x4c)) goto l_0x16_0ca7; /* jz 0xca7 */
            ii(0x16_0c5b, 4); pushw(memw_a16[ds, bx + 0x388c]);         /* push word [bx+0x388c] */
            ii(0x16_0c5f, 4); pushw(memw_a16[ds, bx + 0x388a]);         /* push word [bx+0x388a] */
            ii(0x16_0c63, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0c66, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0c69, 1); pushw(ds);                                /* push ds */
            ii(0x16_0c6a, 3); pushw(0x36b4);                            /* push 0x36b4 */
            ii(0x16_0c6d, 1); pushw(ds);                                /* push ds */
            ii(0x16_0c6e, 3); pushw(0x384d);                            /* push 0x384d */
            ii(0x16_0c71, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x16_0c73, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x16_0c78, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x16_0c7b, 1); pushw(ds);                                /* push ds */
            ii(0x16_0c7c, 3); pushw(0x36b4);                            /* push 0x36b4 */
            ii(0x16_0c7f, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0c82, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0c85, 4); pushw(memw_a16[ds, si + 0x388c]);         /* push word [si+0x388c] */
            ii(0x16_0c89, 4); pushw(memw_a16[ds, si + 0x388a]);         /* push word [si+0x388a] */
            ii(0x16_0c8d, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0c90, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0c93, 1); pushw(cs);                                /* push cs */
            ii(0x16_0c94, 3); callw(0x16_095a, -0x33d);                 /* call 0x95a */
            ii(0x16_0c97, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_0c99, 2); if(jzw(0x16_0c48, -0x53)) goto l_0x16_0c48; /* jz 0xc48 */
            ii(0x16_0c9b, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0c9e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0ca1, 1); pushw(ds);                                /* push ds */
            ii(0x16_0ca2, 3); pushw(0x386c);                            /* push 0x386c */
            ii(0x16_0ca5, 2); jmpw(0x16_0cc0, 0x19); goto l_0x16_0cc0;  /* jmp 0xcc0 */
        l_0x16_0ca7:
            ii(0x16_0ca7, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0caa, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0cad, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x16_0cb0, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x16_0cb3, 3); callw(0x15_ff6c, -0xd4a);                 /* call 0xff6c */
            ii(0x16_0cb6, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0cb9, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0cbc, 1); pushw(ds);                                /* push ds */
            ii(0x16_0cbd, 3); pushw(0x3878);                            /* push 0x3878 */
        l_0x16_0cc0:
            ii(0x16_0cc0, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x16_0cc5, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x16_0cc8:
            ii(0x16_0cc8, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0cc9, 1); popw(si);                                 /* pop si */
            ii(0x16_0cca, 1); leavew();                                 /* leave */
            ii(0x16_0ccb, 3); retfw(0xe); return;                       /* retf 0xe */
        }
    }
}