using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad8e86c9-93c8-47dd-9fd7-3c06cd597ef1")]
        public void Method_100b_7fa4()
        {
            ii(0x100b_7fa4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7fa9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dda4); /* call 0x10165d52 */
            ii(0x100b_7fae, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7faf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7fb0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7fb1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7fb2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7fb3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7fb5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7fbb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7fbe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7fc1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7fc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7fc7, 5); calld(0x1013_ac7d, 0x8_2cb1);           /* call 0x1013ac7d */
            ii(0x100b_7fcc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7fcf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7fd2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7fd4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7fd5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7fd6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7fd7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7fd8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7fd9, 1); retd(); return;                         /* ret */
        }
    }
}
