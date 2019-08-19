using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4ac4-47d429be")]
        public void Method_0017_4ac4()
        {
            ii(0x17_4ac4, 4); enterw(0x36, 0);                          /* enter 0x36, 0x0 */
            ii(0x17_4ac8, 1); pushw(ds);                                /* push ds */
            ii(0x17_4ac9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4acc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4ace, 5); mov(memw_a16[ss, bp - 0x30], 0x1028);     /* mov word [bp-0x30], 0x1028 */
            ii(0x17_4ad3, 5); mov(memw_a16[ss, bp - 0x2e], 0x3e58);     /* mov word [bp-0x2e], 0x3e58 */
            ii(0x17_4ad8, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x17_4add, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_4adf, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_4ae2, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_4ae5, 3); pushw(0xef);                              /* push 0xef */
            ii(0x17_4ae8, 1); pushw(ds);                                /* push ds */
            ii(0x17_4ae9, 3); pushw(0xe9);                              /* push 0xe9 */
            ii(0x17_4aec, 1); nop();                                    /* nop */
            ii(0x17_4aed, 1); pushw(cs);                                /* push cs */
            ii(0x17_4aee, 3); callw(0x16_fb2a, -0x4fc7);                /* call 0xfb2a */
            ii(0x17_4af1, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x17_4af4, 1); pushw(ax);                                /* push ax */
            ii(0x17_4af5, 1); nop();                                    /* nop */
            ii(0x17_4af6, 1); pushw(cs);                                /* push cs */
            ii(0x17_4af7, 3); callw(0x16_dbe0, -0x6f1a);                /* call 0xdbe0 */
            ii(0x17_4afa, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4afd, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4aff, 2); if(jnzw(0x17_4b13, 0x12)) goto l_0x17_4b13; /* jnz 0x4b13 */
            ii(0x17_4b01, 3); pushw(0xf4);                              /* push 0xf4 */
            ii(0x17_4b04, 3); pushw(memw_a16[ss, bp - 0x2c]);           /* push word [bp-0x2c] */
            ii(0x17_4b07, 1); nop();                                    /* nop */
            ii(0x17_4b08, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b09, 3); callw(0x16_dbe0, -0x6f2c);                /* call 0xdbe0 */
            ii(0x17_4b0c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4b0f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4b11, 2); if(jzw(0x17_4b18, 0x5)) goto l_0x17_4b18; /* jz 0x4b18 */
        l_0x17_4b13:
            ii(0x17_4b13, 5); or(memb_a16[ds, 0x19a2], 0x1);            /* or byte [0x19a2], 0x1 */
        l_0x17_4b18:
            ii(0x17_4b18, 1); pushw(ds);                                /* push ds */
            ii(0x17_4b19, 3); pushw(0xf9);                              /* push 0xf9 */
            ii(0x17_4b1c, 1); nop();                                    /* nop */
            ii(0x17_4b1d, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b1e, 3); callw(0x17_0e96, -0x3c8b);                /* call 0xe96 */
            ii(0x17_4b21, 1); pushw(ds);                                /* push ds */
            ii(0x17_4b22, 3); pushw(0xfd);                              /* push 0xfd */
            ii(0x17_4b25, 1); nop();                                    /* nop */
            ii(0x17_4b26, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b27, 3); callw(0x17_104f, -0x3adb);                /* call 0x104f */
            ii(0x17_4b2a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4b2d, 6); mov(memw_a16[ds, 0x1412], 0);             /* mov word [0x1412], 0x0 */
            ii(0x17_4b33, 4); mov(es, memw_a16[ds, 0x1dc8]);            /* mov es, [0x1dc8] */
            ii(0x17_4b37, 6); cmp(memb_a16[es, 0x2e], 0);               /* cmp byte [es:0x2e], 0x0 */
            ii(0x17_4b3d, 2); if(jnzw(0x17_4b46, 0x7)) goto l_0x17_4b46; /* jnz 0x4b46 */
            ii(0x17_4b3f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_4b41, 1); cwd();                                    /* cwd */
            ii(0x17_4b42, 3); jmpw(0x17_4d36, 0x1f1); goto l_0x17_4d36; /* jmp 0x4d36 */
        //  ii(0x17_4b45, 1); Недостижимый код.
        l_0x17_4b46:
            ii(0x17_4b46, 1); nop();                                    /* nop */
            ii(0x17_4b47, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b48, 3); callw(0x17_06b4, -0x4497);                /* call 0x6b4 */
            ii(0x17_4b4b, 5); cmp(memb_a16[ds, 0x90], 0);               /* cmp byte [0x90], 0x0 */
            ii(0x17_4b50, 2); if(jzw(0x17_4b5a, 0x8)) goto l_0x17_4b5a; /* jz 0x4b5a */
            ii(0x17_4b52, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4b55, 1); cwd();                                    /* cwd */
            ii(0x17_4b56, 3); jmpw(0x17_4d36, 0x1dd); goto l_0x17_4d36; /* jmp 0x4d36 */
        //  ii(0x17_4b59, 1); Недостижимый код.
        l_0x17_4b5a:
            ii(0x17_4b5a, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b5b, 3); callw(0x17_5242, 0x6e4);                  /* call 0x5242 */
            ii(0x17_4b5e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4b60, 2); if(jzw(0x17_4b6a, 0x8)) goto l_0x17_4b6a; /* jz 0x4b6a */
            ii(0x17_4b62, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4b65, 1); cwd();                                    /* cwd */
            ii(0x17_4b66, 3); jmpw(0x17_4d36, 0x1cd); goto l_0x17_4d36; /* jmp 0x4d36 */
        //  ii(0x17_4b69, 1); Недостижимый код.
        l_0x17_4b6a:
            ii(0x17_4b6a, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x17_4b6d, 1); nop();                                    /* nop */
            ii(0x17_4b6e, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b6f, 3); callw(0x16_db16, -0x705c);                /* call 0xdb16 */
            ii(0x17_4b72, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_4b75, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_4b78, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4b7a, 2); if(jzw(0x17_4b80, 0x4)) goto l_0x17_4b80; /* jz 0x4b80 */
            ii(0x17_4b7c, 1); dec(ax);                                  /* dec ax */
            ii(0x17_4b7d, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
        l_0x17_4b80:
            ii(0x17_4b80, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_4b82, 5); cmp(memb_a16[ds, bx + 0x3c], 0x5c);       /* cmp byte [bx+0x3c], 0x5c */
            ii(0x17_4b87, 2); if(jnzw(0x17_4b8e, 0x5)) goto l_0x17_4b8e; /* jnz 0x4b8e */
            ii(0x17_4b89, 5); mov(memb_a16[ds, bx + 0x3c], 0);          /* mov byte [bx+0x3c], 0x0 */
        l_0x17_4b8e:
            ii(0x17_4b8e, 1); pushw(ds);                                /* push ds */
            ii(0x17_4b8f, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x17_4b92, 1); nop();                                    /* nop */
            ii(0x17_4b93, 1); pushw(cs);                                /* push cs */
            ii(0x17_4b94, 3); callw(0x17_911c, 0x4585);                 /* call 0x911c */
            ii(0x17_4b97, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4b9a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4b9c, 2); if(jzw(0x17_4ba8, 0xa)) goto l_0x17_4ba8; /* jz 0x4ba8 */
            ii(0x17_4b9e, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x17_4ba1, 1); pushw(cs);                                /* push cs */
            ii(0x17_4ba2, 3); callw(0x17_4a4e, -0x157);                 /* call 0x4a4e */
            ii(0x17_4ba5, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x17_4ba8:
            ii(0x17_4ba8, 5); cmp(memb_a16[ds, 0x39], 0);               /* cmp byte [0x39], 0x0 */
            ii(0x17_4bad, 2); if(jzw(0x17_4bba, 0xb)) goto l_0x17_4bba; /* jz 0x4bba */
            ii(0x17_4baf, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x17_4bb2, 1); nop();                                    /* nop */
            ii(0x17_4bb3, 1); pushw(cs);                                /* push cs */
            ii(0x17_4bb4, 3); callw(0x16_dd6c, -0x6e4b);                /* call 0xdd6c */
            ii(0x17_4bb7, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x17_4bba:
            ii(0x17_4bba, 5); cmp(memb_a16[ds, 0x3d], 0x3a);            /* cmp byte [0x3d], 0x3a */
            ii(0x17_4bbf, 2); if(jzw(0x17_4bc8, 0x7)) goto l_0x17_4bc8; /* jz 0x4bc8 */
            ii(0x17_4bc1, 4); mov(memb_a16[ss, bp - 0x1e], 0);          /* mov byte [bp-0x1e], 0x0 */
            ii(0x17_4bc5, 2); jmpw(0x17_4bd0, 0x9); goto l_0x17_4bd0;   /* jmp 0x4bd0 */
        //  ii(0x17_4bc7, 1); Недостижимый код.
        l_0x17_4bc8:
            ii(0x17_4bc8, 3); mov(al, memb_a16[ds, 0x3c]);              /* mov al, [0x3c] */
            ii(0x17_4bcb, 2); and(al, 0x1f);                            /* and al, 0x1f */
            ii(0x17_4bcd, 3); mov(memb_a16[ss, bp - 0x1e], al);         /* mov [bp-0x1e], al */
        l_0x17_4bd0:
            ii(0x17_4bd0, 3); mov(al, memb_a16[ss, bp - 0x1e]);         /* mov al, [bp-0x1e] */
            ii(0x17_4bd3, 1); pushw(ax);                                /* push ax */
            ii(0x17_4bd4, 1); pushw(cs);                                /* push cs */
            ii(0x17_4bd5, 3); callw(0x17_4a08, -0x1d0);                 /* call 0x4a08 */
            ii(0x17_4bd8, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_4bdb, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_4bde, 3); mov(memw_a16[ss, bp - 0x20], dx);         /* mov [bp-0x20], dx */
            ii(0x17_4be1, 4); cmp(memw_a16[ds, 0x12], dx);              /* cmp [0x12], dx */
            ii(0x17_4be5, 2); if(jbw(0x17_4c22, 0x3b)) goto l_0x17_4c22; /* jb 0x4c22 */
            ii(0x17_4be7, 2); if(jaw(0x17_4bef, 0x6)) goto l_0x17_4bef; /* ja 0x4bef */
            ii(0x17_4be9, 4); cmp(memw_a16[ds, 0x10], ax);              /* cmp [0x10], ax */
            ii(0x17_4bed, 2); if(jbew(0x17_4c22, 0x33)) goto l_0x17_4c22; /* jbe 0x4c22 */
        l_0x17_4bef:
            ii(0x17_4bef, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_4bf1, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_4bf3, 3); mov(ax, memw_a16[ds, 0x10]);              /* mov ax, [0x10] */
            ii(0x17_4bf6, 4); mov(dx, memw_a16[ds, 0x12]);              /* mov dx, [0x12] */
            ii(0x17_4bfa, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_4bfc, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x17_4bfe, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_4c00, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_4c02, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_4c04, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_4c06, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_4c08, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_4c0a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_4c0c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_4c0e, 1); pushw(dx);                                /* push dx */
            ii(0x17_4c0f, 1); pushw(ax);                                /* push ax */
            ii(0x17_4c10, 3); pushw(0x97e);                             /* push 0x97e */
            ii(0x17_4c13, 1); pushw(cs);                                /* push cs */
            ii(0x17_4c14, 3); callw(0x17_75b4, 0x299d);                 /* call 0x75b4 */
            ii(0x17_4c17, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_4c1a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4c1d, 1); cwd();                                    /* cwd */
            ii(0x17_4c1e, 3); jmpw(0x17_4d36, 0x115); goto l_0x17_4d36; /* jmp 0x4d36 */
        //  ii(0x17_4c21, 1); Недостижимый код.
        l_0x17_4c22:
            ii(0x17_4c22, 4); sub(ax, memw_a16[ds, 0x10]);              /* sub ax, [0x10] */
            ii(0x17_4c26, 4); sbb(dx, memw_a16[ds, 0x12]);              /* sbb dx, [0x12] */
            ii(0x17_4c2a, 4); cmp(dx, memw_a16[ds, 0x2e]);              /* cmp dx, [0x2e] */
            ii(0x17_4c2e, 2); if(jaw(0x17_4c3f, 0xf)) goto l_0x17_4c3f; /* ja 0x4c3f */
            ii(0x17_4c30, 2); if(jbw(0x17_4c38, 0x6)) goto l_0x17_4c38; /* jb 0x4c38 */
            ii(0x17_4c32, 4); cmp(ax, memw_a16[ds, 0x2c]);              /* cmp ax, [0x2c] */
            ii(0x17_4c36, 2); if(jaew(0x17_4c3f, 0x7)) goto l_0x17_4c3f; /* jae 0x4c3f */
        l_0x17_4c38:
            ii(0x17_4c38, 3); mov(memw_a16[ds, 0x2c], ax);              /* mov [0x2c], ax */
            ii(0x17_4c3b, 4); mov(memw_a16[ds, 0x2e], dx);              /* mov [0x2e], dx */
        l_0x17_4c3f:
            ii(0x17_4c3f, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x17_4c42, 3); mov(dx, memw_a16[ss, bp - 0x20]);         /* mov dx, [bp-0x20] */
            ii(0x17_4c45, 4); sub(ax, memw_a16[ds, 0x10]);              /* sub ax, [0x10] */
            ii(0x17_4c49, 4); sbb(dx, memw_a16[ds, 0x12]);              /* sbb dx, [0x12] */
            ii(0x17_4c4d, 4); cmp(dx, memw_a16[ds, 0x16]);              /* cmp dx, [0x16] */
            ii(0x17_4c51, 2); if(jaw(0x17_4c94, 0x41)) goto l_0x17_4c94; /* ja 0x4c94 */
            ii(0x17_4c53, 2); if(jbw(0x17_4c5b, 0x6)) goto l_0x17_4c5b; /* jb 0x4c5b */
            ii(0x17_4c55, 4); cmp(ax, memw_a16[ds, 0x14]);              /* cmp ax, [0x14] */
            ii(0x17_4c59, 2); if(jaew(0x17_4c94, 0x39)) goto l_0x17_4c94; /* jae 0x4c94 */
        l_0x17_4c5b:
            ii(0x17_4c5b, 3); mov(ax, memw_a16[ds, 0x14]);              /* mov ax, [0x14] */
            ii(0x17_4c5e, 4); mov(dx, memw_a16[ds, 0x16]);              /* mov dx, [0x16] */
            ii(0x17_4c62, 3); sub(ax, memw_a16[ss, bp - 0x22]);         /* sub ax, [bp-0x22] */
            ii(0x17_4c65, 3); sbb(dx, memw_a16[ss, bp - 0x20]);         /* sbb dx, [bp-0x20] */
            ii(0x17_4c68, 4); add(ax, memw_a16[ds, 0x10]);              /* add ax, [0x10] */
            ii(0x17_4c6c, 4); adc(dx, memw_a16[ds, 0x12]);              /* adc dx, [0x12] */
            ii(0x17_4c70, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_4c72, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_4c74, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_4c76, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_4c78, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_4c7a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_4c7c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_4c7e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_4c80, 1); pushw(dx);                                /* push dx */
            ii(0x17_4c81, 1); pushw(ax);                                /* push ax */
            ii(0x17_4c82, 3); pushw(0x97a);                             /* push 0x97a */
            ii(0x17_4c85, 1); pushw(cs);                                /* push cs */
            ii(0x17_4c86, 3); callw(0x17_75b4, 0x292b);                 /* call 0x75b4 */
            ii(0x17_4c89, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_4c8c, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4c8f, 1); cwd();                                    /* cwd */
            ii(0x17_4c90, 3); jmpw(0x17_4d36, 0xa3); goto l_0x17_4d36;  /* jmp 0x4d36 */
        //  ii(0x17_4c93, 1); Недостижимый код.
        l_0x17_4c94:
            ii(0x17_4c94, 5); cmp(memw_a16[ds, 0x51a0], 0);             /* cmp word [0x51a0], 0x0 */
            ii(0x17_4c99, 2); if(jnzw(0x17_4caa, 0xf)) goto l_0x17_4caa; /* jnz 0x4caa */
            ii(0x17_4c9b, 1); pushw(cs);                                /* push cs */
            ii(0x17_4c9c, 3); callw(0x17_50b4, 0x415);                  /* call 0x50b4 */
            ii(0x17_4c9f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4ca1, 2); if(jzw(0x17_4caa, 0x7)) goto l_0x17_4caa; /* jz 0x4caa */
            ii(0x17_4ca3, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4ca6, 1); cwd();                                    /* cwd */
            ii(0x17_4ca7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4ca8, 1); leavew();                                 /* leave */
            ii(0x17_4ca9, 1); retfw(); return;                          /* retf */
        l_0x17_4caa:
            ii(0x17_4caa, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x17_4cad, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x17_4cb0, 1); nop();                                    /* nop */
            ii(0x17_4cb1, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cb2, 3); callw(0x16_ea4c, -0x6269);                /* call 0xea4c */
            ii(0x17_4cb5, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4cb8, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cb9, 3); callw(0x17_5aaa, 0xdee);                  /* call 0x5aaa */
            ii(0x17_4cbc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4cbe, 2); if(jzw(0x17_4cc8, 0x8)) goto l_0x17_4cc8; /* jz 0x4cc8 */
            ii(0x17_4cc0, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4cc3, 1); cwd();                                    /* cwd */
            ii(0x17_4cc4, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4cc5, 1); leavew();                                 /* leave */
            ii(0x17_4cc6, 1); retfw(); return;                          /* retf */
        //  ii(0x17_4cc7, 1); Недостижимый код.
        l_0x17_4cc8:
            ii(0x17_4cc8, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cc9, 3); callw(0x17_4f2e, 0x262);                  /* call 0x4f2e */
            ii(0x17_4ccc, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_4cd1, 2); if(jzw(0x17_4cd7, 0x4)) goto l_0x17_4cd7; /* jz 0x4cd7 */
            ii(0x17_4cd3, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cd4, 3); callw(0x17_6d30, 0x2059);                 /* call 0x6d30 */
        l_0x17_4cd7:
            ii(0x17_4cd7, 5); cmp(memb_a16[ds, 0x4], 0);                /* cmp byte [0x4], 0x0 */
            ii(0x17_4cdc, 2); if(jzw(0x17_4ce2, 0x4)) goto l_0x17_4ce2; /* jz 0x4ce2 */
            ii(0x17_4cde, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cdf, 3); callw(0x17_5122, 0x440);                  /* call 0x5122 */
        l_0x17_4ce2:
            ii(0x17_4ce2, 1); pushw(cs);                                /* push cs */
            ii(0x17_4ce3, 3); callw(0x17_4e9a, 0x1b4);                  /* call 0x4e9a */
            ii(0x17_4ce6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4ce8, 2); if(jzw(0x17_4cf2, 0x8)) goto l_0x17_4cf2; /* jz 0x4cf2 */
            ii(0x17_4cea, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4ced, 1); cwd();                                    /* cwd */
            ii(0x17_4cee, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4cef, 1); leavew();                                 /* leave */
            ii(0x17_4cf0, 1); retfw(); return;                          /* retf */
        //  ii(0x17_4cf1, 1); Недостижимый код.
        l_0x17_4cf2:
            ii(0x17_4cf2, 1); nop();                                    /* nop */
            ii(0x17_4cf3, 1); pushw(cs);                                /* push cs */
            ii(0x17_4cf4, 3); callw(0x17_c6f0, 0x79f9);                 /* call 0xc6f0 */
            ii(0x17_4cf7, 5); mov(memb_a16[ds, 0x90], 0x1);             /* mov byte [0x90], 0x1 */
            ii(0x17_4cfc, 3); mov(ax, memw_a16[ds, 0x982]);             /* mov ax, [0x982] */
            ii(0x17_4cff, 3); mov(memw_a16[ds, 0x5165], ax);            /* mov [0x5165], ax */
            ii(0x17_4d02, 1); nop();                                    /* nop */
            ii(0x17_4d03, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d04, 3); callw(0x17_8f00, 0x41f9);                 /* call 0x8f00 */
            ii(0x17_4d07, 6); mov(memw_a16[ds, 0x513f], 0x1ffe);        /* mov word [0x513f], 0x1ffe */
            ii(0x17_4d0d, 3); mov(memw_a16[ds, 0x5141], ax);            /* mov [0x5141], ax */
            ii(0x17_4d10, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d11, 3); callw(0x17_4820, -0x4f4);                 /* call 0x4820 */
            ii(0x17_4d14, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d15, 3); callw(0x17_4fae, 0x296);                  /* call 0x4fae */
            ii(0x17_4d18, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4d1a, 2); if(jzw(0x17_4d24, 0x8)) goto l_0x17_4d24; /* jz 0x4d24 */
            ii(0x17_4d1c, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4d1f, 1); cwd();                                    /* cwd */
            ii(0x17_4d20, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4d21, 1); leavew();                                 /* leave */
            ii(0x17_4d22, 1); retfw(); return;                          /* retf */
        //  ii(0x17_4d23, 1); Недостижимый код.
        l_0x17_4d24:
            ii(0x17_4d24, 1); pushw(ds);                                /* push ds */
            ii(0x17_4d25, 3); pushw(0x122);                             /* push 0x122 */
            ii(0x17_4d28, 1); nop();                                    /* nop */
            ii(0x17_4d29, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d2a, 3); callw(0x17_104f, -0x3cde);                /* call 0x104f */
            ii(0x17_4d2d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4d30, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_4d32, 1); cwd();                                    /* cwd */
            ii(0x17_4d33, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4d34, 1); leavew();                                 /* leave */
            ii(0x17_4d35, 1); retfw(); return;                          /* retf */
        l_0x17_4d36:
            ii(0x17_4d36, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4d37, 1); leavew();                                 /* leave */
            ii(0x17_4d38, 1); retfw(); return;                          /* retf */
        }
    }
}
