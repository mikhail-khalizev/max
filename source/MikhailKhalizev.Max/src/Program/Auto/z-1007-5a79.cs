using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa75b809-f978-4c51-9c29-09958c197b93")]
        public void Method_1007_5a79()
        {
            ii(0x1007_5a79, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_5a7e, 5); calld(Definitions.sys_check_available_stack_size, 0xf02cf); /* call 0x10165d52 */
            ii(0x1007_5a83, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5a84, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5a85, 1); pushd(edx);                             /* push edx */
            ii(0x1007_5a86, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5a87, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5a88, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5a89, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5a8b, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_5a91, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_5a94, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1007_5a98, 2); if(jnzd(0x1007_5aa6, 0xc)) goto l_0x1007_5aa6; /* jnz 0x10075aa6 */
            ii(0x1007_5a9a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_5aa1, 5); jmpd(0x1007_5c06, 0x160); goto l_0x1007_5c06; /* jmp 0x10075c06 */
        l_0x1007_5aa6:
            ii(0x1007_5aa6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5aa9, 5); calld(0x1007_61d4, 0x726);              /* call 0x100761d4 */
            ii(0x1007_5aae, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_5ab1, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1007_5ab5, 2); if(jnzd(0x1007_5ac3, 0xc)) goto l_0x1007_5ac3; /* jnz 0x10075ac3 */
            ii(0x1007_5ab7, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_5abe, 5); jmpd(0x1007_5c06, 0x143); goto l_0x1007_5c06; /* jmp 0x10075c06 */
        l_0x1007_5ac3:
            ii(0x1007_5ac3, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_5ac7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5aca, 5); calld(0x1007_64fc, 0xa2d);              /* call 0x100764fc */
            ii(0x1007_5acf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_5ad2, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_5ad6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_5ad9, 5); calld(0x1007_6338, 0x85a);              /* call 0x10076338 */
            ii(0x1007_5ade, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5ae0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5ae3, 5); calld(0x1007_643c, 0x954);              /* call 0x1007643c */
            ii(0x1007_5ae8, 2); jmpd(0x1007_5af2, 0x8); goto l_0x1007_5af2; /* jmp 0x10075af2 */
        l_0x1007_5aea:
            ii(0x1007_5aea, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5aed, 5); calld(0x1007_6bf8, 0x1106);             /* call 0x10076bf8 */
        l_0x1007_5af2:
            ii(0x1007_5af2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5af4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5af7, 5); calld(0x1013_ad71, 0xc5275);            /* call 0x1013ad71 */
            ii(0x1007_5afc, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5afe, 6); if(jzd(0x1007_5b91, 0x8d)) goto l_0x1007_5b91; /* jz 0x10075b91 */
            ii(0x1007_5b04, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b07, 5); calld(0x1007_63a0, 0x894);              /* call 0x100763a0 */
            ii(0x1007_5b0c, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1007_5b10, 2); if(jnzd(0x1007_5b28, 0x16)) goto l_0x1007_5b28; /* jnz 0x10075b28 */
            ii(0x1007_5b12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5b14, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b17, 5); calld(0x1007_63a0, 0x884);              /* call 0x100763a0 */
            ii(0x1007_5b1c, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_5b1f, 5); calld(0x1013_ad11, 0xc51ed);            /* call 0x1013ad11 */
            ii(0x1007_5b24, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5b26, 2); if(jnzd(0x1007_5b2a, 0x2)) goto l_0x1007_5b2a; /* jnz 0x10075b2a */
        l_0x1007_5b28:
            ii(0x1007_5b28, 2); jmpd(0x1007_5b8c, 0x62); goto l_0x1007_5b8c; /* jmp 0x10075b8c */
        l_0x1007_5b2a:
            ii(0x1007_5b2a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b2d, 5); calld(0x1007_63a0, 0x86e);              /* call 0x100763a0 */
            ii(0x1007_5b32, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1007_5b35, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_5b3a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5b3c, 2); if(jzd(0x1007_5b7f, 0x41)) goto l_0x1007_5b7f; /* jz 0x10075b7f */
            ii(0x1007_5b3e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b41, 5); calld(0x1007_63a0, 0x85a);              /* call 0x100763a0 */
            ii(0x1007_5b46, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1007_5b4a, 2); if(jzd(0x1007_5b5a, 0xe)) goto l_0x1007_5b5a; /* jz 0x10075b5a */
            ii(0x1007_5b4c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b4f, 5); calld(0x1007_63a0, 0x84c);              /* call 0x100763a0 */
            ii(0x1007_5b54, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1e);    /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_5b58, 2); if(jnzd(0x1007_5b5c, 0x2)) goto l_0x1007_5b5c; /* jnz 0x10075b5c */
        l_0x1007_5b5a:
            ii(0x1007_5b5a, 2); jmpd(0x1007_5b69, 0xd); goto l_0x1007_5b69; /* jmp 0x10075b69 */
        l_0x1007_5b5c:
            ii(0x1007_5b5c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b5f, 5); calld(0x1007_63d4, 0x870);              /* call 0x100763d4 */
            ii(0x1007_5b64, 5); calld(0x1007_5745, -0x424);             /* call 0x10075745 */
        l_0x1007_5b69:
            ii(0x1007_5b69, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_5b70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5b72, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b75, 5); calld(0x1007_5f6c, 0x3f2);              /* call 0x10075f6c */
            ii(0x1007_5b7a, 5); jmpd(0x1007_5c06, 0x87); goto l_0x1007_5c06; /* jmp 0x10075c06 */
        l_0x1007_5b7f:
            ii(0x1007_5b7f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b82, 5); calld(0x1007_63a0, 0x819);              /* call 0x100763a0 */
            ii(0x1007_5b87, 5); calld(0x1014_b6bd, 0xd5b31);            /* call 0x1014b6bd */
        l_0x1007_5b8c:
            ii(0x1007_5b8c, 5); jmpd(0x1007_5aea, -0xa7); goto l_0x1007_5aea; /* jmp 0x10075aea */
        l_0x1007_5b91:
            ii(0x1007_5b91, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_5b94, 5); calld(0x1007_6338, 0x79f);              /* call 0x10076338 */
            ii(0x1007_5b99, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5b9b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5b9e, 5); calld(0x1007_643c, 0x899);              /* call 0x1007643c */
            ii(0x1007_5ba3, 2); jmpd(0x1007_5bad, 0x8); goto l_0x1007_5bad; /* jmp 0x10075bad */
        l_0x1007_5ba5:
            ii(0x1007_5ba5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5ba8, 5); calld(0x1007_6bf8, 0x104b);             /* call 0x10076bf8 */
        l_0x1007_5bad:
            ii(0x1007_5bad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5baf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5bb2, 5); calld(0x1013_ad71, 0xc51ba);            /* call 0x1013ad71 */
            ii(0x1007_5bb7, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5bb9, 2); if(jzd(0x1007_5be9, 0x2e)) goto l_0x1007_5be9; /* jz 0x10075be9 */
            ii(0x1007_5bbb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5bbe, 5); calld(0x1007_6408, 0x845);              /* call 0x10076408 */
            ii(0x1007_5bc3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_5bc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5bc9, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1007_5bcd, 2); if(jnzd(0x1007_5be7, 0x18)) goto l_0x1007_5be7; /* jnz 0x10075be7 */
            ii(0x1007_5bcf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5bd2, 4); mov(memb_a32[ds, eax + 0x3e], 0x7);     /* mov byte [eax+0x3e], 0x7 */
            ii(0x1007_5bd6, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_5bdd, 2); if(jzd(0x1007_5be7, 0x8)) goto l_0x1007_5be7; /* jz 0x10075be7 */
            ii(0x1007_5bdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5be2, 5); calld(0x1012_88e9, 0xb2d02);            /* call 0x101288e9 */
        l_0x1007_5be7:
            ii(0x1007_5be7, 2); jmpd(0x1007_5ba5, -0x44); goto l_0x1007_5ba5; /* jmp 0x10075ba5 */
        l_0x1007_5be9:
            ii(0x1007_5be9, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1007_5bf0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5bf2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5bf5, 5); calld(0x1007_5f6c, 0x372);              /* call 0x10075f6c */
            ii(0x1007_5bfa, 2); jmpd(0x1007_5c06, 0xa); goto l_0x1007_5c06; /* jmp 0x10075c06 */
        //  ii(0x1007_5bfc, 10); Недостижимый код.
l_0x1007_5c06:
            ii(0x1007_5c06, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_5c09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5c0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5c0c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5c0d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5c0e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_5c0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5c10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_5c11, 1); retd(); return;                         /* ret */
        }
    }
}
