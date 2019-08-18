using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2d3d-d7a27182")]
        public void Method_100a_2d3d()
        {
            ii(0x100a_2d3d, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100a_2d42, 5); calld(Definitions.sys_check_available_stack_size, 0xc_300b); /* call 0x10165d52 */
            ii(0x100a_2d47, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2d48, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2d49, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2d4a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2d4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2d4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2d4e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_2d54, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2d57, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2d5a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_2d5d, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_c272); /* call 0x10076af0 */
            ii(0x100a_2d62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2d65, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_2d68, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2d6b, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_2d6e, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100a_2d71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2d74, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x100a_2d77, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_2d7a, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x100a_2d7e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_2d81, 4); mov(memw_a32[ss, ebp - 0xe], ax);       /* mov [ebp-0xe], ax */
            ii(0x100a_2d85, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100a_2d88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2d8b, 5); calld(0x1007_5e64, -0x2_cf2c);          /* call 0x10075e64 */
            ii(0x100a_2d90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2d93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2d95, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2d96, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2d97, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2d98, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2d99, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2d9a, 1); retd(); return;                         /* ret */
        }
    }
}
