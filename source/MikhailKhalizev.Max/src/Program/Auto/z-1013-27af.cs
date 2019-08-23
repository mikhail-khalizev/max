using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_27af-5b656d29")]
        public void Method_1013_27af()
        {
            ii(0x1013_27af, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_27b4, 5); calld(Definitions.sys_check_available_stack_size, 0x3_3599); /* call 0x10165d52 */
            ii(0x1013_27b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_27ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_27bb, 1); pushd(esi);                             /* push esi */
            ii(0x1013_27bc, 1); pushd(edi);                             /* push edi */
            ii(0x1013_27bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_27be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_27c0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_27c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_27c9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_27cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_27cf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_27d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_27d5, 4); mov(ax, memw_a32[ds, eax + 0x5]);       /* mov ax, [eax+0x5] */
            ii(0x1013_27d9, 1); inc(eax);                               /* inc eax */
            ii(0x1013_27da, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_27dd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_27e0, 5); calld(0x1013_2705, -0xe0);              /* call 0x10132705 */
            ii(0x1013_27e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_27e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_27e8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_27e9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_27ea, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_27eb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_27ec, 1); retd();                                 /* ret */
        }
    }
}
