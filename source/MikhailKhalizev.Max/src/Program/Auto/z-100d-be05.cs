using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c0ddcc6-a790-40db-9b7d-6c6428bfe78a")]
        public void Method_100d_be05()
        {
            ii(0x100d_be05, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100d_be0a, 5); calld(Definitions.sys_check_available_stack_size, 0x89f43); /* call 0x10165d52 */
            ii(0x100d_be0f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_be10, 1); pushd(edi);                             /* push edi */
            ii(0x100d_be11, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_be12, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_be14, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_be1a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_be1d, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_be20, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_be23, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100d_be26, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x100d_be29, 1); pushd(eax);                             /* push eax */
            ii(0x100d_be2a, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x100d_be2d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_be2e, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x100d_be32, 1); pushd(eax);                             /* push eax */
            ii(0x100d_be33, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100d_be37, 1); pushd(eax);                             /* push eax */
            ii(0x100d_be38, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100d_be3b, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_be3e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_be41, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_be44, 5); calld(0x100c_fe4d, -0xbffc);            /* call 0x100cfe4d */
            ii(0x100d_be49, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_be4c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_be4f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_be52, 5); calld(0x100e_0a00, 0x4ba9);             /* call 0x100e0a00 */
            ii(0x100d_be57, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_be59, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_be5b, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x100d_be5e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_be61, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100d_be64, 5); calld(0x100e_0970, 0x4b07);             /* call 0x100e0970 */
            ii(0x100d_be69, 3); sub(eax, 0x48);                         /* sub eax, 0x48 */
            ii(0x100d_be6c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_be6f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_be72, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_be75, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_be78, 7); mov(memd_a32[ds, eax + 0x40], 0x101b_5f18); /* mov dword [eax+0x40], 0x101b5f18 */
            ii(0x100d_be7f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_be82, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_be85, 3); mov(memd_a32[ds, edx + 0x44], eax);     /* mov [edx+0x44], eax */
            ii(0x100d_be88, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_be8b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_be8e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_be91, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_be93, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_be94, 1); popd(edi);                              /* pop edi */
            ii(0x100d_be95, 1); popd(esi);                              /* pop esi */
            ii(0x100d_be96, 3); retd(0x14); return;                     /* ret 0x14 */
        }
    }
}