using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c42a8a29-b7e7-4c47-98dc-f17d516a973e")]
        public void Method_1008_ae2c()
        {
            ii(0x1008_ae2c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_ae31, 5); calld(Definitions.sys_check_available_stack_size, 0xd_af1c); /* call 0x10165d52 */
            ii(0x1008_ae36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ae37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ae38, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ae39, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ae3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ae3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ae3d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_ae43, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_ae46, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_ae49, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_ae4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ae4f, 5); calld(0x1007_6cd0, -0x1_4184);          /* call 0x10076cd0 */
            ii(0x1008_ae54, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_ae57, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_ae5a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_ae5d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ae60, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_ae63, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_ae66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ae68, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ae69, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ae6a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ae6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ae6c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ae6d, 1); retd(); return;                         /* ret */
        }
    }
}
