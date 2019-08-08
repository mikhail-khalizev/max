using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83294f1a-65ce-41ca-ae78-5e34cdc524ea")]
        public void Method_100e_84b8()
        {
            ii(0x100e_84b8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_84bd, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d890); /* call 0x10165d52 */
            ii(0x100e_84c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_84c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_84c4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_84c5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_84c6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_84c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_84c9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_84cf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_84d2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_84d5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_84d9, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x100e_84dc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_84de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_84e1, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_84e4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_84e6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_84e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_84ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_84ee, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_84ef, 1); popd(edi);                              /* pop edi */
            ii(0x100e_84f0, 1); popd(esi);                              /* pop esi */
            ii(0x100e_84f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_84f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_84f3, 1); retd(); return;                         /* ret */
        }
    }
}
