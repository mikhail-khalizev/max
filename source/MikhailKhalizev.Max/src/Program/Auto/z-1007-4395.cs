using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4395-9e2e045d")]
        public void Method_1007_4395()
        {
            ii(0x1007_4395, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_439a, 5); calld(Definitions.sys_check_available_stack_size, 0xf_19b3); /* call 0x10165d52 */
            ii(0x1007_439f, 1); pushd(esi);                             /* push esi */
            ii(0x1007_43a0, 1); pushd(edi);                             /* push edi */
            ii(0x1007_43a1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_43a2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_43a4, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_43aa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_43ad, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1007_43b0, 3); mov(memb_a32[ss, ebp - 0x8], bl);       /* mov [ebp-0x8], bl */
            ii(0x1007_43b3, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1007_43b6, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1007_43ba, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_43be, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_43c3, 5); calld(0x1010_3541, 0x8_f179);           /* call 0x10103541 */
            ii(0x1007_43c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_43ca, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_43cd, 5); calld(0x1007_64b8, 0x20e6);             /* call 0x100764b8 */
        l_0x1007_43d2:
            ii(0x1007_43d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_43d4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_43d7, 5); calld(0x1013_ad71, 0xc_6995);           /* call 0x1013ad71 */
            ii(0x1007_43dc, 2); test(al, al);                           /* test al, al */
            ii(0x1007_43de, 6); if(jzd(0x1007_44c9, 0xe5)) goto l_0x1007_44c9; /* jz 0x100744c9 */
            ii(0x1007_43e4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_43e7, 5); calld(0x1007_63a0, 0x1fb4);             /* call 0x100763a0 */
            ii(0x1007_43ec, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_43f0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_43f3, 5); jmpd(0x1007_4476, 0x7e); goto l_0x1007_4476; /* jmp 0x10074476 */
        l_0x1007_43f8:
            ii(0x1007_43f8, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1007_43fc, 2); if(jzd(0x1007_4418, 0x1a)) goto l_0x1007_4418; /* jz 0x10074418 */
            ii(0x1007_43fe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4401, 5); calld(0x1007_6408, 0x2002);             /* call 0x10076408 */
            ii(0x1007_4406, 5); calld(0x1015_bdae, 0xe_79a3);           /* call 0x1015bdae */
            ii(0x1007_440b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_440e, 5); calld(0x1007_6408, 0x1ff5);             /* call 0x10076408 */
            ii(0x1007_4413, 5); calld(0x1015_f2cc, 0xe_aeb4);           /* call 0x1015f2cc */
        l_0x1007_4418:
            ii(0x1007_4418, 5); jmpd(0x1007_44bc, 0x9f); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_441d:
            ii(0x1007_441d, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_4421, 2); if(jzd(0x1007_4430, 0xd)) goto l_0x1007_4430; /* jz 0x10074430 */
            ii(0x1007_4423, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4426, 5); calld(0x1007_6408, 0x1fdd);             /* call 0x10076408 */
            ii(0x1007_442b, 5); calld(0x1015_f2cc, 0xe_ae9c);           /* call 0x1015f2cc */
        l_0x1007_4430:
            ii(0x1007_4430, 5); jmpd(0x1007_44bc, 0x87); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_4435:
            ii(0x1007_4435, 4); cmp(memb_a32[ss, ebp + 0x14], 0);       /* cmp byte [ebp+0x14], 0x0 */
            ii(0x1007_4439, 2); if(jzd(0x1007_4448, 0xd)) goto l_0x1007_4448; /* jz 0x10074448 */
            ii(0x1007_443b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_443e, 5); calld(0x1007_63d4, 0x1f91);             /* call 0x100763d4 */
            ii(0x1007_4443, 5); calld(0x1015_f2cc, 0xe_ae84);           /* call 0x1015f2cc */
        l_0x1007_4448:
            ii(0x1007_4448, 5); jmpd(0x1007_44bc, 0x6f); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_444d:
            ii(0x1007_444d, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1007_4451, 2); if(jzd(0x1007_4460, 0xd)) goto l_0x1007_4460; /* jz 0x10074460 */
            ii(0x1007_4453, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4456, 5); calld(0x1007_6408, 0x1fad);             /* call 0x10076408 */
            ii(0x1007_445b, 5); calld(0x1015_f2cc, 0xe_ae6c);           /* call 0x1015f2cc */
        l_0x1007_4460:
            ii(0x1007_4460, 5); jmpd(0x1007_44bc, 0x57); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_4465:
            ii(0x1007_4465, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4468, 5); calld(0x1007_6408, 0x1f9b);             /* call 0x10076408 */
            ii(0x1007_446d, 5); calld(0x1015_f2cc, 0xe_ae5a);           /* call 0x1015f2cc */
            ii(0x1007_4472, 2); jmpd(0x1007_44bc, 0x48); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_4474:
            ii(0x1007_4474, 2); jmpd(0x1007_44bc, 0x46); goto l_0x1007_44bc; /* jmp 0x100744bc */
        l_0x1007_4476:
            ii(0x1007_4476, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_4479, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_447c, 5); cmp(memw_a32[ss, ebp - 0x1c], 0xf);     /* cmp word [ebp-0x1c], 0xf */
            ii(0x1007_4481, 2); if(jbd(0x1007_44a3, 0x20)) goto l_0x1007_44a3; /* jb 0x100744a3 */
            ii(0x1007_4483, 5); cmp(memw_a32[ss, ebp - 0x1c], 0x10);    /* cmp word [ebp-0x1c], 0x10 */
            ii(0x1007_4488, 2); if(jbed(0x1007_4465, -0x25)) goto l_0x1007_4465; /* jbe 0x10074465 */
            ii(0x1007_448a, 5); cmp(memw_a32[ss, ebp - 0x1c], 0x13);    /* cmp word [ebp-0x1c], 0x13 */
            ii(0x1007_448f, 2); if(jbd(0x1007_44a1, 0x10)) goto l_0x1007_44a1; /* jb 0x100744a1 */
            ii(0x1007_4491, 5); cmp(memw_a32[ss, ebp - 0x1c], 0x14);    /* cmp word [ebp-0x1c], 0x14 */
            ii(0x1007_4496, 2); if(jbed(0x1007_4465, -0x33)) goto l_0x1007_4465; /* jbe 0x10074465 */
            ii(0x1007_4498, 5); cmp(memw_a32[ss, ebp - 0x1c], 0x15);    /* cmp word [ebp-0x1c], 0x15 */
            ii(0x1007_449d, 2); if(jzd(0x1007_4435, -0x6a)) goto l_0x1007_4435; /* jz 0x10074435 */
            ii(0x1007_449f, 2); jmpd(0x1007_4474, -0x2d); goto l_0x1007_4474; /* jmp 0x10074474 */
        l_0x1007_44a1:
            ii(0x1007_44a1, 2); jmpd(0x1007_444d, -0x56); goto l_0x1007_444d; /* jmp 0x1007444d */
        l_0x1007_44a3:
            ii(0x1007_44a3, 5); cmp(memw_a32[ss, ebp - 0x1c], 0xc);     /* cmp word [ebp-0x1c], 0xc */
            ii(0x1007_44a8, 2); if(jbd(0x1007_44ba, 0x10)) goto l_0x1007_44ba; /* jb 0x100744ba */
            ii(0x1007_44aa, 5); cmp(memw_a32[ss, ebp - 0x1c], 0xc);     /* cmp word [ebp-0x1c], 0xc */
            ii(0x1007_44af, 6); if(jbed(0x1007_43f8, -0xbd)) goto l_0x1007_43f8; /* jbe 0x100743f8 */
            ii(0x1007_44b5, 5); jmpd(0x1007_441d, -0x9d); goto l_0x1007_441d; /* jmp 0x1007441d */
        l_0x1007_44ba:
            ii(0x1007_44ba, 2); jmpd(0x1007_4474, -0x48); goto l_0x1007_4474; /* jmp 0x10074474 */
        l_0x1007_44bc:
            ii(0x1007_44bc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_44bf, 5); calld(0x1007_6bf8, 0x2734);             /* call 0x10076bf8 */
            ii(0x1007_44c4, 5); jmpd(0x1007_43d2, -0xf7); goto l_0x1007_43d2; /* jmp 0x100743d2 */
        l_0x1007_44c9:
            ii(0x1007_44c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_44cb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_44ce, 5); calld(0x1007_5f6c, 0x1a99);             /* call 0x10075f6c */
            ii(0x1007_44d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_44d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_44d6, 1); popd(edi);                              /* pop edi */
            ii(0x1007_44d7, 1); popd(esi);                              /* pop esi */
            ii(0x1007_44d8, 3); retd(0x8);                              /* ret 0x8 */
        }
    }
}
