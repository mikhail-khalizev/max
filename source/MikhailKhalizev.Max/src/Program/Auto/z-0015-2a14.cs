using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a1745600-d3b9-4086-aa7e-32de0041cfee")]
        public void Method_0015_2a14()
        {
            ii(0x15_2a14, 4); popw(memw_a16[ds, 0x3c50]);               /* pop word [0x3c50] */
            ii(0x15_2a18, 4); popw(memw_a16[ds, 0x3c52]);               /* pop word [0x3c52] */
            ii(0x15_2a1c, 2); mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x15_2a1e, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_2a20, 3); mov(memw_a16[ds, 0x3c1a], ax);            /* mov [0x3c1a], ax */
            ii(0x15_2a23, 3); mov(dx, 0x1);                             /* mov dx, 0x1 */
            ii(0x15_2a26, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x15_2a28, 2); if(jzw(0x15_2a53, 0x29)) goto l_0x15_2a53; /* jz 0x2a53 */
            ii(0x15_2a2a, 4); mov(es, memw_a16[ds, 0x3c18]);            /* mov es, [0x3c18] */
            ii(0x15_2a2e, 5); mov(es, memw_a16[es, 0x2c]);              /* mov es, [es:0x2c] */
            ii(0x15_2a33, 4); mov(memw_a16[ds, 0x3c41], es);            /* mov [0x3c41], es */
            ii(0x15_2a37, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_2a39, 1); cwd();                                    /* cwd */
            ii(0x15_2a3a, 3); mov(cx, 0x8000);                          /* mov cx, 0x8000 */
            ii(0x15_2a3d, 2); xor(di, di);                              /* xor di, di */
        l_0x15_2a3f:
            ii(0x15_2a3f, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_2a41, 1); scasb_a16();                              /* scasb */
            ii(0x15_2a42, 2); if(jnzw(0x15_2a3f, -0x5)) goto l_0x15_2a3f; /* jnz 0x2a3f */
            ii(0x15_2a44, 1); inc(di);                                  /* inc di */
            ii(0x15_2a45, 1); inc(di);                                  /* inc di */
            ii(0x15_2a46, 4); mov(memw_a16[ds, 0x3c3f], di);            /* mov [0x3c3f], di */
            ii(0x15_2a4a, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x15_2a4d, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x15_2a4f, 2); not(cx);                                  /* not cx */
            ii(0x15_2a51, 2); mov(dx, cx);                              /* mov dx, cx */
        l_0x15_2a53:
            ii(0x15_2a53, 3); mov(di, 0x1);                             /* mov di, 0x1 */
            ii(0x15_2a56, 3); mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x15_2a59, 4); mov(ds, memw_a16[ds, 0x3c18]);            /* mov ds, [0x3c18] */
        l_0x15_2a5d:
            ii(0x15_2a5d, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2a5e, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x15_2a60, 2); if(jzw(0x15_2a5d, -0x5)) goto l_0x15_2a5d; /* jz 0x2a5d */
            ii(0x15_2a62, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x15_2a64, 2); if(jzw(0x15_2a5d, -0x9)) goto l_0x15_2a5d; /* jz 0x2a5d */
            ii(0x15_2a66, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2a68, 2); if(jzw(0x15_2ad9, 0x6f)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2a6a, 2); or(al, al);                               /* or al, al */
            ii(0x15_2a6c, 2); if(jzw(0x15_2ad9, 0x6b)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2a6e, 1); inc(di);                                  /* inc di */
        l_0x15_2a6f:
            ii(0x15_2a6f, 1); dec(si);                                  /* dec si */
        l_0x15_2a70:
            ii(0x15_2a70, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2a71, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x15_2a73, 2); if(jzw(0x15_2a5d, -0x18)) goto l_0x15_2a5d; /* jz 0x2a5d */
            ii(0x15_2a75, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x15_2a77, 2); if(jzw(0x15_2a5d, -0x1c)) goto l_0x15_2a5d; /* jz 0x2a5d */
            ii(0x15_2a79, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2a7b, 2); if(jzw(0x15_2ad9, 0x5c)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2a7d, 2); or(al, al);                               /* or al, al */
            ii(0x15_2a7f, 2); if(jzw(0x15_2ad9, 0x58)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2a81, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2a83, 2); if(jzw(0x15_2aa9, 0x24)) goto l_0x15_2aa9; /* jz 0x2aa9 */
            ii(0x15_2a85, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2a87, 2); if(jzw(0x15_2a8c, 0x3)) goto l_0x15_2a8c; /* jz 0x2a8c */
            ii(0x15_2a89, 1); inc(dx);                                  /* inc dx */
            ii(0x15_2a8a, 2); jmpw(0x15_2a70, -0x1c); goto l_0x15_2a70; /* jmp 0x2a70 */
        l_0x15_2a8c:
            ii(0x15_2a8c, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x15_2a8e:
            ii(0x15_2a8e, 1); inc(cx);                                  /* inc cx */
            ii(0x15_2a8f, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2a90, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2a92, 2); if(jzw(0x15_2a8e, -0x6)) goto l_0x15_2a8e; /* jz 0x2a8e */
            ii(0x15_2a94, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2a96, 2); if(jzw(0x15_2a9c, 0x4)) goto l_0x15_2a9c; /* jz 0x2a9c */
            ii(0x15_2a98, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x15_2a9a, 2); jmpw(0x15_2a6f, -0x2d); goto l_0x15_2a6f; /* jmp 0x2a6f */
        l_0x15_2a9c:
            ii(0x15_2a9c, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_2a9e, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_2aa0, 2); adc(dx, cx);                              /* adc dx, cx */
            ii(0x15_2aa2, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x15_2aa4, 2); if(jnzw(0x15_2a70, -0x36)) goto l_0x15_2a70; /* jnz 0x2a70 */
            ii(0x15_2aa6, 2); jmpw(0x15_2aa9, 0x1); goto l_0x15_2aa9;   /* jmp 0x2aa9 */
        l_0x15_2aa8:
            ii(0x15_2aa8, 1); dec(si);                                  /* dec si */
        l_0x15_2aa9:
            ii(0x15_2aa9, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2aaa, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2aac, 2); if(jzw(0x15_2ad9, 0x2b)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2aae, 2); or(al, al);                               /* or al, al */
            ii(0x15_2ab0, 2); if(jzw(0x15_2ad9, 0x27)) goto l_0x15_2ad9; /* jz 0x2ad9 */
            ii(0x15_2ab2, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2ab4, 2); if(jzw(0x15_2a70, -0x46)) goto l_0x15_2a70; /* jz 0x2a70 */
            ii(0x15_2ab6, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2ab8, 2); if(jzw(0x15_2abd, 0x3)) goto l_0x15_2abd; /* jz 0x2abd */
            ii(0x15_2aba, 1); inc(dx);                                  /* inc dx */
            ii(0x15_2abb, 2); jmpw(0x15_2aa9, -0x14); goto l_0x15_2aa9; /* jmp 0x2aa9 */
        l_0x15_2abd:
            ii(0x15_2abd, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x15_2abf:
            ii(0x15_2abf, 1); inc(cx);                                  /* inc cx */
            ii(0x15_2ac0, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2ac1, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2ac3, 2); if(jzw(0x15_2abf, -0x6)) goto l_0x15_2abf; /* jz 0x2abf */
            ii(0x15_2ac5, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2ac7, 2); if(jzw(0x15_2acd, 0x4)) goto l_0x15_2acd; /* jz 0x2acd */
            ii(0x15_2ac9, 2); add(dx, cx);                              /* add dx, cx */
            ii(0x15_2acb, 2); jmpw(0x15_2aa8, -0x25); goto l_0x15_2aa8; /* jmp 0x2aa8 */
        l_0x15_2acd:
            ii(0x15_2acd, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_2acf, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_2ad1, 2); adc(dx, cx);                              /* adc dx, cx */
            ii(0x15_2ad3, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x15_2ad5, 2); if(jnzw(0x15_2aa9, -0x2e)) goto l_0x15_2aa9; /* jnz 0x2aa9 */
            ii(0x15_2ad7, 2); jmpw(0x15_2a70, -0x69); goto l_0x15_2a70; /* jmp 0x2a70 */
        l_0x15_2ad9:
            ii(0x15_2ad9, 1); pushw(ss);                                /* push ss */
            ii(0x15_2ada, 1); popw(ds);                                 /* pop ds */
            ii(0x15_2adb, 4); mov(memw_a16[ds, 0x3c35], di);            /* mov [0x3c35], di */
            ii(0x15_2adf, 2); add(dx, di);                              /* add dx, di */
            ii(0x15_2ae1, 1); inc(di);                                  /* inc di */
            ii(0x15_2ae2, 2); shl(di, 0x1);                             /* shl di, 1 */
            ii(0x15_2ae4, 2); shl(di, 0x1);                             /* shl di, 1 */
            ii(0x15_2ae6, 2); add(dx, di);                              /* add dx, di */
            ii(0x15_2ae8, 1); inc(dx);                                  /* inc dx */
            ii(0x15_2ae9, 3); and(dl, 0xfe);                            /* and dl, 0xfe */
            ii(0x15_2aec, 2); sub(sp, dx);                              /* sub sp, dx */
            ii(0x15_2aee, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x15_2af0, 3); mov(memw_a16[ds, 0x3c37], ax);            /* mov [0x3c37], ax */
            ii(0x15_2af3, 4); mov(memw_a16[ds, 0x3c39], ss);            /* mov [0x3c39], ss */
            ii(0x15_2af7, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_2af9, 2); add(di, bx);                              /* add di, bx */
            ii(0x15_2afb, 1); pushw(ss);                                /* push ss */
            ii(0x15_2afc, 1); popw(es);                                 /* pop es */
            ii(0x15_2afd, 3); mov(memw_a16[ss, bx], di);                /* mov [ss:bx], di */
            ii(0x15_2b00, 4); mov(memw_a16[ss, bx + 0x2], ss);          /* mov [ss:bx+0x2], ss */
            ii(0x15_2b04, 3); add(bx, 0x4);                             /* add bx, 0x4 */
            ii(0x15_2b07, 4); lds(si, ds, 0x3c3f);                      /* lds si, [0x3c3f] */
        l_0x15_2b0b:
            ii(0x15_2b0b, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b0c, 1); stosb_a16();                              /* stosb */
            ii(0x15_2b0d, 2); or(al, al);                               /* or al, al */
            ii(0x15_2b0f, 2); if(jnzw(0x15_2b0b, -0x6)) goto l_0x15_2b0b; /* jnz 0x2b0b */
            ii(0x15_2b11, 5); mov(ds, memw_a16[ss, 0x3c18]);            /* mov ds, [ss:0x3c18] */
            ii(0x15_2b16, 3); mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x15_2b19, 2); jmpw(0x15_2b1e, 0x3); goto l_0x15_2b1e;   /* jmp 0x2b1e */
        l_0x15_2b1b:
            ii(0x15_2b1b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_2b1d, 1); stosb_a16();                              /* stosb */
        l_0x15_2b1e:
            ii(0x15_2b1e, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b1f, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x15_2b21, 2); if(jzw(0x15_2b1e, -0x5)) goto l_0x15_2b1e; /* jz 0x2b1e */
            ii(0x15_2b23, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x15_2b25, 2); if(jzw(0x15_2b1e, -0x9)) goto l_0x15_2b1e; /* jz 0x2b1e */
            ii(0x15_2b27, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2b29, 2); if(jnzw(0x15_2b2e, 0x3)) goto l_0x15_2b2e; /* jnz 0x2b2e */
            ii(0x15_2b2b, 3); jmpw(0x15_2bb2, 0x84); goto l_0x15_2bb2;  /* jmp 0x2bb2 */
        l_0x15_2b2e:
            ii(0x15_2b2e, 2); or(al, al);                               /* or al, al */
            ii(0x15_2b30, 2); if(jnzw(0x15_2b35, 0x3)) goto l_0x15_2b35; /* jnz 0x2b35 */
            ii(0x15_2b32, 2); jmpw(0x15_2bb2, 0x7e); goto l_0x15_2bb2;  /* jmp 0x2bb2 */
        //    ii(0x15_2b34, 1); nop();                                    /* nop */
        l_0x15_2b35:
            ii(0x15_2b35, 3); mov(memw_a16[ss, bx], di);                /* mov [ss:bx], di */
            ii(0x15_2b38, 4); mov(memw_a16[ss, bx + 0x2], ss);          /* mov [ss:bx+0x2], ss */
            ii(0x15_2b3c, 3); add(bx, 0x4);                             /* add bx, 0x4 */
        l_0x15_2b3f:
            ii(0x15_2b3f, 1); dec(si);                                  /* dec si */
        l_0x15_2b40:
            ii(0x15_2b40, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b41, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x15_2b43, 2); if(jzw(0x15_2b1b, -0x2a)) goto l_0x15_2b1b; /* jz 0x2b1b */
            ii(0x15_2b45, 2); cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x15_2b47, 2); if(jzw(0x15_2b1b, -0x2e)) goto l_0x15_2b1b; /* jz 0x2b1b */
            ii(0x15_2b49, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2b4b, 2); if(jzw(0x15_2baf, 0x62)) goto l_0x15_2baf; /* jz 0x2baf */
            ii(0x15_2b4d, 2); or(al, al);                               /* or al, al */
            ii(0x15_2b4f, 2); if(jzw(0x15_2baf, 0x5e)) goto l_0x15_2baf; /* jz 0x2baf */
            ii(0x15_2b51, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2b53, 2); if(jzw(0x15_2b7c, 0x27)) goto l_0x15_2b7c; /* jz 0x2b7c */
            ii(0x15_2b55, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2b57, 2); if(jzw(0x15_2b5c, 0x3)) goto l_0x15_2b5c; /* jz 0x2b5c */
            ii(0x15_2b59, 1); stosb_a16();                              /* stosb */
            ii(0x15_2b5a, 2); jmpw(0x15_2b40, -0x1c); goto l_0x15_2b40; /* jmp 0x2b40 */
        l_0x15_2b5c:
            ii(0x15_2b5c, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x15_2b5e:
            ii(0x15_2b5e, 1); inc(cx);                                  /* inc cx */
            ii(0x15_2b5f, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b60, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2b62, 2); if(jzw(0x15_2b5e, -0x6)) goto l_0x15_2b5e; /* jz 0x2b5e */
            ii(0x15_2b64, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2b66, 2); if(jzw(0x15_2b6e, 0x6)) goto l_0x15_2b6e; /* jz 0x2b6e */
            ii(0x15_2b68, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x15_2b6a, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x15_2b6c, 2); jmpw(0x15_2b3f, -0x2f); goto l_0x15_2b3f; /* jmp 0x2b3f */
        l_0x15_2b6e:
            ii(0x15_2b6e, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x15_2b70, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_2b72, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x15_2b74, 2); if(jaew(0x15_2b7c, 0x6)) goto l_0x15_2b7c; /* jae 0x2b7c */
            ii(0x15_2b76, 2); mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x15_2b78, 1); stosb_a16();                              /* stosb */
            ii(0x15_2b79, 2); jmpw(0x15_2b40, -0x3b); goto l_0x15_2b40; /* jmp 0x2b40 */
        l_0x15_2b7b:
            ii(0x15_2b7b, 1); dec(si);                                  /* dec si */
        l_0x15_2b7c:
            ii(0x15_2b7c, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b7d, 2); cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x15_2b7f, 2); if(jzw(0x15_2baf, 0x2e)) goto l_0x15_2baf; /* jz 0x2baf */
            ii(0x15_2b81, 2); or(al, al);                               /* or al, al */
            ii(0x15_2b83, 2); if(jzw(0x15_2baf, 0x2a)) goto l_0x15_2baf; /* jz 0x2baf */
            ii(0x15_2b85, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2b87, 2); if(jzw(0x15_2b40, -0x49)) goto l_0x15_2b40; /* jz 0x2b40 */
            ii(0x15_2b89, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2b8b, 2); if(jzw(0x15_2b90, 0x3)) goto l_0x15_2b90; /* jz 0x2b90 */
            ii(0x15_2b8d, 1); stosb_a16();                              /* stosb */
            ii(0x15_2b8e, 2); jmpw(0x15_2b7c, -0x14); goto l_0x15_2b7c; /* jmp 0x2b7c */
        l_0x15_2b90:
            ii(0x15_2b90, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x15_2b92:
            ii(0x15_2b92, 1); inc(cx);                                  /* inc cx */
            ii(0x15_2b93, 1); lodsb_a16();                              /* lodsb */
            ii(0x15_2b94, 2); cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x15_2b96, 2); if(jzw(0x15_2b92, -0x6)) goto l_0x15_2b92; /* jz 0x2b92 */
            ii(0x15_2b98, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x15_2b9a, 2); if(jzw(0x15_2ba2, 0x6)) goto l_0x15_2ba2; /* jz 0x2ba2 */
            ii(0x15_2b9c, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x15_2b9e, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x15_2ba0, 2); jmpw(0x15_2b7b, -0x27); goto l_0x15_2b7b; /* jmp 0x2b7b */
        l_0x15_2ba2:
            ii(0x15_2ba2, 2); mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x15_2ba4, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x15_2ba6, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x15_2ba8, 2); if(jaew(0x15_2b40, -0x6a)) goto l_0x15_2b40; /* jae 0x2b40 */
            ii(0x15_2baa, 2); mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x15_2bac, 1); stosb_a16();                              /* stosb */
            ii(0x15_2bad, 2); jmpw(0x15_2b7c, -0x33); goto l_0x15_2b7c; /* jmp 0x2b7c */
        l_0x15_2baf:
            ii(0x15_2baf, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_2bb1, 1); stosb_a16();                              /* stosb */
        l_0x15_2bb2:
            ii(0x15_2bb2, 1); pushw(ss);                                /* push ss */
            ii(0x15_2bb3, 1); popw(ds);                                 /* pop ds */
            ii(0x15_2bb4, 4); mov(memw_a16[ds, bx], 0);                 /* mov word [bx], 0x0 */
            ii(0x15_2bb8, 5); mov(memw_a16[ds, bx + 0x2], 0);           /* mov word [bx+0x2], 0x0 */
            ii(0x15_2bbd, 4); if(jmpw_a16_far_ind(ds, 0x3c50)) return;  /* jmp far word [0x3c50] */
        }
    }
}
