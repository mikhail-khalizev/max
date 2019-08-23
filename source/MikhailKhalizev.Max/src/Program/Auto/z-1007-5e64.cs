using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5e64-e8e9edd3")]
        public void Method_1007_5e64()
        {
            ii(0x1007_5e64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_5e69, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fee4); /* call 0x10165d52 */
            ii(0x1007_5e6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5e6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5e70, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5e71, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5e72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5e73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5e75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5e7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5e7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_5e81, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5e84, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1007_5e87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5e8a, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1007_5e8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5e90, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x1007_5e94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5e97, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1007_5e9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5e9e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_5ea1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5ea4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5ea6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5ea7, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5ea8, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5ea9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5eaa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_5eab, 1); retd();                                 /* ret */
        }
    }
}
