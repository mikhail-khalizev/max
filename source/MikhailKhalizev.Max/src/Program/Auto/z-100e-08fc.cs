using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dbd298ce-8bf4-4da6-9ec7-7737c321b2f5")]
        public void Method_100e_08fc()
        {
            ii(0x100e_08fc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0901, 5); calld(Definitions.sys_check_available_stack_size, 0x8544c); /* call 0x10165d52 */
            ii(0x100e_0906, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0907, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0908, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0909, 1); pushd(edi);                             /* push edi */
            ii(0x100e_090a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_090b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_090d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0913, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0916, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0919, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_091c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_091f, 5); calld(0x100c_b850, -0x150d4);           /* call 0x100cb850 */
            ii(0x100e_0924, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0927, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_092a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_092c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_092d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_092e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_092f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0930, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0931, 1); retd(); return;                         /* ret */
        }
    }
}
