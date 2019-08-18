using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ace75b53-1d37-4727-b2d2-9cbede0bbfbc")]
        public void Method_1010_3752()
        {
            ii(0x1010_3752, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_3757, 5); calld(Definitions.sys_check_available_stack_size, 0x6_25f6); /* call 0x10165d52 */
            ii(0x1010_375c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_375d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_375e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_375f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3760, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3761, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3763, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_3769, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_376c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_376f, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_3773, 2); if(jnzd(0x1010_378e, 0x19)) goto l_0x1010_378e; /* jnz 0x1010378e */
            ii(0x1010_3775, 5); mov(ecx, 0x106);                        /* mov ecx, 0x106 */
            ii(0x1010_377a, 5); mov(ebx, StringDefinitions.HashCpp2);   /* mov ebx, 0x101a319f */
            ii(0x1010_377f, 5); mov(edx, StringDefinitions.AttemptedToRemoveNullUnitFromMapHashTable); /* mov edx, 0x101a31a8 */
            ii(0x1010_3784, 5); mov(eax, StringDefinitions.UnitNotEqual02); /* mov eax, 0x101a31db */
            ii(0x1010_3789, 5); calld(0x100f_07d4, -0x1_2fba);          /* call 0x100f07d4 */
        l_0x1010_378e:
            ii(0x1010_378e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3791, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1010_3795, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_3798, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_379b, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1010_379f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_37a2, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_37a6, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_37aa, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_37ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_37b0, 5); calld(0x1010_3642, -0x173);             /* call 0x10103642 */
            ii(0x1010_37b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_37b8, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1010_37bc, 2); if(jzd(0x1010_3803, 0x45)) goto l_0x1010_3803; /* jz 0x10103803 */
            ii(0x1010_37be, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_37c2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_37c5, 1); inc(eax);                               /* inc eax */
            ii(0x1010_37c6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_37c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_37cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_37cf, 5); calld(0x1010_3642, -0x192);             /* call 0x10103642 */
            ii(0x1010_37d4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_37d7, 1); inc(eax);                               /* inc eax */
            ii(0x1010_37d8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_37db, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1010_37df, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_37e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_37e5, 5); calld(0x1010_3642, -0x1a8);             /* call 0x10103642 */
            ii(0x1010_37ea, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_37ed, 1); inc(eax);                               /* inc eax */
            ii(0x1010_37ee, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_37f1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_37f4, 1); inc(eax);                               /* inc eax */
            ii(0x1010_37f5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_37f8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_37fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_37fe, 5); calld(0x1010_3642, -0x1c1);             /* call 0x10103642 */
        l_0x1010_3803:
            ii(0x1010_3803, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3805, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3806, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3807, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3808, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3809, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_380a, 1); retd(); return;                         /* ret */
        }
    }
}
