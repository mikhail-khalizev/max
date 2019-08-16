using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c563493-89f3-45a9-80dc-1382406ec5a0")]
        public void Method_100a_ba72()
        {
            ii(0x100a_ba72, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_ba77, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a2d6); /* call 0x10165d52 */
            ii(0x100a_ba7c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ba7d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ba7e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ba7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ba81, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_ba87, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_ba8a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_ba8d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_ba90, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_ba93, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ba96, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_ba99, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_ba9c, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_ba9f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_baa2, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100a_baa5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_baa8, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_baab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_baae, 5); calld(0x1008_ad90, -0x2_0d23);          /* call 0x1008ad90 */
            ii(0x100a_bab3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_bab6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bab9, 5); calld(0x100a_26d1, -0x93ed);            /* call 0x100a26d1 */
            ii(0x100a_babe, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_bac1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_bac4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_bac7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_baca, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bacd, 5); calld(0x100b_7fdc, 0xc50a);             /* call 0x100b7fdc */
            ii(0x100a_bad2, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_bad5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_bad8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_badb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_bade, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bae1, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5524); /* mov dword [eax+0x2], 0x101b5524 */
            ii(0x100a_bae8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_baeb, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_baee, 3); mov(memd_a32[ds, edx + 0x17], eax);     /* mov [edx+0x17], eax */
            ii(0x100a_baf1, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100a_baf4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_baf7, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x100a_bafa, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_bafd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_bb00, 5); calld(0x100a_c130, 0x62b);              /* call 0x100ac130 */
            ii(0x100a_bb05, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_bb08, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bb0b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bb0e, 5); calld(0x100b_7fa4, 0xc491);             /* call 0x100b7fa4 */
            ii(0x100a_bb13, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bb16, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_bb19, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_bb1c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bb1e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_bb1f, 1); popd(edi);                              /* pop edi */
            ii(0x100a_bb20, 1); popd(esi);                              /* pop esi */
            ii(0x100a_bb21, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}