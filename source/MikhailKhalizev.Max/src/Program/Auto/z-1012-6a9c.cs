using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1987e291-619c-4d40-9c27-70716e52fcbb")]
        public void Method_1012_6a9c()
        {
            ii(0x1012_6a9c, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1012_6aa1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_f2ac); /* call 0x10165d52 */
            ii(0x1012_6aa6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_6aa7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_6aa8, 1); pushd(edx);                             /* push edx */
            ii(0x1012_6aa9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_6aaa, 1); pushd(edi);                             /* push edi */
            ii(0x1012_6aab, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_6aac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_6aae, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1012_6ab4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_6ab7, 7); mov(memd_a32[ss, ebp - 0xc], 0x101c_59f5); /* mov dword [ebp-0xc], 0x101c59f5 */
            ii(0x1012_6abe, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1012_6ac2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6ac5, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xb_0286); /* call 0x10076844 */
            ii(0x1012_6aca, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_6acd, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1012_6ad1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6ad3, 4); mov(dx, memw_a32[ss, ebp - 0x4]);       /* mov dx, [ebp-0x4] */
            ii(0x1012_6ad7, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_6adc, 5); calld(0x1010_3eba, -0x2_2c27);          /* call 0x10103eba */
            ii(0x1012_6ae1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6ae3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6ae6, 5); calld(0x1007_66ac, -0xb_043f);          /* call 0x100766ac */
            ii(0x1012_6aeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6aed, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6af0, 5); calld(0x1013_ad11, 0x1_421c);           /* call 0x1013ad11 */
            ii(0x1012_6af5, 2); test(al, al);                           /* test al, al */
            ii(0x1012_6af7, 2); if(jzd(0x1012_6b07, 0xe)) goto l_0x1012_6b07; /* jz 0x10126b07 */
            ii(0x1012_6af9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6afd, 5); calld(0x1012_6a47, -0xbb);              /* call 0x10126a47 */
            ii(0x1012_6b02, 5); jmpd(0x1012_6c80, 0x179); goto l_0x1012_6c80; /* jmp 0x10126c80 */
        l_0x1012_6b07:
            ii(0x1012_6b07, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1012_6b0c, 5); calld(Definitions.sys_new, 0x3_f2ef);   /* call 0x10165e00 */
            ii(0x1012_6b11, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_6b14, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1012_6b17, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_6b1a, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1012_6b1e, 2); if(jzd(0x1012_6b44, 0x24)) goto l_0x1012_6b44; /* jz 0x10126b44 */
            ii(0x1012_6b20, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6b23, 5); calld(0x1007_6574, -0xb_05b4);          /* call 0x10076574 */
            ii(0x1012_6b28, 5); calld(0x1007_623c, -0xb_08f1);          /* call 0x1007623c */
            ii(0x1012_6b2d, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x1012_6b30, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6b32, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_6b34, 5); calld(0x100c_a2f8, -0x5_c841);          /* call 0x100ca2f8 */
            ii(0x1012_6b39, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_6b3c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_6b3f, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_6b42, 2); jmpd(0x1012_6b4a, 0x6); goto l_0x1012_6b4a; /* jmp 0x10126b4a */
        l_0x1012_6b44:
            ii(0x1012_6b44, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_6b47, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1012_6b4a:
            ii(0x1012_6b4a, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1012_6b4d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b50, 5); calld(0x100c_b77c, -0x5_b3d9);          /* call 0x100cb77c */
            ii(0x1012_6b55, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b58, 5); calld(0x1007_6730, -0xb_042d);          /* call 0x10076730 */
            ii(0x1012_6b5d, 5); calld(0x100c_b7e4, -0x5_b37e);          /* call 0x100cb7e4 */
            ii(0x1012_6b62, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_6b67, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b6a, 5); calld(0x1007_6730, -0xb_043f);          /* call 0x10076730 */
            ii(0x1012_6b6f, 5); calld(0x100c_b7b4, -0x5_b3c0);          /* call 0x100cb7b4 */
            ii(0x1012_6b74, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b77, 5); calld(0x1007_6730, -0xb_044c);          /* call 0x10076730 */
            ii(0x1012_6b7c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6b7f, 4); mov(dx, memw_a32[ds, edx + 0x2]);       /* mov dx, [edx+0x2] */
            ii(0x1012_6b83, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1012_6b87, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b8a, 5); calld(0x1007_6730, -0xb_045f);          /* call 0x10076730 */
            ii(0x1012_6b8f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6b92, 4); mov(dx, memw_a32[ds, edx + 0x4]);       /* mov dx, [edx+0x4] */
            ii(0x1012_6b96, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1012_6b9a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6b9d, 5); calld(0x1007_6730, -0xb_0472);          /* call 0x10076730 */
            ii(0x1012_6ba2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6ba5, 4); mov(dx, memw_a32[ds, edx + 0x6]);       /* mov dx, [edx+0x6] */
            ii(0x1012_6ba9, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1012_6bad, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6bb0, 5); calld(0x1007_6730, -0xb_0485);          /* call 0x10076730 */
            ii(0x1012_6bb5, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6bb8, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x1012_6bbc, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1012_6bc0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6bc3, 5); calld(0x1007_6730, -0xb_0498);          /* call 0x10076730 */
            ii(0x1012_6bc8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6bcb, 4); mov(dx, memw_a32[ds, edx + 0xa]);       /* mov dx, [edx+0xa] */
            ii(0x1012_6bcf, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x1012_6bd3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6bd6, 5); calld(0x1007_6730, -0xb_04ab);          /* call 0x10076730 */
            ii(0x1012_6bdb, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6bde, 4); mov(dx, memw_a32[ds, edx + 0xc]);       /* mov dx, [edx+0xc] */
            ii(0x1012_6be2, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x1012_6be6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6be9, 5); calld(0x1007_6730, -0xb_04be);          /* call 0x10076730 */
            ii(0x1012_6bee, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6bf1, 4); mov(dx, memw_a32[ds, edx + 0xe]);       /* mov dx, [edx+0xe] */
            ii(0x1012_6bf5, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
            ii(0x1012_6bf9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6bfc, 5); calld(0x1007_6730, -0xb_04d1);          /* call 0x10076730 */
            ii(0x1012_6c01, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c04, 3); mov(dl, memb_a32[ds, edx + 0x10]);      /* mov dl, [edx+0x10] */
            ii(0x1012_6c07, 3); mov(memb_a32[ds, eax + 0x16], dl);      /* mov [eax+0x16], dl */
            ii(0x1012_6c0a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c0d, 5); calld(0x1007_6730, -0xb_04e2);          /* call 0x10076730 */
            ii(0x1012_6c12, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c15, 4); mov(dx, memw_a32[ds, edx + 0x12]);      /* mov dx, [edx+0x12] */
            ii(0x1012_6c19, 4); mov(memw_a32[ds, eax + 0x17], dx);      /* mov [eax+0x17], dx */
            ii(0x1012_6c1d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c20, 5); calld(0x1007_6730, -0xb_04f5);          /* call 0x10076730 */
            ii(0x1012_6c25, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c28, 4); mov(dx, memw_a32[ds, edx + 0x14]);      /* mov dx, [edx+0x14] */
            ii(0x1012_6c2c, 4); mov(memw_a32[ds, eax + 0x19], dx);      /* mov [eax+0x19], dx */
            ii(0x1012_6c30, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c33, 5); calld(0x1007_6730, -0xb_0508);          /* call 0x10076730 */
            ii(0x1012_6c38, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c3b, 4); mov(dx, memw_a32[ds, edx + 0x16]);      /* mov dx, [edx+0x16] */
            ii(0x1012_6c3f, 4); mov(memw_a32[ds, eax + 0x1b], dx);      /* mov [eax+0x1b], dx */
            ii(0x1012_6c43, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c46, 5); calld(0x1007_6730, -0xb_051b);          /* call 0x10076730 */
            ii(0x1012_6c4b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c4e, 4); mov(dx, memw_a32[ds, edx + 0x18]);      /* mov dx, [edx+0x18] */
            ii(0x1012_6c52, 4); mov(memw_a32[ds, eax + 0x1d], dx);      /* mov [eax+0x1d], dx */
            ii(0x1012_6c56, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c59, 5); calld(0x1007_6730, -0xb_052e);          /* call 0x10076730 */
            ii(0x1012_6c5e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_6c61, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x1012_6c65, 4); mov(memw_a32[ds, eax + 0x1f], dx);      /* mov [eax+0x1f], dx */
            ii(0x1012_6c69, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c6c, 5); calld(0x100c_b74c, -0x5_b525);          /* call 0x100cb74c */
            ii(0x1012_6c71, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6c73, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6c76, 5); calld(0x1007_6574, -0xb_0707);          /* call 0x10076574 */
            ii(0x1012_6c7b, 5); calld(0x1010_2bc4, -0x2_40bc);          /* call 0x10102bc4 */
        l_0x1012_6c80:
            ii(0x1012_6c80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6c82, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_6c85, 5); calld(0x1007_5f2c, -0xb_0d5e);          /* call 0x10075f2c */
            ii(0x1012_6c8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6c8c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_6c8f, 5); calld(0x1007_5eec, -0xb_0da8);          /* call 0x10075eec */
            ii(0x1012_6c94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6c96, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_6c97, 1); popd(edi);                              /* pop edi */
            ii(0x1012_6c98, 1); popd(esi);                              /* pop esi */
            ii(0x1012_6c99, 1); popd(edx);                              /* pop edx */
            ii(0x1012_6c9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_6c9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_6c9c, 1); retd(); return;                         /* ret */
        }
    }
}
