using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2c3a-cdc4bc7b")]
        public void Method_1007_2c3a()
        {
            ii(0x1007_2c3a, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1007_2c3f, 5); calld(Definitions.sys_check_available_stack_size, 0xf_310e); /* call 0x10165d52 */
            ii(0x1007_2c44, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2c45, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2c46, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2c47, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2c48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2c4a, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_2c50, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_2c53, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1007_2c56, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_2c59, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_2c5d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2c60, 5); calld(0x1007_64fc, 0x3897);             /* call 0x100764fc */
            ii(0x1007_2c65, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_2c68, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_2c6c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2c6f, 5); calld(0x1007_26dd, -0x597);             /* call 0x100726dd */
            ii(0x1007_2c74, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_2c77, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_2c7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_2c7d, 2); if(jld(0x1007_2ca0, 0x21)) goto l_0x1007_2ca0; /* jl 0x10072ca0 */
            ii(0x1007_2c7f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_2c82, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_2c86, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2c89, 6); mov(eax, memd_a32[ds, eax + 0x101b_77a0]); /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2c8f, 5); calld(0x1007_62cc, 0x3638);             /* call 0x100762cc */
            ii(0x1007_2c94, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2c96, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2c99, 5); calld(0x1007_643c, 0x379e);             /* call 0x1007643c */
            ii(0x1007_2c9e, 2); jmpd(0x1007_2cee, 0x4e); goto l_0x1007_2cee; /* jmp 0x10072cee */
        l_0x1007_2ca0:
            ii(0x1007_2ca0, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_2ca4, 2); if(jzd(0x1007_2ccb, 0x25)) goto l_0x1007_2ccb; /* jz 0x10072ccb */
            ii(0x1007_2ca6, 7); mov(memd_a32[ss, ebp - 0x1c], 0x4);     /* mov dword [ebp-0x1c], 0x4 */
            ii(0x1007_2cad, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_2cb1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2cb4, 6); mov(eax, memd_a32[ds, eax + 0x101b_77a0]); /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2cba, 5); calld(0x1007_6304, 0x3645);             /* call 0x10076304 */
            ii(0x1007_2cbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2cc1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2cc4, 5); calld(0x1007_643c, 0x3773);             /* call 0x1007643c */
            ii(0x1007_2cc9, 2); jmpd(0x1007_2cee, 0x23); goto l_0x1007_2cee; /* jmp 0x10072cee */
        l_0x1007_2ccb:
            ii(0x1007_2ccb, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_2cd2, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_2cd6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2cd9, 6); mov(eax, memd_a32[ds, eax + 0x101b_77a0]); /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2cdf, 5); calld(0x1007_6338, 0x3654);             /* call 0x10076338 */
            ii(0x1007_2ce4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2ce6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2ce9, 5); calld(0x1007_643c, 0x374e);             /* call 0x1007643c */
        l_0x1007_2cee:
            ii(0x1007_2cee, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_2cf1, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_2cf4, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_2cf8, 6); if(jzd(0x1007_2dad, 0xaf)) goto l_0x1007_2dad; /* jz 0x10072dad */
        l_0x1007_2cfe:
            ii(0x1007_2cfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2d00, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d03, 5); calld(0x1013_ad71, 0xc_8069);           /* call 0x1013ad71 */
            ii(0x1007_2d08, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2d0a, 2); if(jzd(0x1007_2d14, 0x8)) goto l_0x1007_2d14; /* jz 0x10072d14 */
            ii(0x1007_2d0c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d0f, 5); calld(0x1007_6bf8, 0x3ee4);             /* call 0x10076bf8 */
        l_0x1007_2d14:
            ii(0x1007_2d14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2d16, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d19, 5); calld(0x1013_ad11, 0xc_7ff3);           /* call 0x1013ad11 */
            ii(0x1007_2d1e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2d20, 2); if(jzd(0x1007_2d5c, 0x3a)) goto l_0x1007_2d5c; /* jz 0x10072d5c */
            ii(0x1007_2d22, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x1007_2d25, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1007_2d29, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1007_2d2c, 2); if(jnzd(0x1007_2d35, 0x7)) goto l_0x1007_2d35; /* jnz 0x10072d35 */
            ii(0x1007_2d2e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1007_2d35:
            ii(0x1007_2d35, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1007_2d39, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2d3c, 6); mov(eax, memd_a32[ds, eax + 0x101b_77a0]); /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2d42, 5); calld(0x1007_6338, 0x35f1);             /* call 0x10076338 */
            ii(0x1007_2d47, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2d49, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d4c, 5); calld(0x1007_643c, 0x36eb);             /* call 0x1007643c */
            ii(0x1007_2d51, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_2d54, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1007_2d58, 2); if(jzd(0x1007_2d5c, 0x2)) goto l_0x1007_2d5c; /* jz 0x10072d5c */
            ii(0x1007_2d5a, 2); jmpd(0x1007_2d14, -0x48); goto l_0x1007_2d14; /* jmp 0x10072d14 */
        l_0x1007_2d5c:
            ii(0x1007_2d5c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2d5e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d61, 5); calld(0x1013_ad71, 0xc_800b);           /* call 0x1013ad71 */
            ii(0x1007_2d66, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2d68, 2); if(jzd(0x1007_2d77, 0xd)) goto l_0x1007_2d77; /* jz 0x10072d77 */
            ii(0x1007_2d6a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d6d, 5); calld(0x1007_6408, 0x3696);             /* call 0x10076408 */
            ii(0x1007_2d72, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1007_2d75, 2); if(jnzd(0x1007_2d79, 0x2)) goto l_0x1007_2d79; /* jnz 0x10072d79 */
        l_0x1007_2d77:
            ii(0x1007_2d77, 2); jmpd(0x1007_2da1, 0x28); goto l_0x1007_2da1; /* jmp 0x10072da1 */
        l_0x1007_2d79:
            ii(0x1007_2d79, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d7c, 5); calld(0x1007_63a0, 0x361f);             /* call 0x100763a0 */
            ii(0x1007_2d81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2d83, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_2d86, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2d8a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_2d8c, 2); if(jnzd(0x1007_2d9f, 0x11)) goto l_0x1007_2d9f; /* jnz 0x10072d9f */
            ii(0x1007_2d8e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2d91, 5); calld(0x1007_636c, 0x35d6);             /* call 0x1007636c */
            ii(0x1007_2d96, 5); calld(0x1007_2ae2, -0x2b9);             /* call 0x10072ae2 */
            ii(0x1007_2d9b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2d9d, 2); if(jnzd(0x1007_2da1, 0x2)) goto l_0x1007_2da1; /* jnz 0x10072da1 */
        l_0x1007_2d9f:
            ii(0x1007_2d9f, 2); jmpd(0x1007_2da3, 0x2); goto l_0x1007_2da3; /* jmp 0x10072da3 */
        l_0x1007_2da1:
            ii(0x1007_2da1, 2); jmpd(0x1007_2da8, 0x5); goto l_0x1007_2da8; /* jmp 0x10072da8 */
        l_0x1007_2da3:
            ii(0x1007_2da3, 5); jmpd(0x1007_2cfe, -0xaa); goto l_0x1007_2cfe; /* jmp 0x10072cfe */
        l_0x1007_2da8:
            ii(0x1007_2da8, 5); jmpd(0x1007_2e57, 0xaa); goto l_0x1007_2e57; /* jmp 0x10072e57 */
        l_0x1007_2dad:
            ii(0x1007_2dad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2daf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2db2, 5); calld(0x1013_ad71, 0xc_7fba);           /* call 0x1013ad71 */
            ii(0x1007_2db7, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2db9, 2); if(jzd(0x1007_2dc3, 0x8)) goto l_0x1007_2dc3; /* jz 0x10072dc3 */
            ii(0x1007_2dbb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2dbe, 5); calld(0x1007_6bc0, 0x3dfd);             /* call 0x10076bc0 */
        l_0x1007_2dc3:
            ii(0x1007_2dc3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2dc5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2dc8, 5); calld(0x1013_ad11, 0xc_7f44);           /* call 0x1013ad11 */
            ii(0x1007_2dcd, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2dcf, 2); if(jzd(0x1007_2e0b, 0x3a)) goto l_0x1007_2e0b; /* jz 0x10072e0b */
            ii(0x1007_2dd1, 4); add(memd_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* add dword [ebp-0x20], 0xffffffff */
            ii(0x1007_2dd5, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1007_2dd9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_2ddb, 2); if(jged(0x1007_2de4, 0x7)) goto l_0x1007_2de4; /* jge 0x10072de4 */
            ii(0x1007_2ddd, 7); mov(memd_a32[ss, ebp - 0x20], 0x4);     /* mov dword [ebp-0x20], 0x4 */
        l_0x1007_2de4:
            ii(0x1007_2de4, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1007_2de8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2deb, 6); mov(eax, memd_a32[ds, eax + 0x101b_77a0]); /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2df1, 5); calld(0x1007_6304, 0x350e);             /* call 0x10076304 */
            ii(0x1007_2df6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2df8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2dfb, 5); calld(0x1007_643c, 0x363c);             /* call 0x1007643c */
            ii(0x1007_2e00, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_2e03, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1007_2e07, 2); if(jzd(0x1007_2e0b, 0x2)) goto l_0x1007_2e0b; /* jz 0x10072e0b */
            ii(0x1007_2e09, 2); jmpd(0x1007_2dc3, -0x48); goto l_0x1007_2dc3; /* jmp 0x10072dc3 */
        l_0x1007_2e0b:
            ii(0x1007_2e0b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2e0d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e10, 5); calld(0x1013_ad71, 0xc_7f5c);           /* call 0x1013ad71 */
            ii(0x1007_2e15, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2e17, 2); if(jzd(0x1007_2e26, 0xd)) goto l_0x1007_2e26; /* jz 0x10072e26 */
            ii(0x1007_2e19, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e1c, 5); calld(0x1007_6408, 0x35e7);             /* call 0x10076408 */
            ii(0x1007_2e21, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1007_2e24, 2); if(jnzd(0x1007_2e28, 0x2)) goto l_0x1007_2e28; /* jnz 0x10072e28 */
        l_0x1007_2e26:
            ii(0x1007_2e26, 2); jmpd(0x1007_2e50, 0x28); goto l_0x1007_2e50; /* jmp 0x10072e50 */
        l_0x1007_2e28:
            ii(0x1007_2e28, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e2b, 5); calld(0x1007_63a0, 0x3570);             /* call 0x100763a0 */
            ii(0x1007_2e30, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2e32, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_2e35, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2e39, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_2e3b, 2); if(jnzd(0x1007_2e4e, 0x11)) goto l_0x1007_2e4e; /* jnz 0x10072e4e */
            ii(0x1007_2e3d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e40, 5); calld(0x1007_636c, 0x3527);             /* call 0x1007636c */
            ii(0x1007_2e45, 5); calld(0x1007_2ae2, -0x368);             /* call 0x10072ae2 */
            ii(0x1007_2e4a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2e4c, 2); if(jnzd(0x1007_2e50, 0x2)) goto l_0x1007_2e50; /* jnz 0x10072e50 */
        l_0x1007_2e4e:
            ii(0x1007_2e4e, 2); jmpd(0x1007_2e52, 0x2); goto l_0x1007_2e52; /* jmp 0x10072e52 */
        l_0x1007_2e50:
            ii(0x1007_2e50, 2); jmpd(0x1007_2e57, 0x5); goto l_0x1007_2e57; /* jmp 0x10072e57 */
        l_0x1007_2e52:
            ii(0x1007_2e52, 5); jmpd(0x1007_2dad, -0xaa); goto l_0x1007_2dad; /* jmp 0x10072dad */
        l_0x1007_2e57:
            ii(0x1007_2e57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2e59, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e5c, 5); calld(0x1013_ad11, 0xc_7eb0);           /* call 0x1013ad11 */
            ii(0x1007_2e61, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2e63, 2); if(jnzd(0x1007_2e76, 0x11)) goto l_0x1007_2e76; /* jnz 0x10072e76 */
            ii(0x1007_2e65, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e68, 5); calld(0x1007_636c, 0x34ff);             /* call 0x1007636c */
            ii(0x1007_2e6d, 5); calld(0x1007_2ae2, -0x390);             /* call 0x10072ae2 */
            ii(0x1007_2e72, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2e74, 2); if(jnzd(0x1007_2e89, 0x13)) goto l_0x1007_2e89; /* jnz 0x10072e89 */
        l_0x1007_2e76:
            ii(0x1007_2e76, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_2e7d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2e7f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e82, 5); calld(0x1007_5f6c, 0x30e5);             /* call 0x10075f6c */
            ii(0x1007_2e87, 2); jmpd(0x1007_2eaa, 0x21); goto l_0x1007_2eaa; /* jmp 0x10072eaa */
        l_0x1007_2e89:
            ii(0x1007_2e89, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e8c, 5); calld(0x1007_6408, 0x3577);             /* call 0x10076408 */
            ii(0x1007_2e91, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_2e94, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2e96, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_2e99, 5); calld(0x1007_5f6c, 0x30ce);             /* call 0x10075f6c */
            ii(0x1007_2e9e, 2); jmpd(0x1007_2eaa, 0xa); goto l_0x1007_2eaa; /* jmp 0x10072eaa */
        //  ii(0x1007_2ea0, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_2ea2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_2ea5, 5); calld(0x1007_5f6c, 0x30c2);             /* call 0x10075f6c */
        l_0x1007_2eaa:
            ii(0x1007_2eaa, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_2ead, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_2eaf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_2eb0, 1); popd(edi);                              /* pop edi */
            ii(0x1007_2eb1, 1); popd(esi);                              /* pop esi */
            ii(0x1007_2eb2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2eb3, 1); retd();                                 /* ret */
        }
    }
}
