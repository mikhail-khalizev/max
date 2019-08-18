using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7e00-5d242968")]
        public void Method_1014_7e00()
        {
            ii(0x1014_7e00, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_7e05, 5); calld(Definitions.sys_check_available_stack_size, 0x1_df48); /* call 0x10165d52 */
            ii(0x1014_7e0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7e0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7e0c, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7e0d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7e0e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7e0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7e10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7e12, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7e18, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7e1b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7e1e, 5); calld(0x1007_6d58, -0xd_10cb);          /* call 0x10076d58 */
            ii(0x1014_7e23, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7e26, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_7e29, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7e2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7e2f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7e32, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7e35, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7e37, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7e38, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7e39, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7e3a, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7e3b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7e3c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7e3d, 1); retd(); return;                         /* ret */
        }
    }
}
