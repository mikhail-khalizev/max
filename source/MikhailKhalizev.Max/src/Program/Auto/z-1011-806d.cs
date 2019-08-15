using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e343403-e096-4982-abc0-dd90b7a10898")]
        public void Method_1011_806d()
        {
            ii(0x1011_806d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_8072, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dcdb); /* call 0x10165d52 */
            ii(0x1011_8077, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_8078, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_8079, 1); pushd(edx);                             /* push edx */
            ii(0x1011_807a, 1); pushd(esi);                             /* push esi */
            ii(0x1011_807b, 1); pushd(edi);                             /* push edi */
            ii(0x1011_807c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_807d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_807f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_8085, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_8088, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_808b, 5); calld(0x1014_4ef4, 0x2_ce64);           /* call 0x10144ef4 */
            ii(0x1011_8090, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_8093, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_8096, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_8099, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_809c, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_69b4); /* mov dword [eax+0x2], 0x101b69b4 */
            ii(0x1011_80a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_80a6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_80a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_80ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_80ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_80af, 1); popd(edi);                              /* pop edi */
            ii(0x1011_80b0, 1); popd(esi);                              /* pop esi */
            ii(0x1011_80b1, 1); popd(edx);                              /* pop edx */
            ii(0x1011_80b2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_80b3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_80b4, 1); retd(); return;                         /* ret */
        }
    }
}
