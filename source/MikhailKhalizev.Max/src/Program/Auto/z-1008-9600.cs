using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("051e33b9-cbbb-4f2f-b29f-c58e87d7cf8d")]
        public void Method_1008_9600()
        {
            ii(0x1008_9600, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9605, 5); calld(Definitions.sys_check_available_stack_size, 0xdc748); /* call 0x10165d52 */
            ii(0x1008_960a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_960b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_960c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_960d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_960e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_960f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9611, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9617, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_961a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_961d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_9622, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9625, 5); calld(Definitions.my_dtor_0x101b6edc, 0xb161b); /* call 0x1013ac45 */
            ii(0x1008_962a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_962d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9630, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9633, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9636, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9638, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9639, 1); popd(edi);                              /* pop edi */
            ii(0x1008_963a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_963b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_963c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_963d, 1); retd(); return;                         /* ret */
        }
    }
}
