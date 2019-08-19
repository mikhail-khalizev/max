using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_bbf8-31c38711")]
        public void Method_0017_bbf8()
        {
            ii(0x17_bbf8, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x17_bbfc, 1); pushw(ds);                                /* push ds */
            ii(0x17_bbfd, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_bc00, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_bc02, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bc04, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_bc07, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_bc0a, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_bc0d, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_bc10, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_bc13, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_bc16, 5); mov(memw_a16[ss, bp - 0x4], 0xffff);      /* mov word [bp-0x4], 0xffff */
            ii(0x17_bc1b, 5); mov(memw_a16[ss, bp - 0x2], 0xffff);      /* mov word [bp-0x2], 0xffff */
            ii(0x17_bc20, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_bc23, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_bc26, 2); jmpw(0x17_bc30, 0x8); goto l_0x17_bc30;   /* jmp 0xbc30 */
        l_0x17_bc28:
            ii(0x17_bc28, 4); add(memw_a16[ss, bp - 0xc], 0x1);         /* add word [bp-0xc], 0x1 */
            ii(0x17_bc2c, 4); adc(memw_a16[ss, bp - 0xa], 0);           /* adc word [bp-0xa], 0x0 */
        l_0x17_bc30:
            ii(0x17_bc30, 3); mov(ax, memw_a16[ds, 0x4fd0]);            /* mov ax, [0x4fd0] */
            ii(0x17_bc33, 4); mov(dx, memw_a16[ds, 0x4fd2]);            /* mov dx, [0x4fd2] */
            ii(0x17_bc37, 3); cmp(memw_a16[ss, bp - 0xa], dx);          /* cmp [bp-0xa], dx */
            ii(0x17_bc3a, 2); if(jaw(0x17_bcae, 0x72)) goto l_0x17_bcae; /* ja 0xbcae */
            ii(0x17_bc3c, 2); if(jbw(0x17_bc43, 0x5)) goto l_0x17_bc43; /* jb 0xbc43 */
            ii(0x17_bc3e, 3); cmp(memw_a16[ss, bp - 0xc], ax);          /* cmp [bp-0xc], ax */
            ii(0x17_bc41, 2); if(jaew(0x17_bcae, 0x6b)) goto l_0x17_bcae; /* jae 0xbcae */
        l_0x17_bc43:
            ii(0x17_bc43, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_bc46, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_bc49, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_bc4d, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_bc51, 3); callw(0x17_90c4, -0x2b90);                /* call 0x90c4 */
            ii(0x17_bc54, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_bc57, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_bc59, 2); if(jnzw(0x17_bc98, 0x3d)) goto l_0x17_bc98; /* jnz 0xbc98 */
            ii(0x17_bc5b, 4); add(memw_a16[ss, bp - 0x14], 0x1);        /* add word [bp-0x14], 0x1 */
            ii(0x17_bc5f, 4); adc(memw_a16[ss, bp - 0x12], 0);          /* adc word [bp-0x12], 0x0 */
            ii(0x17_bc63, 4); cmp(memw_a16[ss, bp - 0x4], -0x1 /* 0xff */); /* cmp word [bp-0x4], 0xffff */
            ii(0x17_bc67, 2); if(jnzw(0x17_bc7b, 0x12)) goto l_0x17_bc7b; /* jnz 0xbc7b */
            ii(0x17_bc69, 4); cmp(memw_a16[ss, bp - 0x2], -0x1 /* 0xff */); /* cmp word [bp-0x2], 0xffff */
            ii(0x17_bc6d, 2); if(jnzw(0x17_bc7b, 0xc)) goto l_0x17_bc7b; /* jnz 0xbc7b */
            ii(0x17_bc6f, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x17_bc72, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x17_bc75, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_bc78, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_bc7b:
            ii(0x17_bc7b, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_bc7e, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_bc81, 3); cmp(memw_a16[ss, bp - 0x14], ax);         /* cmp [bp-0x14], ax */
            ii(0x17_bc84, 2); if(jnzw(0x17_bc96, 0x10)) goto l_0x17_bc96; /* jnz 0xbc96 */
            ii(0x17_bc86, 3); cmp(memw_a16[ss, bp - 0x12], dx);         /* cmp [bp-0x12], dx */
            ii(0x17_bc89, 2); if(jnzw(0x17_bc96, 0xb)) goto l_0x17_bc96; /* jnz 0xbc96 */
            ii(0x17_bc8b, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_bc8e, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_bc91, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bc92, 1); leavew();                                 /* leave */
            ii(0x17_bc93, 1); retfw(); return;                          /* retf */
        //  ii(0x17_bc94, 2); Недостижимый код.
        l_0x17_bc96:
            ii(0x17_bc96, 2); jmpw(0x17_bcaa, 0x12); goto l_0x17_bcaa;  /* jmp 0xbcaa */
        l_0x17_bc98:
            ii(0x17_bc98, 5); mov(memw_a16[ss, bp - 0x4], 0xffff);      /* mov word [bp-0x4], 0xffff */
            ii(0x17_bc9d, 5); mov(memw_a16[ss, bp - 0x2], 0xffff);      /* mov word [bp-0x2], 0xffff */
            ii(0x17_bca2, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_bca4, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_bca7, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
        l_0x17_bcaa:
            ii(0x17_bcaa, 3); jmpw(0x17_bc28, -0x85); goto l_0x17_bc28; /* jmp 0xbc28 */
        //  ii(0x17_bcad, 1); nop();                                    /* nop */
        l_0x17_bcae:
            ii(0x17_bcae, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_bcb1, 1); cwd();                                    /* cwd */
            ii(0x17_bcb2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_bcb3, 1); leavew();                                 /* leave */
            ii(0x17_bcb4, 1); retfw(); return;                          /* retf */
        }
    }
}
