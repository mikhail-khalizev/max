using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d22dd0a-6594-46bd-b3fa-69103f12917d")]
        public void Method_100a_3879()
        {
            ii(0x100a_3879, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_387e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_24cf); /* call 0x10165d52 */
            ii(0x100a_3883, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3884, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3885, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3886, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3887, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3888, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3889, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_388b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3891, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_3894, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3896, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3899, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_389c, 5); calld(0x1008_af28, -0x1_8979);          /* call 0x1008af28 */
            ii(0x100a_38a1, 5); calld(0x100a_b198, 0x78f2);             /* call 0x100ab198 */
            ii(0x100a_38a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_38a9, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_38ac, 5); calld(0x1008_af28, -0x1_8989);          /* call 0x1008af28 */
            ii(0x100a_38b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_38b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_38b7, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_38ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_38bd, 3); calld_abs(memd_a32[ds, edx + 0x34]);    /* call dword [edx+0x34] */
            ii(0x100a_38c0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_38c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_38c3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_38c4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_38c5, 1); popd(edx);                              /* pop edx */
            ii(0x100a_38c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_38c7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_38c8, 1); retd(); return;                         /* ret */
        }
    }
}
