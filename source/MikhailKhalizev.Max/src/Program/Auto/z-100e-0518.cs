using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b7d7684-61b5-41b0-87a3-4b73fb61849a")]
        public void Method_100e_0518()
        {
            ii(0x100e_0518, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_051d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5830); /* call 0x10165d52 */
            ii(0x100e_0522, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0523, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0524, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0525, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0526, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0527, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0528, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_052a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0530, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0533, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0536, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_0538, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_053b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_053e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0540, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0541, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0542, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0543, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0544, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0545, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0546, 1); retd(); return;                         /* ret */
        }
    }
}
