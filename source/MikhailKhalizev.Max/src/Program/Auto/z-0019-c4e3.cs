using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c4e3-a342a1f5")]
        public void Method_0019_c4e3()
        {
            ii(0x19_c4e3, 4); enterw(0x20a, 0);                         /* enter 0x20a, 0x0 */
            ii(0x19_c4e7, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_c4ea, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_c4ed, 4); mov(memw_a16[ss, bp - 0x20a], ax);        /* mov [bp-0x20a], ax */
            ii(0x19_c4f1, 4); mov(memw_a16[ss, bp - 0x208], dx);        /* mov [bp-0x208], dx */
            ii(0x19_c4f5, 4); cmp(memw_a16[ss, bp + 0xc], -0x1 /* 0xff */); /* cmp word [bp+0xc], 0xffff */
            ii(0x19_c4f9, 2); if(jnzw(0x19_c501, 0x6)) goto l_0x19_c501; /* jnz 0xc501 */
            ii(0x19_c4fb, 4); cmp(memw_a16[ss, bp + 0xe], -0x1 /* 0xff */); /* cmp word [bp+0xe], 0xffff */
            ii(0x19_c4ff, 2); if(jzw(0x19_c539, 0x38)) goto l_0x19_c539; /* jz 0xc539 */
        l_0x19_c501:
            ii(0x19_c501, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x19_c504, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x19_c507, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_c50a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_c50c, 3); callw(0x19_fed2, 0x39c3);                 /* call 0xfed2 */
            ii(0x19_c50f, 3); cmp(ax, memw_a16[ss, bp + 0xc]);          /* cmp ax, [bp+0xc] */
            ii(0x19_c512, 2); if(jnzw(0x19_c519, 0x5)) goto l_0x19_c519; /* jnz 0xc519 */
            ii(0x19_c514, 3); cmp(dx, memw_a16[ss, bp + 0xe]);          /* cmp dx, [bp+0xe] */
            ii(0x19_c517, 2); if(jzw(0x19_c539, 0x20)) goto l_0x19_c539; /* jz 0xc539 */
        l_0x19_c519:
            ii(0x19_c519, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c51b, 1); cwd();                                    /* cwd */
            ii(0x19_c51c, 3); jmpw(0x19_c5a0, 0x81); goto l_0x19_c5a0;  /* jmp 0xc5a0 */
        l_0x19_c51f:
            ii(0x19_c51f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_c522, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_c525, 3); callw(0x19_df78, 0x1a50);                 /* call 0xdf78 */
            ii(0x19_c528, 4); mov(ax, memw_a16[ss, bp - 0x206]);        /* mov ax, [bp-0x206] */
            ii(0x19_c52c, 1); cwd();                                    /* cwd */
            ii(0x19_c52d, 3); sub(memw_a16[ss, bp + 0x4], ax);          /* sub [bp+0x4], ax */
            ii(0x19_c530, 3); sbb(memw_a16[ss, bp + 0x6], dx);          /* sbb [bp+0x6], dx */
            ii(0x19_c533, 3); add(memw_a16[ss, bp + 0x8], ax);          /* add [bp+0x8], ax */
            ii(0x19_c536, 3); adc(memw_a16[ss, bp + 0xa], dx);          /* adc [bp+0xa], dx */
        l_0x19_c539:
            ii(0x19_c539, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_c53c, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_c53f, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x19_c541, 2); if(jlw(0x19_c54f, 0xc)) goto l_0x19_c54f; /* jl 0xc54f */
            ii(0x19_c543, 2); if(jgw(0x19_c54a, 0x5)) goto l_0x19_c54a; /* jg 0xc54a */
            ii(0x19_c545, 3); cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x19_c548, 2); if(jbew(0x19_c54f, 0x5)) goto l_0x19_c54f; /* jbe 0xc54f */
        l_0x19_c54a:
            ii(0x19_c54a, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_c54c, 3); mov(ax, 0x1000);                          /* mov ax, 0x1000 */
        l_0x19_c54f:
            ii(0x19_c54f, 4); mov(memw_a16[ss, bp - 0x206], ax);        /* mov [bp-0x206], ax */
            ii(0x19_c553, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_c555, 2); if(jzw(0x19_c598, 0x41)) goto l_0x19_c598; /* jz 0xc598 */
            ii(0x19_c557, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x19_c55a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_c55c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_c55e, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_c561, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_c564, 1); cwd();                                    /* cwd */
            ii(0x19_c565, 1); pushw(dx);                                /* push dx */
            ii(0x19_c566, 1); pushw(ax);                                /* push ax */
            ii(0x19_c567, 3); callw(0x19_de46, 0x18dc);                 /* call 0xde46 */
            ii(0x19_c56a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_c56d, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_c570, 1); pushw(dx);                                /* push dx */
            ii(0x19_c571, 1); pushw(ax);                                /* push ax */
            ii(0x19_c572, 4); pushw(memw_a16[ss, bp - 0x206]);          /* push word [bp-0x206] */
            ii(0x19_c576, 3); callw(0x19_fef1, 0x3978);                 /* call 0xfef1 */
            ii(0x19_c579, 4); cmp(memw_a16[ss, bp - 0x206], ax);        /* cmp [bp-0x206], ax */
            ii(0x19_c57d, 2); if(jzw(0x19_c51f, -0x60)) goto l_0x19_c51f; /* jz 0xc51f */
            ii(0x19_c57f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_c582, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_c585, 3); callw(0x19_df78, 0x19f0);                 /* call 0xdf78 */
            ii(0x19_c588, 4); mov(ax, memw_a16[ss, bp - 0x20a]);        /* mov ax, [bp-0x20a] */
            ii(0x19_c58c, 4); mov(dx, memw_a16[ss, bp - 0x208]);        /* mov dx, [bp-0x208] */
            ii(0x19_c590, 3); sub(ax, memw_a16[ss, bp + 0x4]);          /* sub ax, [bp+0x4] */
            ii(0x19_c593, 3); sbb(dx, memw_a16[ss, bp + 0x6]);          /* sbb dx, [bp+0x6] */
            ii(0x19_c596, 2); jmpw(0x19_c5a0, 0x8); goto l_0x19_c5a0;   /* jmp 0xc5a0 */
        l_0x19_c598:
            ii(0x19_c598, 4); mov(ax, memw_a16[ss, bp - 0x20a]);        /* mov ax, [bp-0x20a] */
            ii(0x19_c59c, 4); mov(dx, memw_a16[ss, bp - 0x208]);        /* mov dx, [bp-0x208] */
        l_0x19_c5a0:
            ii(0x19_c5a0, 1); leavew();                                 /* leave */
            ii(0x19_c5a1, 3); retw(0xe);                                /* ret 0xe */
        }
    }
}
