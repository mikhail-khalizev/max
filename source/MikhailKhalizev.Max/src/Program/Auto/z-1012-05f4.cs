using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5efa5b81-c74c-4d7d-a18c-5ed108e4f193")]
        public void Method_1012_05f4()
        {
            ii(0x1012_05f4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_05f9, 5); calld(Definitions.sys_check_available_stack_size, 0x45754); /* call 0x10165d52 */
            ii(0x1012_05fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_05ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0600, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0601, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0602, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0603, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0605, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_060b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_060e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0611, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1012_0616, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_061a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_061d, 5); calld(0x100c_d7e8, -0x52e3a);           /* call 0x100cd7e8 */
            ii(0x1012_0622, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0625, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_0628, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_062b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_062e, 7); mov(memd_a32[ds, eax + 0xc], 0x101b_69fc); /* mov dword [eax+0xc], 0x101b69fc */
            ii(0x1012_0635, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0638, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_063b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_063e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0640, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0641, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0642, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0643, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0644, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0645, 1); retd(); return;                         /* ret */
        }
    }
}
