using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2fa088cd-41d6-4320-a7ba-f756a4da4eac")]
        public void Method_1011_ba3d()
        {
            ii(0x1011_ba3d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_ba42, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a30b); /* call 0x10165d52 */
            ii(0x1011_ba47, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_ba48, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_ba49, 1); pushd(edx);                             /* push edx */
            ii(0x1011_ba4a, 1); pushd(esi);                             /* push esi */
            ii(0x1011_ba4b, 1); pushd(edi);                             /* push edi */
            ii(0x1011_ba4c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_ba4d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ba4f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_ba55, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_ba58, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_ba5a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ba5c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba5f, 5); calld(0x1011_80b5, -0x39af);            /* call 0x101180b5 */
            ii(0x1011_ba64, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_ba67, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_ba6a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_ba6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba70, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_68dc); /* mov dword [eax+0x2], 0x101b68dc */
            ii(0x1011_ba77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba7a, 6); mov(memw_a32[ds, eax + 0x16], 0x1);     /* mov word [eax+0x16], 0x1 */
            ii(0x1011_ba80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba83, 6); mov(memw_a32[ds, eax + 0x18], 0x1);     /* mov word [eax+0x18], 0x1 */
            ii(0x1011_ba89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ba8c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_ba8f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_ba92, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ba94, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ba95, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ba96, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ba97, 1); popd(edx);                              /* pop edx */
            ii(0x1011_ba98, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_ba99, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_ba9a, 1); retd(); return;                         /* ret */
        }
    }
}
