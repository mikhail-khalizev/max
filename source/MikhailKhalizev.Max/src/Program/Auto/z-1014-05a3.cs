using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("647cf9cc-8176-4e33-89ad-35c8f07d8e24")]
        public void Method_1014_05a3()
        {
            ii(0x1014_05a3, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1014_05a8, 5); calld(Definitions.sys_check_available_stack_size, 0x2_57a5); /* call 0x10165d52 */
            ii(0x1014_05ad, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_05ae, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_05af, 1); pushd(esi);                             /* push esi */
            ii(0x1014_05b0, 1); pushd(edi);                             /* push edi */
            ii(0x1014_05b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_05b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_05b4, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_05ba, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_05bd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_05c0, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_05c7, 2); if(jzd(0x1014_05e0, 0x17)) goto l_0x1014_05e0; /* jz 0x101405e0 */
            ii(0x1014_05c9, 5); mov(edx, 0x101b_701c);                  /* mov edx, 0x101b701c */
            ii(0x1014_05ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_05d1, 5); calld(Definitions.sys_call_dtor_arr, 0x2_59e2); /* call 0x10165fb8 */
            ii(0x1014_05d6, 5); calld(Definitions.sys_delete_arr, 0x2_59fd); /* call 0x10165fd8 */
            ii(0x1014_05db, 5); jmpd(0x1014_069f, 0xbf); goto l_0x1014_069f; /* jmp 0x1014069f */
        l_0x1014_05e0:
            ii(0x1014_05e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_05e3, 7); mov(memd_a32[ds, eax + 0x46], 0x101b_7030); /* mov dword [eax+0x46], 0x101b7030 */
            ii(0x1014_05ea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_05ed, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x1014_05f0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_05f3, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1014_05f7, 2); if(jzd(0x1014_060d, 0x14)) goto l_0x1014_060d; /* jz 0x1014060d */
            ii(0x1014_05f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_05fb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_05fe, 5); calld(Definitions.my_dtor_d3, -0x6_88d0); /* call 0x100d7d33 */
            ii(0x1014_0603, 5); calld(Definitions.sys_delete, 0x2_595c); /* call 0x10165f64 */
            ii(0x1014_0608, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_060b, 2); jmpd(0x1014_0614, 0x7); goto l_0x1014_0614; /* jmp 0x10140614 */
        l_0x1014_060d:
            ii(0x1014_060d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1014_0614:
            ii(0x1014_0614, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0617, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1014_061a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_061d, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1014_0621, 2); if(jzd(0x1014_0637, 0x14)) goto l_0x1014_0637; /* jz 0x10140637 */
            ii(0x1014_0623, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_0625, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_0628, 5); calld(Definitions.my_dtor_d2, -0x7_20f5); /* call 0x100ce538 */
            ii(0x1014_062d, 5); calld(Definitions.sys_delete, 0x2_5932); /* call 0x10165f64 */
            ii(0x1014_0632, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_0635, 2); jmpd(0x1014_063e, 0x7); goto l_0x1014_063e; /* jmp 0x1014063e */
        l_0x1014_0637:
            ii(0x1014_0637, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1014_063e:
            ii(0x1014_063e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0641, 3); mov(eax, memd_a32[ds, eax + 0x34]);     /* mov eax, [eax+0x34] */
            ii(0x1014_0644, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_0647, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1014_064b, 2); if(jzd(0x1014_0661, 0x14)) goto l_0x1014_0661; /* jz 0x10140661 */
            ii(0x1014_064d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_064f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_0652, 5); calld(Definitions.my_dtor_d2, -0x7_211f); /* call 0x100ce538 */
            ii(0x1014_0657, 5); calld(Definitions.sys_delete, 0x2_5908); /* call 0x10165f64 */
            ii(0x1014_065c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_065f, 2); jmpd(0x1014_0668, 0x7); goto l_0x1014_0668; /* jmp 0x10140668 */
        l_0x1014_0661:
            ii(0x1014_0661, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1014_0668:
            ii(0x1014_0668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_066a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_066d, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1014_0670, 5); calld(0x100e_957e, -0x5_70f7);          /* call 0x100e957e */
            ii(0x1014_0675, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x1014_0678, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_067b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_067d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_0680, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0683, 5); calld(0x1014_1524, 0xe9c);              /* call 0x10141524 */
            ii(0x1014_0688, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1014_068b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_068e, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_0695, 2); if(jzd(0x1014_069f, 0x8)) goto l_0x1014_069f; /* jz 0x1014069f */
            ii(0x1014_0697, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_069a, 5); calld(Definitions.sys_delete, 0x2_58c5); /* call 0x10165f64 */
        l_0x1014_069f:
            ii(0x1014_069f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_06a2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_06a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_06a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_06aa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_06ab, 1); popd(edi);                              /* pop edi */
            ii(0x1014_06ac, 1); popd(esi);                              /* pop esi */
            ii(0x1014_06ad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_06ae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_06af, 1); retd(); return;                         /* ret */
        }
    }
}
