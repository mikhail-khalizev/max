using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("843c7157-d975-4129-8503-af9a61bce7b4")]
        public void Method_100e_4304()
        {
            ii(0x100e_4304, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_4309, 5); calld(Definitions.sys_check_available_stack_size, 0x8_1a44); /* call 0x10165d52 */
            ii(0x100e_430e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_430f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_4310, 1); pushd(edx);                             /* push edx */
            ii(0x100e_4311, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4312, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4313, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4314, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4316, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_431c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_431f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_4322, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100e_4326, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_4329, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x100e_432d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_4330, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_4333, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4335, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4336, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4337, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4338, 1); popd(edx);                              /* pop edx */
            ii(0x100e_4339, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_433a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_433b, 1); retd(); return;                         /* ret */
        }
    }
}