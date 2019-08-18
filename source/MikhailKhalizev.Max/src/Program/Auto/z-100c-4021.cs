using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a713e576-d6ef-4400-9116-c17c1216ac89")]
        public void Method_100c_4021()
        {
            ii(0x100c_4021, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100c_4025, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_4028, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100c_402a, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x100c_402c, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x100c_402f, 5); calld(0x100c_aafc, 0x6ac8);             /* call 0x100caafc */
            ii(0x100c_4034, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_4037, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_403a, 5); calld(0x1013_602e, 0x7_1fef);           /* call 0x1013602e */
            ii(0x100c_403f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_4042, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_4045, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_4048, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_404a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_404b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_404c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_404d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_404e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_404f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_4050, 1); retd(); return;                         /* ret */
        }
    }
}
