using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_af4d-bcfd365b")]
        public void Method_1010_af4d()
        {
            ii(0x1010_af4d, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1010_af52, 5); calld(Definitions.sys_check_available_stack_size, 0x5_adfb); /* call 0x10165d52 */
            ii(0x1010_af57, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_af58, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_af59, 1); pushd(edx);                             /* push edx */
            ii(0x1010_af5a, 1); pushd(esi);                             /* push esi */
            ii(0x1010_af5b, 1); pushd(edi);                             /* push edi */
            ii(0x1010_af5c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_af5d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_af5f, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1010_af65, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_af68, 7); mov(memd_a32[ss, ebp - 0x8], 0x33);     /* mov dword [ebp-0x8], 0x33 */
        l_0x1010_af6f:
            ii(0x1010_af6f, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_af72, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_af77, 2); if(jzd(0x1010_afc2, 0x49)) goto l_0x1010_afc2; /* jz 0x1010afc2 */
            ii(0x1010_af79, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_af7d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_af80, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_af83, 7); cmp(memd_a32[ds, eax + 0x275], 0);      /* cmp dword [eax+0x275], 0x0 */
            ii(0x1010_af8a, 2); if(jzd(0x1010_afc0, 0x34)) goto l_0x1010_afc0; /* jz 0x1010afc0 */
            ii(0x1010_af8c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_af90, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_af93, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_af96, 6); mov(eax, memd_a32[ds, eax + 0x275]);    /* mov eax, [eax+0x275] */
            ii(0x1010_af9c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_af9f, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_afa3, 2); if(jzd(0x1010_afb9, 0x14)) goto l_0x1010_afb9; /* jz 0x1010afb9 */
            ii(0x1010_afa5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_afa7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_afaa, 5); calld(Definitions.my_dtor_d2, -0x3_ca77); /* call 0x100ce538 */
            ii(0x1010_afaf, 5); calld(Definitions.sys_delete, 0x5_afb0); /* call 0x10165f64 */
            ii(0x1010_afb4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_afb7, 2); jmpd(0x1010_afc0, 0x7); goto l_0x1010_afc0; /* jmp 0x1010afc0 */
        l_0x1010_afb9:
            ii(0x1010_afb9, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_afc0:
            ii(0x1010_afc0, 2); jmpd(0x1010_af6f, -0x53); goto l_0x1010_af6f; /* jmp 0x1010af6f */
        l_0x1010_afc2:
            ii(0x1010_afc2, 7); mov(memd_a32[ss, ebp - 0x8], 0x6);      /* mov dword [ebp-0x8], 0x6 */
        l_0x1010_afc9:
            ii(0x1010_afc9, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_afcc, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_afd1, 2); if(jzd(0x1010_b01c, 0x49)) goto l_0x1010_b01c; /* jz 0x1010b01c */
            ii(0x1010_afd3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_afd7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_afda, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_afdd, 7); cmp(memd_a32[ds, eax + 0x374], 0);      /* cmp dword [eax+0x374], 0x0 */
            ii(0x1010_afe4, 2); if(jzd(0x1010_b01a, 0x34)) goto l_0x1010_b01a; /* jz 0x1010b01a */
            ii(0x1010_afe6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_afea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_afed, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_aff0, 6); mov(eax, memd_a32[ds, eax + 0x374]);    /* mov eax, [eax+0x374] */
            ii(0x1010_aff6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_aff9, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_affd, 2); if(jzd(0x1010_b013, 0x14)) goto l_0x1010_b013; /* jz 0x1010b013 */
            ii(0x1010_afff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b001, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_b004, 5); calld(Definitions.my_dtor_d3, -0x3_32d6); /* call 0x100d7d33 */
            ii(0x1010_b009, 5); calld(Definitions.sys_delete, 0x5_af56); /* call 0x10165f64 */
            ii(0x1010_b00e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_b011, 2); jmpd(0x1010_b01a, 0x7); goto l_0x1010_b01a; /* jmp 0x1010b01a */
        l_0x1010_b013:
            ii(0x1010_b013, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_b01a:
            ii(0x1010_b01a, 2); jmpd(0x1010_afc9, -0x53); goto l_0x1010_afc9; /* jmp 0x1010afc9 */
        l_0x1010_b01c:
            ii(0x1010_b01c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b01f, 7); cmp(memd_a32[ds, eax + 0x341], 0);      /* cmp dword [eax+0x341], 0x0 */
            ii(0x1010_b026, 2); if(jzd(0x1010_b055, 0x2d)) goto l_0x1010_b055; /* jz 0x1010b055 */
            ii(0x1010_b028, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b02b, 6); mov(eax, memd_a32[ds, eax + 0x341]);    /* mov eax, [eax+0x341] */
            ii(0x1010_b031, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_b034, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_b038, 2); if(jzd(0x1010_b04e, 0x14)) goto l_0x1010_b04e; /* jz 0x1010b04e */
            ii(0x1010_b03a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b03c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_b03f, 5); calld(Definitions.my_dtor_d6, -0x1_ff6d); /* call 0x100eb0d7 */
            ii(0x1010_b044, 5); calld(Definitions.sys_delete, 0x5_af1b); /* call 0x10165f64 */
            ii(0x1010_b049, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_b04c, 2); jmpd(0x1010_b055, 0x7); goto l_0x1010_b055; /* jmp 0x1010b055 */
        l_0x1010_b04e:
            ii(0x1010_b04e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1010_b055:
            ii(0x1010_b055, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b057, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b058, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b059, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b05a, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b05b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b05c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b05d, 1); retd();                                 /* ret */
        }
    }
}
