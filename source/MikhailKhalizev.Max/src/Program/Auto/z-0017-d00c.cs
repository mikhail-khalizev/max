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
            ii(0x17_d016, 4); if(ja(0x17_d03a, 0x20)) goto l_0x17_d03a; /* ja 0xd03a */
            ii(0x17_d01a, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_d01d, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d01e, 3); call(0x17_ceac, -0x175);                  /* call 0xceac */
            ii(0x17_d021, 1); push(bx);                                 /* push bx */
            ii(0x17_d022, 1); push(ss);                                 /* push ss */
            ii(0x17_d023, 1); push(bp);                                 /* push bp */
            ii(0x17_d024, 1); nop();                                    /* nop */
            ii(0x17_d025, 1); push(cs);                                 /* push cs */
            ii(0x17_d026, 3); call(0x17_9836, -0x37f3);                 /* call 0x9836 */
            ii(0x17_d029, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d02a, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d02b, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d02c, 3); call(0x17_cf26, -0x109);                  /* call 0xcf26 */
            ii(0x17_d02f, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d031, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_d033, 4); if(jnz(0x17_d0ab, 0x74)) goto l_0x17_d0ab; /* jnz 0xd0ab */
            ii(0x17_d037, 2); jmp(0x17_d0b0, 0x77); goto l_0x17_d0b0;   /* jmp 0xd0b0 */
        //  ii(0x17_d039, 1); nop();                                    /* nop */
        l_0x17_d03a:
            ii(0x17_d03a, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d03c, 5); if(jmp_far_ind(memw[cs, -0x7980])) return; /* jmp far word [cs:0x8680] */
            ii(0x17_d041, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_d043, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x17_d048, 3); cmp(bl, 0x4);                             /* cmp bl, 0x4 */
            ii(0x17_d04b, 4); if(ja(0x17_d06f, 0x20)) goto l_0x17_d06f; /* ja 0xd06f */
            ii(0x17_d04f, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_d052, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d053, 3); call(0x17_ceac, -0x1aa);                  /* call 0xceac */
            ii(0x17_d056, 1); push(bx);                                 /* push bx */
            ii(0x17_d057, 1); push(ss);                                 /* push ss */
            ii(0x17_d058, 1); push(bp);                                 /* push bp */
            ii(0x17_d059, 1); nop();                                    /* nop */
            ii(0x17_d05a, 1); push(cs);                                 /* push cs */
            ii(0x17_d05b, 3); call(0x17_98a6, -0x37b8);                 /* call 0x98a6 */
            ii(0x17_d05e, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d05f, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d060, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d061, 3); call(0x17_cf26, -0x13e);                  /* call 0xcf26 */
            ii(0x17_d064, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d066, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_d068, 4); if(jnz(0x17_d0ab, 0x3f)) goto l_0x17_d0ab; /* jnz 0xd0ab */
            ii(0x17_d06c, 2); jmp(0x17_d0b0, 0x42); goto l_0x17_d0b0;   /* jmp 0xd0b0 */
        //  ii(0x17_d06e, 1); nop();                                    /* nop */
        l_0x17_d06f:
            ii(0x17_d06f, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d071, 5); if(jmp_far_ind(memw[cs, -0x797c])) return; /* jmp far word [cs:0x8684] */
            ii(0x17_d076, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_d078, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x17_d07d, 3); cmp(bl, 0x1);                             /* cmp bl, 0x1 */
            ii(0x17_d080, 4); if(ja(0x17_d0a4, 0x20)) goto l_0x17_d0a4; /* ja 0xd0a4 */
            ii(0x17_d084, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_d087, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d088, 3); call(0x17_ceac, -0x1df);                  /* call 0xceac */
            ii(0x17_d08b, 1); push(bx);                                 /* push bx */
            ii(0x17_d08c, 1); push(ss);                                 /* push ss */
            ii(0x17_d08d, 1); push(bp);                                 /* push bp */
            ii(0x17_d08e, 1); nop();                                    /* nop */
            ii(0x17_d08f, 1); push(cs);                                 /* push cs */
            ii(0x17_d090, 3); call(0x17_9904, -0x378f);                 /* call 0x9904 */
            ii(0x17_d093, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d094, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d095, 1); pop(bx);                                  /* pop bx */
            ii(0x17_d096, 3); call(0x17_cf26, -0x173);                  /* call 0xcf26 */
            ii(0x17_d099, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d09b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_d09d, 4); if(jnz(0x17_d0ab, 0xa)) goto l_0x17_d0ab; /* jnz 0xd0ab */
            ii(0x17_d0a1, 2); jmp(0x17_d0b0, 0xd); goto l_0x17_d0b0;    /* jmp 0xd0b0 */
        //  ii(0x17_d0a3, 1); nop();                                    /* nop */
        l_0x17_d0a4:
            ii(0x17_d0a4, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d0a6, 5); if(jmp_far_ind(memw[cs, -0x7978])) return; /* jmp far word [cs:0x8688] */
        l_0x17_d0ab:
            ii(0x17_d0ab, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
        l_0x17_d0b0:
            ii(0x17_d0b0, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x17_d0b3, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d0b4, 1); pop(es);                                  /* pop es */
            ii(0x17_d0b5, 2); popad();                                  /* popad */
            ii(0x17_d0b7, 2); iretd();                                  /* iretd */
        }
    }
}
