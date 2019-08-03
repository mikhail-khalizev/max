using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("84bb1fe3-daee-4162-9105-02b011699eed")]
        public void Method_1010_9cee()
        {
            ii(0x1010_9cee, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x1010_9cf3, 5); calld(Definitions.sys_check_available_stack_size, 0x5c05a); /* call 0x10165d52 */
            ii(0x1010_9cf8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9cf9, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9cfa, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9cfb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9cfc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9cfe, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1010_9d04, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_9d07, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_9d0a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1010_9d0d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_9d0f, 5); calld(0x100e_883d, -0x214d7);           /* call 0x100e883d */
            ii(0x1010_9d14, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_9d17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_9d1a, 5); mov(memd_a32[ds, 0x101c_4e48], eax);    /* mov [0x101c4e48], eax */
            ii(0x1010_9d1f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_9d22, 6); mov(memw_a32[ds, 0x101c_4e4c], ax);     /* mov [0x101c4e4c], ax */
            ii(0x1010_9d28, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_9d2d, 5); calld(/* sys */ 0x1016_a24c, 0x6051a);  /* call 0x1016a24c */
        l_0x1010_9d32:
            ii(0x1010_9d32, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_9d35, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_9d3a, 6); if(jzd(0x1010_9f8f, 0x24f)) goto l_0x1010_9f8f; /* jz 0x10109f8f */
            ii(0x1010_9d40, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9d44, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9d47, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9d4a, 4); cmp(memb_a32[ds, eax + 0x4], 0);        /* cmp byte [eax+0x4], 0x0 */
            ii(0x1010_9d4e, 2); if(jzd(0x1010_9d60, 0x10)) goto l_0x1010_9d60; /* jz 0x10109d60 */
            ii(0x1010_9d50, 7); mov(memd_a32[ss, ebp - 0x18], 0x2bb);   /* mov dword [ebp-0x18], 0x2bb */
            ii(0x1010_9d57, 7); mov(memd_a32[ss, ebp - 0x14], 0x2bc);   /* mov dword [ebp-0x14], 0x2bc */
            ii(0x1010_9d5e, 2); jmpd(0x1010_9d6e, 0xe); goto l_0x1010_9d6e; /* jmp 0x10109d6e */
        l_0x1010_9d60:
            ii(0x1010_9d60, 7); mov(memd_a32[ss, ebp - 0x18], 0x2bd);   /* mov dword [ebp-0x18], 0x2bd */
            ii(0x1010_9d67, 7); mov(memd_a32[ss, ebp - 0x14], 0x2be);   /* mov dword [ebp-0x14], 0x2be */
        l_0x1010_9d6e:
            ii(0x1010_9d6e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9d72, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9d75, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9d78, 4); cmp(memd_a32[ds, eax + 0x9], 0);        /* cmp dword [eax+0x9], 0x0 */
            ii(0x1010_9d7c, 6); if(jzd(0x1010_9e40, 0xbe)) goto l_0x1010_9e40; /* jz 0x10109e40 */
            ii(0x1010_9d82, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_9d87, 5); calld(Definitions.sys_new, 0x5c074);    /* call 0x10165e00 */
            ii(0x1010_9d8c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_9d8f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_9d92, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_9d95, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_9d99, 2); if(jzd(0x1010_9dd7, 0x3c)) goto l_0x1010_9dd7; /* jz 0x10109dd7 */
            ii(0x1010_9d9b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9d9f, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9da2, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9da5, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x1010_9da8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_9dab, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9dac, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9db0, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9db3, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9db6, 3); mov(ecx, memd_a32[ds, eax + 0x3]);      /* mov ecx, [eax+0x3] */
            ii(0x1010_9db9, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_9dbc, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1010_9dc0, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1010_9dc4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_9dc7, 5); calld(Definitions.my_ctor_c17, -0x3b9bd); /* call 0x100ce40f */
            ii(0x1010_9dcc, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_9dcf, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_9dd2, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_9dd5, 2); jmpd(0x1010_9ddd, 0x6); goto l_0x1010_9ddd; /* jmp 0x10109ddd */
        l_0x1010_9dd7:
            ii(0x1010_9dd7, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_9dda, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1010_9ddd:
            ii(0x1010_9ddd, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_9de1, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x1010_9de4, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1010_9de7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_9dea, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1010_9dec, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1010_9def, 5); calld(0x100d_5224, -0x34bd0);           /* call 0x100d5224 */
            ii(0x1010_9df4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9df5, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1010_9df8, 5); calld(0x100d_5250, -0x34bad);           /* call 0x100d5250 */
            ii(0x1010_9dfd, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9dfe, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1010_9e01, 5); calld(0x100d_527c, -0x34b8a);           /* call 0x100d527c */
            ii(0x1010_9e06, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9e07, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1010_9e0a, 5); calld(0x100d_52a8, -0x34b67);           /* call 0x100d52a8 */
            ii(0x1010_9e0f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9e10, 5); calld(0x100d_52d4, -0x34b41);           /* call 0x100d52d4 */
            ii(0x1010_9e15, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_9e18, 5); calld(0x100d_52f8, -0x34b25);           /* call 0x100d52f8 */
            ii(0x1010_9e1d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_9e20, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9e24, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9e27, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9e2a, 3); mov(edx, memd_a32[ds, eax + 0x9]);      /* mov edx, [eax+0x9] */
            ii(0x1010_9e2d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9e31, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9e34, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9e37, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9e39, 5); calld(0x100c_ef64, -0x3aeda);           /* call 0x100cef64 */
            ii(0x1010_9e3e, 2); jmpd(0x1010_9eae, 0x6e); goto l_0x1010_9eae; /* jmp 0x10109eae */
        l_0x1010_9e40:
            ii(0x1010_9e40, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_9e45, 5); calld(Definitions.sys_new, 0x5bfb6);    /* call 0x10165e00 */
            ii(0x1010_9e4a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_9e4d, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_9e50, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_9e53, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1010_9e57, 2); if(jzd(0x1010_9e97, 0x3e)) goto l_0x1010_9e97; /* jz 0x10109e97 */
            ii(0x1010_9e59, 5); mov(eax, 0xf0);                         /* mov eax, 0xf0 */
            ii(0x1010_9e5e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_9e5f, 5); mov(ecx, 0x12c);                        /* mov ecx, 0x12c */
            ii(0x1010_9e64, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_9e68, 3); imul(ebx, ebx, 0x13);                   /* imul ebx, ebx, 0x13 */
            ii(0x1010_9e6b, 3); add(ebx, memd_a32[ss, ebp - 0xc]);      /* add ebx, [ebp-0xc] */
            ii(0x1010_9e6e, 3); mov(ebx, memd_a32[ds, ebx + 0x5]);      /* mov ebx, [ebx+0x5] */
            ii(0x1010_9e71, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_9e74, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9e78, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9e7b, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9e7e, 3); mov(edx, memd_a32[ds, eax + 0x3]);      /* mov edx, [eax+0x3] */
            ii(0x1010_9e81, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_9e84, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_9e87, 5); calld(0x100c_e39d, -0x3baef);           /* call 0x100ce39d */
            ii(0x1010_9e8c, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_9e8f, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_9e92, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_9e95, 2); jmpd(0x1010_9e9d, 0x6); goto l_0x1010_9e9d; /* jmp 0x10109e9d */
        l_0x1010_9e97:
            ii(0x1010_9e97, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_9e9a, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1010_9e9d:
            ii(0x1010_9e9d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9ea1, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9ea4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_9ea7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_9ea9, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_9eac, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1010_9eae:
            ii(0x1010_9eae, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9eb2, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9eb5, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9eb8, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1010_9ebb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9ebf, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9ec2, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9ec5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9ec7, 5); calld(0x100d_5134, -0x34d98);           /* call 0x100d5134 */
            ii(0x1010_9ecc, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9ed0, 6); lea(edx, eax + 0x7000);                 /* lea edx, [eax+0x7000] */
            ii(0x1010_9ed6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9eda, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9edd, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9ee0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9ee2, 5); calld(0x100d_5164, -0x34d83);           /* call 0x100d5164 */
            ii(0x1010_9ee7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9eeb, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9eee, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_9ef1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_9ef3, 3); mov(edx, memd_a32[ds, edx + 0xf]);      /* mov edx, [edx+0xf] */
            ii(0x1010_9ef6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_9ef9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9efd, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f00, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f03, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9f05, 5); calld(0x100d_50d4, -0x34e36);           /* call 0x100d50d4 */
            ii(0x1010_9f0a, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1010_9f0f, 2); if(jzd(0x1010_9f1a, 0x9)) goto l_0x1010_9f1a; /* jz 0x10109f1a */
            ii(0x1010_9f11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_9f14, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_9f18, 2); if(jzd(0x1010_9f1c, 0x2)) goto l_0x1010_9f1c; /* jz 0x10109f1c */
        l_0x1010_9f1a:
            ii(0x1010_9f1a, 2); jmpd(0x1010_9f50, 0x34); goto l_0x1010_9f50; /* jmp 0x10109f50 */
        l_0x1010_9f1c:
            ii(0x1010_9f1c, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_9f21, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9f25, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f28, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f2b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9f2d, 5); calld(0x100d_5194, -0x34d9e);           /* call 0x100d5194 */
            ii(0x1010_9f32, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9f36, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f39, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f3c, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1010_9f3f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9f43, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f46, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f49, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9f4b, 5); calld(0x100d_5164, -0x34dec);           /* call 0x100d5164 */
        l_0x1010_9f50:
            ii(0x1010_9f50, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_9f53, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1010_9f56, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9f5a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f5d, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f60, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9f62, 5); calld(0x100c_f85c, -0x3a70b);           /* call 0x100cf85c */
            ii(0x1010_9f67, 5); calld(0x100d_51e4, -0x34d88);           /* call 0x100d51e4 */
            ii(0x1010_9f6c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_9f6e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_9f70, 5); calld(0x100d_5204, -0x34d71);           /* call 0x100d5204 */
            ii(0x1010_9f75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_9f77, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_9f79, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9f7d, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9f80, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_9f83, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9f85, 5); calld(0x100c_fa7c, -0x3a50e);           /* call 0x100cfa7c */
            ii(0x1010_9f8a, 5); jmpd(0x1010_9d32, -0x25d); goto l_0x1010_9d32; /* jmp 0x10109d32 */
        l_0x1010_9f8f:
            ii(0x1010_9f8f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_9f92, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_9f95, 5); calld(Definitions.sys_display_draw_0, 0x5d4ea); /* call 0x10167484 */
            ii(0x1010_9f9a, 5); calld(/* sys */ 0x1016_bcc4, 0x61d25);  /* call 0x1016bcc4 */
            ii(0x1010_9f9f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_9fa1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_9fa2, 1); popd(edi);                              /* pop edi */
            ii(0x1010_9fa3, 1); popd(esi);                              /* pop esi */
            ii(0x1010_9fa4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_9fa5, 1); retd(); return;                         /* ret */
        }
    }
}