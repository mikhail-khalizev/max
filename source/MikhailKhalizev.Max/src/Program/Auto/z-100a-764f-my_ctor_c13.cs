using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d9ba339-1b8e-45d8-b209-56bec4200e3a")]
        public void my_ctor_c13()
        {
            ii(0x100a_764f, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100a_7654, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e6f9); /* call 0x10165d52 */
            ii(0x100a_7659, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_765a, 1); pushd(esi);                             /* push esi */
            ii(0x100a_765b, 1); pushd(edi);                             /* push edi */
            ii(0x100a_765c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_765d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_765f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_7665, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_7668, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_766b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_766e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_7670, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_7672, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_7676, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7679, 5); calld(0x100a_26d1, -0x4fad);            /* call 0x100a26d1 */
            ii(0x100a_767e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_7681, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_7684, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_7687, 5); calld(0x100a_a9d4, 0x3348);             /* call 0x100aa9d4 */
            ii(0x100a_768c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_768f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7692, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7695, 5); calld(0x100a_a96c, 0x32d2);             /* call 0x100aa96c */
            ii(0x100a_769a, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x100a_769d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_76a0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_76a3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_76a6, 5); calld(0x100a_a800, 0x3155);             /* call 0x100aa800 */
            ii(0x100a_76ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_76ae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_76b1, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_76b4, 5); calld(0x100a_a7ac, 0x30f3);             /* call 0x100aa7ac */
            ii(0x100a_76b9, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_76bc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_76bf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_76c2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_76c5, 5); calld(0x100a_ab28, 0x345e);             /* call 0x100aab28 */
            ii(0x100a_76ca, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_76cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_76d0, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_76d3, 5); calld(0x100a_aad4, 0x33fc);             /* call 0x100aaad4 */
            ii(0x100a_76d8, 3); sub(eax, 0x2e);                         /* sub eax, 0x2e */
            ii(0x100a_76db, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_76de, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_76e1, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_76e4, 5); calld(0x100a_ab28, 0x343f);             /* call 0x100aab28 */
            ii(0x100a_76e9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_76ec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_76ef, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_76f2, 5); calld(0x100a_aad4, 0x33dd);             /* call 0x100aaad4 */
            ii(0x100a_76f7, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x100a_76fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_76fd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_7700, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_7703, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7706, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_7709, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_101e); /* call 0x100766f0 */
            ii(0x100a_770e, 3); sub(eax, 0x4e);                         /* sub eax, 0x4e */
            ii(0x100a_7711, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_7714, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_7717, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_771a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_771d, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4d94); /* mov dword [eax+0x2], 0x101b4d94 */
            ii(0x100a_7724, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7727, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_772a, 3); mov(memd_a32[ds, edx + 0x52], eax);     /* mov [edx+0x52], eax */
            ii(0x100a_772d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7730, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x100a_7734, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_7737, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_773a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_773d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_773f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7740, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7741, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7742, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7743, 1); retd(); return;                         /* ret */
        }
    }
}
