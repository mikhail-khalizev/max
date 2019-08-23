using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9ffc-e0e05299")]
        public void Method_1008_9ffc()
        {
            ii(0x1008_9ffc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a001, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bd4c); /* call 0x10165d52 */
            ii(0x1008_a006, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a007, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a008, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a009, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a00a, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a00b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a00c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a00e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a014, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a017, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a01a, 4); mov(ax, memw_a32[ds, eax + 0x23]);      /* mov ax, [eax+0x23] */
            ii(0x1008_a01e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a021, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a024, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a026, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a027, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a028, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a029, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a02a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a02b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a02c, 1); retd();                                 /* ret */
        }
    }
}
