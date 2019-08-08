using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("29cc271f-dc1b-45fd-9138-85707cd8561f")]
        public void Method_1014_b64e()
        {
            ii(0x1014_b64e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_b653, 5); calld(Definitions.sys_check_available_stack_size, 0x1_a6fa); /* call 0x10165d52 */
            ii(0x1014_b658, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_b659, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_b65a, 1); pushd(esi);                             /* push esi */
            ii(0x1014_b65b, 1); pushd(edi);                             /* push edi */
            ii(0x1014_b65c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_b65d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_b65f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_b665, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_b668, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_b66b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b66e, 5); calld(0x1007_61d4, -0xd_549f);          /* call 0x100761d4 */
            ii(0x1014_b673, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b675, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b678, 3); mov(memd_a32[ds, eax + 0x7e], edx);     /* mov [eax+0x7e], edx */
            ii(0x1014_b67b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b67e, 4); cmp(memd_a32[ds, eax + 0x7e], 0);       /* cmp dword [eax+0x7e], 0x0 */
            ii(0x1014_b682, 2); if(jnzd(0x1014_b6a7, 0x23)) goto l_0x1014_b6a7; /* jnz 0x1014b6a7 */
            ii(0x1014_b684, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b687, 5); calld(0x1014_b5ef, -0x9d);              /* call 0x1014b5ef */
            ii(0x1014_b68c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_b68f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b692, 5); calld(0x1014_b64e, -0x49);              /* call 0x1014b64e */
            ii(0x1014_b697, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b69a, 5); calld(0x1007_61d4, -0xd_54cb);          /* call 0x100761d4 */
            ii(0x1014_b69f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b6a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b6a4, 3); mov(memd_a32[ds, eax + 0x7e], edx);     /* mov [eax+0x7e], edx */
        l_0x1014_b6a7:
            ii(0x1014_b6a7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_b6aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_b6ad, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b6b0, 5); calld(0x1008_ab1c, -0xc_0b99);          /* call 0x1008ab1c */
            ii(0x1014_b6b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_b6b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_b6b8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_b6b9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_b6ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_b6bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_b6bc, 1); retd(); return;                         /* ret */
        }
    }
}
