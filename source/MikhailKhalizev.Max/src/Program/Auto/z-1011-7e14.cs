using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7e14-76fcaf2f")]
        public void Method_1011_7e14()
        {
            ii(0x1011_7e14, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1011_7e19, 5); calld(Definitions.sys_check_available_stack_size, 0x4_df34); /* call 0x10165d52 */
            ii(0x1011_7e1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7e1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7e20, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7e21, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7e22, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7e23, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7e24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7e26, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_7e2c, 5); calld(/* sys */ 0x1016_be34, 0x5_4003); /* call 0x1016be34 */
            ii(0x1011_7e31, 5); mov(edx, 0xea60);                       /* mov edx, 0xea60 */
            ii(0x1011_7e36, 5); mov(eax, 0x6f0);                        /* mov eax, 0x6f0 */
            ii(0x1011_7e3b, 5); calld(0x1010_8794, -0xf6ac);            /* call 0x10108794 */
            ii(0x1011_7e40, 5); mov(edx, 0xea60);                       /* mov edx, 0xea60 */
            ii(0x1011_7e45, 5); mov(eax, 0x6f1);                        /* mov eax, 0x6f1 */
            ii(0x1011_7e4a, 5); calld(0x1010_8794, -0xf6bb);            /* call 0x10108794 */
            ii(0x1011_7e4f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7e50, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7e51, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7e52, 1); popd(edx);                              /* pop edx */
            ii(0x1011_7e53, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7e54, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7e55, 1); retd();                                 /* ret */
        }
    }
}
