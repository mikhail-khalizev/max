using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4430-9877410b")]
        public void my_dtor_0x101b_63ec()
        {
            ii(0x1010_4430, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_4435, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1918); /* call 0x10165d52 */
            ii(0x1010_443a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_443b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_443c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_443d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_443e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_443f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4441, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4447, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_444a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_444d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_4452, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4455, 5); calld(0x1013_a1be, 0x3_5d64);           /* call 0x1013a1be */
            ii(0x1010_445a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_445d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4460, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_4463, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4466, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4468, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_4469, 1); popd(edi);                              /* pop edi */
            ii(0x1010_446a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_446b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_446c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_446d, 1); retd();                                 /* ret */
        }
    }
}
