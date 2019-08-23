using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_e9e0-16df0fce")]
        public void Method_1014_e9e0()
        {
            ii(0x1014_e9e0, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_e9e5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_7368); /* call 0x10165d52 */
            ii(0x1014_e9ea, 1); pushd(esi);                             /* push esi */
            ii(0x1014_e9eb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_e9ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_e9ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_e9ef, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_e9f5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_e9f8, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_e9fb, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_e9fe, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_ea01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ea04, 5); calld(0x1007_6338, -0xd_86d1);          /* call 0x10076338 */
            ii(0x1014_ea09, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ea0b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea0e, 5); calld(0x1007_64b8, -0xd_855b);          /* call 0x100764b8 */
            ii(0x1014_ea13, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ea16, 5); calld(0x1007_623c, -0xd_87df);          /* call 0x1007623c */
            ii(0x1014_ea1b, 4); mov(ax, memw_a32[ds, eax + 0x1d]);      /* mov ax, [eax+0x1d] */
            ii(0x1014_ea1f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1014_ea22:
            ii(0x1014_ea22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ea24, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea27, 5); calld(0x1013_ad71, -0x1_3cbb);          /* call 0x1013ad71 */
            ii(0x1014_ea2c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ea2e, 6); if(jzd(0x1014_eb38, 0x104)) goto l_0x1014_eb38; /* jz 0x1014eb38 */
            ii(0x1014_ea34, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea37, 5); calld(0x1007_63a0, -0xd_869c);          /* call 0x100763a0 */
            ii(0x1014_ea3c, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x1014_ea40, 2); if(jzd(0x1014_ea5f, 0x1d)) goto l_0x1014_ea5f; /* jz 0x1014ea5f */
            ii(0x1014_ea42, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x1014_ea46, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_ea4a, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_ea4e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea51, 5); calld(0x1007_63d4, -0xd_8682);          /* call 0x100763d4 */
            ii(0x1014_ea56, 5); calld(0x1007_0d68, -0xd_dcf3);          /* call 0x10070d68 */
            ii(0x1014_ea5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_ea5d, 2); if(jnzd(0x1014_ea61, 0x2)) goto l_0x1014_ea61; /* jnz 0x1014ea61 */
        l_0x1014_ea5f:
            ii(0x1014_ea5f, 2); jmpd(0x1014_ea89, 0x28); goto l_0x1014_ea89; /* jmp 0x1014ea89 */
        l_0x1014_ea61:
            ii(0x1014_ea61, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1014_ea65, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_ea69, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_ea6c, 5); calld(0x1007_6aac, -0xd_7fc5);          /* call 0x10076aac */
            ii(0x1014_ea71, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_ea73, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea76, 5); calld(0x1007_636c, -0xd_870f);          /* call 0x1007636c */
            ii(0x1014_ea7b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ea7d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_ea80, 5); calld(0x1007_4b2b, -0xd_9f5a);          /* call 0x10074b2b */
            ii(0x1014_ea85, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ea87, 2); if(jnzd(0x1014_ea8e, 0x5)) goto l_0x1014_ea8e; /* jnz 0x1014ea8e */
        l_0x1014_ea89:
            ii(0x1014_ea89, 5); jmpd(0x1014_eb2b, 0x9d); goto l_0x1014_eb2b; /* jmp 0x1014eb2b */
        l_0x1014_ea8e:
            ii(0x1014_ea8e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_ea91, 5); calld(0x1007_63a0, -0xd_86f6);          /* call 0x100763a0 */
            ii(0x1014_ea96, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1014_ea9b, 2); if(jzd(0x1014_eaac, 0xf)) goto l_0x1014_eaac; /* jz 0x1014eaac */
            ii(0x1014_ea9d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eaa0, 5); calld(0x1007_63a0, -0xd_8705);          /* call 0x100763a0 */
            ii(0x1014_eaa5, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1014_eaaa, 2); if(jnzd(0x1014_eac7, 0x1b)) goto l_0x1014_eac7; /* jnz 0x1014eac7 */
        l_0x1014_eaac:
            ii(0x1014_eaac, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eaaf, 5); calld(0x1007_636c, -0xd_8748);          /* call 0x1007636c */
            ii(0x1014_eab4, 5); calld(0x1007_4a6c, -0xd_a04d);          /* call 0x10074a6c */
            ii(0x1014_eab9, 2); test(al, al);                           /* test al, al */
            ii(0x1014_eabb, 2); if(jzd(0x1014_eac7, 0xa)) goto l_0x1014_eac7; /* jz 0x1014eac7 */
            ii(0x1014_eabd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eac0, 5); calld(0x1007_6bf8, -0xd_7ecd);          /* call 0x10076bf8 */
            ii(0x1014_eac5, 2); jmpd(0x1014_eb33, 0x6c); goto l_0x1014_eb33; /* jmp 0x1014eb33 */
        l_0x1014_eac7:
            ii(0x1014_eac7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eaca, 5); calld(0x1007_63a0, -0xd_872f);          /* call 0x100763a0 */
            ii(0x1014_eacf, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1014_ead3, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1014_ead6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_ead9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eadc, 5); calld(0x1007_63a0, -0xd_8741);          /* call 0x100763a0 */
            ii(0x1014_eae1, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1014_eae5, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1014_eae8, 1); cwde();                                 /* cwde */
            ii(0x1014_eae9, 5); calld(0x1015_c339, 0xd84b);             /* call 0x1015c339 */
            ii(0x1014_eaee, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_eaf1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eaf4, 5); calld(0x1007_63a0, -0xd_8759);          /* call 0x100763a0 */
            ii(0x1014_eaf9, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1014_eafd, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1014_eb00, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_eb03, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eb06, 5); calld(0x1007_63a0, -0xd_876b);          /* call 0x100763a0 */
            ii(0x1014_eb0b, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1014_eb0f, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1014_eb12, 1); cwde();                                 /* cwde */
            ii(0x1014_eb13, 5); calld(0x100a_5f65, -0xa_8bb3);          /* call 0x100a5f65 */
            ii(0x1014_eb18, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_eb1b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_eb1e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eb21, 5); calld(0x1007_63a0, -0xd_8786);          /* call 0x100763a0 */
            ii(0x1014_eb26, 5); calld(0x1014_a8f2, -0x4239);            /* call 0x1014a8f2 */
        l_0x1014_eb2b:
            ii(0x1014_eb2b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eb2e, 5); calld(0x1007_6bf8, -0xd_7f3b);          /* call 0x10076bf8 */
        l_0x1014_eb33:
            ii(0x1014_eb33, 5); jmpd(0x1014_ea22, -0x116); goto l_0x1014_ea22; /* jmp 0x1014ea22 */
        l_0x1014_eb38:
            ii(0x1014_eb38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_eb3a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_eb3d, 5); calld(0x1007_5f6c, -0xd_8bd6);          /* call 0x10075f6c */
            ii(0x1014_eb42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_eb44, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_eb45, 1); popd(edi);                              /* pop edi */
            ii(0x1014_eb46, 1); popd(esi);                              /* pop esi */
            ii(0x1014_eb47, 1); retd();                                 /* ret */
        }
    }
}
