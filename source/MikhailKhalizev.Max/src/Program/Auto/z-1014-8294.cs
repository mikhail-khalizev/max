using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9cfdb135-d410-45d1-8d85-8f1df89fcb55")]
        public void Method_1014_8294()
        {
            ii(0x1014_8294, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_8299, 5); calld(Definitions.sys_check_available_stack_size, 0x1dab4); /* call 0x10165d52 */
            ii(0x1014_829e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_829f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_82a0, 1); pushd(edx);                             /* push edx */
            ii(0x1014_82a1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_82a2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_82a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_82a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_82a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_82ac, 5); calld(/* sys */ 0x1018_0fda, 0x38d29);  /* call 0x10180fda */
            ii(0x1014_82b1, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_82b6, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1014_82bb, 5); calld(/* sys */ 0x1018_0fc8, 0x38d08);  /* call 0x10180fc8 */
            ii(0x1014_82c0, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_82c5, 5); calld(/* sys */ 0x1018_0fd2, 0x38d08);  /* call 0x10180fd2 */
            ii(0x1014_82ca, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_82cd, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_82d2, 5); calld(/* sys */ 0x1018_0fd2, 0x38cfb);  /* call 0x10180fd2 */
            ii(0x1014_82d7, 3); shl(eax, 0x8);                          /* shl eax, 0x8 */
            ii(0x1014_82da, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
            ii(0x1014_82dd, 5); calld(/* sys */ 0x1018_0fdc, 0x38cfa);  /* call 0x10180fdc */
            ii(0x1014_82e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_82e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_82e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_82eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_82ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_82ee, 1); popd(edi);                              /* pop edi */
            ii(0x1014_82ef, 1); popd(esi);                              /* pop esi */
            ii(0x1014_82f0, 1); popd(edx);                              /* pop edx */
            ii(0x1014_82f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_82f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_82f3, 1); retd(); return;                         /* ret */
        }
    }
}
