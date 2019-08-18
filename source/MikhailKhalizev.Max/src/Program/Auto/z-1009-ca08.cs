using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ca08-2b931f1c")]
        public void Method_1009_ca08()
        {
            ii(0x1009_ca08, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ca0d, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9340); /* call 0x10165d52 */
            ii(0x1009_ca12, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ca13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ca14, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ca15, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ca16, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ca17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ca19, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ca1f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ca22, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ca25, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_ca28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ca2b, 5); calld(0x1013_a66b, 0x9_dc3b);           /* call 0x1013a66b */
            ii(0x1009_ca30, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1009_ca33, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_ca36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ca38, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ca39, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ca3a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ca3b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ca3c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ca3d, 1); retd(); return;                         /* ret */
        }
    }
}
