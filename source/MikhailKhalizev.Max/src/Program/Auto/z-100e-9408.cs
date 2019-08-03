using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e386e2b4-d009-410a-9849-e0d94753e5a6")]
        public void Method_100e_9408()
        {
            ii(0x100e_9408, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_940d, 5); calld(Definitions.sys_check_available_stack_size, 0x7c940); /* call 0x10165d52 */
            ii(0x100e_9412, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_9413, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_9414, 1); pushd(edx);                             /* push edx */
            ii(0x100e_9415, 1); pushd(esi);                             /* push esi */
            ii(0x100e_9416, 1); pushd(edi);                             /* push edi */
            ii(0x100e_9417, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_9418, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_941a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_9420, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_9423, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9426, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x100e_942b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_942e, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x100e_9434, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9437, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x100e_943e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9441, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_9444, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9447, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9449, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_944a, 1); popd(edi);                              /* pop edi */
            ii(0x100e_944b, 1); popd(esi);                              /* pop esi */
            ii(0x100e_944c, 1); popd(edx);                              /* pop edx */
            ii(0x100e_944d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_944e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_944f, 1); retd(); return;                         /* ret */
        }
    }
}