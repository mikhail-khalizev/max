using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8d8b-75c4bae1")]
        public void Method_100b_8d8b()
        {
            ii(0x100b_8d8b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_8d90, 5); calld(Definitions.sys_check_available_stack_size, 0xa_cfbd); /* call 0x10165d52 */
            ii(0x100b_8d95, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8d96, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8d97, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8d98, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8d99, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8d9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8d9c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_8da2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8da5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8da8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8dab, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8dae, 5); calld(0x1007_6600, -0x4_27b3);          /* call 0x10076600 */
            ii(0x100b_8db3, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_8db6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_8db8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_8dba, 5); calld(0x1013_c25c, 0x8_349d);           /* call 0x1013c25c */
            ii(0x100b_8dbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8dc2, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100b_8dc5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_8dc8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8dcb, 5); calld(0x1013_c0fa, 0x8_332a);           /* call 0x1013c0fa */
            ii(0x100b_8dd0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8dd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_8dd5, 3); mov(dl, memb_a32[ds, eax + 0x14]);      /* mov dl, [eax+0x14] */
            ii(0x100b_8dd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8ddb, 5); calld(0x100c_b818, 0x1_2a38);           /* call 0x100cb818 */
            ii(0x100b_8de0, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100b_8de5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8de8, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x100b_8deb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8dee, 5); calld(0x1013_c055, 0x8_3262);           /* call 0x1013c055 */
            ii(0x100b_8df3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8df5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8df6, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8df7, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8df8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8df9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8dfa, 1); retd();                                 /* ret */
        }
    }
}
