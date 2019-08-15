using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb2a2752-0124-4542-8894-bc0e1d88a9b9")]
        public void Method_1015_4b8b()
        {
            ii(0x1015_4b8b, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1015_4b90, 5); calld(Definitions.sys_check_available_stack_size, 0x1_11bd); /* call 0x10165d52 */
            ii(0x1015_4b95, 1); pushd(esi);                             /* push esi */
            ii(0x1015_4b96, 1); pushd(edi);                             /* push edi */
            ii(0x1015_4b97, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_4b98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_4b9a, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1015_4ba0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_4ba3, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_4ba6, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1015_4ba9, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1015_4bac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4baf, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1015_4bb3, 2); if(jzd(0x1015_4bbe, 0x9)) goto l_0x1015_4bbe; /* jz 0x10154bbe */
            ii(0x1015_4bb5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4bb8, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_4bbc, 2); if(jnzd(0x1015_4bc0, 0x2)) goto l_0x1015_4bc0; /* jnz 0x10154bc0 */
        l_0x1015_4bbe:
            ii(0x1015_4bbe, 2); jmpd(0x1015_4bc9, 0x9); goto l_0x1015_4bc9; /* jmp 0x10154bc9 */
        l_0x1015_4bc0:
            ii(0x1015_4bc0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4bc3, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_4bc7, 2); if(jnzd(0x1015_4bcb, 0x2)) goto l_0x1015_4bcb; /* jnz 0x10154bcb */
        l_0x1015_4bc9:
            ii(0x1015_4bc9, 2); jmpd(0x1015_4bd4, 0x9); goto l_0x1015_4bd4; /* jmp 0x10154bd4 */
        l_0x1015_4bcb:
            ii(0x1015_4bcb, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1015_4bcf, 5); jmpd(0x1015_4f7f, 0x3ab); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        l_0x1015_4bd4:
            ii(0x1015_4bd4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4bd7, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1015_4bda, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4bdf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4be1, 2); if(jnzd(0x1015_4c04, 0x21)) goto l_0x1015_4c04; /* jnz 0x10154c04 */
            ii(0x1015_4be3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4be6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_4be9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4bee, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4bf4, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_4bfa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4bff, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_4c02, 2); if(jnzd(0x1015_4c06, 0x2)) goto l_0x1015_4c06; /* jnz 0x10154c06 */
        l_0x1015_4c04:
            ii(0x1015_4c04, 2); jmpd(0x1015_4c0f, 0x9); goto l_0x1015_4c0f; /* jmp 0x10154c0f */
        l_0x1015_4c06:
            ii(0x1015_4c06, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1015_4c0a, 5); jmpd(0x1015_4f7f, 0x370); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        l_0x1015_4c0f:
            ii(0x1015_4c0f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c12, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_4c16, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1015_4c1a, 2); if(jnzd(0x1015_4c29, 0xd)) goto l_0x1015_4c29; /* jnz 0x10154c29 */
            ii(0x1015_4c1c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c1f, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_4c23, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1015_4c27, 2); if(jzd(0x1015_4c8c, 0x63)) goto l_0x1015_4c8c; /* jz 0x10154c8c */
        l_0x1015_4c29:
            ii(0x1015_4c29, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c2c, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_4c30, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_4c33, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c36, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_4c3a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1015_4c3d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_4c40, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4c43, 4); mov(memw_a32[ds, edx + 0x1a], ax);      /* mov [edx+0x1a], ax */
            ii(0x1015_4c47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_4c4a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4c4d, 4); mov(memw_a32[ds, edx + 0x1c], ax);      /* mov [edx+0x1c], ax */
            ii(0x1015_4c51, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4c54, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_4c59, 5); calld(0x1010_3752, -0x5_150c);          /* call 0x10103752 */
            ii(0x1015_4c5e, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_4c61, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4c64, 4); mov(memw_a32[ds, edx + 0x1a], ax);      /* mov [edx+0x1a], ax */
            ii(0x1015_4c68, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1015_4c6b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4c6e, 4); mov(memw_a32[ds, edx + 0x1c], ax);      /* mov [edx+0x1c], ax */
            ii(0x1015_4c72, 5); calld(0x1012_0a90, -0x3_41e7);          /* call 0x10120a90 */
            ii(0x1015_4c77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4c79, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_4c7b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c7e, 5); calld(0x1014_f017, -0x5c6c);            /* call 0x1014f017 */
            ii(0x1015_4c83, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1015_4c87, 5); jmpd(0x1015_4f7f, 0x2f3); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        l_0x1015_4c8c:
            ii(0x1015_4c8c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c8f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_4c93, 2); if(jnzd(0x1015_4ca9, 0x14)) goto l_0x1015_4ca9; /* jnz 0x10154ca9 */
            ii(0x1015_4c95, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4c98, 4); cmp(memb_a32[ds, eax + 0x3e], 0x6);     /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1015_4c9c, 2); if(jzd(0x1015_4ca7, 0x9)) goto l_0x1015_4ca7; /* jz 0x10154ca7 */
            ii(0x1015_4c9e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4ca1, 4); cmp(memb_a32[ds, eax + 0x3e], 0x5);     /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1015_4ca5, 2); if(jnzd(0x1015_4ca9, 0x2)) goto l_0x1015_4ca9; /* jnz 0x10154ca9 */
        l_0x1015_4ca7:
            ii(0x1015_4ca7, 2); jmpd(0x1015_4cab, 0x2); goto l_0x1015_4cab; /* jmp 0x10154cab */
        l_0x1015_4ca9:
            ii(0x1015_4ca9, 2); jmpd(0x1015_4cb4, 0x9); goto l_0x1015_4cb4; /* jmp 0x10154cb4 */
        l_0x1015_4cab:
            ii(0x1015_4cab, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1015_4caf, 5); jmpd(0x1015_4f7f, 0x2cb); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        l_0x1015_4cb4:
            ii(0x1015_4cb4, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1015_4cb7, 5); calld(Definitions.my_ctor_0x101b4184, -0xd_e1cc); /* call 0x10076af0 */
            ii(0x1015_4cbc, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_4cbf, 5); calld(Definitions.my_ctor_0x101b4184, -0xd_e1d4); /* call 0x10076af0 */
            ii(0x1015_4cc4, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1015_4ccb, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1015_4cd2, 2); jmpd(0x1015_4cda, 0x6); goto l_0x1015_4cda; /* jmp 0x10154cda */
        l_0x1015_4cd4:
            ii(0x1015_4cd4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_4cd7, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1015_4cda:
            ii(0x1015_4cda, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_4cde, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1015_4ce1, 6); if(jged(0x1015_4e29, 0x142)) goto l_0x1015_4e29; /* jge 0x10154e29 */
            ii(0x1015_4ce7, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1015_4cee, 2); jmpd(0x1015_4cf6, 0x6); goto l_0x1015_4cf6; /* jmp 0x10154cf6 */
        l_0x1015_4cf0:
            ii(0x1015_4cf0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_4cf3, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
        l_0x1015_4cf6:
            ii(0x1015_4cf6, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1015_4cfa, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_4cfd, 6); if(jged(0x1015_4e24, 0x121)) goto l_0x1015_4e24; /* jge 0x10154e24 */
            ii(0x1015_4d03, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_4d07, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_4d0a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4d0d, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_4d11, 7); add(ax, memw_a32[ds, edx + 0x101c_5348]); /* add ax, [edx+0x101c5348] */
            ii(0x1015_4d18, 4); mov(memw_a32[ss, ebp - 0x38], ax);      /* mov [ebp-0x38], ax */
            ii(0x1015_4d1c, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_4d20, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_4d23, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4d26, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_4d2a, 7); add(ax, memw_a32[ds, edx + 0x101c_534a]); /* add ax, [edx+0x101c534a] */
            ii(0x1015_4d31, 4); mov(memw_a32[ss, ebp - 0x36], ax);      /* mov [ebp-0x36], ax */
            ii(0x1015_4d35, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_4d38, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1015_4d3b, 5); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_4d40, 5); and(eax, 0x3);                          /* and eax, 0x3 */
            ii(0x1015_4d45, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_4d48, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_4d4c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_4d4f, 2); if(jled(0x1015_4d5c, 0xb)) goto l_0x1015_4d5c; /* jle 0x10154d5c */
            ii(0x1015_4d51, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1015_4d56, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1015_4d59, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1015_4d5c:
            ii(0x1015_4d5c, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_4d60, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4d62, 2); if(jzd(0x1015_4d71, 0xd)) goto l_0x1015_4d71; /* jz 0x10154d71 */
            ii(0x1015_4d64, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_4d67, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x1015_4d6b, 6); if(jled(0x1015_4e1f, 0xae)) goto l_0x1015_4e1f; /* jle 0x10154e1f */
        l_0x1015_4d71:
            ii(0x1015_4d71, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_4d76, 1); pushd(eax);                             /* push eax */
            ii(0x1015_4d77, 4); movsx(ecx, memw_a32[ss, ebp - 0x36]);   /* movsx ecx, word [ebp-0x36] */
            ii(0x1015_4d7b, 4); movsx(ebx, memw_a32[ss, ebp - 0x38]);   /* movsx ebx, word [ebp-0x38] */
            ii(0x1015_4d7f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4d82, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_4d85, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_4d87, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4d8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4d8d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_4d90, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_4d93, 5); calld(0x1007_02b9, -0xe_4adf);          /* call 0x100702b9 */
            ii(0x1015_4d98, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_4d9b, 6); test(memw_a32[ss, ebp - 0x20], 0x1);    /* test word [ebp-0x20], 0x1 */
            ii(0x1015_4da1, 2); if(jzd(0x1015_4db6, 0x13)) goto l_0x1015_4db6; /* jz 0x10154db6 */
            ii(0x1015_4da3, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_4da7, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1015_4daa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_4dac, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_4daf, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_4db1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1015_4db3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1015_4db6:
            ii(0x1015_4db6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_4dba, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4dbc, 2); if(jzd(0x1015_4e06, 0x48)) goto l_0x1015_4e06; /* jz 0x10154e06 */
            ii(0x1015_4dbe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4dc1, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1015_4dc4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4dc9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_4dcc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_4dce, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4dd1, 3); mov(al, memb_a32[ds, eax + 0x64]);      /* mov al, [eax+0x64] */
            ii(0x1015_4dd4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4dd9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_4ddb, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1015_4ddf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_4de1, 2); if(jled(0x1015_4e04, 0x21)) goto l_0x1015_4e04; /* jle 0x10154e04 */
            ii(0x1015_4de3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4de6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_4de9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4dee, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4df4, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_4dfa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4dff, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_4e02, 2); if(jnzd(0x1015_4e06, 0x2)) goto l_0x1015_4e06; /* jnz 0x10154e06 */
        l_0x1015_4e04:
            ii(0x1015_4e04, 2); jmpd(0x1015_4e08, 0x2); goto l_0x1015_4e08; /* jmp 0x10154e08 */
        l_0x1015_4e06:
            ii(0x1015_4e06, 2); jmpd(0x1015_4e1f, 0x17); goto l_0x1015_4e1f; /* jmp 0x10154e1f */
        l_0x1015_4e08:
            ii(0x1015_4e08, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_4e0b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_4e0e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_4e11, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1015_4e14, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1015_4e17, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1015_4e1a, 5); calld(0x1008_8b44, -0xc_c2db);          /* call 0x10088b44 */
        l_0x1015_4e1f:
            ii(0x1015_4e1f, 5); jmpd(0x1015_4cf0, -0x134); goto l_0x1015_4cf0; /* jmp 0x10154cf0 */
        l_0x1015_4e24:
            ii(0x1015_4e24, 5); jmpd(0x1015_4cd4, -0x155); goto l_0x1015_4cd4; /* jmp 0x10154cd4 */
        l_0x1015_4e29:
            ii(0x1015_4e29, 5); cmp(memw_a32[ss, ebp - 0x2c], 0);       /* cmp word [ebp-0x2c], 0x0 */
            ii(0x1015_4e2e, 2); if(jnzd(0x1015_4e39, 0x9)) goto l_0x1015_4e39; /* jnz 0x10154e39 */
            ii(0x1015_4e30, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1015_4e34, 5); jmpd(0x1015_4f7f, 0x146); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        l_0x1015_4e39:
            ii(0x1015_4e39, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4e3c, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_4e3f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4e44, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4e4a, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_4e50, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4e55, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_4e58, 2); if(jnzd(0x1015_4e82, 0x28)) goto l_0x1015_4e82; /* jnz 0x10154e82 */
            ii(0x1015_4e5a, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1015_4e5e, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1015_4e61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_4e63, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_4e66, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_4e69, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1015_4e6b, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1015_4e6e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_4e71, 3); mov(dl, memb_a32[ds, edx + 0x4e]);      /* mov dl, [edx+0x4e] */
            ii(0x1015_4e74, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1015_4e7a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_4e7c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4e7f, 3); mov(memb_a32[ds, eax + 0x4e], dl);      /* mov [eax+0x4e], dl */
        l_0x1015_4e82:
            ii(0x1015_4e82, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4e85, 5); calld(0x1015_48ba, -0x5d0);             /* call 0x101548ba */
            ii(0x1015_4e8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4e8d, 5); calld(0x1015_24a1, -0x29f1);            /* call 0x101524a1 */
            ii(0x1015_4e92, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_4e94, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_4e99, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4e9c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4e9f, 5); calld(0x1007_6074, -0xd_ee30);          /* call 0x10076074 */
            ii(0x1015_4ea4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_4ea6, 2); if(jzd(0x1015_4ed2, 0x2a)) goto l_0x1015_4ed2; /* jz 0x10154ed2 */
            ii(0x1015_4ea8, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_4ead, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4eb0, 5); calld(0x1007_6d98, -0xd_e11d);          /* call 0x10076d98 */
            ii(0x1015_4eb5, 2); test(al, al);                           /* test al, al */
            ii(0x1015_4eb7, 2); if(jnzd(0x1015_4ec2, 0x9)) goto l_0x1015_4ec2; /* jnz 0x10154ec2 */
            ii(0x1015_4eb9, 7); cmp(memb_a32[ds, 0x101c_3889], 0);      /* cmp byte [0x101c3889], 0x0 */
            ii(0x1015_4ec0, 2); if(jzd(0x1015_4ec4, 0x2)) goto l_0x1015_4ec4; /* jz 0x10154ec4 */
        l_0x1015_4ec2:
            ii(0x1015_4ec2, 2); jmpd(0x1015_4ecd, 0x9); goto l_0x1015_4ecd; /* jmp 0x10154ecd */
        l_0x1015_4ec4:
            ii(0x1015_4ec4, 7); cmp(memb_a32[ds, 0x101c_388a], 0);      /* cmp byte [0x101c388a], 0x0 */
            ii(0x1015_4ecb, 2); if(jzd(0x1015_4ed2, 0x5)) goto l_0x1015_4ed2; /* jz 0x10154ed2 */
        l_0x1015_4ecd:
            ii(0x1015_4ecd, 5); calld(0x100f_f5c1, -0x5_5911);          /* call 0x100ff5c1 */
        l_0x1015_4ed2:
            ii(0x1015_4ed2, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1015_4ed7, 5); calld(Definitions.sys_new, 0x1_0f24);   /* call 0x10165e00 */
            ii(0x1015_4edc, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1015_4edf, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1015_4ee2, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1015_4ee5, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1015_4ee9, 2); if(jzd(0x1015_4f06, 0x1b)) goto l_0x1015_4f06; /* jz 0x10154f06 */
            ii(0x1015_4eeb, 4); movsx(ebx, memw_a32[ss, ebp - 0x3a]);   /* movsx ebx, word [ebp-0x3a] */
            ii(0x1015_4eef, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x1015_4ef3, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1015_4ef6, 5); calld(Definitions.my_ctor_c20, -0x3_afa5); /* call 0x10119f56 */
            ii(0x1015_4efb, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1015_4efe, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1015_4f01, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1015_4f04, 2); jmpd(0x1015_4f0c, 0x6); goto l_0x1015_4f0c; /* jmp 0x10154f0c */
        l_0x1015_4f06:
            ii(0x1015_4f06, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1015_4f09, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1015_4f0c:
            ii(0x1015_4f0c, 3); mov(edx, memd_a32[ss, ebp - 0x4c]);     /* mov edx, [ebp-0x4c] */
            ii(0x1015_4f0f, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1015_4f12, 5); calld(0x100a_b3b0, -0xa_9b67);          /* call 0x100ab3b0 */
            ii(0x1015_4f17, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4f1a, 3); mov(edx, memd_a32[ss, ebp - 0x3a]);     /* mov edx, [ebp-0x3a] */
            ii(0x1015_4f1d, 4); sub(dx, memw_a32[ds, eax + 0x1c]);      /* sub dx, [eax+0x1c] */
            ii(0x1015_4f21, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_4f23, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_4f26, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4f29, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1015_4f2c, 4); sub(dx, memw_a32[ds, eax + 0x1a]);      /* sub dx, [eax+0x1a] */
            ii(0x1015_4f30, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_4f32, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4f35, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1015_4f38, 5); calld(0x100a_b2e0, -0xa_9c5d);          /* call 0x100ab2e0 */
            ii(0x1015_4f3d, 5); calld(0x1011_aca3, -0x3_a29f);          /* call 0x1011aca3 */
            ii(0x1015_4f42, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1015_4f45, 5); calld(0x1015_53b0, 0x466);              /* call 0x101553b0 */
            ii(0x1015_4f4a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_4f4c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4f4f, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_4f52, 5); calld(0x1007_6a34, -0xd_e523);          /* call 0x10076a34 */
            ii(0x1015_4f57, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4f5a, 4); mov(memb_a32[ds, eax + 0x3d], 0x2);     /* mov byte [eax+0x3d], 0x2 */
            ii(0x1015_4f5e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_4f61, 4); mov(memb_a32[ds, eax + 0x3e], 0x5);     /* mov byte [eax+0x3e], 0x5 */
            ii(0x1015_4f65, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1015_4f69, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4f6b, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1015_4f6e, 5); calld(0x100a_9f38, -0xa_b03b);          /* call 0x100a9f38 */
            ii(0x1015_4f73, 2); jmpd(0x1015_4f7f, 0xa); goto l_0x1015_4f7f; /* jmp 0x10154f7f */
        //    ii(0x1015_4f75, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1015_4f77, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
        //    ii(0x1015_4f7a, 5); calld(0x100a_9f38, -0xa_b047);          /* call 0x100a9f38 */
        l_0x1015_4f7f:
            ii(0x1015_4f7f, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1015_4f82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_4f84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_4f85, 1); popd(edi);                              /* pop edi */
            ii(0x1015_4f86, 1); popd(esi);                              /* pop esi */
            ii(0x1015_4f87, 1); retd(); return;                         /* ret */
        }
    }
}
