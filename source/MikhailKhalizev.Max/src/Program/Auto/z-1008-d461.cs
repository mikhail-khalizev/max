using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6eba3ee3-e156-43a7-afec-3967f69f7b93")]
        public void Method_1008_d461()
        {
            ii(0x1008_d461, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_d466, 5); calld(Definitions.sys_check_available_stack_size, 0xd_88e7); /* call 0x10165d52 */
            ii(0x1008_d46b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d46c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d46d, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d46e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d46f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d470, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d471, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d473, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_d479, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d47c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d47e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d481, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d484, 5); calld(0x1013_ad11, 0xa_d888);           /* call 0x1013ad11 */
            ii(0x1008_d489, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d48b, 2); if(jzd(0x1008_d49e, 0x11)) goto l_0x1008_d49e; /* jz 0x1008d49e */
            ii(0x1008_d48d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d490, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d493, 5); calld(0x1007_6574, -0x1_6f24);          /* call 0x10076574 */
            ii(0x1008_d498, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1008_d49c, 2); if(jzd(0x1008_d4a0, 0x2)) goto l_0x1008_d4a0; /* jz 0x1008d4a0 */
        l_0x1008_d49e:
            ii(0x1008_d49e, 2); jmpd(0x1008_d4e5, 0x45); goto l_0x1008_d4e5; /* jmp 0x1008d4e5 */
        l_0x1008_d4a0:
            ii(0x1008_d4a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d4a3, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d4a6, 5); calld(0x1007_6574, -0x1_6f37);          /* call 0x10076574 */
            ii(0x1008_d4ab, 5); calld(0x1007_611c, -0x1_7394);          /* call 0x1007611c */
            ii(0x1008_d4b0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d4b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d4b5, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d4b8, 5); calld(0x1007_6630, -0x1_6e8d);          /* call 0x10076630 */
            ii(0x1008_d4bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d4c0, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d4c3, 5); calld(0x1007_6574, -0x1_6f54);          /* call 0x10076574 */
            ii(0x1008_d4c8, 5); calld(0x1015_26ac, 0xc_51df);           /* call 0x101526ac */
            ii(0x1008_d4cd, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_d4d0, 2); if(jzd(0x1008_d4e5, 0x13)) goto l_0x1008_d4e5; /* jz 0x1008d4e5 */
            ii(0x1008_d4d2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_d4d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d4d8, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d4db, 5); calld(0x1007_6574, -0x1_6f6c);          /* call 0x10076574 */
            ii(0x1008_d4e0, 5); calld(0x1015_27ed, 0xc_5308);           /* call 0x101527ed */
        l_0x1008_d4e5:
            ii(0x1008_d4e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d4e8, 4); mov(memb_a32[ds, eax + 0x25], 0xa);     /* mov byte [eax+0x25], 0xa */
            ii(0x1008_d4ec, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1008_d4f1, 5); calld(Definitions.sys_new, 0xd_890a);   /* call 0x10165e00 */
            ii(0x1008_d4f6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_d4f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d4fc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_d4ff, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_d503, 2); if(jzd(0x1008_d537, 0x32)) goto l_0x1008_d537; /* jz 0x1008d537 */
            ii(0x1008_d505, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d508, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_d50b, 5); calld(0x1007_65d0, -0x1_6f40);          /* call 0x100765d0 */
            ii(0x1008_d510, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_d512, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1008_d515, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d518, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d51b, 5); calld(0x1007_65d0, -0x1_6f50);          /* call 0x100765d0 */
            ii(0x1008_d520, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x1008_d523, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d525, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_d527, 5); calld(0x100b_3871, 0x2_6345);           /* call 0x100b3871 */
            ii(0x1008_d52c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_d52f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_d532, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_d535, 2); jmpd(0x1008_d53d, 0x6); goto l_0x1008_d53d; /* jmp 0x1008d53d */
        l_0x1008_d537:
            ii(0x1008_d537, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d53a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1008_d53d:
            ii(0x1008_d53d, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1008_d540, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_d543, 5); calld(0x1008_b060, -0x24e8);            /* call 0x1008b060 */
            ii(0x1008_d548, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_d54b, 5); calld(0x1008_af84, -0x25cc);            /* call 0x1008af84 */
            ii(0x1008_d550, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d552, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_d557, 5); calld(0x100a_4d50, 0x1_77f4);           /* call 0x100a4d50 */
            ii(0x1008_d55c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d55e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_d561, 5); calld(0x1008_8b7c, -0x49ea);            /* call 0x10088b7c */
            ii(0x1008_d566, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d568, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_d569, 1); popd(edi);                              /* pop edi */
            ii(0x1008_d56a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_d56b, 1); popd(edx);                              /* pop edx */
            ii(0x1008_d56c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_d56d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_d56e, 1); retd(); return;                         /* ret */
        }
    }
}
