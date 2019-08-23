using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6462-9f05bf79")]
        public void Method_1014_6462()
        {
            ii(0x1014_6462, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1014_6467, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f8e6); /* call 0x10165d52 */
            ii(0x1014_646c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_646d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_646e, 1); pushd(edx);                             /* push edx */
            ii(0x1014_646f, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6470, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6471, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6472, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6474, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_647a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_647d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6480, 4); cmp(memb_a32[ds, eax + 0x26], 0);       /* cmp byte [eax+0x26], 0x0 */
            ii(0x1014_6484, 2); if(jnzd(0x1014_64f1, 0x6b)) goto l_0x1014_64f1; /* jnz 0x101464f1 */
            ii(0x1014_6486, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6488, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_648b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_648e, 5); calld(0x1013_ad71, -0xb722);            /* call 0x1013ad71 */
            ii(0x1014_6493, 2); test(al, al);                           /* test al, al */
            ii(0x1014_6495, 2); if(jzd(0x1014_64b1, 0x1a)) goto l_0x1014_64b1; /* jz 0x101464b1 */
            ii(0x1014_6497, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_649a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_649d, 5); calld(0x100e_0760, -0x6_5d42);          /* call 0x100e0760 */
            ii(0x1014_64a2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_64a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_64a8, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1014_64ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_64ae, 3); calld_abs(memd_a32[ds, edx + 0x18]);    /* call dword [edx+0x18] */
        l_0x1014_64b1:
            ii(0x1014_64b1, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1014_64b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_64b7, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1014_64ba, 5); calld(0x1014_710b, 0xc4c);              /* call 0x1014710b */
            ii(0x1014_64bf, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_64c2, 3); add(ebx, 0x18);                         /* add ebx, 0x18 */
            ii(0x1014_64c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_64c7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_64c9, 5); calld(0x100e_07bc, -0x6_5d12);          /* call 0x100e07bc */
            ii(0x1014_64ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_64d0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_64d3, 5); calld(0x100e_03bc, -0x6_611c);          /* call 0x100e03bc */
            ii(0x1014_64d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_64da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_64dd, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_64e0, 5); calld(0x1013_ad11, -0xb7d4);            /* call 0x1013ad11 */
            ii(0x1014_64e5, 2); test(al, al);                           /* test al, al */
            ii(0x1014_64e7, 2); if(jzd(0x1014_64f1, 0x8)) goto l_0x1014_64f1; /* jz 0x101464f1 */
            ii(0x1014_64e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_64ec, 5); calld(0x1014_5bad, -0x944);             /* call 0x10145bad */
        l_0x1014_64f1:
            ii(0x1014_64f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_64f4, 4); cmp(memb_a32[ds, eax + 0x26], 0);       /* cmp byte [eax+0x26], 0x0 */
            ii(0x1014_64f8, 2); if(jnzd(0x1014_6500, 0x6)) goto l_0x1014_6500; /* jnz 0x10146500 */
            ii(0x1014_64fa, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1014_64fe, 2); jmpd(0x1014_6504, 0x4); goto l_0x1014_6504; /* jmp 0x10146504 */
        l_0x1014_6500:
            ii(0x1014_6500, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1014_6504:
            ii(0x1014_6504, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1014_6507, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1014_650a, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1014_650d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_650f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_6510, 1); popd(edi);                              /* pop edi */
            ii(0x1014_6511, 1); popd(esi);                              /* pop esi */
            ii(0x1014_6512, 1); popd(edx);                              /* pop edx */
            ii(0x1014_6513, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6514, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_6515, 1); retd();                                 /* ret */
        }
    }
}
