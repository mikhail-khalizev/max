using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a427-5a89c65e")]
        public void Method_1013_a427()
        {
            ii(0x1013_a427, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1013_a42c, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b921); /* call 0x10165d52 */
            ii(0x1013_a431, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a432, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a433, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a434, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a435, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a437, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1013_a43d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_a440, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_a443, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_a446, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1013_a44a, 2); if(jnzd(0x1013_a45c, 0x10)) goto l_0x1013_a45c; /* jnz 0x1013a45c */
            ii(0x1013_a44c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a44f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_a452, 5); calld(0x1013_a2ab, -0x1ac);             /* call 0x1013a2ab */
            ii(0x1013_a457, 5); jmpd(0x1013_a4e4, 0x88); goto l_0x1013_a4e4; /* jmp 0x1013a4e4 */
        l_0x1013_a45c:
            ii(0x1013_a45c, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1013_a461, 5); calld(Definitions.sys_new, 0x2_b99a);   /* call 0x10165e00 */
            ii(0x1013_a466, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_a469, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_a46c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_a46f, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_a473, 2); if(jzd(0x1013_a48b, 0x16)) goto l_0x1013_a48b; /* jz 0x1013a48b */
            ii(0x1013_a475, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a478, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_a47b, 5); calld(0x1013_9eb4, -0x5cc);             /* call 0x10139eb4 */
            ii(0x1013_a480, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_a483, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_a486, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_a489, 2); jmpd(0x1013_a491, 0x6); goto l_0x1013_a491; /* jmp 0x1013a491 */
        l_0x1013_a48b:
            ii(0x1013_a48b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_a48e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_a491:
            ii(0x1013_a491, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_a494, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a497, 5); calld(0x1007_6d14, -0xc_3788);          /* call 0x10076d14 */
            ii(0x1013_a49c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_a49f, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1013_a4a2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a4a5, 5); calld(0x1007_6c68, -0xc_3842);          /* call 0x10076c68 */
            ii(0x1013_a4aa, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_a4ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a4af, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_a4b1, 5); calld(0x1013_9fbe, -0x4f8);             /* call 0x10139fbe */
            ii(0x1013_a4b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a4b8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a4bb, 5); calld(0x1013_aa3c, 0x57c);              /* call 0x1013aa3c */
            ii(0x1013_a4c0, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a4c3, 5); calld(0x1013_ad11, 0x849);              /* call 0x1013ad11 */
            ii(0x1013_a4c8, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a4ca, 2); if(jzd(0x1013_a4da, 0xe)) goto l_0x1013_a4da; /* jz 0x1013a4da */
            ii(0x1013_a4cc, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_a4cf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_a4d2, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a4d5, 5); calld(0x1013_aa70, 0x596);              /* call 0x1013aa70 */
        l_0x1013_a4da:
            ii(0x1013_a4da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a4dc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a4df, 5); calld(0x1007_5e24, -0xc_46c0);          /* call 0x10075e24 */
        l_0x1013_a4e4:
            ii(0x1013_a4e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a4e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a4e7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a4e8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a4e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a4ea, 1); retd();                                 /* ret */
        }
    }
}
