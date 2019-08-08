using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f44d1d1-714e-451a-84b7-29ab6a1b25f6")]
        public void Method_1011_8113()
        {
            ii(0x1011_8113, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_8118, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dc35); /* call 0x10165d52 */
            ii(0x1011_811d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_811e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_811f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8120, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8122, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_8128, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_812b, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_812e, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_8131, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_8134, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_8137, 5); calld(0x1014_4ef4, 0x2_cdb8);           /* call 0x10144ef4 */
            ii(0x1011_813c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_813f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1011_8142, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_8145, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_8148, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_69b4); /* mov dword [eax+0x2], 0x101b69b4 */
            ii(0x1011_814f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_8152, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_8155, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x1011_8158, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_815b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_815e, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x1011_8161, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8164, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_8167, 4); mov(memw_a32[ds, edx + 0x14], ax);      /* mov [edx+0x14], ax */
            ii(0x1011_816b, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_816e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_8171, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1011_8175, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1011_8178, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_817b, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x1011_817f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_8182, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_8185, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_8188, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_818a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_818b, 1); popd(edi);                              /* pop edi */
            ii(0x1011_818c, 1); popd(esi);                              /* pop esi */
            ii(0x1011_818d, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
