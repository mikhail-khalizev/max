using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e2fc-d1d2d861")]
        public void Method_100c_e2fc()
        {
            ii(0x100c_e2fc, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_e301, 5); calld(Definitions.sys_check_available_stack_size, 0x9_7a4c); /* call 0x10165d52 */
            ii(0x100c_e306, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_e307, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_e308, 1); pushd(edx);                             /* push edx */
            ii(0x100c_e309, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e30a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e30b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e30c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e30e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_e314, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_e317, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e31a, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x100c_e320, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e323, 7); mov(memd_a32[ds, eax + 0xc], 0);        /* mov dword [eax+0xc], 0x0 */
            ii(0x100c_e32a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e32d, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
            ii(0x100c_e334, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e337, 7); mov(memd_a32[ds, eax + 0x14], 0);       /* mov dword [eax+0x14], 0x0 */
            ii(0x100c_e33e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e341, 7); mov(memd_a32[ds, eax + 0x18], 0);       /* mov dword [eax+0x18], 0x0 */
            ii(0x100c_e348, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e34b, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff_ffff); /* mov dword [eax+0x1c], 0xffffffff */
            ii(0x100c_e352, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e355, 7); mov(memd_a32[ds, eax + 0x20], 0xffff_ffff); /* mov dword [eax+0x20], 0xffffffff */
            ii(0x100c_e35c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e35f, 7); mov(memd_a32[ds, eax + 0x24], 0);       /* mov dword [eax+0x24], 0x0 */
            ii(0x100c_e366, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e369, 7); mov(memd_a32[ds, eax + 0x29], 0);       /* mov dword [eax+0x29], 0x0 */
            ii(0x100c_e370, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e373, 7); mov(memd_a32[ds, eax + 0x2d], 0);       /* mov dword [eax+0x2d], 0x0 */
            ii(0x100c_e37a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e37d, 7); mov(memd_a32[ds, eax + 0x31], 0);       /* mov dword [eax+0x31], 0x0 */
            ii(0x100c_e384, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e387, 6); mov(memw_a32[ds, eax + 0x35], 0xffff);  /* mov word [eax+0x35], 0xffff */
            ii(0x100c_e38d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e390, 4); mov(memb_a32[ds, eax + 0x37], 0);       /* mov byte [eax+0x37], 0x0 */
            ii(0x100c_e394, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e396, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e397, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e398, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e399, 1); popd(edx);                              /* pop edx */
            ii(0x100c_e39a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_e39b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_e39c, 1); retd(); return;                         /* ret */
        }
    }
}
