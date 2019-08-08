using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("38340071-7c1b-4e9b-8802-0e0351637d2b")]
        public void Method_100c_e39d()
        {
            ii(0x100c_e39d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_e3a2, 5); calld(Definitions.sys_check_available_stack_size, 0x9_79ab); /* call 0x10165d52 */
            ii(0x100c_e3a7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e3a8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e3a9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e3aa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e3ac, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_e3b2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_e3b5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_e3b8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_e3bb, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100c_e3be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_e3c1, 5); calld(0x100c_e2fc, -0xca);              /* call 0x100ce2fc */
            ii(0x100c_e3c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e3c9, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e3cc, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100c_e3d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e3d3, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e3d6, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100c_e3da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e3dd, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e3e0, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x100c_e3e4, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100c_e3e7, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e3ea, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x100c_e3ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_e3f1, 4); mov(memb_a32[ds, eax + 0x28], 0x1);     /* mov byte [eax+0x28], 0x1 */
            ii(0x100c_e3f5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_e3f8, 6); mov(memw_a32[ds, eax + 0x35], 0xffff);  /* mov word [eax+0x35], 0xffff */
            ii(0x100c_e3fe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_e401, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_e404, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_e407, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e409, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e40a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e40b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e40c, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
