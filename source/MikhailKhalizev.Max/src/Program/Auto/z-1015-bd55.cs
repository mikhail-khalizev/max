using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4276e489-6090-4571-8995-806ddad961ba")]
        public void Method_1015_bd55()
        {
            ii(0x1015_bd55, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_bd5a, 5); calld(Definitions.sys_check_available_stack_size, 0x9ff3); /* call 0x10165d52 */
            ii(0x1015_bd5f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_bd60, 1); pushd(esi);                             /* push esi */
            ii(0x1015_bd61, 1); pushd(edi);                             /* push edi */
            ii(0x1015_bd62, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_bd63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_bd65, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_bd6b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_bd6e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_bd71, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_bd74, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_bd77, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_bd7c, 5); calld(0x1010_3752, -0x5862f);           /* call 0x10103752 */
            ii(0x1015_bd81, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_bd85, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_bd89, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_bd8c, 5); calld(0x1015_bcca, -0xc7);              /* call 0x1015bcca */
            ii(0x1015_bd91, 5); calld(0x100d_53f0, -0x869a6);           /* call 0x100d53f0 */
            ii(0x1015_bd96, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_bd98, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_bd9a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_bd9d, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_bda2, 5); calld(0x1010_346f, -0x58938);           /* call 0x1010346f */
            ii(0x1015_bda7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_bda9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_bdaa, 1); popd(edi);                              /* pop edi */
            ii(0x1015_bdab, 1); popd(esi);                              /* pop esi */
            ii(0x1015_bdac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_bdad, 1); retd(); return;                         /* ret */
        }
    }
}
