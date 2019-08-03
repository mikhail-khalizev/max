using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("003730a1-8fcb-4d87-9aff-9fd89abf8f0c")]
        public void Method_100e_0970()
        {
            ii(0x100e_0970, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_0975, 5); calld(Definitions.sys_check_available_stack_size, 0x853d8); /* call 0x10165d52 */
            ii(0x100e_097a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_097b, 1); pushd(esi);                             /* push esi */
            ii(0x100e_097c, 1); pushd(edi);                             /* push edi */
            ii(0x100e_097d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_097e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0980, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_0986, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0989, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_098c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100e_098f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_0991, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100e_0994, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_0997, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_099a, 5); calld(0x1013_afb8, 0x5a619);            /* call 0x1013afb8 */
            ii(0x100e_099f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_09a2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_09a5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_09a8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_09ab, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_09ae, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_09b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_09b3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_09b4, 1); popd(edi);                              /* pop edi */
            ii(0x100e_09b5, 1); popd(esi);                              /* pop esi */
            ii(0x100e_09b6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_09b7, 1); retd(); return;                         /* ret */
        }
    }
}