using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26946553-ebab-4866-9ff0-0ec12ae699e7")]
        public void Method_1008_be20()
        {
            ii(0x1008_be20, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_be25, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9f28); /* call 0x10165d52 */
            ii(0x1008_be2a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_be2b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_be2c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_be2d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_be2e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_be2f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_be30, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_be32, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_be38, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_be3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_be3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_be40, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_be43, 5); calld(0x1013_ad11, 0xa_eec9);           /* call 0x1013ad11 */
            ii(0x1008_be48, 2); test(al, al);                           /* test al, al */
            ii(0x1008_be4a, 2); if(jzd(0x1008_be55, 0x9)) goto l_0x1008_be55; /* jz 0x1008be55 */
            ii(0x1008_be4c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_be50, 5); jmpd(0x1008_bed1, 0x7c); goto l_0x1008_bed1; /* jmp 0x1008bed1 */
        l_0x1008_be55:
            ii(0x1008_be55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_be58, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_be5b, 5); calld(0x1007_6574, -0x1_58ec);          /* call 0x10076574 */
            ii(0x1008_be60, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x1008_be63, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_be66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_be69, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1008_be6c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_be6f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_be71, 2); if(jld(0x1008_be79, 0x6)) goto l_0x1008_be79; /* jl 0x1008be79 */
            ii(0x1008_be73, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_be77, 2); jmpd(0x1008_bed1, 0x58); goto l_0x1008_bed1; /* jmp 0x1008bed1 */
        l_0x1008_be79:
            ii(0x1008_be79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_be7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_be7e, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_be81, 5); calld(0x1013_ad11, 0xa_ee8b);           /* call 0x1013ad11 */
            ii(0x1008_be86, 2); test(al, al);                           /* test al, al */
            ii(0x1008_be88, 2); if(jzd(0x1008_be90, 0x6)) goto l_0x1008_be90; /* jz 0x1008be90 */
            ii(0x1008_be8a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_be8e, 2); jmpd(0x1008_bed1, 0x41); goto l_0x1008_bed1; /* jmp 0x1008bed1 */
        l_0x1008_be90:
            ii(0x1008_be90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_be93, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_be96, 5); calld(0x1007_6574, -0x1_5927);          /* call 0x10076574 */
            ii(0x1008_be9b, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x1008_be9e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_bea1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bea4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_bea7, 5); calld(0x1007_6574, -0x1_5938);          /* call 0x10076574 */
            ii(0x1008_beac, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_beaf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_beb2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_beb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_beb7, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1008_beba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bebd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_bebf, 2); if(jged(0x1008_bec7, 0x6)) goto l_0x1008_bec7; /* jge 0x1008bec7 */
            ii(0x1008_bec1, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_bec5, 2); jmpd(0x1008_becb, 0x4); goto l_0x1008_becb; /* jmp 0x1008becb */
        l_0x1008_bec7:
            ii(0x1008_bec7, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_becb:
            ii(0x1008_becb, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_bece, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1008_bed1:
            ii(0x1008_bed1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_bed4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bed6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_bed7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_bed8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_bed9, 1); popd(edx);                              /* pop edx */
            ii(0x1008_beda, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_bedb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_bedc, 1); retd(); return;                         /* ret */
        }
    }
}
