using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_36ab-81b7c3d6")]
        public void Method_100c_36ab()
        {
            ii(0x100c_36ab, 5); push(0x68);                             /* push 0x68 */
            ii(0x100c_36b0, 5); call(Definitions.sys_check_available_stack_size, 0xa_269d); /* call 0x10165d52 */
            ii(0x100c_36b5, 1); push(ebx);                              /* push ebx */
            ii(0x100c_36b6, 1); push(ecx);                              /* push ecx */
            ii(0x100c_36b7, 1); push(esi);                              /* push esi */
            ii(0x100c_36b8, 1); push(edi);                              /* push edi */
            ii(0x100c_36b9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_36ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_36bc, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x100c_36c2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_36c5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_36c8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_36cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_36cd, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_36d0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_36d3, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_36d6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_36d8, 2); if(jz(0x100c_36fb, 0x21)) goto l_0x100c_36fb; /* jz 0x100c36fb */
            ii(0x100c_36da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_36dd, 4); test(memb[ds, eax + 0x12], 0x1);        /* test byte [eax+0x12], 0x1 */
            ii(0x100c_36e1, 2); if(jz(0x100c_36ed, 0xa)) goto l_0x100c_36ed; /* jz 0x100c36ed */
            ii(0x100c_36e3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_36e6, 5); cmp(memw[ds, eax + 0x8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x100c_36eb, 2); if(jnz(0x100c_36ef, 0x2)) goto l_0x100c_36ef; /* jnz 0x100c36ef */
        l_0x100c_36ed:
            ii(0x100c_36ed, 2); jmp(0x100c_36f9, 0xa); goto l_0x100c_36f9; /* jmp 0x100c36f9 */
        l_0x100c_36ef:
            ii(0x100c_36ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_36f2, 5); cmp(memw[ds, eax + 0x8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x100c_36f7, 2); if(jnz(0x100c_36fb, 0x2)) goto l_0x100c_36fb; /* jnz 0x100c36fb */
        l_0x100c_36f9:
            ii(0x100c_36f9, 2); jmp(0x100c_3700, 0x5); goto l_0x100c_3700; /* jmp 0x100c3700 */
        l_0x100c_36fb:
            ii(0x100c_36fb, 5); jmp(0x100c_3bf6, 0x4f6); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_3700:
            ii(0x100c_3700, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3703, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_3706, 5); call(0x100c_b000, 0x78f5);              /* call 0x100cb000 */
            ii(0x100c_370b, 3); lea(ebx, memd[ss, ebp - 0x24]);         /* lea ebx, [ebp-0x24] */
            ii(0x100c_370e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3710, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_3712, 5); call(0x1008_a1a4, -0x3_9573);           /* call 0x1008a1a4 */
        l_0x100c_3717:
            ii(0x100c_3717, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3719, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_371c, 5); call(0x1013_ad71, 0x7_7650);            /* call 0x1013ad71 */
            ii(0x100c_3721, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3723, 2); if(jz(0x100c_3737, 0x12)) goto l_0x100c_3737; /* jz 0x100c3737 */
            ii(0x100c_3725, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3728, 5); call(0x1008_a0f8, -0x3_9635);           /* call 0x1008a0f8 */
            ii(0x100c_372d, 5); call(0x1008_a370, -0x3_93c2);           /* call 0x1008a370 */
            ii(0x100c_3732, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100c_3735, 2); if(jnz(0x100c_3739, 0x2)) goto l_0x100c_3739; /* jnz 0x100c3739 */
        l_0x100c_3737:
            ii(0x100c_3737, 2); jmp(0x100c_3743, 0xa); goto l_0x100c_3743; /* jmp 0x100c3743 */
        l_0x100c_3739:
            ii(0x100c_3739, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_373c, 5); call(0x1007_6bf8, -0x4_cb49);           /* call 0x10076bf8 */
            ii(0x100c_3741, 2); jmp(0x100c_3717, -0x2c); goto l_0x100c_3717; /* jmp 0x100c3717 */
        l_0x100c_3743:
            ii(0x100c_3743, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3745, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3748, 5); call(0x1013_ad71, 0x7_7624);            /* call 0x1013ad71 */
            ii(0x100c_374d, 2); test(al, al);                           /* test al, al */
            ii(0x100c_374f, 2); if(jz(0x100c_376d, 0x1c)) goto l_0x100c_376d; /* jz 0x100c376d */
            ii(0x100c_3751, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3754, 5); call(0x1008_a0f8, -0x3_9661);           /* call 0x1008a0f8 */
            ii(0x100c_3759, 5); call(0x100b_8f13, -0xa84b);             /* call 0x100b8f13 */
            ii(0x100c_375e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3760, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3763, 5); call(0x1008_8e4c, -0x3_a91c);           /* call 0x10088e4c */
            ii(0x100c_3768, 5); jmp(0x100c_3bf6, 0x489); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_376d:
            ii(0x100c_376d, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x100c_3772, 5); call(Definitions.sys_new, 0xa_2689);    /* call 0x10165e00 */
            ii(0x100c_3777, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_377a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_377d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_3780, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_3784, 2); if(jz(0x100c_37a2, 0x1c)) goto l_0x100c_37a2; /* jz 0x100c37a2 */
            ii(0x100c_3786, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3789, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_378c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_378f, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_3792, 5); call(0x100b_8bee, -0xaba9);             /* call 0x100b8bee */
            ii(0x100c_3797, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_379a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_379d, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_37a0, 2); jmp(0x100c_37a8, 0x6); goto l_0x100c_37a8; /* jmp 0x100c37a8 */
        l_0x100c_37a2:
            ii(0x100c_37a2, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_37a5, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100c_37a8:
            ii(0x100c_37a8, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x100c_37ab, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_37ae, 5); call(0x100c_b074, 0x78c1);              /* call 0x100cb074 */
            ii(0x100c_37b3, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_37b6, 5); call(0x1008_a284, -0x3_9537);           /* call 0x1008a284 */
            ii(0x100c_37bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_37bd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_37c0, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_37c3, 5); call(0x100c_afd0, 0x7808);              /* call 0x100cafd0 */
            ii(0x100c_37c8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_37cb, 5); cmp(memw[ds, eax + 0x8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x100c_37d0, 2); if(jz(0x100c_37dc, 0xa)) goto l_0x100c_37dc; /* jz 0x100c37dc */
            ii(0x100c_37d2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_37d5, 5); cmp(memw[ds, eax + 0x8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x100c_37da, 2); if(jnz(0x100c_37e7, 0xb)) goto l_0x100c_37e7; /* jnz 0x100c37e7 */
        l_0x100c_37dc:
            ii(0x100c_37dc, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_37df, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_37e2, 5); call(0x100c_2e41, -0x9a6);              /* call 0x100c2e41 */
        l_0x100c_37e7:
            ii(0x100c_37e7, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_37eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_37ee, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_37f1, 5); call(0x100c_b000, 0x780a);              /* call 0x100cb000 */
            ii(0x100c_37f6, 3); lea(ebx, memd[ss, ebp - 0x24]);         /* lea ebx, [ebp-0x24] */
            ii(0x100c_37f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_37fb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_37fd, 5); call(0x100c_af68, 0x7766);              /* call 0x100caf68 */
            ii(0x100c_3802, 2); jmp(0x100c_380c, 0x8); goto l_0x100c_380c; /* jmp 0x100c380c */
        l_0x100c_3804:
            ii(0x100c_3804, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3807, 5); call(0x1007_6bf8, -0x4_cc14);           /* call 0x10076bf8 */
        l_0x100c_380c:
            ii(0x100c_380c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_380e, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3811, 5); call(0x1013_ad71, 0x7_755b);            /* call 0x1013ad71 */
            ii(0x100c_3816, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3818, 2); if(jz(0x100c_383e, 0x24)) goto l_0x100c_383e; /* jz 0x100c383e */
            ii(0x100c_381a, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_381d, 5); call(0x1008_a0f8, -0x3_972a);           /* call 0x1008a0f8 */
            ii(0x100c_3822, 5); call(0x1008_a370, -0x3_94b7);           /* call 0x1008a370 */
            ii(0x100c_3827, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_382a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_382d, 5); call(0x100b_b097, -0x879b);             /* call 0x100bb097 */
            ii(0x100c_3832, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3834, 2); if(jz(0x100c_383c, 0x6)) goto l_0x100c_383c; /* jz 0x100c383c */
            ii(0x100c_3836, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_383a, 2); jmp(0x100c_383e, 0x2); goto l_0x100c_383e; /* jmp 0x100c383e */
        l_0x100c_383c:
            ii(0x100c_383c, 2); jmp(0x100c_3804, -0x3a); goto l_0x100c_3804; /* jmp 0x100c3804 */
        l_0x100c_383e:
            ii(0x100c_383e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3841, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_3844, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3847, 5); call(0x100b_b097, -0x87b5);             /* call 0x100bb097 */
            ii(0x100c_384c, 2); test(al, al);                           /* test al, al */
            ii(0x100c_384e, 2); if(jnz(0x100c_3862, 0x12)) goto l_0x100c_3862; /* jnz 0x100c3862 */
            ii(0x100c_3850, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100c_3854, 2); if(jnz(0x100c_3860, 0xa)) goto l_0x100c_3860; /* jnz 0x100c3860 */
            ii(0x100c_3856, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3859, 5); cmp(memw[ds, eax + 0x8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x100c_385e, 2); if(jz(0x100c_3862, 0x2)) goto l_0x100c_3862; /* jz 0x100c3862 */
        l_0x100c_3860:
            ii(0x100c_3860, 2); jmp(0x100c_38a7, 0x45); goto l_0x100c_38a7; /* jmp 0x100c38a7 */
        l_0x100c_3862:
            ii(0x100c_3862, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3865, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3867, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_386a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_386d, 3); mov(eax, memd[ds, eax + 0x79]);         /* mov eax, [eax+0x79] */
            ii(0x100c_3870, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3873, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_3875, 2); if(jnz(0x100c_38a7, 0x30)) goto l_0x100c_38a7; /* jnz 0x100c38a7 */
            ii(0x100c_3877, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100c_387c, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_387f, 5); call(0x1008_a284, -0x3_9600);           /* call 0x1008a284 */
            ii(0x100c_3884, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3886, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3889, 5); call(0x100b_ab5d, -0x8d31);             /* call 0x100bab5d */
            ii(0x100c_388e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3890, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3893, 5); call(0x1008_8e0c, -0x3_aa8c);           /* call 0x10088e0c */
            ii(0x100c_3898, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_389a, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_389d, 5); call(0x1008_8e4c, -0x3_aa56);           /* call 0x10088e4c */
            ii(0x100c_38a2, 5); jmp(0x100c_3bf6, 0x34f); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_38a7:
            ii(0x100c_38a7, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100c_38ab, 2); if(jnz(0x100c_38bf, 0x12)) goto l_0x100c_38bf; /* jnz 0x100c38bf */
            ii(0x100c_38ad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_38b0, 5); call(0x1007_623c, -0x4_d679);           /* call 0x1007623c */
            ii(0x100c_38b5, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100c_38b8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_38bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_38bd, 2); if(jnz(0x100c_38d8, 0x19)) goto l_0x100c_38d8; /* jnz 0x100c38d8 */
        l_0x100c_38bf:
            ii(0x100c_38bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_38c1, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_38c4, 5); call(0x1008_8e0c, -0x3_aabd);           /* call 0x10088e0c */
            ii(0x100c_38c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_38cb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_38ce, 5); call(0x1008_8e4c, -0x3_aa87);           /* call 0x10088e4c */
            ii(0x100c_38d3, 5); jmp(0x100c_3bf6, 0x31e); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_38d8:
            ii(0x100c_38d8, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_38dd, 5); call(0x1007_6338, -0x4_d5aa);           /* call 0x10076338 */
            ii(0x100c_38e2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_38e4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_38e7, 5); call(0x1007_64b8, -0x4_d434);           /* call 0x100764b8 */
            ii(0x100c_38ec, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_38ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_38f1, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_38f4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_38f7, 3); mov(eax, memd[ds, eax + 0x79]);         /* mov eax, [eax+0x79] */
            ii(0x100c_38fa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_38fd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_38ff, 6); if(jnz(0x100c_3bd8, 0x2d3)) goto l_0x100c_3bd8; /* jnz 0x100c3bd8 */
            ii(0x100c_3905, 2); jmp(0x100c_390f, 0x8); goto l_0x100c_390f; /* jmp 0x100c390f */
        l_0x100c_3907:
            ii(0x100c_3907, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_390a, 5); call(0x1007_6bf8, -0x4_cd17);           /* call 0x10076bf8 */
        l_0x100c_390f:
            ii(0x100c_390f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3911, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3914, 5); call(0x1013_ad71, 0x7_7458);            /* call 0x1013ad71 */
            ii(0x100c_3919, 2); test(al, al);                           /* test al, al */
            ii(0x100c_391b, 6); if(jz(0x100c_3a36, 0x115)) goto l_0x100c_3a36; /* jz 0x100c3a36 */
            ii(0x100c_3921, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3924, 5); call(0x1007_63a0, -0x4_d589);           /* call 0x100763a0 */
            ii(0x100c_3929, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_392c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_392f, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x100c_3932, 2); if(jnz(0x100c_394b, 0x17)) goto l_0x100c_394b; /* jnz 0x100c394b */
            ii(0x100c_3934, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3937, 5); call(0x1007_63a0, -0x4_d59c);           /* call 0x100763a0 */
            ii(0x100c_393c, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_393f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_3942, 5); call(0x100b_b097, -0x88b0);             /* call 0x100bb097 */
            ii(0x100c_3947, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3949, 2); if(jnz(0x100c_394d, 0x2)) goto l_0x100c_394d; /* jnz 0x100c394d */
        l_0x100c_394b:
            ii(0x100c_394b, 2); jmp(0x100c_3965, 0x18); goto l_0x100c_3965; /* jmp 0x100c3965 */
        l_0x100c_394d:
            ii(0x100c_394d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3950, 5); call(0x1007_636c, -0x4_d5e9);           /* call 0x1007636c */
            ii(0x100c_3955, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3957, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_395a, 5); call(0x100a_601a, -0x1_d945);           /* call 0x100a601a */
            ii(0x100c_395f, 1); cwde();                                 /* cwde */
            ii(0x100c_3960, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x100c_3963, 2); if(jl(0x100c_396a, 0x5)) goto l_0x100c_396a; /* jl 0x100c396a */
        l_0x100c_3965:
            ii(0x100c_3965, 5); jmp(0x100c_3a31, 0xc7); goto l_0x100c_3a31; /* jmp 0x100c3a31 */
        l_0x100c_396a:
            ii(0x100c_396a, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x100c_396f, 5); call(Definitions.sys_new, 0xa_248c);    /* call 0x10165e00 */
            ii(0x100c_3974, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_3977, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_397a, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_397d, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100c_3981, 2); if(jz(0x100c_39a6, 0x23)) goto l_0x100c_39a6; /* jz 0x100c39a6 */
            ii(0x100c_3983, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3986, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_3989, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_398c, 5); call(0x1007_63d4, -0x4_d5bd);           /* call 0x100763d4 */
            ii(0x100c_3991, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3993, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_3996, 5); call(0x100b_8bee, -0xadad);             /* call 0x100b8bee */
            ii(0x100c_399b, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100c_399e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100c_39a1, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100c_39a4, 2); jmp(0x100c_39ac, 0x6); goto l_0x100c_39ac; /* jmp 0x100c39ac */
        l_0x100c_39a6:
            ii(0x100c_39a6, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_39a9, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100c_39ac:
            ii(0x100c_39ac, 3); mov(edx, memd[ss, ebp - 0x38]);         /* mov edx, [ebp-0x38] */
            ii(0x100c_39af, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_39b2, 5); call(0x1008_a2b4, -0x3_9703);           /* call 0x1008a2b4 */
            ii(0x100c_39b7, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100c_39ba, 3); mov(ebx, memd[ds, ebx + 0x1a]);         /* mov ebx, [ebx+0x1a] */
            ii(0x100c_39bd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_39c0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_39c3, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x100c_39c6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_39c9, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100c_39cc, 5); call(0x1007_6aac, -0x4_cf25);           /* call 0x10076aac */
            ii(0x100c_39d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_39d3, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_39d6, 5); call(0x1008_a228, -0x3_97b3);           /* call 0x1008a228 */
            ii(0x100c_39db, 5); call(0x100c_b0b8, 0x76d8);              /* call 0x100cb0b8 */
            ii(0x100c_39e0, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_39e3, 5); call(0x1008_a284, -0x3_9764);           /* call 0x1008a284 */
            ii(0x100c_39e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_39ea, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_39ed, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_39f0, 5); call(0x100c_afd0, 0x75db);              /* call 0x100cafd0 */
            ii(0x100c_39f5, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100c_39fa, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_39fd, 5); call(0x1008_a284, -0x3_977e);           /* call 0x1008a284 */
            ii(0x100c_3a02, 3); mov(ecx, memd[ss, ebp - 0x8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100c_3a05, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3a07, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_3a09, 5); call(0x100b_ab5d, -0x8eb1);             /* call 0x100bab5d */
            ii(0x100c_3a0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a10, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3a13, 5); call(0x1007_5f6c, -0x4_daac);           /* call 0x10075f6c */
            ii(0x100c_3a18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a1a, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3a1d, 5); call(0x1008_8e0c, -0x3_ac16);           /* call 0x10088e0c */
            ii(0x100c_3a22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a24, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3a27, 5); call(0x1008_8e4c, -0x3_abe0);           /* call 0x10088e4c */
            ii(0x100c_3a2c, 5); jmp(0x100c_3bf6, 0x1c5); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_3a31:
            ii(0x100c_3a31, 5); jmp(0x100c_3907, -0x12f); goto l_0x100c_3907; /* jmp 0x100c3907 */
        l_0x100c_3a36:
            ii(0x100c_3a36, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3a39, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_3a3c, 5); call(0x100c_b000, 0x75bf);              /* call 0x100cb000 */
            ii(0x100c_3a41, 3); lea(ebx, memd[ss, ebp - 0x24]);         /* lea ebx, [ebp-0x24] */
            ii(0x100c_3a44, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3a46, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_3a48, 5); call(0x100c_af68, 0x751b);              /* call 0x100caf68 */
            ii(0x100c_3a4d, 2); jmp(0x100c_3a57, 0x8); goto l_0x100c_3a57; /* jmp 0x100c3a57 */
        l_0x100c_3a4f:
            ii(0x100c_3a4f, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3a52, 5); call(0x1007_6bf8, -0x4_ce5f);           /* call 0x10076bf8 */
        l_0x100c_3a57:
            ii(0x100c_3a57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a59, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3a5c, 5); call(0x1013_ad71, 0x7_7310);            /* call 0x1013ad71 */
            ii(0x100c_3a61, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3a63, 2); if(jz(0x100c_3a9e, 0x39)) goto l_0x100c_3a9e; /* jz 0x100c3a9e */
            ii(0x100c_3a65, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3a68, 5); call(0x1008_a0f8, -0x3_9975);           /* call 0x1008a0f8 */
            ii(0x100c_3a6d, 5); call(0x1008_a370, -0x3_9702);           /* call 0x1008a370 */
            ii(0x100c_3a72, 5); cmp(memw[ds, eax + 0x8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x100c_3a77, 2); if(jnz(0x100c_3a9c, 0x23)) goto l_0x100c_3a9c; /* jnz 0x100c3a9c */
            ii(0x100c_3a79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a7b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3a7e, 5); call(0x1007_5f6c, -0x4_db17);           /* call 0x10075f6c */
            ii(0x100c_3a83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a85, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3a88, 5); call(0x1008_8e0c, -0x3_ac81);           /* call 0x10088e0c */
            ii(0x100c_3a8d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3a8f, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3a92, 5); call(0x1008_8e4c, -0x3_ac4b);           /* call 0x10088e4c */
            ii(0x100c_3a97, 5); jmp(0x100c_3bf6, 0x15a); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_3a9c:
            ii(0x100c_3a9c, 2); jmp(0x100c_3a4f, -0x4f); goto l_0x100c_3a4f; /* jmp 0x100c3a4f */
        l_0x100c_3a9e:
            ii(0x100c_3a9e, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_3aa3, 5); call(0x1007_6338, -0x4_d770);           /* call 0x10076338 */
            ii(0x100c_3aa8, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x100c_3aab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3aad, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_3aaf, 5); call(0x1007_643c, -0x4_d678);           /* call 0x1007643c */
            ii(0x100c_3ab4, 2); jmp(0x100c_3abe, 0x8); goto l_0x100c_3abe; /* jmp 0x100c3abe */
        l_0x100c_3ab6:
            ii(0x100c_3ab6, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3ab9, 5); call(0x1007_6bf8, -0x4_cec6);           /* call 0x10076bf8 */
        l_0x100c_3abe:
            ii(0x100c_3abe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3ac0, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3ac3, 5); call(0x1013_ad71, 0x7_72a9);            /* call 0x1013ad71 */
            ii(0x100c_3ac8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3aca, 6); if(jz(0x100c_3bd8, 0x108)) goto l_0x100c_3bd8; /* jz 0x100c3bd8 */
            ii(0x100c_3ad0, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3ad3, 5); call(0x1007_63a0, -0x4_d738);           /* call 0x100763a0 */
            ii(0x100c_3ad8, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_3adb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3ade, 3); cmp(dl, memb[ds, eax + 0x26]);          /* cmp dl, [eax+0x26] */
            ii(0x100c_3ae1, 2); if(jnz(0x100c_3af2, 0xf)) goto l_0x100c_3af2; /* jnz 0x100c3af2 */
            ii(0x100c_3ae3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3ae6, 5); call(0x1007_63a0, -0x4_d74b);           /* call 0x100763a0 */
            ii(0x100c_3aeb, 5); cmp(memw[ds, eax + 0x8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x100c_3af0, 2); if(jz(0x100c_3af4, 0x2)) goto l_0x100c_3af4; /* jz 0x100c3af4 */
        l_0x100c_3af2:
            ii(0x100c_3af2, 2); jmp(0x100c_3b0c, 0x18); goto l_0x100c_3b0c; /* jmp 0x100c3b0c */
        l_0x100c_3af4:
            ii(0x100c_3af4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3af7, 5); call(0x1007_636c, -0x4_d790);           /* call 0x1007636c */
            ii(0x100c_3afc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3afe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3b01, 5); call(0x100a_601a, -0x1_daec);           /* call 0x100a601a */
            ii(0x100c_3b06, 1); cwde();                                 /* cwde */
            ii(0x100c_3b07, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x100c_3b0a, 2); if(jl(0x100c_3b11, 0x5)) goto l_0x100c_3b11; /* jl 0x100c3b11 */
        l_0x100c_3b0c:
            ii(0x100c_3b0c, 5); jmp(0x100c_3bd3, 0xc2); goto l_0x100c_3bd3; /* jmp 0x100c3bd3 */
        l_0x100c_3b11:
            ii(0x100c_3b11, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x100c_3b16, 5); call(Definitions.sys_new, 0xa_22e5);    /* call 0x10165e00 */
            ii(0x100c_3b1b, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100c_3b1e, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100c_3b21, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_3b24, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100c_3b28, 2); if(jz(0x100c_3b4d, 0x23)) goto l_0x100c_3b4d; /* jz 0x100c3b4d */
            ii(0x100c_3b2a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3b2d, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_3b30, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3b33, 5); call(0x1007_63d4, -0x4_d764);           /* call 0x100763d4 */
            ii(0x100c_3b38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3b3a, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100c_3b3d, 5); call(0x100b_8bee, -0xaf54);             /* call 0x100b8bee */
            ii(0x100c_3b42, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100c_3b45, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100c_3b48, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100c_3b4b, 2); jmp(0x100c_3b53, 0x6); goto l_0x100c_3b53; /* jmp 0x100c3b53 */
        l_0x100c_3b4d:
            ii(0x100c_3b4d, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100c_3b50, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
        l_0x100c_3b53:
            ii(0x100c_3b53, 3); mov(edx, memd[ss, ebp - 0x4c]);         /* mov edx, [ebp-0x4c] */
            ii(0x100c_3b56, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3b59, 5); call(0x1008_a2b4, -0x3_98aa);           /* call 0x1008a2b4 */
            ii(0x100c_3b5e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3b61, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100c_3b64, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_3b67, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3b6a, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100c_3b6d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_3b70, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x100c_3b73, 5); call(0x1007_6aac, -0x4_d0cc);           /* call 0x10076aac */
            ii(0x100c_3b78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3b7a, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3b7d, 5); call(0x1008_a228, -0x3_995a);           /* call 0x1008a228 */
            ii(0x100c_3b82, 5); call(0x100c_b0b8, 0x7531);              /* call 0x100cb0b8 */
            ii(0x100c_3b87, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3b8a, 5); call(0x1008_a284, -0x3_990b);           /* call 0x1008a284 */
            ii(0x100c_3b8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3b91, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3b94, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_3b97, 5); call(0x100c_afd0, 0x7434);              /* call 0x100cafd0 */
            ii(0x100c_3b9c, 5); mov(ebx, 0x1f00);                       /* mov ebx, 0x1f00 */
            ii(0x100c_3ba1, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3ba4, 5); call(0x1008_a284, -0x3_9925);           /* call 0x1008a284 */
            ii(0x100c_3ba9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_3bab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3bae, 5); call(0x100b_ab5d, -0x9056);             /* call 0x100bab5d */
            ii(0x100c_3bb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3bb5, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3bb8, 5); call(0x1007_5f6c, -0x4_dc51);           /* call 0x10075f6c */
            ii(0x100c_3bbd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3bbf, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3bc2, 5); call(0x1008_8e0c, -0x3_adbb);           /* call 0x10088e0c */
            ii(0x100c_3bc7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3bc9, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3bcc, 5); call(0x1008_8e4c, -0x3_ad85);           /* call 0x10088e4c */
            ii(0x100c_3bd1, 2); jmp(0x100c_3bf6, 0x23); goto l_0x100c_3bf6; /* jmp 0x100c3bf6 */
        l_0x100c_3bd3:
            ii(0x100c_3bd3, 5); jmp(0x100c_3ab6, -0x122); goto l_0x100c_3ab6; /* jmp 0x100c3ab6 */
        l_0x100c_3bd8:
            ii(0x100c_3bd8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3bda, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_3bdd, 5); call(0x1007_5f6c, -0x4_dc76);           /* call 0x10075f6c */
            ii(0x100c_3be2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3be4, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_3be7, 5); call(0x1008_8e0c, -0x3_ade0);           /* call 0x10088e0c */
            ii(0x100c_3bec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3bee, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_3bf1, 5); call(0x1008_8e4c, -0x3_adaa);           /* call 0x10088e4c */
        l_0x100c_3bf6:
            ii(0x100c_3bf6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_3bf8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_3bf9, 1); pop(edi);                               /* pop edi */
            ii(0x100c_3bfa, 1); pop(esi);                               /* pop esi */
            ii(0x100c_3bfb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_3bfc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_3bfd, 1); ret();                                  /* ret */
        }
    }
}
