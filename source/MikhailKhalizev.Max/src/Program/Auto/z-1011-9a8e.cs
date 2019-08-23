using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9a8e-3e221451")]
        public void Method_1011_9a8e()
        {
            ii(0x1011_9a8e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_9a93, 5); calld(Definitions.sys_check_available_stack_size, 0x4_c2ba); /* call 0x10165d52 */
            ii(0x1011_9a98, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9a99, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9a9a, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9a9b, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9a9c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9a9d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9a9f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_9aa5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9aa8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_9aab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9aae, 3); add(edx, 0x16);                         /* add edx, 0x16 */
            ii(0x1011_9ab1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9ab4, 5); calld(0x1013_bb7b, 0x2_20c2);           /* call 0x1013bb7b */
            ii(0x1011_9ab9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9abc, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1011_9abf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9ac2, 5); calld(0x1013_bb11, 0x2_204a);           /* call 0x1013bb11 */
            ii(0x1011_9ac7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9aca, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x1011_9acd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9ad0, 5); calld(0x1013_bb7b, 0x2_20a6);           /* call 0x1013bb7b */
            ii(0x1011_9ad5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9ad8, 3); add(edx, 0x1b);                         /* add edx, 0x1b */
            ii(0x1011_9adb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9ade, 5); calld(0x1013_bb7b, 0x2_2098);           /* call 0x1013bb7b */
            ii(0x1011_9ae3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9ae6, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1011_9ae9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9aec, 5); calld(0x1013_bb7b, 0x2_208a);           /* call 0x1013bb7b */
            ii(0x1011_9af1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9af4, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1011_9af7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9afa, 5); calld(0x1013_bb7b, 0x2_207c);           /* call 0x1013bb7b */
            ii(0x1011_9aff, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9b02, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1011_9b05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b08, 5); calld(0x1013_bbe5, 0x2_20d8);           /* call 0x1013bbe5 */
            ii(0x1011_9b0d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9b10, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1011_9b13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b16, 5); calld(0x1013_bbe5, 0x2_20ca);           /* call 0x1013bbe5 */
            ii(0x1011_9b1b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9b1e, 3); add(edx, 0x25);                         /* add edx, 0x25 */
            ii(0x1011_9b21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b24, 5); calld(0x1013_bbe5, 0x2_20bc);           /* call 0x1013bbe5 */
            ii(0x1011_9b29, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_9b2c, 3); add(edx, 0x29);                         /* add edx, 0x29 */
            ii(0x1011_9b2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9b32, 5); calld(0x1013_bbe5, 0x2_20ae);           /* call 0x1013bbe5 */
            ii(0x1011_9b37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9b39, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9b3a, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9b3b, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9b3c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9b3d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9b3e, 1); retd();                                 /* ret */
        }
    }
}
