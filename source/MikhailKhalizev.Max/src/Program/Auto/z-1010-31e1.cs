using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_31e1-58d581ae")]
        public void Method_1010_31e1()
        {
            ii(0x1010_31e1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_31e6, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2b67); /* call 0x10165d52 */
            ii(0x1010_31eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_31ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_31ed, 1); pushd(esi);                             /* push esi */
            ii(0x1010_31ee, 1); pushd(edi);                             /* push edi */
            ii(0x1010_31ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_31f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_31f2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_31f8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_31fb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_31fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3201, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1010_3204, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_3207, 5); mov(edx, StringDefinitions.X4);         /* mov edx, 0x101a315a */
            ii(0x1010_320c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_320f, 5); calld(0x1014_74f5, 0x4_42e1);           /* call 0x101474f5 */
            ii(0x1010_3214, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3217, 3); mov(ebx, memd_a32[ds, eax + 0x10]);     /* mov ebx, [eax+0x10] */
            ii(0x1010_321a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_321d, 5); mov(edx, StringDefinitions.Y2);         /* mov edx, 0x101a315c */
            ii(0x1010_3222, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3225, 5); calld(0x1014_74f5, 0x4_42cb);           /* call 0x101474f5 */
            ii(0x1010_322a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_322d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3230, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_3233, 5); calld(0x1010_2ff9, -0x23f);             /* call 0x10102ff9 */
            ii(0x1010_3238, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_323a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_323b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_323c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_323d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_323e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_323f, 1); retd();                                 /* ret */
        }
    }
}
