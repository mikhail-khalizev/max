using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5425c12b-3fc2-405c-a0be-176753d46f1f")]
        public void Method_100a_3a81()
        {
            ii(0x100a_3a81, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_3a86, 5); calld(Definitions.sys_check_available_stack_size, 0xc22c7); /* call 0x10165d52 */
            ii(0x100a_3a8b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3a8c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3a8d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3a8e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3a8f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3a90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3a92, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_3a98, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3a9b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_3a9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3aa1, 5); calld(0x100a_a0b0, 0x660a);             /* call 0x100aa0b0 */
            ii(0x100a_3aa6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3aa9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3aac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_3aaf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3ab2, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3ab5, 5); calld(Definitions.my_ctor_0x101b38f8, -0x2d3ca); /* call 0x100766f0 */
            ii(0x100a_3aba, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_3abd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3ac0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3ac3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3ac6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3ac9, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f14); /* mov dword [eax+0x2], 0x101b4f14 */
            ii(0x100a_3ad0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_3ad3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3ad6, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3ad9, 5); calld(0x1007_6630, -0x2d4ae);           /* call 0x10076630 */
            ii(0x100a_3ade, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3ae1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_3ae4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_3ae7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3ae9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3aea, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3aeb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3aec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3aed, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3aee, 1); retd(); return;                         /* ret */
        }
    }
}