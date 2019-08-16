using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc72a3f0-8d1f-4405-a656-6a434d3dbb3e")]
        public void Method_1013_38bc()
        {
            ii(0x1013_38bc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_38c1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_248c); /* call 0x10165d52 */
            ii(0x1013_38c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_38c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_38c8, 1); pushd(esi);                             /* push esi */
            ii(0x1013_38c9, 1); pushd(edi);                             /* push edi */
            ii(0x1013_38ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_38cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_38cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_38d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_38d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_38d9, 5); mov(ebx, 0x101b_6c5c);                  /* mov ebx, 0x101b6c5c */
            ii(0x1013_38de, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1013_38e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_38e6, 5); calld(Definitions.sys_call_dtor_arr_v2, 0x3_26f5); /* call 0x10165fe0 */
            ii(0x1013_38eb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_38ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_38f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_38f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_38f4, 1); popd(edi);                              /* pop edi */
            ii(0x1013_38f5, 1); popd(esi);                              /* pop esi */
            ii(0x1013_38f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_38f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_38f8, 1); retd(); return;                         /* ret */
        }
    }
}