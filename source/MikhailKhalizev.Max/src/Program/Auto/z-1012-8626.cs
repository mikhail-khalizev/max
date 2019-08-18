using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8626-5d90a999")]
        public void Method_1012_8626()
        {
            ii(0x1012_8626, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_862b, 5); calld(Definitions.sys_check_available_stack_size, 0x3_d722); /* call 0x10165d52 */
            ii(0x1012_8630, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8631, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8632, 1); pushd(edx);                             /* push edx */
            ii(0x1012_8633, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8634, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8635, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8636, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8638, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_863e, 5); calld(0x1012_75ed, -0x1056);            /* call 0x101275ed */
            ii(0x1012_8643, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8645, 5); mov(al, memb_a32[ds, 0x101c_609e]);     /* mov al, [0x101c609e] */
            ii(0x1012_864a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_864d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8650, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8652, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8653, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8654, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8655, 1); popd(edx);                              /* pop edx */
            ii(0x1012_8656, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8657, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8658, 1); retd(); return;                         /* ret */
        }
    }
}
