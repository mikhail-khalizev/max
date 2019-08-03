using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e404258a-cd2e-45de-a4a7-7fb2497b1477")]
        public void Method_1010_6a9c()
        {
            ii(0x1010_6a9c, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1010_6aa1, 5); calld(Definitions.sys_check_available_stack_size, 0x5f2ac); /* call 0x10165d52 */
            ii(0x1010_6aa6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6aa7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6aa8, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6aa9, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6aaa, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6aab, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6aac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6aae, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1010_6ab4, 5); calld(0x1010_6c65, 0x1ac);              /* call 0x10106c65 */
            ii(0x1010_6ab9, 5); calld(0x1010_6cb8, 0x1fa);              /* call 0x10106cb8 */
            ii(0x1010_6abe, 5); calld(0x1010_6db2, 0x2ef);              /* call 0x10106db2 */
            ii(0x1010_6ac3, 5); calld(0x1010_6e86, 0x3be);              /* call 0x10106e86 */
            ii(0x1010_6ac8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6ac9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6aca, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6acb, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6acc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6acd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6ace, 1); retd(); return;                         /* ret */
        }
    }
}
