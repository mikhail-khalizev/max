using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b83524b9-11b2-48d1-ae23-c5fbb0d585d2")]
        public void Method_1007_2305()
        {
            ii(0x1007_2305, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_230a, 5); calld(Definitions.sys_check_available_stack_size, 0xf3a43); /* call 0x10165d52 */
            ii(0x1007_230f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2310, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2311, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2312, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2313, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2315, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_231b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_231e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_2321, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1007_2324, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_2328, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_232c, 5); calld(0x1007_1e00, -0x531);             /* call 0x10071e00 */
            ii(0x1007_2331, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2333, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2336, 4); sub(memw_a32[ds, eax + 0x2], dx);       /* sub [eax+0x2], dx */
            ii(0x1007_233a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_233e, 5); calld(0x1007_1ec5, -0x47e);             /* call 0x10071ec5 */
            ii(0x1007_2343, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2345, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2348, 4); sub(memw_a32[ds, eax + 0x4], dx);       /* sub [eax+0x4], dx */
            ii(0x1007_234c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2350, 5); calld(0x1007_1f2e, -0x427);             /* call 0x10071f2e */
            ii(0x1007_2355, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2357, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_235a, 4); sub(memw_a32[ds, eax + 0x6], dx);       /* sub [eax+0x6], dx */
            ii(0x1007_235e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2362, 5); calld(0x1007_1ff5, -0x372);             /* call 0x10071ff5 */
            ii(0x1007_2367, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2369, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_236c, 4); sub(memw_a32[ds, eax + 0x8], dx);       /* sub [eax+0x8], dx */
            ii(0x1007_2370, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2374, 5); calld(0x1007_2073, -0x306);             /* call 0x10072073 */
            ii(0x1007_2379, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_237b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_237e, 3); sub(memw_a32[ds, eax], dx);             /* sub [eax], dx */
            ii(0x1007_2381, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_2383, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_2384, 1); popd(edi);                              /* pop edi */
            ii(0x1007_2385, 1); popd(esi);                              /* pop esi */
            ii(0x1007_2386, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2387, 1); retd(); return;                         /* ret */
        }
    }
}
