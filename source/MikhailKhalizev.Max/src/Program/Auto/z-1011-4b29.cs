using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4b29-2de0e06e")]
        public void Method_1011_4b29()
        {
            ii(0x1011_4b29, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1011_4b2e, 5); calld(Definitions.sys_check_available_stack_size, 0x5_121f); /* call 0x10165d52 */
            ii(0x1011_4b33, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_4b34, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_4b35, 1); pushd(esi);                             /* push esi */
            ii(0x1011_4b36, 1); pushd(edi);                             /* push edi */
            ii(0x1011_4b37, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_4b38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4b3a, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1011_4b40, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_4b43, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_4b46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4b48, 5); calld(/* sys */ 0x1017_8f78, 0x6_442b); /* call 0x10178f78 */
            ii(0x1011_4b4d, 5); calld(/* sys */ 0x1016_5ebf, 0x5_136d); /* call 0x10165ebf */
            ii(0x1011_4b52, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4b54, 5); calld(0x100e_883d, -0x2_c31c);          /* call 0x100e883d */
            ii(0x1011_4b59, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_4b5c, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1011_4b5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b61, 4); mov(memb_a32[ds, eax + 0xa], 0);        /* mov byte [eax+0xa], 0x0 */
            ii(0x1011_4b65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b68, 4); mov(memb_a32[ds, eax + 0xb], 0);        /* mov byte [eax+0xb], 0x0 */
            ii(0x1011_4b6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b6f, 6); mov(memw_a32[ds, eax + 0xc], 0);        /* mov word [eax+0xc], 0x0 */
            ii(0x1011_4b75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b78, 4); mov(memb_a32[ds, eax + 0xe], 0);        /* mov byte [eax+0xe], 0x0 */
            ii(0x1011_4b7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b7f, 4); mov(memb_a32[ds, eax + 0x10], 0);       /* mov byte [eax+0x10], 0x0 */
            ii(0x1011_4b83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b86, 4); mov(memb_a32[ds, eax + 0xf], 0);        /* mov byte [eax+0xf], 0x0 */
            ii(0x1011_4b8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b8d, 4); mov(memb_a32[ds, eax + 0x11], 0xff);    /* mov byte [eax+0x11], 0xff */
            ii(0x1011_4b91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b94, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x1011_4b98, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4b9b, 7); mov(memb_a32[ds, eax + 0x51f], 0);      /* mov byte [eax+0x51f], 0x0 */
            ii(0x1011_4ba2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ba5, 7); mov(memb_a32[ds, eax + 0x51e], 0);      /* mov byte [eax+0x51e], 0x0 */
            ii(0x1011_4bac, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_4bb1, 5); calld(0x1007_5fdc, -0x9_ebda);          /* call 0x10075fdc */
            ii(0x1011_4bb6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_4bb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4bbc, 5); calld(0x1011_4119, -0xaa8);             /* call 0x10114119 */
            ii(0x1011_4bc1, 5); calld(/* sys */ 0x1016_be34, 0x5_726e); /* call 0x1016be34 */
            ii(0x1011_4bc6, 5); calld(0x100d_533c, -0x3_f88f);          /* call 0x100d533c */
            ii(0x1011_4bcb, 1); cwde();                                 /* cwde */
            ii(0x1011_4bcc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_4bcf, 3); pushd(memd_a32[ss, ebp - 0xc]);         /* push dword [ebp-0xc] */
            ii(0x1011_4bd2, 5); calld(0x100d_5360, -0x3_f877);          /* call 0x100d5360 */
            ii(0x1011_4bd7, 1); cwde();                                 /* cwde */
            ii(0x1011_4bd8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_4bdb, 3); pushd(memd_a32[ss, ebp - 0x10]);        /* push dword [ebp-0x10] */
            ii(0x1011_4bde, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_4be5, 3); pushd(memd_a32[ss, ebp - 0x14]);        /* push dword [ebp-0x14] */
            ii(0x1011_4be8, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_4bec, 2); if(jnzd(0x1011_4bf7, 0x9)) goto l_0x1011_4bf7; /* jnz 0x10114bf7 */
            ii(0x1011_4bee, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x1011_4bf5, 2); jmpd(0x1011_4bfe, 0x7); goto l_0x1011_4bfe; /* jmp 0x10114bfe */
        l_0x1011_4bf7:
            ii(0x1011_4bf7, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_4bfe:
            ii(0x1011_4bfe, 3); mov(ecx, memd_a32[ss, ebp - 0x1a]);     /* mov ecx, [ebp-0x1a] */
            ii(0x1011_4c01, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_4c04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4c07, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_4c09, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1011_4c0c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_4c0f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4c12, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_4c14, 5); mov(eax, 0x6d0);                        /* mov eax, 0x6d0 */
            ii(0x1011_4c19, 5); calld(0x100e_8c51, -0x2_bfcd);          /* call 0x100e8c51 */
            ii(0x1011_4c1e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_4c23, 5); calld(/* sys */ 0x1016_a24c, 0x5_5624); /* call 0x1016a24c */
            ii(0x1011_4c28, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1011_4c2d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1011_4c30, 5); calld(0x100d_4d78, -0x3_febd);          /* call 0x100d4d78 */
            ii(0x1011_4c35, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4c36, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_4c3b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4c3c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_4c41, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4c42, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1011_4c47, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4c48, 5); mov(eax, 0x6a);                         /* mov eax, 0x6a */
            ii(0x1011_4c4d, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4c4e, 5); mov(ecx, 0x193);                        /* mov ecx, 0x193 */
            ii(0x1011_4c53, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1011_4c58, 5); mov(edx, StringDefinitions.Messages);   /* mov edx, 0x101a49b8 */
            ii(0x1011_4c5d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4c60, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_4c62, 5); calld(0x100e_ab9d, -0x2_a0ca);          /* call 0x100eab9d */
            ii(0x1011_4c67, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_4c6c, 5); calld(/* sys */ 0x1016_a24c, 0x5_55db); /* call 0x1016a24c */
            ii(0x1011_4c71, 7); mov(memd_a32[ss, ebp - 0x20], 0xe);     /* mov dword [ebp-0x20], 0xe */
        l_0x1011_4c78:
            ii(0x1011_4c78, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x1011_4c7b, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1011_4c80, 6); if(jzd(0x1011_4d2c, 0xa6)) goto l_0x1011_4d2c; /* jz 0x10114d2c */
            ii(0x1011_4c86, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4c8a, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_4c8d, 5); mov(edx, 0x101b_9d8c);                  /* mov edx, 0x101b9d8c */
            ii(0x1011_4c92, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_4c94, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1011_4c97, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1011_4c9c, 5); calld(Definitions.sys_new, 0x5_115f);   /* call 0x10165e00 */
            ii(0x1011_4ca1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_4ca4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_4ca7, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_4caa, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1011_4cae, 2); if(jzd(0x1011_4cf4, 0x44)) goto l_0x1011_4cf4; /* jz 0x10114cf4 */
            ii(0x1011_4cb0, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_4cb3, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1011_4cb7, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1011_4cba, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1011_4cbe, 1); inc(eax);                               /* inc eax */
            ii(0x1011_4cbf, 1); cwde();                                 /* cwde */
            ii(0x1011_4cc0, 1); pushd(eax);                             /* push eax */
            ii(0x1011_4cc1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_4cc4, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1011_4cc8, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1011_4ccb, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_4cce, 1); inc(eax);                               /* inc eax */
            ii(0x1011_4ccf, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_4cd2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_4cd5, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1011_4cd8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_4cdb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_4cde, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_4ce1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_4ce4, 5); calld(0x100d_7bdc, -0x3_d10d);          /* call 0x100d7bdc */
            ii(0x1011_4ce9, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_4cec, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1011_4cef, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_4cf2, 2); jmpd(0x1011_4cfa, 0x6); goto l_0x1011_4cfa; /* jmp 0x10114cfa */
        l_0x1011_4cf4:
            ii(0x1011_4cf4, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_4cf7, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1011_4cfa:
            ii(0x1011_4cfa, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1011_4cfe, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_4d01, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1011_4d04, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_4d07, 6); mov(memd_a32[ds, edx + 0x59d], eax);    /* mov [edx+0x59d], eax */
            ii(0x1011_4d0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4d10, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_4d12, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4d16, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_4d19, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4d1c, 6); mov(eax, memd_a32[ds, eax + 0x59d]);    /* mov eax, [eax+0x59d] */
            ii(0x1011_4d22, 5); calld(0x100d_7d74, -0x3_cfb3);          /* call 0x100d7d74 */
            ii(0x1011_4d27, 5); jmpd(0x1011_4c78, -0xb4); goto l_0x1011_4c78; /* jmp 0x10114c78 */
        l_0x1011_4d2c:
            ii(0x1011_4d2c, 7); mov(memd_a32[ss, ebp - 0x20], 0x18);    /* mov dword [ebp-0x20], 0x18 */
        l_0x1011_4d33:
            ii(0x1011_4d33, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x1011_4d36, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1011_4d3b, 2); if(jzd(0x1011_4d50, 0x13)) goto l_0x1011_4d50; /* jz 0x10114d50 */
            ii(0x1011_4d3d, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4d41, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_4d44, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4d47, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_4d4e, 2); jmpd(0x1011_4d33, -0x1d); goto l_0x1011_4d33; /* jmp 0x10114d33 */
        l_0x1011_4d50:
            ii(0x1011_4d50, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_4d55, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_4d58, 6); add(ebx, 0x21a);                        /* add ebx, 0x21a */
            ii(0x1011_4d5e, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1011_4d63, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_4d68, 5); calld(0x1010_6281, -0xeaec);            /* call 0x10106281 */
            ii(0x1011_4d6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4d70, 5); add(eax, 0x21a);                        /* add eax, 0x21a */
            ii(0x1011_4d75, 5); mov(memd_a32[ds, 0x101b_9db0], eax);    /* mov [0x101b9db0], eax */
            ii(0x1011_4d7a, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1011_4d81, 2); jmpd(0x1011_4d89, 0x6); goto l_0x1011_4d89; /* jmp 0x10114d89 */
        l_0x1011_4d83:
            ii(0x1011_4d83, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_4d86, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1011_4d89:
            ii(0x1011_4d89, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4d8d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1011_4d90, 6); if(jged(0x1011_4e1a, 0x84)) goto l_0x1011_4e1a; /* jge 0x10114e1a */
            ii(0x1011_4d96, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4d9a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_4d9c, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4d9f, 9); mov(memw_a32[ds, eax + 0x328], 0);      /* mov word [eax+0x328], 0x0 */
            ii(0x1011_4da8, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4dac, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_4daf, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4db2, 7); mov(memb_a32[ds, eax + 0x238], 0);      /* mov byte [eax+0x238], 0x0 */
            ii(0x1011_4db9, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4dbd, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_4dc0, 2); if(jged(0x1011_4e15, 0x53)) goto l_0x1011_4e15; /* jge 0x10114e15 */
            ii(0x1011_4dc2, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4dc6, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_4dc8, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4dcb, 9); mov(memw_a32[ds, eax + 0x4dc], 0);      /* mov word [eax+0x4dc], 0x0 */
            ii(0x1011_4dd4, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4dd8, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_4ddb, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4dde, 7); mov(memb_a32[ds, eax + 0x338], 0);      /* mov byte [eax+0x338], 0x0 */
            ii(0x1011_4de5, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4de9, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4dec, 7); mov(memb_a32[ds, eax + 0x4ec], 0);      /* mov byte [eax+0x4ec], 0x0 */
            ii(0x1011_4df3, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4df7, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_4dfa, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_4dfd, 6); add(edx, 0x338);                        /* add edx, 0x338 */
            ii(0x1011_4e03, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_4e05, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4e09, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1011_4e0c, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_4e0f, 6); mov(memd_a32[ds, eax + 0x101b_9d9c], edx); /* mov [eax+0x101b9d9c], edx */
        l_0x1011_4e15:
            ii(0x1011_4e15, 5); jmpd(0x1011_4d83, -0x97); goto l_0x1011_4d83; /* jmp 0x10114d83 */
        l_0x1011_4e1a:
            ii(0x1011_4e1a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e1d, 7); mov(memb_a32[ds, eax + 0x3b0], 0);      /* mov byte [eax+0x3b0], 0x0 */
            ii(0x1011_4e24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e27, 5); add(eax, 0x3b0);                        /* add eax, 0x3b0 */
            ii(0x1011_4e2c, 5); mov(memd_a32[ds, 0x101b_9e28], eax);    /* mov [0x101b9e28], eax */
            ii(0x1011_4e31, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e34, 7); mov(memb_a32[ds, eax + 0x446], 0);      /* mov byte [eax+0x446], 0x0 */
            ii(0x1011_4e3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e3e, 5); add(eax, 0x446);                        /* add eax, 0x446 */
            ii(0x1011_4e43, 5); mov(memd_a32[ds, 0x101b_9e3c], eax);    /* mov [0x101b9e3c], eax */
            ii(0x1011_4e48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4e4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e4d, 5); calld(0x1011_28f6, -0x255c);            /* call 0x101128f6 */
            ii(0x1011_4e52, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_4e54, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e57, 6); mov(memd_a32[ds, eax + 0x196], edx);    /* mov [eax+0x196], edx */
            ii(0x1011_4e5d, 5); mov(edx, 0x12);                         /* mov edx, 0x12 */
            ii(0x1011_4e62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e65, 5); calld(0x1011_28f6, -0x2574);            /* call 0x101128f6 */
            ii(0x1011_4e6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_4e6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e6f, 6); mov(memd_a32[ds, eax + 0x19a], edx);    /* mov [eax+0x19a], edx */
            ii(0x1011_4e75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e78, 10); mov(memd_a32[ds, eax + 0x19e], 0);     /* mov dword [eax+0x19e], 0x0 */
            ii(0x1011_4e82, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e85, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_4e89, 2); if(jzd(0x1011_4ee4, 0x59)) goto l_0x1011_4ee4; /* jz 0x10114ee4 */
            ii(0x1011_4e8b, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1011_4e90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4e93, 5); calld(0x1011_2a06, -0x2492);            /* call 0x10112a06 */
            ii(0x1011_4e98, 7); mov(memd_a32[ss, ebp - 0x20], 0x4);     /* mov dword [ebp-0x20], 0x4 */
        l_0x1011_4e9f:
            ii(0x1011_4e9f, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x1011_4ea2, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1011_4ea7, 2); if(jzd(0x1011_4ebc, 0x13)) goto l_0x1011_4ebc; /* jz 0x10114ebc */
            ii(0x1011_4ea9, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_4ead, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_4eb0, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_4eb3, 7); mov(memb_a32[ds, eax + 0x520], 0);      /* mov byte [eax+0x520], 0x0 */
            ii(0x1011_4eba, 2); jmpd(0x1011_4e9f, -0x1d); goto l_0x1011_4e9f; /* jmp 0x10114e9f */
        l_0x1011_4ebc:
            ii(0x1011_4ebc, 5); calld(/* sys */ 0x1016_5e9b, 0x5_0fda); /* call 0x10165e9b */
            ii(0x1011_4ec1, 6); imul(eax, eax, 0x7cf7);                 /* imul eax, eax, 0x7cf7 */
            ii(0x1011_4ec7, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1011_4eca, 3); lea(edx, eax + 0xa);                    /* lea edx, [eax+0xa] */
            ii(0x1011_4ecd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ed0, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
            ii(0x1011_4ed4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ed7, 4); mov(dx, memw_a32[ds, eax + 0x14]);      /* mov dx, [eax+0x14] */
            ii(0x1011_4edb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ede, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1011_4ee2, 2); jmpd(0x1011_4eed, 0x9); goto l_0x1011_4eed; /* jmp 0x10114eed */
        l_0x1011_4ee4:
            ii(0x1011_4ee4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ee7, 6); mov(memw_a32[ds, eax + 0x14], 0);       /* mov word [eax+0x14], 0x0 */
        l_0x1011_4eed:
            ii(0x1011_4eed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4ef0, 9); mov(memw_a32[ds, eax + 0x5d5], 0xffff); /* mov word [eax+0x5d5], 0xffff */
            ii(0x1011_4ef9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4efc, 5); calld(0x1011_390d, -0x15f4);            /* call 0x1011390d */
            ii(0x1011_4f01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4f04, 5); calld(0x1012_ac41, 0x1_5d38);           /* call 0x1012ac41 */
            ii(0x1011_4f09, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4f0c, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_4f10, 2); if(jzd(0x1011_4f1c, 0xa)) goto l_0x1011_4f1c; /* jz 0x10114f1c */
            ii(0x1011_4f12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4f14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4f17, 5); calld(0x1011_3d56, -0x11c6);            /* call 0x10113d56 */
        l_0x1011_4f1c:
            ii(0x1011_4f1c, 5); calld(/* sys */ 0x1016_bcc4, 0x5_6da3); /* call 0x1016bcc4 */
            ii(0x1011_4f21, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4f23, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_4f24, 1); popd(edi);                              /* pop edi */
            ii(0x1011_4f25, 1); popd(esi);                              /* pop esi */
            ii(0x1011_4f26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_4f27, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_4f28, 1); retd();                                 /* ret */
        }
    }
}
