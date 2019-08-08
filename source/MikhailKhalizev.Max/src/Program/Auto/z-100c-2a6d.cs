using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26299201-454d-4376-ad51-ce65b757ea4d")]
        public void Method_100c_2a6d()
        {
            ii(0x100c_2a6d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_2a72, 5); calld(Definitions.sys_check_available_stack_size, 0xa_32db); /* call 0x10165d52 */
            ii(0x100c_2a77, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_2a78, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2a79, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2a7a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2a7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2a7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2a7e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_2a84, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_2a87, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_2a8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2a8d, 4); cmp(memd_a32[ds, eax + 0x63], 0);       /* cmp dword [eax+0x63], 0x0 */
            ii(0x100c_2a91, 2); if(jzd(0x100c_2ab5, 0x22)) goto l_0x100c_2ab5; /* jz 0x100c2ab5 */
            ii(0x100c_2a93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2a96, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_2a99, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2a9c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2a9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2aa1, 3); mov(edx, memd_a32[ds, eax + 0x63]);     /* mov edx, [eax+0x63] */
            ii(0x100c_2aa4, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2aa6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2aa9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2aab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2aae, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_2ab0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2ab2, 3); or(memb_a32[ds, eax], 0x1);             /* or byte [eax], 0x1 */
        l_0x100c_2ab5:
            ii(0x100c_2ab5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2ab7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2ab8, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2ab9, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2aba, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_2abb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_2abc, 1); retd(); return;                         /* ret */
        }
    }
}
