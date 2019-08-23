using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_eac2-86a0f189")]
        public void Method_0019_eac2()
        {
            ii(0x19_eac2, 4); enter(0x1c, 0);                           /* enter 0x1c, 0x0 */
            ii(0x19_eac6, 1); push(di);                                 /* push di */
            ii(0x19_eac7, 1); push(si);                                 /* push si */
            ii(0x19_eac8, 1); push(ds);                                 /* push ds */
            ii(0x19_eac9, 3); push(0x2dc4);                             /* push 0x2dc4 */
            ii(0x19_eacc, 2); push(0x33);                               /* push 0x33 */
            ii(0x19_eace, 5); call_far_abs(0x80, 0x508e);               /* call word 0x80:0x508e */
            ii(0x19_ead3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_ead6, 5); cmp(memw[ds, 0x2dc6], 0);                 /* cmp word [0x2dc6], 0x0 */
            ii(0x19_eadb, 2); if(jz(0x19_eae0, 0x3)) goto l_0x19_eae0;  /* jz 0xeae0 */
            ii(0x19_eadd, 3); jmp(0x19_eb02, 0x22); goto l_0x19_eb02;   /* jmp 0xeb02 */
        l_0x19_eae0:
            ii(0x19_eae0, 5); cmp(memw[ds, 0x2dc4], 0);                 /* cmp word [0x2dc4], 0x0 */
            ii(0x19_eae5, 2); if(jz(0x19_eaea, 0x3)) goto l_0x19_eaea;  /* jz 0xeaea */
            ii(0x19_eae7, 3); jmp(0x19_eb02, 0x18); goto l_0x19_eb02;   /* jmp 0xeb02 */
        l_0x19_eaea:
            ii(0x19_eaea, 2); push(0);                                  /* push 0x0 */
            ii(0x19_eaec, 2); push(0);                                  /* push 0x0 */
            ii(0x19_eaee, 2); push(0);                                  /* push 0x0 */
            ii(0x19_eaf0, 2); push(0);                                  /* push 0x0 */
            ii(0x19_eaf2, 2); push(0x33);                               /* push 0x33 */
            ii(0x19_eaf4, 5); call_far_abs(0x80, 0x58d4);               /* call word 0x80:0x58d4 */
            ii(0x19_eaf9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_eafc, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_eaff, 3); jmp(0x19_ebfb, 0xf9); goto l_0x19_ebfb;   /* jmp 0xebfb */
        l_0x19_eb02:
            ii(0x19_eb02, 4); cmp(memw[ss, bp + 0x6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x19_eb06, 2); if(jnz(0x19_eb0b, 0x3)) goto l_0x19_eb0b; /* jnz 0xeb0b */
            ii(0x19_eb08, 3); jmp(0x19_eb21, 0x16); goto l_0x19_eb21;   /* jmp 0xeb21 */
        l_0x19_eb0b:
            ii(0x19_eb0b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_eb0d, 2); @int(0x33);                               /* int 0x33 */
            ii(0x19_eb0f, 3); mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x19_eb12, 4); cmp(memw[ss, bp - 0xe], 0);               /* cmp word [bp-0xe], 0x0 */
            ii(0x19_eb16, 2); if(jz(0x19_eb1b, 0x3)) goto l_0x19_eb1b;  /* jz 0xeb1b */
            ii(0x19_eb18, 3); jmp(0x19_eb21, 0x6); goto l_0x19_eb21;    /* jmp 0xeb21 */
        l_0x19_eb1b:
            ii(0x19_eb1b, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x19_eb1e, 3); jmp(0x19_ebfb, 0xda); goto l_0x19_ebfb;   /* jmp 0xebfb */
        l_0x19_eb21:
            ii(0x19_eb21, 3); mov(ax, 0x15);                            /* mov ax, 0x15 */
            ii(0x19_eb24, 2); @int(0x33);                               /* int 0x33 */
            ii(0x19_eb26, 4); mov(memw[ds, 0x48f8], bx);                /* mov [0x48f8], bx */
            ii(0x19_eb2a, 3); mov(ax, memw[ds, 0x48f8]);                /* mov ax, [0x48f8] */
            ii(0x19_eb2d, 3); mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_eb30, 4); cmp(memw[ss, bp - 0x1c], 0x40);           /* cmp word [bp-0x1c], 0x40 */
            ii(0x19_eb34, 2); if(jl(0x19_eb39, 0x3)) goto l_0x19_eb39;  /* jl 0xeb39 */
            ii(0x19_eb36, 3); jmp(0x19_eb3e, 0x5); goto l_0x19_eb3e;    /* jmp 0xeb3e */
        l_0x19_eb39:
            ii(0x19_eb39, 5); mov(memw[ss, bp - 0x1c], 0x40);           /* mov word [bp-0x1c], 0x40 */
        l_0x19_eb3e:
            ii(0x19_eb3e, 4); add(memw[ss, bp - 0x1c], 0x20);           /* add word [bp-0x1c], 0x20 */
            ii(0x19_eb42, 2); push(0x3);                                /* push 0x3 */
            ii(0x19_eb44, 5); call_far_abs(0x80, 0x51ba);               /* call word 0x80:0x51ba */
            ii(0x19_eb49, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_eb4c, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_eb4f, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x19_eb52, 5); call_far_abs(0x80, 0x51e8);               /* call word 0x80:0x51e8 */
            ii(0x19_eb57, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_eb5a, 3); mov(memw[ds, 0x4902], ax);                /* mov [0x4902], ax */
            ii(0x19_eb5d, 4); mov(memw[ds, 0x4904], dx);                /* mov [0x4904], dx */
            ii(0x19_eb61, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_eb64, 5); call_far_abs(0x80, 0x51ba);               /* call word 0x80:0x51ba */
            ii(0x19_eb69, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_eb6c, 3); mov(ax, memw[ds, 0x4904]);                /* mov ax, [0x4904] */
            ii(0x19_eb6f, 4); or(ax, memw[ds, 0x4902]);                 /* or ax, [0x4902] */
            ii(0x19_eb73, 2); if(jz(0x19_eb78, 0x3)) goto l_0x19_eb78;  /* jz 0xeb78 */
            ii(0x19_eb75, 3); jmp(0x19_eb7e, 0x6); goto l_0x19_eb7e;    /* jmp 0xeb7e */
        l_0x19_eb78:
            ii(0x19_eb78, 3); mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x19_eb7b, 3); jmp(0x19_ebfb, 0x7d); goto l_0x19_ebfb;   /* jmp 0xebfb */
        l_0x19_eb7e:
            ii(0x19_eb7e, 4); push(memw[ds, 0x4904]);                   /* push word [0x4904] */
            ii(0x19_eb82, 4); push(memw[ds, 0x4902]);                   /* push word [0x4902] */
            ii(0x19_eb86, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_eb8b, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_eb8e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_eb90, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_eb92, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_eb94, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_eb96, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_eb98, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_eb9a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_eb9c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_eb9e, 3); mov(memw[ds, 0x4900], ax);                /* mov [0x4900], ax */
            ii(0x19_eba1, 3); mov(ax, memw[ds, 0x4904]);                /* mov ax, [0x4904] */
            ii(0x19_eba4, 3); mov(memw[ds, 0x48fe], ax);                /* mov [0x48fe], ax */
            ii(0x19_eba7, 3); mov(ax, memw[ds, 0x4902]);                /* mov ax, [0x4902] */
            ii(0x19_ebaa, 4); mov(dx, memw[ds, 0x4904]);                /* mov dx, [0x4904] */
            ii(0x19_ebae, 3); add(ax, 0x20);                            /* add ax, 0x20 */
            ii(0x19_ebb1, 3); mov(memw[ds, 0x48fa], ax);                /* mov [0x48fa], ax */
            ii(0x19_ebb4, 4); mov(memw[ds, 0x48fc], dx);                /* mov [0x48fc], dx */
            ii(0x19_ebb8, 1); nop();                                    /* nop */
            ii(0x19_ebb9, 1); push(cs);                                 /* push cs */
            ii(0x19_ebba, 3); call(0x19_ec09, 0x4c);                    /* call 0xec09 */
            ii(0x19_ebbd, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_ebc0, 2); if(jz(0x19_ebc5, 0x3)) goto l_0x19_ebc5;  /* jz 0xebc5 */
            ii(0x19_ebc2, 3); jmp(0x19_ebcb, 0x6); goto l_0x19_ebcb;    /* jmp 0xebcb */
        l_0x19_ebc5:
            ii(0x19_ebc5, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x19_ebc8, 3); jmp(0x19_ebfb, 0x30); goto l_0x19_ebfb;   /* jmp 0xebfb */
        l_0x19_ebcb:
            ii(0x19_ebcb, 5); mov(memw[ss, bp - 0x12], 0x9860);         /* mov word [bp-0x12], 0x9860 */
            ii(0x19_ebd0, 5); mov(memw[ss, bp - 0x10], 0x88);           /* mov word [bp-0x10], 0x88 */
            ii(0x19_ebd5, 3); mov(ax, memw[ss, bp - 0x12]);             /* mov ax, [bp-0x12] */
            ii(0x19_ebd8, 3); mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x19_ebdb, 5); mov(memw[ss, bp - 0x16], 0);              /* mov word [bp-0x16], 0x0 */
            ii(0x19_ebe0, 3); mov(ax, memw[ss, bp - 0x10]);             /* mov ax, [bp-0x10] */
            ii(0x19_ebe3, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x19_ebe6, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x19_ebe9, 1); push(ss);                                 /* push ss */
            ii(0x19_ebea, 1); push(ax);                                 /* push ax */
            ii(0x19_ebeb, 2); push(0x33);                               /* push 0x33 */
            ii(0x19_ebed, 5); call_far_abs(0x80, 0xb38);                /* call word 0x80:0xb38 */
            ii(0x19_ebf2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_ebf5, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_ebf8, 3); jmp(0x19_ebfb, 0); goto l_0x19_ebfb;      /* jmp 0xebfb */
        l_0x19_ebfb:
            ii(0x19_ebfb, 1); pop(si);                                  /* pop si */
            ii(0x19_ebfc, 1); pop(di);                                  /* pop di */
            ii(0x19_ebfd, 1); leave();                                  /* leave */
            ii(0x19_ebfe, 1); retf();                                   /* retf */
        }
    }
}
