using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_4a18-34fd0f8e")]
        public void Method_1008_4a18()
        {
            ii(0x1008_4a18, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1008_4a1d, 5); calld(Definitions.sys_check_available_stack_size, 0xe_1330); /* call 0x10165d52 */
            ii(0x1008_4a22, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_4a23, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_4a24, 1); pushd(edx);                             /* push edx */
            ii(0x1008_4a25, 1); pushd(esi);                             /* push esi */
            ii(0x1008_4a26, 1); pushd(edi);                             /* push edi */
            ii(0x1008_4a27, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_4a28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_4a2a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_4a30, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_4a33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4a36, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4a39, 5); calld(0x1007_6574, -0xe4ca);            /* call 0x10076574 */
            ii(0x1008_4a3e, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_4a41, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_4a46, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4a48, 2); if(jnzd(0x1008_4a53, 0x9)) goto l_0x1008_4a53; /* jnz 0x10084a53 */
            ii(0x1008_4a4a, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4a4e, 5); jmpd(0x1008_4c72, 0x21f); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4a53:
            ii(0x1008_4a53, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_4a56, 3); add(edx, 0x36);                         /* add edx, 0x36 */
            ii(0x1008_4a59, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4a5c, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4a5f, 5); calld(0x1007_6574, -0xe4f0);            /* call 0x10076574 */
            ii(0x1008_4a64, 5); calld(0x1015_26ac, 0xc_dc43);           /* call 0x101526ac */
            ii(0x1008_4a69, 5); calld(0x1008_b4b4, 0x6a46);             /* call 0x1008b4b4 */
            ii(0x1008_4a6e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4a70, 2); if(jzd(0x1008_4a7b, 0x9)) goto l_0x1008_4a7b; /* jz 0x10084a7b */
            ii(0x1008_4a72, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4a76, 5); jmpd(0x1008_4c72, 0x1f7); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4a7b:
            ii(0x1008_4a7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4a7e, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_4a81, 5); calld(0x1008_af84, 0x64fe);             /* call 0x1008af84 */
            ii(0x1008_4a86, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4a88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4a8b, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4a8e, 5); calld(0x1007_6574, -0xe51f);            /* call 0x10076574 */
            ii(0x1008_4a93, 5); calld(0x1015_2a52, 0xc_dfba);           /* call 0x10152a52 */
            ii(0x1008_4a98, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4a9a, 2); if(jnzd(0x1008_4aa5, 0x9)) goto l_0x1008_4aa5; /* jnz 0x10084aa5 */
            ii(0x1008_4a9c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4aa0, 5); jmpd(0x1008_4c72, 0x1cd); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4aa5:
            ii(0x1008_4aa5, 4); mov(memb_a32[ss, ebp - 0x10], 0x3);     /* mov byte [ebp-0x10], 0x3 */
            ii(0x1008_4aa9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4aac, 4); cmp(memb_a32[ds, eax + 0x15], 0x3);     /* cmp byte [eax+0x15], 0x3 */
            ii(0x1008_4ab0, 2); if(jld(0x1008_4ab6, 0x4)) goto l_0x1008_4ab6; /* jl 0x10084ab6 */
            ii(0x1008_4ab2, 4); mov(memb_a32[ss, ebp - 0x10], 0x2);     /* mov byte [ebp-0x10], 0x2 */
        l_0x1008_4ab6:
            ii(0x1008_4ab6, 4); movsx(ebx, memb_a32[ss, ebp - 0x10]);   /* movsx ebx, byte [ebp-0x10] */
            ii(0x1008_4aba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4abd, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4ac0, 5); calld(0x1007_65d0, -0xe4f5);            /* call 0x100765d0 */
            ii(0x1008_4ac5, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1008_4ac8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4aca, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1008_4acc, 5); calld(0x100a_3671, 0x1_eba0);           /* call 0x100a3671 */
            ii(0x1008_4ad1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4ad3, 2); if(jzd(0x1008_4ade, 0x9)) goto l_0x1008_4ade; /* jz 0x10084ade */
            ii(0x1008_4ad5, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_4ad9, 5); jmpd(0x1008_4c72, 0x194); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4ade:
            ii(0x1008_4ade, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4ae0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4ae3, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4ae6, 5); calld(0x1013_ad11, 0xb_6226);           /* call 0x1013ad11 */
            ii(0x1008_4aeb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4aed, 2); if(jnzd(0x1008_4b03, 0x14)) goto l_0x1008_4b03; /* jnz 0x10084b03 */
            ii(0x1008_4aef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4af2, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4af5, 5); calld(0x1008_9d7c, 0x5282);             /* call 0x10089d7c */
            ii(0x1008_4afa, 5); calld(0x1008_9f70, 0x5471);             /* call 0x10089f70 */
            ii(0x1008_4aff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4b01, 2); if(jnzd(0x1008_4b0c, 0x9)) goto l_0x1008_4b0c; /* jnz 0x10084b0c */
        l_0x1008_4b03:
            ii(0x1008_4b03, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4b07, 5); jmpd(0x1008_4c72, 0x166); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4b0c:
            ii(0x1008_4b0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b0f, 4); cmp(memb_a32[ds, eax + 0x15], 0x2);     /* cmp byte [eax+0x15], 0x2 */
            ii(0x1008_4b13, 2); if(jgd(0x1008_4b29, 0x14)) goto l_0x1008_4b29; /* jg 0x10084b29 */
            ii(0x1008_4b15, 4); movsx(edx, memb_a32[ss, ebp - 0x10]);   /* movsx edx, byte [ebp-0x10] */
            ii(0x1008_4b19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b1c, 5); calld(0x1008_43e0, -0x741);             /* call 0x100843e0 */
            ii(0x1008_4b21, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_4b24, 5); jmpd(0x1008_4c72, 0x149); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4b29:
            ii(0x1008_4b29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b2c, 4); cmp(memb_a32[ds, eax + 0x15], 0x5);     /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_4b30, 2); if(jld(0x1008_4b46, 0x14)) goto l_0x1008_4b46; /* jl 0x10084b46 */
            ii(0x1008_4b32, 4); movsx(edx, memb_a32[ss, ebp - 0x10]);   /* movsx edx, byte [ebp-0x10] */
            ii(0x1008_4b36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b39, 5); calld(0x1008_43e0, -0x75e);             /* call 0x100843e0 */
            ii(0x1008_4b3e, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_4b41, 5); jmpd(0x1008_4c72, 0x12c); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4b46:
            ii(0x1008_4b46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b49, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4b4c, 5); calld(0x1007_6574, -0xe5dd);            /* call 0x10076574 */
            ii(0x1008_4b51, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x1008_4b55, 2); if(jzd(0x1008_4b88, 0x31)) goto l_0x1008_4b88; /* jz 0x10084b88 */
            ii(0x1008_4b57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b5a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4b5d, 5); calld(0x1007_6574, -0xe5ee);            /* call 0x10076574 */
            ii(0x1008_4b62, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1008_4b65, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_4b68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b6b, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4b6e, 5); calld(0x1007_6574, -0xe5ff);            /* call 0x10076574 */
            ii(0x1008_4b73, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1008_4b76, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_4b79, 5); calld(0x1007_3d48, -0x1_0e36);          /* call 0x10073d48 */
            ii(0x1008_4b7e, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1008_4b83, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1008_4b86, 2); if(jnzd(0x1008_4b8a, 0x2)) goto l_0x1008_4b8a; /* jnz 0x10084b8a */
        l_0x1008_4b88:
            ii(0x1008_4b88, 2); jmpd(0x1008_4ba9, 0x1f); goto l_0x1008_4ba9; /* jmp 0x10084ba9 */
        l_0x1008_4b8a:
            ii(0x1008_4b8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4b8d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_4b90, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_4b93, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1008_4b99, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_4b9e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_4ba0, 5); calld(0x1008_a064, 0x54bf);             /* call 0x1008a064 */
            ii(0x1008_4ba5, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1008_4ba7, 2); if(jnzd(0x1008_4bab, 0x2)) goto l_0x1008_4bab; /* jnz 0x10084bab */
        l_0x1008_4ba9:
            ii(0x1008_4ba9, 2); jmpd(0x1008_4bbf, 0x14); goto l_0x1008_4bbf; /* jmp 0x10084bbf */
        l_0x1008_4bab:
            ii(0x1008_4bab, 4); movsx(edx, memb_a32[ss, ebp - 0x10]);   /* movsx edx, byte [ebp-0x10] */
            ii(0x1008_4baf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4bb2, 5); calld(0x1008_43e0, -0x7d7);             /* call 0x100843e0 */
            ii(0x1008_4bb7, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_4bba, 5); jmpd(0x1008_4c72, 0xb3); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4bbf:
            ii(0x1008_4bbf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4bc2, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4bc5, 5); calld(0x1007_6574, -0xe656);            /* call 0x10076574 */
            ii(0x1008_4bca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4bcc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4bcf, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4bd2, 5); calld(0x1007_6574, -0xe663);            /* call 0x10076574 */
            ii(0x1008_4bd7, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x1008_4bdb, 4); mov(memw_a32[ds, eax + 0x1e], dx);      /* mov [eax+0x1e], dx */
            ii(0x1008_4bdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4be2, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4be5, 5); calld(0x1007_6574, -0xe676);            /* call 0x10076574 */
            ii(0x1008_4bea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4bec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4bef, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4bf2, 5); calld(0x1007_6574, -0xe683);            /* call 0x10076574 */
            ii(0x1008_4bf7, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x1008_4bfb, 4); mov(memw_a32[ds, eax + 0x20], dx);      /* mov [eax+0x20], dx */
            ii(0x1008_4bff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4c02, 5); calld(0x1008_46e6, -0x521);             /* call 0x100846e6 */
            ii(0x1008_4c07, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4c09, 2); if(jnzd(0x1008_4c11, 0x6)) goto l_0x1008_4c11; /* jnz 0x10084c11 */
            ii(0x1008_4c0b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4c0f, 2); jmpd(0x1008_4c72, 0x61); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        l_0x1008_4c11:
            ii(0x1008_4c11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4c14, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_4c17, 5); calld(0x1008_9d08, 0x50ec);             /* call 0x10089d08 */
            ii(0x1008_4c1c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4c1e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_4c21, 5); calld(0x1008_9be4, 0x4fbe);             /* call 0x10089be4 */
            ii(0x1008_4c26, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_4c2a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_4c2d, 5); calld(0x1007_64fc, -0xe736);            /* call 0x100764fc */
            ii(0x1008_4c32, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_4c35, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_4c39, 4); movsx(edx, memb_a32[ss, ebp - 0x10]);   /* movsx edx, byte [ebp-0x10] */
            ii(0x1008_4c3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4c40, 5); calld(0x1008_43e0, -0x865);             /* call 0x100843e0 */
            ii(0x1008_4c45, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_4c48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4c4a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_4c4d, 5); calld(0x1007_5f6c, -0xece6);            /* call 0x10075f6c */
            ii(0x1008_4c52, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4c54, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_4c57, 5); calld(0x1008_9044, 0x43e8);             /* call 0x10089044 */
            ii(0x1008_4c5c, 2); jmpd(0x1008_4c72, 0x14); goto l_0x1008_4c72; /* jmp 0x10084c72 */
        //  ii(0x1008_4c5e, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_4c60, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1008_4c63, 5); calld(0x1007_5f6c, -0xecfc);            /* call 0x10075f6c */
        //  ii(0x1008_4c68, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_4c6a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //  ii(0x1008_4c6d, 5); calld(0x1008_9044, 0x43d2);             /* call 0x10089044 */
        l_0x1008_4c72:
            ii(0x1008_4c72, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_4c75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_4c77, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_4c78, 1); popd(edi);                              /* pop edi */
            ii(0x1008_4c79, 1); popd(esi);                              /* pop esi */
            ii(0x1008_4c7a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_4c7b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_4c7c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_4c7d, 1); retd();                                 /* ret */
        }
    }
}
