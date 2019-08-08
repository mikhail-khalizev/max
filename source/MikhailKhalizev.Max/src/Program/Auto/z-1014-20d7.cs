using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c8c493a-4de5-4e82-a972-c23c62024009")]
        public void Method_1014_20d7()
        {
            ii(0x1014_20d7, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1014_20dc, 5); calld(Definitions.sys_check_available_stack_size, 0x2_3c71); /* call 0x10165d52 */
            ii(0x1014_20e1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_20e2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_20e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_20e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_20e6, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1014_20ec, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_20ef, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_20f2, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_20f5, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1014_20f8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_20fc, 5); calld(Definitions.sys_new_arr, 0x2_3f0f); /* call 0x10166010 */
            ii(0x1014_2101, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_2104, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1014_2107, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_210a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_210d, 5); calld(/* sys */ 0x1018_0f0b, 0x3_edf9); /* call 0x10180f0b */
            ii(0x1014_2112, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2115, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_2117, 5); calld(Definitions.my_string_release, 0x300); /* call 0x1014241c */
            ii(0x1014_211c, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_2121, 5); calld(Definitions.sys_new, 0x2_3cda);   /* call 0x10165e00 */
            ii(0x1014_2126, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_2129, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_212c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_212f, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1014_2133, 2); if(jzd(0x1014_214b, 0x16)) goto l_0x1014_214b; /* jz 0x1014214b */
            ii(0x1014_2135, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1014_2138, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_213b, 5); calld(Definitions.my_strobj_ctor_char_ptr, -0x9a4); /* call 0x1014179c */
            ii(0x1014_2140, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_2143, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_2146, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_2149, 2); jmpd(0x1014_2151, 0x6); goto l_0x1014_2151; /* jmp 0x10142151 */
        l_0x1014_214b:
            ii(0x1014_214b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_214e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1014_2151:
            ii(0x1014_2151, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_2154, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_2157, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1014_2159, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_215c, 5); calld(Definitions.sys_delete_arr, 0x2_3e77); /* call 0x10165fd8 */
            ii(0x1014_2161, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2164, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_2167, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1014_216a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_216c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_216d, 1); popd(edi);                              /* pop edi */
            ii(0x1014_216e, 1); popd(esi);                              /* pop esi */
            ii(0x1014_216f, 1); retd(); return;                         /* ret */
        }
    }
}
