using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c7328e48-efe5-432d-a727-ca8a8e569ff8")]
        public void Method_1010_45d4()
        {
            ii(0x1010_45d4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_45d9, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1774); /* call 0x10165d52 */
            ii(0x1010_45de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_45df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_45e0, 1); pushd(edx);                             /* push edx */
            ii(0x1010_45e1, 1); pushd(esi);                             /* push esi */
            ii(0x1010_45e2, 1); pushd(edi);                             /* push edi */
            ii(0x1010_45e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_45e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_45e6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_45ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_45ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_45f2, 5); calld(0x1007_6d58, -0x8_d89f);          /* call 0x10076d58 */
            ii(0x1010_45f7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_45fa, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1010_45fd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_4600, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4603, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_4606, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4609, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_460b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_460c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_460d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_460e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_460f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4610, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4611, 1); retd(); return;                         /* ret */
        }
    }
}
