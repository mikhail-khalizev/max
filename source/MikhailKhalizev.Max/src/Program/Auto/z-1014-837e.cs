using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d0116b1-665a-4d43-9720-fba80a76c9c1")]
        public void Method_1014_837e()
        {
            ii(0x1014_837e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_8383, 5); calld(Definitions.sys_check_available_stack_size, 0x1d9ca); /* call 0x10165d52 */
            ii(0x1014_8388, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8389, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_838a, 1); pushd(edx);                             /* push edx */
            ii(0x1014_838b, 1); pushd(esi);                             /* push esi */
            ii(0x1014_838c, 1); pushd(edi);                             /* push edi */
            ii(0x1014_838d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_838e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8390, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_8396, 5); mov(eax, 0x61);                         /* mov eax, 0x61 */
            ii(0x1014_839b, 5); calld(/* sys */ 0x1018_0fd2, 0x38c32);  /* call 0x10180fd2 */
            ii(0x1014_83a0, 5); and(eax, 0xfc);                         /* and eax, 0xfc */
            ii(0x1014_83a5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_83a8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_83ab, 5); mov(eax, 0x61);                         /* mov eax, 0x61 */
            ii(0x1014_83b0, 5); calld(/* sys */ 0x1018_0fc8, 0x38c13);  /* call 0x10180fc8 */
            ii(0x1014_83b5, 5); calld(/* sys */ 0x1018_0fda, 0x38c20);  /* call 0x10180fda */
            ii(0x1014_83ba, 5); mov(edx, 0xb4);                         /* mov edx, 0xb4 */
            ii(0x1014_83bf, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1014_83c4, 5); calld(/* sys */ 0x1018_0fc8, 0x38bff);  /* call 0x10180fc8 */
            ii(0x1014_83c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_83cb, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_83d0, 5); calld(/* sys */ 0x1018_0fc8, 0x38bf3);  /* call 0x10180fc8 */
            ii(0x1014_83d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_83d7, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_83dc, 5); calld(/* sys */ 0x1018_0fc8, 0x38be7);  /* call 0x10180fc8 */
            ii(0x1014_83e1, 5); calld(/* sys */ 0x1018_0fdc, 0x38bf6);  /* call 0x10180fdc */
            ii(0x1014_83e6, 5); mov(eax, 0x61);                         /* mov eax, 0x61 */
            ii(0x1014_83eb, 5); calld(/* sys */ 0x1018_0fd2, 0x38be2);  /* call 0x10180fd2 */
            ii(0x1014_83f0, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1014_83f2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_83f5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_83f8, 5); mov(eax, 0x61);                         /* mov eax, 0x61 */
            ii(0x1014_83fd, 5); calld(/* sys */ 0x1018_0fc8, 0x38bc6);  /* call 0x10180fc8 */
            ii(0x1014_8402, 5); calld(0x1014_8294, -0x173);             /* call 0x10148294 */
            ii(0x1014_8407, 5); mov(memd_a32[ds, 0x101c_8130], eax);    /* mov [0x101c8130], eax */
            ii(0x1014_840c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_840e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_840f, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8410, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8411, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8412, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8413, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8414, 1); retd(); return;                         /* ret */
        }
    }
}
