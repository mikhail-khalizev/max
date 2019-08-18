using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1c89-63c38b00")]
        public void my_string_append_string()
        {
            ii(0x1014_1c89, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_1c8e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_40bf); /* call 0x10165d52 */
            ii(0x1014_1c93, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1c94, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1c95, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1c96, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1c97, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1c98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1c9a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_1ca0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1ca3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1ca6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1ca9, 5); calld(Definitions.my_string_make_single_ref, 0x6ae); /* call 0x1014235c */
            ii(0x1014_1cae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1cb1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1cb3, 5); calld(Definitions.my_strobj_get_len, -0x5_6d94); /* call 0x100eaf24 */
            ii(0x1014_1cb8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1cba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1cbd, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1cbf, 5); calld(Definitions.my_strobj_get_len, -0x5_6da0); /* call 0x100eaf24 */
            ii(0x1014_1cc4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_1cc6, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_1cc9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1ccc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1cce, 5); calld(Definitions.my_strobj_get_size, 0x889); /* call 0x1014255c */
            ii(0x1014_1cd3, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1014_1cd7, 2); if(jged(0x1014_1cf6, 0x1d)) goto l_0x1014_1cf6; /* jge 0x10141cf6 */
            ii(0x1014_1cd9, 5); calld(Definitions.my_set_al_1, 0x7ee);  /* call 0x101424cc */
            ii(0x1014_1cde, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_1ce0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_1ce2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1014_1ce6, 5); calld(Definitions.my_string_compute_capacity_from_length, 0x6ed); /* call 0x101423d8 */
            ii(0x1014_1ceb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_1cee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1cf1, 5); calld(Definitions.my_string_reserve, -0x194); /* call 0x10141b62 */
        l_0x1014_1cf6:
            ii(0x1014_1cf6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1cf9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1cfb, 5); calld(Definitions.my_strobj_c_str, -0xb_8504); /* call 0x100897fc */
            ii(0x1014_1d00, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1d02, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1d05, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1d07, 5); calld(Definitions.my_strobj_get_len, -0x5_6de8); /* call 0x100eaf24 */
            ii(0x1014_1d0c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_1d0f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1d12, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1d14, 5); calld(Definitions.my_strobj_c_str, -0xb_851d); /* call 0x100897fc */
            ii(0x1014_1d19, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1014_1d1b, 5); calld(Definitions.sys_strcpy, 0x2_41af); /* call 0x10165ecf */
            ii(0x1014_1d20, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_1d24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1d27, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1d29, 5); calld(Definitions.my_strobj_set_len, 0x7be); /* call 0x101424ec */
            ii(0x1014_1d2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1d31, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_1d34, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1d37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1d39, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1d3a, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1d3b, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1d3c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1d3d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1d3e, 1); retd(); return;                         /* ret */
        }
    }
}
