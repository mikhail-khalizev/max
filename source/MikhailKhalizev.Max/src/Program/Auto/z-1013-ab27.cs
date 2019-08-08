using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("52ad4c7c-ee79-41e0-83ad-2cf6aae52779")]
        public void Method_1013_ab27()
        {
            ii(0x1013_ab27, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_ab2c, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b221); /* call 0x10165d52 */
            ii(0x1013_ab31, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_ab32, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ab33, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ab34, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ab35, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ab36, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ab38, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_ab3e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_ab41, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_ab44, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_ab4b, 2); if(jzd(0x1013_ab61, 0x14)) goto l_0x1013_ab61; /* jz 0x1013ab61 */
            ii(0x1013_ab4d, 5); mov(edx, 0x101b_6eb0);                  /* mov edx, 0x101b6eb0 */
            ii(0x1013_ab52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ab55, 5); calld(Definitions.sys_call_dtor_arr, 0x2_b45e); /* call 0x10165fb8 */
            ii(0x1013_ab5a, 5); calld(Definitions.sys_delete_arr, 0x2_b479); /* call 0x10165fd8 */
            ii(0x1013_ab5f, 2); jmpd(0x1013_abb2, 0x51); goto l_0x1013_abb2; /* jmp 0x1013abb2 */
        l_0x1013_ab61:
            ii(0x1013_ab61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ab64, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6ec4); /* mov dword [eax+0x2], 0x101b6ec4 */
            ii(0x1013_ab6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ab6e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_ab71, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ab73, 2); if(jzd(0x1013_aba1, 0x2c)) goto l_0x1013_aba1; /* jz 0x1013aba1 */
            ii(0x1013_ab75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ab78, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_ab7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ab7d, 2); if(jnzd(0x1013_ab88, 0x9)) goto l_0x1013_ab88; /* jnz 0x1013ab88 */
            ii(0x1013_ab7f, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_ab86, 2); jmpd(0x1013_aba1, 0x19); goto l_0x1013_aba1; /* jmp 0x1013aba1 */
        l_0x1013_ab88:
            ii(0x1013_ab88, 5); mov(ecx, 0x24);                         /* mov ecx, 0x24 */
            ii(0x1013_ab8d, 5); mov(ebx, StringDefinitions.SmartptrCpp); /* mov ebx, 0x101acc20 */
            ii(0x1013_ab92, 5); mov(edx, StringDefinitions.ReferenceCountEqual0); /* mov edx, 0x101acc2d */
            ii(0x1013_ab97, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_ab99, 5); calld(Definitions.sys_assert, 0x2_b1f4); /* call 0x10165d92 */
            ii(0x1013_ab9e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_aba1:
            ii(0x1013_aba1, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_aba8, 2); if(jzd(0x1013_abb2, 0x8)) goto l_0x1013_abb2; /* jz 0x1013abb2 */
            ii(0x1013_abaa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_abad, 5); calld(Definitions.sys_delete, 0x2_b3b2); /* call 0x10165f64 */
        l_0x1013_abb2:
            ii(0x1013_abb2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_abb5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_abb8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_abbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_abbd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_abbe, 1); popd(edi);                              /* pop edi */
            ii(0x1013_abbf, 1); popd(esi);                              /* pop esi */
            ii(0x1013_abc0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_abc1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_abc2, 1); retd(); return;                         /* ret */
        }
    }
}
