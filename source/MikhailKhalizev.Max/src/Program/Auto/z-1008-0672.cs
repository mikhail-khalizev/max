using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("27e4abea-93ef-438a-8fb4-d938f8a30167")]
        public void Method_1008_0672()
        {
            ii(0x1008_0672, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_0677, 5); calld(Definitions.sys_check_available_stack_size, 0xe_56d6); /* call 0x10165d52 */
            ii(0x1008_067c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_067d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_067e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_067f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0680, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_0681, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0683, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_0689, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_068c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_068f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_0692, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_0695, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1008_0698, 5); calld(0x1008_aab4, 0xa417);             /* call 0x1008aab4 */
            ii(0x1008_069d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_06a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_06a3, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1008_06a6, 5); calld(0x1008_aab4, 0xa409);             /* call 0x1008aab4 */
            ii(0x1008_06ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_06ae, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1008_06b1, 5); calld(0x1007_6b90, -0x9b26);            /* call 0x10076b90 */
            ii(0x1008_06b6, 1); cwde();                                 /* cwde */
            ii(0x1008_06b7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_06b9, 2); if(jnzd(0x1008_06c5, 0xa)) goto l_0x1008_06c5; /* jnz 0x100806c5 */
            ii(0x1008_06bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_06be, 5); calld(0x1007_f659, -0x106a);            /* call 0x1007f659 */
            ii(0x1008_06c3, 2); jmpd(0x1008_0723, 0x5e); goto l_0x1008_0723; /* jmp 0x10080723 */
        l_0x1008_06c5:
            ii(0x1008_06c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_06c8, 5); calld(0x1008_ad28, 0xa65b);             /* call 0x1008ad28 */
            ii(0x1008_06cd, 2); test(al, al);                           /* test al, al */
            ii(0x1008_06cf, 2); if(jnzd(0x1008_0723, 0x52)) goto l_0x1008_0723; /* jnz 0x10080723 */
            ii(0x1008_06d1, 5); calld(0x1008_a7bc, 0xa0e6);             /* call 0x1008a7bc */
            ii(0x1008_06d6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_06db, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_06de, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1008_06e3, 5); calld(Definitions.sys_new, 0xe_5718);   /* call 0x10165e00 */
            ii(0x1008_06e8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_06eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_06ee, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_06f1, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1008_06f5, 2); if(jzd(0x1008_070d, 0x16)) goto l_0x1008_070d; /* jz 0x1008070d */
            ii(0x1008_06f7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_06fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_06fd, 5); calld(Definitions.my_ctor_c11, 0x2_31c7); /* call 0x100a38c9 */
            ii(0x1008_0702, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_0705, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_0708, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_070b, 2); jmpd(0x1008_0713, 0x6); goto l_0x1008_0713; /* jmp 0x10080713 */
        l_0x1008_070d:
            ii(0x1008_070d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_0710, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1008_0713:
            ii(0x1008_0713, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1008_0716, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_071b, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1008_071e, 5); calld(0x100a_4db6, 0x2_4693);           /* call 0x100a4db6 */
        l_0x1008_0723:
            ii(0x1008_0723, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0725, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_0726, 1); popd(edi);                              /* pop edi */
            ii(0x1008_0727, 1); popd(esi);                              /* pop esi */
            ii(0x1008_0728, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0729, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_072a, 1); retd(); return;                         /* ret */
        }
    }
}
