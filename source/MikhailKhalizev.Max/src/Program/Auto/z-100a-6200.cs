using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c496ccd3-f865-4adc-b400-6268f114d5cd")]
        public void Method_100a_6200()
        {
            ii(0x100a_6200, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_6205, 5); calld(Definitions.sys_check_available_stack_size, 0xb_fb48); /* call 0x10165d52 */
            ii(0x100a_620a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_620b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_620c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_620d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_620e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_620f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6211, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_6217, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_621a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_621d, 5); mov(edx, StringDefinitions.ObtainUnits); /* mov edx, 0x101a0c3a */
            ii(0x100a_6222, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6225, 5); calld(Definitions.sys_strcpy, 0xb_fca5); /* call 0x10165ecf */
            ii(0x100a_622a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_622d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6230, 5); calld(Definitions.my_2_get_count, -0x1_aecd); /* call 0x1008b368 */
            ii(0x100a_6235, 1); cwde();                                 /* cwde */
            ii(0x100a_6236, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_6238, 2); if(jnzd(0x100a_6247, 0xd)) goto l_0x100a_6247; /* jnz 0x100a6247 */
            ii(0x100a_623a, 5); mov(edx, StringDefinitions.Finished2);  /* mov edx, 0x101a0c49 */
            ii(0x100a_623f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6242, 5); calld(Definitions.sys_strcat, 0xb_fcea); /* call 0x10165f31 */
        l_0x100a_6247:
            ii(0x100a_6247, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_624e, 2); jmpd(0x100a_6256, 0x6); goto l_0x100a_6256; /* jmp 0x100a6256 */
        l_0x100a_6250:
            ii(0x100a_6250, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6253, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_6256:
            ii(0x100a_6256, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6259, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_625c, 5); calld(Definitions.my_2_get_count, -0x1_aef9); /* call 0x1008b368 */
            ii(0x100a_6261, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100a_6265, 2); if(jled(0x100a_6270, 0x9)) goto l_0x100a_6270; /* jle 0x100a6270 */
            ii(0x100a_6267, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_626b, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100a_626e, 2); if(jld(0x100a_6272, 0x2)) goto l_0x100a_6272; /* jl 0x100a6272 */
        l_0x100a_6270:
            ii(0x100a_6270, 2); jmpd(0x100a_62c4, 0x52); goto l_0x100a_62c4; /* jmp 0x100a62c4 */
        l_0x100a_6272:
            ii(0x100a_6272, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_6276, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6279, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_627c, 5); calld(0x1008_b228, -0x1_b059);          /* call 0x1008b228 */
            ii(0x100a_6281, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100a_6284, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100a_6287, 6); mov(edx, memd_a32[ds, edx + 0x101c_81d7]); /* mov edx, [edx+0x101c81d7] */
            ii(0x100a_628d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6290, 5); calld(Definitions.sys_strcat, 0xb_fc9c); /* call 0x10165f31 */
            ii(0x100a_6295, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6298, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_629b, 5); calld(Definitions.my_2_get_count, -0x1_af38); /* call 0x1008b368 */
            ii(0x100a_62a0, 1); cwde();                                 /* cwde */
            ii(0x100a_62a1, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_62a5, 1); dec(eax);                               /* dec eax */
            ii(0x100a_62a6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_62a8, 2); if(jged(0x100a_62b3, 0x9)) goto l_0x100a_62b3; /* jge 0x100a62b3 */
            ii(0x100a_62aa, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_62ae, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_62b1, 2); if(jld(0x100a_62b5, 0x2)) goto l_0x100a_62b5; /* jl 0x100a62b5 */
        l_0x100a_62b3:
            ii(0x100a_62b3, 2); jmpd(0x100a_62c2, 0xd); goto l_0x100a_62c2; /* jmp 0x100a62c2 */
        l_0x100a_62b5:
            ii(0x100a_62b5, 5); mov(edx, StringDefinitions.Control32);  /* mov edx, 0x101a0c54 */
            ii(0x100a_62ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_62bd, 5); calld(Definitions.sys_strcat, 0xb_fc6f); /* call 0x10165f31 */
        l_0x100a_62c2:
            ii(0x100a_62c2, 2); jmpd(0x100a_6250, -0x74); goto l_0x100a_6250; /* jmp 0x100a6250 */
        l_0x100a_62c4:
            ii(0x100a_62c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_62c7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_62ca, 5); calld(Definitions.my_2_get_count, -0x1_af67); /* call 0x1008b368 */
            ii(0x100a_62cf, 1); cwde();                                 /* cwde */
            ii(0x100a_62d0, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100a_62d3, 2); if(jled(0x100a_62e2, 0xd)) goto l_0x100a_62e2; /* jle 0x100a62e2 */
            ii(0x100a_62d5, 5); mov(edx, StringDefinitions.Control31);  /* mov edx, 0x101a0c57 */
            ii(0x100a_62da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_62dd, 5); calld(Definitions.sys_strcat, 0xb_fc4f); /* call 0x10165f31 */
        l_0x100a_62e2:
            ii(0x100a_62e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_62e5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_62e8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_62eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_62ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_62ee, 1); popd(edi);                              /* pop edi */
            ii(0x100a_62ef, 1); popd(esi);                              /* pop esi */
            ii(0x100a_62f0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_62f1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_62f2, 1); retd(); return;                         /* ret */
        }
    }
}
