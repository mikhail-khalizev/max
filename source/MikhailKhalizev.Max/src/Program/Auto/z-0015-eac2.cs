using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d0841fc3-6ee3-4be3-8862-9d79be29feca")]
        public void Method_0015_eac2()
        {
            ii(0x15_eac2, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x15_eac6, 1); pushw(di);                                /* push di */
            ii(0x15_eac7, 1); pushw(si);                                /* push si */
            ii(0x15_eac8, 1); pushw(ds);                                /* push ds */
            ii(0x15_eac9, 3); pushw(0x2dc4);                            /* push 0x2dc4 */
            ii(0x15_eacc, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_eace, 5); callw_far_abs(0x80, 0x508e);              /* call word 0x80:0x508e */
            ii(0x15_ead3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ead6, 5); cmp(memw_a16[ds, 0x2dc6], 0);             /* cmp word [0x2dc6], 0x0 */
            ii(0x15_eadb, 2); if(jzw(0x15_eae0, 0x3)) goto l_0x15_eae0; /* jz 0xeae0 */
            ii(0x15_eadd, 3); jmpw(0x15_eb02, 0x22); goto l_0x15_eb02;  /* jmp 0xeb02 */
        l_0x15_eae0:
            ii(0x15_eae0, 5); cmp(memw_a16[ds, 0x2dc4], 0);             /* cmp word [0x2dc4], 0x0 */
            ii(0x15_eae5, 2); if(jzw(0x15_eaea, 0x3)) goto l_0x15_eaea; /* jz 0xeaea */
            ii(0x15_eae7, 3); jmpw(0x15_eb02, 0x18); goto l_0x15_eb02;  /* jmp 0xeb02 */
        l_0x15_eaea:
            ii(0x15_eaea, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_eaec, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_eaee, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_eaf0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_eaf2, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_eaf4, 5); callw_far_abs(0x80, 0x58d4);              /* call word 0x80:0x58d4 */
            ii(0x15_eaf9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_eafc, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_eaff, 3); jmpw(0x15_ebfb, 0xf9); goto l_0x15_ebfb;  /* jmp 0xebfb */
        l_0x15_eb02:
            ii(0x15_eb02, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x15_eb06, 2); if(jnzw(0x15_eb0b, 0x3)) goto l_0x15_eb0b; /* jnz 0xeb0b */
            ii(0x15_eb08, 3); jmpw(0x15_eb21, 0x16); goto l_0x15_eb21;  /* jmp 0xeb21 */
        l_0x15_eb0b:
            ii(0x15_eb0b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_eb0d, 2); @int(0x33);                               /* int 0x33 */
            ii(0x15_eb0f, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_eb12, 4); cmp(memw_a16[ss, bp - 0xe], 0);           /* cmp word [bp-0xe], 0x0 */
            ii(0x15_eb16, 2); if(jzw(0x15_eb1b, 0x3)) goto l_0x15_eb1b; /* jz 0xeb1b */
            ii(0x15_eb18, 3); jmpw(0x15_eb21, 0x6); goto l_0x15_eb21;   /* jmp 0xeb21 */
        l_0x15_eb1b:
            ii(0x15_eb1b, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x15_eb1e, 3); jmpw(0x15_ebfb, 0xda); goto l_0x15_ebfb;  /* jmp 0xebfb */
        l_0x15_eb21:
            ii(0x15_eb21, 3); mov(ax, 0x15);                            /* mov ax, 0x15 */
            ii(0x15_eb24, 2); @int(0x33);                               /* int 0x33 */
            ii(0x15_eb26, 4); mov(memw_a16[ds, 0x48f8], bx);            /* mov [0x48f8], bx */
            ii(0x15_eb2a, 3); mov(ax, memw_a16[ds, 0x48f8]);            /* mov ax, [0x48f8] */
            ii(0x15_eb2d, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_eb30, 4); cmp(memw_a16[ss, bp - 0x1c], 0x40);       /* cmp word [bp-0x1c], 0x40 */
            ii(0x15_eb34, 2); if(jlw(0x15_eb39, 0x3)) goto l_0x15_eb39; /* jl 0xeb39 */
            ii(0x15_eb36, 3); jmpw(0x15_eb3e, 0x5); goto l_0x15_eb3e;   /* jmp 0xeb3e */
        l_0x15_eb39:
            ii(0x15_eb39, 5); mov(memw_a16[ss, bp - 0x1c], 0x40);       /* mov word [bp-0x1c], 0x40 */
        l_0x15_eb3e:
            ii(0x15_eb3e, 4); add(memw_a16[ss, bp - 0x1c], 0x20);       /* add word [bp-0x1c], 0x20 */
            ii(0x15_eb42, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_eb44, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_eb49, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_eb4c, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_eb4f, 3); pushw(memw_a16[ss, bp - 0x1c]);           /* push word [bp-0x1c] */
            ii(0x15_eb52, 5); callw_far_abs(0x80, 0x51e8);              /* call word 0x80:0x51e8 */
            ii(0x15_eb57, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_eb5a, 3); mov(memw_a16[ds, 0x4902], ax);            /* mov [0x4902], ax */
            ii(0x15_eb5d, 4); mov(memw_a16[ds, 0x4904], dx);            /* mov [0x4904], dx */
            ii(0x15_eb61, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x15_eb64, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_eb69, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_eb6c, 3); mov(ax, memw_a16[ds, 0x4904]);            /* mov ax, [0x4904] */
            ii(0x15_eb6f, 4); or(ax, memw_a16[ds, 0x4902]);             /* or ax, [0x4902] */
            ii(0x15_eb73, 2); if(jzw(0x15_eb78, 0x3)) goto l_0x15_eb78; /* jz 0xeb78 */
            ii(0x15_eb75, 3); jmpw(0x15_eb7e, 0x6); goto l_0x15_eb7e;   /* jmp 0xeb7e */
        l_0x15_eb78:
            ii(0x15_eb78, 3); mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x15_eb7b, 3); jmpw(0x15_ebfb, 0x7d); goto l_0x15_ebfb;  /* jmp 0xebfb */
        l_0x15_eb7e:
            ii(0x15_eb7e, 4); pushw(memw_a16[ds, 0x4904]);              /* push word [0x4904] */
            ii(0x15_eb82, 4); pushw(memw_a16[ds, 0x4902]);              /* push word [0x4902] */
            ii(0x15_eb86, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_eb8b, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_eb8e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x15_eb90, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x15_eb92, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x15_eb94, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x15_eb96, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x15_eb98, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x15_eb9a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x15_eb9c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x15_eb9e, 3); mov(memw_a16[ds, 0x4900], ax);            /* mov [0x4900], ax */
            ii(0x15_eba1, 3); mov(ax, memw_a16[ds, 0x4904]);            /* mov ax, [0x4904] */
            ii(0x15_eba4, 3); mov(memw_a16[ds, 0x48fe], ax);            /* mov [0x48fe], ax */
            ii(0x15_eba7, 3); mov(ax, memw_a16[ds, 0x4902]);            /* mov ax, [0x4902] */
            ii(0x15_ebaa, 4); mov(dx, memw_a16[ds, 0x4904]);            /* mov dx, [0x4904] */
            ii(0x15_ebae, 3); add(ax, 0x20);                            /* add ax, 0x20 */
            ii(0x15_ebb1, 3); mov(memw_a16[ds, 0x48fa], ax);            /* mov [0x48fa], ax */
            ii(0x15_ebb4, 4); mov(memw_a16[ds, 0x48fc], dx);            /* mov [0x48fc], dx */
            ii(0x15_ebb8, 1); nop();                                    /* nop */
            ii(0x15_ebb9, 1); pushw(cs);                                /* push cs */
            ii(0x15_ebba, 3); callw(0x15_ec09, 0x4c);                   /* call 0xec09 */
            ii(0x15_ebbd, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_ebc0, 2); if(jzw(0x15_ebc5, 0x3)) goto l_0x15_ebc5; /* jz 0xebc5 */
            ii(0x15_ebc2, 3); jmpw(0x15_ebcb, 0x6); goto l_0x15_ebcb;   /* jmp 0xebcb */
        l_0x15_ebc5:
            ii(0x15_ebc5, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x15_ebc8, 3); jmpw(0x15_ebfb, 0x30); goto l_0x15_ebfb;  /* jmp 0xebfb */
        l_0x15_ebcb:
            ii(0x15_ebcb, 5); mov(memw_a16[ss, bp - 0x12], 0x9860);     /* mov word [bp-0x12], 0x9860 */
            ii(0x15_ebd0, 5); mov(memw_a16[ss, bp - 0x10], 0x88);       /* mov word [bp-0x10], 0x88 */
            ii(0x15_ebd5, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x15_ebd8, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_ebdb, 5); mov(memw_a16[ss, bp - 0x16], 0);          /* mov word [bp-0x16], 0x0 */
            ii(0x15_ebe0, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_ebe3, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_ebe6, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x15_ebe9, 1); pushw(ss);                                /* push ss */
            ii(0x15_ebea, 1); pushw(ax);                                /* push ax */
            ii(0x15_ebeb, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_ebed, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x15_ebf2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ebf5, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ebf8, 3); jmpw(0x15_ebfb, 0); goto l_0x15_ebfb;     /* jmp 0xebfb */
        l_0x15_ebfb:
            ii(0x15_ebfb, 1); popw(si);                                 /* pop si */
            ii(0x15_ebfc, 1); popw(di);                                 /* pop di */
            ii(0x15_ebfd, 1); leavew();                                 /* leave */
            ii(0x15_ebfe, 1); retfw(); return;                          /* retf */
        }
    }
}
