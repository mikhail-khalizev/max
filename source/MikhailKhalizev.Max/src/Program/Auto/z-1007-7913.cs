using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("84e4756a-73b1-44f4-8915-7d4e70f7ff1b")]
        public void Method_1007_7913()
        {
            ii(0x1007_7913, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x1007_7918, 5); calld(Definitions.sys_check_available_stack_size, 0xe_e435); /* call 0x10165d52 */
            ii(0x1007_791d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_791e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_791f, 1); pushd(esi);                             /* push esi */
            ii(0x1007_7920, 1); pushd(edi);                             /* push edi */
            ii(0x1007_7921, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_7922, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7924, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1007_792a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_792d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_7930, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_7932, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1007_7937, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7939, 2); if(jnzd(0x1007_7952, 0x17)) goto l_0x1007_7952; /* jnz 0x10077952 */
            ii(0x1007_793b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_793e, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_7941, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7946, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7948, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1007_794e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_7950, 2); if(jnzd(0x1007_7954, 0x2)) goto l_0x1007_7954; /* jnz 0x10077954 */
        l_0x1007_7952:
            ii(0x1007_7952, 2); jmpd(0x1007_795d, 0x9); goto l_0x1007_795d; /* jmp 0x1007795d */
        l_0x1007_7954:
            ii(0x1007_7954, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7958, 5); jmpd(0x1007_7c92, 0x335); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_795d:
            ii(0x1007_795d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7960, 4); cmp(memb_a32[ds, eax + 0x59], 0);       /* cmp byte [eax+0x59], 0x0 */
            ii(0x1007_7964, 2); if(jnzd(0x1007_7973, 0xd)) goto l_0x1007_7973; /* jnz 0x10077973 */
            ii(0x1007_7966, 5); mov(eax, memd_a32[ds, 0x101c_31be]);    /* mov eax, [0x101c31be] */
            ii(0x1007_796b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_796e, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_7971, 2); if(jnzd(0x1007_79da, 0x67)) goto l_0x1007_79da; /* jnz 0x100779da */
        l_0x1007_7973:
            ii(0x1007_7973, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1007_7978, 5); calld(Definitions.sys_new, 0xe_e483);   /* call 0x10165e00 */
            ii(0x1007_797d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_7980, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_7983, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_7986, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_798a, 2); if(jzd(0x1007_79a2, 0x16)) goto l_0x1007_79a2; /* jz 0x100779a2 */
            ii(0x1007_798c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_798f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_7992, 5); calld(0x1007_ee7d, 0x74e6);             /* call 0x1007ee7d */
            ii(0x1007_7997, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_799a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_799d, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_79a0, 2); jmpd(0x1007_79a8, 0x6); goto l_0x1007_79a8; /* jmp 0x100779a8 */
        l_0x1007_79a2:
            ii(0x1007_79a2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_79a5, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1007_79a8:
            ii(0x1007_79a8, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1007_79ab, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1007_79ae, 5); calld(0x1008_b060, 0x1_36ad);           /* call 0x1008b060 */
            ii(0x1007_79b3, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1007_79b6, 5); calld(0x1008_af84, 0x1_35c9);           /* call 0x1008af84 */
            ii(0x1007_79bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_79bd, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_79c2, 5); calld(0x100a_4d50, 0x2_d389);           /* call 0x100a4d50 */
            ii(0x1007_79c7, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_79cb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_79cd, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1007_79d0, 5); calld(0x1008_8b7c, 0x1_11a7);           /* call 0x10088b7c */
            ii(0x1007_79d5, 5); jmpd(0x1007_7c92, 0x2b8); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_79da:
            ii(0x1007_79da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_79dd, 5); calld(0x1007_623c, -0x17a6);            /* call 0x1007623c */
            ii(0x1007_79e2, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1007_79e6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_79e9, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_79ed, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_79f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_79f3, 5); calld(0x1007_78a5, -0x153);             /* call 0x100778a5 */
            ii(0x1007_79f8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_79fa, 2); if(jzd(0x1007_7a22, 0x26)) goto l_0x1007_7a22; /* jz 0x10077a22 */
            ii(0x1007_79fc, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1007_7a03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7a06, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1007_7a09, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7a0c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7a0f, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1007_7a12, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7a15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7a18, 5); calld(0x100a_30a2, 0x2_b685);           /* call 0x100a30a2 */
            ii(0x1007_7a1d, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1007_7a20, 2); jmpd(0x1007_7a43, 0x21); goto l_0x1007_7a43; /* jmp 0x10077a43 */
        l_0x1007_7a22:
            ii(0x1007_7a22, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x1007_7a26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7a29, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1007_7a2c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7a2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7a32, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1007_7a35, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7a38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7a3b, 5); calld(0x1007_0d68, -0x6cd8);            /* call 0x10070d68 */
            ii(0x1007_7a40, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1007_7a43:
            ii(0x1007_7a43, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1007_7a47, 6); if(jnzd(0x1007_7b7c, 0x12f)) goto l_0x1007_7b7c; /* jnz 0x10077b7c */
            ii(0x1007_7a4d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7a50, 5); calld(0x1007_623c, -0x1819);            /* call 0x1007623c */
            ii(0x1007_7a55, 4); mov(ax, memw_a32[ds, eax + 0x1d]);      /* mov ax, [eax+0x1d] */
            ii(0x1007_7a59, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1007_7a5c, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1007_7a60, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_7a63, 2); if(jld(0x1007_7a74, 0xf)) goto l_0x1007_7a74; /* jl 0x10077a74 */
            ii(0x1007_7a65, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_7a6a, 5); calld(0x1007_5fdc, -0x1a93);            /* call 0x10075fdc */
            ii(0x1007_7a6f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_7a72, 2); if(jged(0x1007_7a76, 0x2)) goto l_0x1007_7a76; /* jge 0x10077a76 */
        l_0x1007_7a74:
            ii(0x1007_7a74, 2); jmpd(0x1007_7a85, 0xf); goto l_0x1007_7a85; /* jmp 0x10077a85 */
        l_0x1007_7a76:
            ii(0x1007_7a76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7a79, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1007_7a7c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7a81, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7a83, 2); if(jnzd(0x1007_7a8e, 0x9)) goto l_0x1007_7a8e; /* jnz 0x10077a8e */
        l_0x1007_7a85:
            ii(0x1007_7a85, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7a89, 5); jmpd(0x1007_7c92, 0x204); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_7a8e:
            ii(0x1007_7a8e, 4); movsx(ecx, memw_a32[ss, ebp - 0x30]);   /* movsx ecx, word [ebp-0x30] */
            ii(0x1007_7a92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7a95, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1007_7a98, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7a9b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_7a9e, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x1007_7aa1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7aa4, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7aa7, 5); calld(0x1007_6aac, -0x1000);            /* call 0x10076aac */
            ii(0x1007_7aac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7aae, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1007_7ab1, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1007_7ab3, 5); calld(0x100a_95c1, 0x3_1b09);           /* call 0x100a95c1 */
            ii(0x1007_7ab8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1007_7abb, 5); calld(Definitions.my_ctor_0x101b_4184, -0xfd0); /* call 0x10076af0 */
            ii(0x1007_7ac0, 4); mov(memb_a32[ss, ebp - 0x2c], 0);       /* mov byte [ebp-0x2c], 0x0 */
            ii(0x1007_7ac4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7ac7, 5); calld(0x1007_623c, -0x1890);            /* call 0x1007623c */
            ii(0x1007_7acc, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1007_7ad0, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1007_7ad3, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1007_7ad6, 4); imul(eax, memd_a32[ss, ebp - 0x4c]);    /* imul eax, [ebp-0x4c] */
            ii(0x1007_7ada, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1007_7add:
            ii(0x1007_7add, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1007_7ae0, 5); calld(0x1008_9894, 0x1_1daf);           /* call 0x10089894 */
            ii(0x1007_7ae5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7ae7, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1007_7aea, 5); calld(0x1007_5e64, -0x1c8b);            /* call 0x10075e64 */
            ii(0x1007_7aef, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7af1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7af4, 5); calld(0x1007_0ca1, -0x6e58);            /* call 0x10070ca1 */
            ii(0x1007_7af9, 4); cmp(ax, memw_a32[ss, ebp - 0x4c]);      /* cmp ax, [ebp-0x4c] */
            ii(0x1007_7afd, 2); if(jgd(0x1007_7b4b, 0x4c)) goto l_0x1007_7b4b; /* jg 0x10077b4b */
            ii(0x1007_7aff, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1007_7b02, 5); calld(0x1008_9894, 0x1_1d8d);           /* call 0x10089894 */
            ii(0x1007_7b07, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7b09, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1007_7b0c, 5); calld(0x1007_5e64, -0x1cad);            /* call 0x10075e64 */
            ii(0x1007_7b11, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7b13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7b16, 5); calld(0x1007_0ca1, -0x6e7a);            /* call 0x10070ca1 */
            ii(0x1007_7b1b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1007_7b1e, 4); cmp(memb_a32[ss, ebp - 0x2c], 0);       /* cmp byte [ebp-0x2c], 0x0 */
            ii(0x1007_7b22, 2); if(jzd(0x1007_7b2d, 0x9)) goto l_0x1007_7b2d; /* jz 0x10077b2d */
            ii(0x1007_7b24, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1007_7b27, 4); cmp(ax, memw_a32[ss, ebp - 0x5c]);      /* cmp ax, [ebp-0x5c] */
            ii(0x1007_7b2b, 2); if(jged(0x1007_7b4b, 0x1e)) goto l_0x1007_7b4b; /* jge 0x10077b4b */
        l_0x1007_7b2d:
            ii(0x1007_7b2d, 4); mov(memb_a32[ss, ebp - 0x2c], 0x1);     /* mov byte [ebp-0x2c], 0x1 */
            ii(0x1007_7b31, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1007_7b34, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1007_7b37, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1007_7b3a, 5); calld(0x1008_9894, 0x1_1d55);           /* call 0x10089894 */
            ii(0x1007_7b3f, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1007_7b42, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7b44, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_7b46, 5); calld(0x1008_8b44, 0x1_0ff9);           /* call 0x10088b44 */
        l_0x1007_7b4b:
            ii(0x1007_7b4b, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1007_7b4e, 5); calld(0x100a_96db, 0x3_1b88);           /* call 0x100a96db */
            ii(0x1007_7b53, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7b55, 2); if(jnzd(0x1007_7add, -0x7a)) goto l_0x1007_7add; /* jnz 0x10077add */
            ii(0x1007_7b57, 4); cmp(memb_a32[ss, ebp - 0x2c], 0);       /* cmp byte [ebp-0x2c], 0x0 */
            ii(0x1007_7b5b, 2); if(jnzd(0x1007_7b66, 0x9)) goto l_0x1007_7b66; /* jnz 0x10077b66 */
            ii(0x1007_7b5d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7b61, 5); jmpd(0x1007_7c92, 0x12c); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_7b66:
            ii(0x1007_7b66, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1007_7b69, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_7b6c, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
            ii(0x1007_7b70, 3); mov(eax, memd_a32[ss, ebp - 0x46]);     /* mov eax, [ebp-0x46] */
            ii(0x1007_7b73, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_7b76, 4); mov(memw_a32[ds, edx + 0x43], ax);      /* mov [edx+0x43], ax */
            ii(0x1007_7b7a, 2); jmpd(0x1007_7b98, 0x1c); goto l_0x1007_7b98; /* jmp 0x10077b98 */
        l_0x1007_7b7c:
            ii(0x1007_7b7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7b7f, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1007_7b83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7b86, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1007_7b8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7b8d, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1007_7b91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7b94, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
        l_0x1007_7b98:
            ii(0x1007_7b98, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7b9b, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1007_7b9e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7ba3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7ba5, 2); if(jnzd(0x1007_7bb1, 0xa)) goto l_0x1007_7bb1; /* jnz 0x10077bb1 */
            ii(0x1007_7ba7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7baa, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_7baf, 2); if(jzd(0x1007_7bb3, 0x2)) goto l_0x1007_7bb3; /* jz 0x10077bb3 */
        l_0x1007_7bb1:
            ii(0x1007_7bb1, 2); jmpd(0x1007_7bbc, 0x9); goto l_0x1007_7bbc; /* jmp 0x10077bbc */
        l_0x1007_7bb3:
            ii(0x1007_7bb3, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7bb7, 5); jmpd(0x1007_7c92, 0xd6); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_7bbc:
            ii(0x1007_7bbc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7bbf, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_7bc4, 2); if(jnzd(0x1007_7bcf, 0x9)) goto l_0x1007_7bcf; /* jnz 0x10077bcf */
            ii(0x1007_7bc6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1007_7bca, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_7bcd, 2); if(jzd(0x1007_7bd4, 0x5)) goto l_0x1007_7bd4; /* jz 0x10077bd4 */
        l_0x1007_7bcf:
            ii(0x1007_7bcf, 5); jmpd(0x1007_7c59, 0x85); goto l_0x1007_7c59; /* jmp 0x10077c59 */
        l_0x1007_7bd4:
            ii(0x1007_7bd4, 9); mov(memw_a32[ds, 0x101c_31c0], 0x2);    /* mov word [0x101c31c0], 0x2 */
            ii(0x1007_7bdd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_7be0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7be3, 5); calld(0x1008_a998, 0x1_2db0);           /* call 0x1008a998 */
            ii(0x1007_7be8, 5); calld(/* sys */ 0x1016_5e9b, 0xe_e2ae); /* call 0x10165e9b */
            ii(0x1007_7bed, 3); imul(eax, eax, 0x65);                   /* imul eax, eax, 0x65 */
            ii(0x1007_7bf0, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1007_7bf3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7bf5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7bf8, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1007_7bfc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7bff, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_7c03, 2); if(jzd(0x1007_7c31, 0x2c)) goto l_0x1007_7c31; /* jz 0x10077c31 */
            ii(0x1007_7c05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_7c08, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_7c0c, 2); if(jnzd(0x1007_7c2f, 0x21)) goto l_0x1007_7c2f; /* jnz 0x10077c2f */
            ii(0x1007_7c0e, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1007_7c13, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_7c16, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c19, 5); calld(0x1015_c75a, 0xe_4b3c);           /* call 0x1015c75a */
            ii(0x1007_7c1e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_7c21, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1007_7c26, 5); calld(0x1007_5fdc, -0x1c4f);            /* call 0x10075fdc */
            ii(0x1007_7c2b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_7c2d, 2); if(jged(0x1007_7c31, 0x2)) goto l_0x1007_7c31; /* jge 0x10077c31 */
        l_0x1007_7c2f:
            ii(0x1007_7c2f, 2); jmpd(0x1007_7c33, 0x2); goto l_0x1007_7c33; /* jmp 0x10077c33 */
        l_0x1007_7c31:
            ii(0x1007_7c31, 2); jmpd(0x1007_7c44, 0x11); goto l_0x1007_7c44; /* jmp 0x10077c44 */
        l_0x1007_7c33:
            ii(0x1007_7c33, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_7c35, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x1007_7c3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c3d, 5); calld(0x1016_3053, 0xe_b411);           /* call 0x10163053 */
            ii(0x1007_7c42, 2); jmpd(0x1007_7c53, 0xf); goto l_0x1007_7c53; /* jmp 0x10077c53 */
        l_0x1007_7c44:
            ii(0x1007_7c44, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_7c46, 5); mov(edx, 0x18);                         /* mov edx, 0x18 */
            ii(0x1007_7c4b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c4e, 5); calld(0x1016_3053, 0xe_b400);           /* call 0x10163053 */
        l_0x1007_7c53:
            ii(0x1007_7c53, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_7c57, 2); jmpd(0x1007_7c92, 0x39); goto l_0x1007_7c92; /* jmp 0x10077c92 */
        l_0x1007_7c59:
            ii(0x1007_7c59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c5c, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1007_7c5f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7c64, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7c66, 2); if(jled(0x1007_7c71, 0x9)) goto l_0x1007_7c71; /* jle 0x10077c71 */
            ii(0x1007_7c68, 9); mov(memw_a32[ds, 0x101c_31c0], 0x2);    /* mov word [0x101c31c0], 0x2 */
        l_0x1007_7c71:
            ii(0x1007_7c71, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_7c74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c77, 5); calld(0x1007_60ac, -0x1bd0);            /* call 0x100760ac */
            ii(0x1007_7c7c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_7c81, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1007_7c86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_7c89, 5); calld(0x1016_3053, 0xe_b3c5);           /* call 0x10163053 */
            ii(0x1007_7c8e, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x1007_7c92:
            ii(0x1007_7c92, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_7c95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_7c97, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_7c98, 1); popd(edi);                              /* pop edi */
            ii(0x1007_7c99, 1); popd(esi);                              /* pop esi */
            ii(0x1007_7c9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_7c9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_7c9c, 1); retd(); return;                         /* ret */
        }
    }
}
