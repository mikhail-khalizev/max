using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc04cc50-0687-4296-bfe3-8999276e04ce")]
        public void Method_0018_dff6()
        {
            ii(0x18_dff6, 2); pushad();                                 /* pushad */
            ii(0x18_dff8, 1); pushw(es);                                /* push es */
            ii(0x18_dff9, 1); pushw(ds);                                /* push ds */
            ii(0x18_dffa, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_dffc, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x18_dfff, 4); lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x18_e003, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x18_e008, 2); if(jbw(0x18_e010, 0x6)) goto l_0x18_e010; /* jb 0xe010 */
            ii(0x18_e00a, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x18_e00e, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x18_e010:
            ii(0x18_e010, 4); mov(bx, memw_a32[ss, ebp + 0x28]);        /* mov bx, [ebp+0x28] */
            ii(0x18_e014, 3); cmp(bx, 0x71);                            /* cmp bx, 0x71 */
            ii(0x18_e017, 2); if(jbw(0x18_e024, 0xb)) goto l_0x18_e024; /* jb 0xe024 */
            ii(0x18_e019, 4); lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x18_e01d, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x18_e022, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x18_e024:
            ii(0x18_e024, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x18_e026, 1); pushw(bx);                                /* push bx */
            ii(0x18_e027, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x18_e029, 5); and(esi, memd_a32[ss, ebp - 0x4]);        /* and esi, [ebp-0x4] */
            ii(0x18_e02e, 5); and(edi, memd_a32[ss, ebp - 0x4]);        /* and edi, [ebp-0x4] */
            ii(0x18_e033, 3); cmp(ah, 0xf);                             /* cmp ah, 0xf */
            ii(0x18_e036, 2); if(jaew(0x18_e062, 0x2a)) goto l_0x18_e062; /* jae 0xe062 */
            ii(0x18_e038, 5); and(memb_a32[ss, ebp + 0x2c], -0x2 /* 0xfe */); /* and byte [ebp+0x2c], 0xfe */
            ii(0x18_e03d, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x18_e03f, 2); mov(bl, ah);                              /* mov bl, ah */
            ii(0x18_e041, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x18_e043, 5); mov(si, memw_a16[cs, bx + 0x44b8]);       /* mov si, [cs:bx+0x44b8] */
            ii(0x18_e048, 2); xor(ah, ah);                              /* xor ah, ah */
            ii(0x18_e04a, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_e04c, 4); mov(ax, memw_a16[cs, si - 0x2]);          /* mov ax, [cs:si-0x2] */
            ii(0x18_e050, 2); test(al, al);                             /* test al, al */
            ii(0x18_e052, 2); if(jsw(0x18_e05e, 0xa)) goto l_0x18_e05e; /* js 0xe05e */
            ii(0x18_e054, 2); cmp(bl, ah);                              /* cmp bl, ah */
            ii(0x18_e056, 2); if(jaew(0x18_e062, 0xa)) goto l_0x18_e062; /* jae 0xe062 */
            ii(0x18_e058, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x18_e05a, 1); cld();                                    /* cld */
            ii(0x18_e05b, 3); if(jmpw_abs(memw_a16[cs, bx + si])) return; /* jmp word [cs:bx+si] */
        l_0x18_e05e:
            ii(0x18_e05e, 4); if(jmpw_a16_far_ind(cs, si - 0x6)) return; /* jmp far word [cs:si-0x6] */
        l_0x18_e062:
            ii(0x18_e062, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x18_e067, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_e06a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e06b, 1); popw(es);                                 /* pop es */
            ii(0x18_e06c, 2); popad();                                  /* popad */
            ii(0x18_e06e, 2); iretd(); return;                          /* iretd */
        }
    }
}
