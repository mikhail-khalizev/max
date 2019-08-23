using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_ae33-501f57a5")]
        public void Method_1007_ae33()
        {
            ii(0x1007_ae33, 5); push(0x70);                             /* push 0x70 */
            ii(0x1007_ae38, 5); call(Definitions.sys_check_available_stack_size, 0xe_af15); /* call 0x10165d52 */
            ii(0x1007_ae3d, 1); push(ebx);                              /* push ebx */
            ii(0x1007_ae3e, 1); push(ecx);                              /* push ecx */
            ii(0x1007_ae3f, 1); push(esi);                              /* push esi */
            ii(0x1007_ae40, 1); push(edi);                              /* push edi */
            ii(0x1007_ae41, 1); push(ebp);                              /* push ebp */
            ii(0x1007_ae42, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ae44, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1007_ae4a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_ae4d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_ae50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ae52, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ae55, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ae58, 5); call(0x1013_ad11, 0xb_feb4);            /* call 0x1013ad11 */
            ii(0x1007_ae5d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ae5f, 2); if(jnz(0x1007_ae75, 0x14)) goto l_0x1007_ae75; /* jnz 0x1007ae75 */
            ii(0x1007_ae61, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ae64, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ae67, 5); call(0x1008_a228, 0xf3bc);              /* call 0x1008a228 */
            ii(0x1007_ae6c, 5); call(0x1008_a370, 0xf4ff);              /* call 0x1008a370 */
            ii(0x1007_ae71, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_ae73, 2); if(jnz(0x1007_ae8c, 0x17)) goto l_0x1007_ae8c; /* jnz 0x1007ae8c */
        l_0x1007_ae75:
            ii(0x1007_ae75, 5); mov(eax, StringDefinitions.CompletedKillUnitTask); /* mov eax, 0x101a013c */
            ii(0x1007_ae7a, 1); push(eax);                              /* push eax */
            ii(0x1007_ae7b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ae7e, 1); push(eax);                              /* push eax */
            ii(0x1007_ae7f, 5); call(Definitions.sys_sprintf, 0xe_b07d); /* call 0x10165f01 */
            ii(0x1007_ae84, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1007_ae87, 5); jmp(0x1007_af69, 0xdd); goto l_0x1007_af69; /* jmp 0x1007af69 */
        l_0x1007_ae8c:
            ii(0x1007_ae8c, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x1007_ae8f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ae92, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ae95, 5); call(0x1008_a228, 0xf38e);              /* call 0x1008a228 */
            ii(0x1007_ae9a, 5); call(0x1008_a370, 0xf4d1);              /* call 0x1008a370 */
            ii(0x1007_ae9f, 5); call(0x1014_fa43, 0xd_4b9f);            /* call 0x1014fa43 */
            ii(0x1007_aea4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_aea7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_aeaa, 5); call(0x1008_a228, 0xf379);              /* call 0x1008a228 */
            ii(0x1007_aeaf, 5); call(0x100b_8eda, 0x3_e026);            /* call 0x100b8eda */
            ii(0x1007_aeb4, 1); cwde();                                 /* cwde */
            ii(0x1007_aeb5, 1); inc(eax);                               /* inc eax */
            ii(0x1007_aeb6, 1); push(eax);                              /* push eax */
            ii(0x1007_aeb7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_aeba, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_aebd, 5); call(0x1008_a228, 0xf366);              /* call 0x1008a228 */
            ii(0x1007_aec2, 5); call(0x100b_8ea1, 0x3_dfda);            /* call 0x100b8ea1 */
            ii(0x1007_aec7, 1); cwde();                                 /* cwde */
            ii(0x1007_aec8, 1); inc(eax);                               /* inc eax */
            ii(0x1007_aec9, 1); push(eax);                              /* push eax */
            ii(0x1007_aeca, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_aecd, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_aed0, 5); call(0x1008_a228, 0xf353);              /* call 0x1008a228 */
            ii(0x1007_aed5, 5); call(0x1008_a370, 0xf496);              /* call 0x1008a370 */
            ii(0x1007_aeda, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_aedd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_aee0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_aee3, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1007_aee9, 5); mov(eax, StringDefinitions.KillSAtII);  /* mov eax, 0x101a0156 */
            ii(0x1007_aeee, 1); push(eax);                              /* push eax */
            ii(0x1007_aeef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_aef2, 1); push(eax);                              /* push eax */
            ii(0x1007_aef3, 5); call(Definitions.sys_sprintf, 0xe_b009); /* call 0x10165f01 */
            ii(0x1007_aef8, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1007_aefb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_aefe, 4); mov(ax, memw[ds, eax + 0x23]);          /* mov ax, [eax+0x23] */
            ii(0x1007_af02, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_af05, 4); cmp(ax, memw[ds, edx + 0x25]);          /* cmp ax, [edx+0x25] */
            ii(0x1007_af09, 2); if(jg(0x1007_af1a, 0xf)) goto l_0x1007_af1a; /* jg 0x1007af1a */
            ii(0x1007_af0b, 5); mov(edx, StringDefinitions.Ready);      /* mov edx, 0x101a0169 */
            ii(0x1007_af10, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_af13, 5); call(Definitions.sys_strcat, 0xe_b019); /* call 0x10165f31 */
            ii(0x1007_af18, 2); jmp(0x1007_af69, 0x4f); goto l_0x1007_af69; /* jmp 0x1007af69 */
        l_0x1007_af1a:
            ii(0x1007_af1a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_af1d, 3); mov(edx, memd[ds, eax + 0x21]);         /* mov edx, [eax+0x21] */
            ii(0x1007_af20, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_af23, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_af26, 3); mov(eax, memd[ds, eax + 0x23]);         /* mov eax, [eax+0x23] */
            ii(0x1007_af29, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_af2c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_af2e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_af30, 1); push(eax);                              /* push eax */
            ii(0x1007_af31, 5); mov(eax, StringDefinitions.IPointsNeeded); /* mov eax, 0x101a0172 */
            ii(0x1007_af36, 1); push(eax);                              /* push eax */
            ii(0x1007_af37, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1007_af3c, 1); push(eax);                              /* push eax */
            ii(0x1007_af3d, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_af40, 5); call(Definitions.my_string_ctor, 0xc_6ba3); /* call 0x10141ae8 */
            ii(0x1007_af45, 1); push(eax);                              /* push eax */
            ii(0x1007_af46, 5); call(0x1014_2037, 0xc_70ec);            /* call 0x10142037 */
            ii(0x1007_af4b, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1007_af4e, 5); call(Definitions.my_strobj_c_str_v2, 0xe875); /* call 0x100897c8 */
            ii(0x1007_af53, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_af56, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_af58, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_af5a, 5); call(Definitions.sys_strcat, 0xe_afd2); /* call 0x10165f31 */
            ii(0x1007_af5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_af61, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1007_af64, 5); call(Definitions.my_string_dtor, 0xc_6bc1); /* call 0x10141b2a */
        l_0x1007_af69:
            ii(0x1007_af69, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_af6c, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_af6f, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_af72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_af74, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_af75, 1); pop(edi);                               /* pop edi */
            ii(0x1007_af76, 1); pop(esi);                               /* pop esi */
            ii(0x1007_af77, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_af78, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_af79, 1); ret();                                  /* ret */
        }
    }
}
