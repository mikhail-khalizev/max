using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_0c2f-10515d03")]
        public void Method_100c_0c2f()
        {
            ii(0x100c_0c2f, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100c_0c34, 5); calld(Definitions.sys_check_available_stack_size, 0xa_5119); /* call 0x10165d52 */
            ii(0x100c_0c39, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_0c3a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_0c3b, 1); pushd(esi);                             /* push esi */
            ii(0x100c_0c3c, 1); pushd(edi);                             /* push edi */
            ii(0x100c_0c3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_0c3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0c40, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_0c46, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_0c49, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_0c4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_0c4f, 5); calld(0x1007_6338, -0x4_a91c);          /* call 0x10076338 */
            ii(0x100c_0c54, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0c56, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0c59, 5); calld(0x1007_64b8, -0x4_a7a6);          /* call 0x100764b8 */
            ii(0x100c_0c5e, 2); jmpd(0x100c_0c68, 0x8); goto l_0x100c_0c68; /* jmp 0x100c0c68 */
        l_0x100c_0c60:
            ii(0x100c_0c60, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0c63, 5); calld(0x1007_6bf8, -0x4_a070);          /* call 0x10076bf8 */
        l_0x100c_0c68:
            ii(0x100c_0c68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_0c6a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0c6d, 5); calld(0x1013_ad71, 0x7_a0ff);           /* call 0x1013ad71 */
            ii(0x100c_0c72, 2); test(al, al);                           /* test al, al */
            ii(0x100c_0c74, 6); if(jzd(0x100c_0d4a, 0xd0)) goto l_0x100c_0d4a; /* jz 0x100c0d4a */
            ii(0x100c_0c7a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0c7d, 5); calld(0x1007_63a0, -0x4_a8e2);          /* call 0x100763a0 */
            ii(0x100c_0c82, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100c_0c85, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0c8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0c8c, 2); if(jled(0x100c_0c9c, 0xe)) goto l_0x100c_0c9c; /* jle 0x100c0c9c */
            ii(0x100c_0c8e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0c91, 5); calld(0x1007_63a0, -0x4_a8f6);          /* call 0x100763a0 */
            ii(0x100c_0c96, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_0c9a, 2); if(jnzd(0x100c_0c9e, 0x2)) goto l_0x100c_0c9e; /* jnz 0x100c0c9e */
        l_0x100c_0c9c:
            ii(0x100c_0c9c, 2); jmpd(0x100c_0cac, 0xe); goto l_0x100c_0cac; /* jmp 0x100c0cac */
        l_0x100c_0c9e:
            ii(0x100c_0c9e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0ca1, 5); calld(0x1007_63a0, -0x4_a906);          /* call 0x100763a0 */
            ii(0x100c_0ca6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_0caa, 2); if(jnzd(0x100c_0cb1, 0x5)) goto l_0x100c_0cb1; /* jnz 0x100c0cb1 */
        l_0x100c_0cac:
            ii(0x100c_0cac, 5); jmpd(0x100c_0d45, 0x94); goto l_0x100c_0d45; /* jmp 0x100c0d45 */
        l_0x100c_0cb1:
            ii(0x100c_0cb1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0cb4, 5); calld(0x1007_63a0, -0x4_a919);          /* call 0x100763a0 */
            ii(0x100c_0cb9, 5); calld(0x1007_623c, -0x4_aa82);          /* call 0x1007623c */
            ii(0x100c_0cbe, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100c_0cc2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_0cc5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0cc8, 5); calld(0x1007_63a0, -0x4_a92d);          /* call 0x100763a0 */
            ii(0x100c_0ccd, 5); calld(0x1007_623c, -0x4_aa96);          /* call 0x1007623c */
            ii(0x100c_0cd2, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x100c_0cd6, 2); if(jnzd(0x100c_0cdc, 0x4)) goto l_0x100c_0cdc; /* jnz 0x100c0cdc */
            ii(0x100c_0cd8, 4); add(memd_a32[ss, ebp - 0x10], -0x3 /* 0xfd */); /* add dword [ebp-0x10], 0xfffffffd */
        l_0x100c_0cdc:
            ii(0x100c_0cdc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0cdf, 5); calld(0x1007_63a0, -0x4_a944);          /* call 0x100763a0 */
            ii(0x100c_0ce4, 5); calld(0x1007_623c, -0x4_aaad);          /* call 0x1007623c */
            ii(0x100c_0ce9, 4); mov(dx, memw_a32[ds, eax + 0xe]);       /* mov dx, [eax+0xe] */
            ii(0x100c_0ced, 2); neg(edx);                               /* neg edx */
            ii(0x100c_0cef, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0cf2, 5); calld(0x1007_63a0, -0x4_a957);          /* call 0x100763a0 */
            ii(0x100c_0cf7, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100c_0cfa, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_0cfc, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_0cff, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_0d02, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100c_0d06, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0d08, 2); if(jled(0x100c_0d45, 0x3b)) goto l_0x100c_0d45; /* jle 0x100c0d45 */
            ii(0x100c_0d0a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0d0c, 1); pushd(eax);                             /* push eax */
            ii(0x100c_0d0d, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x100c_0d11, 4); movsx(esi, memw_a32[ss, ebp - 0x10]);   /* movsx esi, word [ebp-0x10] */
            ii(0x100c_0d15, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0d18, 5); calld(0x1007_63a0, -0x4_a97d);          /* call 0x100763a0 */
            ii(0x100c_0d1d, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_0d20, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_0d23, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0d26, 5); calld(0x1007_63a0, -0x4_a98b);          /* call 0x100763a0 */
            ii(0x100c_0d2b, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_0d2e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_0d31, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_0d34, 5); calld(0x1007_6aac, -0x4_a28d);          /* call 0x10076aac */
            ii(0x100c_0d39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0d3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_0d3e, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100c_0d40, 5); calld(0x100c_093a, -0x40b);             /* call 0x100c093a */
        l_0x100c_0d45:
            ii(0x100c_0d45, 5); jmpd(0x100c_0c60, -0xea); goto l_0x100c_0c60; /* jmp 0x100c0c60 */
        l_0x100c_0d4a:
            ii(0x100c_0d4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_0d4c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_0d4f, 5); calld(0x1007_5f6c, -0x4_ade8);          /* call 0x10075f6c */
            ii(0x100c_0d54, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_0d56, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_0d57, 1); popd(edi);                              /* pop edi */
            ii(0x100c_0d58, 1); popd(esi);                              /* pop esi */
            ii(0x100c_0d59, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_0d5a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_0d5b, 1); retd();                                 /* ret */
        }
    }
}
