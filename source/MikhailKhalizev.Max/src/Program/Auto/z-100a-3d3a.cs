using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("588ef3c5-2591-4148-a1e9-943d94898351")]
        public void Method_100a_3d3a()
        {
            ii(0x100a_3d3a, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_3d3f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_200e); /* call 0x10165d52 */
            ii(0x100a_3d44, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3d45, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3d46, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3d47, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3d48, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3d49, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3d4b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_3d51, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3d54, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_3d57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3d5a, 5); calld(0x100a_a0b0, 0x6351);             /* call 0x100aa0b0 */
            ii(0x100a_3d5f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3d62, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3d65, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_3d68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3d6b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3d6e, 5); calld(Definitions.my_ctor_0x101b38f8, -0x2_d683); /* call 0x100766f0 */
            ii(0x100a_3d73, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_3d76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3d79, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3d7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3d7f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3d82, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4ef4); /* mov dword [eax+0x2], 0x101b4ef4 */
            ii(0x100a_3d89, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_3d8c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3d8f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3d92, 5); calld(0x1007_6630, -0x2_d767);          /* call 0x10076630 */
            ii(0x100a_3d97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3d9a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_3d9d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_3da0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3da2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3da3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3da4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3da5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3da6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3da7, 1); retd(); return;                         /* ret */
        }
    }
}
