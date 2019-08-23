using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_02f8-181b14d7")]
        public void Method_1009_02f8()
        {
            ii(0x1009_02f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_02fd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_5a50); /* call 0x10165d52 */
            ii(0x1009_0302, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_0303, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0304, 1); pushd(edx);                             /* push edx */
            ii(0x1009_0305, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0306, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0307, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0308, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_030a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_0310, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_0313, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_0316, 7); mov(memd_a32[ds, eax + 0x23], 0x101b_466c); /* mov dword [eax+0x23], 0x101b466c */
            ii(0x1009_031d, 3); mov(al, memb_a32[ss, ebp + 0x2c]);      /* mov al, [ebp+0x2c] */
            ii(0x1009_0320, 3); mov(edi, memd_a32[ss, ebp - 0x4]);      /* mov edi, [ebp-0x4] */
            ii(0x1009_0323, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1009_0325, 3); mov(edi, memd_a32[ss, ebp - 0x4]);      /* mov edi, [ebp-0x4] */
            ii(0x1009_0328, 3); lea(edi, edi + 0x11);                   /* lea edi, [edi+0x11] */
            ii(0x1009_032b, 3); lea(esi, ebp + 0x1c);                   /* lea esi, [ebp+0x1c] */
            ii(0x1009_032e, 1); movsd_a32();                            /* movsd */
            ii(0x1009_032f, 1); movsd_a32();                            /* movsd */
            ii(0x1009_0330, 1); movsd_a32();                            /* movsd */
            ii(0x1009_0331, 1); movsd_a32();                            /* movsd */
            ii(0x1009_0332, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_0335, 6); mov(memw_a32[ds, eax + 0x21], 0);       /* mov word [eax+0x21], 0x0 */
            ii(0x1009_033b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_033e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0341, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0344, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0346, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0347, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0348, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0349, 1); popd(edx);                              /* pop edx */
            ii(0x1009_034a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_034b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_034c, 3); retd(0x14);                             /* ret 0x14 */
        }
    }
}
