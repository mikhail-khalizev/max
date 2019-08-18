using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76c587ff-481c-45ac-a665-5e1e43a3d5c3")]
        public void Method_100b_45ef()
        {
            ii(0x100b_45ef, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_45f4, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1759); /* call 0x10165d52 */
            ii(0x100b_45f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_45fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_45fb, 1); pushd(edx);                             /* push edx */
            ii(0x100b_45fc, 1); pushd(esi);                             /* push esi */
            ii(0x100b_45fd, 1); pushd(edi);                             /* push edi */
            ii(0x100b_45fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_45ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4601, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_4607, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_460a, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_4611, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4614, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4616, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_4617, 1); popd(edi);                              /* pop edi */
            ii(0x100b_4618, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4619, 1); popd(edx);                              /* pop edx */
            ii(0x100b_461a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_461b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_461c, 1); retd(); return;                         /* ret */
        }
    }
}
