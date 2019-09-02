using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0a45-f6c5d0a5")]
        public void Method_001a_0a45()
        {
            ii(0x1a_0a45, 4); enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x1a_0a49, 1); push(si);                                 /* push si */
            ii(0x1a_0a4a, 1); push(ds);                                 /* push ds */
            ii(0x1a_0a4b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0a4e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0a50, 3); les(bx, memw[ss, bp + 8]);                /* les bx, [bp+0x8] */
            ii(0x1a_0a53, 4); mov(memb[es, bx], 0);                     /* mov byte [es:bx], 0x0 */
            ii(0x1a_0a57, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0a5c, 2); jmp(0x1a_0a61, 3); goto l_0x1a_0a61;      /* jmp 0xa61 */
        l_0x1a_0a5e:
            ii(0x1a_0a5e, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0a61:
            ii(0x1a_0a61, 3); mov(ax, memw[ss, bp + 0xe]);              /* mov ax, [bp+0xe] */
            ii(0x1a_0a64, 3); or(ax, memw[ss, bp + 0xc]);               /* or ax, [bp+0xc] */
            ii(0x1a_0a67, 2); if(jz(0x1a_0ac0, 0x57)) goto l_0x1a_0ac0; /* jz 0xac0 */
            ii(0x1a_0a69, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0a6c, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0a6f, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0a73, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0a77, 2); if(jz(0x1a_0ac0, 0x47)) goto l_0x1a_0ac0; /* jz 0xac0 */
            ii(0x1a_0a79, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0a7d, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0a81, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0a84, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0a87, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_0a8a, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_0a8d, 1); push(ds);                                 /* push ds */
            ii(0x1a_0a8e, 3); push(0x37f6);                             /* push 0x37f6 */
            ii(0x1a_0a91, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x1a_0a93, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x1a_0a98, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_0a9b, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x1a_0a9e, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x1a_0aa1, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0aa4, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0aa7, 4); push(memw[ds, si + 0x388c]);              /* push word [si+0x388c] */
            ii(0x1a_0aab, 4); push(memw[ds, si + 0x388a]);              /* push word [si+0x388a] */
            ii(0x1a_0aaf, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0ab2, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0ab5, 1); push(cs);                                 /* push cs */
            ii(0x1a_0ab6, 3); call(0x1a_095a, -0x15f);                  /* call 0x95a */
            ii(0x1a_0ab9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0abb, 2); if(jz(0x1a_0a5e, -0x5f)) goto l_0x1a_0a5e; /* jz 0xa5e */
            ii(0x1a_0abd, 3); jmp(0x1a_0cc8, 0x208); goto l_0x1a_0cc8;  /* jmp 0xcc8 */
        l_0x1a_0ac0:
            ii(0x1a_0ac0, 4); cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x1a_0ac4, 2); if(jz(0x1a_0b26, 0x60)) goto l_0x1a_0b26; /* jz 0xb26 */
            ii(0x1a_0ac6, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0acb, 2); jmp(0x1a_0ad0, 3); goto l_0x1a_0ad0;      /* jmp 0xad0 */
        l_0x1a_0acd:
            ii(0x1a_0acd, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0ad0:
            ii(0x1a_0ad0, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0ad3, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0ad6, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0ada, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0ade, 2); if(jnz(0x1a_0ae3, 3)) goto l_0x1a_0ae3;   /* jnz 0xae3 */
            ii(0x1a_0ae0, 3); jmp(0x1a_0ca7, 0x1c4); goto l_0x1a_0ca7;  /* jmp 0xca7 */
        l_0x1a_0ae3:
            ii(0x1a_0ae3, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0ae7, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0aeb, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0aee, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0af1, 1); push(ds);                                 /* push ds */
            ii(0x1a_0af2, 3); push(0x34b4);                             /* push 0x34b4 */
            ii(0x1a_0af5, 1); push(ds);                                 /* push ds */
            ii(0x1a_0af6, 3); push(0x380b);                             /* push 0x380b */
            ii(0x1a_0af9, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x1a_0afb, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x1a_0b00, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_0b03, 1); push(ds);                                 /* push ds */
            ii(0x1a_0b04, 3); push(0x34b4);                             /* push 0x34b4 */
            ii(0x1a_0b07, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0b0a, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0b0d, 4); push(memw[ds, si + 0x388c]);              /* push word [si+0x388c] */
            ii(0x1a_0b11, 4); push(memw[ds, si + 0x388a]);              /* push word [si+0x388a] */
            ii(0x1a_0b15, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0b18, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0b1b, 1); push(cs);                                 /* push cs */
            ii(0x1a_0b1c, 3); call(0x1a_095a, -0x1c5);                  /* call 0x95a */
            ii(0x1a_0b1f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0b21, 2); if(jz(0x1a_0acd, -0x56)) goto l_0x1a_0acd; /* jz 0xacd */
            ii(0x1a_0b23, 3); jmp(0x1a_0cc8, 0x1a2); goto l_0x1a_0cc8;  /* jmp 0xcc8 */
        l_0x1a_0b26:
            ii(0x1a_0b26, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0b2b, 2); jmp(0x1a_0b30, 3); goto l_0x1a_0b30;      /* jmp 0xb30 */
        l_0x1a_0b2d:
            ii(0x1a_0b2d, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0b30:
            ii(0x1a_0b30, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0b33, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0b36, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0b3a, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0b3e, 2); if(jz(0x1a_0b83, 0x43)) goto l_0x1a_0b83; /* jz 0xb83 */
            ii(0x1a_0b40, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0b44, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0b48, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0b4b, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0b4e, 1); push(ds);                                 /* push ds */
            ii(0x1a_0b4f, 3); push(0x33b4);                             /* push 0x33b4 */
            ii(0x1a_0b52, 1); push(ds);                                 /* push ds */
            ii(0x1a_0b53, 3); push(0x382c);                             /* push 0x382c */
            ii(0x1a_0b56, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x1a_0b58, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x1a_0b5d, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_0b60, 1); push(ds);                                 /* push ds */
            ii(0x1a_0b61, 3); push(0x33b4);                             /* push 0x33b4 */
            ii(0x1a_0b64, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0b67, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0b6a, 4); push(memw[ds, si + 0x388c]);              /* push word [si+0x388c] */
            ii(0x1a_0b6e, 4); push(memw[ds, si + 0x388a]);              /* push word [si+0x388a] */
            ii(0x1a_0b72, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0b75, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0b78, 1); push(cs);                                 /* push cs */
            ii(0x1a_0b79, 3); call(0x1a_095a, -0x222);                  /* call 0x95a */
            ii(0x1a_0b7c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0b7e, 2); if(jz(0x1a_0b2d, -0x53)) goto l_0x1a_0b2d; /* jz 0xb2d */
            ii(0x1a_0b80, 3); jmp(0x1a_0cc8, 0x145); goto l_0x1a_0cc8;  /* jmp 0xcc8 */
        l_0x1a_0b83:
            ii(0x1a_0b83, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0b88, 2); jmp(0x1a_0b8d, 3); goto l_0x1a_0b8d;      /* jmp 0xb8d */
        l_0x1a_0b8a:
            ii(0x1a_0b8a, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0b8d:
            ii(0x1a_0b8d, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0b90, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0b93, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0b97, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0b9b, 2); if(jz(0x1a_0bc0, 0x23)) goto l_0x1a_0bc0; /* jz 0xbc0 */
            ii(0x1a_0b9d, 1); push(ds);                                 /* push ds */
            ii(0x1a_0b9e, 3); push(0x32b4);                             /* push 0x32b4 */
            ii(0x1a_0ba1, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0ba4, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0ba7, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0bab, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0baf, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0bb2, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0bb5, 1); push(cs);                                 /* push cs */
            ii(0x1a_0bb6, 3); call(0x1a_095a, -0x25f);                  /* call 0x95a */
            ii(0x1a_0bb9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0bbb, 2); if(jz(0x1a_0b8a, -0x33)) goto l_0x1a_0b8a; /* jz 0xb8a */
            ii(0x1a_0bbd, 3); jmp(0x1a_0cc8, 0x108); goto l_0x1a_0cc8;  /* jmp 0xcc8 */
        l_0x1a_0bc0:
            ii(0x1a_0bc0, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0bc5, 2); jmp(0x1a_0bca, 3); goto l_0x1a_0bca;      /* jmp 0xbca */
        l_0x1a_0bc7:
            ii(0x1a_0bc7, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0bca:
            ii(0x1a_0bca, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0bcd, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0bd0, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0bd4, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0bd8, 2); if(jz(0x1a_0bfd, 0x23)) goto l_0x1a_0bfd; /* jz 0xbfd */
            ii(0x1a_0bda, 1); push(ds);                                 /* push ds */
            ii(0x1a_0bdb, 3); push(0x384b);                             /* push 0x384b */
            ii(0x1a_0bde, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0be1, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0be4, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0be8, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0bec, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0bef, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0bf2, 1); push(cs);                                 /* push cs */
            ii(0x1a_0bf3, 3); call(0x1a_095a, -0x29c);                  /* call 0x95a */
            ii(0x1a_0bf6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0bf8, 2); if(jz(0x1a_0bc7, -0x33)) goto l_0x1a_0bc7; /* jz 0xbc7 */
            ii(0x1a_0bfa, 3); jmp(0x1a_0cc8, 0xcb); goto l_0x1a_0cc8;   /* jmp 0xcc8 */
        l_0x1a_0bfd:
            ii(0x1a_0bfd, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0c02, 2); jmp(0x1a_0c07, 3); goto l_0x1a_0c07;      /* jmp 0xc07 */
        l_0x1a_0c04:
            ii(0x1a_0c04, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0c07:
            ii(0x1a_0c07, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0c0a, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0c0d, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0c11, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0c15, 2); if(jz(0x1a_0c3a, 0x23)) goto l_0x1a_0c3a; /* jz 0xc3a */
            ii(0x1a_0c17, 1); push(ds);                                 /* push ds */
            ii(0x1a_0c18, 3); push(0x35b4);                             /* push 0x35b4 */
            ii(0x1a_0c1b, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0c1e, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0c21, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0c25, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0c29, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0c2c, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0c2f, 1); push(cs);                                 /* push cs */
            ii(0x1a_0c30, 3); call(0x1a_095a, -0x2d9);                  /* call 0x95a */
            ii(0x1a_0c33, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0c35, 2); if(jz(0x1a_0c04, -0x33)) goto l_0x1a_0c04; /* jz 0xc04 */
            ii(0x1a_0c37, 3); jmp(0x1a_0cc8, 0x8e); goto l_0x1a_0cc8;   /* jmp 0xcc8 */
        l_0x1a_0c3a:
            ii(0x1a_0c3a, 5); cmp(memb[ds, 0x36b4], 0);                 /* cmp byte [0x36b4], 0x0 */
            ii(0x1a_0c3f, 2); if(jz(0x1a_0ca7, 0x66)) goto l_0x1a_0ca7; /* jz 0xca7 */
            ii(0x1a_0c41, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
            ii(0x1a_0c46, 2); jmp(0x1a_0c4b, 3); goto l_0x1a_0c4b;      /* jmp 0xc4b */
        l_0x1a_0c48:
            ii(0x1a_0c48, 3); inc(memw[ss, bp - 2]);                    /* inc word [bp-0x2] */
        l_0x1a_0c4b:
            ii(0x1a_0c4b, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x1a_0c4e, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x1a_0c51, 4); mov(ax, memw[ds, bx + 0x388c]);           /* mov ax, [bx+0x388c] */
            ii(0x1a_0c55, 4); or(ax, memw[ds, bx + 0x388a]);            /* or ax, [bx+0x388a] */
            ii(0x1a_0c59, 2); if(jz(0x1a_0ca7, 0x4c)) goto l_0x1a_0ca7; /* jz 0xca7 */
            ii(0x1a_0c5b, 4); push(memw[ds, bx + 0x388c]);              /* push word [bx+0x388c] */
            ii(0x1a_0c5f, 4); push(memw[ds, bx + 0x388a]);              /* push word [bx+0x388a] */
            ii(0x1a_0c63, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0c66, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0c69, 1); push(ds);                                 /* push ds */
            ii(0x1a_0c6a, 3); push(0x36b4);                             /* push 0x36b4 */
            ii(0x1a_0c6d, 1); push(ds);                                 /* push ds */
            ii(0x1a_0c6e, 3); push(0x384d);                             /* push 0x384d */
            ii(0x1a_0c71, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x1a_0c73, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x1a_0c78, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_0c7b, 1); push(ds);                                 /* push ds */
            ii(0x1a_0c7c, 3); push(0x36b4);                             /* push 0x36b4 */
            ii(0x1a_0c7f, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0c82, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0c85, 4); push(memw[ds, si + 0x388c]);              /* push word [si+0x388c] */
            ii(0x1a_0c89, 4); push(memw[ds, si + 0x388a]);              /* push word [si+0x388a] */
            ii(0x1a_0c8d, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0c90, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0c93, 1); push(cs);                                 /* push cs */
            ii(0x1a_0c94, 3); call(0x1a_095a, -0x33d);                  /* call 0x95a */
            ii(0x1a_0c97, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_0c99, 2); if(jz(0x1a_0c48, -0x53)) goto l_0x1a_0c48; /* jz 0xc48 */
            ii(0x1a_0c9b, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0c9e, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0ca1, 1); push(ds);                                 /* push ds */
            ii(0x1a_0ca2, 3); push(0x386c);                             /* push 0x386c */
            ii(0x1a_0ca5, 2); jmp(0x1a_0cc0, 0x19); goto l_0x1a_0cc0;   /* jmp 0xcc0 */
        l_0x1a_0ca7:
            ii(0x1a_0ca7, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0caa, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0cad, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x1a_0cb0, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x1a_0cb3, 3); call(0x19_ff6c, -0xd4a);                  /* call 0xff6c */
            ii(0x1a_0cb6, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_0cb9, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0cbc, 1); push(ds);                                 /* push ds */
            ii(0x1a_0cbd, 3); push(0x3878);                             /* push 0x3878 */
        l_0x1a_0cc0:
            ii(0x1a_0cc0, 5); call_far_abs(0x80, 0x2289);               /* call word 0x80:0x2289 */
            ii(0x1a_0cc5, 3); add(sp, 8);                               /* add sp, 0x8 */
        l_0x1a_0cc8:
            ii(0x1a_0cc8, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_0cc9, 1); pop(si);                                  /* pop si */
            ii(0x1a_0cca, 1); leave();                                  /* leave */
            ii(0x1a_0ccb, 3); retf(0xe);                                /* retf 0xe */
        }
    }
}
