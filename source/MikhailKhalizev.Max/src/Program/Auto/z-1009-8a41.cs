using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd96d7e4-d390-4840-892f-3fd34dad6477")]
        public void Method_1009_8a41()
        {
            ii(0x1009_8a41, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1009_8a46, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d307); /* call 0x10165d52 */
            ii(0x1009_8a4b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_8a4c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_8a4d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_8a4e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_8a4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_8a50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_8a52, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1009_8a58, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_8a5b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_8a5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8a61, 4); cmp(memb_a32[ds, eax + 0x1d], 0x1);     /* cmp byte [eax+0x1d], 0x1 */
            ii(0x1009_8a65, 2); if(jnzd(0x1009_8a70, 0x9)) goto l_0x1009_8a70; /* jnz 0x10098a70 */
            ii(0x1009_8a67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8a6a, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1009_8a6e, 2); if(jnzd(0x1009_8a72, 0x2)) goto l_0x1009_8a72; /* jnz 0x10098a72 */
        l_0x1009_8a70:
            ii(0x1009_8a70, 2); jmpd(0x1009_8ab7, 0x45); goto l_0x1009_8ab7; /* jmp 0x10098ab7 */
        l_0x1009_8a72:
            ii(0x1009_8a72, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8a75, 4); mov(memb_a32[ds, eax + 0x1d], 0x2);     /* mov byte [eax+0x1d], 0x2 */
            ii(0x1009_8a79, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8a7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8a7f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_8a82, 5); calld(0x1007_6630, -0x2_2457);          /* call 0x10076630 */
            ii(0x1009_8a87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8a8a, 5); calld(0x1009_9110, 0x681);              /* call 0x10099110 */
            ii(0x1009_8a8f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8a91, 6); if(jzd(0x1009_8cc1, 0x22a)) goto l_0x1009_8cc1; /* jz 0x10098cc1 */
            ii(0x1009_8a97, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_8a9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8a9d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_8aa0, 5); calld(0x1007_6574, -0x2_2531);          /* call 0x10076574 */
            ii(0x1009_8aa5, 5); calld(0x1015_27ed, 0xb_9d43);           /* call 0x101527ed */
            ii(0x1009_8aaa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8aad, 5); calld(0x1009_8cc9, 0x217);              /* call 0x10098cc9 */
            ii(0x1009_8ab2, 5); jmpd(0x1009_8cc1, 0x20a); goto l_0x1009_8cc1; /* jmp 0x10098cc1 */
        l_0x1009_8ab7:
            ii(0x1009_8ab7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8aba, 4); cmp(memb_a32[ds, eax + 0x1d], 0x5);     /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_8abe, 2); if(jnzd(0x1009_8ac9, 0x9)) goto l_0x1009_8ac9; /* jnz 0x10098ac9 */
            ii(0x1009_8ac0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8ac3, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1009_8ac7, 2); if(jnzd(0x1009_8acb, 0x2)) goto l_0x1009_8acb; /* jnz 0x10098acb */
        l_0x1009_8ac9:
            ii(0x1009_8ac9, 2); jmpd(0x1009_8ae6, 0x1b); goto l_0x1009_8ae6; /* jmp 0x10098ae6 */
        l_0x1009_8acb:
            ii(0x1009_8acb, 5); calld(0x1008_a79c, -0xe334);            /* call 0x1008a79c */
            ii(0x1009_8ad0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_8ad2, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_8ad4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8ad7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8adc, 5); calld(0x100a_53ac, 0xc8cb);             /* call 0x100a53ac */
            ii(0x1009_8ae1, 5); jmpd(0x1009_8cc1, 0x1db); goto l_0x1009_8cc1; /* jmp 0x10098cc1 */
        l_0x1009_8ae6:
            ii(0x1009_8ae6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8ae9, 4); cmp(memb_a32[ds, eax + 0x1d], 0x5);     /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_8aed, 2); if(jzd(0x1009_8aff, 0x10)) goto l_0x1009_8aff; /* jz 0x10098aff */
            ii(0x1009_8aef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_8af2, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1009_8af6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8af9, 4); cmp(dx, memw_a32[ds, eax + 0x13]);      /* cmp dx, [eax+0x13] */
            ii(0x1009_8afd, 2); if(jzd(0x1009_8b04, 0x5)) goto l_0x1009_8b04; /* jz 0x10098b04 */
        l_0x1009_8aff:
            ii(0x1009_8aff, 5); jmpd(0x1009_8cc1, 0x1bd); goto l_0x1009_8cc1; /* jmp 0x10098cc1 */
        l_0x1009_8b04:
            ii(0x1009_8b04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8b07, 4); mov(memb_a32[ds, eax + 0x1d], 0x5);     /* mov byte [eax+0x1d], 0x5 */
            ii(0x1009_8b0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8b0e, 4); mov(ax, memw_a32[ds, eax + 0x13]);      /* mov ax, [eax+0x13] */
            ii(0x1009_8b12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_8b15, 5); jmpd(0x1009_8bfb, 0xe1); goto l_0x1009_8bfb; /* jmp 0x10098bfb */
        l_0x1009_8b1a:
            ii(0x1009_8b1a, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1009_8b1f, 5); calld(Definitions.sys_new, 0xc_d2dc);   /* call 0x10165e00 */
            ii(0x1009_8b24, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_8b27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_8b2a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_8b2d, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_8b31, 2); if(jzd(0x1009_8b4e, 0x1b)) goto l_0x1009_8b4e; /* jz 0x10098b4e */
            ii(0x1009_8b33, 5); mov(ebx, 0x4c);                         /* mov ebx, 0x4c */
            ii(0x1009_8b38, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8b3b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_8b3e, 5); calld(0x1008_7abb, -0x1_1088);          /* call 0x10087abb */
            ii(0x1009_8b43, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_8b46, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_8b49, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_8b4c, 2); jmpd(0x1009_8b54, 0x6); goto l_0x1009_8b54; /* jmp 0x10098b54 */
        l_0x1009_8b4e:
            ii(0x1009_8b4e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_8b51, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1009_8b54:
            ii(0x1009_8b54, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1009_8b57, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8b5c, 5); calld(0x100a_4d50, 0xc1ef);             /* call 0x100a4d50 */
            ii(0x1009_8b61, 5); jmpd(0x1009_8c60, 0xfa); goto l_0x1009_8c60; /* jmp 0x10098c60 */
        l_0x1009_8b66:
            ii(0x1009_8b66, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1009_8b6b, 5); calld(Definitions.sys_new, 0xc_d290);   /* call 0x10165e00 */
            ii(0x1009_8b70, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_8b73, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_8b76, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_8b79, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_8b7d, 2); if(jzd(0x1009_8b9a, 0x1b)) goto l_0x1009_8b9a; /* jz 0x10098b9a */
            ii(0x1009_8b7f, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x1009_8b84, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8b87, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_8b8a, 5); calld(0x1008_7abb, -0x1_10d4);          /* call 0x10087abb */
            ii(0x1009_8b8f, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_8b92, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_8b95, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_8b98, 2); jmpd(0x1009_8ba0, 0x6); goto l_0x1009_8ba0; /* jmp 0x10098ba0 */
        l_0x1009_8b9a:
            ii(0x1009_8b9a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_8b9d, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1009_8ba0:
            ii(0x1009_8ba0, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1009_8ba3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8ba8, 5); calld(0x100a_4d50, 0xc1a3);             /* call 0x100a4d50 */
            ii(0x1009_8bad, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1009_8bb2, 5); calld(Definitions.sys_new, 0xc_d249);   /* call 0x10165e00 */
            ii(0x1009_8bb7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_8bba, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_8bbd, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_8bc0, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1009_8bc4, 2); if(jzd(0x1009_8be1, 0x1b)) goto l_0x1009_8be1; /* jz 0x10098be1 */
            ii(0x1009_8bc6, 5); mov(ebx, 0x37);                         /* mov ebx, 0x37 */
            ii(0x1009_8bcb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8bce, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_8bd1, 5); calld(0x1008_7abb, -0x1_111b);          /* call 0x10087abb */
            ii(0x1009_8bd6, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_8bd9, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_8bdc, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_8bdf, 2); jmpd(0x1009_8be7, 0x6); goto l_0x1009_8be7; /* jmp 0x10098be7 */
        l_0x1009_8be1:
            ii(0x1009_8be1, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_8be4, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x1009_8be7:
            ii(0x1009_8be7, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1009_8bea, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8bef, 5); calld(0x100a_4d50, 0xc15c);             /* call 0x100a4d50 */
            ii(0x1009_8bf4, 5); jmpd(0x1009_8c60, 0x67); goto l_0x1009_8c60; /* jmp 0x10098c60 */
        l_0x1009_8bf9:
            ii(0x1009_8bf9, 2); jmpd(0x1009_8c60, 0x65); goto l_0x1009_8c60; /* jmp 0x10098c60 */
        l_0x1009_8bfb:
            ii(0x1009_8bfb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_8bfe, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1009_8c01, 5); cmp(memw_a32[ss, ebp - 0x40], 0x3a);    /* cmp word [ebp-0x40], 0x3a */
            ii(0x1009_8c06, 2); if(jbd(0x1009_8c3f, 0x37)) goto l_0x1009_8c3f; /* jb 0x10098c3f */
            ii(0x1009_8c08, 5); cmp(memw_a32[ss, ebp - 0x40], 0x3a);    /* cmp word [ebp-0x40], 0x3a */
            ii(0x1009_8c0d, 6); if(jbed(0x1009_8b66, -0xad)) goto l_0x1009_8b66; /* jbe 0x10098b66 */
            ii(0x1009_8c13, 5); cmp(memw_a32[ss, ebp - 0x40], 0x4d);    /* cmp word [ebp-0x40], 0x4d */
            ii(0x1009_8c18, 2); if(jbd(0x1009_8c32, 0x18)) goto l_0x1009_8c32; /* jb 0x10098c32 */
            ii(0x1009_8c1a, 5); cmp(memw_a32[ss, ebp - 0x40], 0x4d);    /* cmp word [ebp-0x40], 0x4d */
            ii(0x1009_8c1f, 6); if(jbed(0x1009_8b1a, -0x10b)) goto l_0x1009_8b1a; /* jbe 0x10098b1a */
            ii(0x1009_8c25, 5); cmp(memw_a32[ss, ebp - 0x40], 0x4f);    /* cmp word [ebp-0x40], 0x4f */
            ii(0x1009_8c2a, 6); if(jzd(0x1009_8b1a, -0x116)) goto l_0x1009_8b1a; /* jz 0x10098b1a */
            ii(0x1009_8c30, 2); jmpd(0x1009_8bf9, -0x39); goto l_0x1009_8bf9; /* jmp 0x10098bf9 */
        l_0x1009_8c32:
            ii(0x1009_8c32, 5); cmp(memw_a32[ss, ebp - 0x40], 0x44);    /* cmp word [ebp-0x40], 0x44 */
            ii(0x1009_8c37, 6); if(jzd(0x1009_8b1a, -0x123)) goto l_0x1009_8b1a; /* jz 0x10098b1a */
            ii(0x1009_8c3d, 2); jmpd(0x1009_8bf9, -0x46); goto l_0x1009_8bf9; /* jmp 0x10098bf9 */
        l_0x1009_8c3f:
            ii(0x1009_8c3f, 5); cmp(memw_a32[ss, ebp - 0x40], 0x36);    /* cmp word [ebp-0x40], 0x36 */
            ii(0x1009_8c44, 2); if(jbd(0x1009_8c5e, 0x18)) goto l_0x1009_8c5e; /* jb 0x10098c5e */
            ii(0x1009_8c46, 5); cmp(memw_a32[ss, ebp - 0x40], 0x36);    /* cmp word [ebp-0x40], 0x36 */
            ii(0x1009_8c4b, 6); if(jbed(0x1009_8b66, -0xeb)) goto l_0x1009_8b66; /* jbe 0x10098b66 */
            ii(0x1009_8c51, 5); cmp(memw_a32[ss, ebp - 0x40], 0x37);    /* cmp word [ebp-0x40], 0x37 */
            ii(0x1009_8c56, 6); if(jzd(0x1009_8b1a, -0x142)) goto l_0x1009_8b1a; /* jz 0x10098b1a */
            ii(0x1009_8c5c, 2); jmpd(0x1009_8bf9, -0x65); goto l_0x1009_8bf9; /* jmp 0x10098bf9 */
        l_0x1009_8c5e:
            ii(0x1009_8c5e, 2); jmpd(0x1009_8bf9, -0x67); goto l_0x1009_8bf9; /* jmp 0x10098bf9 */
        l_0x1009_8c60:
            ii(0x1009_8c60, 5); calld(0x1008_a79c, -0xe4c9);            /* call 0x1008a79c */
            ii(0x1009_8c65, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_8c67, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_8c69, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_8c6c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8c71, 5); calld(0x100a_53ac, 0xc736);             /* call 0x100a53ac */
            ii(0x1009_8c76, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8c78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8c7b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_8c7e, 5); calld(0x1013_ad71, 0xa_20ee);           /* call 0x1013ad71 */
            ii(0x1009_8c83, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8c85, 2); if(jzd(0x1009_8ca7, 0x20)) goto l_0x1009_8ca7; /* jz 0x10098ca7 */
            ii(0x1009_8c87, 5); calld(0x1008_a79c, -0xe4f0);            /* call 0x1008a79c */
            ii(0x1009_8c8c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_8c8e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_8c90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8c93, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_8c96, 5); calld(0x1007_65d0, -0x2_26cb);          /* call 0x100765d0 */
            ii(0x1009_8c9b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_8c9d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8ca2, 5); calld(0x100a_53ac, 0xc705);             /* call 0x100a53ac */
        l_0x1009_8ca7:
            ii(0x1009_8ca7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_8ca9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8cac, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_8caf, 5); calld(0x1008_afe4, -0xdcd0);            /* call 0x1008afe4 */
            ii(0x1009_8cb4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_8cb7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_8cbc, 5); calld(0x100a_5e27, 0xd166);             /* call 0x100a5e27 */
        l_0x1009_8cc1:
            ii(0x1009_8cc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_8cc3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_8cc4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_8cc5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_8cc6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_8cc7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_8cc8, 1); retd(); return;                         /* ret */
        }
    }
}
