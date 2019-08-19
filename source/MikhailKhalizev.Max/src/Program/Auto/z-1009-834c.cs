using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_834c-ce986989")]
        public void Method_1009_834c()
        {
            ii(0x1009_834c, 5); pushd(0x70);                            /* push 0x70 */
            ii(0x1009_8351, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d9fc); /* call 0x10165d52 */
            ii(0x1009_8356, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_8357, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_8358, 1); pushd(edx);                             /* push edx */
            ii(0x1009_8359, 1); pushd(esi);                             /* push esi */
            ii(0x1009_835a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_835b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_835c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_835e, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1009_8364, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_8367, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1009_836b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_836e, 5); calld(0x1008_bbed, -0xc786);            /* call 0x1008bbed */
            ii(0x1009_8373, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_8376, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1009_837a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_837d, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_1892); /* call 0x10076af0 */
            ii(0x1009_8382, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8385, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_8388, 5); calld(0x1007_6b90, -0x2_17fd);          /* call 0x10076b90 */
            ii(0x1009_838d, 1); cwde();                                 /* cwde */
            ii(0x1009_838e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_8390, 2); if(jnzd(0x1009_83a2, 0x10)) goto l_0x1009_83a2; /* jnz 0x100983a2 */
            ii(0x1009_8392, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8395, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_8398, 5); calld(0x1007_6b90, -0x2_180d);          /* call 0x10076b90 */
            ii(0x1009_839d, 1); cwde();                                 /* cwde */
            ii(0x1009_839e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_83a0, 2); if(jzd(0x1009_83a4, 0x2)) goto l_0x1009_83a4; /* jz 0x100983a4 */
        l_0x1009_83a2:
            ii(0x1009_83a2, 2); jmpd(0x1009_83b7, 0x13); goto l_0x1009_83b7; /* jmp 0x100983b7 */
        l_0x1009_83a4:
            ii(0x1009_83a4, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_83a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_83aa, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_83ad, 5); calld(0x1008_bc9f, -0xc713);            /* call 0x1008bc9f */
            ii(0x1009_83b2, 5); jmpd(0x1009_8753, 0x39c); goto l_0x1009_8753; /* jmp 0x10098753 */
        l_0x1009_83b7:
            ii(0x1009_83b7, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1009_83ba, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_83bd, 5); calld(0x1008_a6f8, -0xdcca);            /* call 0x1008a6f8 */
            ii(0x1009_83c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_83c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_83c7, 5); calld(0x1009_71d8, -0x11f4);            /* call 0x100971d8 */
            ii(0x1009_83cc, 2); test(al, al);                           /* test al, al */
            ii(0x1009_83ce, 2); if(jnzd(0x1009_83e3, 0x13)) goto l_0x1009_83e3; /* jnz 0x100983e3 */
            ii(0x1009_83d0, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_83d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_83d6, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_83d9, 5); calld(0x1008_bc9f, -0xc73f);            /* call 0x1008bc9f */
            ii(0x1009_83de, 5); jmpd(0x1009_8753, 0x370); goto l_0x1009_8753; /* jmp 0x10098753 */
        l_0x1009_83e3:
            ii(0x1009_83e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_83e6, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_83e9, 5); calld(0x1009_c6c8, 0x42da);             /* call 0x1009c6c8 */
            ii(0x1009_83ee, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_83f1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_83f3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_83f5, 5); calld(0x1009_c5dc, 0x41e2);             /* call 0x1009c5dc */
            ii(0x1009_83fa, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1009_83ff, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_8402, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_8405, 5); calld(0x1007_5e64, -0x2_25a6);          /* call 0x10075e64 */
            ii(0x1009_840a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_840c, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_840f, 5); calld(0x1008_a6f8, -0xdd1c);            /* call 0x1008a6f8 */
            ii(0x1009_8414, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8416, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8419, 5); calld(0x1009_7545, -0xed9);             /* call 0x10097545 */
            ii(0x1009_841e, 2); jmpd(0x1009_8428, 0x8); goto l_0x1009_8428; /* jmp 0x10098428 */
        l_0x1009_8420:
            ii(0x1009_8420, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_8423, 5); calld(0x1007_6bf8, -0x2_1830);          /* call 0x10076bf8 */
        l_0x1009_8428:
            ii(0x1009_8428, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_842a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_842d, 5); calld(0x1013_ad71, 0xa_293f);           /* call 0x1013ad71 */
            ii(0x1009_8432, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8434, 6); if(jzd(0x1009_8532, 0xf8)) goto l_0x1009_8532; /* jz 0x10098532 */
            ii(0x1009_843a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_843d, 5); calld(0x1009_c4f8, 0x40b6);             /* call 0x1009c4f8 */
            ii(0x1009_8442, 5); calld(0x1009_c4c4, 0x407d);             /* call 0x1009c4c4 */
            ii(0x1009_8447, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_844a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_844d, 5); calld(0x1009_c4f8, 0x40a6);             /* call 0x1009c4f8 */
            ii(0x1009_8452, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_8455, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_8458, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_845b, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_845e, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_8461, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8463, 2); if(jzd(0x1009_846c, 0x7)) goto l_0x1009_846c; /* jz 0x1009846c */
            ii(0x1009_8465, 5); cmp(memw_a32[ss, ebp - 0x14], 0xc);     /* cmp word [ebp-0x14], 0xc */
            ii(0x1009_846a, 2); if(jnzd(0x1009_846e, 0x2)) goto l_0x1009_846e; /* jnz 0x1009846e */
        l_0x1009_846c:
            ii(0x1009_846c, 2); jmpd(0x1009_8475, 0x7); goto l_0x1009_8475; /* jmp 0x10098475 */
        l_0x1009_846e:
            ii(0x1009_846e, 5); cmp(memw_a32[ss, ebp - 0x14], 0x21);    /* cmp word [ebp-0x14], 0x21 */
            ii(0x1009_8473, 2); if(jnzd(0x1009_8477, 0x2)) goto l_0x1009_8477; /* jnz 0x10098477 */
        l_0x1009_8475:
            ii(0x1009_8475, 2); jmpd(0x1009_847e, 0x7); goto l_0x1009_847e; /* jmp 0x1009847e */
        l_0x1009_8477:
            ii(0x1009_8477, 5); cmp(memw_a32[ss, ebp - 0x14], 0x27);    /* cmp word [ebp-0x14], 0x27 */
            ii(0x1009_847c, 2); if(jnzd(0x1009_8483, 0x5)) goto l_0x1009_8483; /* jnz 0x10098483 */
        l_0x1009_847e:
            ii(0x1009_847e, 5); jmpd(0x1009_852d, 0xaa); goto l_0x1009_852d; /* jmp 0x1009852d */
        l_0x1009_8483:
            ii(0x1009_8483, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_8486, 5); calld(0x1009_c4f8, 0x406d);             /* call 0x1009c4f8 */
            ii(0x1009_848b, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_848e, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_8491, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_8494, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1009_8497, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_849a, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_849d, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1009_84a0, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_84a3, 5); calld(0x1008_a6f8, -0xddb0);            /* call 0x1008a6f8 */
            ii(0x1009_84a8, 5); calld(0x1009_8200, -0x2ad);             /* call 0x10098200 */
            ii(0x1009_84ad, 2); test(al, al);                           /* test al, al */
            ii(0x1009_84af, 6); if(jzd(0x1009_852d, 0x78)) goto l_0x1009_852d; /* jz 0x1009852d */
            ii(0x1009_84b5, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_84b8, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x1009_84bc, 2); jmpd(0x1009_84c5, 0x7); goto l_0x1009_84c5; /* jmp 0x100984c5 */
        l_0x1009_84be:
            ii(0x1009_84be, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_84c1, 4); inc(memw_a32[ss, ebp - 0x28]);          /* inc word [ebp-0x28] */
        l_0x1009_84c5:
            ii(0x1009_84c5, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_84c9, 3); cmp(eax, memd_a32[ss, ebp - 0x40]);     /* cmp eax, [ebp-0x40] */
            ii(0x1009_84cc, 2); if(jged(0x1009_852d, 0x5f)) goto l_0x1009_852d; /* jge 0x1009852d */
            ii(0x1009_84ce, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_84d1, 4); mov(memw_a32[ss, ebp - 0x26], ax);      /* mov [ebp-0x26], ax */
            ii(0x1009_84d5, 2); jmpd(0x1009_84de, 0x7); goto l_0x1009_84de; /* jmp 0x100984de */
        l_0x1009_84d7:
            ii(0x1009_84d7, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_84da, 4); inc(memw_a32[ss, ebp - 0x26]);          /* inc word [ebp-0x26] */
        l_0x1009_84de:
            ii(0x1009_84de, 4); movsx(eax, memw_a32[ss, ebp - 0x26]);   /* movsx eax, word [ebp-0x26] */
            ii(0x1009_84e2, 3); cmp(eax, memd_a32[ss, ebp - 0x3c]);     /* cmp eax, [ebp-0x3c] */
            ii(0x1009_84e5, 2); if(jged(0x1009_852b, 0x44)) goto l_0x1009_852b; /* jge 0x1009852b */
            ii(0x1009_84e7, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x1009_84eb, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1009_84ef, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_84f2, 5); calld(0x1008_a728, -0xddcf);            /* call 0x1008a728 */
            ii(0x1009_84f7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_84f9, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_84fb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_8500, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_8503, 2); if(jnzd(0x1009_8529, 0x24)) goto l_0x1009_8529; /* jnz 0x10098529 */
            ii(0x1009_8505, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
            ii(0x1009_850a, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_850d, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_8510, 5); calld(0x1007_5e64, -0x2_26b1);          /* call 0x10075e64 */
            ii(0x1009_8515, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_8517, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_851a, 5); calld(0x1008_a6f8, -0xde27);            /* call 0x1008a6f8 */
            ii(0x1009_851f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8521, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8524, 5); calld(0x1009_7545, -0xfe4);             /* call 0x10097545 */
        l_0x1009_8529:
            ii(0x1009_8529, 2); jmpd(0x1009_84d7, -0x54); goto l_0x1009_84d7; /* jmp 0x100984d7 */
        l_0x1009_852b:
            ii(0x1009_852b, 2); jmpd(0x1009_84be, -0x6f); goto l_0x1009_84be; /* jmp 0x100984be */
        l_0x1009_852d:
            ii(0x1009_852d, 5); jmpd(0x1009_8420, -0x112); goto l_0x1009_8420; /* jmp 0x10098420 */
        l_0x1009_8532:
            ii(0x1009_8532, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_8536, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8539, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_853c, 5); calld(0x1007_6338, -0x2_2209);          /* call 0x10076338 */
            ii(0x1009_8541, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1009_8544, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8546, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_8548, 5); calld(0x1007_64b8, -0x2_2095);          /* call 0x100764b8 */
            ii(0x1009_854d, 2); jmpd(0x1009_8557, 0x8); goto l_0x1009_8557; /* jmp 0x10098557 */
        l_0x1009_854f:
            ii(0x1009_854f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_8552, 5); calld(0x1007_6bf8, -0x2_195f);          /* call 0x10076bf8 */
        l_0x1009_8557:
            ii(0x1009_8557, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8559, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_855c, 5); calld(0x1013_ad71, 0xa_2810);           /* call 0x1013ad71 */
            ii(0x1009_8561, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8563, 6); if(jzd(0x1009_8626, 0xbd)) goto l_0x1009_8626; /* jz 0x10098626 */
            ii(0x1009_8569, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_856c, 5); calld(0x1007_63a0, -0x2_21d1);          /* call 0x100763a0 */
            ii(0x1009_8571, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_8576, 2); if(jzd(0x1009_8587, 0xf)) goto l_0x1009_8587; /* jz 0x10098587 */
            ii(0x1009_8578, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_857b, 5); calld(0x1007_63a0, -0x2_21e0);          /* call 0x100763a0 */
            ii(0x1009_8580, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_8585, 2); if(jnzd(0x1009_8589, 0x2)) goto l_0x1009_8589; /* jnz 0x10098589 */
        l_0x1009_8587:
            ii(0x1009_8587, 2); jmpd(0x1009_8598, 0xf); goto l_0x1009_8598; /* jmp 0x10098598 */
        l_0x1009_8589:
            ii(0x1009_8589, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_858c, 5); calld(0x1007_63a0, -0x2_21f1);          /* call 0x100763a0 */
            ii(0x1009_8591, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_8596, 2); if(jnzd(0x1009_859a, 0x2)) goto l_0x1009_859a; /* jnz 0x1009859a */
        l_0x1009_8598:
            ii(0x1009_8598, 2); jmpd(0x1009_85a9, 0xf); goto l_0x1009_85a9; /* jmp 0x100985a9 */
        l_0x1009_859a:
            ii(0x1009_859a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_859d, 5); calld(0x1007_63a0, -0x2_2202);          /* call 0x100763a0 */
            ii(0x1009_85a2, 5); cmp(memw_a32[ds, eax + 0x8], 0x22);     /* cmp word [eax+0x8], 0x22 */
            ii(0x1009_85a7, 2); if(jnzd(0x1009_85ab, 0x2)) goto l_0x1009_85ab; /* jnz 0x100985ab */
        l_0x1009_85a9:
            ii(0x1009_85a9, 2); jmpd(0x1009_85ba, 0xf); goto l_0x1009_85ba; /* jmp 0x100985ba */
        l_0x1009_85ab:
            ii(0x1009_85ab, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_85ae, 5); calld(0x1007_63a0, -0x2_2213);          /* call 0x100763a0 */
            ii(0x1009_85b3, 5); cmp(memw_a32[ds, eax + 0x8], 0x24);     /* cmp word [eax+0x8], 0x24 */
            ii(0x1009_85b8, 2); if(jnzd(0x1009_85bc, 0x2)) goto l_0x1009_85bc; /* jnz 0x100985bc */
        l_0x1009_85ba:
            ii(0x1009_85ba, 2); jmpd(0x1009_85cb, 0xf); goto l_0x1009_85cb; /* jmp 0x100985cb */
        l_0x1009_85bc:
            ii(0x1009_85bc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_85bf, 5); calld(0x1007_63a0, -0x2_2224);          /* call 0x100763a0 */
            ii(0x1009_85c4, 5); cmp(memw_a32[ds, eax + 0x8], 0x25);     /* cmp word [eax+0x8], 0x25 */
            ii(0x1009_85c9, 2); if(jnzd(0x1009_85cd, 0x2)) goto l_0x1009_85cd; /* jnz 0x100985cd */
        l_0x1009_85cb:
            ii(0x1009_85cb, 2); jmpd(0x1009_85dc, 0xf); goto l_0x1009_85dc; /* jmp 0x100985dc */
        l_0x1009_85cd:
            ii(0x1009_85cd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_85d0, 5); calld(0x1007_63a0, -0x2_2235);          /* call 0x100763a0 */
            ii(0x1009_85d5, 5); cmp(memw_a32[ds, eax + 0x8], 0x23);     /* cmp word [eax+0x8], 0x23 */
            ii(0x1009_85da, 2); if(jnzd(0x1009_85de, 0x2)) goto l_0x1009_85de; /* jnz 0x100985de */
        l_0x1009_85dc:
            ii(0x1009_85dc, 2); jmpd(0x1009_85ed, 0xf); goto l_0x1009_85ed; /* jmp 0x100985ed */
        l_0x1009_85de:
            ii(0x1009_85de, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_85e1, 5); calld(0x1007_63a0, -0x2_2246);          /* call 0x100763a0 */
            ii(0x1009_85e6, 5); cmp(memw_a32[ds, eax + 0x8], 0x5);      /* cmp word [eax+0x8], 0x5 */
            ii(0x1009_85eb, 2); if(jnzd(0x1009_85ef, 0x2)) goto l_0x1009_85ef; /* jnz 0x100985ef */
        l_0x1009_85ed:
            ii(0x1009_85ed, 2); jmpd(0x1009_8621, 0x32); goto l_0x1009_8621; /* jmp 0x10098621 */
        l_0x1009_85ef:
            ii(0x1009_85ef, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1009_85f2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_85f5, 5); calld(0x1007_63a0, -0x2_225a);          /* call 0x100763a0 */
            ii(0x1009_85fa, 5); calld(0x1015_2532, 0xb_9f33);           /* call 0x10152532 */
            ii(0x1009_85ff, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1009_8604, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1009_8607, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_860a, 5); calld(0x1008_a6f8, -0xdf17);            /* call 0x1008a6f8 */
            ii(0x1009_860f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8611, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8614, 5); calld(0x1009_7ee8, -0x731);             /* call 0x10097ee8 */
            ii(0x1009_8619, 2); test(al, al);                           /* test al, al */
            ii(0x1009_861b, 2); if(jzd(0x1009_8621, 0x4)) goto l_0x1009_8621; /* jz 0x10098621 */
            ii(0x1009_861d, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x1009_8621:
            ii(0x1009_8621, 5); jmpd(0x1009_854f, -0xd7); goto l_0x1009_854f; /* jmp 0x1009854f */
        l_0x1009_8626:
            ii(0x1009_8626, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8629, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_862c, 5); calld(0x1009_c6c8, 0x4097);             /* call 0x1009c6c8 */
            ii(0x1009_8631, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_8634, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8636, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_8638, 5); calld(0x1009_c560, 0x3f23);             /* call 0x1009c560 */
            ii(0x1009_863d, 2); jmpd(0x1009_8647, 0x8); goto l_0x1009_8647; /* jmp 0x10098647 */
        l_0x1009_863f:
            ii(0x1009_863f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_8642, 5); calld(0x1007_6bf8, -0x2_1a4f);          /* call 0x10076bf8 */
        l_0x1009_8647:
            ii(0x1009_8647, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8649, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_864c, 5); calld(0x1013_ad71, 0xa_2720);           /* call 0x1013ad71 */
            ii(0x1009_8651, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8653, 6); if(jzd(0x1009_870f, 0xb6)) goto l_0x1009_870f; /* jz 0x1009870f */
            ii(0x1009_8659, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_865c, 5); calld(0x1009_c4f8, 0x3e97);             /* call 0x1009c4f8 */
            ii(0x1009_8661, 5); calld(0x1009_c4c4, 0x3e5e);             /* call 0x1009c4c4 */
            ii(0x1009_8666, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_8669, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_866c, 5); calld(0x1009_c4f8, 0x3e87);             /* call 0x1009c4f8 */
            ii(0x1009_8671, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1009_8674, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_8677, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_867a, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_867d, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_8680, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8682, 2); if(jzd(0x1009_868b, 0x7)) goto l_0x1009_868b; /* jz 0x1009868b */
            ii(0x1009_8684, 5); cmp(memw_a32[ss, ebp - 0x14], 0xc);     /* cmp word [ebp-0x14], 0xc */
            ii(0x1009_8689, 2); if(jnzd(0x1009_868d, 0x2)) goto l_0x1009_868d; /* jnz 0x1009868d */
        l_0x1009_868b:
            ii(0x1009_868b, 2); jmpd(0x1009_8694, 0x7); goto l_0x1009_8694; /* jmp 0x10098694 */
        l_0x1009_868d:
            ii(0x1009_868d, 5); cmp(memw_a32[ss, ebp - 0x14], 0x21);    /* cmp word [ebp-0x14], 0x21 */
            ii(0x1009_8692, 2); if(jnzd(0x1009_8696, 0x2)) goto l_0x1009_8696; /* jnz 0x10098696 */
        l_0x1009_8694:
            ii(0x1009_8694, 2); jmpd(0x1009_869d, 0x7); goto l_0x1009_869d; /* jmp 0x1009869d */
        l_0x1009_8696:
            ii(0x1009_8696, 5); cmp(memw_a32[ss, ebp - 0x14], 0x27);    /* cmp word [ebp-0x14], 0x27 */
            ii(0x1009_869b, 2); if(jnzd(0x1009_869f, 0x2)) goto l_0x1009_869f; /* jnz 0x1009869f */
        l_0x1009_869d:
            ii(0x1009_869d, 2); jmpd(0x1009_86a6, 0x7); goto l_0x1009_86a6; /* jmp 0x100986a6 */
        l_0x1009_869f:
            ii(0x1009_869f, 5); cmp(memw_a32[ss, ebp - 0x14], 0x22);    /* cmp word [ebp-0x14], 0x22 */
            ii(0x1009_86a4, 2); if(jnzd(0x1009_86a8, 0x2)) goto l_0x1009_86a8; /* jnz 0x100986a8 */
        l_0x1009_86a6:
            ii(0x1009_86a6, 2); jmpd(0x1009_86af, 0x7); goto l_0x1009_86af; /* jmp 0x100986af */
        l_0x1009_86a8:
            ii(0x1009_86a8, 5); cmp(memw_a32[ss, ebp - 0x14], 0x25);    /* cmp word [ebp-0x14], 0x25 */
            ii(0x1009_86ad, 2); if(jnzd(0x1009_86b1, 0x2)) goto l_0x1009_86b1; /* jnz 0x100986b1 */
        l_0x1009_86af:
            ii(0x1009_86af, 2); jmpd(0x1009_86b8, 0x7); goto l_0x1009_86b8; /* jmp 0x100986b8 */
        l_0x1009_86b1:
            ii(0x1009_86b1, 5); cmp(memw_a32[ss, ebp - 0x14], 0x24);    /* cmp word [ebp-0x14], 0x24 */
            ii(0x1009_86b6, 2); if(jnzd(0x1009_86ba, 0x2)) goto l_0x1009_86ba; /* jnz 0x100986ba */
        l_0x1009_86b8:
            ii(0x1009_86b8, 2); jmpd(0x1009_86c1, 0x7); goto l_0x1009_86c1; /* jmp 0x100986c1 */
        l_0x1009_86ba:
            ii(0x1009_86ba, 5); cmp(memw_a32[ss, ebp - 0x14], 0x23);    /* cmp word [ebp-0x14], 0x23 */
            ii(0x1009_86bf, 2); if(jnzd(0x1009_86c3, 0x2)) goto l_0x1009_86c3; /* jnz 0x100986c3 */
        l_0x1009_86c1:
            ii(0x1009_86c1, 2); jmpd(0x1009_86ca, 0x7); goto l_0x1009_86ca; /* jmp 0x100986ca */
        l_0x1009_86c3:
            ii(0x1009_86c3, 5); cmp(memw_a32[ss, ebp - 0x14], 0x5);     /* cmp word [ebp-0x14], 0x5 */
            ii(0x1009_86c8, 2); if(jnzd(0x1009_86cc, 0x2)) goto l_0x1009_86cc; /* jnz 0x100986cc */
        l_0x1009_86ca:
            ii(0x1009_86ca, 2); jmpd(0x1009_870a, 0x3e); goto l_0x1009_870a; /* jmp 0x1009870a */
        l_0x1009_86cc:
            ii(0x1009_86cc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_86cf, 5); calld(0x1009_c4f8, 0x3e24);             /* call 0x1009c4f8 */
            ii(0x1009_86d4, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1009_86d7, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1009_86da, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1009_86dd, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x1009_86e0, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1009_86e3, 3); calld_abs(memd_a32[ds, ecx + 0x1c]);    /* call dword [ecx+0x1c] */
            ii(0x1009_86e6, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
            ii(0x1009_86eb, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1009_86ee, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_86f1, 5); calld(0x1008_a6f8, -0xdffe);            /* call 0x1008a6f8 */
            ii(0x1009_86f6, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1009_86f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_86fb, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1009_86fd, 5); calld(0x1009_7ee8, -0x81a);             /* call 0x10097ee8 */
            ii(0x1009_8702, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8704, 2); if(jzd(0x1009_870a, 0x4)) goto l_0x1009_870a; /* jz 0x1009870a */
            ii(0x1009_8706, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x1009_870a:
            ii(0x1009_870a, 5); jmpd(0x1009_863f, -0xd0); goto l_0x1009_863f; /* jmp 0x1009863f */
        l_0x1009_870f:
            ii(0x1009_870f, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_8712, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1009_8715, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8717, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_871a, 5); calld(0x1007_5f6c, -0x2_27b3);          /* call 0x10075f6c */
            ii(0x1009_871f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8721, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_8724, 5); calld(0x1009_ba6c, 0x3343);             /* call 0x1009ba6c */
            ii(0x1009_8729, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_872b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_872e, 5); calld(0x1008_bc9f, -0xca94);            /* call 0x1008bc9f */
            ii(0x1009_8733, 2); jmpd(0x1009_8753, 0x1e); goto l_0x1009_8753; /* jmp 0x10098753 */
        //  ii(0x1009_8735, 30); Недостижимый код.
        l_0x1009_8753:
            ii(0x1009_8753, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_8756, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_8758, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_8759, 1); popd(edi);                              /* pop edi */
            ii(0x1009_875a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_875b, 1); popd(edx);                              /* pop edx */
            ii(0x1009_875c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_875d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_875e, 1); retd(); return;                         /* ret */
        }
    }
}
