using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9cae6df6-dcd1-473c-8665-fb4773828db2")]
        public void Method_100d_7431()
        {
            ii(0x100d_7431, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100d_7436, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e917); /* call 0x10165d52 */
            ii(0x100d_743b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_743c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_743d, 1); pushd(esi);                             /* push esi */
            ii(0x100d_743e, 1); pushd(edi);                             /* push edi */
            ii(0x100d_743f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7440, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7442, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100d_7448, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_744b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_744e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7451, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100d_7455, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_7458, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_745b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_745e, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100d_7462, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7465, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100d_7469, 2); if(jzd(0x100d_74b3, 0x48)) goto l_0x100d_74b3; /* jz 0x100d74b3 */
            ii(0x100d_746b, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_7470, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100d_7475, 5); calld(0x1013_dc59, 0x6_67df);           /* call 0x1013dc59 */
            ii(0x100d_747a, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100d_747e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7481, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7484, 5); calld(0x100d_7682, 0x1f9);              /* call 0x100d7682 */
            ii(0x100d_7489, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_748c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_748f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_7492, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x100d_7495, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_7498, 3); calld_abs(memd_a32[ds, edx + 0x8]);     /* call dword [edx+0x8] */
            ii(0x100d_749b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_749e, 3); mov(eax, memd_a32[ds, eax + 0x20]);     /* mov eax, [eax+0x20] */
            ii(0x100d_74a1, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_74a4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_74a7, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_74aa, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100d_74ad, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_74b0, 3); calld_abs(memd_a32[ds, ebx + 0x4]);     /* call dword [ebx+0x4] */
        l_0x100d_74b3:
            ii(0x100d_74b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_74b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_74b6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_74b7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_74b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_74b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_74ba, 1); retd(); return;                         /* ret */
        }
    }
}
