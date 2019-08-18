using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0278849-4c3d-4a82-93fa-9adf056377e2")]
        public void Method_100f_eac0()
        {
            ii(0x100f_eac0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_eac5, 5); calld(Definitions.sys_check_available_stack_size, 0x6_7288); /* call 0x10165d52 */
            ii(0x100f_eaca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_eacb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_eacc, 1); pushd(edx);                             /* push edx */
            ii(0x100f_eacd, 1); pushd(esi);                             /* push esi */
            ii(0x100f_eace, 1); pushd(edi);                             /* push edi */
            ii(0x100f_eacf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ead0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ead2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_ead8, 7); mov(memb_a32[ds, 0x101c_3970], 0);      /* mov byte [0x101c3970], 0x0 */
            ii(0x100f_eadf, 7); mov(memb_a32[ds, 0x101c_37d2], 0);      /* mov byte [0x101c37d2], 0x0 */
            ii(0x100f_eae6, 9); mov(memw_a32[ds, 0x101c_3962], 0);      /* mov word [0x101c3962], 0x0 */
            ii(0x100f_eaef, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_eaf4, 5); calld(0x1013_d08a, 0x3_e591);           /* call 0x1013d08a */
            ii(0x100f_eaf9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_eafb, 5); calld(0x100f_448c, -0xa674);            /* call 0x100f448c */
            ii(0x100f_eb00, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_eb07, 2); if(jzd(0x100f_eb1b, 0x12)) goto l_0x100f_eb1b; /* jz 0x100feb1b */
            ii(0x100f_eb09, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_eb0e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_eb10, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_eb15, 1); cwde();                                 /* cwde */
            ii(0x100f_eb16, 5); calld(0x1012_b16c, 0x2_c651);           /* call 0x1012b16c */
        l_0x100f_eb1b:
            ii(0x100f_eb1b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_eb1d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_eb22, 5); calld(0x1007_6630, -0x8_84f7);          /* call 0x10076630 */
            ii(0x100f_eb27, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_eb2c, 5); calld(0x100f_19ee, -0xd143);            /* call 0x100f19ee */
            ii(0x100f_eb31, 7); mov(memd_a32[ss, ebp - 0x4], 0x4);      /* mov dword [ebp-0x4], 0x4 */
        l_0x100f_eb38:
            ii(0x100f_eb38, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_eb3b, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_eb40, 2); if(jzd(0x100f_eb9c, 0x5a)) goto l_0x100f_eb9c; /* jz 0x100feb9c */
            ii(0x100f_eb42, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_eb46, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eb4c, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_eb52, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_eb57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_eb59, 2); if(jzd(0x100f_eb9a, 0x3f)) goto l_0x100f_eb9a; /* jz 0x100feb9a */
            ii(0x100f_eb5b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_eb5f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eb65, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x100f_eb6b, 5); calld(Definitions.sys_delete, 0x6_73f4); /* call 0x10165f64 */
            ii(0x100f_eb70, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_eb74, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eb7a, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a7]); /* mov eax, [eax+0x101ca6a7] */
            ii(0x100f_eb80, 5); calld(Definitions.sys_delete, 0x6_73df); /* call 0x10165f64 */
            ii(0x100f_eb85, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_eb89, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eb8f, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6ab]); /* mov eax, [eax+0x101ca6ab] */
            ii(0x100f_eb95, 5); calld(Definitions.sys_delete, 0x6_73ca); /* call 0x10165f64 */
        l_0x100f_eb9a:
            ii(0x100f_eb9a, 2); jmpd(0x100f_eb38, -0x64); goto l_0x100f_eb38; /* jmp 0x100feb38 */
        l_0x100f_eb9c:
            ii(0x100f_eb9c, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
        l_0x100f_eba3:
            ii(0x100f_eba3, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_eba6, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_ebab, 2); if(jzd(0x100f_ebeb, 0x3e)) goto l_0x100f_ebeb; /* jz 0x100febeb */
            ii(0x100f_ebad, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ebb1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ebb7, 10); mov(memd_a32[ds, eax + 0x101c_a6a3], 0); /* mov dword [eax+0x101ca6a3], 0x0 */
            ii(0x100f_ebc1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ebc5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ebcb, 10); mov(memd_a32[ds, eax + 0x101c_a6a7], 0); /* mov dword [eax+0x101ca6a7], 0x0 */
            ii(0x100f_ebd5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ebd9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_ebdf, 10); mov(memd_a32[ds, eax + 0x101c_a6ab], 0); /* mov dword [eax+0x101ca6ab], 0x0 */
            ii(0x100f_ebe9, 2); jmpd(0x100f_eba3, -0x48); goto l_0x100f_eba3; /* jmp 0x100feba3 */
        l_0x100f_ebeb:
            ii(0x100f_ebeb, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100f_ebf0, 5); calld(0x1010_2e0f, 0x421a);             /* call 0x10102e0f */
            ii(0x100f_ebf5, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_ebfa, 5); calld(0x1010_2e0f, 0x4210);             /* call 0x10102e0f */
            ii(0x100f_ebff, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x100f_ec04, 5); calld(0x1010_2e0f, 0x4206);             /* call 0x10102e0f */
            ii(0x100f_ec09, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_ec0e, 5); calld(0x1010_2e0f, 0x41fc);             /* call 0x10102e0f */
            ii(0x100f_ec13, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_ec18, 5); calld(0x1010_2e0f, 0x41f2);             /* call 0x10102e0f */
            ii(0x100f_ec1d, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x100f_ec22, 5); calld(0x1010_3ff1, 0x53ca);             /* call 0x10103ff1 */
            ii(0x100f_ec27, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100f_ec2c, 5); calld(0x1010_380b, 0x4bda);             /* call 0x1010380b */
            ii(0x100f_ec31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ec33, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ec38, 5); calld(0x1007_6630, -0x8_860d);          /* call 0x10076630 */
            ii(0x100f_ec3d, 7); cmp(memd_a32[ds, 0x101c_9450], 0);      /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_ec44, 2); if(jzd(0x100f_ec50, 0xa)) goto l_0x100f_ec50; /* jz 0x100fec50 */
            ii(0x100f_ec46, 5); mov(eax, memd_a32[ds, 0x101c_9450]);    /* mov eax, [0x101c9450] */
            ii(0x100f_ec4b, 5); calld(Definitions.sys_free, 0x6_c471);  /* call 0x1016b0c1 */
        l_0x100f_ec50:
            ii(0x100f_ec50, 7); cmp(memd_a32[ds, 0x101c_944c], 0);      /* cmp dword [0x101c944c], 0x0 */
            ii(0x100f_ec57, 2); if(jzd(0x100f_ec63, 0xa)) goto l_0x100f_ec63; /* jz 0x100fec63 */
            ii(0x100f_ec59, 5); mov(eax, memd_a32[ds, 0x101c_944c]);    /* mov eax, [0x101c944c] */
            ii(0x100f_ec5e, 5); calld(Definitions.sys_free, 0x6_c45e);  /* call 0x1016b0c1 */
        l_0x100f_ec63:
            ii(0x100f_ec63, 7); cmp(memd_a32[ds, 0x101c_9454], 0);      /* cmp dword [0x101c9454], 0x0 */
            ii(0x100f_ec6a, 2); if(jzd(0x100f_ec76, 0xa)) goto l_0x100f_ec76; /* jz 0x100fec76 */
            ii(0x100f_ec6c, 5); mov(eax, memd_a32[ds, 0x101c_9454]);    /* mov eax, [0x101c9454] */
            ii(0x100f_ec71, 5); calld(Definitions.sys_delete, 0x6_72ee); /* call 0x10165f64 */
        l_0x100f_ec76:
            ii(0x100f_ec76, 7); cmp(memd_a32[ds, 0x101c_811c], 0);      /* cmp dword [0x101c811c], 0x0 */
            ii(0x100f_ec7d, 2); if(jzd(0x100f_ec89, 0xa)) goto l_0x100f_ec89; /* jz 0x100fec89 */
            ii(0x100f_ec7f, 5); mov(eax, memd_a32[ds, 0x101c_811c]);    /* mov eax, [0x101c811c] */
            ii(0x100f_ec84, 5); calld(Definitions.sys_free, 0x6_c438);  /* call 0x1016b0c1 */
        l_0x100f_ec89:
            ii(0x100f_ec89, 10); mov(memd_a32[ds, 0x101c_9450], 0);     /* mov dword [0x101c9450], 0x0 */
            ii(0x100f_ec93, 10); mov(memd_a32[ds, 0x101c_944c], 0);     /* mov dword [0x101c944c], 0x0 */
            ii(0x100f_ec9d, 10); mov(memd_a32[ds, 0x101c_9454], 0);     /* mov dword [0x101c9454], 0x0 */
            ii(0x100f_eca7, 10); mov(memd_a32[ds, 0x101c_811c], 0);     /* mov dword [0x101c811c], 0x0 */
            ii(0x100f_ecb1, 7); cmp(memd_a32[ds, 0x101c_39ac], 0);      /* cmp dword [0x101c39ac], 0x0 */
            ii(0x100f_ecb8, 2); if(jzd(0x100f_ece3, 0x29)) goto l_0x100f_ece3; /* jz 0x100fece3 */
            ii(0x100f_ecba, 5); mov(eax, memd_a32[ds, 0x101c_39ac]);    /* mov eax, [0x101c39ac] */
            ii(0x100f_ecbf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_ecc2, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_ecc6, 2); if(jzd(0x100f_ecdc, 0x14)) goto l_0x100f_ecdc; /* jz 0x100fecdc */
            ii(0x100f_ecc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ecca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_eccd, 5); calld(Definitions.my_dtor_d3, -0x2_6f9f); /* call 0x100d7d33 */
            ii(0x100f_ecd2, 5); calld(Definitions.sys_delete, 0x6_728d); /* call 0x10165f64 */
            ii(0x100f_ecd7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_ecda, 2); jmpd(0x100f_ece3, 0x7); goto l_0x100f_ece3; /* jmp 0x100fece3 */
        l_0x100f_ecdc:
            ii(0x100f_ecdc, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100f_ece3:
            ii(0x100f_ece3, 5); calld(0x100f_2955, -0xc393);            /* call 0x100f2955 */
            ii(0x100f_ece8, 5); calld(0x1013_44d5, 0x3_57e8);           /* call 0x101344d5 */
            ii(0x100f_eced, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ecef, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_ecf0, 1); popd(edi);                              /* pop edi */
            ii(0x100f_ecf1, 1); popd(esi);                              /* pop esi */
            ii(0x100f_ecf2, 1); popd(edx);                              /* pop edx */
            ii(0x100f_ecf3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_ecf4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_ecf5, 1); retd(); return;                         /* ret */
        }
    }
}
