using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d3e7c22-c21d-457b-8491-b37c17b61813")]
        public void Method_1014_e823()
        {
            ii(0x1014_e823, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_e828, 5); calld(Definitions.sys_check_available_stack_size, 0x1_7525); /* call 0x10165d52 */
            ii(0x1014_e82d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_e82e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_e82f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_e830, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_e832, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_e838, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_e83b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_e83e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_e841, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1014_e844, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_e847, 5); calld(0x1007_6338, -0xd_8514);          /* call 0x10076338 */
            ii(0x1014_e84c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_e84e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e851, 5); calld(0x1007_64b8, -0xd_839e);          /* call 0x100764b8 */
            ii(0x1014_e856, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_e859, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_e85c, 5); calld(0x1007_6730, -0xd_8131);          /* call 0x10076730 */
            ii(0x1014_e861, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1014_e864, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_e867, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1014_e86a:
            ii(0x1014_e86a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_e86c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e86f, 5); calld(0x1013_ad71, -0x1_3b03);          /* call 0x1013ad71 */
            ii(0x1014_e874, 2); test(al, al);                           /* test al, al */
            ii(0x1014_e876, 6); if(jzd(0x1014_e8f4, 0x78)) goto l_0x1014_e8f4; /* jz 0x1014e8f4 */
            ii(0x1014_e87c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e87f, 5); calld(0x1007_63a0, -0xd_84e4);          /* call 0x100763a0 */
            ii(0x1014_e884, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x1014_e888, 2); if(jzd(0x1014_e8a7, 0x1d)) goto l_0x1014_e8a7; /* jz 0x1014e8a7 */
            ii(0x1014_e88a, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1014_e88e, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_e892, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1014_e896, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e899, 5); calld(0x1007_6408, -0xd_8496);          /* call 0x10076408 */
            ii(0x1014_e89e, 5); calld(0x1007_0d68, -0xd_db3b);          /* call 0x10070d68 */
            ii(0x1014_e8a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_e8a5, 2); if(jnzd(0x1014_e8a9, 0x2)) goto l_0x1014_e8a9; /* jnz 0x1014e8a9 */
        l_0x1014_e8a7:
            ii(0x1014_e8a7, 2); jmpd(0x1014_e8d1, 0x28); goto l_0x1014_e8d1; /* jmp 0x1014e8d1 */
        l_0x1014_e8a9:
            ii(0x1014_e8a9, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_e8ad, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1014_e8b1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_e8b4, 5); calld(0x1007_6aac, -0xd_7e0d);          /* call 0x10076aac */
            ii(0x1014_e8b9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_e8bb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e8be, 5); calld(0x1007_6408, -0xd_84bb);          /* call 0x10076408 */
            ii(0x1014_e8c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_e8c5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_e8c8, 5); calld(0x1007_4b2b, -0xd_9da2);          /* call 0x10074b2b */
            ii(0x1014_e8cd, 2); test(al, al);                           /* test al, al */
            ii(0x1014_e8cf, 2); if(jnzd(0x1014_e8d3, 0x2)) goto l_0x1014_e8d3; /* jnz 0x1014e8d3 */
        l_0x1014_e8d1:
            ii(0x1014_e8d1, 2); jmpd(0x1014_e8e7, 0x14); goto l_0x1014_e8e7; /* jmp 0x1014e8e7 */
        l_0x1014_e8d3:
            ii(0x1014_e8d3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e8d6, 5); calld(0x1007_63a0, -0xd_853b);          /* call 0x100763a0 */
            ii(0x1014_e8db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_e8dd, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1014_e8e0, 7); add(memw_a32[ds, edx + 0xa3], ax);      /* add [edx+0xa3], ax */
        l_0x1014_e8e7:
            ii(0x1014_e8e7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e8ea, 5); calld(0x1007_6bf8, -0xd_7cf7);          /* call 0x10076bf8 */
            ii(0x1014_e8ef, 5); jmpd(0x1014_e86a, -0x8a); goto l_0x1014_e86a; /* jmp 0x1014e86a */
        l_0x1014_e8f4:
            ii(0x1014_e8f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_e8f6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_e8f9, 5); calld(0x1007_5f6c, -0xd_8992);          /* call 0x10075f6c */
            ii(0x1014_e8fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_e900, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_e901, 1); popd(edi);                              /* pop edi */
            ii(0x1014_e902, 1); popd(esi);                              /* pop esi */
            ii(0x1014_e903, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
