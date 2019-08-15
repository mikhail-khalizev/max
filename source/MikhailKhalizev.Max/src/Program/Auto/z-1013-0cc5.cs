using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6be80986-ef6a-47c9-9af6-5e8f9af317cb")]
        public void Method_1013_0cc5()
        {
            ii(0x1013_0cc5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_0cca, 5); calld(Definitions.sys_check_available_stack_size, 0x3_5083); /* call 0x10165d52 */
            ii(0x1013_0ccf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0cd0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0cd1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0cd2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0cd3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0cd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0cd6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0cdc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0cdf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_0ce2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_0ce5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_0ce8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0ceb, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0cef, 2); if(jzd(0x1013_0d05, 0x14)) goto l_0x1013_0d05; /* jz 0x10130d05 */
            ii(0x1013_0cf1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0cf4, 4); mov(memb_a32[ds, eax + 0x17], 0);       /* mov byte [eax+0x17], 0x0 */
            ii(0x1013_0cf8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0cfd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0d00, 5); calld(0x1013_0c16, -0xef);              /* call 0x10130c16 */
        l_0x1013_0d05:
            ii(0x1013_0d05, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0d07, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0d08, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0d09, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0d0a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0d0b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0d0c, 1); retd(); return;                         /* ret */
        }
    }
}
