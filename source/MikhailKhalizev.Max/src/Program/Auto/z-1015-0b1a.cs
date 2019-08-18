using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2104c92b-1326-4af4-9aaf-10deafb0f77b")]
        public void Method_1015_0b1a()
        {
            ii(0x1015_0b1a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_0b1f, 5); calld(Definitions.sys_check_available_stack_size, 0x1_522e); /* call 0x10165d52 */
            ii(0x1015_0b24, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_0b25, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_0b26, 1); pushd(edx);                             /* push edx */
            ii(0x1015_0b27, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0b28, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0b29, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0b2a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0b2c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_0b32, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_0b35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b38, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_0b3c, 6); if(jzd(0x1015_0be4, 0xa2)) goto l_0x1015_0be4; /* jz 0x10150be4 */
            ii(0x1015_0b42, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b45, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_0b49, 2); if(jzd(0x1015_0b6d, 0x22)) goto l_0x1015_0b6d; /* jz 0x10150b6d */
            ii(0x1015_0b4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b4e, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_0b52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b55, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_0b59, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b5c, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_0b5f, 5); calld(0x1009_caf8, -0xb_406c);          /* call 0x1009caf8 */
            ii(0x1015_0b64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b67, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x1015_0b6b, 2); jmpd(0x1015_0b9a, 0x2d); goto l_0x1015_0b9a; /* jmp 0x10150b9a */
        l_0x1015_0b6d:
            ii(0x1015_0b6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b70, 4); cmp(memb_a32[ds, eax + 0x3e], 0xd);     /* cmp byte [eax+0x3e], 0xd */
            ii(0x1015_0b74, 2); if(jnzd(0x1015_0b7f, 0x9)) goto l_0x1015_0b7f; /* jnz 0x10150b7f */
            ii(0x1015_0b76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b79, 4); mov(memb_a32[ds, eax + 0x3d], 0x15);    /* mov byte [eax+0x3d], 0x15 */
            ii(0x1015_0b7d, 2); jmpd(0x1015_0b86, 0x7); goto l_0x1015_0b86; /* jmp 0x10150b86 */
        l_0x1015_0b7f:
            ii(0x1015_0b7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b82, 4); mov(memb_a32[ds, eax + 0x3d], 0x1f);    /* mov byte [eax+0x3d], 0x1f */
        l_0x1015_0b86:
            ii(0x1015_0b86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b89, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_0b8d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_0b92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b95, 5); calld(0x1007_2600, -0xd_e59a);          /* call 0x10072600 */
        l_0x1015_0b9a:
            ii(0x1015_0b9a, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_0b9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0ba2, 5); calld(0x1007_6d98, -0xd_9e0f);          /* call 0x10076d98 */
            ii(0x1015_0ba7, 2); test(al, al);                           /* test al, al */
            ii(0x1015_0ba9, 2); if(jzd(0x1015_0bce, 0x23)) goto l_0x1015_0bce; /* jz 0x10150bce */
            ii(0x1015_0bab, 5); calld(0x1010_2bf8, -0x4_dfb8);          /* call 0x10102bf8 */
            ii(0x1015_0bb0, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_0bb2, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_0bb4, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1015_0bb9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_0bbc, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_0bc1, 5); calld(0x1013_d5c0, -0x1_3606);          /* call 0x1013d5c0 */
            ii(0x1015_0bc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0bc9, 5); calld(0x1010_094d, -0x5_0281);          /* call 0x1010094d */
        l_0x1015_0bce:
            ii(0x1015_0bce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0bd1, 3); mov(edx, memd_a32[ds, eax + 0x31]);     /* mov edx, [eax+0x31] */
            ii(0x1015_0bd4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0bd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0bda, 5); calld(0x1014_9b07, -0x70d8);            /* call 0x10149b07 */
            ii(0x1015_0bdf, 5); jmpd(0x1015_0d43, 0x15f); goto l_0x1015_0d43; /* jmp 0x10150d43 */
        l_0x1015_0be4:
            ii(0x1015_0be4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0be7, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_0bea, 5); calld(0x1009_caf8, -0xb_40f7);          /* call 0x1009caf8 */
            ii(0x1015_0bef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0bf2, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x1015_0bf6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_0bf8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_0bf9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_0bfb, 1); pushd(eax);                             /* push eax */
            ii(0x1015_0bfc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_0bfe, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_0c03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c06, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1015_0c09, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0c0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c0f, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1015_0c12, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0c15, 5); calld(0x1007_4395, -0xd_c885);          /* call 0x10074395 */
            ii(0x1015_0c1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0c1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c1f, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_0c22, 5); calld(0x1007_6a34, -0xd_a1f3);          /* call 0x10076a34 */
            ii(0x1015_0c27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c2a, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_0c2e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c31, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_0c35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c38, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_0c3c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c3f, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1015_0c44, 2); if(jzd(0x1015_0c65, 0x1f)) goto l_0x1015_0c65; /* jz 0x10150c65 */
            ii(0x1015_0c46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c49, 5); cmp(memw_a32[ds, eax + 0x8], 0x3e);     /* cmp word [eax+0x8], 0x3e */
            ii(0x1015_0c4e, 2); if(jnzd(0x1015_0c63, 0x13)) goto l_0x1015_0c63; /* jnz 0x10150c63 */
            ii(0x1015_0c50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c53, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_0c58, 5); calld(0x1007_6574, -0xd_a6e9);          /* call 0x10076574 */
            ii(0x1015_0c5d, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_0c61, 2); if(jnzd(0x1015_0c65, 0x2)) goto l_0x1015_0c65; /* jnz 0x10150c65 */
        l_0x1015_0c63:
            ii(0x1015_0c63, 2); jmpd(0x1015_0cab, 0x46); goto l_0x1015_0cab; /* jmp 0x10150cab */
        l_0x1015_0c65:
            ii(0x1015_0c65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c68, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1015_0c6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c6f, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1015_0c73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c76, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1015_0c7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c7d, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1015_0c81, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1015_0c86, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1015_0c8b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c8e, 5); calld(0x1016_2f96, 0x1_2303);           /* call 0x10162f96 */
            ii(0x1015_0c93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0c96, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1015_0c99, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_0c9b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0c9e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0ca1, 5); calld(0x1014_9b07, -0x719f);            /* call 0x10149b07 */
            ii(0x1015_0ca6, 5); jmpd(0x1015_0d17, 0x6c); goto l_0x1015_0d17; /* jmp 0x10150d17 */
        l_0x1015_0cab:
            ii(0x1015_0cab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0cae, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x1015_0cb3, 2); if(jnzd(0x1015_0cc6, 0x11)) goto l_0x1015_0cc6; /* jnz 0x10150cc6 */
            ii(0x1015_0cb5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0cb8, 6); mov(eax, memd_a32[ds, eax + 0xd3]);     /* mov eax, [eax+0xd3] */
            ii(0x1015_0cbe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0cc1, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1015_0cc4, 2); if(jged(0x1015_0cc8, 0x2)) goto l_0x1015_0cc8; /* jge 0x10150cc8 */
        l_0x1015_0cc6:
            ii(0x1015_0cc6, 2); jmpd(0x1015_0ce2, 0x1a); goto l_0x1015_0ce2; /* jmp 0x10150ce2 */
        l_0x1015_0cc8:
            ii(0x1015_0cc8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0ccb, 7); mov(ax, memw_a32[ds, eax + 0xd5]);      /* mov ax, [eax+0xd5] */
            ii(0x1015_0cd2, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1015_0cd5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0cd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0cdb, 5); calld(0x1014_9b07, -0x71d9);            /* call 0x10149b07 */
            ii(0x1015_0ce0, 2); jmpd(0x1015_0d17, 0x35); goto l_0x1015_0d17; /* jmp 0x10150d17 */
        l_0x1015_0ce2:
            ii(0x1015_0ce2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0ce5, 5); cmp(memw_a32[ds, eax + 0x8], 0x3e);     /* cmp word [eax+0x8], 0x3e */
            ii(0x1015_0cea, 2); if(jnzd(0x1015_0cfd, 0x11)) goto l_0x1015_0cfd; /* jnz 0x10150cfd */
            ii(0x1015_0cec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0cef, 6); mov(eax, memd_a32[ds, eax + 0xd3]);     /* mov eax, [eax+0xd3] */
            ii(0x1015_0cf5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0cf8, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1015_0cfb, 2); if(jged(0x1015_0cff, 0x2)) goto l_0x1015_0cff; /* jge 0x10150cff */
        l_0x1015_0cfd:
            ii(0x1015_0cfd, 2); jmpd(0x1015_0d17, 0x18); goto l_0x1015_0d17; /* jmp 0x10150d17 */
        l_0x1015_0cff:
            ii(0x1015_0cff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d02, 7); mov(ax, memw_a32[ds, eax + 0xd5]);      /* mov ax, [eax+0xd5] */
            ii(0x1015_0d09, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x1015_0d0c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0d0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d12, 5); calld(0x1014_9b07, -0x7210);            /* call 0x10149b07 */
        l_0x1015_0d17:
            ii(0x1015_0d17, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_0d1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d1f, 5); calld(0x1007_6d98, -0xd_9f8c);          /* call 0x10076d98 */
            ii(0x1015_0d24, 2); test(al, al);                           /* test al, al */
            ii(0x1015_0d26, 2); if(jzd(0x1015_0d43, 0x1b)) goto l_0x1015_0d43; /* jz 0x10150d43 */
            ii(0x1015_0d28, 5); calld(0x1010_2bf8, -0x4_e135);          /* call 0x10102bf8 */
            ii(0x1015_0d2d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_0d2f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_0d31, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_0d36, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_0d39, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_0d3e, 5); calld(0x1013_d5c0, -0x1_3783);          /* call 0x1013d5c0 */
        l_0x1015_0d43:
            ii(0x1015_0d43, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0d45, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0d46, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0d47, 1); popd(esi);                              /* pop esi */
            ii(0x1015_0d48, 1); popd(edx);                              /* pop edx */
            ii(0x1015_0d49, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0d4a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0d4b, 1); retd(); return;                         /* ret */
        }
    }
}
