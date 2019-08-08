using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d7a7953f-417f-45c8-82a3-7d8eadb1faf7")]
        public void Method_0013_5aaa()
        {
            ii(0x13_5aaa, 4); enterw(0x36, 0);                          /* enter 0x36, 0x0 */
            ii(0x13_5aae, 1); pushw(di);                                /* push di */
            ii(0x13_5aaf, 1); pushw(si);                                /* push si */
            ii(0x13_5ab0, 1); pushw(ds);                                /* push ds */
            ii(0x13_5ab1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_5ab4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_5ab6, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x13_5ab8, 1); nop();                                    /* nop */
            ii(0x13_5ab9, 1); pushw(cs);                                /* push cs */
            ii(0x13_5aba, 3); callw(0x12_e77a, -0x7343);                /* call 0xe77a */
            ii(0x13_5abd, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5ac0, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_5ac3, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_5ac6, 1); nop();                                    /* nop */
            ii(0x13_5ac7, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ac8, 3); callw(0x12_e7a8, -0x7323);                /* call 0xe7a8 */
            ii(0x13_5acb, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5ace, 3); mov(memw_a16[ds, 0x4f80], ax);            /* mov [0x4f80], ax */
            ii(0x13_5ad1, 4); mov(memw_a16[ds, 0x4f82], dx);            /* mov [0x4f82], dx */
            ii(0x13_5ad5, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_5ad7, 4); or(ax, memw_a16[ds, 0x4f80]);             /* or ax, [0x4f80] */
            ii(0x13_5adb, 2); if(jnzw(0x13_5afc, 0x1f)) goto l_0x13_5afc; /* jnz 0x5afc */
            ii(0x13_5add, 1); pushw(ds);                                /* push ds */
            ii(0x13_5ade, 3); pushw(0x358);                             /* push 0x358 */
            ii(0x13_5ae1, 3); pushw(0x90a);                             /* push 0x90a */
            ii(0x13_5ae4, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ae5, 3); callw(0x13_75b4, 0x1acc);                 /* call 0x75b4 */
            ii(0x13_5ae8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5aeb, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_5aee, 1); nop();                                    /* nop */
            ii(0x13_5aef, 1); pushw(cs);                                /* push cs */
            ii(0x13_5af0, 3); callw(0x12_e77a, -0x7379);                /* call 0xe77a */
            ii(0x13_5af3, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5af6, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5af9, 3); jmpw(0x13_6154, 0x658); goto l_0x13_6154; /* jmp 0x6154 */
        l_0x13_5afc:
            ii(0x13_5afc, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x13_5b01, 2); if(jzw(0x13_5b22, 0x1f)) goto l_0x13_5b22; /* jz 0x5b22 */
            ii(0x13_5b03, 2); pushw(0x14);                              /* push 0x14 */
            ii(0x13_5b05, 1); nop();                                    /* nop */
            ii(0x13_5b06, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b07, 3); callw(0x12_e7a8, -0x7362);                /* call 0xe7a8 */
            ii(0x13_5b0a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5b0d, 3); mov(memw_a16[ds, 0x4fc4], ax);            /* mov [0x4fc4], ax */
            ii(0x13_5b10, 4); mov(memw_a16[ds, 0x4fc6], dx);            /* mov [0x4fc6], dx */
            ii(0x13_5b14, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_5b16, 4); or(ax, memw_a16[ds, 0x4fc4]);             /* or ax, [0x4fc4] */
            ii(0x13_5b1a, 2); if(jnzw(0x13_5b22, 0x6)) goto l_0x13_5b22; /* jnz 0x5b22 */
            ii(0x13_5b1c, 6); mov(memw_a16[ds, 0x984], 0);              /* mov word [0x984], 0x0 */
        l_0x13_5b22:
            ii(0x13_5b22, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x13_5b25, 1); nop();                                    /* nop */
            ii(0x13_5b26, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b27, 3); callw(0x12_e77a, -0x73b0);                /* call 0xe77a */
            ii(0x13_5b2a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5b2d, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_5b30, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_5b34, 3); mov(memw_a16[ds, 0x4fd0], ax);            /* mov [0x4fd0], ax */
            ii(0x13_5b37, 4); mov(memw_a16[ds, 0x4fd2], dx);            /* mov [0x4fd2], dx */
            ii(0x13_5b3b, 3); mov(al, memb_a16[ds, 0x519d]);            /* mov al, [0x519d] */
            ii(0x13_5b3e, 3); shr(al, 0x2);                             /* shr al, 0x2 */
            ii(0x13_5b41, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_5b43, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_5b46, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5b48, 2); if(jnzw(0x13_5b50, 0x6)) goto l_0x13_5b50; /* jnz 0x5b50 */
            ii(0x13_5b4a, 1); inc(ax);                                  /* inc ax */
            ii(0x13_5b4b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_5b4e, 2); jmpw(0x13_5b5b, 0xb); goto l_0x13_5b5b;   /* jmp 0x5b5b */
        l_0x13_5b50:
            ii(0x13_5b50, 6); test(memw_a16[ds, 0x519c], 0x3ff);        /* test word [0x519c], 0x3ff */
            ii(0x13_5b56, 2); if(jzw(0x13_5b5b, 0x3)) goto l_0x13_5b5b; /* jz 0x5b5b */
            ii(0x13_5b58, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
        l_0x13_5b5b:
            ii(0x13_5b5b, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x13_5b5e, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b5f, 3); callw(0x13_7476, 0x1914);                 /* call 0x7476 */
            ii(0x13_5b62, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5b65, 3); mov(memw_a16[ds, 0x4fe4], ax);            /* mov [0x4fe4], ax */
            ii(0x13_5b68, 4); mov(memw_a16[ds, 0x4fe6], dx);            /* mov [0x4fe6], dx */
            ii(0x13_5b6c, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_5b6e, 4); or(ax, memw_a16[ds, 0x4fe4]);             /* or ax, [0x4fe4] */
            ii(0x13_5b72, 2); if(jnzw(0x13_5b88, 0x14)) goto l_0x13_5b88; /* jnz 0x5b88 */
            ii(0x13_5b74, 1); pushw(ds);                                /* push ds */
            ii(0x13_5b75, 3); pushw(0x364);                             /* push 0x364 */
            ii(0x13_5b78, 3); pushw(0x90a);                             /* push 0x90a */
            ii(0x13_5b7b, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b7c, 3); callw(0x13_75b4, 0x1a35);                 /* call 0x75b4 */
            ii(0x13_5b7f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5b82, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5b85, 3); jmpw(0x13_6154, 0x5cc); goto l_0x13_6154; /* jmp 0x6154 */
        l_0x13_5b88:
            ii(0x13_5b88, 5); cmp(memw_a16[ds, 0x51a0], 0);             /* cmp word [0x51a0], 0x0 */
            ii(0x13_5b8d, 2); if(jnzw(0x13_5bae, 0x1f)) goto l_0x13_5bae; /* jnz 0x5bae */
            ii(0x13_5b8f, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b90, 3); callw(0x13_6b2c, 0xf99);                  /* call 0x6b2c */
            ii(0x13_5b93, 3); mov(memw_a16[ds, 0x992], ax);             /* mov [0x992], ax */
            ii(0x13_5b96, 4); mov(memw_a16[ds, 0x994], dx);             /* mov [0x994], dx */
            ii(0x13_5b9a, 1); pushw(cs);                                /* push cs */
            ii(0x13_5b9b, 3); callw(0x13_564a, -0x554);                 /* call 0x564a */
            ii(0x13_5b9e, 3); mov(ax, memw_a16[ds, 0x4fe4]);            /* mov ax, [0x4fe4] */
            ii(0x13_5ba1, 4); mov(dx, memw_a16[ds, 0x4fe6]);            /* mov dx, [0x4fe6] */
            ii(0x13_5ba5, 3); mov(memw_a16[ds, 0x4fe8], ax);            /* mov [0x4fe8], ax */
            ii(0x13_5ba8, 4); mov(memw_a16[ds, 0x4fea], dx);            /* mov [0x4fea], dx */
            ii(0x13_5bac, 2); jmpw(0x13_5c20, 0x72); goto l_0x13_5c20;  /* jmp 0x5c20 */
        l_0x13_5bae:
            ii(0x13_5bae, 3); pushw(0x2000);                            /* push 0x2000 */
            ii(0x13_5bb1, 4); les(bx, ds, 0x2018);                      /* les bx, [0x2018] */
            ii(0x13_5bb5, 4); mov(ax, memw_a16[es, bx + 0x12]);         /* mov ax, [es:bx+0x12] */
            ii(0x13_5bb9, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_5bbb, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5bbd, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5bbf, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5bc1, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5bc3, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5bc5, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5bc7, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5bc9, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5bcb, 1); pushw(dx);                                /* push dx */
            ii(0x13_5bcc, 1); pushw(ax);                                /* push ax */
            ii(0x13_5bcd, 1); nop();                                    /* nop */
            ii(0x13_5bce, 1); pushw(cs);                                /* push cs */
            ii(0x13_5bcf, 3); callw(0x12_e96a, -0x7268);                /* call 0xe96a */
            ii(0x13_5bd2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5bd5, 3); mov(memw_a16[ds, 0x992], ax);             /* mov [0x992], ax */
            ii(0x13_5bd8, 4); mov(memw_a16[ds, 0x994], dx);             /* mov [0x994], dx */
            ii(0x13_5bdc, 4); pushw(memw_a16[ds, 0x4fe6]);              /* push word [0x4fe6] */
            ii(0x13_5be0, 4); pushw(memw_a16[ds, 0x4fe4]);              /* push word [0x4fe4] */
            ii(0x13_5be4, 1); pushw(cs);                                /* push cs */
            ii(0x13_5be5, 3); callw(0x13_567a, -0x56e);                 /* call 0x567a */
            ii(0x13_5be8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5beb, 3); mov(memw_a16[ds, 0x4fe8], ax);            /* mov [0x4fe8], ax */
            ii(0x13_5bee, 4); mov(memw_a16[ds, 0x4fea], dx);            /* mov [0x4fea], dx */
            ii(0x13_5bf2, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x13_5bf7, 2); jmpw(0x13_5bfd, 0x4); goto l_0x13_5bfd;   /* jmp 0x5bfd */
        //    ii(0x13_5bf9, 1); nop();                                    /* nop */
        l_0x13_5bfa:
            ii(0x13_5bfa, 3); inc(memw_a16[ss, bp - 0x14]);             /* inc word [bp-0x14] */
        l_0x13_5bfd:
            ii(0x13_5bfd, 5); cmp(memw_a16[ss, bp - 0x14], 0x400);      /* cmp word [bp-0x14], 0x400 */
            ii(0x13_5c02, 2); if(jaew(0x13_5c20, 0x1c)) goto l_0x13_5c20; /* jae 0x5c20 */
            ii(0x13_5c04, 3); mov(bx, memw_a16[ss, bp - 0x14]);         /* mov bx, [bp-0x14] */
            ii(0x13_5c07, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_5c0a, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_5c0e, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_5c11, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_5c15, 4); mov(memw_a16[ds, bx + 0x3f60], ax);       /* mov [bx+0x3f60], ax */
            ii(0x13_5c19, 4); mov(memw_a16[ds, bx + 0x3f62], dx);       /* mov [bx+0x3f62], dx */
            ii(0x13_5c1d, 2); jmpw(0x13_5bfa, -0x25); goto l_0x13_5bfa; /* jmp 0x5bfa */
        //    ii(0x13_5c1f, 1); nop();                                    /* nop */
        l_0x13_5c20:
            ii(0x13_5c20, 3); mov(ax, memw_a16[ds, 0x4fe8]);            /* mov ax, [0x4fe8] */
            ii(0x13_5c23, 4); mov(dx, memw_a16[ds, 0x4fea]);            /* mov dx, [0x4fea] */
            ii(0x13_5c27, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_5c29, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_5c2b, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_5c2d, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_5c2f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5c31, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5c33, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5c35, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5c37, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5c39, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5c3b, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5c3d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5c3f, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_5c42, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_5c45, 5); mov(memw_a16[ss, bp - 0x36], 0x3fc);      /* mov word [bp-0x36], 0x3fc */
            ii(0x13_5c4a, 5); mov(memw_a16[ss, bp - 0x34], 0);          /* mov word [bp-0x34], 0x0 */
            ii(0x13_5c4f, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x13_5c54, 2); jmpw(0x13_5c69, 0x13); goto l_0x13_5c69;  /* jmp 0x5c69 */
        l_0x13_5c56:
            ii(0x13_5c56, 3); inc(memw_a16[ss, bp - 0x14]);             /* inc word [bp-0x14] */
            ii(0x13_5c59, 4); add(memw_a16[ss, bp - 0xa], 0x1);         /* add word [bp-0xa], 0x1 */
            ii(0x13_5c5d, 4); adc(memw_a16[ss, bp - 0x8], 0);           /* adc word [bp-0x8], 0x0 */
            ii(0x13_5c61, 4); add(memw_a16[ss, bp - 0x36], 0x1);        /* add word [bp-0x36], 0x1 */
            ii(0x13_5c65, 4); adc(memw_a16[ss, bp - 0x34], 0);          /* adc word [bp-0x34], 0x0 */
        l_0x13_5c69:
            ii(0x13_5c69, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_5c6c, 3); cmp(memw_a16[ss, bp - 0x14], ax);         /* cmp [bp-0x14], ax */
            ii(0x13_5c6f, 2); if(jaew(0x13_5cca, 0x59)) goto l_0x13_5cca; /* jae 0x5cca */
            ii(0x13_5c71, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_5c74, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x13_5c77, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5c79, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5c7b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5c7d, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5c7f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5c81, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5c83, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5c85, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5c87, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5c89, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5c8b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5c8d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5c8f, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_5c91, 3); mov(bx, memw_a16[ss, bp - 0x36]);         /* mov bx, [bp-0x36] */
            ii(0x13_5c94, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_5c97, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_5c9b, 3); xor(ax, memw_a16[es, bx + si]);           /* xor ax, [es:bx+si] */
            ii(0x13_5c9e, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_5ca1, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_5ca3, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_5ca5, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x13_5ca7, 2); xor(di, dx);                              /* xor di, dx */
            ii(0x13_5ca9, 3); mov(memw_a16[es, bx + si], cx);           /* mov [es:bx+si], cx */
            ii(0x13_5cac, 4); mov(memw_a16[es, bx + si + 0x2], di);     /* mov [es:bx+si+0x2], di */
            ii(0x13_5cb0, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_5cb4, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
            ii(0x13_5cb8, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_5cbc, 4); or(memb_a16[es, bx + si], 0x2);           /* or byte [es:bx+si], 0x2 */
            ii(0x13_5cc0, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_5cc4, 4); or(memb_a16[es, bx + si], 0x4);           /* or byte [es:bx+si], 0x4 */
            ii(0x13_5cc8, 2); jmpw(0x13_5c56, -0x74); goto l_0x13_5c56; /* jmp 0x5c56 */
        l_0x13_5cca:
            ii(0x13_5cca, 1); nop();                                    /* nop */
            ii(0x13_5ccb, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ccc, 3); callw(0x13_8e97, 0x31c8);                 /* call 0x8e97 */
            ii(0x13_5ccf, 3); mov(ah, memb_a16[ss, bp - 0x6]);          /* mov ah, [bp-0x6] */
            ii(0x13_5cd2, 3); shl(ah, 0x4);                             /* shl ah, 0x4 */
            ii(0x13_5cd5, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5cd7, 1); pushw(ax);                                /* push ax */
            ii(0x13_5cd8, 4); pushw(memw_a16[ds, 0x4fe6]);              /* push word [0x4fe6] */
            ii(0x13_5cdc, 4); pushw(memw_a16[ds, 0x4fe4]);              /* push word [0x4fe4] */
            ii(0x13_5ce0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_5ce2, 1); nop();                                    /* nop */
            ii(0x13_5ce3, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ce4, 3); callw(0x12_e96a, -0x737d);                /* call 0xe96a */
            ii(0x13_5ce7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5cea, 3); mov(memw_a16[ds, 0x4fec], ax);            /* mov [0x4fec], ax */
            ii(0x13_5ced, 4); mov(memw_a16[ds, 0x4fee], dx);            /* mov [0x4fee], dx */
            ii(0x13_5cf1, 1); pushw(si);                                /* push si */
            ii(0x13_5cf2, 1); pushw(dx);                                /* push dx */
            ii(0x13_5cf3, 1); pushw(ax);                                /* push ax */
            ii(0x13_5cf4, 1); nop();                                    /* nop */
            ii(0x13_5cf5, 1); pushw(cs);                                /* push cs */
            ii(0x13_5cf6, 3); callw(0x13_8ed0, 0x31d7);                 /* call 0x8ed0 */
            ii(0x13_5cf9, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5cfc, 3); mov(ax, memw_a16[ds, 0x519c]);            /* mov ax, [0x519c] */
            ii(0x13_5cff, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_5d02, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
            ii(0x13_5d07, 5); mov(memw_a16[ss, bp - 0x28], 0xff00);     /* mov word [bp-0x28], 0xff00 */
            ii(0x13_5d0c, 1); nop();                                    /* nop */
            ii(0x13_5d0d, 1); pushw(cs);                                /* push cs */
            ii(0x13_5d0e, 3); callw(0x12_e82c, -0x74e5);                /* call 0xe82c */
            ii(0x13_5d11, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_5d13, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_5d15, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_5d17, 2); shl(dh, 0x1);                             /* shl dh, 1 */
            ii(0x13_5d19, 2); sbb(dh, dh);                              /* sbb dh, dh */
            ii(0x13_5d1b, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_5d1d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5d1f, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_5d21, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5d23, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x13_5d26, 3); mov(memw_a16[ss, bp - 0x22], dx);         /* mov [bp-0x22], dx */
            ii(0x13_5d29, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_5d2b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_5d2d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_5d2f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_5d31, 3); sub(memw_a16[ss, bp - 0x24], ax);         /* sub [bp-0x24], ax */
            ii(0x13_5d34, 3); sbb(memw_a16[ss, bp - 0x22], dx);         /* sbb [bp-0x22], dx */
            ii(0x13_5d37, 3); mov(ax, memw_a16[ds, 0x30]);              /* mov ax, [0x30] */
            ii(0x13_5d3a, 4); mov(dx, memw_a16[ds, 0x32]);              /* mov dx, [0x32] */
            ii(0x13_5d3e, 4); mov(cx, memw_a16[ds, 0x28]);              /* mov cx, [0x28] */
            ii(0x13_5d42, 4); mov(bx, memw_a16[ds, 0x2a]);              /* mov bx, [0x2a] */
            ii(0x13_5d46, 3); sub(memw_a16[ss, bp - 0x24], cx);         /* sub [bp-0x24], cx */
            ii(0x13_5d49, 3); sbb(memw_a16[ss, bp - 0x22], bx);         /* sbb [bp-0x22], bx */
            ii(0x13_5d4c, 3); cmp(memw_a16[ss, bp - 0x22], dx);         /* cmp [bp-0x22], dx */
            ii(0x13_5d4f, 2); if(jbw(0x13_5d5e, 0xd)) goto l_0x13_5d5e; /* jb 0x5d5e */
            ii(0x13_5d51, 2); if(jaw(0x13_5d58, 0x5)) goto l_0x13_5d58; /* ja 0x5d58 */
            ii(0x13_5d53, 3); cmp(memw_a16[ss, bp - 0x24], ax);         /* cmp [bp-0x24], ax */
            ii(0x13_5d56, 2); if(jbew(0x13_5d5e, 0x6)) goto l_0x13_5d5e; /* jbe 0x5d5e */
        l_0x13_5d58:
            ii(0x13_5d58, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x13_5d5b, 3); mov(memw_a16[ss, bp - 0x22], dx);         /* mov [bp-0x22], dx */
        l_0x13_5d5e:
            ii(0x13_5d5e, 3); mov(ax, memw_a16[ss, bp - 0x24]);         /* mov ax, [bp-0x24] */
            ii(0x13_5d61, 3); mov(dx, memw_a16[ss, bp - 0x22]);         /* mov dx, [bp-0x22] */
            ii(0x13_5d64, 4); cmp(memw_a16[ds, 0x36], dx);              /* cmp [0x36], dx */
            ii(0x13_5d68, 2); if(jbw(0x13_5d84, 0x1a)) goto l_0x13_5d84; /* jb 0x5d84 */
            ii(0x13_5d6a, 2); if(jaw(0x13_5d72, 0x6)) goto l_0x13_5d72; /* ja 0x5d72 */
            ii(0x13_5d6c, 4); cmp(memw_a16[ds, 0x34], ax);              /* cmp [0x34], ax */
            ii(0x13_5d70, 2); if(jbew(0x13_5d84, 0x12)) goto l_0x13_5d84; /* jbe 0x5d84 */
        l_0x13_5d72:
            ii(0x13_5d72, 3); pushw(0x90e);                             /* push 0x90e */
            ii(0x13_5d75, 1); pushw(cs);                                /* push cs */
            ii(0x13_5d76, 3); callw(0x13_75b4, 0x183b);                 /* call 0x75b4 */
            ii(0x13_5d79, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5d7c, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5d7f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5d80, 1); popw(si);                                 /* pop si */
            ii(0x13_5d81, 1); popw(di);                                 /* pop di */
            ii(0x13_5d82, 1); leavew();                                 /* leave */
            ii(0x13_5d83, 1); retfw(); return;                          /* retf */
        l_0x13_5d84:
            ii(0x13_5d84, 2); and(al, 0xfc);                            /* and al, 0xfc */
            ii(0x13_5d86, 3); and(dx, 0x3f);                            /* and dx, 0x3f */
            ii(0x13_5d89, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5d8b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5d8d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_5d8f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_5d91, 1); pushw(dx);                                /* push dx */
            ii(0x13_5d92, 1); pushw(ax);                                /* push ax */
            ii(0x13_5d93, 1); pushw(cs);                                /* push cs */
            ii(0x13_5d94, 3); callw(0x13_6260, 0x4c9);                  /* call 0x6260 */
            ii(0x13_5d97, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5d9a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5d9c, 2); if(jzw(0x13_5da6, 0x8)) goto l_0x13_5da6; /* jz 0x5da6 */
            ii(0x13_5d9e, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5da1, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5da2, 1); popw(si);                                 /* pop si */
            ii(0x13_5da3, 1); popw(di);                                 /* pop di */
            ii(0x13_5da4, 1); leavew();                                 /* leave */
            ii(0x13_5da5, 1); retfw(); return;                          /* retf */
        l_0x13_5da6:
            ii(0x13_5da6, 5); mov(memw_a16[ss, bp - 0x1a], 0x1);        /* mov word [bp-0x1a], 0x1 */
            ii(0x13_5dab, 2); jmpw(0x13_5db1, 0x4); goto l_0x13_5db1;   /* jmp 0x5db1 */
        //    ii(0x13_5dad, 1); nop();                                    /* nop */
        l_0x13_5dae:
            ii(0x13_5dae, 3); inc(memw_a16[ss, bp - 0x1a]);             /* inc word [bp-0x1a] */
        l_0x13_5db1:
            ii(0x13_5db1, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_5db4, 3); cmp(memw_a16[ss, bp - 0x1a], ax);         /* cmp [bp-0x1a], ax */
            ii(0x13_5db7, 2); if(jaw(0x13_5e28, 0x6f)) goto l_0x13_5e28; /* ja 0x5e28 */
            ii(0x13_5db9, 1); pushw(cs);                                /* push cs */
            ii(0x13_5dba, 3); callw(0x13_615a, 0x39d);                  /* call 0x615a */
            ii(0x13_5dbd, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_5dc0, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_5dc3, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x13_5dc5, 2); if(jnzw(0x13_5dde, 0x17)) goto l_0x13_5dde; /* jnz 0x5dde */
            ii(0x13_5dc7, 1); pushw(ds);                                /* push ds */
            ii(0x13_5dc8, 3); pushw(0x36e);                             /* push 0x36e */
            ii(0x13_5dcb, 3); pushw(0x90a);                             /* push 0x90a */
            ii(0x13_5dce, 1); pushw(cs);                                /* push cs */
            ii(0x13_5dcf, 3); callw(0x13_75b4, 0x17e2);                 /* call 0x75b4 */
            ii(0x13_5dd2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5dd5, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5dd8, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5dd9, 1); popw(si);                                 /* pop si */
            ii(0x13_5dda, 1); popw(di);                                 /* pop di */
            ii(0x13_5ddb, 1); leavew();                                 /* leave */
            ii(0x13_5ddc, 1); retfw(); return;                          /* retf */
        //  ii(0x13_5ddd, 1); Недостижимый код.
        l_0x13_5dde:
            ii(0x13_5dde, 3); mov(bx, memw_a16[ss, bp - 0x1a]);         /* mov bx, [bp-0x1a] */
            ii(0x13_5de1, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_5de4, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x13_5de8, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_5deb, 3); xor(ax, memw_a16[ss, bp - 0x4]);          /* xor ax, [bp-0x4] */
            ii(0x13_5dee, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_5df1, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_5df3, 3); xor(ax, memw_a16[ss, bp - 0x4]);          /* xor ax, [bp-0x4] */
            ii(0x13_5df6, 3); xor(dx, memw_a16[ss, bp - 0x2]);          /* xor dx, [bp-0x2] */
            ii(0x13_5df9, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_5dfc, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x13_5e00, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x13_5e04, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
            ii(0x13_5e08, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x13_5e0c, 4); or(memb_a16[es, bx + si], 0x2);           /* or byte [es:bx+si], 0x2 */
            ii(0x13_5e10, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x13_5e14, 4); or(memb_a16[es, bx + si], 0x4);           /* or byte [es:bx+si], 0x4 */
            ii(0x13_5e18, 1); nop();                                    /* nop */
            ii(0x13_5e19, 1); pushw(cs);                                /* push cs */
            ii(0x13_5e1a, 3); callw(0x13_8e97, 0x307a);                 /* call 0x8e97 */
            ii(0x13_5e1d, 5); add(memw_a16[ss, bp - 0x4], 0x1000);      /* add word [bp-0x4], 0x1000 */
            ii(0x13_5e22, 4); adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
            ii(0x13_5e26, 2); jmpw(0x13_5dae, -0x7a); goto l_0x13_5dae; /* jmp 0x5dae */
        l_0x13_5e28:
            ii(0x13_5e28, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x13_5e2a, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x13_5e2d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5e2f, 1); nop();                                    /* nop */
            ii(0x13_5e30, 1); pushw(cs);                                /* push cs */
            ii(0x13_5e31, 3); callw(0x12_e96a, -0x74ca);                /* call 0xe96a */
            ii(0x13_5e34, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_5e37, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x13_5e3a, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x13_5e3d, 3); mov(memw_a16[ds, 0x4ff0], ax);            /* mov [0x4ff0], ax */
            ii(0x13_5e40, 4); mov(memw_a16[ds, 0x4ff2], dx);            /* mov [0x4ff2], dx */
            ii(0x13_5e44, 3); pushw(0x80);                              /* push 0x80 */
            ii(0x13_5e47, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x13_5e4a, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_5e4d, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_5e4f, 1); pushw(dx);                                /* push dx */
            ii(0x13_5e50, 1); pushw(ax);                                /* push ax */
            ii(0x13_5e51, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x13_5e54, 1); pushw(dx);                                /* push dx */
            ii(0x13_5e55, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x13_5e58, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_5e5a, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_5e5c, 1); pushw(cs);                                /* push cs */
            ii(0x13_5e5d, 3); callw(0x13_621a, 0x3ba);                  /* call 0x621a */
            ii(0x13_5e60, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x13_5e63, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_5e65, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x13_5e67, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5e69, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5e6b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5e6d, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5e6f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5e71, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5e73, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5e75, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5e77, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5e79, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5e7b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5e7d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5e7f, 1); pushw(dx);                                /* push dx */
            ii(0x13_5e80, 1); pushw(ax);                                /* push ax */
            ii(0x13_5e81, 1); pushw(di);                                /* push di */
            ii(0x13_5e82, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_5e85, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x13_5e88, 1); nop();                                    /* nop */
            ii(0x13_5e89, 1); pushw(cs);                                /* push cs */
            ii(0x13_5e8a, 3); callw(0x13_925c, 0x33cf);                 /* call 0x925c */
            ii(0x13_5e8d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_5e90, 1); pushw(di);                                /* push di */
            ii(0x13_5e91, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_5e94, 3); mov(ax, memw_a16[ds, 0x34]);              /* mov ax, [0x34] */
            ii(0x13_5e97, 4); mov(dx, memw_a16[ds, 0x36]);              /* mov dx, [0x36] */
            ii(0x13_5e9b, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5e9d, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5e9f, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5ea1, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5ea3, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5ea5, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5ea7, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5ea9, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5eab, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_5eae, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x13_5eb1, 1); pushw(dx);                                /* push dx */
            ii(0x13_5eb2, 1); pushw(ax);                                /* push ax */
            ii(0x13_5eb3, 1); nop();                                    /* nop */
            ii(0x13_5eb4, 1); pushw(cs);                                /* push cs */
            ii(0x13_5eb5, 3); callw(0x13_dddc, 0x7f24);                 /* call 0xdddc */
            ii(0x13_5eb8, 3); mov(memw_a16[ds, 0xa6], ax);              /* mov [0xa6], ax */
            ii(0x13_5ebb, 4); mov(memw_a16[ds, 0xa8], dx);              /* mov [0xa8], dx */
            ii(0x13_5ebf, 1); nop();                                    /* nop */
            ii(0x13_5ec0, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ec1, 3); callw(0x13_8e97, 0x2fd3);                 /* call 0x8e97 */
            ii(0x13_5ec4, 3); mov(ax, memw_a16[ds, 0x4ff2]);            /* mov ax, [0x4ff2] */
            ii(0x13_5ec7, 3); mov(memw_a16[ds, 0xaa], ax);              /* mov [0xaa], ax */
            ii(0x13_5eca, 1); pushw(ax);                                /* push ax */
            ii(0x13_5ecb, 3); callw(0x13_90ae, 0x31e0);                 /* call 0x90ae */
            ii(0x13_5ece, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_5ed1, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_5ed4, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_5ed8, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5eda, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5edc, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5ede, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5ee0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5ee2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5ee4, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5ee6, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5ee8, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5eea, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5eec, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5eee, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5ef0, 1); pushw(dx);                                /* push dx */
            ii(0x13_5ef1, 1); pushw(ax);                                /* push ax */
            ii(0x13_5ef2, 1); nop();                                    /* nop */
            ii(0x13_5ef3, 1); pushw(cs);                                /* push cs */
            ii(0x13_5ef4, 3); callw(0x13_812e, 0x2237);                 /* call 0x812e */
            ii(0x13_5ef7, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5efa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_5efc, 2); if(jzw(0x13_5f06, 0x8)) goto l_0x13_5f06; /* jz 0x5f06 */
            ii(0x13_5efe, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_5f01, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5f02, 1); popw(si);                                 /* pop si */
            ii(0x13_5f03, 1); popw(di);                                 /* pop di */
            ii(0x13_5f04, 1); leavew();                                 /* leave */
            ii(0x13_5f05, 1); retfw(); return;                          /* retf */
        l_0x13_5f06:
            ii(0x13_5f06, 1); pushw(di);                                /* push di */
            ii(0x13_5f07, 1); pushw(di);                                /* push di */
            ii(0x13_5f08, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x13_5f0b, 3); pushw(0x3c20);                            /* push 0x3c20 */
            ii(0x13_5f0e, 1); nop();                                    /* nop */
            ii(0x13_5f0f, 1); pushw(cs);                                /* push cs */
            ii(0x13_5f10, 3); callw(0x13_c7f4, 0x68e1);                 /* call 0xc7f4 */
            ii(0x13_5f13, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5f16, 3); mov(memb_a16[ds, 0x51a7], al);            /* mov [0x51a7], al */
            ii(0x13_5f19, 1); pushw(di);                                /* push di */
            ii(0x13_5f1a, 1); pushw(di);                                /* push di */
            ii(0x13_5f1b, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x13_5f1e, 3); pushw(0x45a4);                            /* push 0x45a4 */
            ii(0x13_5f21, 1); nop();                                    /* nop */
            ii(0x13_5f22, 1); pushw(cs);                                /* push cs */
            ii(0x13_5f23, 3); callw(0x13_c7f4, 0x68ce);                 /* call 0xc7f4 */
            ii(0x13_5f26, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5f29, 3); mov(memb_a16[ds, 0x51a6], al);            /* mov [0x51a6], al */
            ii(0x13_5f2c, 1); pushw(di);                                /* push di */
            ii(0x13_5f2d, 1); pushw(di);                                /* push di */
            ii(0x13_5f2e, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x13_5f31, 3); pushw(0x4602);                            /* push 0x4602 */
            ii(0x13_5f34, 1); nop();                                    /* nop */
            ii(0x13_5f35, 1); pushw(cs);                                /* push cs */
            ii(0x13_5f36, 3); callw(0x13_c7f4, 0x68bb);                 /* call 0xc7f4 */
            ii(0x13_5f39, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_5f3c, 3); mov(memb_a16[ds, 0x51b5], al);            /* mov [0x51b5], al */
            ii(0x13_5f3f, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_5f42, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_5f46, 3); mov(memw_a16[ds, 0x1fc8], ax);            /* mov [0x1fc8], ax */
            ii(0x13_5f49, 4); mov(memw_a16[ds, 0x1fca], dx);            /* mov [0x1fca], dx */
            ii(0x13_5f4d, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_5f4f, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_5f51, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_5f53, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_5f55, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5f57, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5f59, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5f5b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5f5d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5f5f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5f61, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_5f63, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_5f65, 3); add(ax, 0xffff);                          /* add ax, 0xffff */
            ii(0x13_5f68, 4); adc(dx, 0xfff);                           /* adc dx, 0xfff */
            ii(0x13_5f6c, 3); mov(memw_a16[ds, 0x4fd8], ax);            /* mov [0x4fd8], ax */
            ii(0x13_5f6f, 4); mov(memw_a16[ds, 0x4fda], dx);            /* mov [0x4fda], dx */
            ii(0x13_5f73, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_5f75, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_5f78, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_5f7b, 2); jmpw(0x13_5f86, 0x9); goto l_0x13_5f86;   /* jmp 0x5f86 */
        //    ii(0x13_5f7d, 1); nop();                                    /* nop */
        l_0x13_5f7e:
            ii(0x13_5f7e, 4); add(memw_a16[ss, bp - 0x4], 0x1);         /* add word [bp-0x4], 0x1 */
            ii(0x13_5f82, 4); adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
        l_0x13_5f86:
            ii(0x13_5f86, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_5f89, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_5f8d, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x13_5f90, 2); if(jaw(0x13_5ff8, 0x66)) goto l_0x13_5ff8; /* ja 0x5ff8 */
            ii(0x13_5f92, 2); if(jbw(0x13_5f99, 0x5)) goto l_0x13_5f99; /* jb 0x5f99 */
            ii(0x13_5f94, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x13_5f97, 2); if(jaew(0x13_5ff8, 0x5f)) goto l_0x13_5ff8; /* jae 0x5ff8 */
        l_0x13_5f99:
            ii(0x13_5f99, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5f9b, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5f9e, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5fa1, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_5fa5, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_5fa9, 3); callw(0x13_91e3, 0x3237);                 /* call 0x91e3 */
            ii(0x13_5fac, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_5faf, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5fb1, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5fb4, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5fb7, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_5fbb, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_5fbf, 3); callw(0x13_91e3, 0x3221);                 /* call 0x91e3 */
            ii(0x13_5fc2, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_5fc5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5fc7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5fc9, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5fcc, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5fcf, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x13_5fd3, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x13_5fd7, 3); callw(0x13_9235, 0x325b);                 /* call 0x9235 */
            ii(0x13_5fda, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_5fdd, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5fdf, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_5fe1, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_5fe4, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_5fe7, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x13_5feb, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x13_5fef, 3); callw(0x13_9235, 0x3243);                 /* call 0x9235 */
            ii(0x13_5ff2, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_5ff5, 2); jmpw(0x13_5f7e, -0x79); goto l_0x13_5f7e; /* jmp 0x5f7e */
        //    ii(0x13_5ff7, 1); nop();                                    /* nop */
        l_0x13_5ff8:
            ii(0x13_5ff8, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_5ffa, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_5ffd, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_6000, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x13_6003, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x13_6006, 1); pushw(dx);                                /* push dx */
            ii(0x13_6007, 1); pushw(ax);                                /* push ax */
            ii(0x13_6008, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_600c, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_6010, 3); callw(0x13_91e3, 0x31d0);                 /* call 0x91e3 */
            ii(0x13_6013, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_6016, 3); mov(ax, memw_a16[ds, 0x201c]);            /* mov ax, [0x201c] */
            ii(0x13_6019, 4); mov(dx, memw_a16[ds, 0x201e]);            /* mov dx, [0x201e] */
            ii(0x13_601d, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_601f, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_6021, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6023, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6025, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6027, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6029, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_602b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_602d, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x13_6030, 6); test(memw_a16[ds, 0x201c], 0x3ff);        /* test word [0x201c], 0x3ff */
            ii(0x13_6036, 2); if(jzw(0x13_603c, 0x4)) goto l_0x13_603c; /* jz 0x603c */
            ii(0x13_6038, 1); inc(ax);                                  /* inc ax */
            ii(0x13_6039, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
        l_0x13_603c:
            ii(0x13_603c, 4); add(memw_a16[ss, bp - 0x14], 0x40);       /* add word [bp-0x14], 0x40 */
            ii(0x13_6040, 3); mov(ax, memw_a16[ds, 0x4f8c]);            /* mov ax, [0x4f8c] */
            ii(0x13_6043, 4); mov(dx, memw_a16[ds, 0x4f8e]);            /* mov dx, [0x4f8e] */
            ii(0x13_6047, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_604a, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_604d, 5); mov(memw_a16[ss, bp - 0x26], 0x40);       /* mov word [bp-0x26], 0x40 */
            ii(0x13_6052, 2); jmpw(0x13_6060, 0xc); goto l_0x13_6060;   /* jmp 0x6060 */
        l_0x13_6054:
            ii(0x13_6054, 3); inc(memw_a16[ss, bp - 0x26]);             /* inc word [bp-0x26] */
            ii(0x13_6057, 5); add(memw_a16[ss, bp - 0xa], 0x1000);      /* add word [bp-0xa], 0x1000 */
            ii(0x13_605c, 4); adc(memw_a16[ss, bp - 0x8], 0);           /* adc word [bp-0x8], 0x0 */
        l_0x13_6060:
            ii(0x13_6060, 3); mov(ax, memw_a16[ss, bp - 0x26]);         /* mov ax, [bp-0x26] */
            ii(0x13_6063, 3); cmp(memw_a16[ss, bp - 0x14], ax);         /* cmp [bp-0x14], ax */
            ii(0x13_6066, 2); if(jbew(0x13_60c2, 0x5a)) goto l_0x13_60c2; /* jbe 0x60c2 */
            ii(0x13_6068, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_606b, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_606e, 1); pushw(cs);                                /* push cs */
            ii(0x13_606f, 3); callw(0x13_61ca, 0x158);                  /* call 0x61ca */
            ii(0x13_6072, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_6075, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_6077, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_6079, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_607b, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_607d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_607f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6081, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6083, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6085, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_6087, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_6089, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_608b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_608d, 3); mov(bx, memw_a16[ss, bp - 0x26]);         /* mov bx, [bp-0x26] */
            ii(0x13_6090, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_6093, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_6097, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x13_609a, 3); and(ch, 0xf);                             /* and ch, 0xf */
            ii(0x13_609d, 2); sub(di, di);                              /* sub di, di */
            ii(0x13_609f, 2); or(ax, cx);                               /* or ax, cx */
            ii(0x13_60a1, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_60a4, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x13_60a8, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_60ac, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
            ii(0x13_60b0, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_60b4, 4); or(memb_a16[es, bx + si], 0x2);           /* or byte [es:bx+si], 0x2 */
            ii(0x13_60b8, 4); les(si, ds, 0x992);                       /* les si, [0x992] */
            ii(0x13_60bc, 4); or(memb_a16[es, bx + si], 0x4);           /* or byte [es:bx+si], 0x4 */
            ii(0x13_60c0, 2); jmpw(0x13_6054, -0x6e); goto l_0x13_6054; /* jmp 0x6054 */
        l_0x13_60c2:
            ii(0x13_60c2, 1); nop();                                    /* nop */
            ii(0x13_60c3, 1); pushw(cs);                                /* push cs */
            ii(0x13_60c4, 3); callw(0x13_8e97, 0x2dd0);                 /* call 0x8e97 */
            ii(0x13_60c7, 3); mov(ax, memw_a16[ds, 0x24]);              /* mov ax, [0x24] */
            ii(0x13_60ca, 4); mov(dx, memw_a16[ds, 0x26]);              /* mov dx, [0x26] */
            ii(0x13_60ce, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_60d0, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_60d2, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_60d4, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_60d6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_60d8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_60da, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_60dc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_60de, 3); mov(memw_a16[ds, 0x1fa8], ax);            /* mov [0x1fa8], ax */
            ii(0x13_60e1, 4); mov(memw_a16[ds, 0x1faa], dx);            /* mov [0x1faa], dx */
            ii(0x13_60e5, 3); mov(ax, memw_a16[ds, 0x24]);              /* mov ax, [0x24] */
            ii(0x13_60e8, 4); mov(dx, memw_a16[ds, 0x26]);              /* mov dx, [0x26] */
            ii(0x13_60ec, 2); and(al, 0xfc);                            /* and al, 0xfc */
            ii(0x13_60ee, 3); and(dx, 0x3f);                            /* and dx, 0x3f */
            ii(0x13_60f1, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_60f3, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_60f5, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_60f7, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_60f9, 3); mov(memw_a16[ds, 0x1fc4], ax);            /* mov [0x1fc4], ax */
            ii(0x13_60fc, 4); mov(memw_a16[ds, 0x1fc6], dx);            /* mov [0x1fc6], dx */
            ii(0x13_6100, 3); mov(memw_a16[ds, 0x1fb8], ax);            /* mov [0x1fb8], ax */
            ii(0x13_6103, 4); mov(memw_a16[ds, 0x1fba], dx);            /* mov [0x1fba], dx */
            ii(0x13_6107, 3); mov(memw_a16[ds, 0x1fac], ax);            /* mov [0x1fac], ax */
            ii(0x13_610a, 4); mov(memw_a16[ds, 0x1fae], dx);            /* mov [0x1fae], dx */
            ii(0x13_610e, 3); mov(memw_a16[ds, 0x1fb4], ax);            /* mov [0x1fb4], ax */
            ii(0x13_6111, 4); mov(memw_a16[ds, 0x1fb6], dx);            /* mov [0x1fb6], dx */
            ii(0x13_6115, 3); mov(ax, memw_a16[ds, 0x1fc0]);            /* mov ax, [0x1fc0] */
            ii(0x13_6118, 4); mov(dx, memw_a16[ds, 0x1fc2]);            /* mov dx, [0x1fc2] */
            ii(0x13_611c, 3); mov(memw_a16[ds, 0x1fb8], ax);            /* mov [0x1fb8], ax */
            ii(0x13_611f, 4); mov(memw_a16[ds, 0x1fba], dx);            /* mov [0x1fba], dx */
            ii(0x13_6123, 3); mov(memw_a16[ds, 0x1fbc], ax);            /* mov [0x1fbc], ax */
            ii(0x13_6126, 4); mov(memw_a16[ds, 0x1fbe], dx);            /* mov [0x1fbe], dx */
            ii(0x13_612a, 3); sub(ax, 0xc);                             /* sub ax, 0xc */
            ii(0x13_612d, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x13_6130, 3); mov(memw_a16[ds, 0x1fb0], ax);            /* mov [0x1fb0], ax */
            ii(0x13_6133, 4); mov(memw_a16[ds, 0x1fb2], dx);            /* mov [0x1fb2], dx */
            ii(0x13_6137, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_613a, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x13_613c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_613e, 1); nop();                                    /* nop */
            ii(0x13_613f, 1); pushw(cs);                                /* push cs */
            ii(0x13_6140, 3); callw(0x12_e96a, -0x77d9);                /* call 0xe96a */
            ii(0x13_6143, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_6146, 3); mov(memw_a16[ds, 0x1fe8], ax);            /* mov [0x1fe8], ax */
            ii(0x13_6149, 4); mov(memw_a16[ds, 0x1fea], dx);            /* mov [0x1fea], dx */
            ii(0x13_614d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_614f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6150, 1); popw(si);                                 /* pop si */
            ii(0x13_6151, 1); popw(di);                                 /* pop di */
            ii(0x13_6152, 1); leavew();                                 /* leave */
            ii(0x13_6153, 1); retfw(); return;                          /* retf */
        l_0x13_6154:
            ii(0x13_6154, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6155, 1); popw(si);                                 /* pop si */
            ii(0x13_6156, 1); popw(di);                                 /* pop di */
            ii(0x13_6157, 1); leavew();                                 /* leave */
            ii(0x13_6158, 1); retfw(); return;                          /* retf */
        }
    }
}
