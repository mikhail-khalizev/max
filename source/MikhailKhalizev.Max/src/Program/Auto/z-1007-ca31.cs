using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5b728ed-78b7-4a3e-83b6-1b346827b19f")]
        public void Method_1007_ca31()
        {
            ii(0x1007_ca31, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_ca36, 5); calld(Definitions.sys_check_available_stack_size, 0xe_9317); /* call 0x10165d52 */
            ii(0x1007_ca3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ca3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ca3d, 1); pushd(edx);                             /* push edx */
            ii(0x1007_ca3e, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ca3f, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ca40, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ca41, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ca43, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_ca49, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_ca4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ca4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ca51, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ca54, 5); calld(0x1007_643c, -0x661d);            /* call 0x1007643c */
            ii(0x1007_ca59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ca5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ca5e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_ca61, 5); calld(0x1008_afe4, 0xe57e);             /* call 0x1008afe4 */
            ii(0x1007_ca66, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_ca69, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_ca6e, 5); calld(0x100a_5e27, 0x2_93b4);           /* call 0x100a5e27 */
            ii(0x1007_ca73, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ca75, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_ca76, 1); popd(edi);                              /* pop edi */
            ii(0x1007_ca77, 1); popd(esi);                              /* pop esi */
            ii(0x1007_ca78, 1); popd(edx);                              /* pop edx */
            ii(0x1007_ca79, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ca7a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ca7b, 1); retd(); return;                         /* ret */
        }
    }
}
