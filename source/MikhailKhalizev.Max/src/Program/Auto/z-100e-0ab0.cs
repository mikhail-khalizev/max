using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0ab0-683312b5")]
        public void Method_100e_0ab0()
        {
            ii(0x100e_0ab0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0ab5, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5298); /* call 0x10165d52 */
            ii(0x100e_0aba, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0abb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0abc, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0abd, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0abe, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0abf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0ac0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0ac2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_0ac8, 7); mov(memd_a32[ss, ebp - 0x4], 0x101c_3602); /* mov dword [ebp-0x4], 0x101c3602 */
            ii(0x100e_0acf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0ad2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0ad4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0ad5, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0ad6, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0ad7, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0ad8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0ad9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0ada, 1); retd();                                 /* ret */
        }
    }
}
