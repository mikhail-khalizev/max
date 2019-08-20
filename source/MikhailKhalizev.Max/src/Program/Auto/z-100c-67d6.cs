using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_67d6-a741f872")]
        public void Method_100c_67d6()
        {
            ii(0x100c_67d6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_67db, 1); pushd(eax);                             /* push eax */
            ii(0x100c_67dc, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_67df, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_67e2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_67e5, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_67e8, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_67eb, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_67f0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_67f3, 5); calld(0x100c_6542, -0x2b6);             /* call 0x100c6542 */
            ii(0x100c_67f8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_67fd, 1); pushd(eax);                             /* push eax */
            ii(0x100c_67fe, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6801, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6804, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
        }
    }
}
