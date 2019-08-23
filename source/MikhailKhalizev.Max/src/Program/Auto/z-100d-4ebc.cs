using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4ebc-94db86cb")]
        public void Method_100d_4ebc()
        {
            ii(0x100d_4ebc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4ec1, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0e8c); /* call 0x10165d52 */
            ii(0x100d_4ec6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4ec7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4ec8, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4ec9, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4eca, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4ecb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4ecc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4ece, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4ed4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4ed7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4eda, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x100d_4ede, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4ee1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4ee4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4ee6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4ee7, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4ee8, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4ee9, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4eea, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4eeb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4eec, 1); retd();                                 /* ret */
        }
    }
}
