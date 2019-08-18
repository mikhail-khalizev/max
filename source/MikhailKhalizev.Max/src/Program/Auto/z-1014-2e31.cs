using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d130ddd9-2fd0-483b-ac16-381370c5b0d7")]
        public void Method_1014_2e31()
        {
            ii(0x1014_2e31, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1014_2e36, 5); calld(Definitions.sys_check_available_stack_size, 0x2_2f17); /* call 0x10165d52 */
            ii(0x1014_2e3b, 1); pushd(esi);                             /* push esi */
            ii(0x1014_2e3c, 1); pushd(edi);                             /* push edi */
            ii(0x1014_2e3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_2e3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2e40, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_2e46, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_2e49, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_2e4c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_2e4f, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1014_2e52, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2e56, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_2e58, 2); if(jled(0x1014_2e8f, 0x35)) goto l_0x1014_2e8f; /* jle 0x10142e8f */
            ii(0x1014_2e5a, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1014_2e5e, 5); calld(Definitions.my_get_res_data_by_id, -0xee8b); /* call 0x10133fd8 */
            ii(0x1014_2e63, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_2e66, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1014_2e6a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e6b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2e6e, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e6f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_2e72, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1014_2e75, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e76, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_2e7a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e7b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2e7f, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e80, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_2e83, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1014_2e86, 1); pushd(eax);                             /* push eax */
            ii(0x1014_2e87, 5); calld(/* sys */ 0x1016_abbc, 0x2_7d30); /* call 0x1016abbc */
            ii(0x1014_2e8c, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x1014_2e8f:
            ii(0x1014_2e8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2e91, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_2e92, 1); popd(edi);                              /* pop edi */
            ii(0x1014_2e93, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2e94, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
