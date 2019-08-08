using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1be50fc3-fa59-4425-a8da-50f21a449cba")]
        public void Method_1013_cd6c()
        {
            ii(0x1013_cd6c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_cd71, 5); calld(Definitions.sys_check_available_stack_size, 0x2_8fdc); /* call 0x10165d52 */
            ii(0x1013_cd76, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_cd77, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_cd78, 1); pushd(edx);                             /* push edx */
            ii(0x1013_cd79, 1); pushd(esi);                             /* push esi */
            ii(0x1013_cd7a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_cd7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_cd7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_cd7e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_cd84, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_cd87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cd8a, 7); cmp(memd_a32[ds, eax + 0xdad], 0);      /* cmp dword [eax+0xdad], 0x0 */
            ii(0x1013_cd91, 2); if(jzd(0x1013_cda1, 0xe)) goto l_0x1013_cda1; /* jz 0x1013cda1 */
            ii(0x1013_cd93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cd96, 6); mov(eax, memd_a32[ds, eax + 0xdad]);    /* mov eax, [eax+0xdad] */
            ii(0x1013_cd9c, 5); calld(Definitions.sys_delete, 0x2_91c3); /* call 0x10165f64 */
        l_0x1013_cda1:
            ii(0x1013_cda1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cda4, 10); cmp(memd_a32[ds, eax + 0xda9], 0xffff); /* cmp dword [eax+0xda9], 0xffff */
            ii(0x1013_cdae, 2); if(jzd(0x1013_cdbe, 0xe)) goto l_0x1013_cdbe; /* jz 0x1013cdbe */
            ii(0x1013_cdb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cdb3, 6); mov(eax, memd_a32[ds, eax + 0xda9]);    /* mov eax, [eax+0xda9] */
            ii(0x1013_cdb9, 5); calld(/* sys */ 0x1017_dc61, 0x4_0ea3); /* call 0x1017dc61 */
        l_0x1013_cdbe:
            ii(0x1013_cdbe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cdc1, 7); cmp(memb_a32[ds, eax + 0xdd2], 0);      /* cmp byte [eax+0xdd2], 0x0 */
            ii(0x1013_cdc8, 2); if(jzd(0x1013_cdd1, 0x7)) goto l_0x1013_cdd1; /* jz 0x1013cdd1 */
            ii(0x1013_cdca, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_cdcc, 5); calld(/* sys */ 0x1017_d905, 0x4_0b34); /* call 0x1017d905 */
        l_0x1013_cdd1:
            ii(0x1013_cdd1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cdd4, 7); cmp(memd_a32[ds, eax + 0x1c], 0xffff);  /* cmp dword [eax+0x1c], 0xffff */
            ii(0x1013_cddb, 2); if(jzd(0x1013_cdf7, 0x1a)) goto l_0x1013_cdf7; /* jz 0x1013cdf7 */
            ii(0x1013_cddd, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_cde2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_cde7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cdea, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_cded, 5); calld(/* sys */ 0x1017_f8aa, 0x4_2ab8); /* call 0x1017f8aa */
            ii(0x1013_cdf2, 5); calld(/* sys */ 0x1017_f020, 0x4_2229); /* call 0x1017f020 */
        l_0x1013_cdf7:
            ii(0x1013_cdf7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_cdfa, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_cdfe, 2); if(jzd(0x1013_ce0b, 0xb)) goto l_0x1013_ce0b; /* jz 0x1013ce0b */
            ii(0x1013_ce00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ce03, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_ce06, 5); calld(Definitions.sys_fclose, 0x3_525e); /* call 0x10172069 */
        l_0x1013_ce0b:
            ii(0x1013_ce0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ce0e, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x1013_ce15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ce18, 7); mov(memb_a32[ds, eax + 0xdd2], 0);      /* mov byte [eax+0xdd2], 0x0 */
            ii(0x1013_ce1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ce22, 10); mov(memd_a32[ds, eax + 0xda9], 0xffff); /* mov dword [eax+0xda9], 0xffff */
            ii(0x1013_ce2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ce2f, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff);  /* mov dword [eax+0x1c], 0xffff */
            ii(0x1013_ce36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ce38, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_ce39, 1); popd(edi);                              /* pop edi */
            ii(0x1013_ce3a, 1); popd(esi);                              /* pop esi */
            ii(0x1013_ce3b, 1); popd(edx);                              /* pop edx */
            ii(0x1013_ce3c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_ce3d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_ce3e, 1); retd(); return;                         /* ret */
        }
    }
}
