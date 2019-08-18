using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7446-a59c85e3")]
        public void Method_1014_7446()
        {
            ii(0x1014_7446, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_744b, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e902); /* call 0x10165d52 */
            ii(0x1014_7450, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7451, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7452, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7453, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7454, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7455, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7456, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7458, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_745e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7461, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7464, 5); sub(memw_a32[ds, eax + 0xe], 0x2);      /* sub word [eax+0xe], 0x2 */
            ii(0x1014_7469, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_746c, 5); calld(0x1014_7395, -0xdc);              /* call 0x10147395 */
            ii(0x1014_7471, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7474, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7476, 5); mov(eax, StringDefinitions.Control37);  /* mov eax, 0x101ad11e */
            ii(0x1014_747b, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9acd); /* call 0x10180f4d */
            ii(0x1014_7480, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7482, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7483, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7484, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7485, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7486, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7487, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7488, 1); retd(); return;                         /* ret */
        }
    }
}
