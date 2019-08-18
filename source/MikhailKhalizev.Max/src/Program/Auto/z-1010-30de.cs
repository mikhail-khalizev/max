using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d32be203-2094-4d69-87f2-169991071fb1")]
        public void Method_1010_30de()
        {
            ii(0x1010_30de, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_30e3, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2c6a); /* call 0x10165d52 */
            ii(0x1010_30e8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_30e9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_30ea, 1); pushd(esi);                             /* push esi */
            ii(0x1010_30eb, 1); pushd(edi);                             /* push edi */
            ii(0x1010_30ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_30ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_30ef, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_30f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_30f8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_30fb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_30fe, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1010_3101, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3104, 5); calld(0x1013_bb7b, 0x3_8a72);           /* call 0x1013bb7b */
            ii(0x1010_3109, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_310c, 3); add(edx, 0x12);                         /* add edx, 0x12 */
            ii(0x1010_310f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3112, 5); calld(0x1013_bb7b, 0x3_8a64);           /* call 0x1013bb7b */
            ii(0x1010_3117, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_311a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_311d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_3120, 5); calld(0x1010_2cbf, -0x466);             /* call 0x10102cbf */
            ii(0x1010_3125, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3127, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3128, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3129, 1); popd(esi);                              /* pop esi */
            ii(0x1010_312a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_312b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_312c, 1); retd(); return;                         /* ret */
        }
    }
}
