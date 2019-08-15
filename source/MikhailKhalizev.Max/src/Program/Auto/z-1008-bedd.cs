using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b79fd69-1757-472a-b1f0-55c794fbfe0b")]
        public void Method_1008_bedd()
        {
            ii(0x1008_bedd, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x1008_bee2, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9e6b); /* call 0x10165d52 */
            ii(0x1008_bee7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_bee8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_bee9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_beea, 1); pushd(edi);                             /* push edi */
            ii(0x1008_beeb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_beec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_beee, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1008_bef4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_bef7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_befa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_befd, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1008_bf00, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bf03, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf04, 5); mov(eax, StringDefinitions.GetIMaterials); /* mov eax, 0x101a038c */
            ii(0x1008_bf09, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf0a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bf0d, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf0e, 5); calld(Definitions.sys_sprintf, 0xd_9fee); /* call 0x10165f01 */
            ii(0x1008_bf13, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1008_bf16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_bf18, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bf1b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_bf1e, 5); calld(0x1013_ad11, 0xa_edee);           /* call 0x1013ad11 */
            ii(0x1008_bf23, 2); test(al, al);                           /* test al, al */
            ii(0x1008_bf25, 2); if(jzd(0x1008_bf39, 0x12)) goto l_0x1008_bf39; /* jz 0x1008bf39 */
            ii(0x1008_bf27, 5); mov(edx, StringDefinitions.Finished);   /* mov edx, 0x101a039d */
            ii(0x1008_bf2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bf2f, 5); calld(Definitions.sys_strcat, 0xd_9ffd); /* call 0x10165f31 */
            ii(0x1008_bf34, 5); jmpd(0x1008_c040, 0x107); goto l_0x1008_c040; /* jmp 0x1008c040 */
        l_0x1008_bf39:
            ii(0x1008_bf39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bf3c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_bf3f, 5); calld(0x1007_6574, -0x1_59d0);          /* call 0x10076574 */
            ii(0x1008_bf44, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x1008_bf47, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_bf4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bf4d, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1008_bf50, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bf53, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_bf55, 2); if(jld(0x1008_bf69, 0x12)) goto l_0x1008_bf69; /* jl 0x1008bf69 */
            ii(0x1008_bf57, 5); mov(edx, StringDefinitions.AlreadyOnHand); /* mov edx, 0x101a03a9 */
            ii(0x1008_bf5c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bf5f, 5); calld(Definitions.sys_strcat, 0xd_9fcd); /* call 0x10165f31 */
            ii(0x1008_bf64, 5); jmpd(0x1008_c040, 0xd7); goto l_0x1008_c040; /* jmp 0x1008c040 */
        l_0x1008_bf69:
            ii(0x1008_bf69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bf6c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_bf6f, 5); calld(0x1007_6574, -0x1_5a00);          /* call 0x10076574 */
            ii(0x1008_bf74, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_bf77, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bf7a, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf7b, 5); mov(eax, StringDefinitions.IOnHand);    /* mov eax, 0x101a03bc */
            ii(0x1008_bf80, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf81, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_bf84, 1); pushd(eax);                             /* push eax */
            ii(0x1008_bf85, 5); calld(Definitions.sys_sprintf, 0xd_9f77); /* call 0x10165f01 */
            ii(0x1008_bf8a, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1008_bf8d, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1008_bf90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bf93, 5); calld(Definitions.sys_strcat, 0xd_9f99); /* call 0x10165f31 */
            ii(0x1008_bf98, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_bf9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bf9d, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_bfa0, 5); calld(0x1013_ad11, 0xa_ed6c);           /* call 0x1013ad11 */
            ii(0x1008_bfa5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_bfa7, 2); if(jzd(0x1008_bfbb, 0x12)) goto l_0x1008_bfbb; /* jz 0x1008bfbb */
            ii(0x1008_bfa9, 5); mov(edx, StringDefinitions.WaitingForSource); /* mov edx, 0x101a03cb */
            ii(0x1008_bfae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_bfb1, 5); calld(Definitions.sys_strcat, 0xd_9f7b); /* call 0x10165f31 */
            ii(0x1008_bfb6, 5); jmpd(0x1008_c040, 0x85); goto l_0x1008_c040; /* jmp 0x1008c040 */
        l_0x1008_bfbb:
            ii(0x1008_bfbb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bfbe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_bfc1, 5); calld(0x1007_6574, -0x1_5a52);          /* call 0x10076574 */
            ii(0x1008_bfc6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_bfc9, 4); mov(dx, memw_a32[ds, edx + 0x1f]);      /* mov dx, [edx+0x1f] */
            ii(0x1008_bfcd, 4); sub(dx, memw_a32[ds, eax + 0x52]);      /* sub dx, [eax+0x52] */
            ii(0x1008_bfd1, 3); mov(memd_a32[ss, ebp - 0x44], edx);     /* mov [ebp-0x44], edx */
            ii(0x1008_bfd4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bfd7, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_bfda, 5); calld(0x1007_6574, -0x1_5a6b);          /* call 0x10076574 */
            ii(0x1008_bfdf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_bfe1, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_bfe4, 4); cmp(ax, memw_a32[ds, edx + 0x52]);      /* cmp ax, [edx+0x52] */
            ii(0x1008_bfe8, 2); if(jled(0x1008_bffc, 0x12)) goto l_0x1008_bffc; /* jle 0x1008bffc */
            ii(0x1008_bfea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bfed, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_bff0, 5); calld(0x1007_6574, -0x1_5a81);          /* call 0x10076574 */
            ii(0x1008_bff5, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1008_bff9, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1008_bffc:
            ii(0x1008_bffc, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x1008_c000, 1); pushd(eax);                             /* push eax */
            ii(0x1008_c001, 5); mov(eax, StringDefinitions.GetIFrom);   /* mov eax, 0x101a03df */
            ii(0x1008_c006, 1); pushd(eax);                             /* push eax */
            ii(0x1008_c007, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_c00a, 1); pushd(eax);                             /* push eax */
            ii(0x1008_c00b, 5); calld(Definitions.sys_sprintf, 0xd_9ef1); /* call 0x10165f01 */
            ii(0x1008_c010, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1008_c013, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1008_c016, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c019, 5); calld(Definitions.sys_strcat, 0xd_9f13); /* call 0x10165f31 */
            ii(0x1008_c01e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_c021, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c024, 5); calld(0x1007_6574, -0x1_5ab5);          /* call 0x10076574 */
            ii(0x1008_c029, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1008_c02c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_c02f, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1008_c032, 6); mov(edx, memd_a32[ds, edx + 0x101c_81d7]); /* mov edx, [edx+0x101c81d7] */
            ii(0x1008_c038, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c03b, 5); calld(Definitions.sys_strcat, 0xd_9ef1); /* call 0x10165f31 */
        l_0x1008_c040:
            ii(0x1008_c040, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c043, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_c046, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c049, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c04b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_c04c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_c04d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_c04e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_c04f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_c050, 1); retd(); return;                         /* ret */
        }
    }
}
