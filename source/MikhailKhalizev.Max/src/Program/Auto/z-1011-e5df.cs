using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_e5df-842c4d35")]
        public void Method_1011_e5df()
        {
            ii(0x1011_e5df, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_e5e4, 5); calld(Definitions.sys_check_available_stack_size, 0x4_7769); /* call 0x10165d52 */
            ii(0x1011_e5e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_e5ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_e5eb, 1); pushd(esi);                             /* push esi */
            ii(0x1011_e5ec, 1); pushd(edi);                             /* push edi */
            ii(0x1011_e5ed, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_e5ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_e5f0, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_e5f6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_e5f9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_e5fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e5fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e601, 5); calld(0x1013_ad71, 0x1_c76b);           /* call 0x1013ad71 */
            ii(0x1011_e606, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e608, 6); if(jzd(0x1011_e6a7, 0x99)) goto l_0x1011_e6a7; /* jz 0x1011e6a7 */
            ii(0x1011_e60e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e611, 5); calld(0x100b_7f74, -0x6_66a2);          /* call 0x100b7f74 */
            ii(0x1011_e616, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e618, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e61b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_e61e, 5); calld(0x1012_0834, 0x2211);             /* call 0x10120834 */
            ii(0x1011_e623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e626, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_e62a, 2); if(jzd(0x1011_e656, 0x2a)) goto l_0x1011_e656; /* jz 0x1011e656 */
            ii(0x1011_e62c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e62f, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_e632, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_e635, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_e639, 2); if(jzd(0x1011_e64f, 0x14)) goto l_0x1011_e64f; /* jz 0x1011e64f */
            ii(0x1011_e63b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e63d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_e640, 5); calld(Definitions.my_dtor_d7, -0x2403); /* call 0x1011c242 */
            ii(0x1011_e645, 5); calld(Definitions.sys_delete, 0x4_791a); /* call 0x10165f64 */
            ii(0x1011_e64a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_e64d, 2); jmpd(0x1011_e656, 0x7); goto l_0x1011_e656; /* jmp 0x1011e656 */
        l_0x1011_e64f:
            ii(0x1011_e64f, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_e656:
            ii(0x1011_e656, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e659, 4); cmp(memd_a32[ds, eax + 0x1a], 0);       /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_e65d, 2); if(jzd(0x1011_e689, 0x2a)) goto l_0x1011_e689; /* jz 0x1011e689 */
            ii(0x1011_e65f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e662, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_e665, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_e668, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_e66c, 2); if(jzd(0x1011_e682, 0x14)) goto l_0x1011_e682; /* jz 0x1011e682 */
            ii(0x1011_e66e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e670, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_e673, 5); calld(Definitions.my_dtor_d7, -0x2436); /* call 0x1011c242 */
            ii(0x1011_e678, 5); calld(Definitions.sys_delete, 0x4_78e7); /* call 0x10165f64 */
            ii(0x1011_e67d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_e680, 2); jmpd(0x1011_e689, 0x7); goto l_0x1011_e689; /* jmp 0x1011e689 */
        l_0x1011_e682:
            ii(0x1011_e682, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_e689:
            ii(0x1011_e689, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e68c, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_e693, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e696, 7); mov(memd_a32[ds, eax + 0x1a], 0);       /* mov dword [eax+0x1a], 0x0 */
            ii(0x1011_e69d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e69f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e6a2, 5); calld(0x100b_7fa4, -0x6_6703);          /* call 0x100b7fa4 */
        l_0x1011_e6a7:
            ii(0x1011_e6a7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_e6aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e6ad, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_e6b0, 5); calld(0x1012_0834, 0x217f);             /* call 0x10120834 */
            ii(0x1011_e6b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_e6b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_e6b8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_e6b9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_e6ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_e6bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_e6bc, 1); retd();                                 /* ret */
        }
    }
}
