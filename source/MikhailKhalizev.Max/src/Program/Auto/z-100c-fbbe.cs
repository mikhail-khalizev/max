using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fbbe-c74703d")]
        public void Method_100c_fbbe()
        {
            ii(0x100c_fbbe, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_fbc3, 5); calld(Definitions.sys_check_available_stack_size, 0x9_618a); /* call 0x10165d52 */
            ii(0x100c_fbc8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_fbc9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_fbca, 1); pushd(edx);                             /* push edx */
            ii(0x100c_fbcb, 1); pushd(esi);                             /* push esi */
            ii(0x100c_fbcc, 1); pushd(edi);                             /* push edi */
            ii(0x100c_fbcd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_fbce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fbd0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_fbd6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_fbd9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_fbdc, 3); mov(edx, memd_a32[ds, eax + 0x33]);     /* mov edx, [eax+0x33] */
            ii(0x100c_fbdf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_fbe2, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100c_fbe7, 5); calld(0x1013_dc59, 0x6_e06d);           /* call 0x1013dc59 */
            ii(0x100c_fbec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fbee, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_fbef, 1); popd(edi);                              /* pop edi */
            ii(0x100c_fbf0, 1); popd(esi);                              /* pop esi */
            ii(0x100c_fbf1, 1); popd(edx);                              /* pop edx */
            ii(0x100c_fbf2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_fbf3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_fbf4, 1); retd(); return;                         /* ret */
        }
    }
}
