using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8bbb-8b02a0a1")]
        public void Method_1015_8bbb()
        {
            ii(0x1015_8bbb, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_8bc0, 5); calld(Definitions.sys_check_available_stack_size, 0xd18d); /* call 0x10165d52 */
            ii(0x1015_8bc5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8bc6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8bc7, 1); pushd(esi);                             /* push esi */
            ii(0x1015_8bc8, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8bc9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8bca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8bcc, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_8bd2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8bd5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_8bd8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_8bda, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1015_8bdf, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_8be2, 2); if(jnzd(0x1015_8bf6, 0x12)) goto l_0x1015_8bf6; /* jnz 0x10158bf6 */
            ii(0x1015_8be4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8be7, 5); calld(0x1007_623c, -0xe_29b0);          /* call 0x1007623c */
            ii(0x1015_8bec, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1015_8bef, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_8bf2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_8bf4, 2); if(jgd(0x1015_8bf8, 0x2)) goto l_0x1015_8bf8; /* jg 0x10158bf8 */
        l_0x1015_8bf6:
            ii(0x1015_8bf6, 2); jmpd(0x1015_8c02, 0xa); goto l_0x1015_8c02; /* jmp 0x10158c02 */
        l_0x1015_8bf8:
            ii(0x1015_8bf8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8bfb, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_8c00, 2); if(jnzd(0x1015_8c04, 0x2)) goto l_0x1015_8c04; /* jnz 0x10158c04 */
        l_0x1015_8c02:
            ii(0x1015_8c02, 2); jmpd(0x1015_8c24, 0x20); goto l_0x1015_8c24; /* jmp 0x10158c24 */
        l_0x1015_8c04:
            ii(0x1015_8c04, 5); mov(eax, 0x1015_8b4a);                  /* mov eax, 0x10158b4a */
            ii(0x1015_8c09, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8c0a, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1015_8c0f, 5); mov(ebx, StringDefinitions.Manual);     /* mov ebx, 0x101b24bc */
            ii(0x1015_8c14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c17, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8c19, 3); mov(dl, memb_a32[ds, eax + 0x5b]);      /* mov dl, [eax+0x5b] */
            ii(0x1015_8c1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8c1f, 5); calld(0x1015_7ccf, -0xf55);             /* call 0x10157ccf */
        l_0x1015_8c24:
            ii(0x1015_8c24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c27, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_8c2a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_8c2d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_8c30, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0); /* cmp byte [eax+0x101c81d5], 0x0 */
            ii(0x1015_8c37, 2); if(jzd(0x1015_8c4e, 0x15)) goto l_0x1015_8c4e; /* jz 0x10158c4e */
            ii(0x1015_8c39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c3c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_8c3f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_8c42, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_8c45, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x3); /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x1015_8c4c, 2); if(jled(0x1015_8c50, 0x2)) goto l_0x1015_8c50; /* jle 0x10158c50 */
        l_0x1015_8c4e:
            ii(0x1015_8c4e, 2); jmpd(0x1015_8c59, 0x9); goto l_0x1015_8c59; /* jmp 0x10158c59 */
        l_0x1015_8c50:
            ii(0x1015_8c50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c53, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_8c57, 2); if(jnzd(0x1015_8c5b, 0x2)) goto l_0x1015_8c5b; /* jnz 0x10158c5b */
        l_0x1015_8c59:
            ii(0x1015_8c59, 2); jmpd(0x1015_8c64, 0x9); goto l_0x1015_8c64; /* jmp 0x10158c64 */
        l_0x1015_8c5b:
            ii(0x1015_8c5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c5e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_8c62, 2); if(jnzd(0x1015_8c66, 0x2)) goto l_0x1015_8c66; /* jnz 0x10158c66 */
        l_0x1015_8c64:
            ii(0x1015_8c64, 2); jmpd(0x1015_8ca1, 0x3b); goto l_0x1015_8ca1; /* jmp 0x10158ca1 */
        l_0x1015_8c66:
            ii(0x1015_8c66, 5); mov(eax, 0x1015_8aee);                  /* mov eax, 0x10158aee */
            ii(0x1015_8c6b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8c6c, 7); mov(memd_a32[ss, ebp - 0x14], 0x33);    /* mov dword [ebp-0x14], 0x33 */
            ii(0x1015_8c73, 5); mov(eax, StringDefinitions.XFer);       /* mov eax, 0x101b24c3 */
            ii(0x1015_8c78, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_8c7b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8c7e, 4); cmp(memb_a32[ds, eax + 0x57], 0x3);     /* cmp byte [eax+0x57], 0x3 */
            ii(0x1015_8c82, 2); if(jnzd(0x1015_8c8a, 0x6)) goto l_0x1015_8c8a; /* jnz 0x10158c8a */
            ii(0x1015_8c84, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_8c88, 2); jmpd(0x1015_8c8e, 0x4); goto l_0x1015_8c8e; /* jmp 0x10158c8e */
        l_0x1015_8c8a:
            ii(0x1015_8c8a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_8c8e:
            ii(0x1015_8c8e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8c90, 3); mov(dl, memb_a32[ss, ebp - 0xc]);       /* mov dl, [ebp-0xc] */
            ii(0x1015_8c93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8c96, 3); mov(ecx, memd_a32[ss, ebp - 0x14]);     /* mov ecx, [ebp-0x14] */
            ii(0x1015_8c99, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1015_8c9c, 5); calld(0x1015_7ccf, -0xfd2);             /* call 0x10157ccf */
        l_0x1015_8ca1:
            ii(0x1015_8ca1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8ca4, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x1015_8caa, 2); if(jzd(0x1015_8cb5, 0x9)) goto l_0x1015_8cb5; /* jz 0x10158cb5 */
            ii(0x1015_8cac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8caf, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_8cb3, 2); if(jnzd(0x1015_8cb7, 0x2)) goto l_0x1015_8cb7; /* jnz 0x10158cb7 */
        l_0x1015_8cb5:
            ii(0x1015_8cb5, 2); jmpd(0x1015_8cc0, 0x9); goto l_0x1015_8cc0; /* jmp 0x10158cc0 */
        l_0x1015_8cb7:
            ii(0x1015_8cb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8cba, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_8cbe, 2); if(jnzd(0x1015_8cc2, 0x2)) goto l_0x1015_8cc2; /* jnz 0x10158cc2 */
        l_0x1015_8cc0:
            ii(0x1015_8cc0, 2); jmpd(0x1015_8ce2, 0x20); goto l_0x1015_8ce2; /* jmp 0x10158ce2 */
        l_0x1015_8cc2:
            ii(0x1015_8cc2, 5); mov(eax, 0x1015_84cf);                  /* mov eax, 0x101584cf */
            ii(0x1015_8cc7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8cc8, 5); mov(ecx, 0x35);                         /* mov ecx, 0x35 */
            ii(0x1015_8ccd, 5); mov(ebx, StringDefinitions.Enter);      /* mov ebx, 0x101b24c9 */
            ii(0x1015_8cd2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8cd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8cd7, 3); mov(dl, memb_a32[ds, eax + 0x56]);      /* mov dl, [eax+0x56] */
            ii(0x1015_8cda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8cdd, 5); calld(0x1015_7ccf, -0x1013);            /* call 0x10157ccf */
        l_0x1015_8ce2:
            ii(0x1015_8ce2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8ce4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8ce7, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_8cea, 5); calld(0x1013_ad71, -0x1_df7e);          /* call 0x1013ad71 */
            ii(0x1015_8cef, 2); test(al, al);                           /* test al, al */
            ii(0x1015_8cf1, 2); if(jzd(0x1015_8cfc, 0x9)) goto l_0x1015_8cfc; /* jz 0x10158cfc */
            ii(0x1015_8cf3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8cf6, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_8cfa, 2); if(jnzd(0x1015_8cfe, 0x2)) goto l_0x1015_8cfe; /* jnz 0x10158cfe */
        l_0x1015_8cfc:
            ii(0x1015_8cfc, 2); jmpd(0x1015_8d07, 0x9); goto l_0x1015_8d07; /* jmp 0x10158d07 */
        l_0x1015_8cfe:
            ii(0x1015_8cfe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8d01, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_8d05, 2); if(jnzd(0x1015_8d09, 0x2)) goto l_0x1015_8d09; /* jnz 0x10158d09 */
        l_0x1015_8d07:
            ii(0x1015_8d07, 2); jmpd(0x1015_8d23, 0x1a); goto l_0x1015_8d23; /* jmp 0x10158d23 */
        l_0x1015_8d09:
            ii(0x1015_8d09, 5); mov(eax, 0x1015_8aaa);                  /* mov eax, 0x10158aaa */
            ii(0x1015_8d0e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8d0f, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_8d14, 5); mov(ebx, StringDefinitions.Stop);       /* mov ebx, 0x101b24cf */
            ii(0x1015_8d19, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8d1b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8d1e, 5); calld(0x1015_7ccf, -0x1054);            /* call 0x10157ccf */
        l_0x1015_8d23:
            ii(0x1015_8d23, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8d26, 5); calld(0x1015_0e51, -0x7eda);            /* call 0x10150e51 */
            ii(0x1015_8d2b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_8d2d, 2); if(jzd(0x1015_8d63, 0x34)) goto l_0x1015_8d63; /* jz 0x10158d63 */
            ii(0x1015_8d2f, 5); mov(eax, 0x1015_80ae);                  /* mov eax, 0x101580ae */
            ii(0x1015_8d34, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8d35, 5); mov(ecx, 0x35);                         /* mov ecx, 0x35 */
            ii(0x1015_8d3a, 5); mov(ebx, StringDefinitions.Upgrade2);   /* mov ebx, 0x101b24d4 */
            ii(0x1015_8d3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8d41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8d44, 5); calld(0x1015_7ccf, -0x107a);            /* call 0x10157ccf */
            ii(0x1015_8d49, 5); mov(eax, 0x1015_80fd);                  /* mov eax, 0x101580fd */
            ii(0x1015_8d4e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8d4f, 5); mov(ecx, 0x36);                         /* mov ecx, 0x36 */
            ii(0x1015_8d54, 5); mov(ebx, StringDefinitions.UpgAll);     /* mov ebx, 0x101b24dc */
            ii(0x1015_8d59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8d5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8d5e, 5); calld(0x1015_7ccf, -0x1094);            /* call 0x10157ccf */
        l_0x1015_8d63:
            ii(0x1015_8d63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8d66, 4); test(memb_a32[ds, eax + 0x15], 0x4);    /* test byte [eax+0x15], 0x4 */
            ii(0x1015_8d6a, 6); if(jzd(0x1015_8ddf, 0x6f)) goto l_0x1015_8ddf; /* jz 0x10158ddf */
            ii(0x1015_8d70, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8d73, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_8d78, 2); if(jzd(0x1015_8dc5, 0x4b)) goto l_0x1015_8dc5; /* jz 0x10158dc5 */
            ii(0x1015_8d7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8d7d, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_8d81, 2); if(jnzd(0x1015_8da2, 0x1f)) goto l_0x1015_8da2; /* jnz 0x10158da2 */
            ii(0x1015_8d83, 5); mov(eax, 0x1015_8004);                  /* mov eax, 0x10158004 */
            ii(0x1015_8d88, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8d89, 5); mov(ecx, 0x38);                         /* mov ecx, 0x38 */
            ii(0x1015_8d8e, 5); mov(ebx, StringDefinitions.Sentry);     /* mov ebx, 0x101b24e5 */
            ii(0x1015_8d93, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_8d98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8d9b, 5); calld(0x1015_7ccf, -0x10d1);            /* call 0x10157ccf */
            ii(0x1015_8da0, 2); jmpd(0x1015_8dc5, 0x23); goto l_0x1015_8dc5; /* jmp 0x10158dc5 */
        l_0x1015_8da2:
            ii(0x1015_8da2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8da5, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1015_8da9, 2); if(jnzd(0x1015_8dc5, 0x1a)) goto l_0x1015_8dc5; /* jnz 0x10158dc5 */
            ii(0x1015_8dab, 5); mov(eax, 0x1015_8004);                  /* mov eax, 0x10158004 */
            ii(0x1015_8db0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8db1, 5); mov(ecx, 0x38);                         /* mov ecx, 0x38 */
            ii(0x1015_8db6, 5); mov(ebx, StringDefinitions.Sentry2);    /* mov ebx, 0x101b24ec */
            ii(0x1015_8dbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8dbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8dc0, 5); calld(0x1015_7ccf, -0x10f6);            /* call 0x10157ccf */
        l_0x1015_8dc5:
            ii(0x1015_8dc5, 5); mov(eax, 0x1015_7f4b);                  /* mov eax, 0x10157f4b */
            ii(0x1015_8dca, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8dcb, 5); mov(ecx, 0x39);                         /* mov ecx, 0x39 */
            ii(0x1015_8dd0, 5); mov(ebx, StringDefinitions.Done10);     /* mov ebx, 0x101b24f3 */
            ii(0x1015_8dd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8dd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8dda, 5); calld(0x1015_7ccf, -0x1110);            /* call 0x10157ccf */
        l_0x1015_8ddf:
            ii(0x1015_8ddf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_8de2, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_8de6, 2); if(jzd(0x1015_8e02, 0x1a)) goto l_0x1015_8e02; /* jz 0x10158e02 */
            ii(0x1015_8de8, 5); mov(eax, 0x1015_8a5a);                  /* mov eax, 0x10158a5a */
            ii(0x1015_8ded, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8dee, 5); mov(ecx, 0x30);                         /* mov ecx, 0x30 */
            ii(0x1015_8df3, 5); mov(ebx, StringDefinitions.Remove);     /* mov ebx, 0x101b24f8 */
            ii(0x1015_8df8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8dfa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8dfd, 5); calld(0x1015_7ccf, -0x1133);            /* call 0x10157ccf */
        l_0x1015_8e02:
            ii(0x1015_8e02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8e04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8e05, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8e06, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8e07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8e08, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8e09, 1); retd(); return;                         /* ret */
        }
    }
}
