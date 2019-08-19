using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d00c-89ba81f9")]
        public void Method_0017_d00c()
        {
            ii(0x17_d00c, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_d00e, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x17_d013, 3); cmp(bl, 0x4);                             /* cmp bl, 0x4 */
            ii(0x17_d016, 4); if(jaw(0x17_d03a, 0x20)) goto l_0x17_d03a; /* ja 0xd03a */
            ii(0x17_d01a, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x17_d01d, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d01e, 3); callw(0x17_ceac, -0x175);                 /* call 0xceac */
            ii(0x17_d021, 1); pushw(bx);                                /* push bx */
            ii(0x17_d022, 1); pushw(ss);                                /* push ss */
            ii(0x17_d023, 1); pushw(bp);                                /* push bp */
            ii(0x17_d024, 1); nop();                                    /* nop */
            ii(0x17_d025, 1); pushw(cs);                                /* push cs */
            ii(0x17_d026, 3); callw(0x17_9836, -0x37f3);                /* call 0x9836 */
            ii(0x17_d029, 1); popw(bp);                                 /* pop bp */
            ii(0x17_d02a, 1); popw(bx);                                 /* pop bx */
            ii(0x17_d02b, 1); popw(bx);                                 /* pop bx */
            ii(0x17_d02c, 3); callw(0x17_cf26, -0x109);                 /* call 0xcf26 */
            ii(0x17_d02f, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d031, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_d033, 4); if(jnzw(0x17_d0ab, 0x74)) goto l_0x17_d0ab; /* jnz 0xd0ab */
            ii(0x17_d037, 2); jmpw(0x17_d0b0, 0x77); goto l_0x17_d0b0;  /* jmp 0xd0b0 */
        //  ii(0x17_d039, 1); Недостижимый код.
        l_0x17_d03a:
            ii(0x17_d03a, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d03c, 5); if(jmpw_a16_far_ind(cs, -0x7980)) return; /* jmp far word [cs:0x8680] */
        //  ii(0x17_d041, 106); Недостижимый код.
        l_0x17_d0ab:
            ii(0x17_d0ab, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
        l_0x17_d0b0:
            ii(0x17_d0b0, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x17_d0b3, 1); popw(ds);                                 /* pop ds */
            ii(0x17_d0b4, 1); popw(es);                                 /* pop es */
            ii(0x17_d0b5, 2); popad();                                  /* popad */
            ii(0x17_d0b7, 2); iretd(); return;                          /* iretd */
        }
    }
}
