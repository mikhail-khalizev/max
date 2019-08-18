using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c220-82a1e1ad")]
        public void Method_100a_c220()
        {
            ii(0x100a_c220, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100a_c225, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9b28); /* call 0x10165d52 */
            ii(0x100a_c22a, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c22b, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c22c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c22d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c22f, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100a_c235, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c238, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_c23b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_c23e, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_c241, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100a_c245, 2); if(jnzd(0x100a_c250, 0x9)) goto l_0x100a_c250; /* jnz 0x100ac250 */
            ii(0x100a_c247, 7); mov(memd_a32[ss, ebp - 0x14], 0x1000);  /* mov dword [ebp-0x14], 0x1000 */
            ii(0x100a_c24e, 2); jmpd(0x100a_c266, 0x16); goto l_0x100a_c266; /* jmp 0x100ac266 */
        l_0x100a_c250:
            ii(0x100a_c250, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c253, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_c256, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_c259, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_c25c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_c25f, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100a_c262, 1); cwde();                                 /* cwde */
            ii(0x100a_c263, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100a_c266:
            ii(0x100a_c266, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_c269, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_c26c, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100a_c26f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_c272, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_c274, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x100a_c277, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_c27a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c27d, 5); calld(0x100a_26d1, -0x9bb1);            /* call 0x100a26d1 */
            ii(0x100a_c282, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c285, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_c288, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_c28b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c28e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c291, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_5ba6); /* call 0x100766f0 */
            ii(0x100a_c296, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_c299, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c29c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_c29f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_c2a2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c2a5, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c2a8, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_57bd); /* call 0x10076af0 */
            ii(0x100a_c2ad, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_c2b0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c2b3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c2b6, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_c2b9, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_57ce); /* call 0x10076af0 */
            ii(0x100a_c2be, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_c2c1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c2c4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c2c7, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x100a_c2ca, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_57df); /* call 0x10076af0 */
            ii(0x100a_c2cf, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x100a_c2d2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c2d5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c2d8, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_c2db, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_57f0); /* call 0x10076af0 */
            ii(0x100a_c2e0, 3); sub(eax, 0x28);                         /* sub eax, 0x28 */
            ii(0x100a_c2e3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c2e6, 5); calld(0x100a_ab28, -0x17c3);            /* call 0x100aab28 */
            ii(0x100a_c2eb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_c2ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c2f1, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_c2f4, 5); calld(0x100a_aad4, -0x1825);            /* call 0x100aaad4 */
            ii(0x100a_c2f9, 3); sub(eax, 0x2c);                         /* sub eax, 0x2c */
            ii(0x100a_c2fc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c2ff, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_c302, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_c305, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c308, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_c30b, 5); calld(0x1009_c930, -0xf9e0);            /* call 0x1009c930 */
            ii(0x100a_c310, 3); sub(eax, 0x3c);                         /* sub eax, 0x3c */
            ii(0x100a_c313, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c316, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_c319, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_c31c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c31f, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5494); /* mov dword [eax+0x2], 0x101b5494 */
            ii(0x100a_c326, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c329, 4); mov(memb_a32[ds, eax + 0x48], 0);       /* mov byte [eax+0x48], 0x0 */
            ii(0x100a_c32d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c330, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x100a_c334, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_c337, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c33a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c33d, 5); calld(0x1007_6630, -0x3_5d12);          /* call 0x10076630 */
            ii(0x100a_c342, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_c345, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_c348, 4); mov(memw_a32[ds, edx + 0x17], ax);      /* mov [edx+0x17], ax */
            ii(0x100a_c34c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c34f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c352, 5); calld(0x1007_6574, -0x3_5de3);          /* call 0x10076574 */
            ii(0x100a_c357, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c359, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_c35c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c35f, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_c362, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c365, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_c367, 2); if(jnzd(0x100a_c372, 0x9)) goto l_0x100a_c372; /* jnz 0x100ac372 */
            ii(0x100a_c369, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100a_c370, 2); jmpd(0x100a_c38b, 0x19); goto l_0x100a_c38b; /* jmp 0x100ac38b */
        l_0x100a_c372:
            ii(0x100a_c372, 5); mov(ecx, 0x176);                        /* mov ecx, 0x176 */
            ii(0x100a_c377, 5); mov(ebx, StringDefinitions.AiMoveCpp);  /* mov ebx, 0x101a0dfb */
            ii(0x100a_c37c, 5); mov(edx, StringDefinitions.UnitTeamidEqualTeam); /* mov edx, 0x101a0e07 */
            ii(0x100a_c381, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_c383, 5); calld(Definitions.sys_assert, 0xb_9a0a); /* call 0x10165d92 */
            ii(0x100a_c388, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100a_c38b:
            ii(0x100a_c38b, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x100a_c38e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_c391, 3); mov(memb_a32[ds, edx + 0x19], al);      /* mov [edx+0x19], al */
            ii(0x100a_c394, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c397, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c39a, 5); calld(0x1007_6574, -0x3_5e2b);          /* call 0x10076574 */
            ii(0x100a_c39f, 5); calld(0x1008_aa80, -0x2_1924);          /* call 0x1008aa80 */
            ii(0x100a_c3a4, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x100a_c3a6, 2); if(jzd(0x100a_c3af, 0x7)) goto l_0x100a_c3af; /* jz 0x100ac3af */
            ii(0x100a_c3a8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3ab, 4); mov(memb_a32[ds, eax + 0x19], 0);       /* mov byte [eax+0x19], 0x0 */
        l_0x100a_c3af:
            ii(0x100a_c3af, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3b2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c3b5, 5); calld(0x1007_6574, -0x3_5e46);          /* call 0x10076574 */
            ii(0x100a_c3ba, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100a_c3bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_c3c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_c3c4, 2); if(jnzd(0x100a_c3e0, 0x1a)) goto l_0x100a_c3e0; /* jnz 0x100ac3e0 */
            ii(0x100a_c3c6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3c9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c3cc, 5); calld(0x1007_6574, -0x3_5e5d);          /* call 0x10076574 */
            ii(0x100a_c3d1, 5); calld(0x1007_623c, -0x3_619a);          /* call 0x1007623c */
            ii(0x100a_c3d6, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100a_c3d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c3dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_c3de, 2); if(jgd(0x100a_c3e2, 0x2)) goto l_0x100a_c3e2; /* jg 0x100ac3e2 */
        l_0x100a_c3e0:
            ii(0x100a_c3e0, 2); jmpd(0x100a_c3eb, 0x9); goto l_0x100a_c3eb; /* jmp 0x100ac3eb */
        l_0x100a_c3e2:
            ii(0x100a_c3e2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3e5, 4); cmp(memb_a32[ds, eax + 0x19], 0);       /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_c3e9, 2); if(jgd(0x100a_c3ed, 0x2)) goto l_0x100a_c3ed; /* jg 0x100ac3ed */
        l_0x100a_c3eb:
            ii(0x100a_c3eb, 2); jmpd(0x100a_c3f4, 0x7); goto l_0x100a_c3f4; /* jmp 0x100ac3f4 */
        l_0x100a_c3ed:
            ii(0x100a_c3ed, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3f0, 4); mov(memb_a32[ds, eax + 0x19], 0x3);     /* mov byte [eax+0x19], 0x3 */
        l_0x100a_c3f4:
            ii(0x100a_c3f4, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100a_c3f7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c3fa, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x100a_c3fd, 5); calld(0x1008_8b44, -0x2_38be);          /* call 0x10088b44 */
            ii(0x100a_c402, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100a_c405, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c408, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c40b, 5); calld(0x1008_8b44, -0x2_38cc);          /* call 0x10088b44 */
            ii(0x100a_c410, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100a_c413, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c416, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_c419, 5); calld(0x1008_8b44, -0x2_38da);          /* call 0x10088b44 */
            ii(0x100a_c41e, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100a_c421, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c424, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_c427, 5); calld(0x1008_8b44, -0x2_38e8);          /* call 0x10088b44 */
            ii(0x100a_c42c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c42f, 6); mov(memw_a32[ds, eax + 0x26], 0xffff);  /* mov word [eax+0x26], 0xffff */
            ii(0x100a_c435, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100a_c438, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_c43b, 3); mov(memd_a32[ds, edx + 0x40], eax);     /* mov [edx+0x40], eax */
            ii(0x100a_c43e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c441, 4); mov(memb_a32[ds, eax + 0x44], 0);       /* mov byte [eax+0x44], 0x0 */
            ii(0x100a_c445, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c448, 4); mov(memb_a32[ds, eax + 0x46], 0);       /* mov byte [eax+0x46], 0x0 */
            ii(0x100a_c44c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_c44f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100a_c452, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_c455, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c457, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c458, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c459, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c45a, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
