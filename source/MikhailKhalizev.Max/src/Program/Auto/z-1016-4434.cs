using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df93def0-23df-437d-929a-5aa0aa63e5e0")]
        public void Method_1016_4434()
        {
            ii(0x1016_4434, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4439, 5); calld(Definitions.sys_check_available_stack_size, 0x1914); /* call 0x10165d52 */
            ii(0x1016_443e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_443f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4440, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4441, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4442, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4443, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4445, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_444b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_444e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_4451, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1016_4456, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1016_445b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_445e, 5); calld(Definitions.sys_call_dtor_arr_v2, 0x1b7d); /* call 0x10165fe0 */
            ii(0x1016_4463, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4466, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4469, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_446b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_446c, 1); popd(edi);                              /* pop edi */
            ii(0x1016_446d, 1); popd(esi);                              /* pop esi */
            ii(0x1016_446e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_446f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4470, 1); retd(); return;                         /* ret */
        }
    }
}