using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4dd5-78cac562")]
        public void Method_1012_4dd5()
        {
            ii(0x1012_4dd5, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1012_4dda, 5); calld(Definitions.sys_check_available_stack_size, 0x4_0f73); /* call 0x10165d52 */
            ii(0x1012_4ddf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4de0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4de1, 1); pushd(edx);                             /* push edx */
            ii(0x1012_4de2, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4de3, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4de4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4de5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4de7, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1012_4ded, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1012_4df0, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1012_4df5, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
            ii(0x1012_4df8, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1012_4dfc, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_4e01, 5); calld(0x1010_6281, -0x1_eb85);          /* call 0x10106281 */
            ii(0x1012_4e06, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1012_4e09, 5); calld(0x1012_4d8a, -0x84);              /* call 0x10124d8a */
            ii(0x1012_4e0e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4e10, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4e11, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4e12, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4e13, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4e14, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4e15, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4e16, 1); retd(); return;                         /* ret */
        }
    }
}
