using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_6a12-90ffb598")]
        public void Method_1009_6a12()
        {
            ii(0x1009_6a12, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1009_6a17, 5); calld(Definitions.sys_check_available_stack_size, 0xc_f336); /* call 0x10165d52 */
            ii(0x1009_6a1c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_6a1d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_6a1e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_6a1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_6a20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6a22, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1009_6a28, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_6a2b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_6a2e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_6a31, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x1009_6a35, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6a38, 5); calld(0x1008_bbed, -0xae50);            /* call 0x1008bbed */
            ii(0x1009_6a3d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_6a40, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x1009_6a44, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_6a47, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6a4a, 5); calld(0x1008_a6f8, -0xc357);            /* call 0x1008a6f8 */
            ii(0x1009_6a4f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6a51, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_6a54, 5); calld(0x1009_6666, -0x3f3);             /* call 0x10096666 */
            ii(0x1009_6a59, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6a5b, 2); if(jnzd(0x1009_6a70, 0x13)) goto l_0x1009_6a70; /* jnz 0x10096a70 */
            ii(0x1009_6a5d, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6a61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6a63, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6a66, 5); calld(0x1008_bc9f, -0xadcc);            /* call 0x1008bc9f */
            ii(0x1009_6a6b, 5); jmpd(0x1009_6b80, 0x110); goto l_0x1009_6b80; /* jmp 0x10096b80 */
        l_0x1009_6a70:
            ii(0x1009_6a70, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_6a73, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_ff88); /* call 0x10076af0 */
            ii(0x1009_6a78, 5); calld(0x100e_a7e7, 0x5_3d6a);           /* call 0x100ea7e7 */
            ii(0x1009_6a7d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_6a81, 6); mov(memw_a32[ss, ebp - 0x24], 0x1);     /* mov word [ebp-0x24], 0x1 */
            ii(0x1009_6a87, 2); jmpd(0x1009_6a90, 0x7); goto l_0x1009_6a90; /* jmp 0x10096a90 */
        l_0x1009_6a89:
            ii(0x1009_6a89, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_6a8c, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x1009_6a90:
            ii(0x1009_6a90, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_6a95, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_6a98, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_6a9c, 1); dec(eax);                               /* dec eax */
            ii(0x1009_6a9d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_6a9f, 6); if(jged(0x1009_6b64, 0xbf)) goto l_0x1009_6b64; /* jge 0x10096b64 */
            ii(0x1009_6aa5, 6); mov(memw_a32[ss, ebp - 0x22], 0x1);     /* mov word [ebp-0x22], 0x1 */
            ii(0x1009_6aab, 2); jmpd(0x1009_6ab4, 0x7); goto l_0x1009_6ab4; /* jmp 0x10096ab4 */
        l_0x1009_6aad:
            ii(0x1009_6aad, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x1009_6ab0, 4); inc(memw_a32[ss, ebp - 0x22]);          /* inc word [ebp-0x22] */
        l_0x1009_6ab4:
            ii(0x1009_6ab4, 4); movsx(edx, memw_a32[ss, ebp - 0x22]);   /* movsx edx, word [ebp-0x22] */
            ii(0x1009_6ab8, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_6abd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_6ac0, 1); dec(eax);                               /* dec eax */
            ii(0x1009_6ac1, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_6ac3, 6); if(jged(0x1009_6b5f, 0x96)) goto l_0x1009_6b5f; /* jge 0x10096b5f */
            ii(0x1009_6ac9, 4); movsx(ebx, memw_a32[ss, ebp - 0x22]);   /* movsx ebx, word [ebp-0x22] */
            ii(0x1009_6acd, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_6ad1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6ad4, 5); calld(0x1008_a728, -0xc3b1);            /* call 0x1008a728 */
            ii(0x1009_6ad9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_6adb, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_6add, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_6ae2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_6ae4, 2); if(jzd(0x1009_6b5a, 0x74)) goto l_0x1009_6b5a; /* jz 0x10096b5a */
            ii(0x1009_6ae6, 4); movsx(ebx, memw_a32[ss, ebp - 0x22]);   /* movsx ebx, word [ebp-0x22] */
            ii(0x1009_6aea, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_6aee, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6af1, 5); calld(0x1008_a728, -0xc3ce);            /* call 0x1008a728 */
            ii(0x1009_6af6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_6af8, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_6afa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_6aff, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1009_6b04, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1009_6b06, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1009_6b09, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_6b0c, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1009_6b0f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_6b12, 5); calld(0x1007_5e64, -0x2_0cb3);          /* call 0x10075e64 */
            ii(0x1009_6b17, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_6b19, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_6b1c, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6b1f, 5); calld(0x1007_5e64, -0x2_0cc0);          /* call 0x10075e64 */
            ii(0x1009_6b24, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_6b26, 5); calld(0x100a_5fca, 0xf49f);             /* call 0x100a5fca */
            ii(0x1009_6b2b, 1); cwde();                                 /* cwde */
            ii(0x1009_6b2c, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1009_6b2f, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1009_6b32, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_6b34, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1009_6b37, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1009_6b3b, 2); if(jzd(0x1009_6b45, 0x8)) goto l_0x1009_6b45; /* jz 0x10096b45 */
            ii(0x1009_6b3d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_6b40, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x1009_6b43, 2); if(jged(0x1009_6b5a, 0x15)) goto l_0x1009_6b5a; /* jge 0x10096b5a */
        l_0x1009_6b45:
            ii(0x1009_6b45, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_6b48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_6b4b, 5); calld(0x1008_8b44, -0xe00c);            /* call 0x10088b44 */
            ii(0x1009_6b50, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_6b54, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_6b57, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1009_6b5a:
            ii(0x1009_6b5a, 5); jmpd(0x1009_6aad, -0xb2); goto l_0x1009_6aad; /* jmp 0x10096aad */
        l_0x1009_6b5f:
            ii(0x1009_6b5f, 5); jmpd(0x1009_6a89, -0xdb); goto l_0x1009_6a89; /* jmp 0x10096a89 */
        l_0x1009_6b64:
            ii(0x1009_6b64, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_6b67, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1009_6b6a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6b6c, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_6b6f, 5); calld(0x1008_bc9f, -0xaed5);            /* call 0x1008bc9f */
            ii(0x1009_6b74, 2); jmpd(0x1009_6b80, 0xa); goto l_0x1009_6b80; /* jmp 0x10096b80 */
        //  ii(0x1009_6b76, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_6b78, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
        //  ii(0x1009_6b7b, 5); calld(0x1008_bc9f, -0xaee1);            /* call 0x1008bc9f */
        l_0x1009_6b80:
            ii(0x1009_6b80, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_6b83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_6b85, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_6b86, 1); popd(edi);                              /* pop edi */
            ii(0x1009_6b87, 1); popd(esi);                              /* pop esi */
            ii(0x1009_6b88, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_6b89, 1); retd(); return;                         /* ret */
        }
    }
}
