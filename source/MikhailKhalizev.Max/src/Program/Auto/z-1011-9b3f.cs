using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1e049c4-3531-40ad-9ebf-aefdf987d76b")]
        public void Method_1011_9b3f()
        {
            ii(0x1011_9b3f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_9b44, 5); calld(Definitions.sys_check_available_stack_size, 0x4_c209); /* call 0x10165d52 */
            ii(0x1011_9b49, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9b4a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9b4b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9b4c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9b4d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9b4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9b50, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_9b56, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9b59, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_9b5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9b5f, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_9b62, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9b65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b68, 5); calld(0x1013_c0fa, 0x2_258d);           /* call 0x1013c0fa */
            ii(0x1011_9b6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9b70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_9b72, 3); mov(dl, memb_a32[ds, eax + 0x18]);      /* mov dl, [eax+0x18] */
            ii(0x1011_9b75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b78, 5); calld(0x100c_b818, -0x4_e365);          /* call 0x100cb818 */
            ii(0x1011_9b7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9b80, 3); mov(edx, memd_a32[ds, eax + 0x17]);     /* mov edx, [eax+0x17] */
            ii(0x1011_9b83, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9b86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b89, 5); calld(0x1013_c0fa, 0x2_256c);           /* call 0x1013c0fa */
            ii(0x1011_9b8e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9b91, 3); mov(edx, memd_a32[ds, eax + 0x19]);     /* mov edx, [eax+0x19] */
            ii(0x1011_9b94, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9b97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b9a, 5); calld(0x1013_c0fa, 0x2_255b);           /* call 0x1013c0fa */
            ii(0x1011_9b9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9ba2, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1011_9ba5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9ba8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9bab, 5); calld(0x1013_c0fa, 0x2_254a);           /* call 0x1013c0fa */
            ii(0x1011_9bb0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9bb3, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1011_9bb6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_9bb9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9bbc, 5); calld(0x1013_c0fa, 0x2_2539);           /* call 0x1013c0fa */
            ii(0x1011_9bc1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9bc4, 3); mov(edx, memd_a32[ds, eax + 0x1d]);     /* mov edx, [eax+0x1d] */
            ii(0x1011_9bc7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9bca, 5); calld(0x1013_c164, 0x2_2595);           /* call 0x1013c164 */
            ii(0x1011_9bcf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9bd2, 3); mov(edx, memd_a32[ds, eax + 0x21]);     /* mov edx, [eax+0x21] */
            ii(0x1011_9bd5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9bd8, 5); calld(0x1013_c164, 0x2_2587);           /* call 0x1013c164 */
            ii(0x1011_9bdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9be0, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x1011_9be3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9be6, 5); calld(0x1013_c164, 0x2_2579);           /* call 0x1013c164 */
            ii(0x1011_9beb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9bee, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1011_9bf1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9bf4, 5); calld(0x1013_c164, 0x2_256b);           /* call 0x1013c164 */
            ii(0x1011_9bf9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9bfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9bfc, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9bfd, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9bfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9bff, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9c00, 1); retd(); return;                         /* ret */
        }
    }
}
