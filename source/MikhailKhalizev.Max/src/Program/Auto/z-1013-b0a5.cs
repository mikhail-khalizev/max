using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b321647d-edd2-4775-bdb5-8cae1ad6255a")]
        public void Method_1013_b0a5()
        {
            ii(0x1013_b0a5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b0aa, 5); calld(Definitions.sys_check_available_stack_size, 0x2aca3); /* call 0x10165d52 */
            ii(0x1013_b0af, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b0b0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b0b1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b0b2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b0b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b0b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b0b6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b0bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b0bf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b0c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b0c5, 5); calld(0x1013_b325, 0x25b);              /* call 0x1013b325 */
            ii(0x1013_b0ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b0cd, 4); cmp(memd_a32[ds, eax + 0x6], 0);        /* cmp dword [eax+0x6], 0x0 */
            ii(0x1013_b0d1, 2); if(jzd(0x1013_b0e8, 0x15)) goto l_0x1013_b0e8; /* jz 0x1013b0e8 */
            ii(0x1013_b0d3, 5); mov(edx, 0x101b_6edc);                  /* mov edx, 0x101b6edc */
            ii(0x1013_b0d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b0db, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1013_b0de, 5); calld(Definitions.sys_call_dtor_arr, 0x2aed5); /* call 0x10165fb8 */
            ii(0x1013_b0e3, 5); calld(Definitions.sys_delete_arr, 0x2aef0); /* call 0x10165fd8 */
        l_0x1013_b0e8:
            ii(0x1013_b0e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b0eb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b0ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b0f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b0f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b0f4, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b0f5, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b0f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b0f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b0f8, 1); retd(); return;                         /* ret */
        }
    }
}
