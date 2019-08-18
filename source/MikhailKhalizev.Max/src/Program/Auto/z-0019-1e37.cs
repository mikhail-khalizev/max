using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2edfb4dc-cddd-4c92-8a93-8ceb641cf1c6")]
        public void Method_0019_1e37()
        {
            ii(0x19_1e37, 4); enterw(0x2a, 0);                          /* enter 0x2a, 0x0 */
            ii(0x19_1e3b, 1); pushw(ds);                                /* push ds */
            ii(0x19_1e3c, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_1e3f, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_1e41, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_1e44, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x19_1e47, 3); mov(memw_a16[ds, 0x3ad8], ax);            /* mov [0x3ad8], ax */
            ii(0x19_1e4a, 4); mov(memw_a16[ds, 0x3ada], dx);            /* mov [0x3ada], dx */
        l_0x19_1e4e:
            ii(0x19_1e4e, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x19_1e51, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
            ii(0x19_1e54, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1e57, 1); cbw();                                    /* cbw */
            ii(0x19_1e58, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_1e5a, 2); if(jnzw(0x19_1e5f, 0x3)) goto l_0x19_1e5f; /* jnz 0x1e5f */
            ii(0x19_1e5c, 3); jmpw(0x19_211c, 0x2bd); goto l_0x19_211c; /* jmp 0x211c */
        l_0x19_1e5f:
            ii(0x19_1e5f, 3); cmp(ax, 0x25);                            /* cmp ax, 0x25 */
            ii(0x19_1e62, 2); if(jzw(0x19_1e71, 0xd)) goto l_0x19_1e71; /* jz 0x1e71 */
            ii(0x19_1e64, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_1e68, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_1e6c, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x19_1e6f, 2); jmpw(0x19_1e4e, -0x23); goto l_0x19_1e4e; /* jmp 0x1e4e */
        l_0x19_1e71:
            ii(0x19_1e71, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_1e73, 3); mov(memw_a16[ds, 0x3af0], ax);            /* mov [0x3af0], ax */
            ii(0x19_1e76, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x19_1e79, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_1e7c, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_1e7f, 4); cmp(memb_a16[es, bx], 0x2d);              /* cmp byte [es:bx], 0x2d */
            ii(0x19_1e83, 2); if(jnzw(0x19_1e88, 0x3)) goto l_0x19_1e88; /* jnz 0x1e88 */
            ii(0x19_1e85, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x19_1e88:
            ii(0x19_1e88, 3); mov(memw_a16[ds, 0x3af2], ax);            /* mov [0x3af2], ax */
            ii(0x19_1e8b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_1e8d, 2); if(jzw(0x19_1e92, 0x3)) goto l_0x19_1e92; /* jz 0x1e92 */
            ii(0x19_1e8f, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_1e92:
            ii(0x19_1e92, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_1e95, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1e98, 1); cbw();                                    /* cbw */
            ii(0x19_1e99, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x19_1e9c, 3); cmp(ax, 0x20);                            /* cmp ax, 0x20 */
            ii(0x19_1e9f, 2); if(jnzw(0x19_1ea6, 0x5)) goto l_0x19_1ea6; /* jnz 0x1ea6 */
            ii(0x19_1ea1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_1ea4, 2); jmpw(0x19_1ea8, 0x2); goto l_0x19_1ea8;   /* jmp 0x1ea8 */
        l_0x19_1ea6:
            ii(0x19_1ea6, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_1ea8:
            ii(0x19_1ea8, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x19_1eab, 4); cmp(memw_a16[ss, bp - 0x22], 0x30);       /* cmp word [bp-0x22], 0x30 */
            ii(0x19_1eaf, 2); if(jnzw(0x19_1eb6, 0x5)) goto l_0x19_1eb6; /* jnz 0x1eb6 */
            ii(0x19_1eb1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_1eb4, 2); jmpw(0x19_1eb8, 0x2); goto l_0x19_1eb8;   /* jmp 0x1eb8 */
        l_0x19_1eb6:
            ii(0x19_1eb6, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_1eb8:
            ii(0x19_1eb8, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x19_1ebb, 4); cmp(memw_a16[ss, bp - 0x22], 0x2b);       /* cmp word [bp-0x22], 0x2b */
            ii(0x19_1ebf, 2); if(jnzw(0x19_1ec6, 0x5)) goto l_0x19_1ec6; /* jnz 0x1ec6 */
            ii(0x19_1ec1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_1ec4, 2); jmpw(0x19_1ec8, 0x2); goto l_0x19_1ec8;   /* jmp 0x1ec8 */
        l_0x19_1ec6:
            ii(0x19_1ec6, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_1ec8:
            ii(0x19_1ec8, 3); or(ax, memw_a16[ss, bp - 0x26]);          /* or ax, [bp-0x26] */
            ii(0x19_1ecb, 3); or(ax, memw_a16[ss, bp - 0x24]);          /* or ax, [bp-0x24] */
            ii(0x19_1ece, 2); if(jzw(0x19_1ed9, 0x9)) goto l_0x19_1ed9; /* jz 0x1ed9 */
            ii(0x19_1ed0, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x19_1ed3, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_1ed6, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_1ed9:
            ii(0x19_1ed9, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x19_1edc, 1); pushw(ss);                                /* push ss */
            ii(0x19_1edd, 1); pushw(ax);                                /* push ax */
            ii(0x19_1ede, 3); callw(0x19_1cd3, -0x20e);                 /* call 0x1cd3 */
            ii(0x19_1ee1, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1ee2, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1ee3, 3); mov(memw_a16[ds, 0x3af0], ax);            /* mov [0x3af0], ax */
            ii(0x19_1ee6, 4); cmp(memw_a16[ss, bp - 0x6], 0x30);        /* cmp word [bp-0x6], 0x30 */
            ii(0x19_1eea, 2); if(jnzw(0x19_1ef4, 0x8)) goto l_0x19_1ef4; /* jnz 0x1ef4 */
            ii(0x19_1eec, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x19_1ef1, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
        l_0x19_1ef4:
            ii(0x19_1ef4, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x19_1ef7, 4); cmp(memb_a16[es, bx], 0x6c);              /* cmp byte [es:bx], 0x6c */
            ii(0x19_1efb, 2); if(jnzw(0x19_1f02, 0x5)) goto l_0x19_1f02; /* jnz 0x1f02 */
            ii(0x19_1efd, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_1f00, 2); jmpw(0x19_1f04, 0x2); goto l_0x19_1f04;   /* jmp 0x1f04 */
        l_0x19_1f02:
            ii(0x19_1f02, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_1f04:
            ii(0x19_1f04, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_1f07, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_1f09, 2); if(jzw(0x19_1f0e, 0x3)) goto l_0x19_1f0e; /* jz 0x1f0e */
            ii(0x19_1f0b, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_1f0e:
            ii(0x19_1f0e, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_1f11, 4); cmp(memb_a16[es, bx], 0x46);              /* cmp byte [es:bx], 0x46 */
            ii(0x19_1f15, 2); if(jnzw(0x19_1f1f, 0x8)) goto l_0x19_1f1f; /* jnz 0x1f1f */
            ii(0x19_1f17, 5); mov(memw_a16[ss, bp - 0x1a], 0x1);        /* mov word [bp-0x1a], 0x1 */
            ii(0x19_1f1c, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_1f1f:
            ii(0x19_1f1f, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_1f22, 4); cmp(memb_a16[es, bx], 0x4e);              /* cmp byte [es:bx], 0x4e */
            ii(0x19_1f26, 2); if(jnzw(0x19_1f30, 0x8)) goto l_0x19_1f30; /* jnz 0x1f30 */
            ii(0x19_1f28, 5); mov(memw_a16[ss, bp - 0x1a], 0);          /* mov word [bp-0x1a], 0x0 */
            ii(0x19_1f2d, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
        l_0x19_1f30:
            ii(0x19_1f30, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x19_1f33, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
            ii(0x19_1f36, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1f39, 1); cbw();                                    /* cbw */
            ii(0x19_1f3a, 1); pushw(ax);                                /* push ax */
            ii(0x19_1f3b, 1); nop();                                    /* nop */
            ii(0x19_1f3c, 1); pushw(cs);                                /* push cs */
            ii(0x19_1f3d, 3); callw(0x19_328e, 0x134e);                 /* call 0x328e */
            ii(0x19_1f40, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1f41, 3); cmp(ax, 0x58);                            /* cmp ax, 0x58 */
            ii(0x19_1f44, 2); if(jnzw(0x19_1f49, 0x3)) goto l_0x19_1f49; /* jnz 0x1f49 */
            ii(0x19_1f46, 3); jmpw(0x19_20b2, 0x169); goto l_0x19_20b2; /* jmp 0x20b2 */
        l_0x19_1f49:
            ii(0x19_1f49, 2); if(jbew(0x19_1f4e, 0x3)) goto l_0x19_1f4e; /* jbe 0x1f4e */
            ii(0x19_1f4b, 3); jmpw(0x19_202d, 0xdf); goto l_0x19_202d;  /* jmp 0x202d */
        l_0x19_1f4e:
            ii(0x19_1f4e, 2); sub(al, 0x43);                            /* sub al, 0x43 */
            ii(0x19_1f50, 2); if(jnzw(0x19_1f55, 0x3)) goto l_0x19_1f55; /* jnz 0x1f55 */
            ii(0x19_1f52, 3); jmpw(0x19_200e, 0xb9); goto l_0x19_200e;  /* jmp 0x200e */
        l_0x19_1f55:
            ii(0x19_1f55, 2); dec(al);                                  /* dec al */
            ii(0x19_1f57, 2); if(jnzw(0x19_1f5c, 0x3)) goto l_0x19_1f5c; /* jnz 0x1f5c */
            ii(0x19_1f59, 3); jmpw(0x19_2033, 0xd7); goto l_0x19_2033;  /* jmp 0x2033 */
        l_0x19_1f5c:
            ii(0x19_1f5c, 2); sub(al, 0xc);                             /* sub al, 0xc */
            ii(0x19_1f5e, 2); if(jnzw(0x19_1f63, 0x3)) goto l_0x19_1f63; /* jnz 0x1f63 */
            ii(0x19_1f60, 3); jmpw(0x19_20f1, 0x18e); goto l_0x19_20f1; /* jmp 0x20f1 */
        l_0x19_1f63:
            ii(0x19_1f63, 2); sub(al, 0x3);                             /* sub al, 0x3 */
            ii(0x19_1f65, 2); if(jzw(0x19_1f71, 0xa)) goto l_0x19_1f71; /* jz 0x1f71 */
            ii(0x19_1f67, 2); sub(al, 0x2);                             /* sub al, 0x2 */
            ii(0x19_1f69, 2); if(jnzw(0x19_1f6e, 0x3)) goto l_0x19_1f6e; /* jnz 0x1f6e */
            ii(0x19_1f6b, 3); jmpw(0x19_20ab, 0x13d); goto l_0x19_20ab; /* jmp 0x20ab */
        l_0x19_1f6e:
            ii(0x19_1f6e, 3); jmpw(0x19_202d, 0xbc); goto l_0x19_202d;  /* jmp 0x202d */
        l_0x19_1f71:
            ii(0x19_1f71, 4); cmp(memw_a16[ss, bp - 0x1c], 0);          /* cmp word [bp-0x1c], 0x0 */
            ii(0x19_1f75, 2); if(jnzw(0x19_1f7c, 0x5)) goto l_0x19_1f7c; /* jnz 0x1f7c */
            ii(0x19_1f77, 5); mov(memw_a16[ss, bp - 0x1c], 0x7fff);     /* mov word [bp-0x1c], 0x7fff */
        l_0x19_1f7c:
            ii(0x19_1f7c, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_1f7f, 4); add(memw_a16[ss, bp + 0xe], 0x4);         /* add word [bp+0xe], 0x4 */
            ii(0x19_1f83, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_1f86, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_1f8a, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_1f8d, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x19_1f90, 1); pushw(dx);                                /* push dx */
            ii(0x19_1f91, 5); callw_far_abs(0x88, 0xbac8);              /* call word 0x88:0xbac8 */
            ii(0x19_1f96, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1f97, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_1f99, 2); if(jzw(0x19_1fe0, 0x45)) goto l_0x19_1fe0; /* jz 0x1fe0 */
            ii(0x19_1f9b, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_1f9e, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x19_1fa1, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x19_1fa4, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x19_1fa7, 5); mov(memw_a16[ss, bp - 0x16], 0);          /* mov word [bp-0x16], 0x0 */
            ii(0x19_1fac, 2); jmpw(0x19_1fb4, 0x6); goto l_0x19_1fb4;   /* jmp 0x1fb4 */
        l_0x19_1fae:
            ii(0x19_1fae, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x19_1fb1, 3); inc(memw_a16[ss, bp - 0x16]);             /* inc word [bp-0x16] */
        l_0x19_1fb4:
            ii(0x19_1fb4, 3); les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x19_1fb7, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x19_1fbb, 2); if(jnzw(0x19_1fae, -0xf)) goto l_0x19_1fae; /* jnz 0x1fae */
            ii(0x19_1fbd, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x19_1fc0, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x19_1fc3, 3); callw(0x19_1d3b, -0x28b);                 /* call 0x1d3b */
            ii(0x19_1fc6, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1fc7, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1fc8, 4); sub(memw_a16[ds, 0x3af0], ax);            /* sub [0x3af0], ax */
            ii(0x19_1fcc, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x19_1fcf, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x19_1fd2, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_1fd5, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x19_1fd8, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_1fda, 3); callw(0x19_1d91, -0x24c);                 /* call 0x1d91 */
            ii(0x19_1fdd, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1fde, 2); jmpw(0x19_1fe8, 0x8); goto l_0x19_1fe8;   /* jmp 0x1fe8 */
        l_0x19_1fe0:
            ii(0x19_1fe0, 5); mov(memw_a16[ss, bp - 0x12], 0x3af4);     /* mov word [bp-0x12], 0x3af4 */
            ii(0x19_1fe5, 3); mov(memw_a16[ss, bp - 0x10], ds);         /* mov [bp-0x10], ds */
        l_0x19_1fe8:
            ii(0x19_1fe8, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x19_1feb, 3); dec(memw_a16[ss, bp - 0x1c]);             /* dec word [bp-0x1c] */
            ii(0x19_1fee, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_1ff0, 2); if(jzw(0x19_202d, 0x3b)) goto l_0x19_202d; /* jz 0x202d */
            ii(0x19_1ff2, 3); les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x19_1ff5, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x19_1ff9, 2); if(jzw(0x19_202d, 0x32)) goto l_0x19_202d; /* jz 0x202d */
            ii(0x19_1ffb, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1ffe, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_2002, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x19_2005, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x19_2008, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_200c, 2); jmpw(0x19_1fe8, -0x26); goto l_0x19_1fe8; /* jmp 0x1fe8 */
        l_0x19_200e:
            ii(0x19_200e, 4); dec(memw_a16[ds, 0x3af0]);                /* dec word [0x3af0] */
            ii(0x19_2012, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_2014, 3); callw(0x19_1d91, -0x286);                 /* call 0x1d91 */
            ii(0x19_2017, 1); popw(bx);                                 /* pop bx */
            ii(0x19_2018, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_201b, 4); add(memw_a16[ss, bp + 0xe], 0x2);         /* add word [bp+0xe], 0x2 */
            ii(0x19_201f, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_2022, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_2026, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_202a, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x19_202d:
            ii(0x19_202d, 3); callw(0x19_1d7c, -0x2b4);                 /* call 0x1d7c */
            ii(0x19_2030, 3); jmpw(0x19_1e4e, -0x1e5); goto l_0x19_1e4e; /* jmp 0x1e4e */
        l_0x19_2033:
            ii(0x19_2033, 4); cmp(memw_a16[ss, bp - 0x1a], 0);          /* cmp word [bp-0x1a], 0x0 */
            ii(0x19_2037, 2); if(jzw(0x19_2049, 0x10)) goto l_0x19_2049; /* jz 0x2049 */
            ii(0x19_2039, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_203c, 4); add(memw_a16[ss, bp + 0xe], 0x4);         /* add word [bp+0xe], 0x4 */
            ii(0x19_2040, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_2043, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_2047, 2); jmpw(0x19_2054, 0xb); goto l_0x19_2054;   /* jmp 0x2054 */
        l_0x19_2049:
            ii(0x19_2049, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_204c, 4); add(memw_a16[ss, bp + 0xe], 0x2);         /* add word [bp+0xe], 0x2 */
            ii(0x19_2050, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_2053, 1); cwd();                                    /* cwd */
        l_0x19_2054:
            ii(0x19_2054, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x19_2056, 2); if(jgew(0x19_205d, 0x5)) goto l_0x19_205d; /* jge 0x205d */
            ii(0x19_2058, 5); mov(memw_a16[ss, bp - 0x6], 0x2d);        /* mov word [bp-0x6], 0x2d */
        l_0x19_205d:
            ii(0x19_205d, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_205f, 2); pushw(0xa);                               /* push 0xa */
        l_0x19_2061:
            ii(0x19_2061, 1); pushw(dx);                                /* push dx */
            ii(0x19_2062, 1); pushw(ax);                                /* push ax */
            ii(0x19_2063, 3); callw(0x19_1dbf, -0x2a7);                 /* call 0x1dbf */
            ii(0x19_2066, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_2069, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_206c, 1); pushw(ax);                                /* push ax */
            ii(0x19_206d, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x19_2070, 3); callw(0x19_1d4b, -0x328);                 /* call 0x1d4b */
            ii(0x19_2073, 1); popw(bx);                                 /* pop bx */
            ii(0x19_2074, 1); popw(bx);                                 /* pop bx */
            ii(0x19_2075, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x19_2078, 4); sub(memw_a16[ds, 0x3af0], ax);            /* sub [0x3af0], ax */
            ii(0x19_207c, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_207f, 3); callw(0x19_1d91, -0x2f1);                 /* call 0x1d91 */
            ii(0x19_2082, 1); popw(bx);                                 /* pop bx */
            ii(0x19_2083, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x19_2086, 3); sub(ax, memw_a16[ss, bp - 0x16]);         /* sub ax, [bp-0x16] */
            ii(0x19_2089, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x19_208c, 2); jmpw(0x19_209a, 0xc); goto l_0x19_209a;   /* jmp 0x209a */
        l_0x19_208e:
            ii(0x19_208e, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_2092, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_2096, 4); mov(memb_a16[es, bx], 0x30);              /* mov byte [es:bx], 0x30 */
        l_0x19_209a:
            ii(0x19_209a, 3); dec(memw_a16[ss, bp - 0x1c]);             /* dec word [bp-0x1c] */
            ii(0x19_209d, 2); if(jnsw(0x19_208e, -0x11)) goto l_0x19_208e; /* jns 0x208e */
            ii(0x19_209f, 1); pushw(ds);                                /* push ds */
            ii(0x19_20a0, 3); pushw(0x3adc);                            /* push 0x3adc */
            ii(0x19_20a3, 1); pushw(cs);                                /* push cs */
            ii(0x19_20a4, 3); callw(0x19_1d5b, -0x34c);                 /* call 0x1d5b */
            ii(0x19_20a7, 1); popw(bx);                                 /* pop bx */
            ii(0x19_20a8, 1); popw(bx);                                 /* pop bx */
            ii(0x19_20a9, 2); jmpw(0x19_202d, -0x7e); goto l_0x19_202d; /* jmp 0x202d */
        l_0x19_20ab:
            ii(0x19_20ab, 5); mov(memw_a16[ss, bp - 0x14], 0xa);        /* mov word [bp-0x14], 0xa */
            ii(0x19_20b0, 2); jmpw(0x19_20b7, 0x5); goto l_0x19_20b7;   /* jmp 0x20b7 */
        l_0x19_20b2:
            ii(0x19_20b2, 5); mov(memw_a16[ss, bp - 0x14], 0x10);       /* mov word [bp-0x14], 0x10 */
        l_0x19_20b7:
            ii(0x19_20b7, 4); cmp(memw_a16[ss, bp - 0x1a], 0);          /* cmp word [bp-0x1a], 0x0 */
            ii(0x19_20bb, 2); if(jzw(0x19_20cd, 0x10)) goto l_0x19_20cd; /* jz 0x20cd */
            ii(0x19_20bd, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_20c0, 4); add(memw_a16[ss, bp + 0xe], 0x4);         /* add word [bp+0xe], 0x4 */
            ii(0x19_20c4, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_20c7, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_20cb, 2); jmpw(0x19_20d8, 0xb); goto l_0x19_20d8;   /* jmp 0x20d8 */
        l_0x19_20cd:
            ii(0x19_20cd, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_20d0, 4); add(memw_a16[ss, bp + 0xe], 0x2);         /* add word [bp+0xe], 0x2 */
            ii(0x19_20d4, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_20d7, 1); cwd();                                    /* cwd */
        l_0x19_20d8:
            ii(0x19_20d8, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x19_20dd, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_20e0, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x19_20e3, 4); cmp(memw_a16[ss, bp - 0x1a], 0);          /* cmp word [bp-0x1a], 0x0 */
            ii(0x19_20e7, 2); if(jzw(0x19_20ec, 0x3)) goto l_0x19_20ec; /* jz 0x20ec */
            ii(0x19_20e9, 3); jmpw(0x19_2061, -0x8b); goto l_0x19_2061; /* jmp 0x2061 */
        l_0x19_20ec:
            ii(0x19_20ec, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_20ee, 3); jmpw(0x19_2061, -0x90); goto l_0x19_2061; /* jmp 0x2061 */
        l_0x19_20f1:
            ii(0x19_20f1, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x19_20f4, 4); add(memw_a16[ss, bp + 0xe], 0x4);         /* add word [bp+0xe], 0x4 */
            ii(0x19_20f8, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_20fb, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x19_20ff, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_2102, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x19_2105, 1); pushw(ax);                                /* push ax */
            ii(0x19_2106, 1); pushw(dx);                                /* push dx */
            ii(0x19_2107, 1); pushw(ds);                                /* push ds */
            ii(0x19_2108, 3); pushw(0x3afa);                            /* push 0x3afa */
            ii(0x19_210b, 4); pushw(memw_a16[ds, 0x3ada]);              /* push word [0x3ada] */
            ii(0x19_210f, 4); pushw(memw_a16[ds, 0x3ad8]);              /* push word [0x3ad8] */
            ii(0x19_2113, 3); callw(0x19_1e1c, -0x2fa);                 /* call 0x1e1c */
            ii(0x19_2116, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_2119, 3); jmpw(0x19_202d, -0xef); goto l_0x19_202d; /* jmp 0x202d */
        l_0x19_211c:
            ii(0x19_211c, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_2120, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x19_2124, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x19_2128, 3); mov(ax, memw_a16[ds, 0x3ad8]);            /* mov ax, [0x3ad8] */
            ii(0x19_212b, 3); sub(ax, memw_a16[ss, bp + 0x6]);          /* sub ax, [bp+0x6] */
            ii(0x19_212e, 1); dec(ax);                                  /* dec ax */
            ii(0x19_212f, 1); popw(ds);                                 /* pop ds */
            ii(0x19_2130, 1); leavew();                                 /* leave */
            ii(0x19_2131, 1); retfw(); return;                          /* retf */
        }
    }
}
