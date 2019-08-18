using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bc25-7129f55")]
        public void Method_1011_bc25()
        {
            ii(0x1011_bc25, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_bc2a, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a123); /* call 0x10165d52 */
            ii(0x1011_bc2f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_bc30, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_bc31, 1); pushd(edx);                             /* push edx */
            ii(0x1011_bc32, 1); pushd(esi);                             /* push esi */
            ii(0x1011_bc33, 1); pushd(edi);                             /* push edi */
            ii(0x1011_bc34, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_bc35, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bc37, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_bc3d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_bc40, 5); mov(eax, 0x101c_532e);                  /* mov eax, 0x101c532e */
            ii(0x1011_bc45, 5); calld(0x1012_0d64, 0x511a);             /* call 0x10120d64 */
            ii(0x1011_bc4a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_bc4d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_bc50, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bc52, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_bc53, 1); popd(edi);                              /* pop edi */
            ii(0x1011_bc54, 1); popd(esi);                              /* pop esi */
            ii(0x1011_bc55, 1); popd(edx);                              /* pop edx */
            ii(0x1011_bc56, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_bc57, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_bc58, 1); retd(); return;                         /* ret */
        }
    }
}
