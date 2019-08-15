using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b91ee22e-b87f-403f-889f-278129c54cb7")]
        public void Method_1008_a3dc()
        {
            ii(0x1008_a3dc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a3e1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b96c); /* call 0x10165d52 */
            ii(0x1008_a3e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a3e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a3e8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a3e9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a3ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a3eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a3ed, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a3f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a3f6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a3f9, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_a3fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a400, 5); calld(0x1008_b410, 0x100b);             /* call 0x1008b410 */
            ii(0x1008_a405, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_a408, 5); calld(0x1008_b440, 0x1033);             /* call 0x1008b440 */
            ii(0x1008_a40d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a410, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_a413, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a415, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a416, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a417, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a418, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a419, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a41a, 1); retd(); return;                         /* ret */
        }
    }
}
